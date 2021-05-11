using final_db_forms.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_db_forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        

        private void Main_Load(object sender, EventArgs e)
        {
            load_ds();
        }
        private void load_ds()
        {
            this.nep_ingredientsTableAdapter.Fill(this.llu.nep_ingredients);
            this.name_of_breadTableAdapter.Fill(this.llu.name_of_bread);
            this.priceTableAdapter.Fill(this.llu.price);
            this.positionsTableAdapter.Fill(this.llu.positions);
            this.food_categoriesTableAdapter.Fill(this.llu.food_categories);
            this.ingredientsTableAdapter.Fill(this.llu.ingredients);
            this.recipesTableAdapter.Fill(this.llu.recipes);
            this.sales_forceTableAdapter.Fill(this.llu.sales_force);
            this.soldTableAdapter.Fill(this.llu.sold);
            this.sold_recipe_indexTableAdapter.Fill(this.llu.sold_recipe_index);
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
            new Add_Sale(ta_llu).Show();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
