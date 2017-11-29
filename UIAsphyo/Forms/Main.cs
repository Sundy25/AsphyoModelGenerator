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
using MetroFramework.Controls;
using BEUAsphyo.Exception;
using System.IO;
using UIAsphyo.Helpers;
using System.Threading;

namespace View.Forms {
    public partial class Main : MetroForm {

        private TreeView TableSelect;
        private TreeNode RootDatabaseNode;
        private String Path;
        private enum Languages { PHP, Java}

        public Main() {
            InitializeComponent();
            cboLanguages.Enabled = false;
            this.TableSelect = new TreeView();
            this.RootDatabaseNode = new TreeNode();
            this.Path = "";
        }

        private async void Main_Load(object sender, EventArgs e) {
            DisableControls(pnMain);
            cboDatabases.DataSource = await new BLAsphyo.BLServer().getListDatabases();
            cboDatabases.DisplayMember = "Database";
            cboLanguages.DataSource = Enum.GetNames(typeof(Languages));
            cboLanguages.SelectedItem = Languages.PHP;
            cboLanguages.Enabled = false;
            rbtnGenerateAll.Checked = true;
            cboDatabases_SelectionChangeCommitted(null, null);

        }

        private List<String> getSelectedTables() {
            return RootDatabaseNode.Nodes.Cast<TreeNode>().Where(x => x.Checked).Select(x => x.Text).ToList();
        }

        private async void cboDatabases_SelectionChangeCommitted(object sender, EventArgs e) {
            try {
                this.RootDatabaseNode = new TreeNode();
                this.TableSelect = new TreeView();
                this.TableSelect.ForeColor = MetroColors.White;
                this.TableSelect.BackColor = this.BackColor;
                this.TableSelect.BorderStyle = System.Windows.Forms.BorderStyle.None;
                TableSelect.AfterCheck += (l, p) => {
                    TreeNode parent = p.Node.Parent;

                    if( p.Action == TreeViewAction.ByKeyboard || p.Action == TreeViewAction.ByMouse ) {
                        if( parent != null ) {
                            if( parent.Nodes.Cast<TreeNode>().Any(x => x.Checked == false) ) {
                                parent.Checked = false;
                            } else {
                                parent.Checked = true;
                            }
                            return;
                        }

                        if( parent is null ) {
                            foreach( TreeNode child in p.Node.Nodes ) {
                                child.Checked = p.Node.Checked;
                            }
                            return;
                        }
                    }

                };
                List<String> ListTables = await new BLAsphyo.BLServer().getListTables(cboDatabases.Text);
                RootDatabaseNode.Text = cboDatabases.Text;
                foreach( String Table in ListTables ) {
                    RootDatabaseNode.Nodes.Add(new TreeNode(Table));
                }
                
                TableSelect.Nodes.Add(RootDatabaseNode);
                TableSelect.CheckBoxes = true;
                TableSelect.ExpandAll();
                TableSelect.Dock = DockStyle.Fill;
                pnTree.Controls.Clear();
                pnTree.Controls.Add(TableSelect);
                EnableControls(pnMain);
            }
            catch( BEUExceptionDAO ex ) {
                Excecuted();
                MessageBoxError.Show(ex.Message);
            }
            catch( BEUExceptionBL ex ) {
                Excecuted();
                MessageBoxError.Show(ex.Message);
            }
            this.RootDatabaseNode.Nodes.Cast<TreeNode>().All(x => x.Checked = true);
            this.RootDatabaseNode.Checked = true;
        }

        private void btnSavePath_Click(object sender, EventArgs e) {
            FolderBrowserDialog oForm = new FolderBrowserDialog();
            oForm.RootFolder = Environment.SpecialFolder.MyComputer;
            oForm.Description = "Please, select the forder where you wanna save the Models";
            oForm.ShowNewFolderButton = true;
            if( ( oForm.ShowDialog() == DialogResult.OK ) ) {
                this.Path = oForm.SelectedPath;
                ToolTip yourToolTip = new ToolTip();
                yourToolTip.SetToolTip(lbRoute, oForm.SelectedPath);
                lbRoute.Text = oForm.SelectedPath;
            } else {
                if( this.Path == "" ) {
                    MessageBoxError.Show("Please, select a route");
                }
            }
        }

        private async void btnGenerate_Click(object sender, EventArgs e) {
            try {
                DisableControls(pnMain);
                DisableControls(pnLeft);
                DisableControls(pnBar);
                spGenerating.Enabled = true;
                lbGenerating.Enabled = true;
                spGenerating.Visible = true;
                lbGenerating.Visible = true;

                if( rbtnGenerateAll.Checked ) {
                    await new BLAsphyo.BLGenerator().FormatedBEUClass(this.Path, cboDatabases.Text, getSelectedTables(), chUseAsphyo.Checked, rbtnGenerateOnlyModels.Checked);
                    await new BLAsphyo.BLGenerator().FormatedDAOClass(this.Path, cboDatabases.Text, getSelectedTables(), chUseAsphyo.Checked);
                } else {
                    await new BLAsphyo.BLGenerator().FormatedBEUClass(this.Path, cboDatabases.Text, getSelectedTables(), chUseAsphyo.Checked, rbtnGenerateOnlyModels.Checked);
                }
                Excecuted();
                MessageBoxOK.Show("All the tables has been generated success");
            }
            catch(BEUExceptionBL ex ) {
                Excecuted();
                MessageBoxError.Show(ex.Message);
            }
            catch( Exception ex ) {
                Excecuted();
                MessageBoxError.Show(ex.Message);
            }
        }

        private void btnChangeConnection_Click(object sender, EventArgs e) {
            Thread t = new Thread(() => {
                if( new InstanceConnection().ShowDialog() == DialogResult.OK )
                    Application.Run(new Main());
            }); 
            t.Start();
            this.Close();
        }

        private void Excecuted() {
            spGenerating.Enabled = false;
            lbGenerating.Enabled = false;
            spGenerating.Visible = false;
            lbGenerating.Visible = false;
            EnableControls(pnMain);
            EnableControls(pnLeft);
            EnableControls(pnBar);
        }

        private void DisableControls(Control con) {
            foreach( Control c in con.Controls ) {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con) {
            foreach( Control c in con.Controls ) {
                EnableControls(c);
            }
            con.Enabled = true;
        }
    }
}
