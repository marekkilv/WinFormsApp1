﻿
namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxmeno = new System.Windows.Forms.TextBox();
            this.tboxpriezvisko = new System.Windows.Forms.TextBox();
            this.tboxbydlisko = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tboxpoistovna = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxpohlavie = new System.Windows.Forms.TextBox();
            this.tboxpsc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(598, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ďalej";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Meno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Priezvisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bydlisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Psč";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Zdravotná poisťovňa";
            // 
            // tboxmeno
            // 
            this.tboxmeno.Location = new System.Drawing.Point(381, 59);
            this.tboxmeno.Name = "tboxmeno";
            this.tboxmeno.Size = new System.Drawing.Size(100, 23);
            this.tboxmeno.TabIndex = 6;
            // 
            // tboxpriezvisko
            // 
            this.tboxpriezvisko.Location = new System.Drawing.Point(381, 88);
            this.tboxpriezvisko.Name = "tboxpriezvisko";
            this.tboxpriezvisko.Size = new System.Drawing.Size(100, 23);
            this.tboxpriezvisko.TabIndex = 7;
            // 
            // tboxbydlisko
            // 
            this.tboxbydlisko.Location = new System.Drawing.Point(381, 118);
            this.tboxbydlisko.Name = "tboxbydlisko";
            this.tboxbydlisko.Size = new System.Drawing.Size(100, 23);
            this.tboxbydlisko.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(0, 0);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 14;
            // 
            // tboxpoistovna
            // 
            this.tboxpoistovna.Location = new System.Drawing.Point(381, 186);
            this.tboxpoistovna.Name = "tboxpoistovna";
            this.tboxpoistovna.Size = new System.Drawing.Size(100, 23);
            this.tboxpoistovna.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Pohlavie";
            // 
            // tboxpohlavie
            // 
            this.tboxpohlavie.Location = new System.Drawing.Point(381, 221);
            this.tboxpohlavie.Name = "tboxpohlavie";
            this.tboxpohlavie.Size = new System.Drawing.Size(100, 23);
            this.tboxpohlavie.TabIndex = 13;
            // 
            // tboxpsc
            // 
            this.tboxpsc.Location = new System.Drawing.Point(381, 150);
            this.tboxpsc.Name = "tboxpsc";
            this.tboxpsc.Size = new System.Drawing.Size(100, 23);
            this.tboxpsc.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tboxpsc);
            this.Controls.Add(this.tboxpohlavie);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxpoistovna);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.tboxbydlisko);
            this.Controls.Add(this.tboxpriezvisko);
            this.Controls.Add(this.tboxmeno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxmeno;
        private System.Windows.Forms.TextBox tboxpriezvisko;
        private System.Windows.Forms.TextBox tboxbydlisko;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tboxpoistovna;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxpohlavie;
        private System.Windows.Forms.TextBox tboxpsc;
    }
}

