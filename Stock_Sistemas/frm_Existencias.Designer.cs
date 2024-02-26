namespace Stock_Sistemas
{
    partial class frm_Existencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Existencias));
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.dgv_Almacen = new System.Windows.Forms.DataGridView();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ImprimirReporte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Elipse_Close = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // p_BarraTitulo
            // 
            this.p_BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.p_BarraTitulo.Controls.Add(this.btn_Cerrar);
            this.p_BarraTitulo.Controls.Add(this.label1);
            this.p_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.p_BarraTitulo.Name = "p_BarraTitulo";
            this.p_BarraTitulo.Size = new System.Drawing.Size(686, 30);
            this.p_BarraTitulo.TabIndex = 0;
            // 
            // dgv_Almacen
            // 
            this.dgv_Almacen.AllowUserToAddRows = false;
            this.dgv_Almacen.AllowUserToDeleteRows = false;
            this.dgv_Almacen.AllowUserToResizeColumns = false;
            this.dgv_Almacen.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Almacen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Almacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Almacen.AutoGenerateColumns = false;
            this.dgv_Almacen.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Almacen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Almacen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Almacen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Almacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Almacen.ColumnHeadersHeight = 40;
            this.dgv_Almacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Almacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dgv_Almacen.DataSource = this.stockBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Almacen.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Almacen.EnableHeadersVisualStyles = false;
            this.dgv_Almacen.GridColor = System.Drawing.Color.LightGray;
            this.dgv_Almacen.Location = new System.Drawing.Point(12, 103);
            this.dgv_Almacen.Name = "dgv_Almacen";
            this.dgv_Almacen.ReadOnly = true;
            this.dgv_Almacen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Almacen.RowHeadersVisible = false;
            this.dgv_Almacen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Almacen.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_Almacen.RowTemplate.Height = 30;
            this.dgv_Almacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Almacen.Size = new System.Drawing.Size(662, 271);
            this.dgv_Almacen.TabIndex = 1;
            this.dgv_Almacen.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_Almacen_CellFormatting);
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataSource = typeof(Business_Layer.Consultas.Stock);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "Id_Producto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idProductoDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "Id Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "Producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            this.productoDataGridViewTextBoxColumn.ReadOnly = true;
            this.productoDataGridViewTextBoxColumn.Width = 200;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Width = 150;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.marcaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDataGridViewTextBoxColumn.Width = 90;
            // 
            // btn_ImprimirReporte
            // 
            this.btn_ImprimirReporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ImprimirReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirReporte.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImprimirReporte.Image")));
            this.btn_ImprimirReporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprimirReporte.Location = new System.Drawing.Point(568, 56);
            this.btn_ImprimirReporte.Name = "btn_ImprimirReporte";
            this.btn_ImprimirReporte.Size = new System.Drawing.Size(106, 30);
            this.btn_ImprimirReporte.TabIndex = 2;
            this.btn_ImprimirReporte.Text = "Imprimir Stock";
            this.btn_ImprimirReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ImprimirReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ImprimirReporte.UseVisualStyleBackColor = true;
            this.btn_ImprimirReporte.Click += new System.EventHandler(this.btn_ImprimirReporte_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacén";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(644, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Elipse_Close
            // 
            this.Elipse_Close.ElipseRadius = 5;
            this.Elipse_Close.TargetControl = this.btn_Cerrar;
            // 
            // frm_Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 386);
            this.Controls.Add(this.btn_ImprimirReporte);
            this.Controls.Add(this.dgv_Almacen);
            this.Controls.Add(this.p_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Existencias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Almacen";
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Panel p_BarraTitulo;
        private System.Windows.Forms.DataGridView dgv_Almacen;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_ImprimirReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Close;
    }
}