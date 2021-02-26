using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "(*.txt)|*.txt";
            f.FileName = "wszz.txt";
            f.InitialDirectory = Application.ExecutablePath;
            if(f.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(Path.GetFullPath(f.FileName), richTextBox1.Text);
            }
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "(*.txt)|*.txt";
            if(f.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(Path.GetFullPath(f.FileName));
            }
        }

        private void github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/byyyxd");
        }
    }
}
