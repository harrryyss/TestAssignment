using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAssignment
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void inputnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;


            //if (ch == 46 && inputnumber.Text.IndexOf('.') != -1)
            //{
            //    e.Handled = true;
            //    return;
            //}
            if (!Char.IsDigit(ch) && (ch != '.') && (ch != 44) && (ch != (char)Keys.Back))
            {
                e.Handled = true;
                MessageBox.Show("Only Numbers,Decimal And Comma");
            }
            //if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && (ch != (char)Keys.Back))
            //{
            //    e.Handled = true;
            //}

        }


        private void button1_Click(object sender, EventArgs e)
        {
            double number;
            //number = Convert.ToDouble(inputnumber.Text);


            //string[] array = inputnumber.Text.Split(",");
            double[] arrayQuick = inputnumber.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] ArrayBubble = inputnumber.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            double[] arrayMerge = inputnumber.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            //double[] arrayGCF = inputnumber.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();

            QuickSort(arrayQuick, 0, arrayQuick.Length - 1);
            double[] numberBubble = BubbleSort(ArrayBubble);
            MergeSort(arrayMerge, 0, arrayMerge.Length - 1);

            dataSort(arrayQuick, numberBubble, arrayMerge);
        }

        public int Partition(double[] numbers, int left, int right) {

            double pivot = numbers[left];

            while (true) { 
                while (numbers[left] < pivot) 
                    left++;
                while (numbers[right] > pivot)
                    right--;
                if (left < right) {
                    double temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else {
                    return right;
                }
            }
        }

        public void QuickSort(double[] arr, int left, int right) {

            long time1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            if (left < right) {
                int pivot = Partition(arr, left, right);
                if (pivot > 1)
                    QuickSort(arr, left, pivot - 1);
                if (pivot + 1 < right)
                    QuickSort(arr, pivot + 1, right);
            }
            long time2 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            timequick.Text = (time2 - time1).ToString() + " ms";
        }

        public double[] BubbleSort(double[] array)
        {
            long time1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            double temp = 0;

            for (int write = 0; write < array.Length; write++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort + 1];
                        array[sort + 1] = array[sort];
                        array[sort] = temp;
                    }
                }
            }
            long time2 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            timebubble.Text = (time2 - time1).ToString() + " ms";
            return array;
        }

        public void MainMerge(double[] numbers, int left, int mid, int right)
        {
            double[] temp = new double[25];
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

        public void MergeSort(double[] numbers, int left, int right)
        {            
            int mid;
            long time1 = DateTimeOffset.Now.ToUnixTimeMilliseconds();

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort(numbers, left, mid);
                MergeSort(numbers, (mid + 1), right);
                MainMerge(numbers, left, (mid + 1), right);
            }
            long time2 = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            timemerge.Text = (time2 - time1).ToString() + " ms";
        }
     

        private void dataSort(double[] numberQuick, double[] numberBubble, double[] numberMerge)
        {
            //dataquick
            dataquick.ColumnCount = 1;
            dataquick.Columns[0].Name = "Sort Numbers";

            for (int i = 0; i < numberQuick.Length; i++)
            {
                dataquick.Rows.Add(numberQuick[i]);
                Task.Delay(150).Wait();
            }

            //databubble
            databubble.ColumnCount = 1;
            databubble.Columns[0].Name = "Sort Numbers";

            for (int i = 0; i < numberBubble.Length; i++) 
            {
                databubble.Rows.Add(numberBubble[i]);
                Task.Delay(150).Wait();
            }
            //datamerge
            datamerge.ColumnCount = 1;
            datamerge.Columns[0].Name = "Sort Numbers";

            for (int i = 0; i < numberMerge.Length; i++) 
            {
                datamerge.Rows.Add(numberMerge[i]);
                Task.Delay(150).Wait();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sortbutton.Visible = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataquick_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void databubble_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        
    }
}
