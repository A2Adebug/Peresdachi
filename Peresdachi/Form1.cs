using Peresdachi.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace Peresdachi
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            var client = new RestClient("http://www.peresdachiapi.somee.com");
            var request = new RestRequest("user", Method.GET);
            dataGridView1.DataSource = client.Execute<List<ModelUsers>>(request).Data;

            //проверка на наличие администратора, если его нет, то осуществляется переход в окно для регистрации администритора
            bool admin = false;
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "admin")
                    {
                        admin = true;
                    }
                }
            }
            catch
            {

            }

            if(admin == false)
            {
                this.Hide();
                FormAdminReg formAdminReg = new FormAdminReg();
                formAdminReg.Show();
            }
        }

        private void textBoxEmailReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            if (e.KeyChar == '.') return;
            if (e.KeyChar == '@') return;
            if (e.KeyChar == '_') return;
            e.Handled = true;
        }

        private void textBoxPasswordReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar) || char.IsLetter(e.KeyChar)) return;
            if (e.KeyChar == '.') return;
            if (e.KeyChar == '_') return;
            e.Handled = true;
        }

        private void textBoxFirstNameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBoxSecondNameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }
        // 
        private void textBoxLastNameReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        public int valueRnd = 0;
        public string Role = "professor";

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на уже имеющегося пользователя
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if(row.Cells[2].Value.ToString() == textBoxEmailReg.Text)
                    {
                        MessageBox.Show("Пользователь с такой электронной почтой уже зарегистрирован", "Ошибка");
                        goto end;
                    }
                }
            }
            catch
            {

            }

            //определение роли пользователя
            if (textBoxEmailReg.Text.Contains("_"))
            {
                Role = "student";
            }

            //проверка корректности заполнения полей
            if (textBoxEmailReg.Text.Length > 5 && textBoxPasswordReg.Text.Length > 5 && textBoxSecondNameReg.Text.Length > 1
                && textBoxFirstNameReg.Text.Length > 1 && textBoxLastNameReg.Text.Length > 1 && textBoxEmailReg.Text.Contains("@mpt.ru"))
            {
                try
                {
                    Random rnd = new Random();
                    valueRnd = rnd.Next(1000, 9999);

                    MailAddress from = new MailAddress("peresdachiinfompt@mail.ru", "Информатор");
                    // кому отправляем
                    MailAddress to = new MailAddress(textBoxEmailReg.Text);
                    // создаем объект сообщения
                    MailMessage m = new MailMessage(from, to);
                    // тема письма
                    m.Subject = "Подтверждение регистрации";
                    // текст письма
                    m.Body = $@"<h2>Код для подтверждения регистрации: {valueRnd}</h2>";
                    // письмо представляет код html
                    m.IsBodyHtml = true;
                    // адрес smtp-сервера и порт, с которого будем отправлять письмо
                    SmtpClient smtp = new SmtpClient("smtp.mail.ru", 2525);
                    // логин и пароль
                    smtp.Credentials = new NetworkCredential("peresdachiinfompt@mail.ru", "AQ6fy00sX6s4GyL3zasi");
                    smtp.EnableSsl = true;
                    smtp.Send(m);

                    //скрываем элементы регистрации
                    buttonReg.Visible = false;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    textBoxEmailReg.Visible = false;
                    textBoxPasswordReg.Visible = false;
                    textBoxSecondNameReg.Visible = false;
                    textBoxFirstNameReg.Visible = false;
                    textBoxLastNameReg.Visible = false;

                    //показываем элементы для подтверждения регистрации
                    textBoxAcceptReg.Visible = true;
                    buttonAcceptReg.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Электронная почта введна не корректно", "Ошибка");
                }
            }
            else
            {
                MessageBox.Show("Проверьте правильность введённых данных: \n" +
                        "Логин и пароль содержит не менее 6 символов \n" +
                        "Фамилия, имя и отчество содержит не менее 2 символов", "Ошибка");
            }

            end:;
        }

        private void buttonAcceptReg_Click(object sender, EventArgs e)
        {
            //проверка на совпадение одноразового кода
            if (textBoxAcceptReg.Text == valueRnd.ToString())
            {
                //регистрация пользователя
                var client = new RestClient("http://www.peresdachiapi.somee.com");
                var request = new RestRequest("user", Method.POST);
                request.RequestFormat = DataFormat.Json;

                //хэширование пароля
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(textBoxPasswordReg.Text));
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);

                ModelUsers modelUsers = new ModelUsers
                {
                    role = Role,
                    email = textBoxEmailReg.Text,
                    password = result,
                    FirstName = textBoxSecondNameReg.Text,
                    SecondName = textBoxFirstNameReg.Text,
                    LastName = textBoxLastNameReg.Text,
                    GroupStd = "-",
                };
                request.AddBody(modelUsers);
                client.Execute(request);

                //перенаправление на соответствующее окно при успешной регистрации
                WhichRole(textBoxEmailReg.Text, textBoxPasswordReg.Text);
            }
            else
            {
                //в случае если код подтверждения введён не верно показываем элементы регистрации и скрываем элементы подтверждения регистрации
                MessageBox.Show("Неверно введён код подтверждения", "Ошибка");
                buttonReg.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBoxEmailReg.Visible = true;
                textBoxPasswordReg.Visible = true;
                textBoxSecondNameReg.Visible = true;
                textBoxFirstNameReg.Visible = true;
                textBoxLastNameReg.Visible = true;

                textBoxAcceptReg.Visible = false;
                buttonAcceptReg.Visible = false;
            }
        }

        private void textBoxAcceptReg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsDigit(e.KeyChar)) return;
            e.Handled = true;
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            //перенаправление на соответствующее окно при успешной авторизации
            WhichRole(textBoxEmailAuth.Text, textBoxPasswordAuth.Text);
        }

        public void WhichRole(string email, string password)
        {
            //получение списка данных пользователей
            var client = new RestClient("http://www.peresdachiapi.somee.com");
            var request = new RestRequest("user", Method.GET);
            dataGridView1.DataSource = client.Execute<List<ModelUsers>>(request).Data;

            //хэширование пароля
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);

            //при успешном совпадении хэшированного пароля и электронной почты перенаправление на соответствующее окно
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString() == email && row.Cells[3].Value.ToString() == result)
                    {
                        if (row.Cells[1].Value.ToString() == "professor")
                        {
                            this.Hide();
                            FormProfessor formProfessor = new FormProfessor(row.Cells[0].Value.ToString());
                            formProfessor.Show();
                            goto end;
                        }
                        if (row.Cells[1].Value.ToString() == "student")
                        {
                            this.Hide();
                            FormStudent formStudent = new FormStudent(row.Cells[0].Value.ToString());
                            formStudent.Show();
                            goto end;
                        }
                        if (row.Cells[1].Value.ToString() == "admin")
                        {
                            this.Hide();
                            FormAdmin formAdmin = new FormAdmin();
                            formAdmin.Show();
                            goto end;
                        }
                    }
                }
            }
            catch
            {
                
            }

            MessageBox.Show("Неверно введена электронная почта или пароль", "Ошибка");

            end:;
        }
    }
}
