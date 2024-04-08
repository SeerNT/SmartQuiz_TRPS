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
    public partial class TestChoice : Form
    {
        public TestChoice()
        {
            InitializeComponent();
        }

        private void startTest_Click(object sender, EventArgs e)
        {
            Program.userTestsMenu.Hide();
            Program.userTestForm.Show();
        }
    }
}
