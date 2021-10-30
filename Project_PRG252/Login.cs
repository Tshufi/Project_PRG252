using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PRG252
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReg_LogIn_Click(object sender, EventArgs e)
        {
            Registration sf = new Registration();
            sf.Show();
            this.Hide();
        }

        private void btnAdd_LogIn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
