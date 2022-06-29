using System;

namespace GeniyIdiotClassLibrary
{
    public class User
    {
        public string UserName;
        public int CountRightAnswers;
        public string FinalDiagnosis;

        public User(string userName)
        {
            UserName = userName;
        }

        public static string Result (string userName, string finalDiagnosis)
        {
            return $"{userName}, Ваш диагноз {finalDiagnosis}!";
        }
        public static int GetUserAnswer()
        {
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer))
                Console.WriteLine("Некорректный ввод! Принимается число  от -2147483648 до 2147483647");
            return userAnswer;
        }

    }
}