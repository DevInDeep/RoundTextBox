using System.Drawing;
using System.Windows.Forms;

namespace RoundTextBox
{
    public partial class RoundText : RoundControl
    {
        public RoundText()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            textBox1.Location = new Point(Radius + 5, Radius + 5);
            textBox1.Size = new Size(Width - ((Radius + 5)*2), Height - ((Radius + 5) * 2));
            textBox1.BackColor = BackgroundColor;
        }
    }
}
