﻿namespace RestaurantProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Table10 = new System.Windows.Forms.Button();
            this.btn_Table9 = new System.Windows.Forms.Button();
            this.btn_Table8 = new System.Windows.Forms.Button();
            this.btn_Table7 = new System.Windows.Forms.Button();
            this.btn_Table6 = new System.Windows.Forms.Button();
            this.btn_Table5 = new System.Windows.Forms.Button();
            this.btn_Table4 = new System.Windows.Forms.Button();
            this.btn_Table3 = new System.Windows.Forms.Button();
            this.btn_Table2 = new System.Windows.Forms.Button();
            this.btn_Table1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.restaurantDataSet = new RestaurantProject.RestaurantDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new RestaurantProject.RestaurantDataSetTableAdapters.OrdersTableAdapter();
            this.tableAdapterManager = new RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager();
            this.ordersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.ordersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.ordersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).BeginInit();
            this.ordersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Location = new System.Drawing.Point(12, 28);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(878, 501);
            this.Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chef";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 141);
            this.button1.TabIndex = 55;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_Table10);
            this.tabPage2.Controls.Add(this.btn_Table9);
            this.tabPage2.Controls.Add(this.btn_Table8);
            this.tabPage2.Controls.Add(this.btn_Table7);
            this.tabPage2.Controls.Add(this.btn_Table6);
            this.tabPage2.Controls.Add(this.btn_Table5);
            this.tabPage2.Controls.Add(this.btn_Table4);
            this.tabPage2.Controls.Add(this.btn_Table3);
            this.tabPage2.Controls.Add(this.btn_Table2);
            this.tabPage2.Controls.Add(this.btn_Table1);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tables";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Restaurant";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Fuchsia;
            this.label5.Location = new System.Drawing.Point(451, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Needs Cleaning";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(255, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Ready to Eat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "Dish not Ready";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(68, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Wating for Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(68, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Free Table";
            // 
            // btn_Table10
            // 
            this.btn_Table10.BackColor = System.Drawing.Color.Blue;
            this.btn_Table10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table10.Location = new System.Drawing.Point(627, 179);
            this.btn_Table10.Name = "btn_Table10";
            this.btn_Table10.Size = new System.Drawing.Size(131, 47);
            this.btn_Table10.TabIndex = 9;
            this.btn_Table10.Text = "10";
            this.btn_Table10.UseVisualStyleBackColor = false;
            this.btn_Table10.Click += new System.EventHandler(this.btn_Table10_Click);
            // 
            // btn_Table9
            // 
            this.btn_Table9.BackColor = System.Drawing.Color.Blue;
            this.btn_Table9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table9.Location = new System.Drawing.Point(454, 250);
            this.btn_Table9.Name = "btn_Table9";
            this.btn_Table9.Size = new System.Drawing.Size(131, 47);
            this.btn_Table9.TabIndex = 8;
            this.btn_Table9.Text = "9";
            this.btn_Table9.UseVisualStyleBackColor = false;
            this.btn_Table9.Click += new System.EventHandler(this.btn_Table9_Click);
            // 
            // btn_Table8
            // 
            this.btn_Table8.BackColor = System.Drawing.Color.Blue;
            this.btn_Table8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table8.Location = new System.Drawing.Point(454, 179);
            this.btn_Table8.Name = "btn_Table8";
            this.btn_Table8.Size = new System.Drawing.Size(131, 47);
            this.btn_Table8.TabIndex = 7;
            this.btn_Table8.Text = "8";
            this.btn_Table8.UseVisualStyleBackColor = false;
            this.btn_Table8.Click += new System.EventHandler(this.btn_Table8_Click);
            // 
            // btn_Table7
            // 
            this.btn_Table7.BackColor = System.Drawing.Color.Blue;
            this.btn_Table7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table7.Location = new System.Drawing.Point(454, 109);
            this.btn_Table7.Name = "btn_Table7";
            this.btn_Table7.Size = new System.Drawing.Size(131, 47);
            this.btn_Table7.TabIndex = 6;
            this.btn_Table7.Text = "7";
            this.btn_Table7.UseVisualStyleBackColor = false;
            this.btn_Table7.Click += new System.EventHandler(this.btn_Table7_Click);
            // 
            // btn_Table6
            // 
            this.btn_Table6.BackColor = System.Drawing.Color.Blue;
            this.btn_Table6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table6.Location = new System.Drawing.Point(258, 250);
            this.btn_Table6.Name = "btn_Table6";
            this.btn_Table6.Size = new System.Drawing.Size(131, 47);
            this.btn_Table6.TabIndex = 5;
            this.btn_Table6.Text = "6";
            this.btn_Table6.UseVisualStyleBackColor = false;
            this.btn_Table6.Click += new System.EventHandler(this.btn_Table6_Click);
            // 
            // btn_Table5
            // 
            this.btn_Table5.BackColor = System.Drawing.Color.Blue;
            this.btn_Table5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table5.Location = new System.Drawing.Point(258, 179);
            this.btn_Table5.Name = "btn_Table5";
            this.btn_Table5.Size = new System.Drawing.Size(131, 47);
            this.btn_Table5.TabIndex = 4;
            this.btn_Table5.Text = "5";
            this.btn_Table5.UseVisualStyleBackColor = false;
            this.btn_Table5.Click += new System.EventHandler(this.btn_Table5_Click);
            // 
            // btn_Table4
            // 
            this.btn_Table4.BackColor = System.Drawing.Color.Blue;
            this.btn_Table4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table4.Location = new System.Drawing.Point(258, 109);
            this.btn_Table4.Name = "btn_Table4";
            this.btn_Table4.Size = new System.Drawing.Size(131, 47);
            this.btn_Table4.TabIndex = 3;
            this.btn_Table4.Text = "4";
            this.btn_Table4.UseVisualStyleBackColor = false;
            this.btn_Table4.Click += new System.EventHandler(this.btn_Table4_Click);
            // 
            // btn_Table3
            // 
            this.btn_Table3.BackColor = System.Drawing.Color.Blue;
            this.btn_Table3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table3.Location = new System.Drawing.Point(71, 250);
            this.btn_Table3.Name = "btn_Table3";
            this.btn_Table3.Size = new System.Drawing.Size(131, 47);
            this.btn_Table3.TabIndex = 2;
            this.btn_Table3.Text = "3";
            this.btn_Table3.UseVisualStyleBackColor = false;
            this.btn_Table3.Click += new System.EventHandler(this.btn_Table3_Click);
            // 
            // btn_Table2
            // 
            this.btn_Table2.BackColor = System.Drawing.Color.Blue;
            this.btn_Table2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table2.Location = new System.Drawing.Point(71, 179);
            this.btn_Table2.Name = "btn_Table2";
            this.btn_Table2.Size = new System.Drawing.Size(131, 47);
            this.btn_Table2.TabIndex = 1;
            this.btn_Table2.Text = "2";
            this.btn_Table2.UseVisualStyleBackColor = false;
            this.btn_Table2.Click += new System.EventHandler(this.btn_Table2_Click);
            // 
            // btn_Table1
            // 
            this.btn_Table1.BackColor = System.Drawing.Color.Blue;
            this.btn_Table1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Table1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Table1.Location = new System.Drawing.Point(71, 109);
            this.btn_Table1.Name = "btn_Table1";
            this.btn_Table1.Size = new System.Drawing.Size(131, 47);
            this.btn_Table1.TabIndex = 0;
            this.btn_Table1.Text = "1";
            this.btn_Table1.UseVisualStyleBackColor = false;
            this.btn_Table1.Click += new System.EventHandler(this.btn_Table1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tag = global::RestaurantProject.Properties.Settings.Default.RestaurantConnectionString;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // restaurantDataSet
            // 
            this.restaurantDataSet.DataSetName = "RestaurantDataSet";
            this.restaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.restaurantDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.TableOrderTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RestaurantProject.RestaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ordersBindingNavigator
            // 
            this.ordersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ordersBindingNavigator.BindingSource = this.ordersBindingSource;
            this.ordersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ordersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ordersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.ordersBindingNavigatorSaveItem});
            this.ordersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.ordersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ordersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ordersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ordersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ordersBindingNavigator.Name = "ordersBindingNavigator";
            this.ordersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ordersBindingNavigator.Size = new System.Drawing.Size(912, 25);
            this.ordersBindingNavigator.TabIndex = 1;
            this.ordersBindingNavigator.Text = "bindingNavigator1";
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
            // ordersBindingNavigatorSaveItem
            // 
            this.ordersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ordersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersBindingNavigatorSaveItem.Image")));
            this.ordersBindingNavigatorSaveItem.Name = "ordersBindingNavigatorSaveItem";
            this.ordersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.ordersBindingNavigatorSaveItem.Text = "Save Data";
            this.ordersBindingNavigatorSaveItem.Click += new System.EventHandler(this.ordersBindingNavigatorSaveItem_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // ordersBindingSource1
            // 
            this.ordersBindingSource1.DataMember = "Orders";
            this.ordersBindingSource1.DataSource = this.restaurantDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 529);
            this.Controls.Add(this.ordersBindingNavigator);
            this.Controls.Add(this.Menu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.ordersBindingSource1, "order_id", true));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingNavigator)).EndInit();
            this.ordersBindingNavigator.ResumeLayout(false);
            this.ordersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Table10;
        private System.Windows.Forms.Button btn_Table9;
        private System.Windows.Forms.Button btn_Table8;
        private System.Windows.Forms.Button btn_Table7;
        private System.Windows.Forms.Button btn_Table6;
        private System.Windows.Forms.Button btn_Table5;
        private System.Windows.Forms.Button btn_Table4;
        private System.Windows.Forms.Button btn_Table3;
        private System.Windows.Forms.Button btn_Table2;
        private System.Windows.Forms.Button btn_Table1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private RestaurantDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private RestaurantDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator ordersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton ordersBindingNavigatorSaveItem;
        private System.Windows.Forms.Timer timer2;
        private System.Diagnostics.Process process1;
        public System.Windows.Forms.Timer timer1;
        public RestaurantDataSet restaurantDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource ordersBindingSource1;
    }
}

