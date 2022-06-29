namespace GeniyIdiotWinFormsApp
{
    partial class DeleteQuestionForm
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
            this.questionsShowDataGridView = new System.Windows.Forms.DataGridView();
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.QuestionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Answer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.questionsShowDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsShowDataGridView
            // 
            this.questionsShowDataGridView.AllowUserToAddRows = false;
            this.questionsShowDataGridView.AllowUserToDeleteRows = false;
            this.questionsShowDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.questionsShowDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.questionsShowDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.questionsShowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.questionsShowDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.QuestionCount,
            this.Question,
            this.Answer});
            this.questionsShowDataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.questionsShowDataGridView.Location = new System.Drawing.Point(12, 79);
            this.questionsShowDataGridView.MultiSelect = false;
            this.questionsShowDataGridView.Name = "questionsShowDataGridView";
            this.questionsShowDataGridView.RowHeadersVisible = false;
            this.questionsShowDataGridView.RowHeadersWidth = 51;
            this.questionsShowDataGridView.RowTemplate.Height = 29;
            this.questionsShowDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.questionsShowDataGridView.Size = new System.Drawing.Size(776, 368);
            this.questionsShowDataGridView.TabIndex = 0;
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterNumberLabel.Location = new System.Drawing.Point(12, 18);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(458, 28);
            this.enterNumberLabel.TabIndex = 1;
            this.enterNumberLabel.Text = "Выберите вопрос, который желаете удалить:";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteButton.Location = new System.Drawing.Point(12, 454);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(97, 42);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить!";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(195, 454);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 42);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Отмена!";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // QuestionCount
            // 
            this.QuestionCount.HeaderText = "№";
            this.QuestionCount.MinimumWidth = 6;
            this.QuestionCount.Name = "QuestionCount";
            this.QuestionCount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.QuestionCount.Width = 32;
            // 
            // Question
            // 
            this.Question.HeaderText = "Вопрос";
            this.Question.MinimumWidth = 6;
            this.Question.Name = "Question";
            this.Question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Question.Width = 67;
            // 
            // Answer
            // 
            this.Answer.HeaderText = "Ответ";
            this.Answer.MinimumWidth = 6;
            this.Answer.Name = "Answer";
            this.Answer.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Answer.Width = 54;
            // 
            // DeleteQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.enterNumberLabel);
            this.Controls.Add(this.questionsShowDataGridView);
            this.Name = "DeleteQuestionForm";
            this.Text = "DeleteQuestionForm";
            ((System.ComponentModel.ISupportInitialize)(this.questionsShowDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView questionsShowDataGridView;
        private Label enterNumberLabel;
        private Button deleteButton;
        private Button cancelButton;
        private DataGridViewTextBoxColumn QuestionCount;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Answer;
    }
}