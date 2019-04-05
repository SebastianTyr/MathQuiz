namespace Math
{
    partial class MQuiz
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
            this.label_a = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.labelwynik = new System.Windows.Forms.Label();
            this.textBoxsum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_a.Location = new System.Drawing.Point(28, 73);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(18, 20);
            this.label_a.TabIndex = 0;
            this.label_a.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(70, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "+";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_b.Location = new System.Drawing.Point(112, 73);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(18, 20);
            this.label_b.TabIndex = 2;
            this.label_b.Text = "?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(148, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(308, 117);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "Sprawdź";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.Location = new System.Drawing.Point(308, 74);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(75, 23);
            this.buttonstart.TabIndex = 7;
            this.buttonstart.Text = "Start";
            this.buttonstart.UseVisualStyleBackColor = true;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // labelwynik
            // 
            this.labelwynik.AutoSize = true;
            this.labelwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelwynik.Location = new System.Drawing.Point(152, 172);
            this.labelwynik.Name = "labelwynik";
            this.labelwynik.Size = new System.Drawing.Size(77, 16);
            this.labelwynik.TabIndex = 8;
            this.labelwynik.Text = "Komunikat1";
            // 
            // textBoxsum
            // 
            this.textBoxsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxsum.Location = new System.Drawing.Point(182, 71);
            this.textBoxsum.Name = "textBoxsum";
            this.textBoxsum.Size = new System.Drawing.Size(100, 26);
            this.textBoxsum.TabIndex = 9;
            // 
            // MQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 330);
            this.Controls.Add(this.textBoxsum);
            this.Controls.Add(this.labelwynik);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_a);
            this.Name = "MQuiz";
            this.Text = "MathQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Label labelwynik;
        private System.Windows.Forms.TextBox textBoxsum;
    }
}

