namespace gestionStock
{
    partial class Form2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduct = new System.Windows.Forms.TabPage();
            this.rd_qantite = new System.Windows.Forms.RadioButton();
            this.rd_price = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.productData = new System.Windows.Forms.DataGridView();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_produit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.update = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFour = new System.Windows.Forms.TabPage();
            this.add_provider = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.four_data = new System.Windows.Forms.DataGridView();
            this.id_fou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_fou = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ref_four = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Supprimmer = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rd_nom = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tabProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).BeginInit();
            this.tabFour.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.four_data)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduct);
            this.tabControl1.Controls.Add(this.tabFour);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1399, 614);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProduct
            // 
            this.tabProduct.Controls.Add(this.rd_nom);
            this.tabProduct.Controls.Add(this.rd_qantite);
            this.tabProduct.Controls.Add(this.rd_price);
            this.tabProduct.Controls.Add(this.pictureBox1);
            this.tabProduct.Controls.Add(this.textBox1);
            this.tabProduct.Controls.Add(this.AddProduct);
            this.tabProduct.Controls.Add(this.productData);
            this.tabProduct.Controls.Add(this.label1);
            this.tabProduct.Location = new System.Drawing.Point(4, 25);
            this.tabProduct.Name = "tabProduct";
            this.tabProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduct.Size = new System.Drawing.Size(1391, 585);
            this.tabProduct.TabIndex = 0;
            this.tabProduct.Text = "Stock";
            this.tabProduct.UseVisualStyleBackColor = true;
            // 
            // rd_qantite
            // 
            this.rd_qantite.AutoSize = true;
            this.rd_qantite.Location = new System.Drawing.Point(228, 6);
            this.rd_qantite.Name = "rd_qantite";
            this.rd_qantite.Size = new System.Drawing.Size(171, 20);
            this.rd_qantite.TabIndex = 18;
            this.rd_qantite.TabStop = true;
            this.rd_qantite.Text = "Rechercher par quantite";
            this.rd_qantite.UseVisualStyleBackColor = true;
            // 
            // rd_price
            // 
            this.rd_price.AutoSize = true;
            this.rd_price.Location = new System.Drawing.Point(228, 32);
            this.rd_price.Name = "rd_price";
            this.rd_price.Size = new System.Drawing.Size(145, 20);
            this.rd_price.TabIndex = 17;
            this.rd_price.TabStop = true;
            this.rd_price.Text = "Rechercher par prix";
            this.rd_price.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::gestionStock.Properties.Resources.loupe;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1154, 16);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 37);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddProduct
            // 
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddProduct.Location = new System.Drawing.Point(541, 515);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(240, 54);
            this.AddProduct.TabIndex = 14;
            this.AddProduct.Text = "Ajouter un Produit";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // productData
            // 
            this.productData.AllowUserToAddRows = false;
            this.productData.AllowUserToResizeColumns = false;
            this.productData.AllowUserToResizeRows = false;
            this.productData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productData.BackgroundColor = System.Drawing.Color.White;
            this.productData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.productData.ColumnHeadersHeight = 29;
            this.productData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.productData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.lbl_prod,
            this.prix_produit,
            this.four,
            this.delete,
            this.update});
            this.productData.Location = new System.Drawing.Point(59, 59);
            this.productData.MultiSelect = false;
            this.productData.Name = "productData";
            this.productData.RowHeadersVisible = false;
            this.productData.RowHeadersWidth = 51;
            this.productData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productData.RowTemplate.Height = 24;
            this.productData.ShowEditingIcon = false;
            this.productData.Size = new System.Drawing.Size(1246, 450);
            this.productData.TabIndex = 0;
            this.productData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productData_CellClick_1);
            // 
            // num
            // 
            this.num.DataPropertyName = "id_produit";
            this.num.HeaderText = "numero";
            this.num.MinimumWidth = 6;
            this.num.Name = "num";
            // 
            // lbl_prod
            // 
            this.lbl_prod.DataPropertyName = "label_produit";
            this.lbl_prod.HeaderText = "nom produit";
            this.lbl_prod.MinimumWidth = 6;
            this.lbl_prod.Name = "lbl_prod";
            // 
            // prix_produit
            // 
            this.prix_produit.DataPropertyName = "prix_produit";
            this.prix_produit.HeaderText = "prix produit";
            this.prix_produit.MinimumWidth = 6;
            this.prix_produit.Name = "prix_produit";
            // 
            // four
            // 
            this.four.DataPropertyName = "quantite";
            this.four.HeaderText = "Quantite";
            this.four.MinimumWidth = 6;
            this.four.Name = "four";
            // 
            // delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.HeaderText = "Modifier";
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.delete.Text = "Modifier";
            this.delete.ToolTipText = "Modifier";
            this.delete.UseColumnTextForButtonValue = true;
            // 
            // update
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            this.update.DefaultCellStyle = dataGridViewCellStyle2;
            this.update.HeaderText = "Supprimer";
            this.update.MinimumWidth = 6;
            this.update.Name = "update";
            this.update.Text = "Supprimer";
            this.update.ToolTipText = "Supprimer";
            this.update.UseColumnTextForButtonValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(448, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stock de l\'entreprise";
            // 
            // tabFour
            // 
            this.tabFour.Controls.Add(this.add_provider);
            this.tabFour.Controls.Add(this.label2);
            this.tabFour.Controls.Add(this.four_data);
            this.tabFour.Location = new System.Drawing.Point(4, 25);
            this.tabFour.Name = "tabFour";
            this.tabFour.Padding = new System.Windows.Forms.Padding(3);
            this.tabFour.Size = new System.Drawing.Size(1391, 585);
            this.tabFour.TabIndex = 1;
            this.tabFour.Text = "Fournisseurs";
            this.tabFour.UseVisualStyleBackColor = true;
            // 
            // add_provider
            // 
            this.add_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_provider.Location = new System.Drawing.Point(543, 510);
            this.add_provider.Name = "add_provider";
            this.add_provider.Size = new System.Drawing.Size(250, 57);
            this.add_provider.TabIndex = 19;
            this.add_provider.Text = "Ajouter un Fournisseur";
            this.add_provider.UseVisualStyleBackColor = true;
            this.add_provider.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(575, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Fournisseurs";
            // 
            // four_data
            // 
            this.four_data.AllowUserToAddRows = false;
            this.four_data.AllowUserToResizeColumns = false;
            this.four_data.AllowUserToResizeRows = false;
            this.four_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.four_data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.four_data.BackgroundColor = System.Drawing.Color.White;
            this.four_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.four_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.four_data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_fou,
            this.lbl_fou,
            this.ref_four,
            this.Modifier,
            this.Supprimmer});
            this.four_data.Location = new System.Drawing.Point(18, 81);
            this.four_data.Name = "four_data";
            this.four_data.RowHeadersWidth = 51;
            this.four_data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.four_data.RowTemplate.Height = 24;
            this.four_data.Size = new System.Drawing.Size(1303, 392);
            this.four_data.TabIndex = 16;
            this.four_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.four_data_CellClick);
            // 
            // id_fou
            // 
            this.id_fou.DataPropertyName = "id_fou";
            this.id_fou.HeaderText = "numero";
            this.id_fou.MinimumWidth = 6;
            this.id_fou.Name = "id_fou";
            this.id_fou.ReadOnly = true;
            // 
            // lbl_fou
            // 
            this.lbl_fou.DataPropertyName = "label_fou";
            this.lbl_fou.HeaderText = "nom fournisseur";
            this.lbl_fou.MinimumWidth = 6;
            this.lbl_fou.Name = "lbl_fou";
            // 
            // ref_four
            // 
            this.ref_four.DataPropertyName = "reference_fou";
            this.ref_four.HeaderText = "référence du fournisseur";
            this.ref_four.MinimumWidth = 6;
            this.ref_four.Name = "ref_four";
            // 
            // Modifier
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Modifier.DefaultCellStyle = dataGridViewCellStyle3;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.HeaderText = "Modifier";
            this.Modifier.MinimumWidth = 6;
            this.Modifier.Name = "Modifier";
            this.Modifier.Text = "Modifier";
            this.Modifier.UseColumnTextForButtonValue = true;
            // 
            // Supprimmer
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            this.Supprimmer.DefaultCellStyle = dataGridViewCellStyle4;
            this.Supprimmer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Supprimmer.HeaderText = "Supprimmer";
            this.Supprimmer.MinimumWidth = 6;
            this.Supprimmer.Name = "Supprimmer";
            this.Supprimmer.Text = "Supprimmer";
            this.Supprimmer.UseColumnTextForButtonValue = true;
            // 
            // rd_nom
            // 
            this.rd_nom.AutoSize = true;
            this.rd_nom.Location = new System.Drawing.Point(51, 6);
            this.rd_nom.Name = "rd_nom";
            this.rd_nom.Size = new System.Drawing.Size(149, 20);
            this.rd_nom.TabIndex = 19;
            this.rd_nom.TabStop = true;
            this.rd_nom.Text = "Recherche par nom ";
            this.rd_nom.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 630);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabProduct.ResumeLayout(false);
            this.tabProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productData)).EndInit();
            this.tabFour.ResumeLayout(false);
            this.tabFour.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.four_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduct;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.DataGridView productData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabFour;
        private System.Windows.Forms.Button add_provider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView four_data;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_fou;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbl_fou;
        private System.Windows.Forms.DataGridViewTextBoxColumn ref_four;
        private System.Windows.Forms.DataGridViewButtonColumn Modifier;
        private System.Windows.Forms.DataGridViewButtonColumn Supprimmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.DataGridViewTextBoxColumn lbl_prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_produit;
        private System.Windows.Forms.DataGridViewTextBoxColumn four;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.DataGridViewButtonColumn update;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rd_qantite;
        private System.Windows.Forms.RadioButton rd_price;
        private System.Windows.Forms.RadioButton rd_nom;
    }
}