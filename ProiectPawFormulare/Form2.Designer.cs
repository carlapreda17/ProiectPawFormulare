namespace ProiectPawFormulare
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.citireProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxProduse = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citireProduseToolStripMenuItem,
            this.salvareProduseToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(258, 68);
            // 
            // citireProduseToolStripMenuItem
            // 
            this.citireProduseToolStripMenuItem.Name = "citireProduseToolStripMenuItem";
            this.citireProduseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.citireProduseToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            this.citireProduseToolStripMenuItem.Text = "Citire produse";
            this.citireProduseToolStripMenuItem.Click += new System.EventHandler(this.citireProduseToolStripMenuItem_Click);
            // 
            // salvareProduseToolStripMenuItem
            // 
            this.salvareProduseToolStripMenuItem.Name = "salvareProduseToolStripMenuItem";
            this.salvareProduseToolStripMenuItem.Size = new System.Drawing.Size(257, 32);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adauga Tranzactie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxProduse
            // 
            this.listBoxProduse.AllowDrop = true;
            this.listBoxProduse.ContextMenuStrip = this.contextMenuStrip2;
            this.listBoxProduse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxProduse.FormattingEnabled = true;
            this.listBoxProduse.ItemHeight = 20;
            this.listBoxProduse.Location = new System.Drawing.Point(12, 134);
            this.listBoxProduse.Name = "listBoxProduse";
            this.listBoxProduse.ScrollAlwaysVisible = true;
            this.listBoxProduse.Size = new System.Drawing.Size(813, 284);
            this.listBoxProduse.TabIndex = 5;
            this.listBoxProduse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxProduse_MouseDown);
            this.listBoxProduse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxProduse_MouseDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 449);
            this.Controls.Add(this.listBoxProduse);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxProduse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem salvareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireProduseToolStripMenuItem;
    }
}