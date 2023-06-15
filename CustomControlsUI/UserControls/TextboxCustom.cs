using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CustomControlsUI.UserControls
{

    [DefaultEvent("_TextChanged")]
    public partial class TextboxCustom : UserControl
    {
        //fields

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLineStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;


        //constructor
        public TextboxCustom()
        {
            InitializeComponent();
        }

        //event
        public event EventHandler _TextChanged;



        #region Category
        //properties
        [Category("TextCustom")]

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("TextCustom")]

        public int BoderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();

            }
        }
        [Category("TextCustom")]

        public bool UnderLineStyle
        {
            get
            {
                return underLineStyle;
            }
            set
            {
                underLineStyle = value;
                this.Invalidate();

            }
        }
        [Category("TextCustom")]

        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("TextCustom")]

        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        [Category("TextCustom")]

        public override Color BackColor {
            get {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("TextCustom")]

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("TextCustom")]

        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category("TextCustom")]
        public override string Text
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }
        [Category("TextCustom")]

        public Color BoderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        [Category("TextCustom")]

        public int BoderRadius 
        {
            get{
                return borderRadius; 
            }

            set {
                if (value>=0) {
                    borderRadius = value;
                    this.Invalidate();//redraw controls
                }
            }
        }
        [Category("TextCustom")]

        public Color PlaceholderColor
        {
            get 
            { 
                return placeholderColor; 
            }
            set
            {
                placeholderColor = value;
                if (isPasswordChar)
                {
                    textBox1.ForeColor = value;
                }
            }
        }
        [Category("TextCustom")]

        public string PlaceholderText {
            get
            { 
               return placeholderText;
            }
            set
            { 
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        [Category("TextCustom")]

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }
        [Category("TextCustom")]

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        #endregion
        //overidden method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius>1)///rounded textbox
            {
                //field
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius)) 
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underLineStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else//square/normal textbox
            {
                //draw boder
                using (Pen penBoder = new Pen(borderColor, borderSize))
                {

                    this.Region = new Region(this.ClientRectangle);
                    penBoder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (!isFocused)
                    {
                        if (underLineStyle)//line style
                        {
                            graph.DrawLine(penBoder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else//normal
                        {
                            graph.DrawRectangle(penBoder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

                        }
                    }
                    else
                    {
                        penBoder.Color = borderFocusColor;
                        if (underLineStyle)//line style
                        {
                            graph.DrawLine(penBoder, 0, this.Height - 1, this.Width, this.Height - 1);
                        }
                        else//normal
                        {
                            graph.DrawRectangle(penBoder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);

                        }
                    }
                }
            }    
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            pathTxt.Dispose();
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //private method
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline==false)
            {
                int txtHeight = TextRenderer.MeasureText("Text",this.Font).Height+1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }       
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged!=null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
