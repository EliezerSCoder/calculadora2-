﻿namespace calculadora2
{
    partial class Form3
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
            textBox3 = new TextBox();
            Retangulo1 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.AccessibleDescription = "";
            textBox3.AccessibleName = "";
            textBox3.Location = new Point(76, 102);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 30;
            textBox3.Text = "altura";
            // 
            // Retangulo1
            // 
            Retangulo1.AutoSize = true;
            Retangulo1.Location = new Point(90, 55);
            Retangulo1.Name = "Retangulo1";
            Retangulo1.Size = new Size(73, 15);
            Retangulo1.TabIndex = 29;
            Retangulo1.Text = "RETÂNGULO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(76, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 28;
            textBox2.Text = "base ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(164, 276);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 27;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(164, 239);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 26;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(164, 204);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 25;
            label9.Text = "label9";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(67, 276);
            label10.Name = "label10";
            label10.Size = new Size(54, 15);
            label10.TabIndex = 24;
            label10.Text = "VOLUME";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 239);
            label11.Name = "label11";
            label11.Size = new Size(36, 15);
            label11.TabIndex = 23;
            label11.Text = "ÁREA";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(67, 204);
            label12.Name = "label12";
            label12.Size = new Size(69, 15);
            label12.TabIndex = 22;
            label12.Text = "PERIMETRO";
            // 
            // button2
            // 
            button2.Location = new Point(90, 143);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 21;
            button2.Text = "CALCULAR ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 354);
            Controls.Add(textBox3);
            Controls.Add(Retangulo1);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(button2);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private Label Retangulo1;
        private TextBox textBox2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button2;
    }
}