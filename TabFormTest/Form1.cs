using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace TabFormTest
{
    public partial class Form1 : Form
    {

        private int form2Index = -1;
        private int form3Index = -1;
        private int form4Index = -1;
        private Point _imageLocation = new Point(17, 2);
        private Point _imgHitArea = new Point(17, 2);
        private Image closeR = new Bitmap(1, 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
            this.Text = "Show Form using Tab";
            closeR = TabFormTest.Resource1._10758949_x_icon;
            tabControl1.Padding = new Point(10, 3);
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.form2Index == -1)
            {
                var form2 = new Form2();
                form2.TopLevel = false;
                tabControl1.TabPages.Add(form2.Text);
                this.form2Index = tabControl1.TabCount - 1;
                tabControl1.TabPages[this.form2Index].Controls.Add(form2);
                form2.Dock = DockStyle.Fill;
                form2.Show();
            }
            tabControl1.SelectedIndex = this.form2Index;
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Image img = new Bitmap(closeR);
            Rectangle r = e.Bounds;
            r = this.tabControl1.GetTabRect(e.Index);
            Brush titleBrush = new SolidBrush(Color.Black);
            Brush bgBrush = new SolidBrush(this.BackColor);
            Font f = this.Font;
            if (e.Index == this.tabControl1.SelectedIndex)
            {
                bgBrush = new SolidBrush(Color.LightGray);
                titleBrush = new SolidBrush(Color.Black);
            }
            e.Graphics.FillRectangle(bgBrush, r);
            string title = this.tabControl1.TabPages[e.Index].Text;
            r.Offset(2, 2);
            e.Graphics.DrawString(title, f, titleBrush, new PointF(r.X, r.Y));
            if (tabControl1.SelectedIndex > -1)
            {
                e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y + 2));
            }
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControl1.SelectedIndex > -1)
            {
                if (r.Contains(p))
                {
                    TabPage tabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    resetIndex(tc.SelectedIndex);
                    tabReIndex(tc.SelectedIndex);
                    tc.TabPages.Remove(tabP);
                }
            }
        }

        private void form2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.form3Index == -1)
            {
                var form3 = new Form3();
                form3.TopLevel = false;
                tabControl1.TabPages.Add(form3.Text);
                this.form3Index = tabControl1.TabCount - 1;
                tabControl1.TabPages[this.form3Index].Controls.Add(form3);
                form3.Dock = DockStyle.Fill;
                form3.Show();
            }
            tabControl1.SelectedIndex = this.form3Index;
        }

        private void resetIndex(int index)
        {
            if (this.form2Index == index)
            {
                this.form2Index = -1;
            }
            else if (this.form3Index == index)
            {
                this.form3Index = -1;
            }
            else if (this.form4Index == index)
            {
                this.form4Index = -1;
            }
        }

        private void tabReIndex(int index)
        {
            if (this.form2Index > index && this.form2Index > -1)
            {
                this.form2Index -= 1;
            }
            else if (this.form3Index > index && this.form3Index > -1)
            {
                this.form3Index -= 1;
            }
            else if (this.form4Index > index && this.form4Index > -1)
            {
                this.form4Index -= 1;
            }
        }

        private void form4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.form4Index == -1)
            {
                var form4 = new Form4();
                form4.TopLevel = false;
                tabControl1.TabPages.Add(form4.Text);
                this.form4Index = tabControl1.TabCount - 1;
                tabControl1.TabPages[this.form4Index].Controls.Add(form4);
                form4.Dock = DockStyle.Fill;
                form4.Show();
            }
            tabControl1.SelectedIndex = this.form4Index;
        }
    }
}
