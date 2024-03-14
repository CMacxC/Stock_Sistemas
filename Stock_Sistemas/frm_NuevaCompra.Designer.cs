namespace Stock_Sistemas
{
    partial class frm_NuevaCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevaCompra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cerrrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Factura = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_Fecha = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.dgv_Lista = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Proveedor = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_Aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.p_Totales = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_TotalImporte = new System.Windows.Forms.Label();
            this.lbl_TotalIVA = new System.Windows.Forms.Label();
            this.lbl_SubTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            this.p_Totales.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Cerrrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 30);
            this.panel1.TabIndex = 0;
            // 
            // btn_Cerrrar
            // 
            this.btn_Cerrrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrrar.BackgroundImage")));
            this.btn_Cerrrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrrar.Location = new System.Drawing.Point(665, 0);
            this.btn_Cerrrar.Name = "btn_Cerrrar";
            this.btn_Cerrrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrrar.TabIndex = 1;
            this.btn_Cerrrar.UseVisualStyleBackColor = true;
            this.btn_Cerrrar.Click += new System.EventHandler(this.btn_Cerrrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar compra";
            // 
            // txt_Factura
            // 
            this.txt_Factura.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Factura.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Factura.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Factura.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Factura.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Factura.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Factura.CaptionStyle.TextStyle.Text = "Factura:";
            this.txt_Factura.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Factura.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Factura.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Factura.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Factura.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Factura.Location = new System.Drawing.Point(15, 49);
            this.txt_Factura.Name = "txt_Factura";
            this.txt_Factura.Size = new System.Drawing.Size(180, 30);
            this.txt_Factura.TabIndex = 1;
            this.txt_Factura.ValidationStyle.PasswordChar = '\0';
            this.txt_Factura.Value = "";
            this.txt_Factura.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_Factura.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Factura_KeyDown);
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Fecha.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Fecha.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Fecha.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Fecha.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Fecha.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.CaptionStyle.TextStyle.Text = "Fecha:";
            this.txt_Fecha.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Fecha.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Fecha.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Fecha.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fecha.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Fecha.Location = new System.Drawing.Point(243, 49);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(180, 30);
            this.txt_Fecha.TabIndex = 5;
            this.txt_Fecha.ValidationStyle.MaskValidationStyle.Mask = "00/00/0000";
            this.txt_Fecha.ValidationStyle.PasswordChar = '\0';
            this.txt_Fecha.ValidationStyle.ValidationType = Klik.Windows.Forms.v1.EntryLib.ValidationTypes.DateTime;
            this.txt_Fecha.Value = new System.DateTime(2024, 3, 13, 0, 0, 0, 0);
            this.txt_Fecha.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_Fecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Fecha_KeyDown);
            // 
            // dgv_Lista
            // 
            this.dgv_Lista.AllowUserToAddRows = false;
            this.dgv_Lista.AllowUserToDeleteRows = false;
            this.dgv_Lista.AllowUserToResizeColumns = false;
            this.dgv_Lista.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Lista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Lista.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Lista.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Lista.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Lista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Lista.ColumnHeadersHeight = 30;
            this.dgv_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Id_Producto,
            this.DProducto,
            this.Modelo,
            this.SubTotal,
            this.IVA,
            this.Total});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Lista.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_Lista.EnableHeadersVisualStyles = false;
            this.dgv_Lista.GridColor = System.Drawing.Color.LightGray;
            this.dgv_Lista.Location = new System.Drawing.Point(15, 140);
            this.dgv_Lista.MultiSelect = false;
            this.dgv_Lista.Name = "dgv_Lista";
            this.dgv_Lista.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Lista.RowHeadersVisible = false;
            this.dgv_Lista.RowTemplate.Height = 25;
            this.dgv_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Lista.Size = new System.Drawing.Size(678, 188);
            this.dgv_Lista.TabIndex = 6;
            this.dgv_Lista.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Lista_CellValueChanged);
            this.dgv_Lista.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_Lista_KeyDown);
            // 
            // Cantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 80;
            // 
            // Id_Producto
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Id_Producto.DefaultCellStyle = dataGridViewCellStyle4;
            this.Id_Producto.HeaderText = "No. Producto";
            this.Id_Producto.Name = "Id_Producto";
            // 
            // DProducto
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.DProducto.HeaderText = "Producto";
            this.DProducto.Name = "DProducto";
            this.DProducto.ReadOnly = true;
            this.DProducto.Width = 150;
            // 
            // Modelo
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Modelo.DefaultCellStyle = dataGridViewCellStyle6;
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = null;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle7;
            this.SubTotal.HeaderText = "Costo U.";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Width = 80;
            // 
            // IVA
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.IVA.DefaultCellStyle = dataGridViewCellStyle8;
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Width = 80;
            // 
            // Total
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "C2";
            dataGridViewCellStyle9.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle9;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 80;
            // 
            // txt_Proveedor
            // 
            this.txt_Proveedor.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Proveedor.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Proveedor.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Proveedor.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Proveedor.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Proveedor.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Proveedor.CaptionStyle.TextStyle.Text = "Proveedor:";
            this.txt_Proveedor.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Proveedor.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Proveedor.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Proveedor.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Proveedor.Location = new System.Drawing.Point(15, 99);
            this.txt_Proveedor.Name = "txt_Proveedor";
            this.txt_Proveedor.Size = new System.Drawing.Size(294, 30);
            this.txt_Proveedor.TabIndex = 7;
            this.txt_Proveedor.ValidationStyle.PasswordChar = '\0';
            this.txt_Proveedor.Value = "";
            this.txt_Proveedor.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_Proveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Proveedor_KeyDown);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Aceptar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_Aceptar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Aceptar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Aceptar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Aceptar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Aceptar.BorderStyle.SolidColor = System.Drawing.Color.Navy;
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Aceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(15, 387);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 35);
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Navy;
            this.btn_Aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Navy;
            this.btn_Aceptar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.TabIndex = 8;
            this.btn_Aceptar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.TextStyle.Text = "Aceptar";
            this.btn_Aceptar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_Cancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.SolidColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(593, 387);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 35);
            this.btn_Cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.TextStyle.Text = "Cancelar";
            this.btn_Cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // p_Totales
            // 
            this.p_Totales.BackColor = System.Drawing.Color.WhiteSmoke;
            this.p_Totales.Controls.Add(this.label4);
            this.p_Totales.Controls.Add(this.label3);
            this.p_Totales.Controls.Add(this.label2);
            this.p_Totales.Controls.Add(this.lbl_TotalImporte);
            this.p_Totales.Controls.Add(this.lbl_TotalIVA);
            this.p_Totales.Controls.Add(this.lbl_SubTotal);
            this.p_Totales.Location = new System.Drawing.Point(15, 334);
            this.p_Totales.Name = "p_Totales";
            this.p_Totales.Size = new System.Drawing.Size(678, 47);
            this.p_Totales.TabIndex = 10;
            this.p_Totales.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Totales_Paint);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Importe:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "IVA:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "SubTotal:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_TotalImporte
            // 
            this.lbl_TotalImporte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalImporte.Location = new System.Drawing.Point(602, 23);
            this.lbl_TotalImporte.Name = "lbl_TotalImporte";
            this.lbl_TotalImporte.Size = new System.Drawing.Size(70, 20);
            this.lbl_TotalImporte.TabIndex = 2;
            this.lbl_TotalImporte.Text = "0.00";
            this.lbl_TotalImporte.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalIVA
            // 
            this.lbl_TotalIVA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalIVA.Location = new System.Drawing.Point(516, 23);
            this.lbl_TotalIVA.Name = "lbl_TotalIVA";
            this.lbl_TotalIVA.Size = new System.Drawing.Size(80, 20);
            this.lbl_TotalIVA.TabIndex = 1;
            this.lbl_TotalIVA.Text = "0.00";
            this.lbl_TotalIVA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_SubTotal
            // 
            this.lbl_SubTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SubTotal.Location = new System.Drawing.Point(430, 23);
            this.lbl_SubTotal.Name = "lbl_SubTotal";
            this.lbl_SubTotal.Size = new System.Drawing.Size(80, 20);
            this.lbl_SubTotal.TabIndex = 0;
            this.lbl_SubTotal.Text = "0.00";
            this.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm_NuevaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(707, 437);
            this.Controls.Add(this.p_Totales);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Proveedor);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.txt_Factura);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NuevaCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_NuevaCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Fecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Lista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            this.p_Totales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerrrar;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Fecha;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Factura;
        private System.Windows.Forms.DataGridView dgv_Lista;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Cancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Aceptar;
        private System.Windows.Forms.Panel p_Totales;
        private System.Windows.Forms.Label lbl_TotalIVA;
        private System.Windows.Forms.Label lbl_SubTotal;
        private System.Windows.Forms.Label lbl_TotalImporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}