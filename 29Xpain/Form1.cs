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


       void szybkie_sortowanie(int[] tab, int lewy, int prawy)
        {
            if (prawy <= lewy) return;

            int i = lewy - 1, j = prawy + 1,
            pivot = tab[(lewy + prawy) / 2];
            
            while (true)
            {
                while (pivot > tab[++i]) ;
                while (pivot < tab[--j]) ;
                if (i <= j)
                {
                    int it = i;
                    tab[i] = tab[j];
                    tab[j] = tab[it];
                }
                else
                    break;
            }

            if (j > lewy)
                szybkie_sortowanie(tab, lewy, j);
            if (i < prawy)
                szybkie_sortowanie(tab, i, prawy);
        }
      
     

        private void srtbtn_Click_1(object sender, EventArgs e)
        {
            //wczytanie pliku
            string fileContent = File.ReadAllText("somefile.txt");
            string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int[] integers = new int[integerStrings.Length];
            int ind = 0;
            for (int n = 0; n < integerStrings.Length; n++)
            {
                integers[n] = int.Parse(integerStrings[n]);
                ind++;
            }
            // 
            // Sortowanie przez wstawianie
            Lwstaw.Text = "";
            sortowanie(ind, integers);
            for (int i = 0; i < ind; i++)
            {
                Lwstaw.Text += integers[i] + "\n";
            }
            // Sortowanie bąbelkowe
            Lbabel.Text = "";
            sortowane_bobelkowe(integers);
            for (int i = 0; i < ind; i++)
            {
                Lbabel.Text += integers[i] + "\n";
            }
            // Szybkie sortowanie
             Lszybkie.Text = "";
             szybkie_sortowanie(integers, 0, ind - 1);
             for (int i = 0; i < ind; i++)
             {
                 Lszybkie.Text += integers[i] + "\n";
             }
        }
    }
    
        
       
}

