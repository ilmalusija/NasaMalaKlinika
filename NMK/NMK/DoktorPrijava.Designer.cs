namespace NMK
{
    partial class DoktorPrijava
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
            this.prijava = new System.Windows.Forms.Button();
            this.registracija = new System.Windows.Forms.Button();
            this.izlaz = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prijava
            // 
            this.prijava.BackColor = System.Drawing.Color.FloralWhite;
            this.prijava.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.prijava.Location = new System.Drawing.Point(121, 25);
            this.prijava.Name = "prijava";
            this.prijava.Size = new System.Drawing.Size(134, 58);
            this.prijava.TabIndex = 5;
            this.prijava.Text = "Prijava";
            this.prijava.UseVisualStyleBackColor = false;
            this.prijava.Click += new System.EventHandler(this.button4_Click);
            // 
            // registracija
            // 
            this.registracija.BackColor = System.Drawing.Color.FloralWhite;
            this.registracija.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.registracija.Location = new System.Drawing.Point(121, 110);
            this.registracija.Name = "registracija";
            this.registracija.Size = new System.Drawing.Size(134, 58);
            this.registracija.TabIndex = 6;
            this.registracija.Text = "Registracija";
            this.registracija.UseVisualStyleBackColor = false;
            this.registracija.Click += new System.EventHandler(this.button1_Click);
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.Color.FloralWhite;
            this.izlaz.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(121, 197);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(134, 58);
            this.izlaz.TabIndex = 7;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = false;
            this.izlaz.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // DoktorPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(413, 281);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.registracija);
            this.Controls.Add(this.prijava);
            this.Name = "DoktorPrijava";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.Load += new System.EventHandler(this.DoktorPrijava_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prijava;
        private System.Windows.Forms.Button registracija;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
    }
}