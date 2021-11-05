using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace LysenkovApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dlg.FileName, Encoding.UTF8);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }

            dlg.Dispose();


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dlg.FileName);
                for (int i = 0; i < listBox3.Items.Count; i++)
                {
                    writer.WriteLine((string)listBox3.Items[i]);
                }
                writer.Close();
            }

            dlg.Dispose();


        }
    }
}