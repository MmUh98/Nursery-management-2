namespace Nursery_management
{
    partial class Area_and_FNFs
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
            System.Windows.Forms.Label districtLabel;
            System.Windows.Forms.Label name_of_Fruit_Nursery_FarmLabel;
            System.Windows.Forms.Label total_Area__Acre_Label;
            System.Windows.Forms.Label cultivated_Area__Acre_Label;
            System.Windows.Forms.Label waste_Uncultivated_Area__Area_Label;
            System.Windows.Forms.Label area_under_Roads_Building_etc__Acre_Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Area_and_FNFs));
            System.Windows.Forms.Label idLabel;
            this.databaseDataSet = new Nursery_management.DatabaseDataSet();
            this.distractAreaTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.distractAreaTblTableAdapter = new Nursery_management.DatabaseDataSetTableAdapters.DistractAreaTblTableAdapter();
            this.tableAdapterManager = new Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.distractAreaTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.distractAreaTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.name_of_Fruit_Nursery_FarmTextBox = new System.Windows.Forms.TextBox();
            this.total_Area__Acre_TextBox = new System.Windows.Forms.TextBox();
            this.cultivated_Area__Acre_TextBox = new System.Windows.Forms.TextBox();
            this.waste_Uncultivated_Area__Area_TextBox = new System.Windows.Forms.TextBox();
            this.area_under_Roads_Building_etc__Acre_TextBox = new System.Windows.Forms.TextBox();
            this.distractAreaTblDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Update_button = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            districtLabel = new System.Windows.Forms.Label();
            name_of_Fruit_Nursery_FarmLabel = new System.Windows.Forms.Label();
            total_Area__Acre_Label = new System.Windows.Forms.Label();
            cultivated_Area__Acre_Label = new System.Windows.Forms.Label();
            waste_Uncultivated_Area__Area_Label = new System.Windows.Forms.Label();
            area_under_Roads_Building_etc__Acre_Label = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblBindingNavigator)).BeginInit();
            this.distractAreaTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            districtLabel.Location = new System.Drawing.Point(128, 135);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new System.Drawing.Size(62, 20);
            districtLabel.TabIndex = 3;
            districtLabel.Text = "District:";
            // 
            // name_of_Fruit_Nursery_FarmLabel
            // 
            name_of_Fruit_Nursery_FarmLabel.AutoSize = true;
            name_of_Fruit_Nursery_FarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_Fruit_Nursery_FarmLabel.Location = new System.Drawing.Point(128, 181);
            name_of_Fruit_Nursery_FarmLabel.Name = "name_of_Fruit_Nursery_FarmLabel";
            name_of_Fruit_Nursery_FarmLabel.Size = new System.Drawing.Size(208, 20);
            name_of_Fruit_Nursery_FarmLabel.TabIndex = 5;
            name_of_Fruit_Nursery_FarmLabel.Text = "Name of Fruit Nursery Farm:";
            // 
            // total_Area__Acre_Label
            // 
            total_Area__Acre_Label.AutoSize = true;
            total_Area__Acre_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_Area__Acre_Label.Location = new System.Drawing.Point(128, 239);
            total_Area__Acre_Label.Name = "total_Area__Acre_Label";
            total_Area__Acre_Label.Size = new System.Drawing.Size(133, 20);
            total_Area__Acre_Label.TabIndex = 7;
            total_Area__Acre_Label.Text = "Total Area (Acre):";
            // 
            // cultivated_Area__Acre_Label
            // 
            cultivated_Area__Acre_Label.AutoSize = true;
            cultivated_Area__Acre_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cultivated_Area__Acre_Label.Location = new System.Drawing.Point(128, 292);
            cultivated_Area__Acre_Label.Name = "cultivated_Area__Acre_Label";
            cultivated_Area__Acre_Label.Size = new System.Drawing.Size(168, 20);
            cultivated_Area__Acre_Label.TabIndex = 9;
            cultivated_Area__Acre_Label.Text = "Cultivated Area (Acre):";
            // 
            // waste_Uncultivated_Area__Area_Label
            // 
            waste_Uncultivated_Area__Area_Label.AutoSize = true;
            waste_Uncultivated_Area__Area_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            waste_Uncultivated_Area__Area_Label.Location = new System.Drawing.Point(128, 344);
            waste_Uncultivated_Area__Area_Label.Name = "waste_Uncultivated_Area__Area_Label";
            waste_Uncultivated_Area__Area_Label.Size = new System.Drawing.Size(237, 20);
            waste_Uncultivated_Area__Area_Label.TabIndex = 11;
            waste_Uncultivated_Area__Area_Label.Text = "Waste/Uncultivated Area (Area):";
            // 
            // area_under_Roads_Building_etc__Acre_Label
            // 
            area_under_Roads_Building_etc__Acre_Label.AutoSize = true;
            area_under_Roads_Building_etc__Acre_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            area_under_Roads_Building_etc__Acre_Label.Location = new System.Drawing.Point(128, 401);
            area_under_Roads_Building_etc__Acre_Label.Name = "area_under_Roads_Building_etc__Acre_Label";
            area_under_Roads_Building_etc__Acre_Label.Size = new System.Drawing.Size(276, 20);
            area_under_Roads_Building_etc__Acre_Label.TabIndex = 13;
            area_under_Roads_Building_etc__Acre_Label.Text = "Area under Roads/Building etc (Acre):";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // distractAreaTblBindingSource
            // 
            this.distractAreaTblBindingSource.DataMember = "DistractAreaTbl";
            this.distractAreaTblBindingSource.DataSource = this.databaseDataSet;
            this.distractAreaTblBindingSource.CurrentChanged += new System.EventHandler(this.distractAreaTblBindingSource_CurrentChanged);
            // 
            // distractAreaTblTableAdapter
            // 
            this.distractAreaTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistractAreaTblTableAdapter = this.distractAreaTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // distractAreaTblBindingNavigator
            // 
            this.distractAreaTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.distractAreaTblBindingNavigator.BindingSource = this.distractAreaTblBindingSource;
            this.distractAreaTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.distractAreaTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.distractAreaTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.distractAreaTblBindingNavigatorSaveItem});
            this.distractAreaTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.distractAreaTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.distractAreaTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.distractAreaTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.distractAreaTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.distractAreaTblBindingNavigator.Name = "distractAreaTblBindingNavigator";
            this.distractAreaTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.distractAreaTblBindingNavigator.Size = new System.Drawing.Size(974, 25);
            this.distractAreaTblBindingNavigator.TabIndex = 0;
            this.distractAreaTblBindingNavigator.Text = "bindingNavigator1";
            this.distractAreaTblBindingNavigator.RefreshItems += new System.EventHandler(this.distractAreaTblBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // distractAreaTblBindingNavigatorSaveItem
            // 
            this.distractAreaTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.distractAreaTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("distractAreaTblBindingNavigatorSaveItem.Image")));
            this.distractAreaTblBindingNavigatorSaveItem.Name = "distractAreaTblBindingNavigatorSaveItem";
            this.distractAreaTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.distractAreaTblBindingNavigatorSaveItem.Text = "Save Data";
            this.distractAreaTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.distractAreaTblBindingNavigatorSaveItem_Click_3);
            // 
            // districtTextBox
            // 
            this.districtTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "District", true));
            this.districtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtTextBox.Location = new System.Drawing.Point(429, 132);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(336, 19);
            this.districtTextBox.TabIndex = 4;
            this.districtTextBox.TextChanged += new System.EventHandler(this.districtTextBox_TextChanged);
            // 
            // name_of_Fruit_Nursery_FarmTextBox
            // 
            this.name_of_Fruit_Nursery_FarmTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_of_Fruit_Nursery_FarmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Name_of_Fruit_Nursery_Farm", true));
            this.name_of_Fruit_Nursery_FarmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_Fruit_Nursery_FarmTextBox.Location = new System.Drawing.Point(429, 178);
            this.name_of_Fruit_Nursery_FarmTextBox.Name = "name_of_Fruit_Nursery_FarmTextBox";
            this.name_of_Fruit_Nursery_FarmTextBox.Size = new System.Drawing.Size(336, 19);
            this.name_of_Fruit_Nursery_FarmTextBox.TabIndex = 6;
            // 
            // total_Area__Acre_TextBox
            // 
            this.total_Area__Acre_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_Area__Acre_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Total_Area_(Acre)", true));
            this.total_Area__Acre_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Area__Acre_TextBox.Location = new System.Drawing.Point(429, 236);
            this.total_Area__Acre_TextBox.Name = "total_Area__Acre_TextBox";
            this.total_Area__Acre_TextBox.Size = new System.Drawing.Size(336, 19);
            this.total_Area__Acre_TextBox.TabIndex = 8;
            // 
            // cultivated_Area__Acre_TextBox
            // 
            this.cultivated_Area__Acre_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cultivated_Area__Acre_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Cultivated_Area_(Acre)", true));
            this.cultivated_Area__Acre_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cultivated_Area__Acre_TextBox.Location = new System.Drawing.Point(429, 289);
            this.cultivated_Area__Acre_TextBox.Name = "cultivated_Area__Acre_TextBox";
            this.cultivated_Area__Acre_TextBox.Size = new System.Drawing.Size(336, 19);
            this.cultivated_Area__Acre_TextBox.TabIndex = 10;
            // 
            // waste_Uncultivated_Area__Area_TextBox
            // 
            this.waste_Uncultivated_Area__Area_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waste_Uncultivated_Area__Area_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Waste/Uncultivated_Area_(Area)", true));
            this.waste_Uncultivated_Area__Area_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waste_Uncultivated_Area__Area_TextBox.Location = new System.Drawing.Point(429, 341);
            this.waste_Uncultivated_Area__Area_TextBox.Name = "waste_Uncultivated_Area__Area_TextBox";
            this.waste_Uncultivated_Area__Area_TextBox.Size = new System.Drawing.Size(336, 19);
            this.waste_Uncultivated_Area__Area_TextBox.TabIndex = 12;
            // 
            // area_under_Roads_Building_etc__Acre_TextBox
            // 
            this.area_under_Roads_Building_etc__Acre_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.area_under_Roads_Building_etc__Acre_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Area_under_Roads/Building_etc_(Acre)", true));
            this.area_under_Roads_Building_etc__Acre_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.area_under_Roads_Building_etc__Acre_TextBox.Location = new System.Drawing.Point(429, 398);
            this.area_under_Roads_Building_etc__Acre_TextBox.Name = "area_under_Roads_Building_etc__Acre_TextBox";
            this.area_under_Roads_Building_etc__Acre_TextBox.Size = new System.Drawing.Size(336, 19);
            this.area_under_Roads_Building_etc__Acre_TextBox.TabIndex = 14;
            // 
            // distractAreaTblDataGridView
            // 
            this.distractAreaTblDataGridView.AutoGenerateColumns = false;
            this.distractAreaTblDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.distractAreaTblDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.distractAreaTblDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.distractAreaTblDataGridView.DataSource = this.distractAreaTblBindingSource;
            this.distractAreaTblDataGridView.Location = new System.Drawing.Point(33, 475);
            this.distractAreaTblDataGridView.Name = "distractAreaTblDataGridView";
            this.distractAreaTblDataGridView.Size = new System.Drawing.Size(869, 176);
            this.distractAreaTblDataGridView.TabIndex = 15;
            this.distractAreaTblDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.distractAreaTblDataGridView_CellContentClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "District";
            this.dataGridViewTextBoxColumn2.HeaderText = "District";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Name_of_Fruit_Nursery_Farm";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name_of_Fruit_Nursery_Farm";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Total_Area_(Acre)";
            this.dataGridViewTextBoxColumn4.HeaderText = "Total_Area_(Acre)";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Cultivated_Area_(Acre)";
            this.dataGridViewTextBoxColumn5.HeaderText = "Cultivated_Area_(Acre)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Waste/Uncultivated_Area_(Area)";
            this.dataGridViewTextBoxColumn6.HeaderText = "Waste/Uncultivated_Area_(Area)";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Area_under_Roads/Building_etc_(Acre)";
            this.dataGridViewTextBoxColumn7.HeaderText = "Area_under_Roads/Building_etc_(Acre)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(775, 427);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(127, 42);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(128, 93);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 16;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.distractAreaTblBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(429, 86);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(335, 26);
            this.idTextBox.TabIndex = 17;
            // 
            // Area_and_FNFs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(974, 663);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(this.distractAreaTblDataGridView);
            this.Controls.Add(districtLabel);
            this.Controls.Add(this.districtTextBox);
            this.Controls.Add(name_of_Fruit_Nursery_FarmLabel);
            this.Controls.Add(this.name_of_Fruit_Nursery_FarmTextBox);
            this.Controls.Add(total_Area__Acre_Label);
            this.Controls.Add(this.total_Area__Acre_TextBox);
            this.Controls.Add(cultivated_Area__Acre_Label);
            this.Controls.Add(this.cultivated_Area__Acre_TextBox);
            this.Controls.Add(waste_Uncultivated_Area__Area_Label);
            this.Controls.Add(this.waste_Uncultivated_Area__Area_TextBox);
            this.Controls.Add(area_under_Roads_Building_etc__Acre_Label);
            this.Controls.Add(this.area_under_Roads_Building_etc__Acre_TextBox);
            this.Controls.Add(this.distractAreaTblBindingNavigator);
            this.Name = "Area_and_FNFs";
            this.Text = "Area and FNFs";
            this.Load += new System.EventHandler(this.Area_and_FNFs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblBindingNavigator)).EndInit();
            this.distractAreaTblBindingNavigator.ResumeLayout(false);
            this.distractAreaTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.distractAreaTblDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource distractAreaTblBindingSource;
        private DatabaseDataSetTableAdapters.DistractAreaTblTableAdapter distractAreaTblTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator distractAreaTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton distractAreaTblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.TextBox name_of_Fruit_Nursery_FarmTextBox;
        private System.Windows.Forms.TextBox total_Area__Acre_TextBox;
        private System.Windows.Forms.TextBox cultivated_Area__Acre_TextBox;
        private System.Windows.Forms.TextBox waste_Uncultivated_Area__Area_TextBox;
        private System.Windows.Forms.TextBox area_under_Roads_Building_etc__Acre_TextBox;
        private System.Windows.Forms.DataGridView distractAreaTblDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.TextBox idTextBox;
    }
}