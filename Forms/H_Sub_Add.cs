using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using final_db_forms.lluTableAdapters;

namespace final_db_forms.Forms
{
    public class H_Sub_Add : Form
    {
        readonly int r;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private ToolStrip toolStrip1;
        private llu llu_db;
        private positionsTableAdapter positionsTableAdapter;
        private ToolStripButton toolStripButton1;
        public H_Sub_Add(int _index)
        {
            InitializeComponent();
            r = _index;
        }
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            var row = llu_db.positions.NewpositionsRow();
            if (checkBox1.Checked != true) { row.id_r = r; } else { row.id_r = r + 1; }
            row.name = textBox1.Text;
            llu_db.positions.AddpositionsRow(row);
            positionsTableAdapter.Update(llu_db.positions);
            Close();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(H_Sub_Add));
            textBox1 = new TextBox();
            label1 = new Label();
            checkBox1 = new CheckBox();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            llu_db = new llu();
            positionsTableAdapter = new positionsTableAdapter();
            toolStrip1.SuspendLayout();
            ((ISupportInitialize)(llu_db)).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(147, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 20);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 15);
            label1.Name = "label1";
            label1.Size = new Size(73, 13);
            label1.TabIndex = 1;
            label1.Text = @"Position name";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(167, 38);
            checkBox1.Name = "checkBox1";
            checkBox1.RightToLeft = RightToLeft.Yes;
            checkBox1.Size = new Size(83, 17);
            checkBox1.TabIndex = 2;
            checkBox1.Text = @"Subordinate";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.Items.AddRange(new ToolStripItem[] {
            toolStripButton1});
            toolStrip1.Location = new Point(0, 82);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.RightToLeft = RightToLeft.Yes;
            toolStrip1.Size = new Size(292, 25);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = @"toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton1.Image = ((Image)(resources.GetObject("toolStripButton1.Image")));
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.RightToLeft = RightToLeft.Yes;
            toolStripButton1.Size = new Size(82, 22);
            toolStripButton1.Text = @"Save and quit";
            toolStripButton1.Click += toolStripButton1_Click_1;
            // 
            // llu_db
            // 
            llu_db.DataSetName = "llu";
            llu_db.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // positionsTableAdapter
            // 
            positionsTableAdapter.ClearBeforeFill = true;
            // 
            // H_Sub_Add
            // 
            ClientSize = new Size(292, 107);
            Controls.Add(toolStrip1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "H_Sub_Add";
            Load += H_Sub_Add_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((ISupportInitialize)(llu_db)).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        private void H_Sub_Add_Load(object sender, EventArgs e)
        {
            positionsTableAdapter.Fill(llu_db.positions);

        }
    }
}
