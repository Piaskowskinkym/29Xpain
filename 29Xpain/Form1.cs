using System;
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
            wypelnianie();
        }

        const int n = 10;
        int[] tab = new int[n] ;

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

        void wypelnianie ()
        {

            for (int i = 0; i < 10; i++) {
                
                Random rnd = new Random();
                int es = rnd.Next(-1, 100);

                tab[i] = es;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            sortowanie(n,tab);
            for (int i = 0; i < n; i++)
            {
                label2.Text += tab[i] + "\n";
            }
        }
    }

        
       
}

