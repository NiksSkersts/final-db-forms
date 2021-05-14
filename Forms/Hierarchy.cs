//Used Sources (to recheck later, if need arises)
// https://www.c-sharpcorner.com/blogs/perform-drag-and-drop-operation-on-treeview-node-in-c-sharp-net
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.expandall?view=net-5.0
// https://estudijas.llu.lv/pluginfile.php/95045/mod_resource/content/0/TreeView_all_postgresql.pdf
// https://github.com/NiksSkersts/Programming-II/blob/master/tree_view/Form1.cs
// https://stackoverflow.com/questions/18384485/linq-select-all-items-matching-array
// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-5.0

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using final_db_forms.lluTableAdapters;

namespace final_db_forms.Forms
{
    public class Hierarchy : Form
    {
        private int index_number;
        private TreeView tv;
        private IContainer components;
        private DataGridView dgv_sf;
        public llu ds;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private BindingSource bssf;
        private BindingSource bspos;
        private sales_forceTableAdapter sales_forceTableAdapter;
        private ToolStripButton toolStripButton3;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewComboBoxColumn id_position;
        private TableAdapterManager tads;
        public Hierarchy(llu _ds,TableAdapterManager ta_ds)
        {
            ds = _ds;
            tads = ta_ds;
            InitializeComponent();
        }
        private void SubLevel(int parent_id, TreeNode parentNode)
        {
            if (parent_id == 0)
            {
                CreateNodes(ds.positions.Where(row => row.id_r == parent_id), tv.Nodes);
            }
            else
            {
                CreateNodes(ds.positions.Where(row => row.id_r == parent_id), parentNode.Nodes);
            }
        }
        private void CreateNodes(IEnumerable<llu.positionsRow> dt, TreeNodeCollection nodes)
        {
            foreach (var dr1 in dt)
            {
                var tn = new TreeNode
                {
                    Text = dr1.name,
                    Name = dr1.id_position.ToString()

                };
                nodes.Add(tn);
                SubLevel(Convert.ToInt32(tn.Name), tn);
            }
        }
        private void call_update()
        {
            tads.positionsTableAdapter.Update(ds.positions);
            tads.positionsTableAdapter.Fill(ds.positions);
            tads.sales_forceTableAdapter.Update(ds.sales_force);
            tads.sales_forceTableAdapter.Fill(ds.sales_force);
            tv_refresh();
        }
        private void tv_refresh()
        {
            tv.Nodes.Clear();
            SubLevel(0, null);
        }
        private void Hierarchy_Load(object sender, EventArgs e)
        {
            bssf.DataSource = ds.sales_force;
            bspos.DataSource = ds.positions;
            id_position.DataPropertyName = "id_position";
            id_position.DataSource = ds.positions;
            id_position.DisplayMember = "name";
            id_position.ValueMember = "id_position";
            call_update();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var index = tv.SelectedNode == null ? 0 : ds.positions.FindByid_position(Convert.ToInt32(tv.SelectedNode.Name)).id_r;
            Form frm2 = new H_Sub_Add(index,tads,ds);
            if (frm2.ShowDialog() == DialogResult.OK)
            {
                call_update();
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            call_update();
            Close();
        }
        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tv.ExpandAll();
            if (e.Node.Name != "")
                index_number = Convert.ToInt32(e.Node.Name);

            bssf.Filter = "id_position =" + index_number;
        }
        private void dgv_sf_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dgv_sf.CurrentRow != null)
            {
                dgv_sf.CurrentRow.Cells[2].Value = index_number;
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            call_update();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tv = new System.Windows.Forms.TreeView();
            this.dgv_sf = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_position = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bspos = new System.Windows.Forms.BindingSource(this.components);
            this.bssf = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.sales_forceTableAdapter = new final_db_forms.lluTableAdapters.sales_forceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bspos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssf)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(12, 12);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(461, 454);
            this.tv.TabIndex = 0;
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            // 
            // dgv_sf
            // 
            this.dgv_sf.AutoGenerateColumns = false;
            this.dgv_sf.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgv_sf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname,
            this.id_position});
            this.dgv_sf.DataSource = this.bssf;
            this.dgv_sf.Location = new System.Drawing.Point(12, 472);
            this.dgv_sf.Name = "dgv_sf";
            this.dgv_sf.Size = new System.Drawing.Size(461, 313);
            this.dgv_sf.TabIndex = 2;
            this.dgv_sf.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_sf_CellBeginEdit);
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // surname
            // 
            this.surname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surname.DataPropertyName = "surname";
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            // 
            // id_position
            // 
            this.id_position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id_position.DataPropertyName = "id_position";
            this.id_position.DataSource = this.bspos;
            this.id_position.HeaderText = "Position";
            this.id_position.Name = "id_position";
            this.id_position.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_position.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 791);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(488, 25);
            this.toolStrip2.TabIndex = 4;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Add Position";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "Save and Quit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // sales_forceTableAdapter
            // 
            this.sales_forceTableAdapter.ClearBeforeFill = true;
            // 
            // Hierarchy
            // 
            this.ClientSize = new System.Drawing.Size(488, 816);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgv_sf);
            this.Controls.Add(this.tv);
            this.Name = "Hierarchy";
            this.Load += new System.EventHandler(this.Hierarchy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bspos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssf)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}