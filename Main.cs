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

        private void food_categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.food_categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.llu);

        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'llu.ingredients' table. You can move, or remove it, as needed.
            this.ingredientsTableAdapter.Fill(this.llu.ingredients);
            // TODO: This line of code loads data into the 'llu.recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.llu.recipes);
            // TODO: This line of code loads data into the 'llu.food_categories' table. You can move, or remove it, as needed.
            this.food_categoriesTableAdapter.Fill(this.llu.food_categories);

        }
    }
}
