namespace Task.Views
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.registryToExcelButton = new System.Windows.Forms.Button();
            this.toExcelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.vatTextBox = new System.Windows.Forms.TextBox();
            this.tariffTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.organizationTabPage = new System.Windows.Forms.TabPage();
            this.addCarButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CarId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLabel = new System.Windows.Forms.Label();
            this.contractLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.organizationComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.requestTabPage = new System.Windows.Forms.TabPage();
            this.month1ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addRequestButton = new System.Windows.Forms.Button();
            this.CarBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SnowVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateRegistrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodyCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requestIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waybillNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.organizationTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.requestTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.reportTabPage);
            this.tabControl1.Controls.Add(this.organizationTabPage);
            this.tabControl1.Controls.Add(this.requestTabPage);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(716, 355);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.registryToExcelButton);
            this.reportTabPage.Controls.Add(this.toExcelButton);
            this.reportTabPage.Controls.Add(this.label1);
            this.reportTabPage.Controls.Add(this.monthComboBox);
            this.reportTabPage.Controls.Add(this.vatTextBox);
            this.reportTabPage.Controls.Add(this.tariffTextBox);
            this.reportTabPage.Controls.Add(this.label10);
            this.reportTabPage.Controls.Add(this.label9);
            this.reportTabPage.Location = new System.Drawing.Point(4, 24);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(708, 327);
            this.reportTabPage.TabIndex = 0;
            this.reportTabPage.Text = "Отчет";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // registryToExcelButton
            // 
            this.registryToExcelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registryToExcelButton.Location = new System.Drawing.Point(10, 70);
            this.registryToExcelButton.Name = "registryToExcelButton";
            this.registryToExcelButton.Size = new System.Drawing.Size(137, 29);
            this.registryToExcelButton.TabIndex = 11;
            this.registryToExcelButton.Text = "Реестр";
            this.registryToExcelButton.UseVisualStyleBackColor = true;
            this.registryToExcelButton.Click += new System.EventHandler(this.registryToExcelButton_Click);
            // 
            // toExcelButton
            // 
            this.toExcelButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toExcelButton.Location = new System.Drawing.Point(10, 35);
            this.toExcelButton.Name = "toExcelButton";
            this.toExcelButton.Size = new System.Drawing.Size(137, 29);
            this.toExcelButton.TabIndex = 10;
            this.toExcelButton.Text = "Прием снега";
            this.toExcelButton.UseVisualStyleBackColor = true;
            this.toExcelButton.Click += new System.EventHandler(this.toExcelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Месяц";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(65, 6);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(121, 23);
            this.monthComboBox.TabIndex = 8;
            // 
            // vatTextBox
            // 
            this.vatTextBox.Location = new System.Drawing.Point(602, 34);
            this.vatTextBox.Name = "vatTextBox";
            this.vatTextBox.Size = new System.Drawing.Size(100, 22);
            this.vatTextBox.TabIndex = 7;
            this.vatTextBox.Leave += new System.EventHandler(this.vatTextBox_Leave);
            // 
            // tariffTextBox
            // 
            this.tariffTextBox.Location = new System.Drawing.Point(602, 6);
            this.tariffTextBox.Name = "tariffTextBox";
            this.tariffTextBox.Size = new System.Drawing.Size(100, 22);
            this.tariffTextBox.TabIndex = 6;
            this.tariffTextBox.Leave += new System.EventHandler(this.tariffTextBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(482, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "Ставка НДС, %";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(340, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(256, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Тариф за 1 куб. м. без НДС, руб. коп.";
            // 
            // organizationTabPage
            // 
            this.organizationTabPage.Controls.Add(this.addCarButton);
            this.organizationTabPage.Controls.Add(this.dataGridView1);
            this.organizationTabPage.Controls.Add(this.dateLabel);
            this.organizationTabPage.Controls.Add(this.contractLabel);
            this.organizationTabPage.Controls.Add(this.label6);
            this.organizationTabPage.Controls.Add(this.label5);
            this.organizationTabPage.Controls.Add(this.label4);
            this.organizationTabPage.Controls.Add(this.deleteButton);
            this.organizationTabPage.Controls.Add(this.editButton);
            this.organizationTabPage.Controls.Add(this.addButton);
            this.organizationTabPage.Controls.Add(this.organizationComboBox);
            this.organizationTabPage.Controls.Add(this.label3);
            this.organizationTabPage.Location = new System.Drawing.Point(4, 24);
            this.organizationTabPage.Name = "organizationTabPage";
            this.organizationTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.organizationTabPage.Size = new System.Drawing.Size(708, 327);
            this.organizationTabPage.TabIndex = 1;
            this.organizationTabPage.Text = "Организации";
            this.organizationTabPage.UseVisualStyleBackColor = true;
            // 
            // addCarButton
            // 
            this.addCarButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarButton.Location = new System.Drawing.Point(12, 294);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(117, 27);
            this.addCarButton.TabIndex = 20;
            this.addCarButton.Text = "Добавить автомобиль";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carBrandDataGridViewTextBoxColumn,
            this.carModelDataGridViewTextBoxColumn,
            this.stateRegistrationNumberDataGridViewTextBoxColumn,
            this.bodyCapacityDataGridViewTextBoxColumn,
            this.CarId});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(684, 173);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // CarId
            // 
            this.CarId.DataPropertyName = "CarId";
            this.CarId.HeaderText = "CarId";
            this.CarId.Name = "CarId";
            this.CarId.Visible = false;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(251, 59);
            this.dateLabel.MinimumSize = new System.Drawing.Size(116, 17);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(116, 21);
            this.dateLabel.TabIndex = 16;
            // 
            // contractLabel
            // 
            this.contractLabel.AutoSize = true;
            this.contractLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contractLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractLabel.Location = new System.Drawing.Point(99, 59);
            this.contractLabel.MinimumSize = new System.Drawing.Size(116, 17);
            this.contractLabel.Name = "contractLabel";
            this.contractLabel.Size = new System.Drawing.Size(116, 21);
            this.contractLabel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(8, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Список автомобилей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(221, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Договор №";
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(579, 27);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(117, 27);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editButton.Location = new System.Drawing.Point(456, 27);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(117, 27);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(333, 27);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(117, 27);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // organizationComboBox
            // 
            this.organizationComboBox.FormattingEnabled = true;
            this.organizationComboBox.Location = new System.Drawing.Point(12, 30);
            this.organizationComboBox.Name = "organizationComboBox";
            this.organizationComboBox.Size = new System.Drawing.Size(315, 23);
            this.organizationComboBox.TabIndex = 1;
            this.organizationComboBox.SelectedValueChanged += new System.EventHandler(this.organizationComboBox_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Наименование организации";
            // 
            // requestTabPage
            // 
            this.requestTabPage.Controls.Add(this.month1ComboBox);
            this.requestTabPage.Controls.Add(this.label2);
            this.requestTabPage.Controls.Add(this.dataGridView2);
            this.requestTabPage.Controls.Add(this.addRequestButton);
            this.requestTabPage.Location = new System.Drawing.Point(4, 24);
            this.requestTabPage.Name = "requestTabPage";
            this.requestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestTabPage.Size = new System.Drawing.Size(708, 327);
            this.requestTabPage.TabIndex = 2;
            this.requestTabPage.Text = "Заявки";
            this.requestTabPage.UseVisualStyleBackColor = true;
            // 
            // month1ComboBox
            // 
            this.month1ComboBox.FormattingEnabled = true;
            this.month1ComboBox.Location = new System.Drawing.Point(66, 7);
            this.month1ComboBox.Name = "month1ComboBox";
            this.month1ComboBox.Size = new System.Drawing.Size(121, 23);
            this.month1ComboBox.TabIndex = 8;
            this.month1ComboBox.SelectedValueChanged += new System.EventHandler(this.month1ComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Месяц";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestIdDataGridViewTextBoxColumn,
            this.dateRequestDataGridViewTextBoxColumn,
            this.timeRequestDataGridViewTextBoxColumn,
            this.waybillNumberDataGridViewTextBoxColumn,
            this.carIdDataGridViewTextBoxColumn,
            this.carDataGridViewTextBoxColumn,
            this.CarBrand,
            this.Number,
            this.SnowVolume});
            this.dataGridView2.DataSource = this.requestBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(681, 249);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView2_DataError);
            this.dataGridView2.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_UserDeletedRow);
            this.dataGridView2.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView2_UserDeletingRow);
            // 
            // addRequestButton
            // 
            this.addRequestButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addRequestButton.Location = new System.Drawing.Point(11, 294);
            this.addRequestButton.Name = "addRequestButton";
            this.addRequestButton.Size = new System.Drawing.Size(87, 27);
            this.addRequestButton.TabIndex = 5;
            this.addRequestButton.Text = "Добавить";
            this.addRequestButton.UseVisualStyleBackColor = true;
            this.addRequestButton.Click += new System.EventHandler(this.addRequestButton_Click);
            // 
            // CarBrand
            // 
            this.CarBrand.DataPropertyName = "CarBrand";
            this.CarBrand.HeaderText = "Марка автомобиля";
            this.CarBrand.Name = "CarBrand";
            this.CarBrand.ReadOnly = true;
            this.CarBrand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "StateRegistrationNumber";
            this.Number.DataSource = this.carBindingSource1;
            this.Number.HeaderText = "Гос. рег. номер";
            this.Number.Name = "Number";
            // 
            // SnowVolume
            // 
            this.SnowVolume.DataPropertyName = "BodyCapacity";
            this.SnowVolume.HeaderText = "Объем снега (куб. м)";
            this.SnowVolume.Name = "SnowVolume";
            this.SnowVolume.ReadOnly = true;
            this.SnowVolume.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SnowVolume.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // carBrandDataGridViewTextBoxColumn
            // 
            this.carBrandDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carBrandDataGridViewTextBoxColumn.DataPropertyName = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.HeaderText = "Марка";
            this.carBrandDataGridViewTextBoxColumn.Name = "carBrandDataGridViewTextBoxColumn";
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            // 
            // stateRegistrationNumberDataGridViewTextBoxColumn
            // 
            this.stateRegistrationNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stateRegistrationNumberDataGridViewTextBoxColumn.DataPropertyName = "StateRegistrationNumber";
            this.stateRegistrationNumberDataGridViewTextBoxColumn.HeaderText = "Гос. рег. знак";
            this.stateRegistrationNumberDataGridViewTextBoxColumn.Name = "stateRegistrationNumberDataGridViewTextBoxColumn";
            // 
            // bodyCapacityDataGridViewTextBoxColumn
            // 
            this.bodyCapacityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bodyCapacityDataGridViewTextBoxColumn.DataPropertyName = "BodyCapacity";
            this.bodyCapacityDataGridViewTextBoxColumn.HeaderText = "Вместимость кузова, (куб. м)";
            this.bodyCapacityDataGridViewTextBoxColumn.Name = "bodyCapacityDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(Task.Models.Car);
            // 
            // requestIdDataGridViewTextBoxColumn
            // 
            this.requestIdDataGridViewTextBoxColumn.DataPropertyName = "RequestId";
            this.requestIdDataGridViewTextBoxColumn.HeaderText = "RequestId";
            this.requestIdDataGridViewTextBoxColumn.Name = "requestIdDataGridViewTextBoxColumn";
            this.requestIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateRequestDataGridViewTextBoxColumn
            // 
            this.dateRequestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateRequestDataGridViewTextBoxColumn.DataPropertyName = "DateRequest";
            this.dateRequestDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateRequestDataGridViewTextBoxColumn.Name = "dateRequestDataGridViewTextBoxColumn";
            // 
            // timeRequestDataGridViewTextBoxColumn
            // 
            this.timeRequestDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeRequestDataGridViewTextBoxColumn.DataPropertyName = "TimeRequest";
            this.timeRequestDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeRequestDataGridViewTextBoxColumn.Name = "timeRequestDataGridViewTextBoxColumn";
            this.timeRequestDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // waybillNumberDataGridViewTextBoxColumn
            // 
            this.waybillNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.waybillNumberDataGridViewTextBoxColumn.DataPropertyName = "WaybillNumber";
            this.waybillNumberDataGridViewTextBoxColumn.HeaderText = " Номер путевого листа";
            this.waybillNumberDataGridViewTextBoxColumn.Name = "waybillNumberDataGridViewTextBoxColumn";
            this.waybillNumberDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // carIdDataGridViewTextBoxColumn
            // 
            this.carIdDataGridViewTextBoxColumn.DataPropertyName = "CarId";
            this.carIdDataGridViewTextBoxColumn.HeaderText = "CarId";
            this.carIdDataGridViewTextBoxColumn.Name = "carIdDataGridViewTextBoxColumn";
            this.carIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.carIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // carDataGridViewTextBoxColumn
            // 
            this.carDataGridViewTextBoxColumn.DataPropertyName = "Car";
            this.carDataGridViewTextBoxColumn.HeaderText = "Car";
            this.carDataGridViewTextBoxColumn.Name = "carDataGridViewTextBoxColumn";
            this.carDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.carDataGridViewTextBoxColumn.Visible = false;
            // 
            // carBindingSource1
            // 
            this.carBindingSource1.DataSource = typeof(Task.Models.Car);
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataSource = typeof(Task.Models.Heeelp);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 388);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Учет принимаемой снежной массы";
            this.tabControl1.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.reportTabPage.PerformLayout();
            this.organizationTabPage.ResumeLayout(false);
            this.organizationTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.requestTabPage.ResumeLayout(false);
            this.requestTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage reportTabPage;
        private System.Windows.Forms.TabPage organizationTabPage;
        private System.Windows.Forms.TabPage requestTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox organizationComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addRequestButton;
        private System.Windows.Forms.Label contractLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carBindingSource;
        private System.Windows.Forms.Button addCarButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource requestBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateRegistrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodyCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarId;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.TextBox vatTextBox;
        private System.Windows.Forms.TextBox tariffTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox month1ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button toExcelButton;
        private System.Windows.Forms.BindingSource carBindingSource1;
        private System.Windows.Forms.Button registryToExcelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waybillNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarBrand;
        private System.Windows.Forms.DataGridViewComboBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn SnowVolume;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}