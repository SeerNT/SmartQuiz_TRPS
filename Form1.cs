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
            Program.authForm.Opacity = 0;
            Program.authForm.ShowInTaskbar = false;
            Program.registerForm.Show();
        }

        private void Authorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();       
        }
    }
}

