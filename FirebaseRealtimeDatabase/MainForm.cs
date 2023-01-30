using FirebaseRealtimeDatabase.Firebase;
using FirebaseRealtimeDatabase.Models;
using FireSharp;
using FireSharp.Config;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirebaseRealtimeDatabase
{
    enum FirebaseInteractionMode
    {
        SDK = 0,
        Http = 1
    }

    public partial class MainForm : Form
    {
        private IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "cJrssoZLBwhYf7WvjR7dmHJp0d8zBkZ5P8zuvyWq",
            BasePath = "https://talhafyp-default-rtdb.firebaseio.com/"
        };
        private FirebaseClient client = null;
        private DataTable dataSource = null;
        private int mode = (int)FirebaseInteractionMode.SDK;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataSource = new DataTable();
            dataSource.Columns.Add("Id");
            dataSource.Columns.Add("StudentName");
            dataSource.Columns.Add("Degree");
            dataSource.Columns.Add("Phone");
            dataSource.Columns.Add("Address");

            gridStudents.DataSource = dataSource;
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Edit";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            gridStudents.Columns.Add(Editlink);

            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            gridStudents.Columns.Add(Deletelink);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);

            if (client != null)
            {
                MessageBox.Show("Firebase connection established!");
            }

            Read();     //reading all the students from firebase realtime database
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            btnRegister.Enabled = false;

            if (btnRegister.Text.Equals("Register"))
                Create();
            else
                Update();       //creating or updating student in firebase realtime database 

            btnRegister.Enabled = true;
        }

        private void Reset()
        {
            txtName.Text = String.Empty;
            txtDegreeProgram.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtAddress.Text = String.Empty;
        }

        private void gridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int studentId = Convert.ToInt32(gridStudents.Rows[e.RowIndex].Cells["id"].Value);

            if (e.ColumnIndex == 5)
                Edit(studentId);    //fetching particular student data from firebase realtime database
            else if (e.ColumnIndex == 6)
                Delete(studentId);    //deleting particular student data from firebase realtime database

        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            DeleteAll();
        }


        #region Firebase Operations

        private async void Create()
        {
            try
            {
                StudentModel model = new StudentModel()
                {
                    Id = txtRegisteration.Text,
                    Name = txtName.Text,
                    Degree = txtDegreeProgram.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                };

                if (mode == (int)FirebaseInteractionMode.Http)
                {
                    var std = StudentService.Add(model);
                }
                else
                {
                    SetResponse response = await client.SetTaskAsync($"Students/{model.Id}", model);
                    StudentModel result = response.ResultAs<StudentModel>();
                }

                MessageBox.Show("Student has been registered!");

                Reset();
                Read();
            }
            catch (Exception)
            {
            }
        }

        private async void Read()
        {
            int lastId = 0;

            try
            {
                dataSource.Rows.Clear();

                FirebaseResponse response = await client.GetTaskAsync("Students");
                var students = response.ResultAs<List<StudentModel>>();

                foreach (var std in students)
                {
                    if (std != null)
                    {
                        dataSource.Rows.Add(std.Id, std.Name, std.Degree, std.Phone, std.Address);
                        lastId = Convert.ToInt32(std.Id);
                    }
                }
                dataSource.AcceptChanges();
                lastId += 1;

                txtRegisteration.Text = lastId.ToString();
                txtRegisteration.Enabled = false;
                txtName.Focus();

            }
            catch (Exception)
            {
            }
        }

        private async void Edit(int id)
        {
            try
            {
                FirebaseResponse response = await client.GetTaskAsync($"Students/{id}");
                var student = response.ResultAs<StudentModel>();

                txtRegisteration.Text = student.Id;
                txtName.Text = student.Name;
                txtDegreeProgram.Text = student.Degree;
                txtPhone.Text = student.Phone;
                txtAddress.Text = student.Address;

                btnRegister.Text = "Update";
            }
            catch (Exception)
            {
            }
        }

        private async void Update()
        {
            try
            {
                StudentModel model = new StudentModel()
                {
                    Id = txtRegisteration.Text,
                    Name = txtName.Text,
                    Degree = txtDegreeProgram.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                };

                FirebaseResponse response = await client.UpdateTaskAsync($"Students/{model.Id}", model);
                StudentModel result = response.ResultAs<StudentModel>();

                MessageBox.Show("Student has been updated!");
                btnRegister.Text = "Register";

                Reset();
                Read();
            }
            catch (Exception)
            {
            }
        }

        private async void Delete(int id)
        {
            try
            {
                FirebaseResponse response = await client.DeleteTaskAsync($"Students/{id}");
                MessageBox.Show("Student has been deleted!");
                Read();
            }
            catch (Exception)
            {
            }
        }

        private async void DeleteAll()
        {
            try
            {
                FirebaseResponse response = await client.DeleteTaskAsync("Students");
                MessageBox.Show("All Students deleted!");
                Read();
            }
            catch (Exception)
            {
            }
        }

        #endregion

    }
}
