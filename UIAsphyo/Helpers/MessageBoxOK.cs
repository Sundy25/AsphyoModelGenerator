using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAsphyo.Helpers {
    public partial class MessageBoxOK : MetroFramework.Forms.MetroForm {
        public MessageBoxOK(String strMensaje) {
            InitializeComponent();

            String[] words = strMensaje.Trim().Split(' ');
            String formated = "";
            int cont = 0;
            foreach( String item in words ) {
                if( cont > 30 ) {
                    formated += "\n";
                    this.Height += 8;
                    cont = 0;
                }
                formated += item + " ";
                cont += item.Length;
            }

            lbMsg.Text = formated;
        }

        public static void Show(String strMensaje) {
            new MessageBoxOK(strMensaje).ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
