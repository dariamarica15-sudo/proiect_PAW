namespace proiect
{
    partial class SelecteazaMaterial
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdMaterial = new System.Windows.Forms.TextBox();
            this.cbIdFurnizor = new System.Windows.Forms.ComboBox();
            this.cbMaterial = new System.Windows.Forms.ComboBox();
            this.MaterialeSelectate = new System.Windows.Forms.ListBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.cbIpFurnizor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Log = new System.Windows.Forms.ListBox();
            this.btnTesteazaConexiunea = new System.Windows.Forms.Button();
            this.cbIpLocal = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Cantitate = new System.Windows.Forms.Label();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id furnizor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Material";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data";
            // 
            // tbIdMaterial
            // 
            this.tbIdMaterial.Location = new System.Drawing.Point(137, 74);
            this.tbIdMaterial.Name = "tbIdMaterial";
            this.tbIdMaterial.Size = new System.Drawing.Size(141, 22);
            this.tbIdMaterial.TabIndex = 5;
            // 
            // cbIdFurnizor
            // 
            this.cbIdFurnizor.FormattingEnabled = true;
            this.cbIdFurnizor.Location = new System.Drawing.Point(137, 25);
            this.cbIdFurnizor.Name = "cbIdFurnizor";
            this.cbIdFurnizor.Size = new System.Drawing.Size(141, 24);
            this.cbIdFurnizor.TabIndex = 7;
            // 
            // cbMaterial
            // 
            this.cbMaterial.FormattingEnabled = true;
            this.cbMaterial.Location = new System.Drawing.Point(137, 122);
            this.cbMaterial.Name = "cbMaterial";
            this.cbMaterial.Size = new System.Drawing.Size(141, 24);
            this.cbMaterial.TabIndex = 8;
            this.cbMaterial.SelectedIndexChanged += new System.EventHandler(this.cbMaterial_SelectedIndexChanged);
            // 
            // MaterialeSelectate
            // 
            this.MaterialeSelectate.FormattingEnabled = true;
            this.MaterialeSelectate.ItemHeight = 16;
            this.MaterialeSelectate.Location = new System.Drawing.Point(409, 16);
            this.MaterialeSelectate.Name = "MaterialeSelectate";
            this.MaterialeSelectate.Size = new System.Drawing.Size(236, 116);
            this.MaterialeSelectate.TabIndex = 9;
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(47, 332);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(120, 23);
            this.btnSalveaza.TabIndex = 10;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(47, 377);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(120, 23);
            this.btnRenunta.TabIndex = 12;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // cbIpFurnizor
            // 
            this.cbIpFurnizor.FormattingEnabled = true;
            this.cbIpFurnizor.Location = new System.Drawing.Point(489, 223);
            this.cbIpFurnizor.Name = "cbIpFurnizor";
            this.cbIpFurnizor.Size = new System.Drawing.Size(143, 24);
            this.cbIpFurnizor.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 261);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "IP furnizor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "IP local";
            // 
            // Log
            // 
            this.Log.FormattingEnabled = true;
            this.Log.ItemHeight = 16;
            this.Log.Location = new System.Drawing.Point(409, 343);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(236, 84);
            this.Log.TabIndex = 18;
            // 
            // btnTesteazaConexiunea
            // 
            this.btnTesteazaConexiunea.Location = new System.Drawing.Point(409, 293);
            this.btnTesteazaConexiunea.Name = "btnTesteazaConexiunea";
            this.btnTesteazaConexiunea.Size = new System.Drawing.Size(223, 23);
            this.btnTesteazaConexiunea.TabIndex = 19;
            this.btnTesteazaConexiunea.Text = "Testeaza Conexiunea";
            this.btnTesteazaConexiunea.UseVisualStyleBackColor = true;
            this.btnTesteazaConexiunea.Click += new System.EventHandler(this.btnTesteazaConexiunea_Click);
            // 
            // cbIpLocal
            // 
            this.cbIpLocal.FormattingEnabled = true;
            this.cbIpLocal.Location = new System.Drawing.Point(489, 181);
            this.cbIpLocal.Name = "cbIpLocal";
            this.cbIpLocal.Size = new System.Drawing.Size(143, 24);
            this.cbIpLocal.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Cantitate
            // 
            this.Cantitate.AutoSize = true;
            this.Cantitate.Location = new System.Drawing.Point(34, 181);
            this.Cantitate.Name = "Cantitate";
            this.Cantitate.Size = new System.Drawing.Size(90, 16);
            this.Cantitate.TabIndex = 21;
            this.Cantitate.Text = "Cantitate in kg";
            // 
            // tbCantitate
            // 
            this.tbCantitate.Location = new System.Drawing.Point(137, 175);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(141, 22);
            this.tbCantitate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Pret pe Kg";
            // 
            // tbPret
            // 
            this.tbPret.Location = new System.Drawing.Point(137, 217);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(141, 22);
            this.tbPret.TabIndex = 24;
            // 
            // SelecteazaMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.Cantitate);
            this.Controls.Add(this.cbIpLocal);
            this.Controls.Add(this.btnTesteazaConexiunea);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbIpFurnizor);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.MaterialeSelectate);
            this.Controls.Add(this.cbMaterial);
            this.Controls.Add(this.cbIdFurnizor);
            this.Controls.Add(this.tbIdMaterial);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelecteazaMaterial";
            this.Text = "SelecteazaMaterial";
            this.Load += new System.EventHandler(this.SelecteazaMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdMaterial;
        private System.Windows.Forms.ComboBox cbIdFurnizor;
        private System.Windows.Forms.ComboBox cbMaterial;
        private System.Windows.Forms.ListBox MaterialeSelectate;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.ComboBox cbIpFurnizor;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Log;
        private System.Windows.Forms.Button btnTesteazaConexiunea;
        private System.Windows.Forms.ComboBox cbIpLocal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label Cantitate;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.Label label4;
    }
}