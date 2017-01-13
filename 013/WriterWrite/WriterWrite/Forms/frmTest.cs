using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WriterWrite.Forms
{
    public partial class frmTest : Form
    {
        string dir = Directory.GetCurrentDirectory();

        int clickCount = 0;
        public frmTest()
        {
            InitializeComponent();
            Console.WriteLine(dir);
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("frmTest Has Loaded");
        }

        private void frmTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("frmTest Has Closed");
        }

        private void frmTest_Click(object sender, EventArgs e)
        {
            ++clickCount;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("You have clicked formTest " + clickCount + " times");
        }
    }
}
