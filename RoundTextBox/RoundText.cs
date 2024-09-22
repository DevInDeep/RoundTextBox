using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RoundTextBox
{
    public partial class RoundText : RoundControl
    {
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text { get => textBox1.Text; set => textBox1.Text = value; }
        public override Color ForeColor { get => textBox1.ForeColor; set => textBox1.ForeColor = value; }
        private Font _Font = UserControl.DefaultFont;
        [Description("Sets the font of the button caption")]
        [Browsable(true)]
        [Bindable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override Font Font
        {
            get { return base.Font; }
            set { textBox1.Font = base.Font = value; }
        }
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
