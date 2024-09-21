using System.Drawing;
using System.Windows.Forms;

namespace RoundTextBox
{
    public partial class RoundText : RoundControl
    {
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
            textBox1.Location = new Point(Radius + 7, Radius + 7);
            textBox1.Size = new Size(Width - ((Radius + 7) * 2), Height - ((Radius + 7) * 2));
            textBox1.BackColor = BackgroundColor;
        }
    }
}
