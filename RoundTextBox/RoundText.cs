using System.Drawing;
using System.Windows.Forms;

namespace RoundTextBox
{
    public partial class RoundText : RoundControl
    {
        public bool Multiline { get => textBox1.Multiline; set => textBox1.Multiline = value; }
        public string MyText { get => textBox1.Text; set => textBox1.Text = value; }
        public Color MyForeColor { get => textBox1.ForeColor; set => textBox1.ForeColor = value; }
        public Font MyFont { get => textBox1.Font; set => textBox1.Font = value; }
        public RoundText()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (textBox1.Multiline)
            {
                textBox1.Location = new Point(Radius + 5, Radius + 5);
                textBox1.Size = new Size(Width - ((Radius + 5) * 2), Height - ((Radius + 5) * 2));
            }
            else
            {
                textBox1.Location = new Point(Radius + 5, (Height - textBox1.Height) / 2);
            }
            textBox1.BackColor = BackgroundColor;
        }

        private void textBox1_Resize(object sender, System.EventArgs e) => ResizeMe();

        private void ResizeMe()
        {
            if (!textBox1.Multiline)
            {
                Width = textBox1.Width + (Radius + 5) * 2;
                Height = textBox1.Height + 10;
                textBox1.Location = new Point(Radius + 5, (Height - textBox1.Height) / 2);
            }
        }
    }
}
