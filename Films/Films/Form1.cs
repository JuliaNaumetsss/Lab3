using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Films
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ThrillerButton_Click(object sender, EventArgs e)
        {
            Thriller current = new Thriller();
            if (comboBoxThriller.SelectedItem == null)
                MessageBox.Show("выберете фильм!!!");
            else
            {

                comboBoxMelodrama.SelectedItem = null;
                comboBoxCartoon.SelectedItem = null;
                comboBoxFiction.SelectedItem = null;
                current.name = comboBoxThriller.SelectedItem.ToString();
                if (current.name == "Остров проклятых")
                {
                    
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2010;
                    current.budget = "80 млн";
                    current.actors = "Леонардо Ди Каприо, Марк Руффало,Эмили Мортимер";
                    current.director = "Мартин Скорсезе";
                    current.producer = "Майк Медавой";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/ostrov.jpg";
                   // comboBoxThriller.SelectedItem = null;
                }
                if (current.name == "Начало")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2010;
                    current.budget = "160 млн";
                    current.actors = "Леонардо Ди Каприо, Эллен Пейдж, Джозеф Гордон-Левитт";
                    current.director = "Кристофер Нолан";
                    current.producer = "Кристофер Нолан, Эмма Томас";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/begin.jpg";
                   // comboBoxThriller.SelectedItem = null;
                }
                if (current.name == "Охотники за разумом")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2004;
                    current.budget = "27 млн";
                    current.actors = "Кристиан Слэйтер, Кэтрин Моррис, Джонни Ли Миллер";
                    current.director = "Ренни Харлин";
                    current.producer = "Мориц Борман, Кэри Брокау";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/ohota.jpg";
                   // comboBoxThriller.SelectedItem = null;
                }
                listBox1.Items.Add("Название: " + current.name);
                listBox1.Items.Add("Год: " + current.year);
                listBox1.Items.Add("Бюджет: " + current.budget);
                listBox1.Items.Add("Актёры: " + current.actors);
                listBox1.Items.Add("Режиссёр: " + current.director);
                listBox1.Items.Add("Продюссер: " + current.producer);
            }
        }

        private void MelodramaButton_Click(object sender, EventArgs e)
        {
            Melodrama current = new Melodrama();
            if (comboBoxMelodrama.SelectedItem == null)
                MessageBox.Show("Выберите фильм");
            else
            {
                comboBoxThriller.SelectedItem = null;
                comboBoxCartoon.SelectedItem = null;
                comboBoxFiction.SelectedItem = null;
                current.name = comboBoxMelodrama.SelectedItem.ToString();
                if (current.name == "Золушка")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2015;
                    current.countOfPart = 1;
                    current.actors = "Лили Джеймс, Ричард Мэдден, Хелена Бонэм Картер";
                    current.director = "Кеннет Брана";
                    current.producer = "Саймон Кинберг, Дэвид Баррон";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/cindirella.jpg";
                    //comboBoxThriller.SelectedItem = null;
                }
                listBox1.Items.Add("Название: " + current.name);
                listBox1.Items.Add("Год: " + current.year);
                listBox1.Items.Add("Бюджет: " + current.countOfPart);
                listBox1.Items.Add("Актёры: " + current.actors);
                listBox1.Items.Add("Режиссёр: " + current.director);
                listBox1.Items.Add("Продюссер: " + current.producer);
            }

        }

        private void CartoonButton_Click(object sender, EventArgs e)
        {
            //comboBoxCartoon.Visible = true;
            this.Name = comboBoxCartoon.SelectedItem.ToString();
        }

        private void FictionButton_Click(object sender, EventArgs e)
        {
           // comboBoxFiction.Visible = true;
            this.Name = comboBoxFiction.SelectedItem.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Film current = new Film();
            //current.name = 
        }
    }
}
