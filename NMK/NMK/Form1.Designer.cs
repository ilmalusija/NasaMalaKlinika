namespace NMK
{
    partial class Form1
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
            this.porukaDobrodoslice = new System.Windows.Forms.Label();
            this.PrijavaKao = new System.Windows.Forms.Label();
            this.izborPrijave = new System.Windows.Forms.ComboBox();
            this.izlaz = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomoćToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.analitičkiPodaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // porukaDobrodoslice
            // 
            this.porukaDobrodoslice.AutoSize = true;
            this.porukaDobrodoslice.Font = new System.Drawing.Font("Cambria", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.porukaDobrodoslice.ForeColor = System.Drawing.Color.FloralWhite;
            this.porukaDobrodoslice.Location = new System.Drawing.Point(43, 36);
            this.porukaDobrodoslice.Name = "porukaDobrodoslice";
            this.porukaDobrodoslice.Size = new System.Drawing.Size(533, 41);
            this.porukaDobrodoslice.TabIndex = 0;
            this.porukaDobrodoslice.Text = "Dobro došli u Našu Malu Kliniku!";
            this.porukaDobrodoslice.Click += new System.EventHandler(this.porukaDobrodoslice_Click);
            // 
            // PrijavaKao
            // 
            this.PrijavaKao.AutoSize = true;
            this.PrijavaKao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PrijavaKao.Location = new System.Drawing.Point(62, 195);
            this.PrijavaKao.Name = "PrijavaKao";
            this.PrijavaKao.Size = new System.Drawing.Size(0, 29);
            this.PrijavaKao.TabIndex = 1;
            // 
            // izborPrijave
            // 
            this.izborPrijave.BackColor = System.Drawing.SystemColors.Window;
            this.izborPrijave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izborPrijave.FormattingEnabled = true;
            this.izborPrijave.ItemHeight = 16;
            this.izborPrijave.Items.AddRange(new object[] {
            "Doktor",
            "Medicinski tehničar",
            "Pacijent",
            "Administrator"});
            this.izborPrijave.Location = new System.Drawing.Point(206, 220);
            this.izborPrijave.Name = "izborPrijave";
            this.izborPrijave.Size = new System.Drawing.Size(200, 24);
            this.izborPrijave.TabIndex = 6;
            this.izborPrijave.Text = "Prijavite se kao...";
            this.izborPrijave.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // izlaz
            // 
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.izlaz.Location = new System.Drawing.Point(239, 290);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(111, 42);
            this.izlaz.TabIndex = 7;
            this.izlaz.Text = "Izlaz";
            this.izlaz.UseVisualStyleBackColor = true;
            this.izlaz.Click += new System.EventHandler(this.izlaz_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomoćToolStripMenuItem,
            this.analitičkiPodaciToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(651, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // pomoćToolStripMenuItem
            // 
            this.pomoćToolStripMenuItem.Name = "pomoćToolStripMenuItem";
            this.pomoćToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomoćToolStripMenuItem.Text = "Pomoć";
            this.pomoćToolStripMenuItem.Click += new System.EventHandler(this.pomoćToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 364);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // analitičkiPodaciToolStripMenuItem
            // 
            this.analitičkiPodaciToolStripMenuItem.Name = "analitičkiPodaciToolStripMenuItem";
            this.analitičkiPodaciToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.analitičkiPodaciToolStripMenuItem.Text = "Analitički podaci";
            this.analitičkiPodaciToolStripMenuItem.Click += new System.EventHandler(this.analitičkiPodaciToolStripMenuItem_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GreenYellow;
            this.ClientSize = new System.Drawing.Size(651, 386);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.izborPrijave);
            this.Controls.Add(this.PrijavaKao);
            this.Controls.Add(this.porukaDobrodoslice);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe Script", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Navy;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Naša Mala Klinika";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label porukaDobrodoslice;
        private System.Windows.Forms.Label PrijavaKao;
        private System.Windows.Forms.ComboBox izborPrijave;
        private System.Windows.Forms.Button izlaz;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomoćToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem analitičkiPodaciToolStripMenuItem;
    }
}

