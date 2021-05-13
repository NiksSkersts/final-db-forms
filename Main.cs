using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using final_db_forms.Forms;
using final_db_forms.Properties;

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
            hide_filtering_index();
            init_listbox();
            groupBox3.Visible = false;
        }
        private void init_dgv()
        {
            dgv_index.AutoGenerateColumns = false;
            dataGridViewTextBoxColumn1.Visible = false;
            dgv_fake_index.Visible = false;
            id_n_o_b.Visible = false;
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
        private void hide_filtering_index()
        {
            if (options_index.Checked == false)
            {
                index_range.Visible = false;
            }
            else
            {
                index_range.Visible = true;
            }
        }
        private void reset_filters()
        {
            soldBindingSource.RemoveFilter();
            sold_recipe_indexBindingSource.RemoveFilter();
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
            if (tabControl1.SelectedTab == tabControl1.TabPages[0] || tabControl1.SelectedTab == tabControl1.TabPages[1] || tabControl1.SelectedTab == tabControl1.TabPages[4])
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
            
            ta_llu.UpdateAll(llu);
            reset_filters();

        }
        private void apply_filter_by_date()
        {
            if (options_index.CheckState != CheckState.Checked)
            {
                sold_recipe_indexBindingSource.Filter = $"date = '{d_index.Value.Date}'";
            }
            else { return; }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            hide_filtering_index();
        }
        private void apply_filtering_Index()
        {
            var stringbuilder = "";
            try
            {
                switch (checkBox3.Checked)
                {
                    case true:
                    {
                        soldBindingSource.Filter = $"amount = '{n_index_up.Value}'";
                        var indexes =get_data_from_fake_dgv();
                        plow_through(indexes);
                        break;
                    }
                    default:
                    {
                        switch (checkBox1.Checked)
                        {
                            case true when !checkBox2.Checked:
                            {
                                soldBindingSource.Filter = $"amount > '{n_index_up.Value}'";
                                var indexes =get_data_from_fake_dgv();
                                plow_through(indexes);
                                break;
                            }
                            default:
                            {
                                switch (checkBox2.Checked)
                                {
                                    case true when !checkBox1.Checked:
                                    {
                                        soldBindingSource.Filter = $"amount < '{n_index_up.Value}'";
                                        var indexes =get_data_from_fake_dgv();
                                                    plow_through(indexes);
                                        break;
                                    }
                                    default:
                                    {
                                        switch (checkBox1.Checked)
                                        {
                                            case true when checkBox2.Checked:
                                            {
                                                soldBindingSource.Filter = $"amount > '{n_index_up.Value}' OR amount < {n_index_down.Value}";
                                                var indexes =get_data_from_fake_dgv();
                                                                plow_through(indexes);
                                                break;
                                            }
                                            default:
                                            {
                                                switch (checkBox4.Checked)
                                                {
                                                    case true:
                                                    {
                                                        soldBindingSource.Filter = $"amount > '{n_index_down.Value}' AND amount < {n_index_up.Value}";
                                                        var indexes =get_data_from_fake_dgv();
                                                                            plow_through(indexes);
                                                        break;
                                                    }
                                                }

                                                break;
                                            }
                                        }

                                        break;
                                    }
                                }

                                break;
                            }
                        }

                        break;
                    }
                }
                switch (checkBox1.CheckState)
                {
                    case CheckState.Unchecked when checkBox2.CheckState == CheckState.Unchecked && checkBox3.CheckState == CheckState.Unchecked && checkBox4.CheckState == CheckState.Unchecked:
                        apply_filter_by_date();
                        break;
                    default:
                        sold_recipe_indexBindingSource.Filter = $"date = '{d_index.Value.Date}' AND (" + stringbuilder +")";
                        break;
                }
            }
            catch (Exception e)
            {
                soldBindingSource.RemoveFilter();
                sold_recipe_indexBindingSource.RemoveFilter();
                MessageBox.Show(e.Message);
                
                //MessageBox.Show(Resources.nothing_found);
            }


            int[] get_data_from_fake_dgv()
            {
                var indexes = new int[dgv_fake_index.RowCount-1];
                for(int r = 0; r < dgv_fake_index.RowCount-1; r++)
                {
                    indexes[r]=(int) dgv_fake_index[0, r].Value;
                }

                return indexes;
            }
            void plow_through(int[] indexes)
            {
                foreach (var index in indexes)
                {
                    switch (stringbuilder)
                    {
                        case "":
                            stringbuilder =$"id_sold  = {index} " ;
                            break;
                        default:
                            stringbuilder += $"OR id_sold  = {index} ";
                            break;
                    }
                }
            }
        }
        private void dgv_index_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            soldBindingSource.RemoveFilter();
            sold_recipe_indexBindingSource.RemoveFilter();
            MessageBox.Show(Resources.nothing_found);
            
        }
        private void init_listbox()
        {
            var emps = llu.sales_force.Select(row => row.name + " " + row.surname).ToList();
            foreach (var item in emps)
            {
                emp_list.Items.Add(item);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var stringbuilder = "";
            plow_through(get_emp_id_list());
            soldBindingSource.Filter = stringbuilder;
            void plow_through(int[] indexes)
            {
                foreach (var index in indexes)
                {
                    switch (stringbuilder)
                    {
                        case "":
                            stringbuilder = $"id_sales_force  = {index} ";
                            break;
                        default:
                            stringbuilder += $"OR id_sales_force  = {index} ";
                            break;
                    }
                }
            }
        }
        private int[] get_emp_id_list() 
        {
            int[] id_list = new int[emp_list.CheckedItems.Count];
            if (emp_list.CheckedItems.Count != 0)
            {
                var arr = new string[emp_list.CheckedItems.Count];

                for (int i = 0; i < emp_list.CheckedItems.Count; i++)
                {
                    arr[i] = emp_list.CheckedItems[i].ToString();
                }
                var id_arr = llu.sales_force.Select(id => (id.name + " " + id.surname))
                    .ToArray();
                var common = arr.Intersect(id_arr);
                int v = 0;
                foreach (var item in llu.sales_force)
                {
                    foreach (var sub in common)
                    {
                        if ((item.name + " " + item.surname) == sub)
                        {
                            id_list[v] = item.employee_id;
                            v++;
                        }
                    }
                }
            }
            return id_list;
        }
        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            auto_check();
        }
        private void auto_check()
        {
            if (checkBox3.CheckState == CheckState.Unchecked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
            if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState==CheckState.Checked)
            {
                groupBox3.Visible = true;
            }
            else if (checkBox4.CheckState==CheckState.Checked)
            {
                groupBox3.Visible = true;
            }
            else
            {
                groupBox3.Visible = false;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            auto_check();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            auto_check();
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            auto_check();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (options_index.CheckState==CheckState.Checked)
                {
                    apply_filtering_Index();
                }
                else
                {
                    apply_filter_by_date();
                }
            }
            catch
            {
                reset_filters();
            }
        }
    }
}