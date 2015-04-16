﻿using System;
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
        private void Information(Film current)
        {
            listBox1.Items.Add("Название: " + current.name);
            listBox1.Items.Add("Год: " + current.year);
            listBox1.Items.Add("Режиссёр: " + current.director);
            listBox1.Items.Add("Продюссер: " + current.producer);
            listBox1.Items.Add("Жанр:" + current.feature);
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
                    current.feature = "Триллер";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/ostrov.jpg";
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
                    current.feature = "Триллер";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/begin.jpg";
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
                    current.feature = "Триллер";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/ohota.jpg";
                }
                Information(current);
                listBox1.Items.Add("Бюджет: " + current.budget);
                listBox1.Items.Add("Актёры: " + current.actors);
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
                    current.feature = "Мелодрама";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/cindirella.jpg";
                }
                if (current.name == "Дневники вампира")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2009;
                    current.countOfPart = 6;
                    current.actors = "Нина Добрев, Пол Уэсли, Йен Сомерхолдер";
                    current.director = "Джули Плек";
                    current.producer = "Майкл Саби";
                    current.feature = "Мелодрама";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/vampire.jpg";
                }
                if (current.name == "Вселенная Стивена Хокинга")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2014;
                    current.countOfPart = 1;
                    current.actors = "Эдди Редмэйн, Фелисити Джонс";
                    current.director = "Джеймс Марш";
                    current.producer = "Тим Беван, Лиза Брюс, Эрик Феллнер";
                    current.feature = "Мелодрама";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/stiven.jpg";
                }
                Information(current);
                listBox1.Items.Add("Количество частей: " + current.countOfPart);
                listBox1.Items.Add("Актёры: " + current.actors);
            }

        }

        private void CartoonButton_Click(object sender, EventArgs e)
        {
            Cartoons current = new Cartoons();
            if (comboBoxCartoon.SelectedItem == null)
                MessageBox.Show("Выберите фильм");
            else
            {
                comboBoxThriller.SelectedItem = null;
                comboBoxMelodrama.SelectedItem = null;
                comboBoxFiction.SelectedItem = null;
                current.name = comboBoxCartoon.SelectedItem.ToString();
                if (current.name == "Гадкий я")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2010;
                    current.voiceOfTheFilm = "Стив Карелл, Джейсон Сигел, Джули Эндрюс";
                    current.duration = "95 мин";
                    current.director = "Пьер Коффин, Крис Рено";
                    current.producer = "Джон Коэн, Крис Меледандри, Джанет Хили";
                    current.feature = "Мультфильм";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/I.jpg";
                }
                if (current.name == "Как приручить дракона")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2010;
                    current.voiceOfTheFilm = "Джей Барушель, Америка Феррера, Джерард Батлер";
                    current.duration = "98 мин";
                    current.director = "Крис Сандерс, Дин Деблуа";
                    current.producer = "Бонни Арнольд";
                    current.feature = "Мультфильм";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/dracon.jpg";
                }
                if (current.name == "Холодное сердце")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2013;
                    current.voiceOfTheFilm = "Кристен Белл, Идина Мензел, Джонатан Грофф";
                    current.duration = "102 мин";
                    current.director = "Крис Бак, Дженнифер Ли";
                    current.producer = "Питер Дель Вечо, Джон Лассетер";
                    current.feature = "Мультфильм";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/Frozen.jpg";
                }
                Information(current);
                listBox1.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                listBox1.Items.Add("Длительность: " + current.duration);
            }
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
