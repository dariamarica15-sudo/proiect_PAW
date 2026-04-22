namespace proiect
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
            this.btnAdaugaFurnizor = new System.Windows.Forms.Button();
            this.btnSelecteazaMateriale = new System.Windows.Forms.Button();
            this.btnAdaugaContract = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.furnizoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contracteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvareFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deschideFisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdaugaFurnizor
            // 
            this.btnAdaugaFurnizor.Location = new System.Drawing.Point(303, 150);
            this.btnAdaugaFurnizor.Name = "btnAdaugaFurnizor";
            this.btnAdaugaFurnizor.Size = new System.Drawing.Size(207, 32);
            this.btnAdaugaFurnizor.TabIndex = 0;
            this.btnAdaugaFurnizor.Text = "Adauga Furnizor";
            this.btnAdaugaFurnizor.UseVisualStyleBackColor = true;
            this.btnAdaugaFurnizor.Click += new System.EventHandler(this.btnAdaugaFurnizor_Click);
            // 
            // btnSelecteazaMateriale
            // 
            this.btnSelecteazaMateriale.Location = new System.Drawing.Point(303, 219);
            this.btnSelecteazaMateriale.Name = "btnSelecteazaMateriale";
            this.btnSelecteazaMateriale.Size = new System.Drawing.Size(207, 32);
            this.btnSelecteazaMateriale.TabIndex = 1;
            this.btnSelecteazaMateriale.Text = "Selecteaza Materiale";
            this.btnSelecteazaMateriale.UseVisualStyleBackColor = true;
            this.btnSelecteazaMateriale.Click += new System.EventHandler(this.btnSelecteazaMateriale_Click);
            // 
            // btnAdaugaContract
            // 
            this.btnAdaugaContract.Location = new System.Drawing.Point(303, 290);
            this.btnAdaugaContract.Name = "btnAdaugaContract";
            this.btnAdaugaContract.Size = new System.Drawing.Size(207, 32);
            this.btnAdaugaContract.TabIndex = 2;
            this.btnAdaugaContract.Text = "Adauga Contract";
            this.btnAdaugaContract.UseVisualStyleBackColor = true;
            this.btnAdaugaContract.Click += new System.EventHandler(this.btnAdaugaContract_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.furnizoriToolStripMenuItem,
            this.materialeToolStripMenuItem,
            this.contracteToolStripMenuItem,
            this.salvareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // furnizoriToolStripMenuItem
            // 
            this.furnizoriToolStripMenuItem.Name = "furnizoriToolStripMenuItem";
            this.furnizoriToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.furnizoriToolStripMenuItem.Text = "Furnizori";
            this.furnizoriToolStripMenuItem.Click += new System.EventHandler(this.furnizoriToolStripMenuItem_Click);
            // 
            // materialeToolStripMenuItem
            // 
            this.materialeToolStripMenuItem.Name = "materialeToolStripMenuItem";
            this.materialeToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.materialeToolStripMenuItem.Text = "Materiale";
            this.materialeToolStripMenuItem.Click += new System.EventHandler(this.materialeToolStripMenuItem_Click_1);
            // 
            // contracteToolStripMenuItem
            // 
            this.contracteToolStripMenuItem.Name = "contracteToolStripMenuItem";
            this.contracteToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.contracteToolStripMenuItem.Text = "Contracte";
            this.contracteToolStripMenuItem.Click += new System.EventHandler(this.contracteToolStripMenuItem_Click);
            // 
            // salvareToolStripMenuItem
            // 
            this.salvareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvareFisierToolStripMenuItem,
            this.deschideFisierToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            this.salvareToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.salvareToolStripMenuItem.Text = "Salvare";
            this.salvareToolStripMenuItem.Click += new System.EventHandler(this.salvareToolStripMenuItem_Click);
            // 
            // salvareFisierToolStripMenuItem
            // 
            this.salvareFisierToolStripMenuItem.Name = "salvareFisierToolStripMenuItem";
            this.salvareFisierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salvareFisierToolStripMenuItem.Text = "Salvare fisier";
            this.salvareFisierToolStripMenuItem.Click += new System.EventHandler(this.salvareFisierToolStripMenuItem_Click);
            // 
            // deschideFisierToolStripMenuItem
            // 
            this.deschideFisierToolStripMenuItem.Name = "deschideFisierToolStripMenuItem";
            this.deschideFisierToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deschideFisierToolStripMenuItem.Text = "Deschide fisier";
            this.deschideFisierToolStripMenuItem.Click += new System.EventHandler(this.deschideFisierToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugaContract);
            this.Controls.Add(this.btnSelecteazaMateriale);
            this.Controls.Add(this.btnAdaugaFurnizor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdaugaFurnizor;
        private System.Windows.Forms.Button btnSelecteazaMateriale;
        private System.Windows.Forms.Button btnAdaugaContract;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem furnizoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materialeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contracteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvareFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deschideFisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

