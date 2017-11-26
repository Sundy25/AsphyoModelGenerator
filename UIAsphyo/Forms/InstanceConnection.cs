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
using MetroFramework;
using BEUAsphyo;
using BLAsphyo;
using BEUAsphyo.Exception;
using UIAsphyo.Helpers;

namespace View.Forms {
    public partial class InstanceConnection : MetroForm {

        enum ConnectionTypes { WindowsAuthentication = 0, SQL = 1 };

        public InstanceConnection() {
            InitializeComponent();
            cboAuthentication.DataSource = Enum.GetValues(typeof(ConnectionTypes));
            cboEngine.DataSource = Enum.GetValues(typeof(BLDatabaseEngine.DataSource));
        }

        private void cboAuthentication_SelectionChangeCommitted(object sender, EventArgs e) {
            switch( cboAuthentication.SelectedItem ) {
                case ConnectionTypes.WindowsAuthentication:
                    lbLogin.Enabled = false;
                    lbPassword.Enabled = false;
                    txtLogin.Enabled = false;
                    txtPassword.Enabled = false;
                    break;

                case ConnectionTypes.SQL:
                    lbLogin.Enabled = true;
                    lbPassword.Enabled = true;
                    txtLogin.Enabled = true;
                    txtPassword.Enabled = true;
                    break;
            }
        }

        private void cboEngine_SelectionChangeCommitted(object sender, EventArgs e) {
            switch( cboEngine.SelectedItem ) {

                case BLDatabaseEngine.DataSource.SqlServer:
                    cboAuthentication.Enabled = true;
                    cboAuthentication_SelectionChangeCommitted(sender, e);
                    txtPort.Enabled = false;
                    break;
                case BLDatabaseEngine.DataSource.MySQL:
                    cboAuthentication.Enabled = false;
                    txtLogin.Enabled = true;
                    txtPort.Enabled = true;
                    txtPassword.Enabled = true;
                    break;
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e) {
            try {
                SpinnerConnect.Visible = true;
                this.Enabled = false;
                switch( (BLDatabaseEngine.DataSource) cboEngine.SelectedItem ) {
                    case BLDatabaseEngine.DataSource.SqlServer:

                        switch( (ConnectionTypes) cboAuthentication.SelectedItem ) {
                            case ConnectionTypes.WindowsAuthentication:
                                BLDatabaseEngine.ChangeCredentials(new BEUAsphyo.Engines.BEUMicrosoftSQLServer() {
                                    IntegratedSecurity = true,
                                    DataSource = txtServerInstance.Text.Trim()
                                });
                                break;
                            case ConnectionTypes.SQL:
                                BLDatabaseEngine.ChangeCredentials(new BEUAsphyo.Engines.BEUMicrosoftSQLServer() {
                                    IntegratedSecurity = false,
                                    DataSource = txtServerInstance.Text.Trim(),
                                    Password = txtPassword.Text.Trim(),
                                    Username = txtLogin.Text.Trim()
                                });
                                break;
                        }
                        BLDatabaseEngine.EngineInUse = BLDatabaseEngine.DataSource.SqlServer;
                        break;
                    case BLDatabaseEngine.DataSource.MySQL:
                        BLDatabaseEngine.ChangeCredentials(new BEUAsphyo.Engines.BEUMySQL() {
                            ServerName = txtServerInstance.Text.Trim(),
                            Username = txtLogin.Text.Trim(),
                            Password = txtPassword.Text.Trim(),
                            Port = Convert.ToUInt32(( txtPort.Text == "" ) ? "3306" : txtPort.Text)
                        });
                        BLDatabaseEngine.EngineInUse = BLDatabaseEngine.DataSource.MySQL;
                        break;
                }


                if( await new BLServer().testConnection() ) {
                    this.Hide();
                    new Main(this, BLDatabaseEngine.EngineInUse.ToString()).Show();
                }

            }
            catch( BEUExceptionDAO ex ) { MessageBoxError.Show(ex.Message); }
            catch( BEUExceptionBL ex ) { MessageBoxError.Show(ex.Message); }
            catch( Exception ex ) { MessageBoxError.Show(ex.Message); }

            SpinnerConnect.Visible = false;
            this.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            if(MetroMessageBox.Show(this, "Are you sure do you wanna quit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 130) == DialogResult.Yes ) {
                Application.Exit();
            }
        }

        private void cleanControls(Control con) {
            foreach( Control c in con.Controls ) {

            }
            con.Enabled = true;
        }

        private void EnableControls(Control con) {
            foreach( Control c in con.Controls ) {
                EnableControls(c);
            }
            con.Enabled = true;
        }

        private void DisableControls(Control con) {
            foreach( Control c in con.Controls ) {
                DisableControls(c);
            }
            con.Enabled = false;
        }
    }
}
