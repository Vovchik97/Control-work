using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiSD_KR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static int[] GenerateCauchyArray(int size, double a, double b)
        {
            int[] arrayNumbers = new int[size];

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                double u = random.NextDouble();

                double x = a + b * Math.Atan(2 / (Math.PI * (2 * u - 1)));

                arrayNumbers[i] = (int)Math.Round(x);
            }

            return arrayNumbers;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            list_Sort_Array.Items.Clear();
            list_Origin_Array.Items.Clear();


            textBox_Time.Clear();
            textBox_Comparisons.Clear();
            textBox_Swaps.Clear();
            textBox_Time.Enabled = false;
            textBox_Comparisons.Enabled = false;
            textBox_Swaps.Enabled = false;

            button_Clear_Changed(sender, e);
        }

        private void button_Sort_Click(object sender, EventArgs e)
        {
            int N = int.Parse(textBox_N.Text);
            double A = double.Parse(textBox_A.Text);
            double B = double.Parse(textBox_B.Text);

            int[] array = GenerateCauchyArray(N, A, B);
            int[] sortedArray = new int[N];

            Array.Copy(array, sortedArray, N);

            int comparisonsCount = 0;
            int swapsCount = 0;

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sortedArray = Counting_Sort.CountingSort(sortedArray, ref comparisonsCount, ref swapsCount);
            stopwatch.Stop();

            DisplayOriginArray(array);
            DisplaySortedArray(sortedArray);
            DisplayStat(stopwatch.Elapsed.TotalMilliseconds, comparisonsCount, swapsCount);

            button_Clear_Changed(sender, e);

        }

        private void DisplayOriginArray(int[] array)
        {
            list_Origin_Array.Items.Clear();
            List<ListViewItem> listOriginItems = new List<ListViewItem>();

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());

                listOriginItems.Add(item);
            }
            list_Origin_Array.Items.AddRange(listOriginItems.ToArray());
        }

        private void DisplaySortedArray(int[] array)
        {
            list_Sort_Array.Items.Clear();
            List<ListViewItem> listSortItems = new List<ListViewItem>();

            for (int i = 0; i < array.Length; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(array[i].ToString());

                listSortItems.Add(item);
            }
            list_Sort_Array.Items.AddRange(listSortItems.ToArray());
        }

        private void DisplayStat(double countingTime, int comparisonsCount, int swapsCount)
        {
            textBox_Time.Text = countingTime.ToString();
            textBox_Comparisons.Text = comparisonsCount.ToString();
            textBox_Swaps.Text = swapsCount.ToString();
            textBox_Time.Enabled = true;
            textBox_Comparisons.Enabled = true;
            textBox_Swaps.Enabled = true;
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            CalcForm calcForm = new CalcForm();

            calcForm.ShowDialog();
        }

        private void textBox_N_TextChanged(object sender, EventArgs e)
        {
            if (textBox_N.Text.Length > 0 && textBox_A.Text.Length > 0 && textBox_B.Text.Length > 0)
            {
                if (int.TryParse(textBox_N.Text, out int n))
                {
                    if (n >= 9000 && n <= 10000)
                    {
                        button_Sort.Enabled = true;
                    }

                    else if (n >= 10000 && n <= 50000)
                    {
                        button_Sort.Enabled = true;
                    }

                    else
                    {
                        button_Sort.Enabled = false;
                    }
                }

                else
                {
                    textBox_N.Text = string.Empty;
                }
            }

            else
            {
                button_Sort.Enabled = false;
            }
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            if (textBox_A.Text.Length > 0)
            {
                if (double.TryParse(textBox_A.Text, out double a))
                {
                    textBox_N_TextChanged(sender, e);
                }

                else
                {
                    textBox_A.Text = string.Empty;
                    button_Sort.Enabled = false;
                }
            }

            else
            {
                button_Sort.Enabled = false;
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            if (textBox_B.Text.Length > 0)
            {
                if (double.TryParse(textBox_B.Text, out double b))
                {
                    textBox_A_TextChanged(sender, e);
                }

                else
                {
                    textBox_B.Text = string.Empty;
                    button_Sort.Enabled = false;
                }
            }

            else
            {
                button_Sort.Enabled = false;
            }
        }

        private void button_Clear_Changed(object sender, EventArgs e)
        {
            if (list_Sort_Array.Items.Count > 0)
            {
                button_Clear.Enabled = true;
            }

            else
            {
                button_Clear.Enabled = false;
            }
        }
    }
}
