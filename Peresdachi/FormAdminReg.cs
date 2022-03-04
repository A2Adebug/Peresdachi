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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peresdachi
{
    public partial class FormAdminReg : Form
    {
        public FormAdminReg()
        {
            InitializeComponent();
        }

        public int valueRnd = 0;

        private void buttonReg_Click(object sender, EventArgs e)
        {
            //проверка на уже имеющегося пользователя
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[2].Value.ToString() == textBoxEmailReg.Text)
                    {
                        MessageBox.Show("Пользователь с такой электронной почтой уже зарегистрирован", "Ошибка");
                        goto end;
                    }
                }
            }
            catch
            {

            }


            //проверка корректности заполнения полей
            if (textBoxEmailReg.Text.Length > 5 && textBoxPasswordReg.Text.Length > 5 && textBoxSecondNameReg.Text.Length > 1
                && textBoxFirstNameReg.Text.Length > 1 && textBoxLastNameReg.Text.Length > 1)
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

        private void FormAdminReg_Shown(object sender, EventArgs e)
        {
            var client = new RestClient("http://www.peresdachiapi.somee.com");
            var request = new RestRequest("user", Method.GET);
            dataGridView1.DataSource = client.Execute<List<ModelUsers>>(request).Data;
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
                    role = "admin",
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
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
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
    }
}
