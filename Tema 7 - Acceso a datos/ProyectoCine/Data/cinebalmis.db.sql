BEGIN TRANSACTION;
DROP TABLE IF EXISTS "sesiones";
CREATE TABLE IF NOT EXISTS "sesiones" (
	"idSesion"	INTEGER,
	"pelicula"	INTEGER,
	"sala"	INTEGER,
	"hora"	TEXT,
	FOREIGN KEY("sala") REFERENCES "salas"("idSala"),
	FOREIGN KEY("pelicula") REFERENCES "peliculas"("idPelicula"),
	PRIMARY KEY("idSesion" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "ventas";
CREATE TABLE IF NOT EXISTS "ventas" (
	"idVenta"	INTEGER,
	"sesion"	INTEGER,
	"cantidad"	INTEGER,
	"pago"	TEXT,
	FOREIGN KEY("sesion") REFERENCES "sesiones"("idSesion"),
	PRIMARY KEY("idVenta" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "salas";
CREATE TABLE IF NOT EXISTS "salas" (
	"idSala"	INTEGER,
	"numero"	TEXT,
	"capacidad"	INTEGER,
	"disponible"	BOOLEAN DEFAULT (true),
	PRIMARY KEY("idSala" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "peliculas";
CREATE TABLE IF NOT EXISTS "peliculas" (
	"idPelicula"	INTEGER,
	"titulo"	TEXT,
	"descripcion"	TEXT,
	"cartel"	TEXT,
	"anyo"	INTEGER,
	"genero"	TEXT,
	"calificacion"	TEXT,
	PRIMARY KEY("idPelicula")
);
COMMIT;

INSERT INTO peliculas ( titulo, descripcion, cartel, anyo, genero, calificacion ) VALUES
 ('Oppenheimer', 'Es una película biográfica de suspense de 2023, escrita y dirigida por Christopher Nolan. Fue producida por Nolan junto a Charles Roven y Emma Thomas. Basada en American Prometheus, una biografía de 2005 escrita por Kai Bird y Martin J. Sherwin, la cinta narra la vida de J. Robert Oppenheimer, un físico teórico que fue fundamental en el desarrollo de las primeras armas nucleares como parte del Proyecto Manhattan y, por lo tanto, marcó el comienzo de la era atómica durante la Segunda Guerra Mundial. Cillian Murphy interpreta a Oppenheimer, con Emily Blunt como Katherine «Kitty» Oppenheimer, esposa de Robert, Matt Damon como el general Leslie Groves, el controlador militar de Oppenheimer, y Robert Downey Jr. como Lewis Strauss, un alto miembro de la Comisión de Energía Atómica de los Estados Unidos. El elenco del conjunto incluye a Florence Pugh, Josh Hartnett, Casey Affleck, Rami Malek y Kenneth Branagh.', 'https://jesusclase.blob.core.windows.net/2dam/oppenheimer.jpg', 2023, "Suspense,Drama,Accion", "NRM 18"),
 ('Resacon en las vegas', 'Doug Billings (Justin Bartha) va a casarse con Tracy Garner (Sasha Barrese). Doug realizará una despedida de soltero en Las Vegas con sus amigos Phil Wenneck (Bradley Cooper), Stuart "Stu" Price (Ed Helms), y el hermano de Tracy, Alan Garner (Zach Galifianakis). Doug, Phil, Alan y Stu se dirigen esa misma noche a Las Vegas donde reservan una suite en el hotel Caesars Palace. Justo antes de que comience la despedida de soltero se dirigen a la azotea del hotel donde toman unos tragos preparados por Alan. A la mañana siguiente, Phil, Stu y Alan despiertan en la suite del hotel muy aturdidos y sin recordar nada de lo que pasó la noche anterior. Los tres descubren que Doug no está en ninguna parte. A Stu le falta un diente, la suite del hotel está casi destruida, hay un tigre en el baño, al igual que un bebé dentro de un armario (al que Alan apoda "Carlos") y una gallina cuya procedencia desconocen y no le ponen ninguna importancia. Mientras se preguntaban lo que pasaba, Alan descubre en su bolsillo el diente que le falta a Stu, por lo que todos revisan sus bolsillos y ven que Phil tiene una pulsera de hospital. Los tres van a recoger el Mercedes del padre de Tracy (el auto en el que vinieron a Las Vegas). Mientras esperan, los 3 descubren el colchón de Doug clavado en una estatua. Luego de esto, el valet parking les entrega un auto patrulla en lugar del Mercedes.','https://jesusclase.blob.core.windows.net/2dam/ResaconEnLasVegas.jpg', 2009, "Comedia,Accion,Animacion,Drama,Suspense", "NRM 16"),
 ('Smile', 'Cuenta cómo, después de presenciar un incidente extraño y violento que afecta a una paciente, una psicóloga comienza a experimentar visiones terroríficas, que la alejan de la realidad y que la enfrentan a personas conocidas y desconocidas exhibiendo inquietantes sonrisas. Tendrá que enfrentarse a su pasado y descubrir qué extraña maldición o contagio está estrechando el cerco en torno a ella.', 'https://jesusclase.blob.core.windows.net/2dam/smile.jpg', 2022, "Terror,Suspense,Drama", "NRM 16"),
 ('Aquaman', 'Cuando se desata un poder antiguo, Aquaman debe forjar una alianza incómoda con un aliado poco probable para proteger la Atlántida y el mundo de una devastación irreversible. La primera parte finaliza con el personaje de Jason Momoa, Arthur Curry, consiguiendo el Tridente del Rey Atlan y convirtiéndose en el Maestro del Océano. Nicole Kidman, Atlanna en la película, se reúne con su marido muchos años después, mientras que el malvado rey Orm es encarcelado por sus actos de guerra.', 'https://jesusclase.blob.core.windows.net/2dam/Aquaman.jpg', 2023, "Accion,Drama", "NRM 12");