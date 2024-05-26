namespace Nursery_management
{
    partial class FNFBajaur
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label districtLabel;
            System.Windows.Forms.Label name_of_Fruit_Nursery_FarmLabel;
            System.Windows.Forms.Label name_of_FruitLabel;
            System.Windows.Forms.Label no_of_Fruit_Plants_RaisedLabel;
            System.Windows.Forms.Label total_No_of_Plants_available_for_seasonLabel;
            System.Windows.Forms.Label under_Size_PlantsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNFBajaur));
            this.databaseDataSet = new Nursery_management.DatabaseDataSet();
            this.fNFBajaurTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fNFBajaurTblTableAdapter = new Nursery_management.DatabaseDataSetTableAdapters.FNFBajaurTblTableAdapter();
            this.tableAdapterManager = new Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.fNFBajaurTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fNFBajaurTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.name_of_Fruit_Nursery_FarmTextBox = new System.Windows.Forms.TextBox();
            this.name_of_FruitTextBox = new System.Windows.Forms.TextBox();
            this.no_of_Fruit_Plants_RaisedTextBox = new System.Windows.Forms.TextBox();
            this.total_No_of_Plants_available_for_seasonTextBox = new System.Windows.Forms.TextBox();
            this.under_Size_PlantsTextBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Search_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            idLabel = new System.Windows.Forms.Label();
            districtLabel = new System.Windows.Forms.Label();
            name_of_Fruit_Nursery_FarmLabel = new System.Windows.Forms.Label();
            name_of_FruitLabel = new System.Windows.Forms.Label();
            no_of_Fruit_Plants_RaisedLabel = new System.Windows.Forms.Label();
            total_No_of_Plants_available_for_seasonLabel = new System.Windows.Forms.Label();
            under_Size_PlantsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFBajaurTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFBajaurTblBindingNavigator)).BeginInit();
            this.fNFBajaurTblBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(85, 88);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            districtLabel.Location = new System.Drawing.Point(85, 135);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new System.Drawing.Size(62, 20);
            districtLabel.TabIndex = 3;
            districtLabel.Text = "District:";
            // 
            // name_of_Fruit_Nursery_FarmLabel
            // 
            name_of_Fruit_Nursery_FarmLabel.AutoSize = true;
            name_of_Fruit_Nursery_FarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_Fruit_Nursery_FarmLabel.Location = new System.Drawing.Point(85, 181);
            name_of_Fruit_Nursery_FarmLabel.Name = "name_of_Fruit_Nursery_FarmLabel";
            name_of_Fruit_Nursery_FarmLabel.Size = new System.Drawing.Size(208, 20);
            name_of_Fruit_Nursery_FarmLabel.TabIndex = 5;
            name_of_Fruit_Nursery_FarmLabel.Text = "Name of Fruit Nursery Farm:";
            // 
            // name_of_FruitLabel
            // 
            name_of_FruitLabel.AutoSize = true;
            name_of_FruitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_FruitLabel.Location = new System.Drawing.Point(85, 223);
            name_of_FruitLabel.Name = "name_of_FruitLabel";
            name_of_FruitLabel.Size = new System.Drawing.Size(109, 20);
            name_of_FruitLabel.TabIndex = 7;
            name_of_FruitLabel.Text = "Name of Fruit:";
            // 
            // no_of_Fruit_Plants_RaisedLabel
            // 
            no_of_Fruit_Plants_RaisedLabel.AutoSize = true;
            no_of_Fruit_Plants_RaisedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_of_Fruit_Plants_RaisedLabel.Location = new System.Drawing.Point(85, 263);
            no_of_Fruit_Plants_RaisedLabel.Name = "no_of_Fruit_Plants_RaisedLabel";
            no_of_Fruit_Plants_RaisedLabel.Size = new System.Drawing.Size(189, 20);
            no_of_Fruit_Plants_RaisedLabel.TabIndex = 9;
            no_of_Fruit_Plants_RaisedLabel.Text = "No of Fruit Plants Raised:";
            // 
            // total_No_of_Plants_available_for_seasonLabel
            // 
            total_No_of_Plants_available_for_seasonLabel.AutoSize = true;
            total_No_of_Plants_available_for_seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_No_of_Plants_available_for_seasonLabel.Location = new System.Drawing.Point(85, 304);
            total_No_of_Plants_available_for_seasonLabel.Name = "total_No_of_Plants_available_for_seasonLabel";
            total_No_of_Plants_available_for_seasonLabel.Size = new System.Drawing.Size(282, 20);
            total_No_of_Plants_available_for_seasonLabel.TabIndex = 11;
            total_No_of_Plants_available_for_seasonLabel.Text = "Total No of Plants available for season:";
            // 
            // under_Size_PlantsLabel
            // 
            under_Size_PlantsLabel.AutoSize = true;
            under_Size_PlantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            under_Size_PlantsLabel.Location = new System.Drawing.Point(85, 355);
            under_Size_PlantsLabel.Name = "under_Size_PlantsLabel";
            under_Size_PlantsLabel.Size = new System.Drawing.Size(140, 20);
            under_Size_PlantsLabel.TabIndex = 13;
            under_Size_PlantsLabel.Text = "Under Size Plants:";
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNFBajaurTblBindingSource
            // 
            this.fNFBajaurTblBindingSource.DataMember = "FNFBajaurTbl";
            this.fNFBajaurTblBindingSource.DataSource = this.databaseDataSet;
            // 
            // fNFBajaurTblTableAdapter
            // 
            this.fNFBajaurTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistractAreaTblTableAdapter = null;
            this.tableAdapterManager.FNFAbbottabadTblTableAdapter = null;
            this.tableAdapterManager.FNFBajaurTblTableAdapter = this.fNFBajaurTblTableAdapter;
            this.tableAdapterManager.FNFChitralLowerTblTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fNFBajaurTblBindingNavigator
            // 
            this.fNFBajaurTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fNFBajaurTblBindingNavigator.BindingSource = this.fNFBajaurTblBindingSource;
            this.fNFBajaurTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fNFBajaurTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fNFBajaurTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fNFBajaurTblBindingNavigatorSaveItem});
            this.fNFBajaurTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fNFBajaurTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fNFBajaurTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fNFBajaurTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fNFBajaurTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fNFBajaurTblBindingNavigator.Name = "fNFBajaurTblBindingNavigator";
            this.fNFBajaurTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fNFBajaurTblBindingNavigator.Size = new System.Drawing.Size(919, 25);
            this.fNFBajaurTblBindingNavigator.TabIndex = 0;
            this.fNFBajaurTblBindingNavigator.Text = "bindingNavigator1";
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
            // fNFBajaurTblBindingNavigatorSaveItem
            // 
            this.fNFBajaurTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fNFBajaurTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fNFBajaurTblBindingNavigatorSaveItem.Image")));
            this.fNFBajaurTblBindingNavigatorSaveItem.Name = "fNFBajaurTblBindingNavigatorSaveItem";
            this.fNFBajaurTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fNFBajaurTblBindingNavigatorSaveItem.Text = "Save Data";
            this.fNFBajaurTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.fNFBajaurTblBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(381, 88);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(328, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // districtTextBox
            // 
            this.districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "District", true));
            this.districtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtTextBox.Location = new System.Drawing.Point(381, 129);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(328, 26);
            this.districtTextBox.TabIndex = 4;
            // 
            // name_of_Fruit_Nursery_FarmTextBox
            // 
            this.name_of_Fruit_Nursery_FarmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "Name_of_Fruit_Nursery_Farm", true));
            this.name_of_Fruit_Nursery_FarmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_Fruit_Nursery_FarmTextBox.Location = new System.Drawing.Point(381, 175);
            this.name_of_Fruit_Nursery_FarmTextBox.Name = "name_of_Fruit_Nursery_FarmTextBox";
            this.name_of_Fruit_Nursery_FarmTextBox.Size = new System.Drawing.Size(328, 26);
            this.name_of_Fruit_Nursery_FarmTextBox.TabIndex = 6;
            // 
            // name_of_FruitTextBox
            // 
            this.name_of_FruitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "Name_of_Fruit", true));
            this.name_of_FruitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_FruitTextBox.Location = new System.Drawing.Point(381, 217);
            this.name_of_FruitTextBox.Name = "name_of_FruitTextBox";
            this.name_of_FruitTextBox.Size = new System.Drawing.Size(328, 26);
            this.name_of_FruitTextBox.TabIndex = 8;
            // 
            // no_of_Fruit_Plants_RaisedTextBox
            // 
            this.no_of_Fruit_Plants_RaisedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "No_of_Fruit_Plants_Raised", true));
            this.no_of_Fruit_Plants_RaisedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_Fruit_Plants_RaisedTextBox.Location = new System.Drawing.Point(381, 257);
            this.no_of_Fruit_Plants_RaisedTextBox.Name = "no_of_Fruit_Plants_RaisedTextBox";
            this.no_of_Fruit_Plants_RaisedTextBox.Size = new System.Drawing.Size(328, 26);
            this.no_of_Fruit_Plants_RaisedTextBox.TabIndex = 10;
            // 
            // total_No_of_Plants_available_for_seasonTextBox
            // 
            this.total_No_of_Plants_available_for_seasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "Total_No_of_Plants_available_for_season", true));
            this.total_No_of_Plants_available_for_seasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_No_of_Plants_available_for_seasonTextBox.Location = new System.Drawing.Point(381, 298);
            this.total_No_of_Plants_available_for_seasonTextBox.Name = "total_No_of_Plants_available_for_seasonTextBox";
            this.total_No_of_Plants_available_for_seasonTextBox.Size = new System.Drawing.Size(328, 26);
            this.total_No_of_Plants_available_for_seasonTextBox.TabIndex = 12;
            // 
            // under_Size_PlantsTextBox
            // 
            this.under_Size_PlantsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFBajaurTblBindingSource, "Under_Size_Plants", true));
            this.under_Size_PlantsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.under_Size_PlantsTextBox.Location = new System.Drawing.Point(381, 349);
            this.under_Size_PlantsTextBox.Name = "under_Size_PlantsTextBox";
            this.under_Size_PlantsTextBox.Size = new System.Drawing.Size(328, 26);
            this.under_Size_PlantsTextBox.TabIndex = 14;
            // 
            // Update_button
            // 
            this.Update_button.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(513, 404);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 34);
            this.Update_button.TabIndex = 16;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = false;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_button.Location = new System.Drawing.Point(89, 404);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 34);
            this.Back_button.TabIndex = 17;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.Red;
            this.Delete_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_button.Location = new System.Drawing.Point(634, 404);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 34);
            this.Delete_button.TabIndex = 22;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = false;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Search_button
            // 
            this.Search_button.BackColor = System.Drawing.Color.DodgerBlue;
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(344, 404);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(112, 34);
            this.Search_button.TabIndex = 23;
            this.Search_button.Text = "Show Details";
            this.Search_button.UseVisualStyleBackColor = false;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 457);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(888, 278);
            this.dataGridView1.TabIndex = 24;
            // 
            // FNFBajaur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(919, 691);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Update_button);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(districtLabel);
            this.Controls.Add(this.districtTextBox);
            this.Controls.Add(name_of_Fruit_Nursery_FarmLabel);
            this.Controls.Add(this.name_of_Fruit_Nursery_FarmTextBox);
            this.Controls.Add(name_of_FruitLabel);
            this.Controls.Add(this.name_of_FruitTextBox);
            this.Controls.Add(no_of_Fruit_Plants_RaisedLabel);
            this.Controls.Add(this.no_of_Fruit_Plants_RaisedTextBox);
            this.Controls.Add(total_No_of_Plants_available_for_seasonLabel);
            this.Controls.Add(this.total_No_of_Plants_available_for_seasonTextBox);
            this.Controls.Add(under_Size_PlantsLabel);
            this.Controls.Add(this.under_Size_PlantsTextBox);
            this.Controls.Add(this.fNFBajaurTblBindingNavigator);
            this.Name = "FNFBajaur";
            this.Text = "FNFBajaur";
            this.Load += new System.EventHandler(this.FNFBajaur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFBajaurTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFBajaurTblBindingNavigator)).EndInit();
            this.fNFBajaurTblBindingNavigator.ResumeLayout(false);
            this.fNFBajaurTblBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource fNFBajaurTblBindingSource;
        private DatabaseDataSetTableAdapters.FNFBajaurTblTableAdapter fNFBajaurTblTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fNFBajaurTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fNFBajaurTblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.TextBox name_of_Fruit_Nursery_FarmTextBox;
        private System.Windows.Forms.TextBox name_of_FruitTextBox;
        private System.Windows.Forms.TextBox no_of_Fruit_Plants_RaisedTextBox;
        private System.Windows.Forms.TextBox total_No_of_Plants_available_for_seasonTextBox;
        private System.Windows.Forms.TextBox under_Size_PlantsTextBox;
        private System.Windows.Forms.Button Update_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}