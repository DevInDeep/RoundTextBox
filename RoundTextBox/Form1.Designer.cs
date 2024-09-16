namespace RoundTextBox
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
            this.roundText1 = new RoundTextBox.RoundText();
            this.roundText2 = new RoundTextBox.RoundText();
            this.SuspendLayout();
            // 
            // roundText1
            // 
            this.roundText1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(205)))), ((int)(((byte)(255)))));
            this.roundText1.BorderColor = System.Drawing.Color.White;
            this.roundText1.BorderWidth = 7F;
            this.roundText1.Location = new System.Drawing.Point(75, 12);
            this.roundText1.MinimumSize = new System.Drawing.Size(140, 50);
            this.roundText1.Multiline = false;
            this.roundText1.MyFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundText1.MyForeColor = System.Drawing.SystemColors.WindowText;
            this.roundText1.MyText = "";
            this.roundText1.Name = "roundText1";
            this.roundText1.Radius = 10;
            this.roundText1.Size = new System.Drawing.Size(197, 50);
            this.roundText1.TabIndex = 0;
            // 
            // roundText2
            // 
            this.roundText2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundText2.BorderColor = System.Drawing.SystemColors.Control;
            this.roundText2.BorderWidth = 1F;
            this.roundText2.Location = new System.Drawing.Point(75, 100);
            this.roundText2.MinimumSize = new System.Drawing.Size(140, 50);
            this.roundText2.Multiline = false;
            this.roundText2.MyFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundText2.MyForeColor = System.Drawing.SystemColors.WindowText;
            this.roundText2.MyText = "";
            this.roundText2.Name = "roundText2";
            this.roundText2.Radius = 10;
            this.roundText2.Size = new System.Drawing.Size(142, 50);
            this.roundText2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(366, 214);
            this.Controls.Add(this.roundText2);
            this.Controls.Add(this.roundText1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundText roundText1;
        private RoundText roundText2;
    }
}

