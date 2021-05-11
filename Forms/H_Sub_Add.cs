﻿using System;
using System.Windows.Forms;

namespace final_db_forms.Forms
{
    public partial class H_Sub_Add : Form
    {
        readonly int r;
        private TextBox textBox1;
        private Label label1;
        private CheckBox checkBox1;
        private ToolStrip toolStrip1;
        private llu llu_db;
        private lluTableAdapters.positionsTableAdapter positionsTableAdapter;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(H_Sub_Add));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.llu_db = new final_db_forms.llu();
            this.positionsTableAdapter = new final_db_forms.lluTableAdapters.positionsTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llu_db)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Position name";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(167, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(83, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Subordinate";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 82);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(292, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripButton1.Size = new System.Drawing.Size(82, 22);
            this.toolStripButton1.Text = "Save and quit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // llu_db
            // 
            this.llu_db.DataSetName = "llu";
            this.llu_db.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // H_Sub_Add
            // 
            this.ClientSize = new System.Drawing.Size(292, 107);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "H_Sub_Add";
            this.Load += new System.EventHandler(this.H_Sub_Add_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.llu_db)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void H_Sub_Add_Load(object sender, EventArgs e)
        {
            this.positionsTableAdapter.Fill(this.llu_db.positions);

        }
    }
}
