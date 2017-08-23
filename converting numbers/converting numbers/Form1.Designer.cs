namespace converting_numbers
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbbinary = new System.Windows.Forms.Label();
            this.lbdecimal = new System.Windows.Forms.Label();
            this.lboctal = new System.Windows.Forms.Label();
            this.lbhexa = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre any number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BInary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Decimal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "octal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "hexa";
            // 
            // lbbinary
            // 
            this.lbbinary.AutoSize = true;
            this.lbbinary.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbbinary.Location = new System.Drawing.Point(37, 152);
            this.lbbinary.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbbinary.Name = "lbbinary";
            this.lbbinary.Size = new System.Drawing.Size(0, 19);
            this.lbbinary.TabIndex = 5;
            // 
            // lbdecimal
            // 
            this.lbdecimal.AutoSize = true;
            this.lbdecimal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbdecimal.Location = new System.Drawing.Point(153, 152);
            this.lbdecimal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbdecimal.Name = "lbdecimal";
            this.lbdecimal.Size = new System.Drawing.Size(0, 19);
            this.lbdecimal.TabIndex = 6;
            // 
            // lboctal
            // 
            this.lboctal.AutoSize = true;
            this.lboctal.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lboctal.Location = new System.Drawing.Point(253, 152);
            this.lboctal.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.lboctal.Name = "lboctal";
            this.lboctal.Size = new System.Drawing.Size(0, 19);
            this.lboctal.TabIndex = 7;
            // 
            // lbhexa
            // 
            this.lbhexa.AutoSize = true;
            this.lbhexa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbhexa.Location = new System.Drawing.Point(370, 152);
            this.lbhexa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbhexa.Name = "lbhexa";
            this.lbhexa.Size = new System.Drawing.Size(0, 19);
            this.lbhexa.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(25, 260);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 56);
            this.button1.TabIndex = 9;
            this.button1.Text = "convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(284, 25);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(440, 320);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbhexa);
            this.Controls.Add(this.lboctal);
            this.Controls.Add(this.lbdecimal);
            this.Controls.Add(this.lbbinary);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "conversion system";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbbinary;
        private System.Windows.Forms.Label lbdecimal;
        private System.Windows.Forms.Label lboctal;
        private System.Windows.Forms.Label lbhexa;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

