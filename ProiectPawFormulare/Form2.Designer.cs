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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.salvareProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citireProduseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxProduse = new System.Windows.Forms.ListBox();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 108);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 120);
            this.textBox1.TabIndex = 0;
            
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareProduseToolStripMenuItem,
            this.citireProduseToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(198, 48);
            // 
            // salvareProduseToolStripMenuItem
            // 
            this.salvareProduseToolStripMenuItem.Name = "salvareProduseToolStripMenuItem";
            this.salvareProduseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.salvareProduseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salvareProduseToolStripMenuItem.Text = "Salvare produse";
            this.salvareProduseToolStripMenuItem.Click += new System.EventHandler(this.salvareProduseToolStripMenuItem_Click);
            // 
            // citireProduseToolStripMenuItem
            // 
            this.citireProduseToolStripMenuItem.Name = "citireProduseToolStripMenuItem";
            this.citireProduseToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.citireProduseToolStripMenuItem.Text = "Citire produse";
            this.citireProduseToolStripMenuItem.Click += new System.EventHandler(this.citireProduseToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 19);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adauga Tranzactie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxProduse
            // 
            this.listBoxProduse.ContextMenuStrip = this.contextMenuStrip2;
            this.listBoxProduse.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.listBoxProduse.FormattingEnabled = true;
            this.listBoxProduse.Location = new System.Drawing.Point(263, 120);
            this.listBoxProduse.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxProduse.Name = "listBoxProduse";
            this.listBoxProduse.Size = new System.Drawing.Size(209, 108);
            this.listBoxProduse.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.listBoxProduse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxProduse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem salvareProduseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citireProduseToolStripMenuItem;
    }
}