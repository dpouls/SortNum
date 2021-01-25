using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SortNum
{
    public partial class SortNumbersForm : Form
    {
        string filename = "nums.txt";
        
        public SortNumbersForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Save user input to file and to LstBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TxtBoxNumber.Text, out double userNumber))
            {
                StreamWriter outputFile;
                try
                {
                    outputFile = File.AppendText(filename);
                    outputFile.WriteLine(userNumber);
                    outputFile.Close();
                    LstBoxNumbers.Items.Add(userNumber.ToString());
                    TxtBoxNumber.Clear();
                    TxtBoxNumber.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
        /// <summary>
        /// Sort Numbers in LstBox from smallest to largest
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSort_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Load initial numbers from file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortNumbersForm_Load(object sender, EventArgs e)
        {
            StreamReader inputFile;
            StreamWriter outputFile;

            try
            {
            if (!File.Exists(filename))
            {
                outputFile = File.CreateText(filename);
                outputFile.Close();
            }
            inputFile = File.OpenText(filename);
                while (!inputFile.EndOfStream)
                {
                    LstBoxNumbers.Items.Add(inputFile.ReadLine());
                }
            inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            

        }


    }
}
