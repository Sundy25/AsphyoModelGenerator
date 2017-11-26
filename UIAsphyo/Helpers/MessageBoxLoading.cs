using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace View.Helpers {
    public partial class MessageBoxLoading : MetroForm {

        private static MessageBoxLoading load;

        public MessageBoxLoading(String strMensaje) {
            InitializeComponent();
            for(int i = 0; i < strMensaje.Length; i += 40) { // SE insertan saltos a la cadena y aumenta el height por cada uno (Valor aun no testeado)
                strMensaje = strMensaje.Insert(i, "\n");
                this.Height += 10;
            }
            lbMsg.Text = strMensaje;
        }

        public static void Show(IWin32Window owner, String message) {
            load = new MessageBoxLoading(message);
            load.ShowDialog(owner);
        }

        public static void Show(String message) {
            load = new MessageBoxLoading(message);
            load.ShowDialog();
        }

        
        public static void Exit() {
            load.Close();
            load = null;
        }

    }
}
