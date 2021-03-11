using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformLesson3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("Write Code");
            checkedListBox1.Items.Add("Reading");
            checkedListBox1.Items.Add("Do Sport");




            List<Language> languages = new List<Language>
            {
                new Language
                {
                    Name="English"
                },
                new Language
                {
                    Name="Russion"
                },
                new Language
                {
                    Name="Azerbaijani"
                },
            };


            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = languages;




        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                stringBuilder.Append($"\n{item}");
            }

            label1.Text = stringBuilder.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((comboBox1.SelectedItem as Language)?.Name);
        }
    }
}
