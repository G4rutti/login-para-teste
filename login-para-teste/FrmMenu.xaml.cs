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
using System.Windows.Shapes;

namespace login_para_teste
{
    /// <summary>
    /// Lógica interna para FrmMenu.xaml
    /// </summary>
    public partial class FrmMenu : Window
    {
        Usuario usuario;
        public FrmMenu()
        {
            InitializeComponent();
        }

        public FrmMenu(Usuario usuarioLogado)
        {
            InitializeComponent();
            usuario = usuarioLogado;
            usuario = usuarioLogado;
        }
    }
}
