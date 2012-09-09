using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using ns7.bhaswor;
//using System.Runtime.InteropServices;

namespace ns7.sadh.RomanBangla
{
    public partial class RomanBanglaForm : Form
    {
        delegate void SetTextCallback(string text);
        private Thread demoThread = null;
        public RomanBanglaForm()
        {
            InitializeComponent();
        }
        void writeIt()
        {
            this.demoThread = new Thread(new ThreadStart(this.ThreadProcSafe));
            this.demoThread.Start();
        }

        private void ThreadProcSafe()
        {
            this.SetText(ns7.bhaswor.LikhonPad.JuktiKendro.parseWrite(inputText.Text));
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.outputText.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.outputText.Text = text;
                this.outputText.AppendText(" ");
            }
        }

        private void Clickkkkk(object sender, EventArgs e)
        {
            writeIt(); 
        }

        private void fontClick(object sender, EventArgs e)
        {
            fontDialog1.Font = outputText.Font;
            fontDialog1.ShowDialog();
            outputText.Font = fontDialog1.Font;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            writeIt();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                  "This application is by Khan Muhammad Nafee Mostafa Sadh\n"
                + "এই সফ্‌টওয়ারটি খান মুহাম্মাদ নাফী মোস্তফা সাধ এর বানানো\n"
                + "هذا البرنامج يقوم بها خن محمد نافع مصطفى ساده\n"
                + "Αυτό το λογισμικό είναι χτισμένο από Κηαν Μυηαμμαδ Ναφεε Μοσταφα Σαδη\n"
                + "\nsadh@nafsadh.org\n"
                + "Tangail, Bangladesh", "LikhonPad from nafSadh.org");
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(outputText.Text);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            outputText.Text = openFileDialog1.FileName;
        }

        private void convFileButton_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(openFileDialog1.FileName,Encoding.ASCII);
            FileStream file = File.Create(openFileDialog1.FileName + ".html");
            file.Close();
            int i = 0;
            foreach (string line in lines)
            {
                lines[i]= ns7.bhaswor.LikhonPad.htmlUnicode.htmlhex2bn(line);
                outputText.AppendText(lines[i]); i++;
            }
            File.WriteAllLines(openFileDialog1.FileName + ".html", lines, Encoding.Unicode);

           // outputText.Text = openFileDialog1.FileName + " DONE";
        }
    }
}
