namespace LaboratoryWork2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.XLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.ZLabel = new System.Windows.Forms.Label();
            this.WLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.ZTextBox = new System.Windows.Forms.TextBox();
            this.WTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.ResultButton = new System.Windows.Forms.Button();
            this.AllClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.XLabel.Location = new System.Drawing.Point(19, 12);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(34, 22);
            this.XLabel.TabIndex = 0;
            this.XLabel.Text = "X=";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Font = new System.Drawing.Font("Helvetica", 14.25F);
            this.YLabel.Location = new System.Drawing.Point(19, 46);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(33, 22);
            this.YLabel.TabIndex = 1;
            this.YLabel.Text = "Y=";
            // 
            // ZLabel
            // 
            this.ZLabel.AutoSize = true;
            this.ZLabel.Font = new System.Drawing.Font("Helvetica", 14.25F);
            this.ZLabel.Location = new System.Drawing.Point(19, 78);
            this.ZLabel.Name = "ZLabel";
            this.ZLabel.Size = new System.Drawing.Size(33, 22);
            this.ZLabel.TabIndex = 2;
            this.ZLabel.Text = "Z=";
            // 
            // WLabel
            // 
            this.WLabel.AutoSize = true;
            this.WLabel.Font = new System.Drawing.Font("Helvetica", 14.25F);
            this.WLabel.Location = new System.Drawing.Point(13, 112);
            this.WLabel.Name = "WLabel";
            this.WLabel.Size = new System.Drawing.Size(40, 22);
            this.WLabel.TabIndex = 3;
            this.WLabel.Text = "W=";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(58, 12);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.ReadOnly = true;
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 4;
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(58, 46);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.ReadOnly = true;
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 5;
            // 
            // ZTextBox
            // 
            this.ZTextBox.Location = new System.Drawing.Point(58, 78);
            this.ZTextBox.Name = "ZTextBox";
            this.ZTextBox.ReadOnly = true;
            this.ZTextBox.Size = new System.Drawing.Size(100, 20);
            this.ZTextBox.TabIndex = 6;
            // 
            // WTextBox
            // 
            this.WTextBox.Location = new System.Drawing.Point(58, 112);
            this.WTextBox.Name = "WTextBox";
            this.WTextBox.ReadOnly = true;
            this.WTextBox.Size = new System.Drawing.Size(100, 20);
            this.WTextBox.TabIndex = 7;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(16, 176);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ResultTextBox.Size = new System.Drawing.Size(479, 197);
            this.ResultTextBox.TabIndex = 8;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Helvetica", 14.25F);
            this.Result.Location = new System.Drawing.Point(12, 151);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(102, 22);
            this.Result.TabIndex = 9;
            this.Result.Text = "Результат:";
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(16, 379);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(246, 23);
            this.ResultButton.TabIndex = 10;
            this.ResultButton.Text = "Выполнить";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // AllClearButton
            // 
            this.AllClearButton.Location = new System.Drawing.Point(268, 379);
            this.AllClearButton.Name = "AllClearButton";
            this.AllClearButton.Size = new System.Drawing.Size(227, 23);
            this.AllClearButton.TabIndex = 11;
            this.AllClearButton.Text = "Очистить всё";
            this.AllClearButton.UseVisualStyleBackColor = true;
            this.AllClearButton.Click += new System.EventHandler(this.AllClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 412);
            this.Controls.Add(this.AllClearButton);
            this.Controls.Add(this.ResultButton);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.WTextBox);
            this.Controls.Add(this.ZTextBox);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.WLabel);
            this.Controls.Add(this.ZLabel);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.XLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label ZLabel;
        private System.Windows.Forms.Label WLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox ZTextBox;
        private System.Windows.Forms.TextBox WTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Button AllClearButton;
    }
}

