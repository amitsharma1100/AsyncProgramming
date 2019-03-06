using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Process("1", lblResult1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process("2", lblResult2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process("3", lblResult3);
        }

        private async void Process(string fileNumber, Label label)
        {
            Task<int> task = new Task<int>(CountCharacters);
            task.Start();

            label.Text = $"Counting characters in file {fileNumber}...";
            int count = await task;
            label.Text = $"Characters in file {fileNumber} : {count}";
        }

        private int CountCharacters()
        {
            int count = 0;

            using (StreamReader reader = new StreamReader("C:\\ecInteractive\\Trace Files\\GuestCheckout-Prop65.txt"))
            {
                string content = reader.ReadToEnd();
                count = content.Length;
            }

            Thread.Sleep(5000);
            return count;
        }
    }
}
