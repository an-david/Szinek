namespace Szinek
{
    partial class Form_Ablak
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
            this.label_AblakSzin = new System.Windows.Forms.Label();
            this.label_BetuSzin = new System.Windows.Forms.Label();
            this.textBox_AblakSzin = new System.Windows.Forms.TextBox();
            this.textBox_BetuSzin = new System.Windows.Forms.TextBox();
            this.button_AblakSzin = new System.Windows.Forms.Button();
            this.button_BetuSzin = new System.Windows.Forms.Button();
            this.label_Hiba = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_AblakSzin
            // 
            this.label_AblakSzin.AutoSize = true;
            this.label_AblakSzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_AblakSzin.Location = new System.Drawing.Point(76, 72);
            this.label_AblakSzin.Name = "label_AblakSzin";
            this.label_AblakSzin.Size = new System.Drawing.Size(196, 16);
            this.label_AblakSzin.TabIndex = 0;
            this.label_AblakSzin.Text = "Add meg az ablak  háttér színét:";
            // 
            // label_BetuSzin
            // 
            this.label_BetuSzin.AutoSize = true;
            this.label_BetuSzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_BetuSzin.Location = new System.Drawing.Point(89, 153);
            this.label_BetuSzin.Name = "label_BetuSzin";
            this.label_BetuSzin.Size = new System.Drawing.Size(183, 16);
            this.label_BetuSzin.TabIndex = 1;
            this.label_BetuSzin.Text = "Add meg az ablak betűszínét:";
            // 
            // textBox_AblakSzin
            // 
            this.textBox_AblakSzin.Location = new System.Drawing.Point(331, 70);
            this.textBox_AblakSzin.Name = "textBox_AblakSzin";
            this.textBox_AblakSzin.Size = new System.Drawing.Size(161, 20);
            this.textBox_AblakSzin.TabIndex = 2;
            // 
            // textBox_BetuSzin
            // 
            this.textBox_BetuSzin.Location = new System.Drawing.Point(331, 151);
            this.textBox_BetuSzin.Name = "textBox_BetuSzin";
            this.textBox_BetuSzin.Size = new System.Drawing.Size(161, 20);
            this.textBox_BetuSzin.TabIndex = 3;
            // 
            // button_AblakSzin
            // 
            this.button_AblakSzin.Location = new System.Drawing.Point(566, 67);
            this.button_AblakSzin.Name = "button_AblakSzin";
            this.button_AblakSzin.Size = new System.Drawing.Size(75, 23);
            this.button_AblakSzin.TabIndex = 4;
            this.button_AblakSzin.Text = "Alkalmaz";
            this.button_AblakSzin.UseVisualStyleBackColor = true;
            this.button_AblakSzin.Click += new System.EventHandler(this.button_AblakSzin_Click);
            // 
            // button_BetuSzin
            // 
            this.button_BetuSzin.Location = new System.Drawing.Point(566, 149);
            this.button_BetuSzin.Name = "button_BetuSzin";
            this.button_BetuSzin.Size = new System.Drawing.Size(75, 23);
            this.button_BetuSzin.TabIndex = 5;
            this.button_BetuSzin.Text = "Alkalmaz";
            this.button_BetuSzin.UseVisualStyleBackColor = true;
            this.button_BetuSzin.Click += new System.EventHandler(this.button_BetuSzin_Click);
            // 
            // label_Hiba
            // 
            this.label_Hiba.AutoSize = true;
            this.label_Hiba.Location = new System.Drawing.Point(354, 99);
            this.label_Hiba.Name = "label_Hiba";
            this.label_Hiba.Size = new System.Drawing.Size(0, 13);
            this.label_Hiba.TabIndex = 6;
            // 
            // Form_Ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Hiba);
            this.Controls.Add(this.button_BetuSzin);
            this.Controls.Add(this.button_AblakSzin);
            this.Controls.Add(this.textBox_BetuSzin);
            this.Controls.Add(this.textBox_AblakSzin);
            this.Controls.Add(this.label_BetuSzin);
            this.Controls.Add(this.label_AblakSzin);
            this.Name = "Form_Ablak";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AblakSzin;
        private System.Windows.Forms.Label label_BetuSzin;
        private System.Windows.Forms.TextBox textBox_AblakSzin;
        private System.Windows.Forms.TextBox textBox_BetuSzin;
        private System.Windows.Forms.Button button_AblakSzin;
        private System.Windows.Forms.Button button_BetuSzin;
        private System.Windows.Forms.Label label_Hiba;
    }
}

