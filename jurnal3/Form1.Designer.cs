namespace jurnal3
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
            textInput = new TextBox();
            angka1 = new Button();
            angka2 = new Button();
            angka3 = new Button();
            angka4 = new Button();
            angka5 = new Button();
            angka6 = new Button();
            angka7 = new Button();
            angka8 = new Button();
            jumlah = new Button();
            angka0 = new Button();
            samaDengan = new Button();
            angka9 = new Button();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.Location = new Point(251, 79);
            textInput.Name = "textInput";
            textInput.Size = new Size(231, 23);
            textInput.TabIndex = 0;
            textInput.TextChanged += textInput_TextChanged;
            // 
            // angka1
            // 
            angka1.Location = new Point(251, 124);
            angka1.Name = "angka1";
            angka1.Size = new Size(73, 31);
            angka1.TabIndex = 1;
            angka1.Text = "1";
            angka1.UseVisualStyleBackColor = true;
            angka1.Click += button1_Click;
            // 
            // angka2
            // 
            angka2.Location = new Point(330, 124);
            angka2.Name = "angka2";
            angka2.Size = new Size(73, 31);
            angka2.TabIndex = 1;
            angka2.Text = "2";
            angka2.UseVisualStyleBackColor = true;
            angka2.Click += button2_Click;
            // 
            // angka3
            // 
            angka3.Location = new Point(409, 124);
            angka3.Name = "angka3";
            angka3.Size = new Size(73, 31);
            angka3.TabIndex = 1;
            angka3.Text = "3";
            angka3.UseVisualStyleBackColor = true;
            angka3.Click += angka3_Click;
            // 
            // angka4
            // 
            angka4.Location = new Point(251, 161);
            angka4.Name = "angka4";
            angka4.Size = new Size(73, 31);
            angka4.TabIndex = 1;
            angka4.Text = "4";
            angka4.UseVisualStyleBackColor = true;
            angka4.Click += angka4_Click;
            // 
            // angka5
            // 
            angka5.Location = new Point(330, 161);
            angka5.Name = "angka5";
            angka5.Size = new Size(73, 31);
            angka5.TabIndex = 1;
            angka5.Text = "5";
            angka5.UseVisualStyleBackColor = true;
            angka5.Click += angka5_Click;
            // 
            // angka6
            // 
            angka6.Location = new Point(409, 161);
            angka6.Name = "angka6";
            angka6.Size = new Size(73, 31);
            angka6.TabIndex = 1;
            angka6.Text = "6";
            angka6.UseVisualStyleBackColor = true;
            angka6.Click += button6_Click;
            // 
            // angka7
            // 
            angka7.Location = new Point(251, 198);
            angka7.Name = "angka7";
            angka7.Size = new Size(73, 31);
            angka7.TabIndex = 1;
            angka7.Text = "7";
            angka7.UseVisualStyleBackColor = true;
            angka7.Click += angka7_Click;
            // 
            // angka8
            // 
            angka8.Location = new Point(330, 198);
            angka8.Name = "angka8";
            angka8.Size = new Size(73, 31);
            angka8.TabIndex = 1;
            angka8.Text = "8";
            angka8.UseVisualStyleBackColor = true;
            angka8.Click += angka8_Click;
            // 
            // jumlah
            // 
            jumlah.Location = new Point(251, 235);
            jumlah.Name = "jumlah";
            jumlah.Size = new Size(73, 31);
            jumlah.TabIndex = 1;
            jumlah.Text = "+";
            jumlah.UseVisualStyleBackColor = true;
            jumlah.Click += jumlah_Click;
            // 
            // angka0
            // 
            angka0.Location = new Point(330, 235);
            angka0.Name = "angka0";
            angka0.Size = new Size(73, 31);
            angka0.TabIndex = 1;
            angka0.Text = "0";
            angka0.UseVisualStyleBackColor = true;
            angka0.Click += angka0_Click;
            // 
            // samaDengan
            // 
            samaDengan.Location = new Point(409, 235);
            samaDengan.Name = "samaDengan";
            samaDengan.Size = new Size(73, 31);
            samaDengan.TabIndex = 2;
            samaDengan.Text = "=";
            samaDengan.UseVisualStyleBackColor = true;
            samaDengan.Click += samaDengan_Click;
            // 
            // angka9
            // 
            angka9.Location = new Point(409, 198);
            angka9.Name = "angka9";
            angka9.Size = new Size(73, 31);
            angka9.TabIndex = 3;
            angka9.Text = "9";
            angka9.UseVisualStyleBackColor = true;
            angka9.Click += angka9_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(angka9);
            Controls.Add(samaDengan);
            Controls.Add(angka6);
            Controls.Add(angka3);
            Controls.Add(angka0);
            Controls.Add(angka8);
            Controls.Add(angka5);
            Controls.Add(angka2);
            Controls.Add(jumlah);
            Controls.Add(angka7);
            Controls.Add(angka4);
            Controls.Add(angka1);
            Controls.Add(textInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Button angka1;
        private Button angka2;
        private Button angka3;
        private Button angka4;
        private Button angka5;
        private Button angka6;
        private Button angka7;
        private Button angka8;
        private Button jumlah;
        private Button angka0;
        private Button samaDengan;
        private Button angka9;
    }
}
