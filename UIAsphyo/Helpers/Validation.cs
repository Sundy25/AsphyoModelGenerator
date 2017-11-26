using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Helpers {
    class Validation {

        public static void OnlyIntegerNumbers(MetroFramework.Controls.MetroTextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
            };
        }

        public static void OnlyIntegerNumbers(System.Windows.Forms.TextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
            };
        }

        public static void OnlyRealNumber(MetroFramework.Controls.MetroTextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar)) e.Handled = true; 
            };
        }

        public static void OnlyRealNumber(System.Windows.Forms.TextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsNumber(e.KeyChar) && e.KeyChar != '.' && !Char.IsControl(e.KeyChar)) e.Handled = true;
                
            };
        }

        public static void OnlyLetters(MetroFramework.Controls.MetroTextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            };
        }

        public static void OnlyLetters(System.Windows.Forms.TextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            };
        }

        public static void OnlyLettersAndSymbols(MetroFramework.Controls.MetroTextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            };
        }

        public static void OnlyLettersAndSymbols(System.Windows.Forms.TextBox txt) {
            txt.KeyPress += (sender, e) => {
                if(!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsSymbol(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)) e.Handled = true;
            };
        }

    }
}
