
namespace GeniyIdiotClassLibrary
{
    public class DiagnoseCalculator
    {
        public static string Calculate(int countRightAnswers, int countQuestions)
        {
            var diagnoses = GetAll();
            var answerCount = (diagnoses.Count() -1)/ Convert.ToDouble(countQuestions) * countRightAnswers;
            var rightAnswerCount = Convert.ToInt32(Math.Round(answerCount));
            return  diagnoses[rightAnswerCount];
            
        } 
        private static string[] GetAll()
        {
            var diagnoses = new string[]
            {
            "кретин",
            "идиот",
            "дурак",
            "нормальный",
            "талант",
            "гений",
            };
            return diagnoses;
        }
    }
}
