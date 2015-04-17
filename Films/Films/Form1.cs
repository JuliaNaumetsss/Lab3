using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace Films
{
    public partial class Form1 : Form
    {
        public int countOfObjects = 0;
        List<Thriller> listOfThrillers = new List<Thriller>();
        List<Melodrama> listOfMelodrams = new List<Melodrama>();
        List<Cartoons> listOfCartoons = new List<Cartoons>();
        List<Fiction> listOfFictions = new List<Fiction>();
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
        private void Information2(Film current)
        {
            informationBox.Items.Add("Название: " + current.name);
            informationBox.Items.Add("Год: " + current.year);
            informationBox.Items.Add("Режиссёр: " + current.director);
            informationBox.Items.Add("Продюссер: " + current.producer);
            informationBox.Items.Add("Жанр:" + current.feature);
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
                countOfObjects++;
                Information(current);
                listBox1.Items.Add("Бюджет: " + current.budget);
                listBox1.Items.Add("Актёры: " + current.actors);
                listBox1.Items.Add("Объект класса ТРИЛЛЕР создан");
                listBox1.Items.Add("Количество созданных объектов" + countOfObjects.ToString());
                listOfThrillers.Add(current);
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
                countOfObjects++;
                listBox1.Items.Add("Объект класса МЕЛОДРАМА создан");
                listBox1.Items.Add("Количество созданных объектов" + countOfObjects.ToString());
                listOfMelodrams.Add(current);

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
                countOfObjects++;
                listBox1.Items.Add("Объект класса МУЛЬТФИЛЬМ создан");
                listBox1.Items.Add("Количество созданных объектов" + countOfObjects.ToString());
                listOfCartoons.Add(current);
            }
        }

        private void FictionButton_Click(object sender, EventArgs e)
        {

            Fiction current = new Fiction();
            if (comboBoxFiction.SelectedItem == null)
                MessageBox.Show("Выберете фильм");
            else
            {
                comboBoxThriller.SelectedItem = null;
                comboBoxMelodrama.SelectedItem = null;
                comboBoxCartoon.SelectedItem = null;
                current.name = comboBoxFiction.SelectedItem.ToString();
                if (current.name == "Интерстеллар")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2014;
                    current.voiceOfTheFilm = "Мэттью Макконахи, Энн Хэтэуэй";
                    current.boxOffice = "672 млн";
                    current.director = "Кристофер Нолан";
                    current.producer = "Кристофер Нолан, Эмма Томас, Линда Обст";
                    current.feature = "Фантастика";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/interstellar.jpg";
                }
                if (current.name == "Путешествие к центру земли")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2008;
                    current.voiceOfTheFilm = "Брендан Фрэйзер, Джош Хатчерсон, Анита Брием";
                    current.boxOffice = "241 млн";
                    current.director = "Эрик Бревиг";
                    current.producer = "Брендан Фрэйзер";
                    current.feature = "Фантастика";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/center.jpg";
                }
                if (current.name == "Голодные игры")
                {
                    pictureBox1.ImageLocation = "";
                    listBox1.Items.Clear();
                    current.year = 2014;
                    current.voiceOfTheFilm = "Дженнифер Лоуренс, Джош Хатчерсон, Лиам Хемсворт";
                    current.boxOffice = "751 млн";
                    current.director = "Френсис Лоуренс";
                    current.producer = "Нина Джейкобсон, Джон Килик";
                    current.feature = "Фантастика";
                    pictureBox1.ImageLocation = @"D:/Projects/ThirdLab/Pictures/game.jpg";
                }
                Information(current);
                listBox1.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                listBox1.Items.Add("Кассовые сборы: " + current.boxOffice);
                countOfObjects++;
                listBox1.Items.Add("Объект класса ФАНТАСТИКА создан");
                listBox1.Items.Add("Количество созданных объектов" + countOfObjects.ToString());
                listOfFictions.Add(current);
            }
        }
        private void editFunction(Film current)
        {
            if (textBoxYear.Text != "")
                current.year = Convert.ToInt32(textBoxYear.Text);
            if (textBoxProducer.Text != "")
                current.producer = textBoxProducer.Text;
            if (textBoxDirector.Text != "")
                current.director = textBoxDirector.Text;
            if (textBoxPath.Text != "")
                pictureBox1.ImageLocation = @textBoxPath.Text;
        }
        private void cleanFunction()
        {
            textBoxYear.Text = "";
            textBoxProducer.Text = "";
            textBoxPath.Text = "";
            textBoxDirector.Text = "";
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int x;
            if (textBoxYear.Text != "")
            {
                x = Convert.ToInt32(textBoxYear.Text);
                if (x > 2015 || x < 1900)
                    MessageBox.Show("Введите год в диапазоне от 1900 до 2015");
            }
            if (comboBoxThriller.SelectedItem != null)
            {
                Thriller current = new Thriller();
                current = listOfThrillers[listOfThrillers.Count-1];
                editFunction(current);
                listBox1.Items.Add("-------------------------------");
                Information(current);
                listBox1.Items.Add("Бюджет: " + current.budget);
                listBox1.Items.Add("Актёры: " + current.actors);
                listBox1.Items.Add("ОБЪЕКТ КЛАССА ТРИЛЛЕР ИЗМЕНЁН");
                cleanFunction();
            }
            if (comboBoxMelodrama.SelectedItem != null)
            {
                Melodrama current = new Melodrama();
                current = listOfMelodrams[listOfMelodrams.Count - 1];
                editFunction(current);
                listBox1.Items.Add("-------------------------------");
                Information(current);
                listBox1.Items.Add("Количество частей: " + current.countOfPart);
                listBox1.Items.Add("Актёры: " + current.actors);
                listBox1.Items.Add("ОБЪЕКТ КЛАССА МЕЛОДРАМА ИЗМЕНЁН");
                cleanFunction();
            }
            if (comboBoxFiction.SelectedItem != null)
            {
                Fiction current = new Fiction();
                current = listOfFictions[listOfFictions.Count - 1];
                editFunction(current);
                listBox1.Items.Add("-------------------------------");
                Information(current);
                listBox1.Items.Add("Кассовый сбор: " + current.boxOffice);
                listBox1.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                listBox1.Items.Add("ОБЪЕКТ КЛАССА ФАНТАСТИКА ИЗМЕНЁН");
                cleanFunction();
            }
            if(comboBoxCartoon.SelectedItem != null)
            {
                Cartoons current = new Cartoons();
                current = listOfCartoons[listOfCartoons.Count - 1];
                editFunction(current);
                listBox1.Items.Add("-------------------------------");
                Information(current);
                listBox1.Items.Add("Продолжительность: " + current.duration);
                listBox1.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                listBox1.Items.Add("ОБЪЕКТ КЛАССА МУЛЬТФИЛЬМ ИЗМЕНЁН");
                cleanFunction();
            }
        }

        private void objectsProperty_Click(object sender, EventArgs e)
        {
            int number = 0;
            informationBox.Items.Clear();
            foreach(Cartoons current in listOfCartoons)
            {
                number++;
                informationBox.Items.Add("Объект номер" + number);
                Information2(current);
                informationBox.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                informationBox.Items.Add("Актёры: " + current.duration);
                informationBox.Items.Add("-----------------------------------");
                      
            }
            foreach (Fiction current in listOfFictions)
            {
                number++;
                informationBox.Items.Add("Объект номер" + number);
                Information2(current);
                informationBox.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                informationBox.Items.Add("Кассовые сборы: " + current.boxOffice);
                informationBox.Items.Add("-----------------------------------");

            }
            foreach (Melodrama current in listOfMelodrams)
            {
                number++;
                informationBox.Items.Add("Объект номер" + number);
                Information2(current);
                informationBox.Items.Add("Количество частей: " + current.countOfPart);
                informationBox.Items.Add("Актёры: " + current.actors);
                informationBox.Items.Add("-----------------------------------");

            }
            foreach (Thriller current in listOfThrillers)
            {
                number++;
                informationBox.Items.Add("Объект номер"+number);
                Information2(current);
                informationBox.Items.Add("Количество частей: " + current.budget);
                informationBox.Items.Add("Актёры: " + current.actors);
                informationBox.Items.Add("-----------------------------------");
            }
        }

        private void checkSymbols(KeyPressEventArgs e)
        {
            if ((!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), @"\d")) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void textBoxYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkSymbols(e);
        }
        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {

            textBoxYear.MaxLength = 4;

        }

        private void textBoxProducer_TextChanged(object sender, EventArgs e)
        {
            textBoxProducer.MaxLength = 30;
        }

        private void textBoxDirector_TextChanged(object sender, EventArgs e)
        {
            textBoxDirector.MaxLength = 30;
        }

        private void Serialization_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<Cartoons>));
            using (FileStream fs = new FileStream("cartoons.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listOfCartoons);
            }
            XmlSerializer formatter1 = new XmlSerializer(typeof(List<Fiction>));
            using (FileStream fs = new FileStream("fictions.xml", FileMode.OpenOrCreate))
            {
                formatter1.Serialize(fs, listOfFictions);
            }
            XmlSerializer formatter2 = new XmlSerializer(typeof(List<Thriller>));
            using (FileStream fs = new FileStream("thrillers.xml", FileMode.OpenOrCreate))
            {
                formatter2.Serialize(fs, listOfThrillers);
            }
            XmlSerializer formatter3 = new XmlSerializer(typeof(List<Melodrama>));
            using (FileStream fs = new FileStream("melodrams.xml", FileMode.OpenOrCreate))
            {
                formatter3.Serialize(fs, listOfMelodrams);
            }
        }

        private void Deserialization_Click(object sender, EventArgs e)
        {
            int num = 0;
            XmlSerializer formatter = new XmlSerializer(typeof(List<Cartoons>));
            using (FileStream fs = new FileStream("cartoons.xml", FileMode.OpenOrCreate))
            {
                List<Cartoons> listOfCartoons  = (List<Cartoons>)formatter.Deserialize(fs);
                foreach (Cartoons current in listOfCartoons)
                {
                    num++;
                    informationBox.Items.Add("Объект номер" + num);
                    Information2(current);
                    informationBox.Items.Add("Роли озвучивали: " + current.voiceOfTheFilm);
                    informationBox.Items.Add("Актёры: " + current.duration);
                    informationBox.Items.Add("-----------------------------------");

                }
            }
        }

        private void DeleteObject_Click(object sender, EventArgs e)
        {
            int i;
            bool flagFind = false;
            //Melodrama film = new Melodrama();
           //film =  listOfMelodrams.Find(item => item.name == objectBox.Text);
           i = listOfMelodrams.FindIndex(item => item.name == objectBox.Text);
           if (i > -1)
           {
               listOfMelodrams.Remove(listOfMelodrams[i]);
               flagFind = true;
               MessageBox.Show("Фильм" + objectBox.Text+ "  удалён");
           }
            if(!flagFind)
            {
                i = listOfFictions.FindIndex(item => item.name == objectBox.Text);
                if (i > -1)
                {
                    listOfFictions.Remove(listOfFictions[i]);
                    flagFind = true;
                    MessageBox.Show("Фильм" + objectBox.Text + "  удалён");
                }
            }
            if(!flagFind)
            {
                i = listOfCartoons.FindIndex(item => item.name == objectBox.Text);
                if (i > -1)
                {
                    listOfCartoons.Remove(listOfCartoons[i]);
                    flagFind = true;
                    MessageBox.Show("Фильм" + objectBox.Text + "  удалён");
                }
            }
            if(!flagFind)
            {
                i = listOfThrillers.FindIndex(item => item.name == objectBox.Text);
                if (i > -1)
                {
                    listOfThrillers.Remove(listOfThrillers[i]);
                    flagFind = true;
                    MessageBox.Show("Фильм" + objectBox.Text + "  удалён");
                }
            }
            if(!flagFind)
                MessageBox.Show("Фильма с таким названием в списке нет");

        }
    }
}
