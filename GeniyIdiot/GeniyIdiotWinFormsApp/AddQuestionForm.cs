using GeniyIdiotClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeniyIdiotWinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        Game game;
        public AddQuestionForm(Game game)
        {
            this.game = game;
            InitializeComponent();           
        }

        string path = "Questions.json";
        

        private void nextButton_Click(object sender, EventArgs e)
        {
            string questionText = enterQuestionTextBox.Text;
            int questionAnswer;
            while (!int.TryParse(enterAnswerTextBox.Text, out questionAnswer))
            {
                MessageBox.Show("Некорректный ввод! Принимается число  от -2147483648 до 2147483647");
                return;
            }

            var newQuestion = new Question(questionText, questionAnswer);
            game.AddNewQuestion(newQuestion);
            var doneMessage = MessageBox.Show("Новый вопрос сохранен! Программа будет перезагружена", "Успех!", MessageBoxButtons.OK);
            if(doneMessage == DialogResult.OK) { Application.Restart(); }
        }
    }
}
