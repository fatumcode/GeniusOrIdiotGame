namespace GeniyIdiotWinFormsApp
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(94, 295);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(449, 83);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Дальше";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionNumberLabel.Location = new System.Drawing.Point(12, 36);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(118, 28);
            this.questionNumberLabel.TabIndex = 2;
            this.questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTextLabel.Location = new System.Drawing.Point(12, 119);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(146, 25);
            this.questionTextLabel.TabIndex = 3;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.Location = new System.Drawing.Point(94, 228);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(449, 27);
            this.userAnswerTextBox.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousResultsToolStripMenuItem,
            this.addNewQuestionToolStripMenuItem,
            this.deleteQuestionToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // previousResultsToolStripMenuItem
            // 
            this.previousResultsToolStripMenuItem.Name = "previousResultsToolStripMenuItem";
            this.previousResultsToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.previousResultsToolStripMenuItem.Text = "Предыдущие результаты";
            this.previousResultsToolStripMenuItem.Click += new System.EventHandler(this.PreviousResultsToolStripMenuItem_Click);
            // 
            // addNewQuestionToolStripMenuItem
            // 
            this.addNewQuestionToolStripMenuItem.Name = "addNewQuestionToolStripMenuItem";
            this.addNewQuestionToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.addNewQuestionToolStripMenuItem.Text = "Добавить новый вопрос";
            this.addNewQuestionToolStripMenuItem.Click += new System.EventHandler(this.AddNewQuestionToolStripMenuItem_Click);
            // 
            // deleteQuestionToolStripMenuItem
            // 
            this.deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            this.deleteQuestionToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.deleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            this.deleteQuestionToolStripMenuItem.Click += new System.EventHandler(this.DeleteQuestionToolStripMenuItem_Click);
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.reloadToolStripMenuItem.Text = "Перезапустить приложение";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.exitToolStripMenuItem.Text = "Выйти";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.mainTimer_Tick);
            // 
            // leftTimeLabel
            // 
            this.leftTimeLabel.AutoSize = true;
            this.leftTimeLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.leftTimeLabel.Location = new System.Drawing.Point(604, 39);
            this.leftTimeLabel.Name = "leftTimeLabel";
            this.leftTimeLabel.Size = new System.Drawing.Size(104, 25);
            this.leftTimeLabel.TabIndex = 6;
            this.leftTimeLabel.Text = "Осталось: ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 445);
            this.Controls.Add(this.leftTimeLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Гений Идиот";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button nextButton;
        private Label questionNumberLabel;
        private Label questionTextLabel;
        private TextBox userAnswerTextBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem previousResultsToolStripMenuItem;
        private ToolStripMenuItem addNewQuestionToolStripMenuItem;
        private ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private ToolStripMenuItem reloadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer mainTimer;
        private Label leftTimeLabel;
    }
}