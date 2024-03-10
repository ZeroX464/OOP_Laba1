using OOP_Laba1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOP_Laba1
{
    public partial class Laba1 : Form
    {
        Graphics g;
        bool MouseMoving = false;
        bool DrawStart = false;
        Pen pen;
        Point? previousPoint = null;
        Bitmap bufferBitmap;
        Bitmap bufferBitmap2;

        public Laba1()
        {
            InitializeComponent();
            this.ContextMenuStrip = contextMenuStrip1;
            this.DoubleBuffered = true;
            bufferBitmap = new Bitmap(this.Width, this.Height);
            //bufferBitmap = new Bitmap(ActiveForm.Width, ActiveForm.Height);
            pen = new Pen(Color.Black, 5);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBoxStart.Text = "Success";
            TextBoxStart.Visible = true;
            ButtonStart.Visible = false;
            CheckBoxPinkTheme.Visible = true;
            CheckedListBox123.Visible = true;
            ComboBox123.Visible = true;
            labelDate.Visible = true;
            dateTimePickerGoogle.Visible = true;
            linkLabelGoogle.Visible = true;
            listBox.Visible = true;
            pictureBox1.Visible = true;
            numericUpDown1.Visible = true;
            progressBar1.Visible = true;
            TimerProgressBar.Start();
            statusStrip1.Visible = true;
            DateBox.Visible = true;
            splitContainer1.Visible = true;
            tableLayoutPanel1.Visible = true;
            tabControl1.Visible = true;
            panel1.Visible = true;
        }

        private void tbStart_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxStart.Text == "Exit") {
                TextBoxStart.Visible = false;
                ButtonStart.Visible = true;
                CheckBoxPinkTheme.Visible = false;
                CheckedListBox123.Visible = false;
                ComboBox123.Visible = false;
                labelDate.Visible = false;
                dateTimePickerGoogle.Visible = false;
                linkLabelGoogle.Visible = false;
                listBox.Visible = false;
                pictureBox1.Visible = false;
                numericUpDown1.Visible = false;
                progressBar1.Visible = false;
                statusStrip1.Visible = false;
                DateBox.Visible = false;
                splitContainer1.Visible = false;
                tableLayoutPanel1.Visible = false;
                tabControl1.Visible = false;
                panel1.Visible = false;
            }
        }

        private void cbPinkTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxPinkTheme.Checked == true)
            {
                this.BackColor = Color.Pink;
                TextBoxStart.BackColor = Color.Pink;
                
                
            }
            else
            {
                this.BackColor = Color.White;
                TextBoxStart.BackColor = Color.White;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox123.SelectedIndex > 2) { ErrorComboBox.SetError(ComboBox123, "It's too dangerous to choose"); }
            else
            {
                CheckedListBox123.SetItemChecked(ComboBox123.SelectedIndex, !CheckedListBox123.GetItemChecked(ComboBox123.SelectedIndex));
            }
        }

        private void linkLabelGoogle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void dateTimePickerGoogle_CloseUp(object sender, EventArgs e)
        {
            int Year = 0;
            if (dateTimePickerGoogle.Value.Day < DateTime.Now.Day) { Year -= 1; }
            else if (dateTimePickerGoogle.Value.Day < DateTime.Now.Month) { Year -= 1; }
            if (Year + DateTime.Now.Year - dateTimePickerGoogle.Value.Year >= 18)
            {
                linkLabelGoogle.Enabled = true;
                labelDate.Text = "Now you can go to Google";
            }
            else
            {
                linkLabelGoogle.Enabled = false;
                labelDate.Text = "You are under 18 and you can't access Google";
            }
        }

        private void listBoxGoogle_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\TEST\\Laba1\\OOP_Laba1\\OOP_Laba1\\Properties\\Faces\\" + listBox.Text + ".png";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Value = (int) numericUpDown1.Value;
        }

        private void Laba1_SizeChanged(object sender, EventArgs e)
        {
            progressBar1.Width = Laba1.ActiveForm.Width;
            if (WindowState != FormWindowState.Minimized)
            {
                bufferBitmap2 = new Bitmap(ActiveForm.Width, ActiveForm.Height);
                using (Graphics g = Graphics.FromImage(bufferBitmap2))
                {
                    g.FillRectangle(SystemBrushes.Control, 0, 0, bufferBitmap2.Width, bufferBitmap2.Height);
                    g.DrawImage(bufferBitmap, 0, 0, bufferBitmap.Width, bufferBitmap.Height);
                }
                bufferBitmap = bufferBitmap2;
            }
        }

        private void TimerProgressBar_Tick(object sender, EventArgs e)
        {
            int random = new Random().Next(1, 20) - 10;
            if (numericUpDown1.Value + random < numericUpDown1.Maximum && numericUpDown1.Value + random > numericUpDown1.Minimum)
            {
                numericUpDown1.Value += random;
            }
        }

        private void createButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button DeleteButton = new System.Windows.Forms.Button();
            DeleteButton.Location = new System.Drawing.Point(PointToClient(Cursor.Position).X - DeleteButton.Width / 2, PointToClient(Cursor.Position).Y - DeleteButton.Height / 2);
            DeleteButton.Text = "Delete";
            DeleteButton.Click += DeleteButton_Click;
            this.Controls.Add(DeleteButton);
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.Controls.Remove((Control)sender);
        }

        private void TextBoxMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { MessageBox.Show(TextBoxMessage.Text); }
        }

        private void Laba1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = "Current mouse coordinates:" + " X = " + e.X.ToString() + " Y = " + e.Y.ToString();
            if (DrawStart && MouseMoving)
            {
                g = Graphics.FromImage(bufferBitmap);
                g.DrawLine(pen, previousPoint.Value, e.Location);
                previousPoint = e.Location;
                this.Invalidate();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            labelSplitContainer1.Text = (100 * splitContainer1.Panel1.Width / (splitContainer1.Width - splitContainer1.SplitterWidth)).ToString() + '%';
            labelSplitContainer2.Text = (100 - 100 * splitContainer1.Panel1.Width / (splitContainer1.Width - splitContainer1.SplitterWidth)).ToString() + '%';
        }

        private void TableButton1_MouseEnter(object sender, EventArgs e)
        {
            TableButton1.BackColor = Color.Blue;
            TableButton1.ForeColor = Color.Red;
        }

        private void TableButton1_Click(object sender, EventArgs e)
        {
            TableButton1.BackColor = SystemColors.Control;
            TableButton1.ForeColor = SystemColors.ControlText;
        }

        private void TableButton2_MouseEnter(object sender, EventArgs e)
        {
            TableButton2.BackColor = Color.Green;
            TableButton2.ForeColor = Color.Yellow;
        }

        private void TableButton2_Click(object sender, EventArgs e)
        {
            TableButton2.BackColor = SystemColors.Control;
            TableButton2.ForeColor = SystemColors.ControlText;
        }

        private void TableButton3_MouseEnter(object sender, EventArgs e)
        {
            TableButton3.BackColor = Color.Yellow;
            TableButton3.ForeColor = Color.Green;
        }

        private void TableButton3_Click(object sender, EventArgs e)
        {
            TableButton3.BackColor = SystemColors.Control;
            TableButton3.ForeColor = SystemColors.ControlText;
        }

        private void TableButton4_MouseEnter(object sender, EventArgs e)
        {
            TableButton4.BackColor = Color.Red;
            TableButton4.ForeColor = Color.Blue;
        }

        private void TableButton4_Click(object sender, EventArgs e)
        {
            TableButton4.BackColor = SystemColors.Control;
            TableButton4.ForeColor = SystemColors.ControlText;
        }

        private void exitToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Laba1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bufferBitmap, 0, 0);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }

        private void Laba1_MouseDown(object sender, MouseEventArgs e)
        {
            if (DrawStart)
            {
                MouseMoving = true;
                previousPoint = e.Location;
                this.Cursor = Cursors.Cross;
            }
        }

        private void Laba1_MouseUp(object sender, MouseEventArgs e)
        {
            if (DrawStart)
            {
                MouseMoving = false;
                this.Cursor = Cursors.Default;
                previousPoint = null;
            }
            
        }

        private void startToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            DrawStart = !DrawStart;
            if (DrawStart) { startToolStripMenuItem.BackColor = Color.LightGreen; }
            else { startToolStripMenuItem.BackColor = SystemColors.Control; }
        }

        private void clearToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            bufferBitmap = new Bitmap(Width, Height);
            this.Refresh();
        }

        private void hideShowStartButtonToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            ButtonStart.Visible = !ButtonStart.Visible;
        }
    }
}   
