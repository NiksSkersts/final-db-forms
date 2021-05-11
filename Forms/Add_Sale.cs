//https://www.oreilly.com/library/view/adonet-in-a/0596003617/ch13s02.html

using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using final_db_forms.lluTableAdapters;
using final_db_forms.Properties;

namespace final_db_forms.Forms
{
    public class Add_Sale : Form
    {
        private llu.soldRow row;
        private llu.sold_recipe_indexRow newRow;
        #region(declare)
        private int prev_sold_row_index;
        public llu llu;
        private BindingSource name_of_breadBindingSource;
        private IContainer components;
        private name_of_breadTableAdapter name_of_breadTableAdapter;
        private TableAdapterManager tableAdapterManager;
        private recipesTableAdapter recipesTableAdapter;
        private DataGridView dgv_nob;
        private BindingSource recipesBindingSource;
        private soldTableAdapter soldTableAdapter;
        private BindingSource soldBindingSource;
        private priceTableAdapter priceTableAdapter;
        private BindingSource priceBindingSource;
        private sales_forceTableAdapter sales_forceTableAdapter;
        private DataGridView dgv_price;
        private BindingSource pricefkBindingSource;
        private TableAdapterManager tableAdapterManager1;
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
        private readonly TableAdapterManager ta_llu;
        #endregion
        public Add_Sale(llu lludb, TableAdapterManager ta)
        {
            ta_llu = ta;
            llu = lludb;
            InitializeComponent();
        }

        private void Add_Sale_Load(object sender, EventArgs e)
        {
            name_of_breadTableAdapter.Fill(llu.name_of_bread);
            priceTableAdapter.Fill(llu.price);
            sales_forceTableAdapter.Fill(llu.sales_force);
            recipesTableAdapter.Fill(llu.recipes);
            soldTableAdapter.Fill(llu.sold);
        }
        private int add_row_sold()
        {
            row = llu.sold.NewsoldRow();
            var weight = get_kg();
            if (weight>0)
            {
                row.amount = get_kg();
            }
            else
            {
                MessageBox.Show(Resources.weight_val, Resources.bad_val);
                throw new Exception();
            }
            row.id_price = get_price_id();
            row.id_sales_force = get_emp_id();
            llu.sold.AddsoldRow(row);
            return (int)llu.sold.AsEnumerable().Last().ItemArray[0];
        }
        private void add_row_index()
        {
            prev_sold_row_index = add_row_sold();
            newRow = llu.sold_recipe_index.Newsold_recipe_indexRow();
            newRow.id_sold = prev_sold_row_index;
            newRow.id_n_o_b = get_nob();
            newRow.date = DateTime.Now;
            llu.sold_recipe_index.Addsold_recipe_indexRow(newRow);
            //return (int)llu.sold_recipe_index.AsEnumerable().Last().ItemArray[0];
        }
        private int get_nob()
        {
            if (dgv_nob.CurrentRow != null) return (int) dgv_nob.Rows[dgv_nob.CurrentRow.Index].Cells[0].Value;
            throw new InvalidOperationException();
        }

        private int get_emp_id()
        {
            if (dgv_sf.CurrentRow != null) return (int) dgv_sf.Rows[dgv_sf.CurrentRow.Index].Cells[0].Value;
            throw new InvalidOperationException();
        }

        private int get_price_id()
        {
            if (dgv_price.CurrentRow != null) return (int) dgv_price.Rows[dgv_price.CurrentRow.Index].Cells[0].Value;
            throw new InvalidOperationException();
        }

        private double get_kg() => (double)num_kg.Value;

        private void toolStripButton1_Click(object sender, EventArgs e)//wq
        {
            ta_llu.UpdateAll(llu);
            Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//add
        {
            try
            {
                add_row_index();
            }
            catch (Exception message)
            {
                throw new Exception(message.Message);
            }

        }

        private void toolStripButton3_Click(object sender, EventArgs e)//del
        {
            llu.sold_recipe_index.Removesold_recipe_indexRow(newRow);
            llu.sold.RemovesoldRow(row);
        }

        private void InitializeComponent()
        {
            components = new Container();
            name_of_breadBindingSource = new BindingSource(components);
            name_of_breadTableAdapter = new name_of_breadTableAdapter();
            tableAdapterManager = new TableAdapterManager();
            priceTableAdapter = new priceTableAdapter();
            recipesTableAdapter = new recipesTableAdapter();
            sales_forceTableAdapter = new sales_forceTableAdapter();
            soldTableAdapter = new soldTableAdapter();
            dgv_nob = new DataGridView();
            recipesBindingSource = new BindingSource(components);
            soldBindingSource = new BindingSource(components);
            priceBindingSource = new BindingSource(components);
            dgv_price = new DataGridView();
            pricefkBindingSource = new BindingSource(components);
            tableAdapterManager1 = new TableAdapterManager();
            sales_forceBindingSource = new BindingSource(components);
            dgv_sf = new DataGridView();
            num_kg = new NumericUpDown();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            label1 = new Label();
            id_price = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            id_n_o_b = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            ((ISupportInitialize)(llu)).BeginInit();
            ((ISupportInitialize)(name_of_breadBindingSource)).BeginInit();
            ((ISupportInitialize)(dgv_nob)).BeginInit();
            ((ISupportInitialize)(recipesBindingSource)).BeginInit();
            ((ISupportInitialize)(soldBindingSource)).BeginInit();
            ((ISupportInitialize)(priceBindingSource)).BeginInit();
            ((ISupportInitialize)(dgv_price)).BeginInit();
            ((ISupportInitialize)(pricefkBindingSource)).BeginInit();
            ((ISupportInitialize)(sales_forceBindingSource)).BeginInit();
            ((ISupportInitialize)(dgv_sf)).BeginInit();
            ((ISupportInitialize)(num_kg)).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // llu
            // 
            llu.DataSetName = "llu";
            llu.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // name_of_breadBindingSource
            // 
            name_of_breadBindingSource.DataMember = "name_of_bread";
            name_of_breadBindingSource.DataSource = llu;
            // 
            // name_of_breadTableAdapter
            // 
            name_of_breadTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            tableAdapterManager.BackupDataSetBeforeUpdate = false;
            tableAdapterManager.food_categoriesTableAdapter = null;
            tableAdapterManager.ingredientsTableAdapter = null;
            tableAdapterManager.name_of_breadTableAdapter = name_of_breadTableAdapter;
            tableAdapterManager.nep_ingredientsTableAdapter = null;
            tableAdapterManager.positionsTableAdapter = null;
            tableAdapterManager.priceTableAdapter = priceTableAdapter;
            tableAdapterManager.recipesTableAdapter = recipesTableAdapter;
            tableAdapterManager.sales_forceTableAdapter = sales_forceTableAdapter;
            tableAdapterManager.sold_recipe_indexTableAdapter = null;
            tableAdapterManager.soldTableAdapter = soldTableAdapter;
            tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // priceTableAdapter
            // 
            priceTableAdapter.ClearBeforeFill = true;
            // 
            // recipesTableAdapter
            // 
            recipesTableAdapter.ClearBeforeFill = true;
            // 
            // sales_forceTableAdapter
            // 
            sales_forceTableAdapter.ClearBeforeFill = true;
            // 
            // soldTableAdapter
            // 
            soldTableAdapter.ClearBeforeFill = true;
            // 
            // dgv_nob
            // 
            dgv_nob.AutoGenerateColumns = false;
            dgv_nob.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_nob.Columns.AddRange(id_n_o_b, dataGridViewTextBoxColumn2);
            dgv_nob.DataSource = name_of_breadBindingSource;
            dgv_nob.Location = new Point(12, 38);
            dgv_nob.Name = "dgv_nob";
            dgv_nob.Size = new Size(300, 606);
            dgv_nob.TabIndex = 1;
            // 
            // recipesBindingSource
            // 
            recipesBindingSource.DataMember = "recipes";
            recipesBindingSource.DataSource = llu;
            // 
            // soldBindingSource
            // 
            soldBindingSource.DataMember = "sold";
            soldBindingSource.DataSource = llu;
            // 
            // priceBindingSource
            // 
            priceBindingSource.DataMember = "price";
            priceBindingSource.DataSource = llu;
            // 
            // dgv_price
            // 
            dgv_price.AutoGenerateColumns = false;
            dgv_price.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_price.Columns.AddRange(id_price, dataGridViewTextBoxColumn12);
            dgv_price.DataSource = pricefkBindingSource;
            dgv_price.Location = new Point(318, 38);
            dgv_price.Name = "dgv_price";
            dgv_price.Size = new Size(300, 220);
            dgv_price.TabIndex = 3;
            // 
            // pricefkBindingSource
            // 
            pricefkBindingSource.DataMember = "price_fk";
            pricefkBindingSource.DataSource = name_of_breadBindingSource;
            // 
            // tableAdapterManager1
            // 
            tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            tableAdapterManager1.Connection = null;
            tableAdapterManager1.food_categoriesTableAdapter = null;
            tableAdapterManager1.ingredientsTableAdapter = null;
            tableAdapterManager1.name_of_breadTableAdapter = null;
            tableAdapterManager1.nep_ingredientsTableAdapter = null;
            tableAdapterManager1.positionsTableAdapter = null;
            tableAdapterManager1.priceTableAdapter = null;
            tableAdapterManager1.recipesTableAdapter = null;
            tableAdapterManager1.sales_forceTableAdapter = null;
            tableAdapterManager1.sold_recipe_indexTableAdapter = null;
            tableAdapterManager1.soldTableAdapter = null;
            tableAdapterManager1.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sales_forceBindingSource
            // 
            sales_forceBindingSource.DataMember = "sales_force";
            sales_forceBindingSource.DataSource = llu;
            // 
            // dgv_sf
            // 
            dgv_sf.AutoGenerateColumns = false;
            dgv_sf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sf.Columns.AddRange(dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4);
            dgv_sf.DataSource = sales_forceBindingSource;
            dgv_sf.Location = new Point(318, 264);
            dgv_sf.Name = "dgv_sf";
            dgv_sf.Size = new Size(300, 380);
            dgv_sf.TabIndex = 3;
            // 
            // num_kg
            // 
            num_kg.DecimalPlaces = 3;
            num_kg.Location = new Point(12, 12);
            num_kg.Name = "num_kg";
            num_kg.Size = new Size(120, 20);
            num_kg.TabIndex = 4;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] {
            toolStripButton1,
            toolStripButton3,
            toolStripButton2});
            toolStrip1.Location = new Point(0, 662);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RenderMode = ToolStripRenderMode.System;
            toolStrip1.Size = new Size(694, 25);
            toolStrip1.TabIndex = 5;
            toolStrip1.Text = @"toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(80, 22);
            toolStripButton1.Text = Resources.Add_Sale_InitializeComponent_Save_and_Exit;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(92, 22);
            toolStripButton3.Text = @"Delete Last Sale";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(57, 22);
            toolStripButton2.Text = @"Add Sale";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 14);
            label1.Name = "label1";
            label1.Size = new Size(86, 13);
            label1.TabIndex = 6;
            label1.Text = @"Add amount sold";
            // 
            // id_price
            // 
            id_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id_price.DataPropertyName = "id_price";
            id_price.HeaderText = @"id_price";
            id_price.Name = "id_price";
            id_price.Visible = false;
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn12.DataPropertyName = "price";
            dataGridViewTextBoxColumn12.HeaderText = Resources.price;
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // id_n_o_b
            // 
            id_n_o_b.DataPropertyName = "id_n_o_b";
            id_n_o_b.HeaderText = @"id_n_o_b";
            id_n_o_b.Name = "id_n_o_b";
            id_n_o_b.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.DataPropertyName = "name";
            dataGridViewTextBoxColumn2.HeaderText = Resources.name;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            dataGridViewTextBoxColumn1.HeaderText = @"employee_id";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.DataPropertyName = "name";
            dataGridViewTextBoxColumn3.HeaderText = Resources.name;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn4.DataPropertyName = "surname";
            dataGridViewTextBoxColumn4.HeaderText = Resources.surname;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Add_Sale
            // 
            ClientSize = new Size(694, 687);
            Controls.Add(toolStrip1);
            Controls.Add(label1);
            Controls.Add(num_kg);
            Controls.Add(dgv_sf);
            Controls.Add(dgv_price);
            Controls.Add(dgv_nob);
            Name = "Add_Sale";
            Load += Add_Sale_Load;
            ((ISupportInitialize)(llu)).EndInit();
            ((ISupportInitialize)(name_of_breadBindingSource)).EndInit();
            ((ISupportInitialize)(dgv_nob)).EndInit();
            ((ISupportInitialize)(recipesBindingSource)).EndInit();
            ((ISupportInitialize)(soldBindingSource)).EndInit();
            ((ISupportInitialize)(priceBindingSource)).EndInit();
            ((ISupportInitialize)(dgv_price)).EndInit();
            ((ISupportInitialize)(pricefkBindingSource)).EndInit();
            ((ISupportInitialize)(sales_forceBindingSource)).EndInit();
            ((ISupportInitialize)(dgv_sf)).EndInit();
            ((ISupportInitialize)(num_kg)).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }
    }
}
