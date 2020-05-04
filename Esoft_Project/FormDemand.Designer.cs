namespace Esoft_Project
{
    partial class FormDemand
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
            this.comboBoxIdAgent = new System.Windows.Forms.ComboBox();
            this.comboBoxIdClient = new System.Windows.Forms.ComboBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxMiniPrice = new System.Windows.Forms.TextBox();
            this.textBoxMaxPrice = new System.Windows.Forms.TextBox();
            this.textBoxMiniArea = new System.Windows.Forms.TextBox();
            this.listViewDemandApartment = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandHous = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewDemandLand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxMaxArea = new System.Windows.Forms.TextBox();
            this.textBoxMinRooms = new System.Windows.Forms.TextBox();
            this.textBoxMaxRooms = new System.Windows.Forms.TextBox();
            this.textBoxMinFloor = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloor = new System.Windows.Forms.TextBox();
            this.textBoxMinFloors = new System.Windows.Forms.TextBox();
            this.textBoxMaxFloors = new System.Windows.Forms.TextBox();
            this.labelIdAgent = new System.Windows.Forms.Label();
            this.labelIdClient = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.labelMinPrice = new System.Windows.Forms.Label();
            this.labelMaxPrice = new System.Windows.Forms.Label();
            this.labelMinArea = new System.Windows.Forms.Label();
            this.labelMaxArea = new System.Windows.Forms.Label();
            this.labelMinRooms = new System.Windows.Forms.Label();
            this.labelMaxRooms = new System.Windows.Forms.Label();
            this.labelMinFloor = new System.Windows.Forms.Label();
            this.labelMaxFloor = new System.Windows.Forms.Label();
            this.labelMinFloors = new System.Windows.Forms.Label();
            this.labelMaxFloors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIdAgent
            // 
            this.comboBoxIdAgent.FormattingEnabled = true;
            this.comboBoxIdAgent.Location = new System.Drawing.Point(18, 33);
            this.comboBoxIdAgent.Name = "comboBoxIdAgent";
            this.comboBoxIdAgent.Size = new System.Drawing.Size(205, 21);
            this.comboBoxIdAgent.TabIndex = 0;
            // 
            // comboBoxIdClient
            // 
            this.comboBoxIdClient.FormattingEnabled = true;
            this.comboBoxIdClient.Location = new System.Drawing.Point(18, 73);
            this.comboBoxIdClient.Name = "comboBoxIdClient";
            this.comboBoxIdClient.Size = new System.Drawing.Size(205, 21);
            this.comboBoxIdClient.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Квартира",
            "Дом",
            "Земля"});
            this.comboBoxType.Location = new System.Drawing.Point(18, 113);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(205, 21);
            this.comboBoxType.TabIndex = 2;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxMiniPrice
            // 
            this.textBoxMiniPrice.Location = new System.Drawing.Point(229, 33);
            this.textBoxMiniPrice.Name = "textBoxMiniPrice";
            this.textBoxMiniPrice.Size = new System.Drawing.Size(205, 21);
            this.textBoxMiniPrice.TabIndex = 3;
            // 
            // textBoxMaxPrice
            // 
            this.textBoxMaxPrice.Location = new System.Drawing.Point(229, 73);
            this.textBoxMaxPrice.Name = "textBoxMaxPrice";
            this.textBoxMaxPrice.Size = new System.Drawing.Size(205, 21);
            this.textBoxMaxPrice.TabIndex = 4;
            // 
            // textBoxMiniArea
            // 
            this.textBoxMiniArea.Location = new System.Drawing.Point(229, 113);
            this.textBoxMiniArea.Name = "textBoxMiniArea";
            this.textBoxMiniArea.Size = new System.Drawing.Size(205, 21);
            this.textBoxMiniArea.TabIndex = 5;
            // 
            // listViewDemandApartment
            // 
            this.listViewDemandApartment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader27});
            this.listViewDemandApartment.FullRowSelect = true;
            this.listViewDemandApartment.GridLines = true;
            this.listViewDemandApartment.HideSelection = false;
            this.listViewDemandApartment.Location = new System.Drawing.Point(18, 181);
            this.listViewDemandApartment.MultiSelect = false;
            this.listViewDemandApartment.Name = "listViewDemandApartment";
            this.listViewDemandApartment.Size = new System.Drawing.Size(838, 339);
            this.listViewDemandApartment.TabIndex = 6;
            this.listViewDemandApartment.UseCompatibleStateImageBehavior = false;
            this.listViewDemandApartment.View = System.Windows.Forms.View.Details;
            this.listViewDemandApartment.SelectedIndexChanged += new System.EventHandler(this.listViewDemandApartment_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Id риелтора";
            this.columnHeader17.Width = 74;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Id клиента";
            this.columnHeader18.Width = 66;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Тип";
            this.columnHeader19.Width = 36;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Мин. Цена";
            this.columnHeader20.Width = 67;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Мах. Цена";
            this.columnHeader21.Width = 69;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Мин. Площадь";
            this.columnHeader22.Width = 91;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Мах. Площадь";
            this.columnHeader23.Width = 90;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Мин. кол. комнат";
            this.columnHeader24.Width = 103;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Мах. колю комнат";
            this.columnHeader25.Width = 106;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Мин. Этаж";
            this.columnHeader26.Width = 71;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "Мах. Этаж";
            this.columnHeader27.Width = 117;
            // 
            // listViewDemandHous
            // 
            this.listViewDemandHous.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16});
            this.listViewDemandHous.FullRowSelect = true;
            this.listViewDemandHous.GridLines = true;
            this.listViewDemandHous.HideSelection = false;
            this.listViewDemandHous.Location = new System.Drawing.Point(18, 181);
            this.listViewDemandHous.MultiSelect = false;
            this.listViewDemandHous.Name = "listViewDemandHous";
            this.listViewDemandHous.Size = new System.Drawing.Size(838, 340);
            this.listViewDemandHous.TabIndex = 7;
            this.listViewDemandHous.UseCompatibleStateImageBehavior = false;
            this.listViewDemandHous.View = System.Windows.Forms.View.Details;
            this.listViewDemandHous.SelectedIndexChanged += new System.EventHandler(this.listViewDemandHous_SelectedIndexChanged);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Id риелтора";
            this.columnHeader8.Width = 102;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Id клиента";
            this.columnHeader9.Width = 99;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Тип";
            this.columnHeader10.Width = 117;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Мин. Цена";
            this.columnHeader11.Width = 89;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Мах. Цена";
            this.columnHeader12.Width = 90;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Мин. Площадь";
            this.columnHeader13.Width = 92;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Мах. Площадь";
            this.columnHeader14.Width = 90;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Мин.  кол-во этажей";
            this.columnHeader15.Width = 78;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Мах. кол-во этаж";
            this.columnHeader16.Width = 82;
            // 
            // listViewDemandLand
            // 
            this.listViewDemandLand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewDemandLand.FullRowSelect = true;
            this.listViewDemandLand.GridLines = true;
            this.listViewDemandLand.HideSelection = false;
            this.listViewDemandLand.Location = new System.Drawing.Point(18, 181);
            this.listViewDemandLand.MultiSelect = false;
            this.listViewDemandLand.Name = "listViewDemandLand";
            this.listViewDemandLand.Size = new System.Drawing.Size(838, 340);
            this.listViewDemandLand.TabIndex = 8;
            this.listViewDemandLand.UseCompatibleStateImageBehavior = false;
            this.listViewDemandLand.View = System.Windows.Forms.View.Details;
            this.listViewDemandLand.SelectedIndexChanged += new System.EventHandler(this.listViewDemandLand_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id клиента";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " Id риелтора";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Тип ";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Мин. Цена";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Мах. Цена";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Мин. Площадь";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Мах. Площадь";
            this.columnHeader7.Width = 139;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 523);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(529, 527);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(105, 48);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Создать";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(640, 527);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(105, 48);
            this.buttonEdit.TabIndex = 11;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(751, 527);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(105, 48);
            this.buttonDel.TabIndex = 12;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxMaxArea
            // 
            this.textBoxMaxArea.Location = new System.Drawing.Point(229, 151);
            this.textBoxMaxArea.Name = "textBoxMaxArea";
            this.textBoxMaxArea.Size = new System.Drawing.Size(205, 21);
            this.textBoxMaxArea.TabIndex = 19;
            // 
            // textBoxMinRooms
            // 
            this.textBoxMinRooms.Location = new System.Drawing.Point(440, 33);
            this.textBoxMinRooms.Name = "textBoxMinRooms";
            this.textBoxMinRooms.Size = new System.Drawing.Size(205, 21);
            this.textBoxMinRooms.TabIndex = 20;
            // 
            // textBoxMaxRooms
            // 
            this.textBoxMaxRooms.Location = new System.Drawing.Point(440, 73);
            this.textBoxMaxRooms.Name = "textBoxMaxRooms";
            this.textBoxMaxRooms.Size = new System.Drawing.Size(205, 21);
            this.textBoxMaxRooms.TabIndex = 21;
            // 
            // textBoxMinFloor
            // 
            this.textBoxMinFloor.Location = new System.Drawing.Point(651, 33);
            this.textBoxMinFloor.Name = "textBoxMinFloor";
            this.textBoxMinFloor.Size = new System.Drawing.Size(205, 21);
            this.textBoxMinFloor.TabIndex = 22;
            // 
            // textBoxMaxFloor
            // 
            this.textBoxMaxFloor.Location = new System.Drawing.Point(651, 73);
            this.textBoxMaxFloor.Name = "textBoxMaxFloor";
            this.textBoxMaxFloor.Size = new System.Drawing.Size(205, 21);
            this.textBoxMaxFloor.TabIndex = 23;
            // 
            // textBoxMinFloors
            // 
            this.textBoxMinFloors.Location = new System.Drawing.Point(440, 33);
            this.textBoxMinFloors.Name = "textBoxMinFloors";
            this.textBoxMinFloors.Size = new System.Drawing.Size(205, 21);
            this.textBoxMinFloors.TabIndex = 24;
            this.textBoxMinFloors.Visible = false;
            // 
            // textBoxMaxFloors
            // 
            this.textBoxMaxFloors.Location = new System.Drawing.Point(440, 73);
            this.textBoxMaxFloors.Name = "textBoxMaxFloors";
            this.textBoxMaxFloors.Size = new System.Drawing.Size(205, 21);
            this.textBoxMaxFloors.TabIndex = 25;
            this.textBoxMaxFloors.Visible = false;
            // 
            // labelIdAgent
            // 
            this.labelIdAgent.AutoSize = true;
            this.labelIdAgent.Location = new System.Drawing.Point(15, 17);
            this.labelIdAgent.Name = "labelIdAgent";
            this.labelIdAgent.Size = new System.Drawing.Size(66, 13);
            this.labelIdAgent.TabIndex = 26;
            this.labelIdAgent.Text = "Id риелтора";
            // 
            // labelIdClient
            // 
            this.labelIdClient.AutoSize = true;
            this.labelIdClient.Location = new System.Drawing.Point(15, 57);
            this.labelIdClient.Name = "labelIdClient";
            this.labelIdClient.Size = new System.Drawing.Size(60, 13);
            this.labelIdClient.TabIndex = 27;
            this.labelIdClient.Text = "Id клиента";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(15, 97);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(148, 13);
            this.labelType.TabIndex = 28;
            this.labelType.Text = "Тип объекта недвижимости";
            // 
            // labelMinPrice
            // 
            this.labelMinPrice.AutoSize = true;
            this.labelMinPrice.Location = new System.Drawing.Point(229, 17);
            this.labelMinPrice.Name = "labelMinPrice";
            this.labelMinPrice.Size = new System.Drawing.Size(106, 13);
            this.labelMinPrice.TabIndex = 29;
            this.labelMinPrice.Text = "Минимальная цена";
            // 
            // labelMaxPrice
            // 
            this.labelMaxPrice.AutoSize = true;
            this.labelMaxPrice.Location = new System.Drawing.Point(229, 57);
            this.labelMaxPrice.Name = "labelMaxPrice";
            this.labelMaxPrice.Size = new System.Drawing.Size(112, 13);
            this.labelMaxPrice.TabIndex = 30;
            this.labelMaxPrice.Text = "Максимальная цена";
            // 
            // labelMinArea
            // 
            this.labelMinArea.AutoSize = true;
            this.labelMinArea.Location = new System.Drawing.Point(229, 97);
            this.labelMinArea.Name = "labelMinArea";
            this.labelMinArea.Size = new System.Drawing.Size(127, 13);
            this.labelMinArea.TabIndex = 31;
            this.labelMinArea.Text = "Минимальная площадь";
            // 
            // labelMaxArea
            // 
            this.labelMaxArea.AutoSize = true;
            this.labelMaxArea.Location = new System.Drawing.Point(229, 135);
            this.labelMaxArea.Name = "labelMaxArea";
            this.labelMaxArea.Size = new System.Drawing.Size(133, 13);
            this.labelMaxArea.TabIndex = 32;
            this.labelMaxArea.Text = "Максимальная площадь";
            // 
            // labelMinRooms
            // 
            this.labelMinRooms.AutoSize = true;
            this.labelMinRooms.Location = new System.Drawing.Point(440, 17);
            this.labelMinRooms.Name = "labelMinRooms";
            this.labelMinRooms.Size = new System.Drawing.Size(181, 13);
            this.labelMinRooms.TabIndex = 33;
            this.labelMinRooms.Text = "Минимальное количество комнат";
            // 
            // labelMaxRooms
            // 
            this.labelMaxRooms.AutoSize = true;
            this.labelMaxRooms.Location = new System.Drawing.Point(440, 57);
            this.labelMaxRooms.Name = "labelMaxRooms";
            this.labelMaxRooms.Size = new System.Drawing.Size(187, 13);
            this.labelMaxRooms.TabIndex = 34;
            this.labelMaxRooms.Text = "Максимальное количество комнат";
            // 
            // labelMinFloor
            // 
            this.labelMinFloor.AutoSize = true;
            this.labelMinFloor.Location = new System.Drawing.Point(648, 17);
            this.labelMinFloor.Name = "labelMinFloor";
            this.labelMinFloor.Size = new System.Drawing.Size(109, 13);
            this.labelMinFloor.TabIndex = 35;
            this.labelMinFloor.Text = "Минимальный этаж";
            // 
            // labelMaxFloor
            // 
            this.labelMaxFloor.AutoSize = true;
            this.labelMaxFloor.Location = new System.Drawing.Point(649, 57);
            this.labelMaxFloor.Name = "labelMaxFloor";
            this.labelMaxFloor.Size = new System.Drawing.Size(115, 13);
            this.labelMaxFloor.TabIndex = 36;
            this.labelMaxFloor.Text = "Максимальный этаж";
            // 
            // labelMinFloors
            // 
            this.labelMinFloors.AutoSize = true;
            this.labelMinFloors.Location = new System.Drawing.Point(440, 17);
            this.labelMinFloors.Name = "labelMinFloors";
            this.labelMinFloors.Size = new System.Drawing.Size(181, 13);
            this.labelMinFloors.TabIndex = 37;
            this.labelMinFloors.Text = "Минимальное количество этажей";
            this.labelMinFloors.Visible = false;
            // 
            // labelMaxFloors
            // 
            this.labelMaxFloors.AutoSize = true;
            this.labelMaxFloors.Location = new System.Drawing.Point(440, 57);
            this.labelMaxFloors.Name = "labelMaxFloors";
            this.labelMaxFloors.Size = new System.Drawing.Size(181, 13);
            this.labelMaxFloors.TabIndex = 38;
            this.labelMaxFloors.Text = "Максимально количество этажей";
            this.labelMaxFloors.Visible = false;
            // 
            // FormDemand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 587);
            this.Controls.Add(this.labelMaxFloors);
            this.Controls.Add(this.labelMinFloors);
            this.Controls.Add(this.labelMaxFloor);
            this.Controls.Add(this.labelMinFloor);
            this.Controls.Add(this.labelMaxRooms);
            this.Controls.Add(this.labelMinRooms);
            this.Controls.Add(this.labelMaxArea);
            this.Controls.Add(this.labelMinArea);
            this.Controls.Add(this.labelMaxPrice);
            this.Controls.Add(this.labelMinPrice);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.labelIdClient);
            this.Controls.Add(this.labelIdAgent);
            this.Controls.Add(this.textBoxMaxFloors);
            this.Controls.Add(this.textBoxMinFloors);
            this.Controls.Add(this.textBoxMaxFloor);
            this.Controls.Add(this.textBoxMinFloor);
            this.Controls.Add(this.textBoxMaxRooms);
            this.Controls.Add(this.textBoxMinRooms);
            this.Controls.Add(this.textBoxMaxArea);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewDemandLand);
            this.Controls.Add(this.listViewDemandHous);
            this.Controls.Add(this.listViewDemandApartment);
            this.Controls.Add(this.textBoxMiniArea);
            this.Controls.Add(this.textBoxMaxPrice);
            this.Controls.Add(this.textBoxMiniPrice);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.comboBoxIdClient);
            this.Controls.Add(this.comboBoxIdAgent);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormDemand";
            this.Text = "FormDemand";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdAgent;
        private System.Windows.Forms.ComboBox comboBoxIdClient;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxMiniPrice;
        private System.Windows.Forms.TextBox textBoxMaxPrice;
        private System.Windows.Forms.TextBox textBoxMiniArea;
        private System.Windows.Forms.ListView listViewDemandApartment;
        private System.Windows.Forms.ListView listViewDemandHous;
        private System.Windows.Forms.ListView listViewDemandLand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxMaxArea;
        private System.Windows.Forms.TextBox textBoxMinRooms;
        private System.Windows.Forms.TextBox textBoxMaxRooms;
        private System.Windows.Forms.TextBox textBoxMinFloor;
        private System.Windows.Forms.TextBox textBoxMaxFloor;
        private System.Windows.Forms.TextBox textBoxMinFloors;
        private System.Windows.Forms.TextBox textBoxMaxFloors;
        private System.Windows.Forms.Label labelIdAgent;
        private System.Windows.Forms.Label labelIdClient;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelMinPrice;
        private System.Windows.Forms.Label labelMaxPrice;
        private System.Windows.Forms.Label labelMinArea;
        private System.Windows.Forms.Label labelMaxArea;
        private System.Windows.Forms.Label labelMinRooms;
        private System.Windows.Forms.Label labelMaxRooms;
        private System.Windows.Forms.Label labelMinFloor;
        private System.Windows.Forms.Label labelMaxFloor;
        private System.Windows.Forms.Label labelMinFloors;
        private System.Windows.Forms.Label labelMaxFloors;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}