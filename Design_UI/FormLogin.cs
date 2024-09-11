using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admint" && txtPassword.Text == "admin")
            {
                FormMain frmMain = new FormMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Anda salah menginput username atau password");
            }


        }
    }
}
