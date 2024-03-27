using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartQuiz
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void registration_label_Click(object sender, EventArgs e)
        {

        }

        private void confirmRegisterBut_Click(object sender, EventArgs e)
        {
            Program.registerForm.Hide();
            Program.userTestForm.Show();
        }
    }
}
