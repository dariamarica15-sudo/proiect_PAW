namespace proiect
{
    partial class EditareMaterial
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
            this.tbPret = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.Cantitate = new System.Windows.Forms.Label();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.tbIdMaterial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(393, 262);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(141, 22);
            this.tbPret.TabIndex = 32;
           // this.tbPret.TextChanged += new System.EventHandler(this.tbPret_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Pret pe Kg";
            //this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(393, 220);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(141, 22);
            this.tbCantitate.TabIndex = 30;
            //this.tbCantitate.TextChanged += new System.EventHandler(this.tbCantitate_TextChanged);
            // 
            // Cantitate
            // 
            this.Cantitate.AutoSize = true;
            this.Cantitate.Location = new System.Drawing.Point(290, 226);
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(90, 16);
            this.Cantitate.TabIndex = 29;
            this.Cantitate.Text = "Cantitate in kg";
           // this.Cantitate.Click += new System.EventHandler(this.Cantitate_Click);
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(393, 167);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(141, 24);
            this.cbMaterial.TabIndex = 28;
            //this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // tbIdMaterial
            // 
            this.tbIdMaterial.Location = new System.Drawing.Point(393, 119);
            this.tbIdMaterial.Name = "tbIdMaterial";
            this.tbIdMaterial.Size = new System.Drawing.Size(141, 22);
            this.tbIdMaterial.TabIndex = 27;
           // this.tbIdMaterial.TextChanged += new System.EventHandler(this.tbIdMaterial_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Material";
            //this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id material";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(502, 340);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(147, 23);
            this.btnRenunta.TabIndex = 34;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(258, 340);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(147, 23);
            this.btnSalveaza.TabIndex = 33;
            this.btnSalveaza.Text = "Salveaza modificarile";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditareMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.tbIdMaterial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EditareMaterial";
            this.Text = "EditareMaterial";
            //this.Load += new System.EventHandler(this.EditareMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label Cantitate;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.TextBox tbIdMaterial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}