
namespace WindowsAlternation
{
    partial class Form_Madar
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
            this.button_Madar_hozzaad = new System.Windows.Forms.Button();
            this.dateTimePicker_Szuletett = new System.Windows.Forms.DateTimePicker();
            this.textBox_tollazat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Madar_hozzaad
            // 
            this.button_Madar_hozzaad.Location = new System.Drawing.Point(26, 190);
            this.button_Madar_hozzaad.Name = "button_Madar_hozzaad";
            this.button_Madar_hozzaad.Size = new System.Drawing.Size(290, 36);
            this.button_Madar_hozzaad.TabIndex = 10;
            this.button_Madar_hozzaad.Text = "Új madár";
            this.button_Madar_hozzaad.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_Szuletett
            // 
            this.dateTimePicker_Szuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Szuletett.Location = new System.Drawing.Point(77, 86);
            this.dateTimePicker_Szuletett.Name = "dateTimePicker_Szuletett";
            this.dateTimePicker_Szuletett.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker_Szuletett.TabIndex = 9;
            // 
            // textBox_tollazat
            // 
            this.textBox_tollazat.Location = new System.Drawing.Point(77, 133);
            this.textBox_tollazat.Name = "textBox_tollazat";
            this.textBox_tollazat.Size = new System.Drawing.Size(239, 20);
            this.textBox_tollazat.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Született";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tollazat";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(77, 35);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(239, 20);
            this.textBox_Nev.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Név";
            // 
            // Form_Madar
            // 
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.button_Madar_hozzaad);
            this.Controls.Add(this.dateTimePicker_Szuletett);
            this.Controls.Add(this.textBox_tollazat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Name = "Form_Madar";
            this.Text = "Madár";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Madar_hozzaad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Szuletett;
        private System.Windows.Forms.TextBox textBox_tollazat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label1;
    }
}