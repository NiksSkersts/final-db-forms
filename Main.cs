using System;
using System.Windows.Forms;
using final_db_forms.Forms;

namespace final_db_forms
{
    public partial class Main : Form
    {
        private bool hidden_buttons;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            load_ds();
            init_dgv();
            hidden_buttons=hide_buttons();
        }
        private void init_dgv()
        {
            sold_recipe_indexDataGridView.AutoGenerateColumns = false;
            dataGridViewTextBoxColumn1.Visible = false;
        }
        private void load_ds()
        {
            nep_ingredientsTableAdapter.Fill(llu.nep_ingredients);
            name_of_breadTableAdapter.Fill(llu.name_of_bread);
            priceTableAdapter.Fill(llu.price);
            positionsTableAdapter.Fill(llu.positions);
            food_categoriesTableAdapter.Fill(llu.food_categories);
            ingredientsTableAdapter.Fill(llu.ingredients);
            recipesTableAdapter.Fill(llu.recipes);
            sales_forceTableAdapter.Fill(llu.sales_force);
            soldTableAdapter.Fill(llu.sold);
            sold_recipe_indexTableAdapter.Fill(llu.sold_recipe_index);
        }
        private bool hide_buttons()
        {
            add_emps.Visible = false;
            add_sales.Visible = false;
            return true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ta_llu.UpdateAll(llu);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//add employees
        {
            new Hierarchy(llu,ta_llu).Show();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)//add sales
        {
            var add_sale = new Add_Sale(llu,ta_llu);
            add_sale.Show();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[0] || tabControl1.SelectedTab == tabControl1.TabPages[1])
            {
                if (hidden_buttons!=true)
                {
                    hide_buttons();
                }
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[2])
            {
                add_sales.Visible = false;
                add_emps.Visible = true;
                hidden_buttons = false;
            }
            else if (tabControl1.SelectedTab == tabControl1.TabPages[3])
            {
                add_emps.Visible = false;
                add_sales.Visible = true;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filter_by_date_ValueChanged(object sender, EventArgs e)
        {
            sold_recipe_indexBindingSource.Filter = $"date = '{filter_by_date.Value.Date}'";
        }
    }
}

// private void button_filter_Click(object sender, EventArgs e)
// {
//    if (dataGridView8.SelectedCells.Count > 0)
//    {
//        var selectedrowindex = dataGridView8.SelectedCells[0].RowIndex;
//        var selectedRow = dataGridView8.Rows[selectedrowindex];
//        var cellValue = Convert.ToString(selectedRow.Cells["disposable"].Value);
//        bs_sold.Filter = "id_sales_force =" + cellValue;
//    }
//}

//private void button_index_filter_Click(object sender, EventArgs e)
//{
//    if (dataGridView10.SelectedCells.Count > 0)
//    {
//        var selectedrowindex = dataGridView10.SelectedCells[0].RowIndex;
//        var selectedRow = dataGridView10.Rows[selectedrowindex];
//        var cellValue = Convert.ToString(selectedRow.Cells["id_n_o_b"].Value);
//        bs_index.Filter = "id_sold_recipe_index =" + cellValue;
//    }
//}
