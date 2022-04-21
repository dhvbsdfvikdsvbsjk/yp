namespace _0402
{
    partial class Form4
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
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label датаРожденияLabel;
            System.Windows.Forms.Label паспортныеДанныеLabel;
            System.Windows.Forms.Label подразделениеLabel;
            System.Windows.Forms.Label должностьLabel;
            System.Windows.Forms.Label фотоLabel;
            System.Windows.Forms.Label логинLabel;
            System.Windows.Forms.Label парольLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.z1DataSet = new _0402.z1DataSet();
            this.tabBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabTableAdapter = new _0402.z1DataSetTableAdapters.tabTableAdapter();
            this.tableAdapterManager = new _0402.z1DataSetTableAdapters.TableAdapterManager();
            this.tabBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tabBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tabDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.датаРожденияTextBox = new System.Windows.Forms.TextBox();
            this.паспортныеДанныеTextBox = new System.Windows.Forms.TextBox();
            this.подразделениеTextBox = new System.Windows.Forms.TextBox();
            this.должностьTextBox = new System.Windows.Forms.TextBox();
            this.фотоTextBox = new System.Windows.Forms.TextBox();
            this.логинTextBox = new System.Windows.Forms.TextBox();
            this.парольTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            датаРожденияLabel = new System.Windows.Forms.Label();
            паспортныеДанныеLabel = new System.Windows.Forms.Label();
            подразделениеLabel = new System.Windows.Forms.Label();
            должностьLabel = new System.Windows.Forms.Label();
            фотоLabel = new System.Windows.Forms.Label();
            логинLabel = new System.Windows.Forms.Label();
            парольLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBindingNavigator)).BeginInit();
            this.tabBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(31, 302);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(59, 13);
            фамилияLabel.TabIndex = 2;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(31, 328);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(32, 13);
            имяLabel.TabIndex = 4;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(31, 354);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(57, 13);
            отчествоLabel.TabIndex = 6;
            отчествоLabel.Text = "Отчество:";
            // 
            // датаРожденияLabel
            // 
            датаРожденияLabel.AutoSize = true;
            датаРожденияLabel.Location = new System.Drawing.Point(31, 380);
            датаРожденияLabel.Name = "датаРожденияLabel";
            датаРожденияLabel.Size = new System.Drawing.Size(90, 13);
            датаРожденияLabel.TabIndex = 8;
            датаРожденияLabel.Text = "Дата Рождения:";
            // 
            // паспортныеДанныеLabel
            // 
            паспортныеДанныеLabel.AutoSize = true;
            паспортныеДанныеLabel.Location = new System.Drawing.Point(31, 406);
            паспортныеДанныеLabel.Name = "паспортныеДанныеLabel";
            паспортныеДанныеLabel.Size = new System.Drawing.Size(117, 13);
            паспортныеДанныеLabel.TabIndex = 10;
            паспортныеДанныеLabel.Text = "Паспортные Данные:";
            // 
            // подразделениеLabel
            // 
            подразделениеLabel.AutoSize = true;
            подразделениеLabel.Location = new System.Drawing.Point(31, 432);
            подразделениеLabel.Name = "подразделениеLabel";
            подразделениеLabel.Size = new System.Drawing.Size(90, 13);
            подразделениеLabel.TabIndex = 12;
            подразделениеLabel.Text = "Подразделение:";
            // 
            // должностьLabel
            // 
            должностьLabel.AutoSize = true;
            должностьLabel.Location = new System.Drawing.Point(31, 458);
            должностьLabel.Name = "должностьLabel";
            должностьLabel.Size = new System.Drawing.Size(68, 13);
            должностьLabel.TabIndex = 14;
            должностьLabel.Text = "Должность:";
            // 
            // фотоLabel
            // 
            фотоLabel.AutoSize = true;
            фотоLabel.Location = new System.Drawing.Point(31, 484);
            фотоLabel.Name = "фотоLabel";
            фотоLabel.Size = new System.Drawing.Size(38, 13);
            фотоLabel.TabIndex = 16;
            фотоLabel.Text = "Фото:";
            // 
            // логинLabel
            // 
            логинLabel.AutoSize = true;
            логинLabel.Location = new System.Drawing.Point(31, 510);
            логинLabel.Name = "логинLabel";
            логинLabel.Size = new System.Drawing.Size(41, 13);
            логинLabel.TabIndex = 18;
            логинLabel.Text = "Логин:";
            // 
            // парольLabel
            // 
            парольLabel.AutoSize = true;
            парольLabel.Location = new System.Drawing.Point(31, 536);
            парольLabel.Name = "парольLabel";
            парольLabel.Size = new System.Drawing.Size(48, 13);
            парольLabel.TabIndex = 20;
            парольLabel.Text = "Пароль:";
            // 
            // z1DataSet
            // 
            this.z1DataSet.DataSetName = "z1DataSet";
            this.z1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabBindingSource
            // 
            this.tabBindingSource.DataMember = "tab";
            this.tabBindingSource.DataSource = this.z1DataSet;
            // 
            // tabTableAdapter
            // 
            this.tabTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabTableAdapter = this.tabTableAdapter;
            this.tableAdapterManager.UpdateOrder = _0402.z1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tabBindingNavigator
            // 
            this.tabBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabBindingNavigator.BindingSource = this.tabBindingSource;
            this.tabBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabBindingNavigatorSaveItem});
            this.tabBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tabBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabBindingNavigator.Name = "tabBindingNavigator";
            this.tabBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabBindingNavigator.Size = new System.Drawing.Size(1093, 25);
            this.tabBindingNavigator.TabIndex = 0;
            this.tabBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tabBindingNavigatorSaveItem
            // 
            this.tabBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabBindingNavigatorSaveItem.Image")));
            this.tabBindingNavigatorSaveItem.Name = "tabBindingNavigatorSaveItem";
            this.tabBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tabBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.tabBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabBindingNavigatorSaveItem_Click);
            // 
            // tabDataGridView
            // 
            this.tabDataGridView.AutoGenerateColumns = false;
            this.tabDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tabDataGridView.DataSource = this.tabBindingSource;
            this.tabDataGridView.Location = new System.Drawing.Point(34, 28);
            this.tabDataGridView.Name = "tabDataGridView";
            this.tabDataGridView.Size = new System.Drawing.Size(1011, 220);
            this.tabDataGridView.TabIndex = 1;
            this.tabDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Отчество";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ДатаРождения";
            this.dataGridViewTextBoxColumn4.HeaderText = "ДатаРождения";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ПаспортныеДанные";
            this.dataGridViewTextBoxColumn5.HeaderText = "ПаспортныеДанные";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Подразделение";
            this.dataGridViewTextBoxColumn6.HeaderText = "Подразделение";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Должность";
            this.dataGridViewTextBoxColumn7.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Фото";
            this.dataGridViewTextBoxColumn8.HeaderText = "Фото";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Логин";
            this.dataGridViewTextBoxColumn9.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Пароль";
            this.dataGridViewTextBoxColumn10.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(154, 299);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(100, 20);
            this.фамилияTextBox.TabIndex = 3;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(154, 325);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(100, 20);
            this.имяTextBox.TabIndex = 5;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(154, 351);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(100, 20);
            this.отчествоTextBox.TabIndex = 7;
            // 
            // датаРожденияTextBox
            // 
            this.датаРожденияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "ДатаРождения", true));
            this.датаРожденияTextBox.Location = new System.Drawing.Point(154, 377);
            this.датаРожденияTextBox.Name = "датаРожденияTextBox";
            this.датаРожденияTextBox.Size = new System.Drawing.Size(100, 20);
            this.датаРожденияTextBox.TabIndex = 9;
            // 
            // паспортныеДанныеTextBox
            // 
            this.паспортныеДанныеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "ПаспортныеДанные", true));
            this.паспортныеДанныеTextBox.Location = new System.Drawing.Point(154, 403);
            this.паспортныеДанныеTextBox.Name = "паспортныеДанныеTextBox";
            this.паспортныеДанныеTextBox.Size = new System.Drawing.Size(100, 20);
            this.паспортныеДанныеTextBox.TabIndex = 11;
            // 
            // подразделениеTextBox
            // 
            this.подразделениеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Подразделение", true));
            this.подразделениеTextBox.Location = new System.Drawing.Point(154, 429);
            this.подразделениеTextBox.Name = "подразделениеTextBox";
            this.подразделениеTextBox.Size = new System.Drawing.Size(100, 20);
            this.подразделениеTextBox.TabIndex = 13;
            // 
            // должностьTextBox
            // 
            this.должностьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Должность", true));
            this.должностьTextBox.Location = new System.Drawing.Point(154, 455);
            this.должностьTextBox.Name = "должностьTextBox";
            this.должностьTextBox.Size = new System.Drawing.Size(100, 20);
            this.должностьTextBox.TabIndex = 15;
            // 
            // фотоTextBox
            // 
            this.фотоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Фото", true));
            this.фотоTextBox.Location = new System.Drawing.Point(154, 481);
            this.фотоTextBox.Name = "фотоTextBox";
            this.фотоTextBox.Size = new System.Drawing.Size(100, 20);
            this.фотоTextBox.TabIndex = 17;
            // 
            // логинTextBox
            // 
            this.логинTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Логин", true));
            this.логинTextBox.Location = new System.Drawing.Point(154, 507);
            this.логинTextBox.Name = "логинTextBox";
            this.логинTextBox.Size = new System.Drawing.Size(100, 20);
            this.логинTextBox.TabIndex = 19;
            // 
            // парольTextBox
            // 
            this.парольTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabBindingSource, "Пароль", true));
            this.парольTextBox.Location = new System.Drawing.Point(154, 533);
            this.парольTextBox.Name = "парольTextBox";
            this.парольTextBox.Size = new System.Drawing.Size(100, 20);
            this.парольTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(датаРожденияLabel);
            this.Controls.Add(this.датаРожденияTextBox);
            this.Controls.Add(паспортныеДанныеLabel);
            this.Controls.Add(this.паспортныеДанныеTextBox);
            this.Controls.Add(подразделениеLabel);
            this.Controls.Add(this.подразделениеTextBox);
            this.Controls.Add(должностьLabel);
            this.Controls.Add(this.должностьTextBox);
            this.Controls.Add(фотоLabel);
            this.Controls.Add(this.фотоTextBox);
            this.Controls.Add(логинLabel);
            this.Controls.Add(this.логинTextBox);
            this.Controls.Add(парольLabel);
            this.Controls.Add(this.парольTextBox);
            this.Controls.Add(this.tabDataGridView);
            this.Controls.Add(this.tabBindingNavigator);
            this.Name = "Form4";
            this.Text = "Администратор";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.z1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabBindingNavigator)).EndInit();
            this.tabBindingNavigator.ResumeLayout(false);
            this.tabBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private z1DataSet z1DataSet;
        private System.Windows.Forms.BindingSource tabBindingSource;
        private z1DataSetTableAdapters.tabTableAdapter tabTableAdapter;
        private z1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tabBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox датаРожденияTextBox;
        private System.Windows.Forms.TextBox паспортныеДанныеTextBox;
        private System.Windows.Forms.TextBox подразделениеTextBox;
        private System.Windows.Forms.TextBox должностьTextBox;
        private System.Windows.Forms.TextBox фотоTextBox;
        private System.Windows.Forms.TextBox логинTextBox;
        private System.Windows.Forms.TextBox парольTextBox;
        private System.Windows.Forms.Button button1;
    }
}