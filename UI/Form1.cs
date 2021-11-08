using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BL;
using DapperDataAccessLayer;

namespace UI
{
    public partial class Form1 : Form
    {
        private Methods _methods = new Methods();

        private DapperRepository _dapper = new DapperRepository();
        
        public Form1()
        {
            InitializeComponent();
            Averagee.Enabled = false;

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Employee eeee = new Employee
                { 
                Name = textName.Text, 
                Age = Convert.ToInt32(textAge.Text), 
                Salary = Convert.ToInt32(textSalary.Text) 
             };
            _dapper.Add(eeee);
        }
        


        private void Remove_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            _dapper.Delete(index);
        }

        //private void Edit_Click(object sender, EventArgs e)
        //{
        //    _methods.Edit(Convert.ToInt32(textAge.Text),Convert.ToString(textName.Text),Convert.ToInt32(textSalary.Text),Convert.ToString(textBox1.Text));
        //    listEmployee.SelectedItem = false;
        //}

        //public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Edit.Enabled = true;
        //    if (listEmployee.SelectedItem is Employee _info)
        //    {

        //        textBox1.Text = _info.Name;
        //        textAge.Text = Convert.ToString(_info.Age);
        //        textName.Text = _info.Name;
        //        textSalary.Text = Convert.ToString(_info.Salary);
                
        //    }
        //}
            
        private void Average_Click(object sender, EventArgs e)
        {

            Averagee.Text = Convert.ToString(_methods.AverageSalary());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tempdbDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.tempdbDataSet.Employee);

        }
    }
}
