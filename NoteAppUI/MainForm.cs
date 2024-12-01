using NoteApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteAppUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Главное окно программы";
            this.Size = new Size(400, 250);
            var project = new Project();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Contact firstContact = new Contact();
            //firstContact.Name = "Alex";
            //firstContact.Birth = DateTime.Today;
            //firstContact.Sername = "Ivanov";
            //firstContact.Email = "some@email.ru";
            //firstContact.IdVk = "123456789";

            //ProjectManager.SaveToFile( ProjectManager.DefaultPath;
            //JsonSerializer serializer = new JsonSerializer();

            ////Открываем поток для записи в файл с указанием пути
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\Денис\json.txt"))
            //using (JsonWriter writer = new JsonTextWriter(sw))
            //{
            //    //Вызываем сериализацию и передаем объект, который хотим сериализовать
            //    serializer.Serialize(writer, firstContact);
            //}

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}