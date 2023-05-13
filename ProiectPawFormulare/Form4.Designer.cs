namespace ProiectPawFormulare
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.citireFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 8);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(501, 238);
            this.listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireFisierToolStripMenuItem,
            this.stergereFisierToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(291, 101);
            // 
            // citireFisierToolStripMenuItem
            // 
            this.citireFisierToolStripMenuItem.Name = "citireFisierToolStripMenuItem";
            this.citireFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.citireFisierToolStripMenuItem.Size = new System.Drawing.Size(290, 32);
            this.citireFisierToolStripMenuItem.Text = "Citire fisier";
            this.citireFisierToolStripMenuItem.Click += new System.EventHandler(this.citireFisierToolStripMenuItem_Click);
            // 
            // stergereFisierToolStripMenuItem
            // 
            this.stergereFisierToolStripMenuItem.Name = "stergereFisierToolStripMenuItem";
            this.stergereFisierToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.stergereFisierToolStripMenuItem.Size = new System.Drawing.Size(290, 32);
            this.stergereFisierToolStripMenuItem.Text = "Stergere tranzactie";
            this.stergereFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierToolStripMenuItem_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(672, 384);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.Text = "Form4";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stergereFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireFisierToolStripMenuItem;
    }
}