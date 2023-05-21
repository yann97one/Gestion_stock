namespace gestionStock
{
    partial class FormFournisseur
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
            this.lbl_formF = new System.Windows.Forms.Label();
            this.four_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.four_ref = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.four_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du Fournisseur";
            // 
            // lbl_formF
            // 
            this.lbl_formF.AutoSize = true;
            this.lbl_formF.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbl_formF.Location = new System.Drawing.Point(319, 27);
            this.lbl_formF.Name = "lbl_formF";
            this.lbl_formF.Size = new System.Drawing.Size(361, 29);
            this.lbl_formF.TabIndex = 1;
            this.lbl_formF.Text = "AJOUTER UN FOURNISSEUR";
            // 
            // four_name
            // 
            this.four_name.Location = new System.Drawing.Point(55, 168);
            this.four_name.Multiline = true;
            this.four_name.Name = "four_name";
            this.four_name.Size = new System.Drawing.Size(625, 36);
            this.four_name.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(50, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Référence du fournisseur";
            // 
            // four_ref
            // 
            this.four_ref.Location = new System.Drawing.Point(55, 314);
            this.four_ref.Multiline = true;
            this.four_ref.Name = "four_ref";
            this.four_ref.Size = new System.Drawing.Size(265, 28);
            this.four_ref.TabIndex = 4;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(294, 385);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(314, 39);
            this.submit.TabIndex = 5;
            this.submit.Text = "Enregistrer";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // four_id
            // 
            this.four_id.AutoSize = true;
            this.four_id.Location = new System.Drawing.Point(189, 63);
            this.four_id.Name = "four_id";
            this.four_id.Size = new System.Drawing.Size(0, 16);
            this.four_id.TabIndex = 6;
            // 
            // FormFournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 450);
            this.Controls.Add(this.four_id);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.four_ref);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.four_name);
            this.Controls.Add(this.lbl_formF);
            this.Controls.Add(this.label1);
            this.Name = "FormFournisseur";
            this.Text = "FormFournisseur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_formF;
        private System.Windows.Forms.TextBox four_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox four_ref;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label four_id;
    }
}