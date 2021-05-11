//Used Sources (to recheck later, if need arises)
// https://www.c-sharpcorner.com/blogs/perform-drag-and-drop-operation-on-treeview-node-in-c-sharp-net
// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.treeview.expandall?view=net-5.0
// https://estudijas.llu.lv/pluginfile.php/95045/mod_resource/content/0/TreeView_all_postgresql.pdf
// https://github.com/NiksSkersts/Programming-II/blob/master/tree_view/Form1.cs
// https://stackoverflow.com/questions/18384485/linq-select-all-items-matching-array
// https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where?view=net-5.0
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace final_db_forms.Forms
{
    public partial class Hierarchy : Form
    {
        private int index_number;
        private TreeView tv;
        private System.ComponentModel.IContainer components;
        private DataGridView dgv_sf;
        private llu ds;
        private ToolStrip toolStrip2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private BindingSource bssf;
        private BindingSource bspos;
        private lluTableAdapters.sales_forceTableAdapter sales_forceTableAdapter;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn posi;
        private readonly lluTableAdapters.TableAdapterManager tads;

        public Hierarchy(llu _ds,lluTableAdapters.TableAdapterManager ta_ds)
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
        private void CreateNodes(IEnumerable<llu.positionsRow> @dt, TreeNodeCollection nodes)
        {
            foreach (var dr1 in dt)
            {
                var tn = new TreeNode
                {
                    Text = dr1.name.ToString(),
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
            if (tv.Nodes!=null)
            {
                tv.Nodes.Clear();
            }
            SubLevel(0, null)
        ;
        }
        private void tv_hierarchy_ItemDrag(object sender, ItemDragEventArgs e){if (e.Button == MouseButtons.Left) DoDragDrop(e.Item, DragDropEffects.Move);}
        private void tv_hierarchy_DragDrop(object sender, DragEventArgs e)
        {
            var targetPoint = tv.PointToClient(new Point(e.X, e.Y));
            var targetNode = tv.GetNodeAt(targetPoint);
            var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }
                targetNode.Expand();
            }
        }
        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;
            return ContainsNode(node1, node2.Parent);
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
            this.sales_forceTableAdapter.Fill(this.ds.sales_force);
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
            int index;
            if (tv.SelectedNode == null)
            {
                index = 0;
            }
            else
            {
                index = ds.positions.FindByid_position(Convert.ToInt32(tv.SelectedNode.Name)).id_r;
            }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hierarchy));
            this.tv = new System.Windows.Forms.TreeView();
            this.dgv_sf = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.posi = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bspos = new System.Windows.Forms.BindingSource(this.components);
            this.bssf = new System.Windows.Forms.BindingSource(this.components);
            this.ds = new final_db_forms.llu();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.sales_forceTableAdapter = new final_db_forms.lluTableAdapters.sales_forceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bspos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bssf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
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
            this.dgv_sf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sf.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.posi});
            this.dgv_sf.DataSource = this.bssf;
            this.dgv_sf.Location = new System.Drawing.Point(12, 472);
            this.dgv_sf.Name = "dgv_sf";
            this.dgv_sf.Size = new System.Drawing.Size(461, 313);
            this.dgv_sf.TabIndex = 2;
            this.dgv_sf.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgv_sf_CellBeginEdit);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // posi
            // 
            this.posi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.posi.DataPropertyName = "id_position";
            this.posi.DataSource = this.bspos;
            this.posi.HeaderText = "id_position";
            this.posi.Name = "posi";
            this.posi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.posi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bssf
            // 
            this.bssf.DataMember = "sales_force";
            this.bssf.DataSource = this.ds;
            // 
            // ds
            // 
            this.ds.DataSetName = "llu";
            this.ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
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
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
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
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripButton2.Text = "Save and Quit";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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