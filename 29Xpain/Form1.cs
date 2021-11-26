using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29Xpain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }


        

        void sortowanie(int n, int[] tab)
        {
            int pom, j;
            for (int i = 1; i < n; i++)
            {
                pom = tab[i];
                j = i - 1;

                while (j >= 0 && tab[j] > pom)
                {
                    tab[j + 1] = tab[j]; //przesuwanie elementów
                    --j;
                }
                tab[j + 1] = pom; //wstawienie pom w odpowiednie miejsce
            }
        }

        void sortowane_bobelkowe(int[] tab)
        {
            int b = tab.Length;
            do
            {
                for (int i = 0; i < b - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tmp;
                    }
                }
                b--;
            }
            while (b > 1);
        }

      

        
        private void button1_Click(object sender, EventArgs e)
        {
            string fileContent = File.ReadAllText("somefile.txt");
            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            int ind = 0;
            for (int n = 0; n < integerStrings.Length; n++)
            {
                integers[n] = int.Parse(integerStrings[n]);
                ind++;
            }
                

            label2.Text = "";
            sortowanie(ind,integers);
            for (int i = 0; i < ind; i++)
            {
                label2.Text += integers[i] + "\n";
            }

            label3.Text = "";
            sortowane_bobelkowe(integers);
            for (int i = 0; i < ind; i++)
            {
                label3.Text += integers[i] + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            string fileContent = File.ReadAllText("somefile.txt");
            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            int licznik;
            for (int n = 0; n < integerStrings.Length; n++)
                integers[n] = int.Parse(integerStrings[n]);
               
           
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
        
       
}

