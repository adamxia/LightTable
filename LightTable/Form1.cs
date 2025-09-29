using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int deltaX=0;
        int deltaY = 0;
        MyPictureBox pictureBox1 = new MyPictureBox();
        MyTableLayoutPanel panel = new MyTableLayoutPanel();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.6;

            pictureBox1.Image = global::LightTable.Properties.Resources.test;
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            //Panel panel = new Panel();
            panel.Size = new Size(2300, 1300);
            panel.Location = new Point(123, 25);
            panel.AutoScroll = true;
            panel.Controls.Add(pictureBox1);
            this.Controls.Add(panel);
            deltaX = this.Width - panel.Width;
            deltaY = this.Height - panel.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Opacity >= 1) return;
            this.Opacity +=0.1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Opacity <= 0.2) return;
            this.Opacity -= 0.1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog(this)== DialogResult.OK)
            {
                string strFileName = openFileDialog1.FileName;
                Bitmap m_bitmap = new Bitmap(strFileName);
                pictureBox1.Image = m_bitmap;
            }
        }

        private void btPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Bitmap))
                pictureBox1.Image = (Bitmap)Clipboard.GetDataObject().GetData(DataFormats.Bitmap);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            panel.Width = this.Width-deltaX;
            panel.Height = this.Height-deltaY;
        }

        private class MyTableLayoutPanel : Panel // or TableLayoutPanel, etc.
        {
            private Point _mouseDown;
            private Point _formLocation;
            private bool _capture;

            // NOTE: we cannot use the WM_NCHITTEST / HTCAPTION trick because the table is in control, not the owning form...
            protected override void OnMouseDown(MouseEventArgs e)
            {
                _capture = true;
                _mouseDown = e.Location;
                _formLocation = ((Form)TopLevelControl).Location;
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                _capture = false;
            }

            protected override void OnMouseMove(MouseEventArgs e)
            {
                if (_capture)
                {
                    int dx = e.Location.X - _mouseDown.X;
                    int dy = e.Location.Y - _mouseDown.Y;
                    Point newLocation = new Point(_formLocation.X + dx, _formLocation.Y + dy);
                    ((Form)TopLevelControl).Location = newLocation;
                    _formLocation = newLocation;
                }
            }
        }

        private class MyPictureBox : PictureBox 
        {
            private Point _mouseDown;
            private Point _formLocation;
            private bool _capture;

            // NOTE: we cannot use the WM_NCHITTEST / HTCAPTION trick because the table is in control, not the owning form...
            protected override void OnMouseDown(MouseEventArgs e)
            {
                _capture = true;
                _mouseDown = e.Location;
                _formLocation = ((Form)TopLevelControl).Location;
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                _capture = false;
            }

            protected override void OnMouseMove(MouseEventArgs e)
            {
                if (_capture)
                {
                    int dx = e.Location.X - _mouseDown.X;
                    int dy = e.Location.Y - _mouseDown.Y;
                    Point newLocation = new Point(_formLocation.X + dx, _formLocation.Y + dy);
                    ((Form)TopLevelControl).Location = newLocation;
                    _formLocation = newLocation;
                }
            }
        }
    }
}