using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Görev_yöneticisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var uygulama = listBox1.SelectedItem;
                Process[] processes = Process.GetProcessesByName(uygulama.ToString());

                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
            catch (Exception)
            {
                label1.Text = "Bunu Kapatamazsın";
            }
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcesses();

            listBox1.Items.Clear();
            foreach (Process process in processes)
            {
                listBox1.Items.Add(process.ProcessName.ToLower());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int sonuc;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(textBox1.Text))
                {
                    listBox1.SetSelected(i, true);
                }


                //sonuc = string.Compare(textBox1.Text, listBox1.Items[i].ToString().ToString());
                //label1.Text = sonuc.ToString();

            }
        }
    }
}
