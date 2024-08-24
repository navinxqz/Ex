using System;
using System.Collections.Generic;
using SqlKata.Execution;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminSystem.Forms
{
    public partial class Employee : Form
    {
        private List<Employee> employee;
        private Home h;

        public Employee()
        {
            InitializeComponent();
            EmpData.AutoGenerateColumns = false;


            for(int i = 0; i < 3; i++)
            {
                EmpData.Rows.Add(new object[] {
                    imageList1.Images[0],
                });
            }
        }

        void LoadData()
        {
            EmpData.Rows.Clear();
            try
            {
                //for searching
                var db = DataAccess.DBconnect.Db();
                if (searchtxtbox.Text.Trim().Length > 0)
                {

                }
                IEnumerable<Employee> result = db.Query("employee").Get<Employee>();
                foreach (var emp in result)
                {
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
            }catch(Exception ex)
            {
                MessageBox.Show($"An Error Occured! {ex.Message}");
            }
        }

        private void EmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

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
            LoadData();
        }

        private void bgWorkerGetEmp_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
