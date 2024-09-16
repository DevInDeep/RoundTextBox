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
            this.SuspendLayout();
            // 
            // roundText1
            // 
            this.roundText1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.roundText1.BorderColor = System.Drawing.SystemColors.Control;
            this.roundText1.BorderWidth = 1F;
            this.roundText1.Location = new System.Drawing.Point(96, 69);
            this.roundText1.Name = "roundText1";
            this.roundText1.Radius = 10;
            this.roundText1.Size = new System.Drawing.Size(145, 43);
            this.roundText1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(300, 189);
            this.Controls.Add(this.roundText1);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundText roundText1;
    }
}

