namespace proiect
{
    partial class AdaugaContract
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIdContract = new System.Windows.Forms.TextBox();
            this.cbIdFurnizor = new System.Windows.Forms.ComboBox();
            this.Contracte = new System.Windows.Forms.ListBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbObservatii = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id contract";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id furnizor";
            // 
            // tbIdContract
            // 
            this.tbIdContract.Location = new System.Drawing.Point(129, 26);
            this.tbIdContract.Name = "tbIdContract";
            this.tbIdContract.Size = new System.Drawing.Size(135, 22);
            this.tbIdContract.TabIndex = 2;
            // 
            // cbIdFurnizor
            // 
            this.cbIdFurnizor.FormattingEnabled = true;
            this.cbIdFurnizor.Location = new System.Drawing.Point(129, 72);
            this.cbIdFurnizor.Name = "cbIdFurnizor";
            this.cbIdFurnizor.Size = new System.Drawing.Size(135, 24);
            this.cbIdFurnizor.TabIndex = 3;
            // 
            // Contracte
            // 
            this.Contracte.FormattingEnabled = true;
            this.Contracte.ItemHeight = 16;
            this.Contracte.Location = new System.Drawing.Point(423, 32);
            this.Contracte.Name = "Contracte";
            this.Contracte.Size = new System.Drawing.Size(317, 132);
            this.Contracte.TabIndex = 4;
            //this.Contracte.SelectedIndexChanged += new System.EventHandler(this.Contracte_SelectedIndexChanged);
            // 
            // btnSalveaza
            // 
            this.btnSalveaza.Location = new System.Drawing.Point(184, 275);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(145, 29);
            this.btnSalveaza.TabIndex = 5;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            // 
            // btnRenunta
            // 
            this.btnRenunta.Location = new System.Drawing.Point(423, 275);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(145, 29);
            this.btnRenunta.TabIndex = 6;
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.UseVisualStyleBackColor = true;
            this.btnRenunta.Click += new System.EventHandler(this.btnRenunta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Observatii";
            // 
            // tbObservatii
            // 
            this.tbObservatii.Location = new System.Drawing.Point(120, 163);
            this.tbObservatii.Name = "tbObservatii";
            this.tbObservatii.Size = new System.Drawing.Size(135, 22);
            this.tbObservatii.TabIndex = 10;
            // 
            // AdaugaContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbObservatii);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.btnSalveaza);
            this.Controls.Add(this.Contracte);
            this.Controls.Add(this.cbIdFurnizor);
            this.Controls.Add(this.tbIdContract);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdaugaContract";
            this.Text = "AdaugaContract";
            this.Load += new System.EventHandler(this.AdaugaContract_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIdContract;
        private System.Windows.Forms.ComboBox cbIdFurnizor;
        private System.Windows.Forms.ListBox Contracte;
        private System.Windows.Forms.Button btnSalveaza;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbObservatii;
    }
}