namespace GeniyIdiotWinFormsApp
{
    partial class AddQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterTextLabel = new System.Windows.Forms.Label();
            this.enterQuestionTextBox = new System.Windows.Forms.TextBox();
            this.enterAnswerLabel = new System.Windows.Forms.Label();
            this.enterAnswerTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterTextLabel
            // 
            this.enterTextLabel.AutoSize = true;
            this.enterTextLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterTextLabel.Location = new System.Drawing.Point(41, 16);
            this.enterTextLabel.Name = "enterTextLabel";
            this.enterTextLabel.Size = new System.Drawing.Size(261, 28);
            this.enterTextLabel.TabIndex = 0;
            this.enterTextLabel.Text = "Напишите текст вопроса:";
            // 
            // enterQuestionTextBox
            // 
            this.enterQuestionTextBox.Location = new System.Drawing.Point(41, 47);
            this.enterQuestionTextBox.Name = "enterQuestionTextBox";
            this.enterQuestionTextBox.Size = new System.Drawing.Size(708, 27);
            this.enterQuestionTextBox.TabIndex = 1;
            // 
            // enterAnswerLabel
            // 
            this.enterAnswerLabel.AutoSize = true;
            this.enterAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterAnswerLabel.Location = new System.Drawing.Point(41, 125);
            this.enterAnswerLabel.Name = "enterAnswerLabel";
            this.enterAnswerLabel.Size = new System.Drawing.Size(282, 28);
            this.enterAnswerLabel.TabIndex = 2;
            this.enterAnswerLabel.Text = "Напишите ответ на вопрос:";
            // 
            // enterAnswerTextBox
            // 
            this.enterAnswerTextBox.Location = new System.Drawing.Point(41, 156);
            this.enterAnswerTextBox.Name = "enterAnswerTextBox";
            this.enterAnswerTextBox.Size = new System.Drawing.Size(708, 27);
            this.enterAnswerTextBox.TabIndex = 3;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(41, 247);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(98, 39);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Дальше";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // AddQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.enterAnswerTextBox);
            this.Controls.Add(this.enterAnswerLabel);
            this.Controls.Add(this.enterQuestionTextBox);
            this.Controls.Add(this.enterTextLabel);
            this.Name = "AddQuestionForm";
            this.Text = "Добавить новый вопрос";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterTextLabel;
        private TextBox enterQuestionTextBox;
        private Label enterAnswerLabel;
        private TextBox enterAnswerTextBox;
        private Button nextButton;
    }
}