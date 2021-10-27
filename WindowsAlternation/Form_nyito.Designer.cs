
namespace WindowsAlternation
{
    partial class Form_nyito
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
            this.listBox_Allat = new System.Windows.Forms.ListBox();
            this.button_Kutya = new System.Windows.Forms.Button();
            this.button_Madar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Allat
            // 
            this.listBox_Allat.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox_Allat.FormattingEnabled = true;
            this.listBox_Allat.Location = new System.Drawing.Point(0, 0);
            this.listBox_Allat.Name = "listBox_Allat";
            this.listBox_Allat.Size = new System.Drawing.Size(267, 134);
            this.listBox_Allat.TabIndex = 0;
            // 
            // button_Kutya
            // 
            this.button_Kutya.Location = new System.Drawing.Point(13, 165);
            this.button_Kutya.Name = "button_Kutya";
            this.button_Kutya.Size = new System.Drawing.Size(242, 30);
            this.button_Kutya.TabIndex = 1;
            this.button_Kutya.Text = "Új kutya";
            this.button_Kutya.UseVisualStyleBackColor = true;
            this.button_Kutya.Click += new System.EventHandler(this.button_Kutya_Click);
            // 
            // button_Madar
            // 
            this.button_Madar.Location = new System.Drawing.Point(12, 212);
            this.button_Madar.Name = "button_Madar";
            this.button_Madar.Size = new System.Drawing.Size(242, 30);
            this.button_Madar.TabIndex = 1;
            this.button_Madar.Text = "Új madár";
            this.button_Madar.UseVisualStyleBackColor = true;
            this.button_Madar.Click += new System.EventHandler(this.button_Madar_Click);
            // 
            // Form_nyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 269);
            this.Controls.Add(this.button_Madar);
            this.Controls.Add(this.button_Kutya);
            this.Controls.Add(this.listBox_Allat);
            this.Name = "Form_nyito";
            this.Text = "Állatok";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listBox_Allat;
        private System.Windows.Forms.Button button_Kutya;
        private System.Windows.Forms.Button button_Madar;
    }
}

