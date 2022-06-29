using GeniyIdiotClassLibrary;

namespace GeniyIdiotWinFormsApp
{
    public partial class DeleteQuestionForm : Form
    {
        private QuestionsStorage questionsStorage = new QuestionsStorage();
        private List<Question> questions;
        Game game;
        
        public DeleteQuestionForm(Game game)
        {
            InitializeComponent();
            questions = questionsStorage.GetQuestions();
            ShowQuestions();
            this.game = game;
           
        }

       
        public void ShowQuestions()
        {
            var questionCount = 1;
            var Questions = questionsStorage.GetQuestions();
            foreach (var question in Questions)
            {
                questionsShowDataGridView.Rows.Add(questionCount, question.Text, question.Answer);
                questionCount++;
            }
        }


        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            var index = questionsShowDataGridView.CurrentRow.Index;
            questionsShowDataGridView.Rows.RemoveAt(index);
            game.DeleteQuestion(index);
            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
