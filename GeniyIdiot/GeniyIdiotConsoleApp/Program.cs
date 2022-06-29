using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.Timers;

namespace GeniyIdiotConsoleApp
{

    public class Program
    {
        private static int ticks = 1;
        private static Timer timer;

        static void Main(string[] args)
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.Clear();

                Console.WriteLine("Приветствую! Укажите свое имя: ");
                var user = new User(Console.ReadLine());
                var game = new Game(user);

                Console.WriteLine($"{user.UserName}, Вы желаете посмотреть предыдущие результаты?");
                if (UserChoice())
                    ShowPreviousResults();
                Console.WriteLine("Внимание! На ответ у Вас будет всего 10 секунд!");
                while (!game.End())
                {
                    timer = new Timer(1000);
                    timer.Elapsed += timerEnd;
                    timer.Start();
                    var currentQuestion = game.GetNextQuestion();
                    Console.WriteLine(game.GetQuestionNumberText());

                    Console.WriteLine(currentQuestion.Text);
                    var userAnswer = User.GetUserAnswer();
                    if (ticks == 10)
                    {
                        Console.WriteLine("Вы не успели ответить за 10 секунд! Ответ не защитан!");
                        userAnswer = -1;
                    }
                    game.AcceptAnswer(userAnswer);
                    timer.Stop();
                    ticks = 1;
                }
                var message = game.CalculateDiagnose();
                Console.WriteLine(message);

                Console.WriteLine($"{user.UserName}, Вы желаете добавить новый вопрос?");
                if (UserChoice())
                {
                    var newQuestion = GetNewQuestion();
                    game.AddNewQuestion(newQuestion);
                }

                Console.WriteLine($"{user.UserName}, Желаете удалить какой-то из вопросов?");
                if (UserChoice())
                {
                    var deletedQuestion = GetDeletedQuestionIndex(game.GetAll());
                    game.DeleteQuestion(deletedQuestion);
                }

                Console.WriteLine("Если желаете пройти тест снова, то нажмите любую клавишу");
                Console.WriteLine("Чтобы завершить программу - нажмите Escape");
                btn = Console.ReadKey();
            }
            while (!(btn.Key == ConsoleKey.Escape));
        }
        static void timerEnd(object sender, ElapsedEventArgs e)
        {
            if (ticks == 10)
            {
                Console.WriteLine("10.");
                timer.Stop();
                return;
            }
            Console.Write(ticks + ". ");
            ticks++;
        }

        static bool UserChoice()
        {
            Console.WriteLine("Напише ДА  или Нет");
            var answer = Console.ReadLine().ToLower();
            if (answer == "да")
                return true;
            else
                return false;

        }
        static void ShowPreviousResults()
        {
            var value = UsersResultStorage.GetAll();
            if (value.Count == 0)
            {
                Console.WriteLine("Упс, база результатов пока пуста.");
            }
            else
            {
                Console.WriteLine("|| {0,-15} || {1, 25} || {2,15} ||", "Имя", "Правильные ответы:", "Диагноз");

                foreach (var line in value)
                {
                    Console.WriteLine("|| {0,-15} || {1, 25} || {2,15} ||", line.UserName, line.CountRightAnswers, line.FinalDiagnosis);
                }
            }
        }
        public static Question GetNewQuestion()
        {
            Console.WriteLine("Введите текст вопроса:");
            var text = Console.ReadLine();
            Console.WriteLine("Введите ответ на вопрос:");
            int answer = User.GetUserAnswer();

            return new Question(text, answer);
        }

        public static int GetDeletedQuestionIndex(List<Question> questions)
        {
            var countQuestion = 1;
            Console.WriteLine("Какой из вопросов Вы желаете удалить?");
            foreach (var question in questions)
            {
                Console.WriteLine(countQuestion + " " + question.Text);
                countQuestion++;
            }
            Console.WriteLine("Введите номер вопроса для удаления:");
            int userAnswer;
            while (!int.TryParse(Console.ReadLine(), out userAnswer) || userAnswer < 1 || userAnswer >= countQuestion)
                Console.WriteLine($"Некорректный ввод! Принимается число  от 1 до {countQuestion - 1}");

            return userAnswer - 1;


        }
    }
}