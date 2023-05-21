namespace gestionStock
{
    partial class FormProduit
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Product_Name = new System.Windows.Forms.TextBox();
            this.Four_Product = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.Price_Product = new System.Windows.Forms.TextBox();
            this.Product_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.quantite_produit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(66, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(66, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fournisseur du produit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(66, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Affecter un prix au produit";
            // 
            // Product_Name
            // 
            this.Product_Name.Location = new System.Drawing.Point(71, 78);
            this.Product_Name.Multiline = true;
            this.Product_Name.Name = "Product_Name";
            this.Product_Name.Size = new System.Drawing.Size(451, 38);
            this.Product_Name.TabIndex = 5;
            // 
            // Four_Product
            // 
            this.Four_Product.Location = new System.Drawing.Point(71, 203);
            this.Four_Product.Multiline = true;
            this.Four_Product.Name = "Four_Product";
            this.Four_Product.Size = new System.Drawing.Size(451, 38);
            this.Four_Product.TabIndex = 7;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(319, 394);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(180, 44);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Enregistrer";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Price_Product
            // 
            this.Price_Product.Location = new System.Drawing.Point(71, 335);
            this.Price_Product.Multiline = true;
            this.Price_Product.Name = "Price_Product";
            this.Price_Product.Size = new System.Drawing.Size(451, 37);
            this.Price_Product.TabIndex = 10;
            // 
            // Product_id
            // 
            this.Product_id.Location = new System.Drawing.Point(657, 94);
            this.Product_id.Name = "Product_id";
            this.Product_id.ReadOnly = true;
            this.Product_id.Size = new System.Drawing.Size(115, 22);
            this.Product_id.TabIndex = 12;
            this.Product_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(669, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "id du produit";
            // 
            // quantite_produit
            // 
            this.quantite_produit.Location = new System.Drawing.Point(561, 335);
            this.quantite_produit.Multiline = true;
            this.quantite_produit.Name = "quantite_produit";
            this.quantite_produit.Size = new System.Drawing.Size(211, 38);
            this.quantite_produit.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(618, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantite";
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quantite_produit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Product_id);
            this.Controls.Add(this.Price_Product);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.Four_Product);
            this.Controls.Add(this.Product_Name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FormProduit";
            this.Text = "Enregistrer";
            this.Load += new System.EventHandler(this.FormProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Product_Name;
        private System.Windows.Forms.TextBox Four_Product;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox Price_Product;
        private System.Windows.Forms.TextBox Product_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantite_produit;
        private System.Windows.Forms.Label label3;
    }
}