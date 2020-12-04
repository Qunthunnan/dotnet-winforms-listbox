using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsLists.Models;

namespace WinFormsLists
{
    public partial class Form1 : Form
    {
        /* private List<Employee> employees =
            new List<Employee>{
                    new Employee() { Name = "N1", Salary = 14000 },
                    new Employee() {Name = "N2", Salary = 15000 },
                    new Employee() { Name = "N3", Salary = 11300 }
                }; */
        private Employee[] employeesStub =
            new Employee[]{
                    new Employee() { Name = "N1", Salary = 14000 },
                    new Employee() { Name = "N2", Salary = 15000 },
                    new Employee() { Name = "N3", Salary = 11300 }
        };
    private BindingList<Employee> employees =
            new BindingList<Employee>{};
        public Form1()
        {
            InitializeComponent();
            /* employeesListBox.Items.AddRange(
                new Employee[]{
                    new Employee() { Id = 1, Name = "N1", Salary = 14000 },
                    new Employee() { Id = 2, Name = "N2", Salary = 15000 },
                    new Employee() { Id = 3, Name = "N3", Salary = 11300 }
                }
                );
            */
            /* employeesListBox.DataSource = new Employee[]{
                    new Employee() { Id = 1, Name = "N1", Salary = 14000 },
                    new Employee() { Id = 2, Name = "N2", Salary = 15000 },
                    new Employee() { Id = 3, Name = "N3", Salary = 11300 }
                }; */

            employeesListBox.DataSource = employees;

            employeesListBox.DisplayMember = "Name";
            employeesListBox.ValueMember = "Id";
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            var steps = employeesStub.Length;
            progressBar.Visible = true;
            progressBar.Step = 1;
            for (int i = 0; i < steps; i++)
            {
                // Thread.Sleep(1000);
                employees.Add(employeesStub[i]);
                progressBar.PerformStep();
            }
            progressBar.Visible = false;
            progressBar.Step = 0;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }

        private void employeesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Console.WriteLine(((ListBox)sender).SelectedIndex);
            Console.WriteLine(((ListBox)sender).SelectedItem);
            Console.WriteLine(((ListBox)sender).SelectedValue); */
            // Console.WriteLine(((ListBox)sender).SelectedItem.GetType().Name);
            selectedEmployeeValueLabel.Text = employeesListBox.SelectedIndex.ToString() + " " + employeesListBox.SelectedItem.ToString();

                // ((Employee)((ListBox)sender).SelectedItem).Name;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            employees.Add(
                    new Employee()
                    {
                        Name = nameTextBox.Text,
                        Salary = decimal.Parse(salaryTextBox.Text)
                    }
                );
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            employees.Remove((Employee)(employeesListBox.SelectedItem));
        }

        private void employeesListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedItem != null)
            {
                removeButton.Visible = true;
                editButton.Visible = true;
            }
            else
            {
                removeButton.Visible = false;
                editButton.Visible = false;
                selectedEmployeeValueLabel.Text = "";
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            employees[employeesListBox.SelectedIndex].Name = nameTextBox.Text;
            employees[employeesListBox.SelectedIndex].Salary = decimal.Parse(salaryTextBox.Text);
            
            employees.Add(new Employee());
            employees.RemoveAt(employees.Count - 1);
        }
    }
}
