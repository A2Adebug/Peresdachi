using Peresdachi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peresdachi
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void FormAdmin_Shown(object sender, EventArgs e)
        {
            var client = new RestClient("http://www.peresdachiapi.somee.com");
            var request = new RestRequest("user", Method.GET);
            dataGridView1.DataSource = client.Execute<List<ModelUsers>>(request).Data;

            try
            {
                dataGridView2.Columns.Add("id", "Номер пользователя");
                dataGridView2.Columns.Add("role", "Роль");
                dataGridView2.Columns.Add("email", "Электронная почта");
                dataGridView2.Columns.Add("FirstName", "Имя");
                dataGridView2.Columns.Add("SecondName", "Фамилия");
                dataGridView2.Columns.Add("LastName", "Отчество");
                dataGridView2.Columns.Add("GroupStd", "Группа");
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[row.Index].Cells[0].Value = row.Cells[0].Value;
                    string j = "";
                    if (row.Cells[1].Value.ToString() == "admin") j = "Администратор";
                    if (row.Cells[1].Value.ToString() == "professor") j = "Преподаватель";
                    if (row.Cells[1].Value.ToString() == "student") j = "Студент";
                    dataGridView2.Rows[row.Index].Cells[1].Value = j;
                    dataGridView2.Rows[row.Index].Cells[2].Value = row.Cells[2].Value;
                    dataGridView2.Rows[row.Index].Cells[3].Value = row.Cells[4].Value;
                    dataGridView2.Rows[row.Index].Cells[4].Value = row.Cells[5].Value;
                    dataGridView2.Rows[row.Index].Cells[5].Value = row.Cells[6].Value;
                    dataGridView2.Rows[row.Index].Cells[6].Value = row.Cells[7].Value;
                }
            }
            catch
            {

            }
        }
    }
}
