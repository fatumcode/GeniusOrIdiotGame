namespace GeniyIdiotWinFormsApp
{
    partial class AddNameForm
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
            this.enterNameLabel = new System.Windows.Forms.Label();
            this.enterNameTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNameLabel
            // 
            this.enterNameLabel.AutoSize = true;
            this.enterNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterNameLabel.Location = new System.Drawing.Point(12, 19);
            this.enterNameLabel.Name = "enterNameLabel";
            this.enterNameLabel.Size = new System.Drawing.Size(297, 23);
            this.enterNameLabel.TabIndex = 0;
            this.enterNameLabel.Text = "Здравствуйте! Введите Ваше имя:";
            // 
            // enterNameTextBox
            // 
            this.enterNameTextBox.Location = new System.Drawing.Point(12, 77);
            this.enterNameTextBox.Name = "enterNameTextBox";
            this.enterNameTextBox.Size = new System.Drawing.Size(297, 27);
            this.enterNameTextBox.TabIndex = 1;
            
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nextButton.Location = new System.Drawing.Point(197, 110);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(94, 29);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Дальше";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(304, -1);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 26);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // AddNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 149);
            this.ControlBox = false;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.enterNameTextBox);
            this.Controls.Add(this.enterNameLabel);
            this.Name = "AddNameForm";
            this.Text = "Гений Идиот";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label enterNameLabel;
        private TextBox enterNameTextBox;
        private Button nextButton;
        private Button exitButton;
    }
}