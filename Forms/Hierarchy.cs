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
        private llu ds;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private BindingSource bssf;
        private BindingSource bspos;
        private sales_forceTableAdapter sales_forceTableAdapter;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn posi;
        private TableAdapterManager tads;

        public Hierarchy(llu _ds,TableAdapterManager ta_ds)
        {
            InitializeComponent();
            ds = _ds;
            tads = ta_ds;
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
            SubLevel(0, null)
        ;
        }
        private void tv_hierarchy_ItemDrag(object sender, ItemDragEventArgs e){if (e.Button == MouseButtons.Left) DoDragDrop(e.Item, DragDropEffects.Move);}
        private void tv_hierarchy_DragDrop(object sender, DragEventArgs e)
        {
            var targetPoint = tv.PointToClient(new Point(e.X, e.Y));
            var targetNode = tv.GetNodeAt(targetPoint);
            var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (draggedNode.Equals(targetNode) || ContainsNode(draggedNode, targetNode)) return;
            if (e.Effect == DragDropEffects.Move)
            {
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
            }
            targetNode.Expand();
        }
        private static bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null) return false;
            return node2.Parent.Equals(node1) || ContainsNode(node1, node2.Parent);
        }
        private void tv_hierarchy_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void tv_hierarchy_DragOver(object sender, DragEventArgs e)
        {
            var targetPoint = tv.PointToClient(new Point(e.X, e.Y));
            tv.SelectedNode = tv.GetNodeAt(targetPoint);
        }
        private void Hierarchy_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds.sales_force' table. You can move, or remove it, as needed.
            sales_forceTableAdapter.Fill(ds.sales_force);
            bssf.DataSource = ds.sales_force;
            bspos.DataSource = ds.positions;
            posi.DataPropertyName = "id_position";
            posi.DataSource = ds.positions;
            posi.DisplayMember = "name";
            posi.ValueMember = "id_position";
            call_update();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var index = tv.SelectedNode == null ? 0 : ds.positions.FindByid_position(Convert.ToInt32(tv.SelectedNode.Name)).id_r;
            new H_Sub_Add(index).Show();
            call_update();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            call_update();
            Close();
        }

        private void InitializeComponent()
        {
            components = new Container();
            var resources = new ComponentResourceManager(typeof(Hierarchy));
            tv = new TreeView();
            dgv_sf = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            surnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            posi = new DataGridViewComboBoxColumn();
            bspos = new BindingSource(components);
            bssf = new BindingSource(components);
            ds = new llu();
            toolStrip2 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            sales_forceTableAdapter = new sales_forceTableAdapter();
            ((ISupportInitialize)(dgv_sf)).BeginInit();
            ((ISupportInitialize)(bspos)).BeginInit();
            ((ISupportInitialize)(bssf)).BeginInit();
            ((ISupportInitialize)(ds)).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // tv
            // 
            tv.Location = new Point(12, 12);
            tv.Name = "tv";
            tv.Size = new Size(461, 454);
            tv.TabIndex = 0;
            tv.NodeMouseClick += tv_NodeMouseClick;
            // 
            // dgv_sf
            // 
            dgv_sf.AutoGenerateColumns = false;
            dgv_sf.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_sf.Columns.AddRange(nameDataGridViewTextBoxColumn, surnameDataGridViewTextBoxColumn, posi);
            dgv_sf.DataSource = bssf;
            dgv_sf.Location = new Point(12, 472);
            dgv_sf.Name = "dgv_sf";
            dgv_sf.Size = new Size(461, 313);
            dgv_sf.TabIndex = 2;
            dgv_sf.CellBeginEdit += dgv_sf_CellBeginEdit;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            nameDataGridViewTextBoxColumn.HeaderText = @"name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            surnameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            surnameDataGridViewTextBoxColumn.HeaderText = @"surname";
            surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // posi
            // 
            posi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            posi.DataPropertyName = "id_position";
            posi.DataSource = bspos;
            posi.HeaderText = @"id_position";
            posi.Name = "posi";
            posi.Resizable = DataGridViewTriState.True;
            posi.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // bssf
            // 
            bssf.DataMember = "sales_force";
            bssf.DataSource = ds;
            // 
            // ds
            // 
            ds.DataSetName = "llu";
            ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip2
            // 
            toolStrip2.Dock = DockStyle.Bottom;
            toolStrip2.Items.AddRange(new ToolStripItem[] {
            toolStripButton1,
            toolStripButton2});
            toolStrip2.Location = new Point(0, 791);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(488, 25);
            toolStrip2.TabIndex = 4;
            toolStrip2.Text = @"toolStrip2";
            // 
            // toolStripButton1
            // 
            toolStripButton1.Alignment = ToolStripItemAlignment.Right;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = ((Image)(resources.GetObject("toolStripButton1.Image")));
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(79, 22);
            toolStripButton1.Text = @"Add Position";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Alignment = ToolStripItemAlignment.Right;
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton2.Image = ((Image)(resources.GetObject("toolStripButton2.Image")));
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(84, 22);
            toolStripButton2.Text = @"Save and Quit";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // sales_forceTableAdapter
            // 
            sales_forceTableAdapter.ClearBeforeFill = true;
            // 
            // Hierarchy
            // 
            ClientSize = new Size(488, 816);
            Controls.Add(toolStrip2);
            Controls.Add(dgv_sf);
            Controls.Add(tv);
            Name = "Hierarchy";
            Load += Hierarchy_Load;
            ((ISupportInitialize)(dgv_sf)).EndInit();
            ((ISupportInitialize)(bspos)).EndInit();
            ((ISupportInitialize)(bssf)).EndInit();
            ((ISupportInitialize)(ds)).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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
    }
}