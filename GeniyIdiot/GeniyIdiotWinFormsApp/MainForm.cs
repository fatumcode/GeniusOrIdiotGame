using GeniyIdiotClassLibrary;
using Microsoft.VisualBasic;

namespace GeniyIdiotWinFormsApp
{
    public partial class mainForm : Form
    {

        private Game game;
        private QuestionsStorage questionsStorage;
        private static System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        private int timeLeft = 10;


        public mainForm()
        {
            InitializeComponent();
            Timer();
            questionsStorage = new QuestionsStorage();
            userAnswerTextBox.KeyDown += UserAnswerTextBox_KeyDown;
        }

        private void Timer()
        {
            var timer = MessageBox.Show("У Вас есть 10 секунд, чтобы ответить на вопрос!", "Внимание!", MessageBoxButtons.OK);
            if (timer == System.Windows.Forms.DialogResult.OK)
            {
                mainTimer.Enabled = true;
                mainTimer.Start();
            }
        }
        private void UserAnswerTextBox_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                NextButton_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var user = new User(AddNameForm.userName);
            game = new Game(user);
            ShowNextQuestion();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {

            int userAnswer;
            while (!int.TryParse(userAnswerTextBox.Text, out userAnswer))
            {
                MessageBox.Show("Некорректный ввод! Принимается число  от -2147483648 до 2147483647");
                return;
            }

            game.AcceptAnswer(userAnswer);
            DialogResult newTest;

            if (game.End())
            {
                mainTimer.Stop();
                var message = game.CalculateDiagnose();
                MessageBox.Show(message, "Результат");
                newTest = MessageBox.Show(
                    "Желаете повторить тестирование?",
                    "Начать сначала",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (newTest == DialogResult.Yes)
                {
                    Application.Restart();
                }
                return;
            }

            userAnswerTextBox.Clear();
            ShowNextQuestion();
            userAnswerTextBox.Focus();
            timeLeft = 10;
        }

        private void ShowNextQuestion()
        {
            var currentQuestion = game.GetNextQuestion();
            questionTextLabel.Text = currentQuestion.Text;
            questionNumberLabel.Text = game.GetQuestionNumberText();
        }

        private void PreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = new previousResultsForm();
            results.Show();
        }

        private void AddNewQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addQuestion = new AddQuestionForm(game);
            addQuestion.Show();
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var deleteQuestion = new DeleteQuestionForm(game);
            deleteQuestion.Show();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exit = MessageBox.Show("Выйти из приложения?", "Выход", MessageBoxButtons.YesNo);
            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;

        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            timeLeft--;
            leftTimeLabel.Text = $"Осталось: {timeLeft} сек!";
            if (timeLeft == 0)
            {
                game.AcceptAnswer(-999);
                DialogResult newTest;

                if (game.End())
                {
                    mainTimer.Stop();
                    var message = game.CalculateDiagnose();
                    MessageBox.Show(message, "Результат");
                    newTest = MessageBox.Show(
                        "Желаете повторить тестирование?",
                        "Начать сначала",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (newTest == DialogResult.Yes)
                    {
                        Application.Restart();
                    }
                    return;
                }
                userAnswerTextBox.Clear();
                ShowNextQuestion();
                userAnswerTextBox.Focus();

                timeLeft = 10;
            }
        }
    }
}