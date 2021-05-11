
using final_db_forms.Properties;

namespace final_db_forms
{
    partial class Main
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
            System.Windows.Forms.TabPage tab_ing;
            System.Windows.Forms.TabPage tab_r;
            System.Windows.Forms.TabPage tab_emp;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.Label label1;
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_ing = new System.Windows.Forms.BindingSource(this.components);
            this.bs_fc = new System.Windows.Forms.BindingSource(this.components);
            this.llu = new final_db_forms.llu();
            this.food_categoriesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nep_ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_price = new System.Windows.Forms.BindingSource(this.components);
            this.bs_nob = new System.Windows.Forms.BindingSource(this.components);
            this.priceDataGridView = new System.Windows.Forms.DataGridView();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bs_nep = new System.Windows.Forms.BindingSource(this.components);
            this.recipesDataGridView = new System.Windows.Forms.DataGridView();
            this.id_n_o_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idingredientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ingredientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_nep_ing = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs_fk_recip = new System.Windows.Forms.BindingSource(this.components);
            this.name_of_breadDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_forceDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesforcefkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bs_pos = new System.Windows.Forms.BindingSource(this.components);
            this.positionsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_save = new System.Windows.Forms.ToolStripButton();
            this.add_emps = new System.Windows.Forms.ToolStripButton();
            this.add_sales = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_sales = new System.Windows.Forms.TabPage();
            this.soldDataGridView = new System.Windows.Forms.DataGridView();
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sold_recipe_indexDataGridView = new System.Windows.Forms.DataGridView();
            this.sold_recipe_indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.food_categoriesTableAdapter = new final_db_forms.lluTableAdapters.food_categoriesTableAdapter();
            this.ta_llu = new final_db_forms.lluTableAdapters.TableAdapterManager();
            this.ingredientsTableAdapter = new final_db_forms.lluTableAdapters.ingredientsTableAdapter();
            this.name_of_breadTableAdapter = new final_db_forms.lluTableAdapters.name_of_breadTableAdapter();
            this.nep_ingredientsTableAdapter = new final_db_forms.lluTableAdapters.nep_ingredientsTableAdapter();
            this.positionsTableAdapter = new final_db_forms.lluTableAdapters.positionsTableAdapter();
            this.priceTableAdapter = new final_db_forms.lluTableAdapters.priceTableAdapter();
            this.recipesTableAdapter = new final_db_forms.lluTableAdapters.recipesTableAdapter();
            this.sales_forceTableAdapter = new final_db_forms.lluTableAdapters.sales_forceTableAdapter();
            this.sold_recipe_indexTableAdapter = new final_db_forms.lluTableAdapters.sold_recipe_indexTableAdapter();
            this.soldTableAdapter = new final_db_forms.lluTableAdapters.soldTableAdapter();
            this.bs_sf = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_sales_force = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold_recipe_indexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sold_recipe_indexDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.filter_by_date = new System.Windows.Forms.DateTimePicker();
            tab_ing = new System.Windows.Forms.TabPage();
            tab_r = new System.Windows.Forms.TabPage();
            tab_emp = new System.Windows.Forms.TabPage();
            label1 = new System.Windows.Forms.Label();
            tab_ing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_fc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.llu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_categoriesDataGridView)).BeginInit();
            tab_r.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nep_ingredientsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_nob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_nep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_fk_recip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_of_breadDataGridView)).BeginInit();
            tab_emp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sales_forceDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforcefkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_pos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_sales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexDataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_ing
            // 
            tab_ing.AutoScroll = true;
            tab_ing.Controls.Add(this.ingredientsDataGridView);
            tab_ing.Controls.Add(this.food_categoriesDataGridView);
            tab_ing.Location = new System.Drawing.Point(4, 22);
            tab_ing.Name = "tab_ing";
            tab_ing.Padding = new System.Windows.Forms.Padding(3);
            tab_ing.RightToLeft = System.Windows.Forms.RightToLeft.No;
            tab_ing.Size = new System.Drawing.Size(1384, 723);
            tab_ing.TabIndex = 0;
            tab_ing.Text = "Ingredients";
            tab_ing.UseVisualStyleBackColor = true;
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AutoGenerateColumns = false;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.ingredientsDataGridView.DataSource = this.bs_ing;
            this.ingredientsDataGridView.Location = new System.Drawing.Point(258, 6);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.Size = new System.Drawing.Size(449, 714);
            this.ingredientsDataGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ingredient";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // bs_ing
            // 
            this.bs_ing.DataMember = "ingredients_fk";
            this.bs_ing.DataSource = this.bs_fc;
            // 
            // bs_fc
            // 
            this.bs_fc.DataMember = "food_categories";
            this.bs_fc.DataSource = this.llu;
            // 
            // llu
            // 
            this.llu.DataSetName = "llu";
            this.llu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // food_categoriesDataGridView
            // 
            this.food_categoriesDataGridView.AutoGenerateColumns = false;
            this.food_categoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.food_categoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.food_categoriesDataGridView.DataSource = this.bs_fc;
            this.food_categoriesDataGridView.Location = new System.Drawing.Point(8, 6);
            this.food_categoriesDataGridView.Name = "food_categoriesDataGridView";
            this.food_categoriesDataGridView.Size = new System.Drawing.Size(244, 714);
            this.food_categoriesDataGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = Resources.name;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // tab_r
            // 
            tab_r.AutoScroll = true;
            tab_r.Controls.Add(this.nep_ingredientsDataGridView);
            tab_r.Controls.Add(this.priceDataGridView);
            tab_r.Controls.Add(this.recipesDataGridView);
            tab_r.Controls.Add(this.name_of_breadDataGridView);
            tab_r.Location = new System.Drawing.Point(4, 22);
            tab_r.Name = "tab_r";
            tab_r.Padding = new System.Windows.Forms.Padding(3);
            tab_r.Size = new System.Drawing.Size(1384, 723);
            tab_r.TabIndex = 1;
            tab_r.Text = "Recipes";
            tab_r.UseVisualStyleBackColor = true;
            // 
            // nep_ingredientsDataGridView
            // 
            this.nep_ingredientsDataGridView.AutoGenerateColumns = false;
            this.nep_ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nep_ingredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.priceDataGridViewTextBoxColumn});
            this.nep_ingredientsDataGridView.DataSource = this.bs_price;
            this.nep_ingredientsDataGridView.Location = new System.Drawing.Point(706, 0);
            this.nep_ingredientsDataGridView.Name = "nep_ingredientsDataGridView";
            this.nep_ingredientsDataGridView.Size = new System.Drawing.Size(300, 723);
            this.nep_ingredientsDataGridView.TabIndex = 3;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = Resources.price;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bs_price
            // 
            this.bs_price.DataMember = "price_fk";
            this.bs_price.DataSource = this.bs_nob;
            // 
            // bs_nob
            // 
            this.bs_nob.DataMember = "name_of_bread";
            this.bs_nob.DataSource = this.llu;
            // 
            // priceDataGridView
            // 
            this.priceDataGridView.AutoGenerateColumns = false;
            this.priceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.priceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn});
            this.priceDataGridView.DataSource = this.bs_nep;
            this.priceDataGridView.Location = new System.Drawing.Point(256, 504);
            this.priceDataGridView.Name = "priceDataGridView";
            this.priceDataGridView.Size = new System.Drawing.Size(444, 220);
            this.priceDataGridView.TabIndex = 2;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Add Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // bs_nep
            // 
            this.bs_nep.DataMember = "nep_ingredients";
            this.bs_nep.DataSource = this.llu;
            // 
            // recipesDataGridView
            // 
            this.recipesDataGridView.AutoGenerateColumns = false;
            this.recipesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_n_o_b,
            this.idingredientsDataGridViewTextBoxColumn,
            this.id_nep_ing});
            this.recipesDataGridView.DataSource = this.bs_fk_recip;
            this.recipesDataGridView.Location = new System.Drawing.Point(256, 0);
            this.recipesDataGridView.Name = "recipesDataGridView";
            this.recipesDataGridView.Size = new System.Drawing.Size(444, 498);
            this.recipesDataGridView.TabIndex = 1;
            // 
            // id_n_o_b
            // 
            this.id_n_o_b.DataPropertyName = "id_n_o_b";
            this.id_n_o_b.HeaderText = "id_n_o_b";
            this.id_n_o_b.Name = "id_n_o_b";
            // 
            // idingredientsDataGridViewTextBoxColumn
            // 
            this.idingredientsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idingredientsDataGridViewTextBoxColumn.DataPropertyName = "id_ingredients";
            this.idingredientsDataGridViewTextBoxColumn.DataSource = this.ingredientsBindingSource;
            this.idingredientsDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idingredientsDataGridViewTextBoxColumn.HeaderText = "Ingredient";
            this.idingredientsDataGridViewTextBoxColumn.Name = "idingredientsDataGridViewTextBoxColumn";
            this.idingredientsDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idingredientsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idingredientsDataGridViewTextBoxColumn.ValueMember = "id_ingredients";
            // 
            // ingredientsBindingSource
            // 
            this.ingredientsBindingSource.DataMember = "ingredients";
            this.ingredientsBindingSource.DataSource = this.llu;
            // 
            // id_nep_ing
            // 
            this.id_nep_ing.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_nep_ing.DataPropertyName = "id_nep_ing";
            this.id_nep_ing.DataSource = this.bs_nep;
            this.id_nep_ing.DisplayMember = "amount";
            this.id_nep_ing.HeaderText = "Amount";
            this.id_nep_ing.Name = "id_nep_ing";
            this.id_nep_ing.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_nep_ing.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_nep_ing.ValueMember = "id_nep_ing";
            // 
            // bs_fk_recip
            // 
            this.bs_fk_recip.DataMember = "recipes_fk_1";
            this.bs_fk_recip.DataSource = this.bs_nob;
            // 
            // name_of_breadDataGridView
            // 
            this.name_of_breadDataGridView.AutoGenerateColumns = false;
            this.name_of_breadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.name_of_breadDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn2});
            this.name_of_breadDataGridView.DataSource = this.bs_nob;
            this.name_of_breadDataGridView.Location = new System.Drawing.Point(0, 0);
            this.name_of_breadDataGridView.Name = "name_of_breadDataGridView";
            this.name_of_breadDataGridView.Size = new System.Drawing.Size(250, 723);
            this.name_of_breadDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn2
            // 
            this.nameDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn2.HeaderText = Resources.name;
            this.nameDataGridViewTextBoxColumn2.Name = "nameDataGridViewTextBoxColumn2";
            // 
            // tab_emp
            // 
            tab_emp.AutoScroll = true;
            tab_emp.Controls.Add(this.sales_forceDataGridView);
            tab_emp.Controls.Add(this.positionsDataGridView);
            tab_emp.Location = new System.Drawing.Point(4, 22);
            tab_emp.Name = "tab_emp";
            tab_emp.Padding = new System.Windows.Forms.Padding(3);
            tab_emp.Size = new System.Drawing.Size(1384, 723);
            tab_emp.TabIndex = 2;
            tab_emp.Text = "Employees";
            tab_emp.UseVisualStyleBackColor = true;
            // 
            // sales_forceDataGridView
            // 
            this.sales_forceDataGridView.AutoGenerateColumns = false;
            this.sales_forceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sales_forceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn4,
            this.surnameDataGridViewTextBoxColumn});
            this.sales_forceDataGridView.DataSource = this.salesforcefkBindingSource;
            this.sales_forceDataGridView.Location = new System.Drawing.Point(312, 6);
            this.sales_forceDataGridView.Name = "sales_forceDataGridView";
            this.sales_forceDataGridView.ReadOnly = true;
            this.sales_forceDataGridView.Size = new System.Drawing.Size(434, 711);
            this.sales_forceDataGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = Resources.name;
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = Resources.surname;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesforcefkBindingSource
            // 
            this.salesforcefkBindingSource.DataMember = "sales_force_fk";
            this.salesforcefkBindingSource.DataSource = this.bs_pos;
            // 
            // bs_pos
            // 
            this.bs_pos.DataMember = "positions";
            this.bs_pos.DataSource = this.llu;
            // 
            // positionsDataGridView
            // 
            this.positionsDataGridView.AutoGenerateColumns = false;
            this.positionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.positionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn3});
            this.positionsDataGridView.DataSource = this.bs_pos;
            this.positionsDataGridView.Location = new System.Drawing.Point(6, 6);
            this.positionsDataGridView.Name = "positionsDataGridView";
            this.positionsDataGridView.ReadOnly = true;
            this.positionsDataGridView.Size = new System.Drawing.Size(300, 393);
            this.positionsDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn3
            // 
            this.nameDataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn3.HeaderText = "Position";
            this.nameDataGridViewTextBoxColumn3.Name = "nameDataGridViewTextBoxColumn3";
            this.nameDataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_save,
            this.add_emps,
            this.add_sales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1392, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // button_save
            // 
            this.button_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.button_save.Image = ((System.Drawing.Image)(resources.GetObject("button_save.Image")));
            this.button_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(38, 22);
            this.button_save.Text = "Save!";
            this.button_save.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // add_emps
            // 
            this.add_emps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_emps.Image = ((System.Drawing.Image)(resources.GetObject("add_emps.Image")));
            this.add_emps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_emps.Name = "add_emps";
            this.add_emps.Size = new System.Drawing.Size(93, 22);
            this.add_emps.Text = "Add Employees";
            this.add_emps.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // add_sales
            // 
            this.add_sales.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.add_sales.Image = ((System.Drawing.Image)(resources.GetObject("add_sales.Image")));
            this.add_sales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.add_sales.Name = "add_sales";
            this.add_sales.Size = new System.Drawing.Size(62, 22);
            this.add_sales.Text = "Add Sales";
            this.add_sales.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(tab_ing);
            this.tabControl1.Controls.Add(tab_r);
            this.tabControl1.Controls.Add(tab_emp);
            this.tabControl1.Controls.Add(this.tab_sales);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1392, 749);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_sales
            // 
            this.tab_sales.Controls.Add(this.tableLayoutPanel1);
            this.tab_sales.Controls.Add(this.sold_recipe_indexDataGridView1);
            this.tab_sales.Controls.Add(this.soldDataGridView);
            this.tab_sales.Controls.Add(this.sold_recipe_indexDataGridView);
            this.tab_sales.Location = new System.Drawing.Point(4, 22);
            this.tab_sales.Name = "tab_sales";
            this.tab_sales.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sales.Size = new System.Drawing.Size(1384, 723);
            this.tab_sales.TabIndex = 3;
            this.tab_sales.Text = "Sales";
            this.tab_sales.UseVisualStyleBackColor = true;
            // 
            // soldDataGridView
            // 
            this.soldDataGridView.AllowUserToAddRows = false;
            this.soldDataGridView.AutoGenerateColumns = false;
            this.soldDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.id_sales_force,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.soldDataGridView.DataSource = this.soldBindingSource;
            this.soldDataGridView.Location = new System.Drawing.Point(0, 0);
            this.soldDataGridView.Name = "soldDataGridView";
            this.soldDataGridView.RowHeadersVisible = false;
            this.soldDataGridView.Size = new System.Drawing.Size(441, 727);
            this.soldDataGridView.TabIndex = 1;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "sold";
            this.soldBindingSource.DataSource = this.llu;
            // 
            // sold_recipe_indexDataGridView
            // 
            this.sold_recipe_indexDataGridView.AutoGenerateColumns = false;
            this.sold_recipe_indexDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sold_recipe_indexDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sold_recipe_indexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sold_recipe_indexDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sold_recipe_indexDataGridView.DataSource = this.sold_recipe_indexBindingSource;
            this.sold_recipe_indexDataGridView.Location = new System.Drawing.Point(466, 58);
            this.sold_recipe_indexDataGridView.Name = "sold_recipe_indexDataGridView";
            this.sold_recipe_indexDataGridView.RowHeadersVisible = false;
            this.sold_recipe_indexDataGridView.Size = new System.Drawing.Size(434, 666);
            this.sold_recipe_indexDataGridView.TabIndex = 0;
            // 
            // sold_recipe_indexBindingSource
            // 
            this.sold_recipe_indexBindingSource.DataMember = "sold_recipe_index";
            this.sold_recipe_indexBindingSource.DataSource = this.llu;
            // 
            // food_categoriesTableAdapter
            // 
            this.food_categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ta_llu
            // 
            this.ta_llu.BackupDataSetBeforeUpdate = true;
            this.ta_llu.food_categoriesTableAdapter = this.food_categoriesTableAdapter;
            this.ta_llu.ingredientsTableAdapter = this.ingredientsTableAdapter;
            this.ta_llu.name_of_breadTableAdapter = this.name_of_breadTableAdapter;
            this.ta_llu.nep_ingredientsTableAdapter = this.nep_ingredientsTableAdapter;
            this.ta_llu.positionsTableAdapter = this.positionsTableAdapter;
            this.ta_llu.priceTableAdapter = this.priceTableAdapter;
            this.ta_llu.recipesTableAdapter = this.recipesTableAdapter;
            this.ta_llu.sales_forceTableAdapter = this.sales_forceTableAdapter;
            this.ta_llu.sold_recipe_indexTableAdapter = this.sold_recipe_indexTableAdapter;
            this.ta_llu.soldTableAdapter = this.soldTableAdapter;
            this.ta_llu.UpdateOrder = final_db_forms.lluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ingredientsTableAdapter
            // 
            this.ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // name_of_breadTableAdapter
            // 
            this.name_of_breadTableAdapter.ClearBeforeFill = true;
            // 
            // nep_ingredientsTableAdapter
            // 
            this.nep_ingredientsTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // priceTableAdapter
            // 
            this.priceTableAdapter.ClearBeforeFill = true;
            // 
            // recipesTableAdapter
            // 
            this.recipesTableAdapter.ClearBeforeFill = true;
            // 
            // sales_forceTableAdapter
            // 
            this.sales_forceTableAdapter.ClearBeforeFill = true;
            // 
            // sold_recipe_indexTableAdapter
            // 
            this.sold_recipe_indexTableAdapter.ClearBeforeFill = true;
            // 
            // soldTableAdapter
            // 
            this.soldTableAdapter.ClearBeforeFill = true;
            // 
            // bs_sf
            // 
            this.bs_sf.DataMember = "sales_force";
            this.bs_sf.DataSource = this.llu;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_sales_force";
            this.dataGridViewTextBoxColumn8.DataSource = this.bs_sf;
            this.dataGridViewTextBoxColumn8.DisplayMember = "name";
            this.dataGridViewTextBoxColumn8.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn8.HeaderText = Resources.name;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "employee_id";
            // 
            // id_sales_force
            // 
            this.id_sales_force.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_sales_force.DataPropertyName = "id_sales_force";
            this.id_sales_force.DataSource = this.bs_sf;
            this.id_sales_force.DisplayMember = "surname";
            this.id_sales_force.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_sales_force.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_sales_force.HeaderText = Resources.surname;
            this.id_sales_force.Name = "id_sales_force";
            this.id_sales_force.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_sales_force.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_sales_force.ValueMember = "employee_id";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "amount";
            this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_price";
            this.dataGridViewTextBoxColumn6.DataSource = this.bs_price;
            this.dataGridViewTextBoxColumn6.DisplayMember = "price";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn6.HeaderText = Resources.price;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id_price";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_sold_recipe_index";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_sold_recipe_index";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id_n_o_b";
            this.dataGridViewTextBoxColumn2.DataSource = this.bs_nob;
            this.dataGridViewTextBoxColumn2.DisplayMember = "name";
            this.dataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn2.HeaderText = Resources.name;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "id_n_o_b";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "id_sold";
            this.dataGridViewTextBoxColumn3.DataSource = this.soldBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "amount";
            this.dataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "id_sold";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn4.HeaderText = "date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // sold_recipe_indexBindingSource1
            // 
            this.sold_recipe_indexBindingSource1.DataMember = "sold_recipe_index_fk_1";
            this.sold_recipe_indexBindingSource1.DataSource = this.soldBindingSource;
            // 
            // sold_recipe_indexDataGridView1
            // 
            this.sold_recipe_indexDataGridView1.AllowUserToAddRows = false;
            this.sold_recipe_indexDataGridView1.AllowUserToDeleteRows = false;
            this.sold_recipe_indexDataGridView1.AutoGenerateColumns = false;
            this.sold_recipe_indexDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sold_recipe_indexDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.sold_recipe_indexDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sold_recipe_indexDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
            this.sold_recipe_indexDataGridView1.DataSource = this.sold_recipe_indexBindingSource1;
            this.sold_recipe_indexDataGridView1.Location = new System.Drawing.Point(466, 0);
            this.sold_recipe_indexDataGridView1.Name = "sold_recipe_indexDataGridView1";
            this.sold_recipe_indexDataGridView1.ReadOnly = true;
            this.sold_recipe_indexDataGridView1.RowHeadersVisible = false;
            this.sold_recipe_indexDataGridView1.Size = new System.Drawing.Size(434, 49);
            this.sold_recipe_indexDataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_sold_recipe_index";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_sold_recipe_index";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 131;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "id_n_o_b";
            this.dataGridViewTextBoxColumn9.DataSource = this.bs_nob;
            this.dataGridViewTextBoxColumn9.DisplayMember = "name";
            this.dataGridViewTextBoxColumn9.HeaderText = Resources.name;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn9.ValueMember = "id_n_o_b";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_sold";
            this.dataGridViewTextBoxColumn10.DataSource = this.soldBindingSource;
            this.dataGridViewTextBoxColumn10.DisplayMember = "amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn10.ValueMember = "id_sold";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn11.HeaderText = "Date";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.60591F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.39409F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.filter_by_date, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1123, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.47458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.52542F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 469F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(253, 717);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(164, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 26);
            label1.TabIndex = 0;
            label1.Text = "Filter Sales by Date";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // filter_by_date
            // 
            this.filter_by_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.filter_by_date.Location = new System.Drawing.Point(3, 14);
            this.filter_by_date.Name = "filter_by_date";
            this.filter_by_date.Size = new System.Drawing.Size(144, 20);
            this.filter_by_date.TabIndex = 1;
            this.filter_by_date.ValueChanged += new System.EventHandler(this.filter_by_date_ValueChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 776);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.Text = "SIA \"Random Bakery on Liela Iela\"";
            this.Load += new System.EventHandler(this.Main_Load);
            tab_ing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_fc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.llu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.food_categoriesDataGridView)).EndInit();
            tab_r.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nep_ingredientsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_nob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_nep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_fk_recip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_of_breadDataGridView)).EndInit();
            tab_emp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sales_forceDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesforcefkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_pos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsDataGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_sales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soldDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_sf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexDataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton button_save;
        private System.Windows.Forms.ToolStripButton add_emps;
        private System.Windows.Forms.ToolStripButton add_sales;
        private llu llu;
        private lluTableAdapters.food_categoriesTableAdapter food_categoriesTableAdapter;
        private lluTableAdapters.TableAdapterManager ta_llu;
        private lluTableAdapters.recipesTableAdapter recipesTableAdapter;
        private System.Windows.Forms.DataGridView food_categoriesDataGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private lluTableAdapters.ingredientsTableAdapter ingredientsTableAdapter;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private lluTableAdapters.name_of_breadTableAdapter name_of_breadTableAdapter;
        private System.Windows.Forms.DataGridView recipesDataGridView;
        private System.Windows.Forms.DataGridView name_of_breadDataGridView;
        private lluTableAdapters.priceTableAdapter priceTableAdapter;
        private System.Windows.Forms.DataGridView priceDataGridView;
        private lluTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.DataGridView positionsDataGridView;
        private lluTableAdapters.sales_forceTableAdapter sales_forceTableAdapter;
        private System.Windows.Forms.DataGridView sales_forceDataGridView;
        private lluTableAdapters.nep_ingredientsTableAdapter nep_ingredientsTableAdapter;
        private System.Windows.Forms.DataGridView nep_ingredientsDataGridView;
        private lluTableAdapters.soldTableAdapter soldTableAdapter;
        private lluTableAdapters.sold_recipe_indexTableAdapter sold_recipe_indexTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_fc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bs_ing;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_price;
        private System.Windows.Forms.BindingSource bs_nob;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bs_nep;
        private System.Windows.Forms.BindingSource ingredientsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_n_o_b;
        private System.Windows.Forms.DataGridViewComboBoxColumn idingredientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_nep_ing;
        private System.Windows.Forms.BindingSource bs_fk_recip;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource salesforcefkBindingSource;
        private System.Windows.Forms.BindingSource bs_pos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tab_sales;
        private System.Windows.Forms.DataGridView soldDataGridView;
        private System.Windows.Forms.BindingSource soldBindingSource;
        private System.Windows.Forms.DataGridView sold_recipe_indexDataGridView;
        private System.Windows.Forms.BindingSource sold_recipe_indexBindingSource;
        private System.Windows.Forms.BindingSource bs_sf;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_sales_force;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView sold_recipe_indexDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.BindingSource sold_recipe_indexBindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DateTimePicker filter_by_date;
    }
}

