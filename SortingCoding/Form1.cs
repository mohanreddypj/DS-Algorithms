using SortingCoding.Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingCoding
{
    public partial class Form1 : Form
    {
        int[] inputArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            inputArray = (from item in txtInput.Text.Split(',')
                          where !String.IsNullOrEmpty(item)
                          select Convert.ToInt32(item)
                          ).ToArray();
        }

        // BUBBLE SORT
        private void btnBubbleSort_Click(object sender, EventArgs e)
        {
            BubbleSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        // INSERTION SORT
        private void btnInsertionSort_Click(object sender, EventArgs e)
        {
            InsertionSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        // SELECTION SORT
        private void btnSelectionSort_Click(object sender, EventArgs e)
        {
            SelectionSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        // MERGE SORT
        private void btnMergeSort_Click(object sender, EventArgs e)
        {
            MergeSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        // QUICK SORT
        private void btnQuickSort_Click(object sender, EventArgs e)
        {
            QuickSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        private void btnHeapSort_Click(object sender, EventArgs e)
        {
            HeapSort_Max.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        private void btnShellSort_Click(object sender, EventArgs e)
        {
            ShellSort.Sort(inputArray);

            lblOutPut.Text = stringify(inputArray);
        }

        private string stringify(int[] toCovert)
        {
            string text = "";

            foreach (int item in toCovert)
            {
                text = text + " " + item.ToString();
            }

            return text;
        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            txtInput.Text = "4,5,2,8,6,0,1,10,100,150,125,100";
            lblOutPut.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random randomGen = new Random();
            inputArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                inputArray[i] = randomGen.Next(100);
                //txtInput.Text = txtInput.Text + inputArray[i].ToString();
            }
        }

       
    }
}
