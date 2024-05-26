namespace Nursery_management
{
    partial class FNF_Abbottabad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FNF_Abbottabad));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label districtLabel;
            System.Windows.Forms.Label name_of_Fruit_Nursery_FarmLabel;
            System.Windows.Forms.Label name_of_FruitLabel;
            System.Windows.Forms.Label no_of_Fruit_Plants_RaisedLabel;
            System.Windows.Forms.Label total_No_of_Plants_available_for_seasonLabel;
            System.Windows.Forms.Label under_Size_PlantsLabel;
            this.databaseDataSet = new Nursery_management.DatabaseDataSet();
            this.fNFAbbottabadTblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fNFAbbottabadTblTableAdapter = new Nursery_management.DatabaseDataSetTableAdapters.FNFAbbottabadTblTableAdapter();
            this.tableAdapterManager = new Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.fNFAbbottabadTblBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.fNFAbbottabadTblBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.name_of_Fruit_Nursery_FarmTextBox = new System.Windows.Forms.TextBox();
            this.name_of_FruitTextBox = new System.Windows.Forms.TextBox();
            this.no_of_Fruit_Plants_RaisedTextBox = new System.Windows.Forms.TextBox();
            this.total_No_of_Plants_available_for_seasonTextBox = new System.Windows.Forms.TextBox();
            this.under_Size_PlantsTextBox = new System.Windows.Forms.TextBox();
            this.Update_button = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            districtLabel = new System.Windows.Forms.Label();
            name_of_Fruit_Nursery_FarmLabel = new System.Windows.Forms.Label();
            name_of_FruitLabel = new System.Windows.Forms.Label();
            no_of_Fruit_Plants_RaisedLabel = new System.Windows.Forms.Label();
            total_No_of_Plants_available_for_seasonLabel = new System.Windows.Forms.Label();
            under_Size_PlantsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFAbbottabadTblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFAbbottabadTblBindingNavigator)).BeginInit();
            this.fNFAbbottabadTblBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNFAbbottabadTblBindingSource
            // 
            this.fNFAbbottabadTblBindingSource.DataMember = "FNFAbbottabadTbl";
            this.fNFAbbottabadTblBindingSource.DataSource = this.databaseDataSet;
            // 
            // fNFAbbottabadTblTableAdapter
            // 
            this.fNFAbbottabadTblTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DistractAreaTblTableAdapter = null;
            this.tableAdapterManager.FNFAbbottabadTblTableAdapter = this.fNFAbbottabadTblTableAdapter;
            this.tableAdapterManager.UpdateOrder = Nursery_management.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fNFAbbottabadTblBindingNavigator
            // 
            this.fNFAbbottabadTblBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fNFAbbottabadTblBindingNavigator.BindingSource = this.fNFAbbottabadTblBindingSource;
            this.fNFAbbottabadTblBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fNFAbbottabadTblBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fNFAbbottabadTblBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fNFAbbottabadTblBindingNavigatorSaveItem});
            this.fNFAbbottabadTblBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.fNFAbbottabadTblBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fNFAbbottabadTblBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fNFAbbottabadTblBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fNFAbbottabadTblBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fNFAbbottabadTblBindingNavigator.Name = "fNFAbbottabadTblBindingNavigator";
            this.fNFAbbottabadTblBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fNFAbbottabadTblBindingNavigator.Size = new System.Drawing.Size(869, 25);
            this.fNFAbbottabadTblBindingNavigator.TabIndex = 0;
            this.fNFAbbottabadTblBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // fNFAbbottabadTblBindingNavigatorSaveItem
            // 
            this.fNFAbbottabadTblBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fNFAbbottabadTblBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fNFAbbottabadTblBindingNavigatorSaveItem.Image")));
            this.fNFAbbottabadTblBindingNavigatorSaveItem.Name = "fNFAbbottabadTblBindingNavigatorSaveItem";
            this.fNFAbbottabadTblBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fNFAbbottabadTblBindingNavigatorSaveItem.Text = "Save Data";
            this.fNFAbbottabadTblBindingNavigatorSaveItem.Click += new System.EventHandler(this.fNFAbbottabadTblBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(188, 51);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(27, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.Location = new System.Drawing.Point(499, 51);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(334, 26);
            this.idTextBox.TabIndex = 2;
            // 
            // districtLabel
            // 
            districtLabel.AutoSize = true;
            districtLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            districtLabel.Location = new System.Drawing.Point(188, 99);
            districtLabel.Name = "districtLabel";
            districtLabel.Size = new System.Drawing.Size(62, 20);
            districtLabel.TabIndex = 3;
            districtLabel.Text = "District:";
            // 
            // districtTextBox
            // 
            this.districtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "District", true));
            this.districtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.districtTextBox.Location = new System.Drawing.Point(499, 99);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(334, 26);
            this.districtTextBox.TabIndex = 4;
            // 
            // name_of_Fruit_Nursery_FarmLabel
            // 
            name_of_Fruit_Nursery_FarmLabel.AutoSize = true;
            name_of_Fruit_Nursery_FarmLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_Fruit_Nursery_FarmLabel.Location = new System.Drawing.Point(188, 146);
            name_of_Fruit_Nursery_FarmLabel.Name = "name_of_Fruit_Nursery_FarmLabel";
            name_of_Fruit_Nursery_FarmLabel.Size = new System.Drawing.Size(208, 20);
            name_of_Fruit_Nursery_FarmLabel.TabIndex = 5;
            name_of_Fruit_Nursery_FarmLabel.Text = "Name of Fruit Nursery Farm:";
            // 
            // name_of_Fruit_Nursery_FarmTextBox
            // 
            this.name_of_Fruit_Nursery_FarmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "Name_of_Fruit_Nursery_Farm", true));
            this.name_of_Fruit_Nursery_FarmTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_Fruit_Nursery_FarmTextBox.Location = new System.Drawing.Point(499, 146);
            this.name_of_Fruit_Nursery_FarmTextBox.Name = "name_of_Fruit_Nursery_FarmTextBox";
            this.name_of_Fruit_Nursery_FarmTextBox.Size = new System.Drawing.Size(334, 26);
            this.name_of_Fruit_Nursery_FarmTextBox.TabIndex = 6;
            // 
            // name_of_FruitLabel
            // 
            name_of_FruitLabel.AutoSize = true;
            name_of_FruitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            name_of_FruitLabel.Location = new System.Drawing.Point(188, 196);
            name_of_FruitLabel.Name = "name_of_FruitLabel";
            name_of_FruitLabel.Size = new System.Drawing.Size(109, 20);
            name_of_FruitLabel.TabIndex = 7;
            name_of_FruitLabel.Text = "Name of Fruit:";
            // 
            // name_of_FruitTextBox
            // 
            this.name_of_FruitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "Name_of_Fruit", true));
            this.name_of_FruitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_of_FruitTextBox.Location = new System.Drawing.Point(499, 196);
            this.name_of_FruitTextBox.Name = "name_of_FruitTextBox";
            this.name_of_FruitTextBox.Size = new System.Drawing.Size(334, 26);
            this.name_of_FruitTextBox.TabIndex = 8;
            // 
            // no_of_Fruit_Plants_RaisedLabel
            // 
            no_of_Fruit_Plants_RaisedLabel.AutoSize = true;
            no_of_Fruit_Plants_RaisedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            no_of_Fruit_Plants_RaisedLabel.Location = new System.Drawing.Point(188, 244);
            no_of_Fruit_Plants_RaisedLabel.Name = "no_of_Fruit_Plants_RaisedLabel";
            no_of_Fruit_Plants_RaisedLabel.Size = new System.Drawing.Size(189, 20);
            no_of_Fruit_Plants_RaisedLabel.TabIndex = 9;
            no_of_Fruit_Plants_RaisedLabel.Text = "No of Fruit Plants Raised:";
            // 
            // no_of_Fruit_Plants_RaisedTextBox
            // 
            this.no_of_Fruit_Plants_RaisedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "No_of_Fruit_Plants_Raised", true));
            this.no_of_Fruit_Plants_RaisedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no_of_Fruit_Plants_RaisedTextBox.Location = new System.Drawing.Point(499, 244);
            this.no_of_Fruit_Plants_RaisedTextBox.Name = "no_of_Fruit_Plants_RaisedTextBox";
            this.no_of_Fruit_Plants_RaisedTextBox.Size = new System.Drawing.Size(334, 26);
            this.no_of_Fruit_Plants_RaisedTextBox.TabIndex = 10;
            // 
            // total_No_of_Plants_available_for_seasonLabel
            // 
            total_No_of_Plants_available_for_seasonLabel.AutoSize = true;
            total_No_of_Plants_available_for_seasonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            total_No_of_Plants_available_for_seasonLabel.Location = new System.Drawing.Point(188, 297);
            total_No_of_Plants_available_for_seasonLabel.Name = "total_No_of_Plants_available_for_seasonLabel";
            total_No_of_Plants_available_for_seasonLabel.Size = new System.Drawing.Size(282, 20);
            total_No_of_Plants_available_for_seasonLabel.TabIndex = 11;
            total_No_of_Plants_available_for_seasonLabel.Text = "Total No of Plants available for season:";
            // 
            // total_No_of_Plants_available_for_seasonTextBox
            // 
            this.total_No_of_Plants_available_for_seasonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "Total_No_of_Plants_available_for_season", true));
            this.total_No_of_Plants_available_for_seasonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_No_of_Plants_available_for_seasonTextBox.Location = new System.Drawing.Point(499, 297);
            this.total_No_of_Plants_available_for_seasonTextBox.Name = "total_No_of_Plants_available_for_seasonTextBox";
            this.total_No_of_Plants_available_for_seasonTextBox.Size = new System.Drawing.Size(334, 26);
            this.total_No_of_Plants_available_for_seasonTextBox.TabIndex = 12;
            // 
            // under_Size_PlantsLabel
            // 
            under_Size_PlantsLabel.AutoSize = true;
            under_Size_PlantsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            under_Size_PlantsLabel.Location = new System.Drawing.Point(188, 350);
            under_Size_PlantsLabel.Name = "under_Size_PlantsLabel";
            under_Size_PlantsLabel.Size = new System.Drawing.Size(140, 20);
            under_Size_PlantsLabel.TabIndex = 13;
            under_Size_PlantsLabel.Text = "Under Size Plants:";
            // 
            // under_Size_PlantsTextBox
            // 
            this.under_Size_PlantsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fNFAbbottabadTblBindingSource, "Under_Size_Plants", true));
            this.under_Size_PlantsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.under_Size_PlantsTextBox.Location = new System.Drawing.Point(499, 350);
            this.under_Size_PlantsTextBox.Name = "under_Size_PlantsTextBox";
            this.under_Size_PlantsTextBox.Size = new System.Drawing.Size(334, 26);
            this.under_Size_PlantsTextBox.TabIndex = 14;
            // 
            // Update_button
            // 
            this.Update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_button.Location = new System.Drawing.Point(768, 404);
            this.Update_button.Name = "Update_button";
            this.Update_button.Size = new System.Drawing.Size(75, 34);
            this.Update_button.TabIndex = 15;
            this.Update_button.Text = "Update";
            this.Update_button.UseVisualStyleBackColor = true;
            this.Update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // FNF_Abbottabad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(869, 450);
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
            this.Controls.Add(this.fNFAbbottabadTblBindingNavigator);
            this.Name = "FNF_Abbottabad";
            this.Text = "FNF_Abbottabad";
            this.Load += new System.EventHandler(this.FNF_Abbottabad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFAbbottabadTblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fNFAbbottabadTblBindingNavigator)).EndInit();
            this.fNFAbbottabadTblBindingNavigator.ResumeLayout(false);
            this.fNFAbbottabadTblBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource fNFAbbottabadTblBindingSource;
        private DatabaseDataSetTableAdapters.FNFAbbottabadTblTableAdapter fNFAbbottabadTblTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fNFAbbottabadTblBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fNFAbbottabadTblBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.TextBox name_of_Fruit_Nursery_FarmTextBox;
        private System.Windows.Forms.TextBox name_of_FruitTextBox;
        private System.Windows.Forms.TextBox no_of_Fruit_Plants_RaisedTextBox;
        private System.Windows.Forms.TextBox total_No_of_Plants_available_for_seasonTextBox;
        private System.Windows.Forms.TextBox under_Size_PlantsTextBox;
        private System.Windows.Forms.Button Update_button;
    }
}