using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas
{
    public partial class UserControlNuevaPersona : UserControl
    {
        private UserControlNuevaPersonaVM userControlNuevaPersonaVM;

        public UserControlNuevaPersona()
        {
            InitializeComponent();
            this.userControlNuevaPersonaVM = new UserControlNuevaPersonaVM();
            this.DataContext = userControlNuevaPersonaVM;
        }
    }
}
