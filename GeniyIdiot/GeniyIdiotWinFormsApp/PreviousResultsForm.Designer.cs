namespace GeniyIdiotWinFormsApp
{
    partial class previousResultsForm
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
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.AllowUserToAddRows = false;
            this.resultsDataGridView.AllowUserToDeleteRows = false;
            this.resultsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.rightAnswers,
            this.diagnosis});
            this.resultsDataGridView.Location = new System.Drawing.Point(2, 1);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowHeadersVisible = false;
            this.resultsDataGridView.RowHeadersWidth = 51;
            this.resultsDataGridView.RowTemplate.Height = 29;
            this.resultsDataGridView.Size = new System.Drawing.Size(432, 352);
            this.resultsDataGridView.TabIndex = 0;
            
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Имя";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // rightAnswers
            // 
            this.rightAnswers.HeaderText = "Правильные ответы";
            this.rightAnswers.MinimumWidth = 6;
            this.rightAnswers.Name = "rightAnswers";
            this.rightAnswers.Width = 125;
            // 
            // diagnosis
            // 
            this.diagnosis.HeaderText = "Диагноз";
            this.diagnosis.MinimumWidth = 6;
            this.diagnosis.Name = "diagnosis";
            this.diagnosis.Width = 125;
            // 
            // previousResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.resultsDataGridView);
            this.Name = "previousResultsForm";
            this.Text = "Гений Идиот";
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView resultsDataGridView;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn rightAnswers;
        private DataGridViewTextBoxColumn diagnosis;
    }
}