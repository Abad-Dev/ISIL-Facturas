namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grdProductos = new DataGridView();
            txtCodProd = new TextBox();
            lblCodProd = new Label();
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblQty = new Label();
            numQty = new NumericUpDown();
            lblPrecio = new Label();
            txtPrecio = new TextBox();
            grpInsert = new GroupBox();
            lblPrefixSubtotal = new Label();
            btnAdd = new Button();
            lblSubtotal = new Label();
            lblSubtotalView = new Label();
            btnNew = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            lblPrefixTotal = new Label();
            lblTotal = new Label();
            lblTotalView = new Label();
            ((System.ComponentModel.ISupportInitialize)grdProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            grpInsert.SuspendLayout();
            SuspendLayout();
            // 
            // grdProductos
            // 
            grdProductos.AllowUserToAddRows = false;
            grdProductos.AllowUserToResizeColumns = false;
            grdProductos.AllowUserToResizeRows = false;
            grdProductos.BackgroundColor = Color.GhostWhite;
            grdProductos.BorderStyle = BorderStyle.Fixed3D;
            grdProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            grdProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdProductos.GridColor = SystemColors.ScrollBar;
            grdProductos.Location = new Point(99, 287);
            grdProductos.Name = "grdProductos";
            grdProductos.ReadOnly = true;
            grdProductos.RowHeadersVisible = false;
            grdProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            grdProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdProductos.Size = new Size(503, 150);
            grdProductos.TabIndex = 0;
            // 
            // txtCodProd
            // 
            txtCodProd.Location = new Point(43, 53);
            txtCodProd.Name = "txtCodProd";
            txtCodProd.Size = new Size(129, 23);
            txtCodProd.TabIndex = 1;
            // 
            // lblCodProd
            // 
            lblCodProd.AutoSize = true;
            lblCodProd.Location = new Point(43, 35);
            lblCodProd.Name = "lblCodProd";
            lblCodProd.Size = new Size(117, 15);
            lblCodProd.TabIndex = 2;
            lblCodProd.Text = "Código de Producto:";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(43, 88);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(72, 15);
            lblDesc.TabIndex = 4;
            lblDesc.Text = "Descripción:";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(43, 106);
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(129, 23);
            txtDesc.TabIndex = 3;
            // 
            // lblQty
            // 
            lblQty.AutoSize = true;
            lblQty.Location = new Point(226, 36);
            lblQty.Name = "lblQty";
            lblQty.Size = new Size(58, 15);
            lblQty.TabIndex = 6;
            lblQty.Text = "Cantidad:";
            // 
            // numQty
            // 
            numQty.Location = new Point(226, 54);
            numQty.Name = "numQty";
            numQty.Size = new Size(120, 23);
            numQty.TabIndex = 7;
            numQty.ValueChanged += numQty_ValueChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(226, 88);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(85, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio Unitario";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(226, 106);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(120, 23);
            txtPrecio.TabIndex = 9;
            txtPrecio.Text = "0";
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // grpInsert
            // 
            grpInsert.Controls.Add(lblPrefixSubtotal);
            grpInsert.Controls.Add(btnAdd);
            grpInsert.Controls.Add(lblSubtotal);
            grpInsert.Controls.Add(lblSubtotalView);
            grpInsert.Controls.Add(lblCodProd);
            grpInsert.Controls.Add(txtPrecio);
            grpInsert.Controls.Add(txtCodProd);
            grpInsert.Controls.Add(lblPrecio);
            grpInsert.Controls.Add(txtDesc);
            grpInsert.Controls.Add(numQty);
            grpInsert.Controls.Add(lblDesc);
            grpInsert.Controls.Add(lblQty);
            grpInsert.Location = new Point(99, 70);
            grpInsert.Name = "grpInsert";
            grpInsert.Size = new Size(503, 195);
            grpInsert.TabIndex = 10;
            grpInsert.TabStop = false;
            grpInsert.Text = "Insertar Producto";
            // 
            // lblPrefixSubtotal
            // 
            lblPrefixSubtotal.AutoSize = true;
            lblPrefixSubtotal.BackColor = Color.Transparent;
            lblPrefixSubtotal.Location = new Point(397, 94);
            lblPrefixSubtotal.Name = "lblPrefixSubtotal";
            lblPrefixSubtotal.Size = new Size(21, 15);
            lblPrefixSubtotal.TabIndex = 13;
            lblPrefixSubtotal.Text = "S/ ";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(43, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.Location = new Point(414, 90);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(41, 21);
            lblSubtotal.TabIndex = 11;
            lblSubtotal.Text = "0.00";
            // 
            // lblSubtotalView
            // 
            lblSubtotalView.AutoSize = true;
            lblSubtotalView.Location = new Point(397, 73);
            lblSubtotalView.Name = "lblSubtotalView";
            lblSubtotalView.Size = new Size(58, 15);
            lblSubtotalView.TabIndex = 10;
            lblSubtotalView.Text = "Sub Total:";
            // 
            // btnNew
            // 
            btnNew.Location = new Point(99, 491);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(118, 30);
            btnNew.TabIndex = 11;
            btnNew.Text = "Nueva Factura";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(474, 491);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(128, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Guardar Factura";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(591, 12);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(116, 30);
            btnLoad.TabIndex = 13;
            btnLoad.Text = "Cargar Factura";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // lblPrefixTotal
            // 
            lblPrefixTotal.AutoSize = true;
            lblPrefixTotal.BackColor = Color.Transparent;
            lblPrefixTotal.Location = new Point(544, 466);
            lblPrefixTotal.Name = "lblPrefixTotal";
            lblPrefixTotal.Size = new Size(21, 15);
            lblPrefixTotal.TabIndex = 16;
            lblPrefixTotal.Text = "S/ ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(561, 462);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(41, 21);
            lblTotal.TabIndex = 15;
            lblTotal.Text = "0.00";
            // 
            // lblTotalView
            // 
            lblTotalView.AutoSize = true;
            lblTotalView.Location = new Point(565, 446);
            lblTotalView.Name = "lblTotalView";
            lblTotalView.Size = new Size(35, 15);
            lblTotalView.TabIndex = 14;
            lblTotalView.Text = "Total:";
            lblTotalView.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(719, 554);
            Controls.Add(lblPrefixTotal);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalView);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(grpInsert);
            Controls.Add(grdProductos);
            Name = "Form1";
            Text = "Manejador Facturas";
            ((System.ComponentModel.ISupportInitialize)grdProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            grpInsert.ResumeLayout(false);
            grpInsert.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView grdProductos;
        private TextBox txtCodProd;
        private Label lblCodProd;
        private Label lblDesc;
        private TextBox txtDesc;
        private Label lblQty;
        private NumericUpDown numQty;
        private Label lblPrecio;
        private TextBox txtPrecio;
        private GroupBox grpInsert;
        private Label lblSubtotal;
        private Label lblSubtotalView;
        private Button btnAdd;
        private Label lblPrefixSubtotal;
        private Button btnNew;
        private Button btnSave;
        private Button btnLoad;
        private Label lblPrefixTotal;
        private Label lblTotal;
        private Label lblTotalView;
    }
}
