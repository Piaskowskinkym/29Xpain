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
        public decimal powotorzenia;
 

        public void sortowanie(int n, int[] tab)
            {
            DateTime startTime = DateTime.Now;
            int pom, j;
                for (int i = 1; i < n; i++)
                {
                    pom = tab[i];
                    j = i - 1;

                    while (j >= 0 && tab[j] > pom)
                    {
                        tab[j + 1] = tab[j];
                        --j;
                    }
                    tab[j + 1] = pom;
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

        void szybkie_sortowanie(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = przedzial(arr, left, right);

                if (pivot > 1)
                {
                    szybkie_sortowanie(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    szybkie_sortowanie(arr, pivot + 1, right);
                }
            }

        }
        int przedzial(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }


        void sortowanie_kopcowe(int[] tab)
        {
            int n = tab.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                kopcowanie(tab, n, i);

            for (int i = n - 1; i > 0; i--)
            {
               
                int temp = tab[0];
                tab[0] = tab[i];
                tab[i] = temp;

          
                kopcowanie(tab, i, 0);
            }
        }
        void kopcowanie(int[] arr, int n, int i)
        {
            int largest = i; 
            int l = 2 * i + 1; 
            int r = 2 * i + 2; 

          
            if (l < n && arr[l] > arr[largest])
                largest = l;

         
            if (r < n && arr[r] > arr[largest])
                largest = r;

          
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;

               
                kopcowanie(arr, n, largest);
            }
        }

        static public void scal(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, eol, num, pos;
            eol = (mid - 1);
            pos = left;
            num = (right - left + 1);

            while ((left <= eol) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid])
                    temp[pos++] = numbers[left++];
                else
                    temp[pos++] = numbers[mid++];
            }
            while (left <= eol)
                temp[pos++] = numbers[left++];
            while (mid <= right)
                temp[pos++] = numbers[mid++];
            for (i = 0; i < num; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void sortowanie_scalanie(int[] numbers, int left, int right)
        {
            int mid;
            if (right > left)
            {
                mid = (right + left) / 2;
                sortowanie_scalanie(numbers, left, mid);
                sortowanie_scalanie(numbers, (mid + 1), right);
                scal(numbers, left, (mid + 1), right);
            }
        }

        private void srtwbtn_Click(object sender, EventArgs e)
          {
            OpenFileDialog otworzplik = new OpenFileDialog();
            otworzplik.InitialDirectory = "c:\\";
            otworzplik.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otworzplik.FilterIndex = 2;
            otworzplik.RestoreDirectory = true;
            if (otworzplik.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(otworzplik.FileName);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                }
                Lplikw.Text = otworzplik.SafeFileName;
                //Liczba powtórzeń
                int l = 0;
                powotorzenia = powtorzenianUD.Value;
                //Liczenie czasu
                DateTime startTime = DateTime.Now;
                // Sortowanie przez wstawianie
                while (l < powotorzenia)
                { 
                    Lwstaw.Text = "";
                  sortowanie(integers.Length, integers);
                    for (int i = 0; i < integers.Length; i++)
                    {
                        Lwstaw.Text += integers[i] + "\n";
                    }
                    l++;
                }
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                new DateTime(roznica.Ticks).ToString("fff");
                Lwczas.Text += " " + roznica;

            }
            
          }

          private void srtbbtn_Click(object sender, EventArgs e)
          {
            OpenFileDialog otworzplik = new OpenFileDialog();
            otworzplik.InitialDirectory = "c:\\";
            otworzplik.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otworzplik.FilterIndex = 2;
            otworzplik.RestoreDirectory = true;
            if (otworzplik.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(otworzplik.FileName);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                }
                Lbplik.Text = otworzplik.SafeFileName;
                // Sortowanie bąbelkowe
                int l = 0;
                powotorzenia = powtorzenianUD.Value;
                DateTime startTime = DateTime.Now;
                while (l < powotorzenia)
                {
                    Lbabel.Text = "";
                    sortowane_bobelkowe(integers);
                    for (int i = 0; i < integers.Length; i++)
                    {
                        Lbabel.Text += integers[i] + "\n";
                    }
                    l++;
                }
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                new DateTime(roznica.Ticks).ToString("fff");
                Lbczas.Text += " " + roznica;
            }
          }

        private void srtsbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworzplik = new OpenFileDialog();
            otworzplik.InitialDirectory = "c:\\";
            otworzplik.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otworzplik.FilterIndex = 2;
            otworzplik.RestoreDirectory = true;
            if (otworzplik.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(otworzplik.FileName);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                }
                Lkplik.Text = otworzplik.SafeFileName;
                // Szybkie sortowanie
                int l = 0;
                powotorzenia = powtorzenianUD.Value;
                DateTime startTime = DateTime.Now;
                while (l < powotorzenia)
                {
                    Lszybkie.Text = "";
                   szybkie_sortowanie(integers, 0, integers.Length-1);
                    for (int i = 0; i < integers.Length; i++)
                    {
                        Lszybkie.Text += integers[i] + "\n";
                    }
                    l++;
                }
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                new DateTime(roznica.Ticks).ToString("fff");
                Lsczas.Text += " " + roznica;
            }


        }


        private void srthbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog otworzplik = new OpenFileDialog();
            otworzplik.InitialDirectory = "c:\\";
            otworzplik.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otworzplik.FilterIndex = 2;
            otworzplik.RestoreDirectory = true;
            if (otworzplik.ShowDialog() == DialogResult.OK)
            {
                string fileContent = File.ReadAllText(otworzplik.FileName);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                }

                Lsplik.Text = otworzplik.SafeFileName;
                int l = 0;
                powotorzenia = powtorzenianUD.Value;
                DateTime startTime = DateTime.Now;
                while (l < powotorzenia)
                {
                    Lkopcowanie.Text = "";
                    sortowanie_kopcowe(integers);
                    for (int i = 0; i < integers.Length; i++)
                    {
                        Lkopcowanie.Text += integers[i] + "\n";
                    }
                    l++;
                }
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                new DateTime(roznica.Ticks).ToString("fff");
                Lkczas.Text += " " + roznica;
            }

        }

      

        private void srtscbtn_Click(object sender, EventArgs e)
        {
            //wczytanie pliku
            OpenFileDialog otworzplik = new OpenFileDialog();
            otworzplik.InitialDirectory = "c:\\";
            otworzplik.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            otworzplik.FilterIndex = 2;
            otworzplik.RestoreDirectory = true;
            if (otworzplik.ShowDialog() == DialogResult.OK)
            {
                //stworzenie tabeli zwierającą dane z pliku
                string fileContent = File.ReadAllText(otworzplik.FileName);
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                int[] integers = new int[integerStrings.Length];
                for (int n = 0; n < integerStrings.Length; n++)
                {
                    integers[n] = int.Parse(integerStrings[n]);
                }
                //wyświetlenie nazwy pliku
                Lscplik.Text = otworzplik.SafeFileName;
                //liczba powtózeńsortowania
                int l = 0;
                powotorzenia = powtorzenianUD.Value;
                //rozpoczęcie liczenia czasu
                DateTime startTime = DateTime.Now;
                while (l < powotorzenia)
                {
                    //sortowanie przez scalanie
                    Lscalanie.Text = "";
                    sortowanie_scalanie(integers, 0, integers.Length-1);
                    for (int i = 0; i < integers.Length; i++)
                    {
                        Lscalanie.Text += integers[i] + "\n";
                    }
                    l++;
                }
                //zakończenie liczenia czasu
                DateTime stopTime = DateTime.Now;
                TimeSpan roznica = stopTime - startTime;
                new DateTime(roznica.Ticks).ToString("fff");
                //wypisanie czasu sortowania
                Lscczas.Text += " " + roznica;
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}

