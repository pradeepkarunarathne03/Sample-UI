using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calculate()
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text); 

            MyCalculation objMyCalculation = new MyCalculation();
            int result = objMyCalculation.CalculateSquare(firstNumber, secondNumber);

            txtResult.Text = result.ToString();

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(txtFirstNumber.Text);
            int secondNumber = int.Parse(txtSecondNumber.Text);
            
            if(firstNumber > 0 && secondNumber > 0)
            {
                Calculate();

            }
            else
            {
                MessageBox.Show("Data Not Valid");
            }
        }

        public class EmployeeSalary
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }
        }


        private void readDataGridViewData()
        {
            //for (int i = 0; i < dgvEmployeeSalaryData.RowCount - 1; i++)
            //{                 
            //    string Name = dgvEmployeeSalaryData.Rows[i].Cells["Name"].Value.ToString();
            //    int Age = int.Parse(dgvEmployeeSalaryData.Rows[i].Cells["Age"].Value.ToString());
            //    int Salary = int.Parse(dgvEmployeeSalaryData.Rows[i].Cells["Salary"].Value.ToString());
            //    Console.WriteLine($"Index is {i} - {Name} - {Age} - {Salary}");
            //}

            foreach (DataGridViewRow row in dgvEmployeeSalaryData.Rows)
            {
                Console.WriteLine(row.Cells["Name"].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            readDataGridViewData();
        }
    }
}
