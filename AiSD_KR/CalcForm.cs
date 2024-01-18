using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AiSD_KR
{
    public partial class CalcForm : Form
    {
        private static Random random = new Random();
        public CalcForm()
        {
            InitializeComponent();
        }

        public double GenerateRandomNumber()
        {
            return Math.Round(random.NextDouble(), 2);
        }

        private void button_Calc_Click(object sender, EventArgs e)
        {
            listView_Data.Items.Clear();

            double A = GenerateRandomNumber();
            double B = GenerateRandomNumber();

            List<ListViewItem> listViewItems = new List<ListViewItem>();

            Random random = new Random();

            int.TryParse(textBox_Volume.Text, out int numberArrays);

            double[] array_time = new double[numberArrays];
            int[] array_size = new int[numberArrays];

            for (int i = 0; i < numberArrays; i++)
            {
                int numberArguments = random.Next(9000, 50001);

                int[] array = MainForm.GenerateCauchyArray(numberArguments, A, B);

                Stopwatch stopwatch = Stopwatch.StartNew();

                Counting_Sort.CountingSort(array);

                stopwatch.Stop();

                double time = stopwatch.Elapsed.TotalMilliseconds;

                array_time[i] = time;
                array_size[i] = array.Length;

                ListViewItem item = new ListViewItem();
                item.Text = (i + 1).ToString();
                item.SubItems.Add(time.ToString());
                item.SubItems.Add(array.Length.ToString());
                item.SubItems.Add(((long)array.Length * array.Length).ToString());
                item.SubItems.Add((array.Length * time).ToString());

                listViewItems.Add(item);
            }

            listView_Data.Items.AddRange(listViewItems.ToArray());

            int n = Convert.ToInt16(textBox_Volume.Text);
            double sumTime = 0;
            long sumLengthArrays = 0;
            long sumLengthArrays_2 = 0;
            double sumLengthForTime = 0;

            for (int i = 0; i < numberArrays; i++)
            {
                if (double.TryParse(listViewItems[i].SubItems[1].Text, out double value_y))
                {
                    sumTime += value_y;
                }

                if (long.TryParse(listViewItems[i].SubItems[2].Text, out long value_x))
                {
                    sumLengthArrays += value_x;
                }

                if (long.TryParse(listViewItems[i].SubItems[3].Text, out long value_x_2))
                {
                    sumLengthArrays_2 += value_x_2;
                }

                if (double.TryParse(listViewItems[i].SubItems[4].Text, out double value_xy))
                {
                    sumLengthForTime += value_xy;
                }
            }

            textBox_a0_1.Enabled = true;
            textBox_a0_2.Enabled = true;
            textBox_a1_1.Enabled = true;
            textBox_a1_2.Enabled = true;
            textBox_output1.Enabled = true;
            textBox_output2.Enabled = true;

            textBox_a0_1.Text = n.ToString();
            textBox_a0_2.Text = sumLengthArrays.ToString();
            textBox_a1_1.Text = sumLengthArrays.ToString();
            textBox_a1_2.Text = sumLengthArrays_2.ToString();
            textBox_output1.Text = sumTime.ToString();
            textBox_output2.Text = sumLengthForTime.ToString();

            double[,] matrix = 
            {
                {Convert.ToInt64(textBox_a0_1.Text), Convert.ToInt64(textBox_a1_1.Text), Convert.ToDouble(textBox_output1.Text)},
                {Convert.ToInt64(textBox_a0_2.Text), Convert.ToInt64(textBox_a1_2.Text), Convert.ToDouble(textBox_output2.Text)}
            };

            double[] args = GaussMethod.SolveGauss(matrix);

            double a0 = args[0];
            double a1 = args[1];

            textBox_link_a0.Enabled = true;
            textBox_link_a1.Enabled = true;
            textBox_link_a0.Text = a0.ToString();
            textBox_link_a1.Text = a1.ToString();

            textBox_link_y.Enabled = true;
            textBox_link_x.Enabled = true;
            textBox_link_y.Text = textBox_link_a0.Text;
            textBox_link_x.Text = textBox_link_a1.Text;

            double coeff_corel = Сoefficients.CoefficientCorelation(n, array_time, sumLengthArrays, sumTime, sumLengthArrays_2, sumLengthForTime);
            double coeff_deter = Сoefficients.CoefficientDetermination(coeff_corel);
            double coeff_elastic = Сoefficients.CoefficientOfElasticity(a1, n, sumLengthArrays, sumTime);
            double coeff_beta = Сoefficients.BetaCoefficient(a1, n, sumLengthArrays, sumTime, array_size, array_time);

            textBox_elastic.Enabled = true;
            textBox_elastic.Text = coeff_elastic.ToString();

            textBox_beta.Enabled = true;
            textBox_beta.Text = coeff_beta.ToString();

            textBox_korelation.Enabled = true;
            textBox_korelation.Text = coeff_corel.ToString();

            textBox_determination.Enabled = true;
            textBox_determination.Text = coeff_deter.ToString();

            CallChart(n, array_size, array_time, a0, a1);         
        }

        private void CallChart(int n, int[] array_x, double[] array_y, double a0, double a1)
        {
            chart1.Series.Clear();

            Series series1 = new Series("Точечный наблюдённый график");
            Series series2 = new Series("Линейный график");

            series1.Color = Color.Red;
            series2.Color = Color.Blue;

            series1.IsVisibleInLegend = true;
            series2.IsVisibleInLegend = true;

            series1.IsXValueIndexed = false;
            series2.IsXValueIndexed = false;

            series1.ChartType = SeriesChartType.Point;            
            series2.ChartType = SeriesChartType.Line;

            chart1.Series.Add(series1);
            chart1.Series.Add(series2);

            for (int i = 0; i < n; i++)
            {
                series1.Points.AddXY(array_x[i], array_y[i]);

            }

            int x_min = 9000;
            int x_max = 50000;

            double y_min = a0 + a1 * x_min;
            double y_max = a0 + a1 * x_max;

            series2.Points.AddXY(x_min, y_min);
            series2.Points.AddXY(x_max, y_max);
        }

        private void textBox_Volume_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Volume.Text.Length > 0)
            {
                if (int.TryParse(textBox_Volume.Text, out int value))
                {
                    button_Calc.Enabled = true;
                }

                else
                {
                    button_Calc.Enabled = false;
                    textBox_Volume.Text = string.Empty;
                }
            }

            else
            {
                button_Calc.Enabled = false;
            }
        }
    }
}
