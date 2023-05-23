namespace ProiectPawFormulare
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.codPTb = new System.Windows.Forms.TextBox();
            this.cantTB = new System.Windows.Forms.TextBox();
            this.dataTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // codPTb
            // 
            this.codPTb.Location = new System.Drawing.Point(198, 87);
            this.codPTb.Name = "codPTb";
            this.codPTb.Size = new System.Drawing.Size(100, 26);
            this.codPTb.TabIndex = 0;
            // 
            // cantTB
            // 
            this.cantTB.Location = new System.Drawing.Point(189, 198);
            this.cantTB.Name = "cantTB";
            this.cantTB.Size = new System.Drawing.Size(100, 26);
            this.cantTB.TabIndex = 1;
            // 
            // dataTb
            // 
            this.dataTb.Location = new System.Drawing.Point(198, 150);
            this.dataTb.Name = "dataTb";
            this.dataTb.Size = new System.Drawing.Size(100, 26);
            this.dataTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cod produs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantitate produs:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data tranzactie:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Adauga tranzactie:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(360, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Vizulizare Tranzactii";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(668, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 40);
            this.button4.TabIndex = 10;
            this.button4.Text = "Printeaza tranzactia";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form3
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(927, 490);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataTb);
            this.Controls.Add(this.cantTB);
            this.Controls.Add(this.codPTb);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form3";
            this.Text = "Form3";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form3_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form3_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codPTb;
        private System.Windows.Forms.TextBox cantTB;
        private System.Windows.Forms.TextBox dataTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}