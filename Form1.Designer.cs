namespace GuessingsNumbersGame
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            txtGuessNumber1 = new TextBox();
            txtGuessNumber2 = new TextBox();
            btnCreate = new Button();
            label3 = new Label();
            lblCreatedNumber = new Label();
            label4 = new Label();
            txtGuess = new TextBox();
            btnGuess = new Button();
            label5 = new Label();
            lblTryNumber = new Label();
            label6 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(197, 32);
            label1.TabIndex = 0;
            label1.Text = "Tahmin Aralığı 1 :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(197, 32);
            label2.TabIndex = 1;
            label2.Text = "Tahmin Aralığı 2 :";
            // 
            // txtGuessNumber1
            // 
            txtGuessNumber1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuessNumber1.Location = new Point(215, 12);
            txtGuessNumber1.Name = "txtGuessNumber1";
            txtGuessNumber1.Size = new Size(146, 35);
            txtGuessNumber1.TabIndex = 2;
            // 
            // txtGuessNumber2
            // 
            txtGuessNumber2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuessNumber2.Location = new Point(215, 54);
            txtGuessNumber2.Name = "txtGuessNumber2";
            txtGuessNumber2.Size = new Size(146, 35);
            txtGuessNumber2.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.LawnGreen;
            btnCreate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreate.Location = new Point(395, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(116, 77);
            btnCreate.TabIndex = 4;
            btnCreate.Text = "Sayı Üret";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 130);
            label3.Name = "label3";
            label3.Size = new Size(153, 32);
            label3.TabIndex = 5;
            label3.Text = "Üretilen Sayı:";
            // 
            // lblCreatedNumber
            // 
            lblCreatedNumber.AutoSize = true;
            lblCreatedNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCreatedNumber.Location = new Point(165, 130);
            lblCreatedNumber.Name = "lblCreatedNumber";
            lblCreatedNumber.Size = new Size(44, 32);
            lblCreatedNumber.TabIndex = 6;
            lblCreatedNumber.Text = "---";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(133, 32);
            label4.TabIndex = 7;
            label4.Text = "Tahmininiz:";
            // 
            // txtGuess
            // 
            txtGuess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuess.Location = new Point(151, 208);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(146, 35);
            txtGuess.TabIndex = 8;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.Red;
            btnGuess.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuess.Location = new Point(312, 209);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(103, 35);
            btnGuess.TabIndex = 9;
            btnGuess.Text = "Tahmin Et";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += btnGuess_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 269);
            label5.Name = "label5";
            label5.Size = new Size(191, 32);
            label5.TabIndex = 10;
            label5.Text = "Deneme Sayınız:";
            // 
            // lblTryNumber
            // 
            lblTryNumber.AutoSize = true;
            lblTryNumber.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblTryNumber.Location = new Point(215, 269);
            lblTryNumber.Name = "lblTryNumber";
            lblTryNumber.Size = new Size(44, 32);
            lblTryNumber.TabIndex = 11;
            lblTryNumber.Text = "---";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 323);
            label6.Name = "label6";
            label6.Size = new Size(85, 32);
            label6.TabIndex = 12;
            label6.Text = "Sonuç:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(103, 323);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(44, 32);
            lblResult.TabIndex = 13;
            lblResult.Text = "---";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 387);
            Controls.Add(lblResult);
            Controls.Add(label6);
            Controls.Add(lblTryNumber);
            Controls.Add(label5);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(label4);
            Controls.Add(lblCreatedNumber);
            Controls.Add(label3);
            Controls.Add(btnCreate);
            Controls.Add(txtGuessNumber2);
            Controls.Add(txtGuessNumber1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Guess Number";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtGuessNumber1;
        private TextBox txtGuessNumber2;
        private Button btnCreate;
        private Label label3;
        private Label lblCreatedNumber;
        private Label label4;
        private TextBox txtGuess;
        private Button btnGuess;
        private Label label5;
        private Label lblTryNumber;
        private Label label6;
        private Label lblResult;
    }
}