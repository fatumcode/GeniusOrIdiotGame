

using Newtonsoft.Json;

namespace GeniyIdiotClassLibrary
{

    public class QuestionsStorage
    {

        private string path = "Questions.json";

        public QuestionsStorage()
        {
            if (!FileProvider.Exist(path))
            {
                var basicQuestions = new List<Question>();
                basicQuestions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                basicQuestions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9));
                basicQuestions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                basicQuestions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?", 60));
                basicQuestions.Add(new Question("Пять свечей горело, две потухли. Сколько свечей осталось?", 2));
                basicQuestions.Add(new Question("test1", 1));
                basicQuestions.Add(new Question("test2", 2));

                Save(basicQuestions);
            }
        }


        public List<Question> GetQuestions()
        {
            var value = FileProvider.Get(path);
            var questions = JsonConvert.DeserializeObject<List<Question>>(value);
            return questions;
        }

        public void Add(Question question)
        {
            var questions = GetQuestions();
            questions.Add(question);
            Save(questions);
        }

        public void Delete(int questionIndex)
        {
            var questions = GetQuestions();
            questions.RemoveAt(questionIndex);
            Save(questions);
        }

        private void Save(List<Question> questions)
        {
            FileProvider.Delete(path);

            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(path, jsonData);
        }
    }
}