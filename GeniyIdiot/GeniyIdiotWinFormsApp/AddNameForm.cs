
namespace GeniyIdiotWinFormsApp
{
    public partial class AddNameForm : Form
    {
        public static string userName = "Безымянный";
        public AddNameForm()
        {
            InitializeComponent();
            enterNameTextBox.KeyDown += EnterNameTextBox_KeyDown;
        }

        private void EnterNameTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NextButton_Click(sender, e);
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string nameUser = enterNameTextBox.Text;
            if (nameUser == "")
            {
                MessageBox.Show("Вы не ввели имя!", "Ошибка!", MessageBoxButtons.OK);
                return;
            }
            else
            {
                userName = nameUser;
                this.Close();
                
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
