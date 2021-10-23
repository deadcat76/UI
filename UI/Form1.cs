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

namespace UI
{
    public partial class Form1 : Form
    {
        private Methods _methods = new Methods();
        
        public Form1()
        {
            InitializeComponent();
            Edit.Enabled = false;
            textBox1.Enabled = false;
            Averagee.Enabled = false;
            Edit.Enabled = false;
            foreach (Employee employee in _methods.employees)
            {
                listEmployee.Items.Add(employee.ToString());
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            listEmployee.Items.Clear();
            _methods.Add(Convert.ToInt32(textAge.Text), Convert.ToString(textName.Text),Convert.ToInt32(textSalary.Text));
            //listEmployee.Refresh();
            textAge.Clear();
            textName.Clear();
            textSalary.Clear();
            foreach (Employee employee in _methods.employees)
            {
                listEmployee.Items.Add(employee.ToString());
            }
        }
        


        private void Remove_Click(object sender, EventArgs e)
        {
            _methods.employees.RemoveAt(listEmployee.SelectedIndex);
            listEmployee.Items.RemoveAt(listEmployee.SelectedIndex);
            foreach (Employee employee in _methods.employees)
            {
                listEmployee.Items.Add(employee.ToString());
            }
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
    }
}
