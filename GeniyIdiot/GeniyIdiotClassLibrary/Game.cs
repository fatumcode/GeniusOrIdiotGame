
namespace GeniyIdiotClassLibrary
{
    public class Game
    {
        private QuestionsStorage questionsStorage;
        private List<Question> questions;
        private Question currentQuestion;
        private int countQuestion;
        public User user;
        private int questionNumber = 0;
        public Game(User user)
        {
            this.user = user;
            questionsStorage = new QuestionsStorage();
            questions = questionsStorage.GetQuestions();
            countQuestion = questions.Count;
        }
        public List<Question> GetAll()
        {
            return questions = questionsStorage.GetQuestions();
        }

        public Question GetNextQuestion()
        {
            var random = new Random();
            var randomQuestionIndex = random.Next(0, questions.Count);
            currentQuestion = questions[randomQuestionIndex];
            questionNumber++;
            return currentQuestion;
        }

        public string GetQuestionNumberText()
        {
            return "Вопрос№" + questionNumber;
        }

        public void AcceptAnswer (int userAnswer)
        {
            var rightAnswer = currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                user.CountRightAnswers++;
            }
            questions.Remove(currentQuestion);
        }

        public bool End()
        {
            return questions.Count == 0;
        }
        public string CalculateDiagnose()
        {
            user.FinalDiagnosis = DiagnoseCalculator.Calculate(user.CountRightAnswers, countQuestion);
            UsersResultStorage.Append(user);
            return User.Result(user.UserName, user.FinalDiagnosis);
        }

        public void AddNewQuestion(Question question)
        {
            questionsStorage.Add(question);
        }

        public void DeleteQuestion(int questionIndex)
        {
            questionsStorage.Delete(questionIndex);
        }
    }
}
