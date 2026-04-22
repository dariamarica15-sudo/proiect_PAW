namespace proiect
{
    partial class Afisare_Contracte
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnPrinteaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista contracte";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(108, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(552, 257);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnPrinteaza
            // 
            this.btnPrinteaza.Location = new System.Drawing.Point(288, 370);
            this.btnPrinteaza.Name = "btnPrinteaza";
            this.btnPrinteaza.Size = new System.Drawing.Size(211, 23);
            this.btnPrinteaza.TabIndex = 2;
            this.btnPrinteaza.Text = "Printeaza";
            this.btnPrinteaza.UseVisualStyleBackColor = true;
            this.btnPrinteaza.Click += new System.EventHandler(this.button1_Click);
            // 
            // Afisare_Contracte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrinteaza);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Afisare_Contracte";
            this.Text = "Afisare_Contracte";
            //this.Load += new System.EventHandler(this.Afisare_Contracte_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnPrinteaza;
    }
}