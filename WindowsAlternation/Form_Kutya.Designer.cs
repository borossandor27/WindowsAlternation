
namespace WindowsAlternation
{
    partial class Form_Kutya
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
            this.button_Kutya_hozzaad = new System.Windows.Forms.Button();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.textBox_szorzet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Kutya_hozzaad
            // 
            this.button_Kutya_hozzaad.Location = new System.Drawing.Point(27, 171);
            this.button_Kutya_hozzaad.Name = "button_Kutya_hozzaad";
            this.button_Kutya_hozzaad.Size = new System.Drawing.Size(290, 36);
            this.button_Kutya_hozzaad.TabIndex = 17;
            this.button_Kutya_hozzaad.Text = "Új kutya";
            this.button_Kutya_hozzaad.UseVisualStyleBackColor = true;
            this.button_Kutya_hozzaad.Click += new System.EventHandler(this.button_Kutya_hozzaad_Click);
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(78, 67);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker_Szuletett.TabIndex = 16;
            // 
            // textBox_szorzet
            // 
            this.textBox_szorzet.Location = new System.Drawing.Point(78, 114);
            this.textBox_szorzet.Name = "textBox_szorzet";
            this.textBox_szorzet.Size = new System.Drawing.Size(239, 20);
            this.textBox_szorzet.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Született";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Szőrzet";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(78, 16);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(239, 20);
            this.textBox_Nev.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Név";
            // 
            // Form_Kutya
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 258);
            this.Controls.Add(this.button_Kutya_hozzaad);
            this.Controls.Add(this.dateTimePicker_Szuletett);
            this.Controls.Add(this.textBox_szorzet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Name = "Form_Kutya";
            this.Text = "Form_Kutya";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Kutya_hozzaad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.TextBox textBox_szorzet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label1;
    }
}