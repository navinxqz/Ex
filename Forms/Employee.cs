﻿using System;
using System.Collections.Generic;
using SqlKata.Execution;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminSystem.Classes;

namespace AdminSystem.Forms
{
    public partial class Employee : Form
    {
        private List<EmployeeBase> employee;
        private List<EmployeeBase> list;
        private EmployeeBase emp;
        private Home h;

        public Employee()
        {
            InitializeComponent();
            EmpData.AutoGenerateColumns = false;
            bgWorkerGetEmp.RunWorkerAsync();


            for(int i = 0; i < 3; i++)
            {
                EmpData.Rows.Add(new object[] {
                    imageList1.Images[0],
                });
            }
        }
        public Employee(EmployeeBase e, Home home)
        {
            InitializeComponent();
            EmpData.AutoGenerateColumns = false;
            bgWorkerGetEmp.RunWorkerAsync();
            emp = e;
            h = home;
        }

        /*void LoadData()
        {
            EmpData.Rows.Clear();
            try
            {
                //for searching
                var db = DataAccess.DBconnect.Db();
                if (!string.IsNullOrWhiteSpace(searchtxtbox.Text))
                {

                }
                IEnumerable<Employee> result = db.Query("employee").Get<Employee>();
                foreach (var emp in result)
                {
                    int id;
                    if(int.TryParse(emp.ID.ToString(), out id)) {
                        EmpData.Rows.Add(new object[]{
                    imageList1.Images[0],
                    emp.ID,
                    emp.FullName,
                    emp.Username,
                    emp.Gender,
                    emp.Age,
                    emp.Birthday,
                    emp.phone,
                    emp.Email,
                    emp.Salary,
                    null
                    });
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID! " + emp.ID);
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured! {ex.Message}");
            }
        }   */

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPeople ppl = new AddPeople(emp, E: true);
            faddingTimer.Start();
            ppl.ShowDialog();
            faddingTime2.Start();
            panelView.Visible = false;
            bgWorkerGetEmp.RunWorkerAsync();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void faddingTimer_Tick(object sender, EventArgs e)
        {
            if(h.Opacity>0.86)
            {
                h.Opacity -= 0.01;
            }
            else
            {
                faddingTimer.Stop();
            }
        }

        private void faddingTime2_Tick(object sender, EventArgs e)
        {
            if (h.Opacity < 1)
            {
                h.Opacity += 0.01;
            }
            else
            {
                faddingTime2.Stop();
            }
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            //load Data
            //LoadData();
        }

        private void bgWorkerGetEmp_DoWork(object sender, DoWorkEventArgs e)
        {
            //employee = StaticClass.empQuery
        }

        private void bgWorkerGetEmp_RunWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            if(employee != null)
            {
                panelView.Visible = true;
                EmpData = StaticClass.data.Grid(EmpData, employee);
            }
            else
            {
                panelView.Visible=false;
            }
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            if(searchtxtbox.Text != "Search")
            {
                try
                {
                    bgWorkerList.RunWorkerAsync();
                }catch (Exception ex)
                {
                    Console.WriteLine($"Error! {ex.Message}");
                }
            }
        }

        private void bgWorkerList_DoWork(object sender, DoWorkEventArgs e)
        {
            list = employee.Where(employee => employee.Name.ToLower().Contains(searchtxtbox.Text) || employee.Name.Contains(searchtxtbox.Text) || employee.Name.ToUpper().Contains(searchtxtbox.Text) || employee.Id.ToString().Contains(searchtxtbox.Text) || employee.Username.ToUpper().Contains(searchtxtbox.Text) || employee.Username.ToLower().Contains(searchtxtbox.Text)).ToList();
        }

        private void bgrWorkerList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(list != null)
            {
                EmpData = StaticClass.data.Grid(EmpData, list);
            }
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if(searchtxtbox.Text == "")
            {
                searchtxtbox.Text = "Search";
                searchtxtbox.StateActive.Content.Color1 = Color.FromArgb(70, 71, 78);
            }

        }

        private void searchBox_Enter(object sender, EventArgs e)
        {
            if(searchtxtbox.Text == "Search")
            {
                searchtxtbox.Text = string.Empty;
                searchtxtbox.StateActive.Content.Color1 = Color.FromArgb(189, 188, 205);
                
                if(searchtxtbox.TabStop == false)
                {
                    searchtxtbox.TabStop = true;
                }
            }
        }
    }
}
