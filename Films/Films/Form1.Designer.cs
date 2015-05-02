namespace Films
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ThrillerButton = new System.Windows.Forms.Button();
            this.comboBoxThriller = new System.Windows.Forms.ComboBox();
            this.MelodramaButton = new System.Windows.Forms.Button();
            this.comboBoxMelodrama = new System.Windows.Forms.ComboBox();
            this.CartoonButton = new System.Windows.Forms.Button();
            this.comboBoxCartoon = new System.Windows.Forms.ComboBox();
            this.FictionButton = new System.Windows.Forms.Button();
            this.comboBoxFiction = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelPath = new System.Windows.Forms.Label();
            this.labelDirector = new System.Windows.Forms.Label();
            this.labelProducer = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxProducer = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.listOfObjects = new System.Windows.Forms.ComboBox();
            this.objectsProperty = new System.Windows.Forms.Button();
            this.informationBox = new System.Windows.Forms.ListBox();
            this.Serialization = new System.Windows.Forms.Button();
            this.Deserialization = new System.Windows.Forms.Button();
            this.DeleteObject = new System.Windows.Forms.Button();
            this.cleanInformationBox = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.film = new System.Windows.Forms.Label();
            this.informationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ThrillerButton
            // 
            this.ThrillerButton.Location = new System.Drawing.Point(12, 8);
            this.ThrillerButton.Name = "ThrillerButton";
            this.ThrillerButton.Size = new System.Drawing.Size(105, 27);
            this.ThrillerButton.TabIndex = 0;
            this.ThrillerButton.Text = "Триллер";
            this.ThrillerButton.UseVisualStyleBackColor = true;
            this.ThrillerButton.Click += new System.EventHandler(this.ThrillerButton_Click);
            // 
            // comboBoxThriller
            // 
            this.comboBoxThriller.FormattingEnabled = true;
            this.comboBoxThriller.Items.AddRange(new object[] {
            "Остров проклятых",
            "Начало",
            "Охотники за разумом"});
            this.comboBoxThriller.Location = new System.Drawing.Point(137, 12);
            this.comboBoxThriller.Name = "comboBoxThriller";
            this.comboBoxThriller.Size = new System.Drawing.Size(194, 21);
            this.comboBoxThriller.TabIndex = 1;
            // 
            // MelodramaButton
            // 
            this.MelodramaButton.Location = new System.Drawing.Point(12, 41);
            this.MelodramaButton.Name = "MelodramaButton";
            this.MelodramaButton.Size = new System.Drawing.Size(105, 23);
            this.MelodramaButton.TabIndex = 2;
            this.MelodramaButton.Text = "Мелодрама";
            this.MelodramaButton.UseVisualStyleBackColor = true;
            this.MelodramaButton.Click += new System.EventHandler(this.MelodramaButton_Click);
            // 
            // comboBoxMelodrama
            // 
            this.comboBoxMelodrama.FormattingEnabled = true;
            this.comboBoxMelodrama.Items.AddRange(new object[] {
            "Золушка",
            "Дневники вампира",
            "Вселенная Стивена Хокинга"});
            this.comboBoxMelodrama.Location = new System.Drawing.Point(137, 41);
            this.comboBoxMelodrama.Name = "comboBoxMelodrama";
            this.comboBoxMelodrama.Size = new System.Drawing.Size(194, 21);
            this.comboBoxMelodrama.TabIndex = 3;
            // 
            // CartoonButton
            // 
            this.CartoonButton.Location = new System.Drawing.Point(12, 70);
            this.CartoonButton.Name = "CartoonButton";
            this.CartoonButton.Size = new System.Drawing.Size(105, 23);
            this.CartoonButton.TabIndex = 4;
            this.CartoonButton.Text = "Мультфильмы";
            this.CartoonButton.UseVisualStyleBackColor = true;
            this.CartoonButton.Click += new System.EventHandler(this.CartoonButton_Click);
            // 
            // comboBoxCartoon
            // 
            this.comboBoxCartoon.FormattingEnabled = true;
            this.comboBoxCartoon.Items.AddRange(new object[] {
            "Гадкий я",
            "Как приручить дракона",
            "Холодное сердце"});
            this.comboBoxCartoon.Location = new System.Drawing.Point(137, 70);
            this.comboBoxCartoon.Name = "comboBoxCartoon";
            this.comboBoxCartoon.Size = new System.Drawing.Size(194, 21);
            this.comboBoxCartoon.TabIndex = 5;
            // 
            // FictionButton
            // 
            this.FictionButton.Location = new System.Drawing.Point(12, 99);
            this.FictionButton.Name = "FictionButton";
            this.FictionButton.Size = new System.Drawing.Size(105, 23);
            this.FictionButton.TabIndex = 6;
            this.FictionButton.Text = "Фантастика";
            this.FictionButton.UseVisualStyleBackColor = true;
            this.FictionButton.Click += new System.EventHandler(this.FictionButton_Click);
            // 
            // comboBoxFiction
            // 
            this.comboBoxFiction.FormattingEnabled = true;
            this.comboBoxFiction.Items.AddRange(new object[] {
            "Интерстеллар",
            "Путешествие к центру земли",
            "Голодные игры"});
            this.comboBoxFiction.Location = new System.Drawing.Point(138, 101);
            this.comboBoxFiction.Name = "comboBoxFiction";
            this.comboBoxFiction.Size = new System.Drawing.Size(193, 21);
            this.comboBoxFiction.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(413, 121);
            this.listBox1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(424, 226);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.labelPath);
            this.panel1.Controls.Add(this.labelDirector);
            this.panel1.Controls.Add(this.labelProducer);
            this.panel1.Controls.Add(this.labelYear);
            this.panel1.Controls.Add(this.textBoxPath);
            this.panel1.Controls.Add(this.textBoxDirector);
            this.panel1.Controls.Add(this.textBoxProducer);
            this.panel1.Controls.Add(this.textBoxYear);
            this.panel1.Controls.Add(this.labelEdit);
            this.panel1.Location = new System.Drawing.Point(12, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 109);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(111, 74);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(137, 23);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Location = new System.Drawing.Point(270, 30);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(72, 13);
            this.labelPath.TabIndex = 8;
            this.labelPath.Text = "путь к файлу";
            // 
            // labelDirector
            // 
            this.labelDirector.AutoSize = true;
            this.labelDirector.Location = new System.Drawing.Point(160, 30);
            this.labelDirector.Name = "labelDirector";
            this.labelDirector.Size = new System.Drawing.Size(57, 13);
            this.labelDirector.TabIndex = 7;
            this.labelDirector.Text = "режиссёр";
            // 
            // labelProducer
            // 
            this.labelProducer.AutoSize = true;
            this.labelProducer.Location = new System.Drawing.Point(79, 30);
            this.labelProducer.Name = "labelProducer";
            this.labelProducer.Size = new System.Drawing.Size(63, 13);
            this.labelProducer.TabIndex = 6;
            this.labelProducer.Text = "продюссер";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(16, 30);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(24, 13);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "год";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(254, 46);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(143, 20);
            this.textBoxPath.TabIndex = 4;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(148, 46);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(100, 20);
            this.textBoxDirector.TabIndex = 3;
            this.textBoxDirector.TextChanged += new System.EventHandler(this.textBoxDirector_TextChanged);
            // 
            // textBoxProducer
            // 
            this.textBoxProducer.Location = new System.Drawing.Point(61, 46);
            this.textBoxProducer.Name = "textBoxProducer";
            this.textBoxProducer.Size = new System.Drawing.Size(81, 20);
            this.textBoxProducer.TabIndex = 2;
            this.textBoxProducer.TextChanged += new System.EventHandler(this.textBoxProducer_TextChanged);
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(5, 46);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(50, 20);
            this.textBoxYear.TabIndex = 1;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            this.textBoxYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxYear_KeyPress);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(145, 11);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(91, 13);
            this.labelEdit.TabIndex = 0;
            this.labelEdit.Text = "Редактирование";
            // 
            // listOfObjects
            // 
            this.listOfObjects.FormattingEnabled = true;
            this.listOfObjects.Items.AddRange(new object[] {
            ""});
            this.listOfObjects.Location = new System.Drawing.Point(215, 394);
            this.listOfObjects.Name = "listOfObjects";
            this.listOfObjects.Size = new System.Drawing.Size(139, 21);
            this.listOfObjects.TabIndex = 17;
            // 
            // objectsProperty
            // 
            this.objectsProperty.Location = new System.Drawing.Point(877, 275);
            this.objectsProperty.Name = "objectsProperty";
            this.objectsProperty.Size = new System.Drawing.Size(111, 44);
            this.objectsProperty.TabIndex = 11;
            this.objectsProperty.Text = "Свойства всех обектов";
            this.objectsProperty.UseVisualStyleBackColor = true;
            this.objectsProperty.Click += new System.EventHandler(this.objectsProperty_Click);
            // 
            // informationBox
            // 
            this.informationBox.FormattingEnabled = true;
            this.informationBox.Location = new System.Drawing.Point(431, 275);
            this.informationBox.Name = "informationBox";
            this.informationBox.Size = new System.Drawing.Size(440, 186);
            this.informationBox.TabIndex = 12;
            // 
            // Serialization
            // 
            this.Serialization.Location = new System.Drawing.Point(877, 325);
            this.Serialization.Name = "Serialization";
            this.Serialization.Size = new System.Drawing.Size(111, 36);
            this.Serialization.TabIndex = 13;
            this.Serialization.Text = "Сериализация";
            this.Serialization.UseVisualStyleBackColor = true;
            this.Serialization.Click += new System.EventHandler(this.Serialization_Click);
            // 
            // Deserialization
            // 
            this.Deserialization.Location = new System.Drawing.Point(877, 370);
            this.Deserialization.Name = "Deserialization";
            this.Deserialization.Size = new System.Drawing.Size(111, 32);
            this.Deserialization.TabIndex = 14;
            this.Deserialization.Text = "Десериализация";
            this.Deserialization.UseVisualStyleBackColor = true;
            this.Deserialization.Click += new System.EventHandler(this.Deserialization_Click);
            // 
            // DeleteObject
            // 
            this.DeleteObject.Location = new System.Drawing.Point(12, 394);
            this.DeleteObject.Name = "DeleteObject";
            this.DeleteObject.Size = new System.Drawing.Size(137, 23);
            this.DeleteObject.TabIndex = 15;
            this.DeleteObject.Text = "Удалить";
            this.DeleteObject.UseVisualStyleBackColor = true;
            this.DeleteObject.Click += new System.EventHandler(this.DeleteObject_Click);
            // 
            // cleanInformationBox
            // 
            this.cleanInformationBox.Location = new System.Drawing.Point(877, 411);
            this.cleanInformationBox.Name = "cleanInformationBox";
            this.cleanInformationBox.Size = new System.Drawing.Size(111, 50);
            this.cleanInformationBox.TabIndex = 18;
            this.cleanInformationBox.Text = "Очистить информацию об объектах";
            this.cleanInformationBox.UseVisualStyleBackColor = true;
            this.cleanInformationBox.Click += new System.EventHandler(this.cleanInformationBox_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(354, 96);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(106, 29);
            this.buttonClean.TabIndex = 19;
            this.buttonClean.Text = "Очистить";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // film
            // 
            this.film.AutoSize = true;
            this.film.Location = new System.Drawing.Point(212, 430);
            this.film.Name = "film";
            this.film.Size = new System.Drawing.Size(142, 26);
            this.film.TabIndex = 20;
            this.film.Text = "             фильм для \r\nредактирования/удаления";
            // 
            // informationLabel
            // 
            this.informationLabel.AutoSize = true;
            this.informationLabel.Location = new System.Drawing.Point(539, 259);
            this.informationLabel.Name = "informationLabel";
            this.informationLabel.Size = new System.Drawing.Size(214, 13);
            this.informationLabel.TabIndex = 21;
            this.informationLabel.Text = "информация о всех созданных объектах";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 482);
            this.Controls.Add(this.informationLabel);
            this.Controls.Add(this.film);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.cleanInformationBox);
            this.Controls.Add(this.listOfObjects);
            this.Controls.Add(this.DeleteObject);
            this.Controls.Add(this.Deserialization);
            this.Controls.Add(this.Serialization);
            this.Controls.Add(this.informationBox);
            this.Controls.Add(this.objectsProperty);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBoxFiction);
            this.Controls.Add(this.FictionButton);
            this.Controls.Add(this.comboBoxCartoon);
            this.Controls.Add(this.CartoonButton);
            this.Controls.Add(this.comboBoxMelodrama);
            this.Controls.Add(this.MelodramaButton);
            this.Controls.Add(this.comboBoxThriller);
            this.Controls.Add(this.ThrillerButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ThrillerButton;
        private System.Windows.Forms.ComboBox comboBoxThriller;
        private System.Windows.Forms.Button MelodramaButton;
        private System.Windows.Forms.ComboBox comboBoxMelodrama;
        private System.Windows.Forms.Button CartoonButton;
        private System.Windows.Forms.ComboBox comboBoxCartoon;
        private System.Windows.Forms.Button FictionButton;
        private System.Windows.Forms.ComboBox comboBoxFiction;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.Label labelDirector;
        private System.Windows.Forms.Label labelProducer;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxProducer;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Button objectsProperty;
        private System.Windows.Forms.ListBox informationBox;
        private System.Windows.Forms.Button Serialization;
        private System.Windows.Forms.Button Deserialization;
        private System.Windows.Forms.Button DeleteObject;
        private System.Windows.Forms.ComboBox listOfObjects;
        private System.Windows.Forms.Button cleanInformationBox;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Label film;
        private System.Windows.Forms.Label informationLabel;
    }
}

