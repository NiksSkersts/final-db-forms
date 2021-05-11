//https://www.oreilly.com/library/view/adonet-in-a/0596003617/ch13s02.html
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_db_forms.Forms
{
    public partial class Add_Sale : Form
    {
        llu.soldRow row;
        llu.sold_recipe_indexRow newRow;
        #region(declare)
        private int prev_sold_row_index;
        private llu llu;
        private BindingSource name_of_breadBindingSource;
        private IContainer components;
        private lluTableAdapters.name_of_breadTableAdapter name_of_breadTableAdapter;
        private lluTableAdapters.TableAdapterManager tableAdapterManager;
        private lluTableAdapters.recipesTableAdapter recipesTableAdapter;
        private DataGridView dgv_nob;
        private BindingSource recipesBindingSource;
        private lluTableAdapters.soldTableAdapter soldTableAdapter;
        private BindingSource soldBindingSource;
        private lluTableAdapters.priceTableAdapter priceTableAdapter;
        private BindingSource priceBindingSource;
        private lluTableAdapters.sales_forceTableAdapter sales_forceTableAdapter;
        private DataGridView dgv_price;
        private BindingSource pricefkBindingSource;
        private lluTableAdapters.TableAdapterManager tableAdapterManager1;
        private BindingSource sales_forceBindingSource;
        private DataGridView dgv_sf;
        private NumericUpDown num_kg;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton2;
        private Label label1;
        private DataGridViewTextBoxColumn id_price;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn id_n_o_b;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private readonly lluTableAdapters.TableAdapterManager ta_llu;
        #endregion
        public Add_Sale(lluTableAdapters.TableAdapterManager ta)
        {
            InitializeComponent();
            ta_llu = ta;
        }

        private void Add_Sale_Load(object sender, EventArgs e)
        {
            this.name_of_breadTableAdapter.Fill(this.llu.name_of_bread);
            this.priceTableAdapter.Fill(this.llu.price);
            this.sales_forceTableAdapter.Fill(this.llu.sales_force);
            this.recipesTableAdapter.Fill(this.llu.recipes);
            this.soldTableAdapter.Fill(this.llu.sold);
        }
        private int add_row_sold()
        {
            row = llu.sold.NewsoldRow();
            row.amount = get_kg();
            row.id_price = get_price_id();
            row.id_sales_force = get_emp_id();
            llu.sold.AddsoldRow(row);
            return (int)llu.sold.AsEnumerable().Last().ItemArray[0];
        }
        private int add_row_index()
        {
            prev_sold_row_index = add_row_sold();
            newRow = llu.sold_recipe_index.Newsold_recipe_indexRow();
            newRow.id_sold = prev_sold_row_index;
            newRow.id_n_o_b = get_nob();
            newRow.date = DateTime.Now;
            llu.sold_recipe_index.Addsold_recipe_indexRow(newRow);
            return (int)llu.sold_recipe_index.AsEnumerable().Last().ItemArray[0];
        }
        private int get_nob() => (int)dgv_nob.Rows[dgv_nob.CurrentRow.Index].Cells[0].Value;
        private int get_emp_id() => (int)dgv_sf.Rows[dgv_sf.CurrentRow.Index].Cells[0].Value;
        private int get_price_id() => (int)dgv_price.Rows[dgv_price.CurrentRow.Index].Cells[0].Value;
        private double get_kg() => (double)num_kg.Value;

        private void toolStripButton1_Click(object sender, EventArgs e)//wq
        {
            ta_llu.UpdateAll(llu);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//add
        {
            add_row_index();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//del
        {
            llu.sold_recipe_index.Removesold_recipe_indexRow(newRow);
            llu.sold.RemovesoldRow(row);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.llu = new final_db_forms.llu();
            this.name_of_breadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name_of_breadTableAdapter = new final_db_forms.lluTableAdapters.name_of_breadTableAdapter();
            this.tableAdapterManager = new final_db_forms.lluTableAdapters.TableAdapterManager();
            this.priceTableAdapter = new final_db_forms.lluTableAdapters.priceTableAdapter();
            this.recipesTableAdapter = new final_db_forms.lluTableAdapters.recipesTableAdapter();
            this.sales_forceTableAdapter = new final_db_forms.lluTableAdapters.sales_forceTableAdapter();
            this.soldTableAdapter = new final_db_forms.lluTableAdapters.soldTableAdapter();
            this.dgv_nob = new System.Windows.Forms.DataGridView();
            this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_price = new System.Windows.Forms.DataGridView();
            this.pricefkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new final_db_forms.lluTableAdapters.TableAdapterManager();
            this.sales_forceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_sf = new System.Windows.Forms.DataGridView();
            this.num_kg = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.id_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_n_o_b = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.llu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_of_breadBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricefkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_forceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kg)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // llu
            // 
            this.llu.DataSetName = "llu";
            this.llu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // name_of_breadBindingSource
            // 
            this.name_of_breadBindingSource.DataMember = "name_of_bread";
            this.name_of_breadBindingSource.DataSource = this.llu;
            // 
            // name_of_breadTableAdapter
            // 
            this.name_of_breadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.food_categoriesTableAdapter = null;
            this.tableAdapterManager.ingredientsTableAdapter = null;
            this.tableAdapterManager.name_of_breadTableAdapter = this.name_of_breadTableAdapter;
            this.tableAdapterManager.nep_ingredientsTableAdapter = null;
            this.tableAdapterManager.positionsTableAdapter = null;
            this.tableAdapterManager.priceTableAdapter = this.priceTableAdapter;
            this.tableAdapterManager.recipesTableAdapter = this.recipesTableAdapter;
            this.tableAdapterManager.sales_forceTableAdapter = this.sales_forceTableAdapter;
            this.tableAdapterManager.sold_recipe_indexTableAdapter = null;
            this.tableAdapterManager.soldTableAdapter = this.soldTableAdapter;
            this.tableAdapterManager.UpdateOrder = final_db_forms.lluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // soldTableAdapter
            // 
            this.soldTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_nob
            // 
            this.dgv_nob.AutoGenerateColumns = false;
            this.dgv_nob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_n_o_b,
            this.dataGridViewTextBoxColumn2});
            this.dgv_nob.DataSource = this.name_of_breadBindingSource;
            this.dgv_nob.Location = new System.Drawing.Point(12, 38);
            this.dgv_nob.Name = "dgv_nob";
            this.dgv_nob.Size = new System.Drawing.Size(300, 606);
            this.dgv_nob.TabIndex = 1;
            // 
            // recipesBindingSource
            // 
            this.recipesBindingSource.DataMember = "recipes";
            this.recipesBindingSource.DataSource = this.llu;
            // 
            // soldBindingSource
            // 
            this.soldBindingSource.DataMember = "sold";
            this.soldBindingSource.DataSource = this.llu;
            // 
            // priceBindingSource
            // 
            this.priceBindingSource.DataMember = "price";
            this.priceBindingSource.DataSource = this.llu;
            // 
            // dgv_price
            // 
            this.dgv_price.AutoGenerateColumns = false;
            this.dgv_price.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_price.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_price,
            this.dataGridViewTextBoxColumn12});
            this.dgv_price.DataSource = this.pricefkBindingSource;
            this.dgv_price.Location = new System.Drawing.Point(318, 38);
            this.dgv_price.Name = "dgv_price";
            this.dgv_price.Size = new System.Drawing.Size(300, 220);
            this.dgv_price.TabIndex = 3;
            // 
            // pricefkBindingSource
            // 
            this.pricefkBindingSource.DataMember = "price_fk";
            this.pricefkBindingSource.DataSource = this.name_of_breadBindingSource;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.food_categoriesTableAdapter = null;
            this.tableAdapterManager1.ingredientsTableAdapter = null;
            this.tableAdapterManager1.name_of_breadTableAdapter = null;
            this.tableAdapterManager1.nep_ingredientsTableAdapter = null;
            this.tableAdapterManager1.positionsTableAdapter = null;
            this.tableAdapterManager1.priceTableAdapter = null;
            this.tableAdapterManager1.recipesTableAdapter = null;
            this.tableAdapterManager1.sales_forceTableAdapter = null;
            this.tableAdapterManager1.sold_recipe_indexTableAdapter = null;
            this.tableAdapterManager1.soldTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = final_db_forms.lluTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sales_forceBindingSource
            // 
            this.sales_forceBindingSource.DataMember = "sales_force";
            this.sales_forceBindingSource.DataSource = this.llu;
            // 
            // dgv_sf
            // 
            this.dgv_sf.AutoGenerateColumns = false;
            this.dgv_sf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dgv_sf.DataSource = this.sales_forceBindingSource;
            this.dgv_sf.Location = new System.Drawing.Point(318, 264);
            this.dgv_sf.Name = "dgv_sf";
            this.dgv_sf.Size = new System.Drawing.Size(300, 380);
            this.dgv_sf.TabIndex = 3;
            // 
            // num_kg
            // 
            this.num_kg.DecimalPlaces = 3;
            this.num_kg.Location = new System.Drawing.Point(12, 12);
            this.num_kg.Name = "num_kg";
            this.num_kg.Size = new System.Drawing.Size(120, 20);
            this.num_kg.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 662);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(694, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 22);
            this.toolStripButton1.Text = "Save and Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(92, 22);
            this.toolStripButton3.Text = "Delete Last Sale";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton2.Text = "Add Sale";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add amount sold";
            // 
            // id_price
            // 
            this.id_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_price.DataPropertyName = "id_price";
            this.id_price.HeaderText = "id_price";
            this.id_price.Name = "id_price";
            this.id_price.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn12.DataPropertyName = "price";
            this.dataGridViewTextBoxColumn12.HeaderText = "Price";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // id_n_o_b
            // 
            this.id_n_o_b.DataPropertyName = "id_n_o_b";
            this.id_n_o_b.HeaderText = "id_n_o_b";
            this.id_n_o_b.Name = "id_n_o_b";
            this.id_n_o_b.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Add_Sale
            // 
            this.ClientSize = new System.Drawing.Size(694, 687);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num_kg);
            this.Controls.Add(this.dgv_sf);
            this.Controls.Add(this.dgv_price);
            this.Controls.Add(this.dgv_nob);
            this.Name = "Add_Sale";
            this.Load += new System.EventHandler(this.Add_Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.llu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_of_breadBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soldBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricefkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sales_forceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_kg)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
