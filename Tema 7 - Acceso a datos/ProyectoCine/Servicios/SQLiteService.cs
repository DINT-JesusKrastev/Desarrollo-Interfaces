using Microsoft.Data.Sqlite;
using ProyectoCine.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProyectoCine
{
    public static class SQLiteService
    {
        private static SqliteConnection? conexion = null;

        public static void Connect()
        {
            if(conexion == null)
            {
                conexion = new SqliteConnection("Data Source=../../../data/cinebalmis.db");
                conexion.Open();
            }
        }

        public static void Disconect()
        {
            if (conexion != null) conexion.Close();
        }

        public static void RestartBD()
        {
            Connect();
            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = File.ReadAllText("../../../data/cinebalmis.db.sql");
            comando.ExecuteNonQuery();
        }

        public static ObservableCollection<Pelicula> GetCartelera()
        {
            Connect();
            ObservableCollection<Pelicula> cartelera = new ObservableCollection<Pelicula>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM peliculas";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int idPelicula = (int) (long) lector["idPelicula"];
                    string titulo = (string) lector["titulo"];
                    string descripcion = (string)lector["descripcion"];
                    string cartel = (string) lector["cartel"];
                    int anyo = (int) (long) lector["anyo"];
                    string calificacion = (string)lector["calificacion"];
                    ObservableCollection<string> generos = new ObservableCollection<string>(((string)lector["genero"]).Split(','));
                    cartelera.Add(new Pelicula(idPelicula, titulo, descripcion, cartel, anyo, generos, calificacion));
                }
            }
            lector.Close();

            return cartelera;
        }

        public static Pelicula GetPelicula(int idPelicula)
        {
            Connect();
            Pelicula pelicula = new Pelicula(-1, "", "", "", -1, new ObservableCollection<string>(), "");

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM peliculas WHERE idpelicula = " + idPelicula;
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idPelicula"];
                    string titulo = (string)lector["titulo"];
                    string descripcion = (string)lector["descripcion"];
                    string cartel = (string)lector["cartel"];
                    int anyo = (int)(long)lector["anyo"];
                    string calificacion = (string)lector["calificacion"];
                    ObservableCollection<string> generos = new ObservableCollection<string>(((string)lector["genero"]).Split(','));
                    pelicula = new Pelicula(id, titulo, descripcion, cartel, anyo, generos, calificacion);
                }
            }
            lector.Close();

            return pelicula;
        }

        public static ObservableCollection<Sala> GetSalas()
        {
            Connect();
            ObservableCollection<Sala> salas = new ObservableCollection<Sala>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM salas";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSala"];
                    string numero = (string)lector["numero"];
                    int capacidad = (int)(long)lector["capacidad"];
                    bool disponible = ((int)(long)lector["disponible"] == 1); 
                    salas.Add(new Sala(id, numero, capacidad, disponible));
                }
            }
            lector.Close();

            return salas;
        }

        public static ObservableCollection<Sala> GetSalasDisponibles()
        {
            Connect();
            ObservableCollection<Sala> salas = new ObservableCollection<Sala>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM salas WHERE disponible = true";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSala"];
                    string numero = (string)lector["numero"];
                    int capacidad = (int)(long)lector["capacidad"];
                    bool disponible = ((int)(long)lector["disponible"] == 1);
                    salas.Add(new Sala(id, numero, capacidad, disponible));
                }
            }
            lector.Close();

            return salas;
        }

        public static int GetOcupacionSala(int? idSala)
        {
            Connect();
            int ocupacion = 0;

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText =
                "SELECT SUM(ventas.cantidad) AS 'ocupacion'" +
                "FROM salas JOIN sesiones JOIN ventas " +
                "ON salas.idSala = sesiones.sala AND sesiones.idSesion = ventas.sesion " +
                "WHERE salas.idSala = " + idSala + " " +
                "GROUP BY sesiones.idSesion";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    ocupacion = (int)(long)lector["ocupacion"];
                }
            }

            return ocupacion;
        }

        public static bool InsertSala(Sala sala)
        {
            Connect();
            bool insertado = false;

            // Comprobar si ya hay un número de sala igual
            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM salas WHERE numero = " + sala.Numero;
            SqliteDataReader lector = comando.ExecuteReader();

            if (!lector.HasRows)
            {
                comando = conexion.CreateCommand();
                comando.CommandText = "INSERT INTO salas VALUES (null,@numero,@capacidad,@disponible)";
                comando.Parameters.Add("@numero", SqliteType.Integer);
                comando.Parameters.Add("@capacidad", SqliteType.Integer);
                comando.Parameters.Add("@disponible", SqliteType.Integer);

                comando.Parameters["@numero"].Value = sala.Numero;
                comando.Parameters["@capacidad"].Value = sala.Capacidad;
                comando.Parameters["@disponible"].Value = sala.Disponible;

                insertado = comando.ExecuteNonQuery() == 1;
            }

            return insertado;
        }

        public static bool UpdateSala(Sala sala)
        {
            Connect();
            bool actualizado = false;
            
            // Comprobar si existe la sala
            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM salas WHERE idSala = " + sala.Id;
            SqliteDataReader lector = comando.ExecuteReader();

            if (lector.HasRows)
            {
                comando = conexion.CreateCommand();
                comando.CommandText =
                    "UPDATE salas SET " +
                        "numero=@numero," +
                        "capacidad=@capacidad," +
                        "disponible=@disponible " +
                        "WHERE idSala=" + sala.Id;
                comando.Parameters.Add("@numero", SqliteType.Text);
                comando.Parameters.Add("@capacidad", SqliteType.Integer);
                comando.Parameters.Add("@disponible", SqliteType.Integer);

                comando.Parameters["@numero"].Value = sala.Numero;
                comando.Parameters["@capacidad"].Value = sala.Capacidad;
                comando.Parameters["@disponible"].Value = sala.Disponible;

                actualizado = comando.ExecuteNonQuery() == 1;
            }

            return actualizado;
        }

        public static Sala GetSala(int idSala)
        {
            Connect();
            Sala sala = new Sala(-1, "0", 0, false);

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM salas WHERE idSala = " + idSala;
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSala"];
                    string numero = (string)lector["numero"];
                    int capacidad = (int)(long)lector["capacidad"];
                    bool disponible = ((int)(long)lector["disponible"] == 0);
                    sala = new Sala(id, numero, capacidad, disponible);
                }
            }
            lector.Close();

            return sala;
        }

        public static ObservableCollection<Ticket> GetTickets()
        {
            Connect();
            ObservableCollection<Ticket> tickets = new ObservableCollection<Ticket>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM ventas";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idVenta"];
                    int sesion = (int)(long)lector["sesion"];
                    int cantidad = (int)(long)lector["cantidad"];
                    string pago = (string)lector["pago"];
                    tickets.Add(new Ticket(id, sesion, cantidad, pago));
                }
            }
            lector.Close();

            return tickets;
        }

        public static void DeleteAllTickets()
        {
            Connect();
            SqliteCommand comando = conexion.CreateCommand();

            foreach (Ticket ticket in GetTickets()) 
            {
                comando.CommandText = "DELETE FROM ventas WHERE idVenta = " + ticket.Id;
                comando.ExecuteNonQuery();
            }
        }

        public static Ticket GetTicket(int idTicket)
        {
            Connect();
            Ticket ticket = new Ticket(-1, 0, 0, "");

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM ventas WHERE idVenta = " + idTicket;
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idVenta"];
                    int sesion = (int)(long)lector["sesion"];
                    int cantidad = (int)(long)lector["cantidad"];
                    string pago = (string)lector["pago"];
                    ticket = new Ticket(id, sesion, cantidad, pago);
                }
            }
            lector.Close();

            return ticket;
        }

        public static bool InsertTicket(Ticket ticket)
        {
            Connect();
            bool insertado = false;
            // Comprobar si la sala esta llena
            Sesion sesion = getSesion(ticket.Sesion);
            Sala sala = GetSala(sesion.Sala);
            int ocupacionSala = (sesion != null && sala != null) ? GetOcupacionSala(sala.Id) : -1;

            if (ocupacionSala != -1 && ocupacionSala < sala.Capacidad)
            {
                SqliteCommand comando = conexion.CreateCommand();
                comando = conexion.CreateCommand();
                comando.CommandText = "INSERT INTO ventas VALUES (null,@sesion,@cantidad,@pago)";
                comando.Parameters.Add("@sesion", SqliteType.Integer);
                comando.Parameters.Add("@cantidad", SqliteType.Integer);
                comando.Parameters.Add("@pago", SqliteType.Text);

                comando.Parameters["@sesion"].Value = ticket.Sesion;
                comando.Parameters["@cantidad"].Value = ticket.Cantidad;
                comando.Parameters["@pago"].Value = ticket.Pago;

                insertado = comando.ExecuteNonQuery() == 1;
            }

            return insertado;
        }

        public static ObservableCollection<Sesion> getSesiones()
        {
            Connect();
            ObservableCollection<Sesion> sesiones = new ObservableCollection<Sesion>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM sesiones";
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSesion"];
                    int pelicula = (int)(long)lector["pelicula"];
                    int sala = (int)(long)lector["sala"];
                    string hora = (string)lector["hora"];
                    sesiones.Add(new Sesion(id, sala, hora, pelicula));
                }
            }
            lector.Close();

            return sesiones;
        }

        public static ObservableCollection<Sesion> getSesionesPorPelicula(int idPelicula)
        {
            Connect();
            ObservableCollection<Sesion> sesiones = new ObservableCollection<Sesion>();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM sesiones WHERE pelicula = " + idPelicula;
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSesion"];
                    int pelicula = (int)(long)lector["pelicula"];
                    int sala = (int)(long)lector["sala"];
                    string hora = (string)lector["hora"];
                    sesiones.Add(new Sesion(id, sala, hora, pelicula));
                }
            }
            lector.Close();

            return sesiones;
        }

        public static Sesion getSesion(int idSesion)
        {
            Connect();
            Sesion sesion = new Sesion(-1, 0, "", 0);

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM sesiones WHERE idSesion = " + idSesion;
            SqliteDataReader lector = comando.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    int id = (int)(long)lector["idSesion"];
                    int pelicula = (int)(long)lector["pelicula"];
                    int sala = (int)(long)lector["sala"];
                    string hora = (string)lector["hora"];
                    sesion = new Sesion(id, sala, hora, pelicula);
                }
            }
            lector.Close();

            return sesion;
        }

        public static bool InsertSesion(Sesion sesion)
        {
            Connect();
            bool insertado = false;

            // Comprobar el número de sesiones asociado a una sala
            SqliteCommand comando = conexion.CreateCommand();
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM sesiones WHERE pelicula = " + sesion.Pelicula;
            int total = Convert.ToInt32(comando.ExecuteScalar());
            
            // Comprobar si esta disponible una sala
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT disponible FROM salas WHERE idSala = " + sesion.Sala;
            bool disponible = Convert.ToBoolean(comando.ExecuteScalar());
            Trace.WriteLine(sesion.Sala);

            if (total < 3 && disponible)
            {
                comando = conexion.CreateCommand();
                comando.CommandText = "INSERT INTO sesiones VALUES (null,@pelicula,@sala,@hora)";
                comando.Parameters.Add("@pelicula", SqliteType.Integer);
                comando.Parameters.Add("@sala", SqliteType.Integer);
                comando.Parameters.Add("@hora", SqliteType.Text);

                comando.Parameters["@pelicula"].Value = sesion.Pelicula;
                comando.Parameters["@sala"].Value = sesion.Sala;
                comando.Parameters["@hora"].Value = sesion.Hora;

                insertado = comando.ExecuteNonQuery() == 1;
            }

            return insertado;
        }

        public static bool UpdateSesion(Sesion sesion)
        {
            Connect();
            bool actualizado = false;

            // Comprobar el número de sesiones asociado a una sala
            SqliteCommand comando = conexion.CreateCommand();
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT COUNT(*) FROM sesiones WHERE pelicula = " + sesion.Pelicula;
            int total = Convert.ToInt32(comando.ExecuteScalar());

            // Comprobar si esta disponible una sala
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT disponible FROM salas WHERE idSala = " + sesion.Sala;
            bool disponible = Convert.ToBoolean(comando.ExecuteScalar());

            // Comprobar si existe la sala
            comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM sesiones WHERE idSesion = " + sesion.Id;
            SqliteDataReader lector = comando.ExecuteReader();

            if (lector.HasRows && total < 3 && disponible)
            {
                comando = conexion.CreateCommand();
                comando.CommandText =
                    "UPDATE sesiones SET pelicula=@pelicula, sala=@sala, hora=@hora WHERE idSesion = " + sesion.Id;
                    //"UPDATE sesiones SET " +
                    //    "pelicula=@pelicula," +
                    //    "sala=@sala," +
                    //    "hora=@hora" +
                    //    "WHERE idSesion=" + sesion.Id;
                comando.Parameters.Add("@pelicula", SqliteType.Integer);
                comando.Parameters.Add("@sala", SqliteType.Integer);
                comando.Parameters.Add("@hora", SqliteType.Text);

                comando.Parameters["@pelicula"].Value = sesion.Pelicula;
                comando.Parameters["@sala"].Value = sesion.Sala;
                comando.Parameters["@hora"].Value = sesion.Hora;

                actualizado = comando.ExecuteNonQuery() == 1;
            }

            return actualizado;
        }

        public static bool DeleteSesion(Sesion sesion)
        {
            Connect();
            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = "DELETE FROM sesiones WHERE idSesion = " + sesion.Id;

            return comando.ExecuteNonQuery() == 1;
        }
    }
}