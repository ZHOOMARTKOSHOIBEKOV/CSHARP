using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms.DataVisualization.Charting;

namespace OutlookDemo.UserControls
{
    public partial class Tab_Sort : UserControl
    {

        private int[] randomArray;

        public Tab_Sort()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.radioButtonOddEven = new System.Windows.Forms.RadioButton();
            this.radioButtonRadix = new System.Windows.Forms.RadioButton();
            this.radioButtonFibonacci = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный Массив:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Массив:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выбрать Метод:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(783, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сравнительный анализ:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandom.Location = new System.Drawing.Point(303, 65);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(421, 39);
            this.buttonRandom.TabIndex = 4;
            this.buttonRandom.Text = "Новый рандомный массив";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.richTextBoxResult);
            this.groupBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxResult.Location = new System.Drawing.Point(36, 442);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(1129, 237);
            this.groupBoxResult.TabIndex = 6;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Enter += new System.EventHandler(this.groupBoxResult_Enter);
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxResult.Location = new System.Drawing.Point(6, 25);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.Size = new System.Drawing.Size(1117, 197);
            this.richTextBoxResult.TabIndex = 0;
            this.richTextBoxResult.Text = "";
            // 
            // radioButtonOddEven
            // 
            this.radioButtonOddEven.AutoSize = true;
            this.radioButtonOddEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOddEven.Location = new System.Drawing.Point(44, 221);
            this.radioButtonOddEven.Name = "radioButtonOddEven";
            this.radioButtonOddEven.Size = new System.Drawing.Size(282, 33);
            this.radioButtonOddEven.TabIndex = 7;
            this.radioButtonOddEven.TabStop = true;
            this.radioButtonOddEven.Text = "Пузырьковая(Bubble)";
            this.radioButtonOddEven.UseVisualStyleBackColor = true;
            // 
            // radioButtonRadix
            // 
            this.radioButtonRadix.AutoSize = true;
            this.radioButtonRadix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonRadix.Location = new System.Drawing.Point(44, 256);
            this.radioButtonRadix.Name = "radioButtonRadix";
            this.radioButtonRadix.Size = new System.Drawing.Size(261, 33);
            this.radioButtonRadix.TabIndex = 8;
            this.radioButtonRadix.TabStop = true;
            this.radioButtonRadix.Text = "Шейкерная(Shaker)";
            this.radioButtonRadix.UseVisualStyleBackColor = true;
            // 
            // radioButtonFibonacci
            // 
            this.radioButtonFibonacci.AutoSize = true;
            this.radioButtonFibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFibonacci.Location = new System.Drawing.Point(44, 292);
            this.radioButtonFibonacci.Name = "radioButtonFibonacci";
            this.radioButtonFibonacci.Size = new System.Drawing.Size(292, 33);
            this.radioButtonFibonacci.TabIndex = 9;
            this.radioButtonFibonacci.TabStop = true;
            this.radioButtonFibonacci.Text = "Битоническая(Bitonic)";
            this.radioButtonFibonacci.UseVisualStyleBackColor = true;
            // 
            // buttonSort
            // 
            this.buttonSort.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSort.Location = new System.Drawing.Point(46, 354);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(678, 82);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать по методу";
            this.buttonSort.UseVisualStyleBackColor = false;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click_1);
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResult.Legends.Add(legend1);
            this.chartResult.Location = new System.Drawing.Point(778, 106);
            this.chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult.Series.Add(series1);
            this.chartResult.Size = new System.Drawing.Size(429, 343);
            this.chartResult.TabIndex = 13;
            this.chartResult.Text = "chart1";
            this.chartResult.Click += new System.EventHandler(this.chartResult_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Location = new System.Drawing.Point(39, 137);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(685, 26);
            this.textBoxRandom.TabIndex = 16;
            this.textBoxRandom.TextChanged += new System.EventHandler(this.textBoxRandom_TextChanged);
            // 
            // Tab_Sort
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxRandom);
            this.Controls.Add(this.chartResult);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.radioButtonFibonacci);
            this.Controls.Add(this.radioButtonRadix);
            this.Controls.Add(this.radioButtonOddEven);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Tab_Sort";
            this.Size = new System.Drawing.Size(1229, 714);
            this.Load += new System.EventHandler(this.Tab_Sort_Load);
            this.groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tab_Sort_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void buttonRandom_Click(object sender, EventArgs e)
    {
        // Generate a new random array
        Random rand = new Random();
        randomArray = Enumerable.Range(1, 20).Select(i => rand.Next(1, 100)).ToArray();

        // Clear the TextBox
        textBoxRandom.Clear();

        // Assuming you have a List<int> named randomList
        string itemsAsText = string.Join(", ", randomArray);
        textBoxRandom.AppendText(itemsAsText);

        var oddEvenResult = BubbleSort(randomArray);
        var radixResult = ShakerSort(randomArray);
        var fibonacciResult = BitonicSort(randomArray);

        // Call the chartResult function to display the results
        ChartResultFunction(oddEvenResult, radixResult, fibonacciResult);

    }

    private void ChartResultFunction((int iterations, TimeSpan timeWasted) oddEvenResult,
                    (int iterations, TimeSpan timeWasted) radixResult,
                    (int iterations, TimeSpan timeWasted) fibonacciResult)
    {
        chartResult.Series.Clear();

        // Create a data series for iterations
        var iterationsSeries = new Series("Iterations");
        iterationsSeries.Points.AddXY("BubbleSort", oddEvenResult.iterations);
        iterationsSeries.Points.AddXY("ShakerSort", radixResult.iterations);
        iterationsSeries.Points.AddXY("BitonicSort", fibonacciResult.iterations);

        // Add the iterations series to the chart
        chartResult.Series.Add(iterationsSeries);

        // Create a data series for time wasted
        var timeWastedSeries = new Series("Time Wasted (ms)");
        timeWastedSeries.Points.AddXY("BubbleSort", oddEvenResult.timeWasted.TotalMilliseconds);
        timeWastedSeries.Points.AddXY("ShakerSort", radixResult.timeWasted.TotalMilliseconds);
        timeWastedSeries.Points.AddXY("BitonicSort", fibonacciResult.timeWasted.TotalMilliseconds);

        // Add the time wasted series to the chart
        chartResult.Series.Add(timeWastedSeries);

        // Configure the chart appearance and labels as needed
        chartResult.ChartAreas[0].AxisX.Interval = 1; // Adjust the interval if needed
        chartResult.ChartAreas[0].AxisX.Title = "Algorithm";
        chartResult.ChartAreas[0].AxisY.Title = "Число Интераций / Потраченное время";
    }

    private void buttonSort_Click_1(object sender, EventArgs e)
    {
        richTextBoxResult.Clear();

        if (radioButtonOddEven.Checked)
        {
            var result = BubbleSort(randomArray);
        }
        else if (radioButtonRadix.Checked)
        {
            ShakerSort(randomArray);
        }
        else if (radioButtonFibonacci.Checked)
        {
            BitonicSort(randomArray);
        }
    }

    // Display the current state of the array and explanation in the RichTextBox
    private void DisplaySortingStep(int[] arr, string explanation)
    {
        richTextBoxResult.AppendText(string.Join(", ", arr) + "\n");
        richTextBoxResult.AppendText(explanation + "\n\n");
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }


    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {

    }

    private void radioButtonOddEven_CheckedChanged(object sender, EventArgs e)
    {

    }

    private (int iterations, TimeSpan timeWasted) BubbleSort(int[] arr)
        {
            DateTime startTime = DateTime.Now;
            int n = arr.Length;
            int iterations = 0;
            int[] sortedArr = (int[])arr.Clone();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedArr[j] > sortedArr[j + 1])
                    {
                        // Обмен элементов
                        int temp = sortedArr[j];
                        sortedArr[j] = sortedArr[j + 1];
                        sortedArr[j + 1] = temp;

                        iterations++;

                        // Вывод шага сортировки
                        DisplaySortingStep(sortedArr, $"Итерация {iterations}: Обмен {sortedArr[j]} и {sortedArr[j + 1]}");
                    }
                }
            }

            DateTime endTime = DateTime.Now;
            TimeSpan timeWasted = endTime - startTime;

            // Вывод завершающего сообщения
            DisplaySortingStep(sortedArr, "Сортировка методом пузырька завершена\n" +
                $"Количество итераций: {iterations}\n" +
                $"Затраченное время: {timeWasted}");

            return (iterations, timeWasted);
        }



        private (int iterations, TimeSpan timeWasted) ShakerSort(int[] arr)
        {
            DateTime startTime = DateTime.Now;
            int n = arr.Length;
            int iterations = 0;
            int[] sortedArr = (int[])arr.Clone();
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (sortedArr[i] > sortedArr[i + 1])
                    {
                        // Swap elements
                        int temp = sortedArr[i];
                        sortedArr[i] = sortedArr[i + 1];
                        sortedArr[i + 1] = temp;

                        swapped = true;
                        iterations++;

                        // Display the sorting step
                        DisplaySortingStep(sortedArr, $"Итерация {iterations}: Обмен {sortedArr[i]} и {sortedArr[i + 1]}");
                    }
                }

                if (!swapped)
                    break;

                swapped = false;

                for (int i = n - 1; i > 0; i--)
                {
                    if (sortedArr[i - 1] > sortedArr[i]) // Corrected the condition here
                    {
                        // Swap elements
                        int temp = sortedArr[i - 1];
                        sortedArr[i - 1] = sortedArr[i];
                        sortedArr[i] = temp;

                        swapped = true;
                        iterations++;

                        // Display the sorting step
                        DisplaySortingStep(sortedArr, $"Итерация {iterations}: Обмен {sortedArr[i - 1]} и {sortedArr[i]}");
                    }
                }
            } while (swapped);

            DateTime endTime = DateTime.Now;
            TimeSpan timeWasted = endTime - startTime;

            // Display the final message
            DisplaySortingStep(sortedArr, "Шейкерная сортировка завершена\n" +
                $"Количество итераций: {iterations}\n" +
                $"Затраченное время: {timeWasted}");

            return (iterations, timeWasted);
        }
        private (int iterations, TimeSpan timeWasted) BitonicSort(int[] arr)
        {
            DateTime startTime = DateTime.Now;
            int n = arr.Length;
            int iterations = 0;
            int[] sortedArr = (int[])arr.Clone();

            BitonicSortRecursive(sortedArr, 0, n, true, ref iterations);

            DateTime endTime = DateTime.Now;
            TimeSpan timeWasted = endTime - startTime;

            // Вывод завершающего сообщения
            DisplaySortingStep(sortedArr, "Битоническая сортировка завершена\n" +
                $"Количество итераций: {iterations}\n" +
                $"Затраченное время: {timeWasted}");

            return (iterations, timeWasted);
        }

        private void BitonicSortRecursive(int[] arr, int low, int count, bool direction, ref int iterations)
        {
            if (count > 1)
            {
                int k = count / 2;

                // Прямая битоническая сортировка
                BitonicSortRecursive(arr, low, k, true, ref iterations);

                // Обратная битоническая сортировка
                BitonicSortRecursive(arr, low + k, k, false, ref iterations);

                // Слияние двух подпоследовательностей
                BitonicMerge(arr, low, count, direction, ref iterations);
            }
        }

        private void BitonicMerge(int[] arr, int low, int count, bool direction, ref int iterations)
        {
            if (count > 1)
            {
                int k = count / 2;
                for (int i = low; i < low + k; i++)
                {
                    CompareAndSwap(arr, i, i + k, direction, ref iterations);
                }
                BitonicMerge(arr, low, k, direction, ref iterations);
                BitonicMerge(arr, low + k, k, direction, ref iterations);
            }
        }

        private void CompareAndSwap(int[] arr, int i, int j, bool direction, ref int iterations)
        {
            if (direction == (arr[i] > arr[j]))
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                iterations++;

                // Вывод шага сортировки
                DisplaySortingStep(arr, $"Итерация {iterations}: Обмен {arr[i]} и {arr[j]}");
            }
        }



        private void Form1_Load(object sender, EventArgs e)
    {

    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chartResult_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {

        }

        private void listBoxRandom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRandom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
