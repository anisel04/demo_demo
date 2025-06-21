using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace demo_demo {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControlMain = new TabControl();
            tabPagePartners = new TabPage();
            buttonGoToAddPartner = new Button();
            buttonRefreshPartners = new Button();
            dataGridViewPartners = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Partner = new DataGridViewTextBoxColumn();
            Discount = new DataGridViewTextBoxColumn();
            labelPartners = new Label();
            pictureBoxPartners = new PictureBox();
            tabPageHistory = new TabPage();
            labelHistoryPartner = new Label();
            comboBoxHistory = new ComboBox();
            dataGridViewHistory = new DataGridView();
            IDh = new DataGridViewTextBoxColumn();
            Partnerh = new DataGridViewTextBoxColumn();
            Producth = new DataGridViewTextBoxColumn();
            Quantityh = new DataGridViewTextBoxColumn();
            SaleDateh = new DataGridViewTextBoxColumn();
            labelHistory = new Label();
            pictureBoxHistory = new PictureBox();
            tabPageAddPartner = new TabPage();
            buttonAddPartner = new Button();
            textBoxAddPartnerRating = new TextBox();
            labelAddPartnerRating = new Label();
            textBoxAddPartnerPhone = new TextBox();
            labelAddPartnerPhone = new Label();
            textBoxAddPartnerINN = new TextBox();
            labelAddPartnerINN = new Label();
            textBoxAddPartnerAddress = new TextBox();
            labelAddPartnerAddress = new Label();
            textBoxAddPartnerEmail = new TextBox();
            labelAddPartnerEmail = new Label();
            textBoxAddPartnerDirector = new TextBox();
            labelAddPartnerDirector = new Label();
            textBoxAddPartnerType = new TextBox();
            labelAddPartnerType = new Label();
            textBoxAddPartnerName = new TextBox();
            labelAddPartnerName = new Label();
            labelAddPartner = new Label();
            pictureBoxAddPartner = new PictureBox();
            tabPageUpdatePartner = new TabPage();
            buttonUpdatePartner = new Button();
            textBoxUpdatePartnerRating = new TextBox();
            label1 = new Label();
            textBoxUpdatePartnerPhone = new TextBox();
            label2 = new Label();
            textBoxUpdatePartnerINN = new TextBox();
            label3 = new Label();
            textBoxUpdatePartnerAddress = new TextBox();
            label4 = new Label();
            textBoxUpdatePartnerEmail = new TextBox();
            label5 = new Label();
            textBoxUpdatePartnerDirector = new TextBox();
            label6 = new Label();
            textBoxUpdatePartnerType = new TextBox();
            label7 = new Label();
            textBoxUpdatePartnerName = new TextBox();
            label8 = new Label();
            labelUpdatePartnerCombo = new Label();
            comboBoxUpdatePartner = new ComboBox();
            labelUpdatePartner = new Label();
            pictureBoxUpdatePartner = new PictureBox();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            tabControlMain.SuspendLayout();
            tabPagePartners.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPartners).BeginInit();
            tabPageHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistory).BeginInit();
            tabPageAddPartner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddPartner).BeginInit();
            tabPageUpdatePartner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdatePartner).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPagePartners);
            tabControlMain.Controls.Add(tabPageHistory);
            tabControlMain.Controls.Add(tabPageAddPartner);
            tabControlMain.Controls.Add(tabPageUpdatePartner);
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Margin = new Padding(3, 4, 3, 4);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(914, 600);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPagePartners
            // 
            tabPagePartners.BackColor = Color.White;
            tabPagePartners.Controls.Add(buttonGoToAddPartner);
            tabPagePartners.Controls.Add(buttonRefreshPartners);
            tabPagePartners.Controls.Add(dataGridViewPartners);
            tabPagePartners.Controls.Add(labelPartners);
            tabPagePartners.Controls.Add(pictureBoxPartners);
            tabPagePartners.Location = new Point(4, 29);
            tabPagePartners.Margin = new Padding(3, 4, 3, 4);
            tabPagePartners.Name = "tabPagePartners";
            tabPagePartners.Padding = new Padding(3, 4, 3, 4);
            tabPagePartners.Size = new Size(906, 567);
            tabPagePartners.TabIndex = 0;
            tabPagePartners.Text = "Партнеры";
            // 
            // buttonGoToAddPartner
            // 
            buttonGoToAddPartner.BackColor = Color.FromArgb(103, 186, 128);
            buttonGoToAddPartner.FlatStyle = FlatStyle.Flat;
            buttonGoToAddPartner.ForeColor = Color.White;
            buttonGoToAddPartner.Location = new Point(720, 44);
            buttonGoToAddPartner.Margin = new Padding(3, 4, 3, 4);
            buttonGoToAddPartner.Name = "buttonGoToAddPartner";
            buttonGoToAddPartner.Size = new Size(86, 31);
            buttonGoToAddPartner.TabIndex = 4;
            buttonGoToAddPartner.Text = "Добавить";
            buttonGoToAddPartner.UseVisualStyleBackColor = false;
            buttonGoToAddPartner.Click += buttonGoToAddPartner_Click;
            // 
            // buttonRefreshPartners
            // 
            buttonRefreshPartners.BackColor = Color.FromArgb(103, 186, 128);
            buttonRefreshPartners.FlatStyle = FlatStyle.Flat;
            buttonRefreshPartners.ForeColor = Color.White;
            buttonRefreshPartners.Location = new Point(813, 44);
            buttonRefreshPartners.Margin = new Padding(3, 4, 3, 4);
            buttonRefreshPartners.Name = "buttonRefreshPartners";
            buttonRefreshPartners.Size = new Size(86, 31);
            buttonRefreshPartners.TabIndex = 3;
            buttonRefreshPartners.Text = "Обновить";
            buttonRefreshPartners.UseVisualStyleBackColor = false;
            buttonRefreshPartners.Click += buttonRefreshPartners_Click;
            // 
            // dataGridViewPartners
            // 
            dataGridViewPartners.AllowUserToAddRows = false;
            dataGridViewPartners.AllowUserToDeleteRows = false;
            dataGridViewPartners.AllowUserToResizeColumns = false;
            dataGridViewPartners.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 230, 210);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(240, 230, 210);
            dataGridViewPartners.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPartners.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPartners.BackgroundColor = Color.FromArgb(244, 232, 211);
            dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartners.ColumnHeadersVisible = false;
            dataGridViewPartners.Columns.AddRange(new DataGridViewColumn[] { ID, Partner, Discount });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewPartners.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewPartners.GridColor = Color.FromArgb(244, 232, 211);
            dataGridViewPartners.Location = new Point(7, 83);
            dataGridViewPartners.Margin = new Padding(3, 4, 3, 4);
            dataGridViewPartners.MultiSelect = false;
            dataGridViewPartners.Name = "dataGridViewPartners";
            dataGridViewPartners.ReadOnly = true;
            dataGridViewPartners.RowHeadersVisible = false;
            dataGridViewPartners.RowHeadersWidth = 51;
            dataGridViewPartners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartners.ShowEditingIcon = false;
            dataGridViewPartners.Size = new Size(891, 472);
            dataGridViewPartners.TabIndex = 2;
            dataGridViewPartners.CellDoubleClick += dataGridViewPartners_CellDoubleClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Partner
            // 
            Partner.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Partner.FillWeight = 80F;
            Partner.HeaderText = "Partner";
            Partner.MinimumWidth = 6;
            Partner.Name = "Partner";
            Partner.ReadOnly = true;
            // 
            // Discount
            // 
            Discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Discount.FillWeight = 20F;
            Discount.HeaderText = "Discount";
            Discount.MinimumWidth = 6;
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            // 
            // labelPartners
            // 
            labelPartners.AutoSize = true;
            labelPartners.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelPartners.ForeColor = Color.FromArgb(103, 186, 128);
            labelPartners.Location = new Point(71, 25);
            labelPartners.Name = "labelPartners";
            labelPartners.Size = new Size(243, 28);
            labelPartners.TabIndex = 1;
            labelPartners.Text = "Мастер пол | Партнеры";
            // 
            // pictureBoxPartners
            // 
            pictureBoxPartners.Image = Properties.Resources.Мастер_пол;
            pictureBoxPartners.Location = new Point(7, 8);
            pictureBoxPartners.Margin = new Padding(3, 4, 3, 4);
            pictureBoxPartners.Name = "pictureBoxPartners";
            pictureBoxPartners.Size = new Size(57, 67);
            pictureBoxPartners.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPartners.TabIndex = 0;
            pictureBoxPartners.TabStop = false;
            // 
            // tabPageHistory
            // 
            tabPageHistory.Controls.Add(labelHistoryPartner);
            tabPageHistory.Controls.Add(comboBoxHistory);
            tabPageHistory.Controls.Add(dataGridViewHistory);
            tabPageHistory.Controls.Add(labelHistory);
            tabPageHistory.Controls.Add(pictureBoxHistory);
            tabPageHistory.Location = new Point(4, 29);
            tabPageHistory.Margin = new Padding(3, 4, 3, 4);
            tabPageHistory.Name = "tabPageHistory";
            tabPageHistory.Padding = new Padding(3, 4, 3, 4);
            tabPageHistory.Size = new Size(906, 567);
            tabPageHistory.TabIndex = 1;
            tabPageHistory.Text = "История продаж";
            tabPageHistory.UseVisualStyleBackColor = true;
            // 
            // labelHistoryPartner
            // 
            labelHistoryPartner.AutoSize = true;
            labelHistoryPartner.Location = new Point(446, 48);
            labelHistoryPartner.Name = "labelHistoryPartner";
            labelHistoryPartner.Size = new Size(72, 20);
            labelHistoryPartner.TabIndex = 7;
            labelHistoryPartner.Text = "Партнер:";
            // 
            // comboBoxHistory
            // 
            comboBoxHistory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxHistory.FormattingEnabled = true;
            comboBoxHistory.Location = new Point(518, 44);
            comboBoxHistory.Margin = new Padding(3, 4, 3, 4);
            comboBoxHistory.Name = "comboBoxHistory";
            comboBoxHistory.Size = new Size(378, 28);
            comboBoxHistory.TabIndex = 6;
            comboBoxHistory.SelectedValueChanged += comboBoxHistory_SelectedValueChanged;
            // 
            // dataGridViewHistory
            // 
            dataGridViewHistory.AllowUserToAddRows = false;
            dataGridViewHistory.AllowUserToDeleteRows = false;
            dataGridViewHistory.AllowUserToResizeColumns = false;
            dataGridViewHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(233, 222, 201);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(233, 222, 201);
            dataGridViewHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewHistory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewHistory.BackgroundColor = Color.FromArgb(244, 232, 211);
            dataGridViewHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewHistory.Columns.AddRange(new DataGridViewColumn[] { IDh, Partnerh, Producth, Quantityh, SaleDateh });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(244, 232, 211);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(103, 186, 128);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewHistory.GridColor = Color.FromArgb(244, 232, 211);
            dataGridViewHistory.Location = new Point(7, 80);
            dataGridViewHistory.Margin = new Padding(3, 4, 3, 4);
            dataGridViewHistory.MultiSelect = false;
            dataGridViewHistory.Name = "dataGridViewHistory";
            dataGridViewHistory.ReadOnly = true;
            dataGridViewHistory.RowHeadersVisible = false;
            dataGridViewHistory.RowHeadersWidth = 51;
            dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewHistory.ShowEditingIcon = false;
            dataGridViewHistory.Size = new Size(891, 475);
            dataGridViewHistory.TabIndex = 4;
            // 
            // IDh
            // 
            IDh.HeaderText = "ID";
            IDh.MinimumWidth = 6;
            IDh.Name = "IDh";
            IDh.ReadOnly = true;
            IDh.Visible = false;
            IDh.Width = 125;
            // 
            // Partnerh
            // 
            Partnerh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Partnerh.FillWeight = 30F;
            Partnerh.HeaderText = "Партнер";
            Partnerh.MinimumWidth = 6;
            Partnerh.Name = "Partnerh";
            Partnerh.ReadOnly = true;
            Partnerh.Visible = false;
            // 
            // Producth
            // 
            Producth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Producth.FillWeight = 85F;
            Producth.HeaderText = "Продукт";
            Producth.MinimumWidth = 6;
            Producth.Name = "Producth";
            Producth.ReadOnly = true;
            // 
            // Quantityh
            // 
            Quantityh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Quantityh.FillWeight = 15F;
            Quantityh.HeaderText = "Количество";
            Quantityh.MinimumWidth = 6;
            Quantityh.Name = "Quantityh";
            Quantityh.ReadOnly = true;
            // 
            // SaleDateh
            // 
            SaleDateh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SaleDateh.FillWeight = 20F;
            SaleDateh.HeaderText = "Дата продажи";
            SaleDateh.MinimumWidth = 6;
            SaleDateh.Name = "SaleDateh";
            SaleDateh.ReadOnly = true;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelHistory.ForeColor = Color.FromArgb(103, 186, 128);
            labelHistory.Location = new Point(71, 25);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(310, 28);
            labelHistory.TabIndex = 3;
            labelHistory.Text = "Мастер пол | История продаж";
            // 
            // pictureBoxHistory
            // 
            pictureBoxHistory.Image = Properties.Resources.Мастер_пол;
            pictureBoxHistory.Location = new Point(7, 8);
            pictureBoxHistory.Margin = new Padding(3, 4, 3, 4);
            pictureBoxHistory.Name = "pictureBoxHistory";
            pictureBoxHistory.Size = new Size(57, 67);
            pictureBoxHistory.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHistory.TabIndex = 2;
            pictureBoxHistory.TabStop = false;
            // 
            // tabPageAddPartner
            // 
            tabPageAddPartner.Controls.Add(buttonAddPartner);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerRating);
            tabPageAddPartner.Controls.Add(labelAddPartnerRating);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerPhone);
            tabPageAddPartner.Controls.Add(labelAddPartnerPhone);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerINN);
            tabPageAddPartner.Controls.Add(labelAddPartnerINN);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerAddress);
            tabPageAddPartner.Controls.Add(labelAddPartnerAddress);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerEmail);
            tabPageAddPartner.Controls.Add(labelAddPartnerEmail);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerDirector);
            tabPageAddPartner.Controls.Add(labelAddPartnerDirector);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerType);
            tabPageAddPartner.Controls.Add(labelAddPartnerType);
            tabPageAddPartner.Controls.Add(textBoxAddPartnerName);
            tabPageAddPartner.Controls.Add(labelAddPartnerName);
            tabPageAddPartner.Controls.Add(labelAddPartner);
            tabPageAddPartner.Controls.Add(pictureBoxAddPartner);
            tabPageAddPartner.Location = new Point(4, 29);
            tabPageAddPartner.Margin = new Padding(3, 4, 3, 4);
            tabPageAddPartner.Name = "tabPageAddPartner";
            tabPageAddPartner.Padding = new Padding(3, 4, 3, 4);
            tabPageAddPartner.Size = new Size(906, 567);
            tabPageAddPartner.TabIndex = 2;
            tabPageAddPartner.Text = "Добавление партнера";
            tabPageAddPartner.UseVisualStyleBackColor = true;
            // 
            // buttonAddPartner
            // 
            buttonAddPartner.BackColor = Color.FromArgb(103, 186, 128);
            buttonAddPartner.FlatStyle = FlatStyle.Flat;
            buttonAddPartner.ForeColor = Color.White;
            buttonAddPartner.Location = new Point(146, 411);
            buttonAddPartner.Margin = new Padding(3, 4, 3, 4);
            buttonAddPartner.Name = "buttonAddPartner";
            buttonAddPartner.Size = new Size(94, 36);
            buttonAddPartner.TabIndex = 22;
            buttonAddPartner.Text = "Добавить";
            buttonAddPartner.UseVisualStyleBackColor = false;
            buttonAddPartner.Click += buttonAddPartner_Click;
            // 
            // textBoxAddPartnerRating
            // 
            textBoxAddPartnerRating.Location = new Point(146, 372);
            textBoxAddPartnerRating.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerRating.Name = "textBoxAddPartnerRating";
            textBoxAddPartnerRating.Size = new Size(75, 27);
            textBoxAddPartnerRating.TabIndex = 21;
            // 
            // labelAddPartnerRating
            // 
            labelAddPartnerRating.AutoSize = true;
            labelAddPartnerRating.Location = new Point(78, 376);
            labelAddPartnerRating.Name = "labelAddPartnerRating";
            labelAddPartnerRating.Size = new Size(67, 20);
            labelAddPartnerRating.TabIndex = 20;
            labelAddPartnerRating.Text = "Рейтинг:";
            // 
            // textBoxAddPartnerPhone
            // 
            textBoxAddPartnerPhone.Location = new Point(146, 333);
            textBoxAddPartnerPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerPhone.Name = "textBoxAddPartnerPhone";
            textBoxAddPartnerPhone.Size = new Size(148, 27);
            textBoxAddPartnerPhone.TabIndex = 19;
            // 
            // labelAddPartnerPhone
            // 
            labelAddPartnerPhone.AutoSize = true;
            labelAddPartnerPhone.Location = new Point(73, 337);
            labelAddPartnerPhone.Name = "labelAddPartnerPhone";
            labelAddPartnerPhone.Size = new Size(72, 20);
            labelAddPartnerPhone.TabIndex = 18;
            labelAddPartnerPhone.Text = "Телефон:";
            // 
            // textBoxAddPartnerINN
            // 
            textBoxAddPartnerINN.Location = new Point(146, 295);
            textBoxAddPartnerINN.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerINN.Name = "textBoxAddPartnerINN";
            textBoxAddPartnerINN.Size = new Size(325, 27);
            textBoxAddPartnerINN.TabIndex = 17;
            // 
            // labelAddPartnerINN
            // 
            labelAddPartnerINN.AutoSize = true;
            labelAddPartnerINN.Location = new Point(97, 299);
            labelAddPartnerINN.Name = "labelAddPartnerINN";
            labelAddPartnerINN.Size = new Size(45, 20);
            labelAddPartnerINN.TabIndex = 16;
            labelAddPartnerINN.Text = "ИНН:";
            // 
            // textBoxAddPartnerAddress
            // 
            textBoxAddPartnerAddress.Location = new Point(146, 256);
            textBoxAddPartnerAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerAddress.Name = "textBoxAddPartnerAddress";
            textBoxAddPartnerAddress.Size = new Size(325, 27);
            textBoxAddPartnerAddress.TabIndex = 15;
            // 
            // labelAddPartnerAddress
            // 
            labelAddPartnerAddress.AutoSize = true;
            labelAddPartnerAddress.Location = new Point(95, 260);
            labelAddPartnerAddress.Name = "labelAddPartnerAddress";
            labelAddPartnerAddress.Size = new Size(54, 20);
            labelAddPartnerAddress.TabIndex = 14;
            labelAddPartnerAddress.Text = "Адрес:";
            // 
            // textBoxAddPartnerEmail
            // 
            textBoxAddPartnerEmail.Location = new Point(146, 217);
            textBoxAddPartnerEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerEmail.Name = "textBoxAddPartnerEmail";
            textBoxAddPartnerEmail.Size = new Size(325, 27);
            textBoxAddPartnerEmail.TabIndex = 13;
            // 
            // labelAddPartnerEmail
            // 
            labelAddPartnerEmail.AutoSize = true;
            labelAddPartnerEmail.Location = new Point(95, 221);
            labelAddPartnerEmail.Name = "labelAddPartnerEmail";
            labelAddPartnerEmail.Size = new Size(49, 20);
            labelAddPartnerEmail.TabIndex = 12;
            labelAddPartnerEmail.Text = "Email:";
            // 
            // textBoxAddPartnerDirector
            // 
            textBoxAddPartnerDirector.Location = new Point(146, 179);
            textBoxAddPartnerDirector.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerDirector.Name = "textBoxAddPartnerDirector";
            textBoxAddPartnerDirector.Size = new Size(325, 27);
            textBoxAddPartnerDirector.TabIndex = 11;
            // 
            // labelAddPartnerDirector
            // 
            labelAddPartnerDirector.AutoSize = true;
            labelAddPartnerDirector.Location = new Point(67, 183);
            labelAddPartnerDirector.Name = "labelAddPartnerDirector";
            labelAddPartnerDirector.Size = new Size(79, 20);
            labelAddPartnerDirector.TabIndex = 10;
            labelAddPartnerDirector.Text = "Директор:";
            // 
            // textBoxAddPartnerType
            // 
            textBoxAddPartnerType.Location = new Point(146, 140);
            textBoxAddPartnerType.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerType.Name = "textBoxAddPartnerType";
            textBoxAddPartnerType.Size = new Size(325, 27);
            textBoxAddPartnerType.TabIndex = 9;
            // 
            // labelAddPartnerType
            // 
            labelAddPartnerType.AutoSize = true;
            labelAddPartnerType.Location = new Point(43, 144);
            labelAddPartnerType.Name = "labelAddPartnerType";
            labelAddPartnerType.Size = new Size(108, 20);
            labelAddPartnerType.TabIndex = 8;
            labelAddPartnerType.Text = "Тип партнера:";
            // 
            // textBoxAddPartnerName
            // 
            textBoxAddPartnerName.Location = new Point(146, 101);
            textBoxAddPartnerName.Margin = new Padding(3, 4, 3, 4);
            textBoxAddPartnerName.Name = "textBoxAddPartnerName";
            textBoxAddPartnerName.Size = new Size(325, 27);
            textBoxAddPartnerName.TabIndex = 7;
            // 
            // labelAddPartnerName
            // 
            labelAddPartnerName.AutoSize = true;
            labelAddPartnerName.Location = new Point(7, 105);
            labelAddPartnerName.Name = "labelAddPartnerName";
            labelAddPartnerName.Size = new Size(150, 20);
            labelAddPartnerName.TabIndex = 6;
            labelAddPartnerName.Text = "Название партнера:";
            // 
            // labelAddPartner
            // 
            labelAddPartner.AutoSize = true;
            labelAddPartner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddPartner.ForeColor = Color.FromArgb(103, 186, 128);
            labelAddPartner.Location = new Point(71, 25);
            labelAddPartner.Name = "labelAddPartner";
            labelAddPartner.Size = new Size(363, 28);
            labelAddPartner.TabIndex = 5;
            labelAddPartner.Text = "Мастер пол | Добавление партнера";
            // 
            // pictureBoxAddPartner
            // 
            pictureBoxAddPartner.Image = Properties.Resources.Мастер_пол;
            pictureBoxAddPartner.Location = new Point(7, 8);
            pictureBoxAddPartner.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAddPartner.Name = "pictureBoxAddPartner";
            pictureBoxAddPartner.Size = new Size(57, 67);
            pictureBoxAddPartner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAddPartner.TabIndex = 4;
            pictureBoxAddPartner.TabStop = false;
            // 
            // tabPageUpdatePartner
            // 
            tabPageUpdatePartner.Controls.Add(buttonUpdatePartner);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerRating);
            tabPageUpdatePartner.Controls.Add(label1);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerPhone);
            tabPageUpdatePartner.Controls.Add(label2);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerINN);
            tabPageUpdatePartner.Controls.Add(label3);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerAddress);
            tabPageUpdatePartner.Controls.Add(label4);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerEmail);
            tabPageUpdatePartner.Controls.Add(label5);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerDirector);
            tabPageUpdatePartner.Controls.Add(label6);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerType);
            tabPageUpdatePartner.Controls.Add(label7);
            tabPageUpdatePartner.Controls.Add(textBoxUpdatePartnerName);
            tabPageUpdatePartner.Controls.Add(label8);
            tabPageUpdatePartner.Controls.Add(labelUpdatePartnerCombo);
            tabPageUpdatePartner.Controls.Add(comboBoxUpdatePartner);
            tabPageUpdatePartner.Controls.Add(labelUpdatePartner);
            tabPageUpdatePartner.Controls.Add(pictureBoxUpdatePartner);
            tabPageUpdatePartner.Location = new Point(4, 29);
            tabPageUpdatePartner.Margin = new Padding(3, 4, 3, 4);
            tabPageUpdatePartner.Name = "tabPageUpdatePartner";
            tabPageUpdatePartner.Padding = new Padding(3, 4, 3, 4);
            tabPageUpdatePartner.Size = new Size(906, 567);
            tabPageUpdatePartner.TabIndex = 3;
            tabPageUpdatePartner.Text = "Редактирование партнера";
            tabPageUpdatePartner.UseVisualStyleBackColor = true;
            // 
            // buttonUpdatePartner
            // 
            buttonUpdatePartner.BackColor = Color.FromArgb(103, 186, 128);
            buttonUpdatePartner.FlatStyle = FlatStyle.Flat;
            buttonUpdatePartner.ForeColor = Color.Transparent;
            buttonUpdatePartner.Location = new Point(223, 467);
            buttonUpdatePartner.Margin = new Padding(3, 4, 3, 4);
            buttonUpdatePartner.Name = "buttonUpdatePartner";
            buttonUpdatePartner.Size = new Size(176, 36);
            buttonUpdatePartner.TabIndex = 39;
            buttonUpdatePartner.Text = "Сохранить изменения";
            buttonUpdatePartner.UseVisualStyleBackColor = false;
            buttonUpdatePartner.Click += buttonUpdatePartner_Click;
            // 
            // textBoxUpdatePartnerRating
            // 
            textBoxUpdatePartnerRating.Location = new Point(223, 428);
            textBoxUpdatePartnerRating.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerRating.Name = "textBoxUpdatePartnerRating";
            textBoxUpdatePartnerRating.Size = new Size(75, 27);
            textBoxUpdatePartnerRating.TabIndex = 38;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 432);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 37;
            label1.Text = "Рейтинг:";
            // 
            // textBoxUpdatePartnerPhone
            // 
            textBoxUpdatePartnerPhone.Location = new Point(223, 389);
            textBoxUpdatePartnerPhone.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerPhone.Name = "textBoxUpdatePartnerPhone";
            textBoxUpdatePartnerPhone.Size = new Size(148, 27);
            textBoxUpdatePartnerPhone.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 393);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 35;
            label2.Text = "Телефон:";
            // 
            // textBoxUpdatePartnerINN
            // 
            textBoxUpdatePartnerINN.Location = new Point(223, 351);
            textBoxUpdatePartnerINN.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerINN.Name = "textBoxUpdatePartnerINN";
            textBoxUpdatePartnerINN.Size = new Size(325, 27);
            textBoxUpdatePartnerINN.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 355);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 33;
            label3.Text = "ИНН:";
            // 
            // textBoxUpdatePartnerAddress
            // 
            textBoxUpdatePartnerAddress.Location = new Point(223, 312);
            textBoxUpdatePartnerAddress.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerAddress.Name = "textBoxUpdatePartnerAddress";
            textBoxUpdatePartnerAddress.Size = new Size(325, 27);
            textBoxUpdatePartnerAddress.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(171, 316);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 31;
            label4.Text = "Адрес:";
            // 
            // textBoxUpdatePartnerEmail
            // 
            textBoxUpdatePartnerEmail.Location = new Point(223, 273);
            textBoxUpdatePartnerEmail.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerEmail.Name = "textBoxUpdatePartnerEmail";
            textBoxUpdatePartnerEmail.Size = new Size(325, 27);
            textBoxUpdatePartnerEmail.TabIndex = 30;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 277);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 29;
            label5.Text = "Email:";
            // 
            // textBoxUpdatePartnerDirector
            // 
            textBoxUpdatePartnerDirector.Location = new Point(223, 235);
            textBoxUpdatePartnerDirector.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerDirector.Name = "textBoxUpdatePartnerDirector";
            textBoxUpdatePartnerDirector.Size = new Size(325, 27);
            textBoxUpdatePartnerDirector.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(144, 239);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 27;
            label6.Text = "Директор:";
            // 
            // textBoxUpdatePartnerType
            // 
            textBoxUpdatePartnerType.Location = new Point(223, 196);
            textBoxUpdatePartnerType.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerType.Name = "textBoxUpdatePartnerType";
            textBoxUpdatePartnerType.Size = new Size(325, 27);
            textBoxUpdatePartnerType.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(120, 200);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 25;
            label7.Text = "Тип партнера:";
            // 
            // textBoxUpdatePartnerName
            // 
            textBoxUpdatePartnerName.Location = new Point(223, 157);
            textBoxUpdatePartnerName.Margin = new Padding(3, 4, 3, 4);
            textBoxUpdatePartnerName.Name = "textBoxUpdatePartnerName";
            textBoxUpdatePartnerName.Size = new Size(325, 27);
            textBoxUpdatePartnerName.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(83, 161);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 23;
            label8.Text = "Название партнера:";
            // 
            // labelUpdatePartnerCombo
            // 
            labelUpdatePartnerCombo.AutoSize = true;
            labelUpdatePartnerCombo.Location = new Point(64, 95);
            labelUpdatePartnerCombo.Name = "labelUpdatePartnerCombo";
            labelUpdatePartnerCombo.Size = new Size(72, 20);
            labelUpdatePartnerCombo.TabIndex = 9;
            labelUpdatePartnerCombo.Text = "Партнер:";
            // 
            // comboBoxUpdatePartner
            // 
            comboBoxUpdatePartner.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUpdatePartner.FormattingEnabled = true;
            comboBoxUpdatePartner.Location = new Point(136, 91);
            comboBoxUpdatePartner.Margin = new Padding(3, 4, 3, 4);
            comboBoxUpdatePartner.Name = "comboBoxUpdatePartner";
            comboBoxUpdatePartner.Size = new Size(287, 28);
            comboBoxUpdatePartner.TabIndex = 8;
            comboBoxUpdatePartner.SelectedValueChanged += comboBoxUpdatePartner_SelectedValueChanged;
            // 
            // labelUpdatePartner
            // 
            labelUpdatePartner.AutoSize = true;
            labelUpdatePartner.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUpdatePartner.ForeColor = Color.FromArgb(103, 186, 128);
            labelUpdatePartner.Location = new Point(71, 25);
            labelUpdatePartner.Name = "labelUpdatePartner";
            labelUpdatePartner.Size = new Size(402, 28);
            labelUpdatePartner.TabIndex = 7;
            labelUpdatePartner.Text = "Мастер пол | Редактирование партнера";
            // 
            // pictureBoxUpdatePartner
            // 
            pictureBoxUpdatePartner.Image = Properties.Resources.Мастер_пол;
            pictureBoxUpdatePartner.Location = new Point(7, 8);
            pictureBoxUpdatePartner.Margin = new Padding(3, 4, 3, 4);
            pictureBoxUpdatePartner.Name = "pictureBoxUpdatePartner";
            pictureBoxUpdatePartner.Size = new Size(57, 67);
            pictureBoxUpdatePartner.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUpdatePartner.TabIndex = 6;
            pictureBoxUpdatePartner.TabStop = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(362, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Мастер пол";
            tabControlMain.ResumeLayout(false);
            tabPagePartners.ResumeLayout(false);
            tabPagePartners.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPartners).EndInit();
            tabPageHistory.ResumeLayout(false);
            tabPageHistory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewHistory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHistory).EndInit();
            tabPageAddPartner.ResumeLayout(false);
            tabPageAddPartner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddPartner).EndInit();
            tabPageUpdatePartner.ResumeLayout(false);
            tabPageUpdatePartner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxUpdatePartner).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPagePartners;
        private PictureBox pictureBoxPartners;
        private TabPage tabPageHistory;
        private Button buttonRefreshPartners;
        private DataGridView dataGridViewPartners;
        private Label labelPartners;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Partner;
        private DataGridViewTextBoxColumn Discount;
        private Button buttonGoToAddPartner;
        private DataGridView dataGridViewHistory;
        private Label labelHistory;
        private PictureBox pictureBoxHistory;
        private TabPage tabPageAddPartner;
        private Label labelAddPartner;
        private PictureBox pictureBoxAddPartner;
        private TextBox textBoxAddPartnerDirector;
        private Label labelAddPartnerDirector;
        private TextBox textBoxAddPartnerType;
        private Label labelAddPartnerType;
        private TextBox textBoxAddPartnerName;
        private Label labelAddPartnerName;
        private TextBox textBoxAddPartnerEmail;
        private Label labelAddPartnerEmail;
        private TextBox textBoxAddPartnerAddress;
        private Label labelAddPartnerAddress;
        private TextBox textBoxAddPartnerINN;
        private Label labelAddPartnerINN;
        private TextBox textBoxAddPartnerPhone;
        private Label labelAddPartnerPhone;
        private TextBox textBoxAddPartnerRating;
        private Label labelAddPartnerRating;
        private Button buttonAddPartner;
        private TabPage tabPageUpdatePartner;
        private Label labelUpdatePartner;
        private PictureBox pictureBoxUpdatePartner;
        private Label labelHistoryPartner;
        private ComboBox comboBoxHistory;
        private DataGridViewTextBoxColumn IDh;
        private DataGridViewTextBoxColumn Partnerh;
        private DataGridViewTextBoxColumn Producth;
        private DataGridViewTextBoxColumn Quantityh;
        private DataGridViewTextBoxColumn SaleDateh;
        private Label labelUpdatePartnerCombo;
        private ComboBox comboBoxUpdatePartner;
        private Button buttonUpdatePartner;
        private TextBox textBoxUpdatePartnerRating;
        private Label label1;
        private TextBox textBoxUpdatePartnerPhone;
        private Label label2;
        private TextBox textBoxUpdatePartnerINN;
        private Label label3;
        private TextBox textBoxUpdatePartnerAddress;
        private Label label4;
        private TextBox textBoxUpdatePartnerEmail;
        private Label label5;
        private TextBox textBoxUpdatePartnerDirector;
        private Label label6;
        private TextBox textBoxUpdatePartnerType;
        private Label label7;
        private TextBox textBoxUpdatePartnerName;
        private Label label8;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}
