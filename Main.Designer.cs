
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
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
            this.bs_sf = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.button_save = new System.Windows.Forms.ToolStripButton();
            this.add_emps = new System.Windows.Forms.ToolStripButton();
            this.add_sales = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_sales = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.emp_list = new System.Windows.Forms.CheckedListBox();
            this.dgv_sold_ro = new System.Windows.Forms.DataGridView();
            this.idpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bs_price_not_fk = new System.Windows.Forms.BindingSource(this.components);
            this.idsalesforceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.id_sales_force = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.index_range = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.index_from = new System.Windows.Forms.Label();
            this.index_to = new System.Windows.Forms.Label();
            this.n_index_down = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.n_index_up = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgv_fake_index = new System.Windows.Forms.DataGridView();
            this.idsoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.options_index = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.d_index = new System.Windows.Forms.DateTimePicker();
            this.dgv_index = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sold_recipe_indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sold_recipe_indexBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.soldfk1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
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
            ((System.ComponentModel.ISupportInitialize)(this.bs_sf)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_sales.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold_ro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_price_not_fk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.index_range.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_index_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_index_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fake_index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_index)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldfk1BindingSource)).BeginInit();
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
            tab_ing.Size = new System.Drawing.Size(1024, 723);
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
            this.ingredientsDataGridView.Location = new System.Drawing.Point(574, 6);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.Size = new System.Drawing.Size(447, 714);
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
            this.food_categoriesDataGridView.Size = new System.Drawing.Size(560, 714);
            this.food_categoriesDataGridView.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Category";
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
            tab_r.Size = new System.Drawing.Size(1024, 723);
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
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
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
            this.id_n_o_b.Visible = false;
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
            this.nameDataGridViewTextBoxColumn2.HeaderText = "Name";
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
            tab_emp.Size = new System.Drawing.Size(1024, 723);
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
            this.sales_forceDataGridView.Location = new System.Drawing.Point(312, 0);
            this.sales_forceDataGridView.Name = "sales_forceDataGridView";
            this.sales_forceDataGridView.ReadOnly = true;
            this.sales_forceDataGridView.Size = new System.Drawing.Size(712, 717);
            this.sales_forceDataGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn4
            // 
            this.nameDataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn4.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn4.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn4.Name = "nameDataGridViewTextBoxColumn4";
            this.nameDataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
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
            this.positionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.positionsDataGridView.Name = "positionsDataGridView";
            this.positionsDataGridView.ReadOnly = true;
            this.positionsDataGridView.Size = new System.Drawing.Size(300, 723);
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
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(294, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 13);
            label1.TabIndex = 0;
            label1.Text = "Filter Sales by Date";
            // 
            // bs_sf
            // 
            this.bs_sf.DataMember = "sales_force";
            this.bs_sf.DataSource = this.llu;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.button_save,
            this.add_emps,
            this.add_sales});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1032, 25);
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
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1032, 749);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tab_sales
            // 
            this.tab_sales.AutoScroll = true;
            this.tab_sales.Controls.Add(this.groupBox1);
            this.tab_sales.Controls.Add(this.dgv_sold_ro);
            this.tab_sales.Location = new System.Drawing.Point(4, 22);
            this.tab_sales.Name = "tab_sales";
            this.tab_sales.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sales.Size = new System.Drawing.Size(1024, 723);
            this.tab_sales.TabIndex = 3;
            this.tab_sales.Text = "Sales";
            this.tab_sales.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.emp_list);
            this.groupBox1.Location = new System.Drawing.Point(673, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 561);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtering";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // emp_list
            // 
            this.emp_list.FormattingEnabled = true;
            this.emp_list.Location = new System.Drawing.Point(146, 19);
            this.emp_list.Name = "emp_list";
            this.emp_list.Size = new System.Drawing.Size(176, 364);
            this.emp_list.TabIndex = 1;
            // 
            // dgv_sold_ro
            // 
            this.dgv_sold_ro.AllowUserToAddRows = false;
            this.dgv_sold_ro.AutoGenerateColumns = false;
            this.dgv_sold_ro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sold_ro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpriceDataGridViewTextBoxColumn,
            this.idsalesforceDataGridViewTextBoxColumn,
            this.id_sales_force,
            this.amountDataGridViewTextBoxColumn2});
            this.dgv_sold_ro.DataSource = this.soldBindingSource;
            this.dgv_sold_ro.Location = new System.Drawing.Point(0, 0);
            this.dgv_sold_ro.Name = "dgv_sold_ro";
            this.dgv_sold_ro.ReadOnly = true;
            this.dgv_sold_ro.Size = new System.Drawing.Size(614, 723);
            this.dgv_sold_ro.TabIndex = 0;
            // 
            // idpriceDataGridViewTextBoxColumn
            // 
            this.idpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idpriceDataGridViewTextBoxColumn.DataPropertyName = "id_price";
            this.idpriceDataGridViewTextBoxColumn.DataSource = this.bs_price_not_fk;
            this.idpriceDataGridViewTextBoxColumn.DisplayMember = "price";
            this.idpriceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idpriceDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idpriceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.idpriceDataGridViewTextBoxColumn.Name = "idpriceDataGridViewTextBoxColumn";
            this.idpriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idpriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idpriceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idpriceDataGridViewTextBoxColumn.ValueMember = "id_price";
            // 
            // bs_price_not_fk
            // 
            this.bs_price_not_fk.DataMember = "price";
            this.bs_price_not_fk.DataSource = this.llu;
            // 
            // idsalesforceDataGridViewTextBoxColumn
            // 
            this.idsalesforceDataGridViewTextBoxColumn.DataPropertyName = "id_sales_force";
            this.idsalesforceDataGridViewTextBoxColumn.DataSource = this.bs_sf;
            this.idsalesforceDataGridViewTextBoxColumn.DisplayMember = "name";
            this.idsalesforceDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.idsalesforceDataGridViewTextBoxColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idsalesforceDataGridViewTextBoxColumn.HeaderText = "Name";
            this.idsalesforceDataGridViewTextBoxColumn.Name = "idsalesforceDataGridViewTextBoxColumn";
            this.idsalesforceDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsalesforceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idsalesforceDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.idsalesforceDataGridViewTextBoxColumn.ValueMember = "employee_id";
            // 
            // id_sales_force
            // 
            this.id_sales_force.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_sales_force.DataPropertyName = "id_sales_force";
            this.id_sales_force.DataSource = this.bs_sf;
            this.id_sales_force.DisplayMember = "surname";
            this.id_sales_force.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.id_sales_force.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.id_sales_force.HeaderText = "Surname";
            this.id_sales_force.Name = "id_sales_force";
            this.id_sales_force.ReadOnly = true;
            this.id_sales_force.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_sales_force.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.id_sales_force.ValueMember = "employee_id";
            // 
            // amountDataGridViewTextBoxColumn2
            // 
            this.amountDataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.amountDataGridViewTextBoxColumn2.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn2.Name = "amountDataGridViewTextBoxColumn2";
            this.amountDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "sold";
            this.soldBindingSource.DataSource = this.llu;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dgv_index);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1024, 723);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Index";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.index_range);
            this.groupBox2.Controls.Add(this.dgv_fake_index);
            this.groupBox2.Controls.Add(this.options_index);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Controls.Add(this.d_index);
            this.groupBox2.Location = new System.Drawing.Point(626, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(398, 723);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtering";
            // 
            // index_range
            // 
            this.index_range.Controls.Add(this.groupBox3);
            this.index_range.Controls.Add(this.label7);
            this.index_range.Controls.Add(this.label5);
            this.index_range.Controls.Add(this.checkBox4);
            this.index_range.Controls.Add(this.checkBox3);
            this.index_range.Controls.Add(this.checkBox2);
            this.index_range.Controls.Add(this.n_index_up);
            this.index_range.Controls.Add(this.checkBox1);
            this.index_range.Location = new System.Drawing.Point(6, 119);
            this.index_range.Name = "index_range";
            this.index_range.Size = new System.Drawing.Size(292, 117);
            this.index_range.TabIndex = 7;
            this.index_range.TabStop = false;
            this.index_range.Text = "Range";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.index_from);
            this.groupBox3.Controls.Add(this.index_to);
            this.groupBox3.Controls.Add(this.n_index_down);
            this.groupBox3.Location = new System.Drawing.Point(186, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(106, 85);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            // 
            // index_from
            // 
            this.index_from.AutoSize = true;
            this.index_from.Location = new System.Drawing.Point(16, 24);
            this.index_from.Name = "index_from";
            this.index_from.Size = new System.Drawing.Size(30, 13);
            this.index_from.TabIndex = 8;
            this.index_from.Text = "from:";
            // 
            // index_to
            // 
            this.index_to.AutoSize = true;
            this.index_to.Location = new System.Drawing.Point(16, 72);
            this.index_to.Name = "index_to";
            this.index_to.Size = new System.Drawing.Size(19, 13);
            this.index_to.TabIndex = 9;
            this.index_to.Text = "to:";
            // 
            // n_index_down
            // 
            this.n_index_down.DecimalPlaces = 3;
            this.n_index_down.Location = new System.Drawing.Point(14, 40);
            this.n_index_down.Name = "n_index_down";
            this.n_index_down.Size = new System.Drawing.Size(92, 20);
            this.n_index_down.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "(Selecting both = Invert Range)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Filter by Amount";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(70, 94);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(58, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Range";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(6, 94);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(58, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Equals";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.checkBox3_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 42);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Less Than";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // n_index_up
            // 
            this.n_index_up.DecimalPlaces = 3;
            this.n_index_up.Location = new System.Drawing.Point(200, 93);
            this.n_index_up.Name = "n_index_up";
            this.n_index_up.Size = new System.Drawing.Size(92, 20);
            this.n_index_up.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "More than";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgv_fake_index
            // 
            this.dgv_fake_index.AutoGenerateColumns = false;
            this.dgv_fake_index.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fake_index.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsoldDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1});
            this.dgv_fake_index.DataSource = this.soldBindingSource;
            this.dgv_fake_index.Location = new System.Drawing.Point(12, 526);
            this.dgv_fake_index.Name = "dgv_fake_index";
            this.dgv_fake_index.Size = new System.Drawing.Size(203, 201);
            this.dgv_fake_index.TabIndex = 4;
            // 
            // idsoldDataGridViewTextBoxColumn
            // 
            this.idsoldDataGridViewTextBoxColumn.DataPropertyName = "id_sold";
            this.idsoldDataGridViewTextBoxColumn.HeaderText = "id_sold";
            this.idsoldDataGridViewTextBoxColumn.Name = "idsoldDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // options_index
            // 
            this.options_index.AutoSize = true;
            this.options_index.Location = new System.Drawing.Point(165, 22);
            this.options_index.Name = "options_index";
            this.options_index.Size = new System.Drawing.Size(89, 17);
            this.options_index.TabIndex = 7;
            this.options_index.Text = "More Options";
            this.options_index.UseVisualStyleBackColor = true;
            this.options_index.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Filter!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // d_index
            // 
            this.d_index.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.d_index.Location = new System.Drawing.Point(260, 19);
            this.d_index.Name = "d_index";
            this.d_index.Size = new System.Drawing.Size(132, 20);
            this.d_index.TabIndex = 1;
            this.d_index.ValueChanged += new System.EventHandler(this.filter_by_date_ValueChanged);
            // 
            // dgv_index
            // 
            this.dgv_index.AutoGenerateColumns = false;
            this.dgv_index.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_index.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_index.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_index.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_index.DataSource = this.sold_recipe_indexBindingSource;
            this.dgv_index.Location = new System.Drawing.Point(8, 3);
            this.dgv_index.Name = "dgv_index";
            this.dgv_index.RowHeadersVisible = false;
            this.dgv_index.Size = new System.Drawing.Size(588, 714);
            this.dgv_index.TabIndex = 0;
            this.dgv_index.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_index_DataError);
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
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
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
            // sold_recipe_indexBindingSource
            // 
            this.sold_recipe_indexBindingSource.DataMember = "sold_recipe_index";
            this.sold_recipe_indexBindingSource.DataSource = this.llu;
            // 
            // sold_recipe_indexBindingSource1
            // 
            this.sold_recipe_indexBindingSource1.DataMember = "sold_recipe_index_fk_1";
            this.sold_recipe_indexBindingSource1.DataSource = this.soldBindingSource;
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
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // soldfk1BindingSource
            // 
            this.soldfk1BindingSource.DataMember = "sold_fk_1";
            this.soldfk1BindingSource.DataSource = this.bs_sf;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 776);
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
            ((System.ComponentModel.ISupportInitialize)(this.bs_sf)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_sales.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sold_ro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_price_not_fk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.index_range.ResumeLayout(false);
            this.index_range.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.n_index_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.n_index_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fake_index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_index)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sold_recipe_indexBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldfk1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgv_fake_index;

        private System.Windows.Forms.DataGridViewTextBoxColumn idsoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label label7;

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
        private System.Windows.Forms.BindingSource soldBindingSource;
        private System.Windows.Forms.DataGridView dgv_index;
        private System.Windows.Forms.BindingSource sold_recipe_indexBindingSource;
        private System.Windows.Forms.BindingSource bs_sf;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.BindingSource sold_recipe_indexBindingSource1;
        private System.Windows.Forms.DateTimePicker d_index;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown n_index_up;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown n_index_down;
        private System.Windows.Forms.GroupBox index_range;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label index_to;
        private System.Windows.Forms.Label index_from;
        private System.Windows.Forms.CheckBox options_index;
        private System.Windows.Forms.BindingSource soldfk1BindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox emp_list;
        private System.Windows.Forms.DataGridView dgv_sold_ro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bs_price_not_fk;
        private System.Windows.Forms.DataGridViewComboBoxColumn idpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn idsalesforceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn id_sales_force;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

