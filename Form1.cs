namespace SmartQuiz
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void registerBut_Click(object sender, EventArgs e)
        {
            Program.authForm.Hide();
            Program.registerForm.Show();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void auth_label_Click(object sender, EventArgs e)
        {

        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (Program.authForm.currLogin().Text == "admin" && Program.authForm.currPassword().Text == "admin")
            {
                Program.authForm.Hide();
                Program.questionsDesignerForm.Show();
                return;
            }

            Program.authForm.Hide();
            Program.userTestForm.Show();

        }
    }
}

