namespace Stock_Sistemas
{
    partial class frm_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_btnCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.p_Opciones = new System.Windows.Forms.Panel();
            this.btn_ImprimirCompras = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.txt_NCompra = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.dtp_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Compras = new System.Windows.Forms.DataGridView();
            this.idCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFDIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p_BarraTitulo.SuspendLayout();
            this.p_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ImprimirCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // p_BarraTitulo
            // 
            this.p_BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.p_BarraTitulo.Controls.Add(this.label1);
            this.p_BarraTitulo.Controls.Add(this.btn_Cerrar);
            this.p_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.p_BarraTitulo.Name = "p_BarraTitulo";
            this.p_BarraTitulo.Size = new System.Drawing.Size(702, 30);
            this.p_BarraTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compras";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(660, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // Elipse_btnCerrar
            // 
            this.Elipse_btnCerrar.ElipseRadius = 5;
            this.Elipse_btnCerrar.TargetControl = this.btn_Cerrar;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.p_BarraTitulo;
            this.bunifuDragControl1.Vertical = true;
            // 
            // p_Opciones
            // 
            this.p_Opciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p_Opciones.Controls.Add(this.btn_ImprimirCompras);
            this.p_Opciones.Controls.Add(this.txt_NCompra);
            this.p_Opciones.Controls.Add(this.dtp_FechaFinal);
            this.p_Opciones.Controls.Add(this.dtp_FechaInicial);
            this.p_Opciones.Controls.Add(this.label3);
            this.p_Opciones.Controls.Add(this.label2);
            this.p_Opciones.Location = new System.Drawing.Point(15, 45);
            this.p_Opciones.Name = "p_Opciones";
            this.p_Opciones.Size = new System.Drawing.Size(675, 93);
            this.p_Opciones.TabIndex = 1;
            this.p_Opciones.Paint += new System.Windows.Forms.PaintEventHandler(this.dgv_Compras_Paint);
            // 
            // btn_ImprimirCompras
            // 
            this.btn_ImprimirCompras.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_ImprimirCompras.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_ImprimirCompras.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirCompras.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirCompras.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirCompras.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirCompras.BorderStyle.SolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirCompras.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_ImprimirCompras.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_ImprimirCompras.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_ImprimirCompras.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImprimirCompras.Location = new System.Drawing.Point(172, 16);
            this.btn_ImprimirCompras.Name = "btn_ImprimirCompras";
            this.btn_ImprimirCompras.Size = new System.Drawing.Size(216, 30);
            this.btn_ImprimirCompras.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirCompras.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirCompras.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_ImprimirCompras.TabIndex = 5;
            this.btn_ImprimirCompras.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirCompras.TextStyle.Text = "Imprimir lista de compra";
            this.btn_ImprimirCompras.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImprimirCompras.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // txt_NCompra
            // 
            this.txt_NCompra.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_NCompra.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_NCompra.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_NCompra.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_NCompra.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_NCompra.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_NCompra.BorderStyle.SolidColor = System.Drawing.Color.Green;
            this.txt_NCompra.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_NCompra.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_NCompra.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txt_NCompra.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_NCompra.Location = new System.Drawing.Point(15, 16);
            this.txt_NCompra.Name = "txt_NCompra";
            this.txt_NCompra.Size = new System.Drawing.Size(132, 30);
            this.txt_NCompra.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Green;
            this.txt_NCompra.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Green;
            this.txt_NCompra.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.txt_NCompra.TabIndex = 4;
            this.txt_NCompra.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NCompra.TextStyle.Text = "Nueva compra";
            this.txt_NCompra.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_NCompra.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.txt_NCompra.Click += new System.EventHandler(this.txt_NCompra_Click);
            // 
            // dtp_FechaFinal
            // 
            this.dtp_FechaFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFinal.Location = new System.Drawing.Point(548, 53);
            this.dtp_FechaFinal.Name = "dtp_FechaFinal";
            this.dtp_FechaFinal.Size = new System.Drawing.Size(110, 25);
            this.dtp_FechaFinal.TabIndex = 3;
            this.dtp_FechaFinal.ValueChanged += new System.EventHandler(this.dtp_FechaFinal_ValueChanged);
            // 
            // dtp_FechaInicial
            // 
            this.dtp_FechaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicial.Location = new System.Drawing.Point(548, 16);
            this.dtp_FechaInicial.Name = "dtp_FechaInicial";
            this.dtp_FechaInicial.Size = new System.Drawing.Size(110, 25);
            this.dtp_FechaInicial.TabIndex = 2;
            this.dtp_FechaInicial.ValueChanged += new System.EventHandler(this.dtp_FechaInicial_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(458, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(458, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dgv_Compras
            // 
            this.dgv_Compras.AllowUserToAddRows = false;
            this.dgv_Compras.AllowUserToDeleteRows = false;
            this.dgv_Compras.AllowUserToResizeColumns = false;
            this.dgv_Compras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Compras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Compras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Compras.AutoGenerateColumns = false;
            this.dgv_Compras.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Compras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Compras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Compras.ColumnHeadersHeight = 30;
            this.dgv_Compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Compras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompraDataGridViewTextBoxColumn,
            this.cFDIDataGridViewTextBoxColumn,
            this.fechaCompraDataGridViewTextBoxColumn,
            this.proveedorDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.iVADataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dgv_Compras.DataSource = this.comprasBindingSource;
            this.dgv_Compras.EnableHeadersVisualStyles = false;
            this.dgv_Compras.GridColor = System.Drawing.Color.LightGray;
            this.dgv_Compras.Location = new System.Drawing.Point(15, 158);
            this.dgv_Compras.Name = "dgv_Compras";
            this.dgv_Compras.ReadOnly = true;
            this.dgv_Compras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Compras.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Compras.RowHeadersVisible = false;
            this.dgv_Compras.RowTemplate.Height = 25;
            this.dgv_Compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Compras.Size = new System.Drawing.Size(675, 260);
            this.dgv_Compras.TabIndex = 2;
            // 
            // idCompraDataGridViewTextBoxColumn
            // 
            this.idCompraDataGridViewTextBoxColumn.DataPropertyName = "Id_Compra";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idCompraDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idCompraDataGridViewTextBoxColumn.Name = "idCompraDataGridViewTextBoxColumn";
            this.idCompraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCompraDataGridViewTextBoxColumn.Width = 50;
            // 
            // cFDIDataGridViewTextBoxColumn
            // 
            this.cFDIDataGridViewTextBoxColumn.DataPropertyName = "CFDI";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cFDIDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cFDIDataGridViewTextBoxColumn.HeaderText = "CFDI";
            this.cFDIDataGridViewTextBoxColumn.Name = "cFDIDataGridViewTextBoxColumn";
            this.cFDIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCompraDataGridViewTextBoxColumn
            // 
            this.fechaCompraDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Compra";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaCompraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.fechaCompraDataGridViewTextBoxColumn.HeaderText = "Fecha Compra";
            this.fechaCompraDataGridViewTextBoxColumn.Name = "fechaCompraDataGridViewTextBoxColumn";
            this.fechaCompraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proveedorDataGridViewTextBoxColumn
            // 
            this.proveedorDataGridViewTextBoxColumn.DataPropertyName = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.HeaderText = "Proveedor";
            this.proveedorDataGridViewTextBoxColumn.Name = "proveedorDataGridViewTextBoxColumn";
            this.proveedorDataGridViewTextBoxColumn.ReadOnly = true;
            this.proveedorDataGridViewTextBoxColumn.Width = 120;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = null;
            this.subTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iVADataGridViewTextBoxColumn
            // 
            this.iVADataGridViewTextBoxColumn.DataPropertyName = "IVA";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.iVADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.iVADataGridViewTextBoxColumn.HeaderText = "IVA";
            this.iVADataGridViewTextBoxColumn.Name = "iVADataGridViewTextBoxColumn";
            this.iVADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataSource = typeof(Business_Layer.Compras);
            // 
            // frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 430);
            this.Controls.Add(this.dgv_Compras);
            this.Controls.Add(this.p_Opciones);
            this.Controls.Add(this.p_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.frm_Compra_Load);
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            this.p_Opciones.ResumeLayout(false);
            this.p_Opciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ImprimirCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_BarraTitulo;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel p_Opciones;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.DataGridView dgv_Compras;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFDIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaFinal;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicial;
        private System.Windows.Forms.Label label3;
        private Klik.Windows.Forms.v1.EntryLib.ELButton txt_NCompra;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_ImprimirCompras;
    }
}