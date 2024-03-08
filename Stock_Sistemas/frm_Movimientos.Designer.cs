namespace Stock_Sistemas
{
    partial class frm_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Movimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_Movimientos = new System.Windows.Forms.DataGridView();
            this.folioNotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Elipse_btnCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_Opciones = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtp_FechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ImprimirMovimiento = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Compras = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Salidas = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_Salidas = new Klik.Windows.Forms.v1.EntryLib.ELRadioButton();
            this.rd_Compras = new Klik.Windows.Forms.v1.EntryLib.ELRadioButton();
            this.p_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Movimientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource)).BeginInit();
            this.p_Opciones.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ImprimirMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salidas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rd_Salidas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd_Compras)).BeginInit();
            this.SuspendLayout();
            // 
            // p_BarraTitulo
            // 
            this.p_BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.p_BarraTitulo.Controls.Add(this.btn_Cerrar);
            this.p_BarraTitulo.Controls.Add(this.label1);
            this.p_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.p_BarraTitulo.Name = "p_BarraTitulo";
            this.p_BarraTitulo.Size = new System.Drawing.Size(800, 30);
            this.p_BarraTitulo.TabIndex = 0;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(758, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movimientos";
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // dgv_Movimientos
            // 
            this.dgv_Movimientos.AllowUserToAddRows = false;
            this.dgv_Movimientos.AllowUserToDeleteRows = false;
            this.dgv_Movimientos.AllowUserToResizeColumns = false;
            this.dgv_Movimientos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgv_Movimientos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Movimientos.AutoGenerateColumns = false;
            this.dgv_Movimientos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Movimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Movimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Movimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Movimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Movimientos.ColumnHeadersHeight = 30;
            this.dgv_Movimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Movimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.folioNotaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.recibioDataGridViewTextBoxColumn,
            this.empresaDataGridViewTextBoxColumn});
            this.dgv_Movimientos.DataSource = this.salidasBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Movimientos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Movimientos.EnableHeadersVisualStyles = false;
            this.dgv_Movimientos.GridColor = System.Drawing.Color.Silver;
            this.dgv_Movimientos.Location = new System.Drawing.Point(15, 168);
            this.dgv_Movimientos.Name = "dgv_Movimientos";
            this.dgv_Movimientos.ReadOnly = true;
            this.dgv_Movimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Movimientos.RowHeadersVisible = false;
            this.dgv_Movimientos.RowTemplate.Height = 25;
            this.dgv_Movimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Movimientos.Size = new System.Drawing.Size(773, 268);
            this.dgv_Movimientos.TabIndex = 1;
            // 
            // folioNotaDataGridViewTextBoxColumn
            // 
            this.folioNotaDataGridViewTextBoxColumn.DataPropertyName = "Folio_Nota";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.folioNotaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.folioNotaDataGridViewTextBoxColumn.HeaderText = "Folio";
            this.folioNotaDataGridViewTextBoxColumn.Name = "folioNotaDataGridViewTextBoxColumn";
            this.folioNotaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.cantidadDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Salida";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.fechaSalidaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            this.fechaSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recibioDataGridViewTextBoxColumn
            // 
            this.recibioDataGridViewTextBoxColumn.DataPropertyName = "Recibio";
            this.recibioDataGridViewTextBoxColumn.HeaderText = "Recibio";
            this.recibioDataGridViewTextBoxColumn.Name = "recibioDataGridViewTextBoxColumn";
            this.recibioDataGridViewTextBoxColumn.ReadOnly = true;
            this.recibioDataGridViewTextBoxColumn.Width = 150;
            // 
            // empresaDataGridViewTextBoxColumn
            // 
            this.empresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa";
            this.empresaDataGridViewTextBoxColumn.HeaderText = "Empresa";
            this.empresaDataGridViewTextBoxColumn.Name = "empresaDataGridViewTextBoxColumn";
            this.empresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salidasBindingSource
            // 
            this.salidasBindingSource.DataSource = typeof(Business_Layer.Salidas);
            // 
            // Elipse_btnCerrar
            // 
            this.Elipse_btnCerrar.ElipseRadius = 5;
            this.Elipse_btnCerrar.TargetControl = this.btn_Cerrar;
            // 
            // p_Opciones
            // 
            this.p_Opciones.Controls.Add(this.groupBox3);
            this.p_Opciones.Controls.Add(this.groupBox2);
            this.p_Opciones.Controls.Add(this.groupBox1);
            this.p_Opciones.Location = new System.Drawing.Point(15, 45);
            this.p_Opciones.Name = "p_Opciones";
            this.p_Opciones.Size = new System.Drawing.Size(773, 110);
            this.p_Opciones.TabIndex = 2;
            this.p_Opciones.Paint += new System.Windows.Forms.PaintEventHandler(this.p_Opciones_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_FechaFinal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtp_FechaInicial);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(513, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 100);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Período";
            // 
            // dtp_FechaFinal
            // 
            this.dtp_FechaFinal.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaFinal.Location = new System.Drawing.Point(121, 60);
            this.dtp_FechaFinal.Name = "dtp_FechaFinal";
            this.dtp_FechaFinal.Size = new System.Drawing.Size(102, 25);
            this.dtp_FechaFinal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Fecha Final:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fecha Inicial:";
            // 
            // dtp_FechaInicial
            // 
            this.dtp_FechaInicial.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaInicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaInicial.Location = new System.Drawing.Point(121, 23);
            this.dtp_FechaInicial.Name = "dtp_FechaInicial";
            this.dtp_FechaInicial.Size = new System.Drawing.Size(102, 25);
            this.dtp_FechaInicial.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ImprimirMovimiento);
            this.groupBox2.Controls.Add(this.btn_Compras);
            this.groupBox2.Controls.Add(this.btn_Salidas);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_ImprimirMovimiento
            // 
            this.btn_ImprimirMovimiento.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_ImprimirMovimiento.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_ImprimirMovimiento.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirMovimiento.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirMovimiento.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirMovimiento.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_ImprimirMovimiento.BorderStyle.SolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ImprimirMovimiento.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_ImprimirMovimiento.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_ImprimirMovimiento.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_ImprimirMovimiento.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImprimirMovimiento.Location = new System.Drawing.Point(11, 64);
            this.btn_ImprimirMovimiento.Name = "btn_ImprimirMovimiento";
            this.btn_ImprimirMovimiento.Size = new System.Drawing.Size(265, 25);
            this.btn_ImprimirMovimiento.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirMovimiento.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ImprimirMovimiento.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_ImprimirMovimiento.TabIndex = 5;
            this.btn_ImprimirMovimiento.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImprimirMovimiento.TextStyle.Text = "Imprimir Movimiento";
            this.btn_ImprimirMovimiento.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ImprimirMovimiento.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // btn_Compras
            // 
            this.btn_Compras.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Compras.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_Compras.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Compras.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Compras.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Compras.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Compras.BorderStyle.SolidColor = System.Drawing.Color.Green;
            this.btn_Compras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Compras.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Compras.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Compras.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btn_Compras.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Compras.Location = new System.Drawing.Point(11, 21);
            this.btn_Compras.Name = "btn_Compras";
            this.btn_Compras.Size = new System.Drawing.Size(115, 25);
            this.btn_Compras.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Green;
            this.btn_Compras.StateStyles.HoverStyle.TextBackColor = System.Drawing.Color.Green;
            this.btn_Compras.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Compras.TabIndex = 4;
            this.btn_Compras.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Compras.TextStyle.Text = "Compra";
            this.btn_Compras.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Compras.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // btn_Salidas
            // 
            this.btn_Salidas.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Salidas.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_Salidas.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Salidas.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Salidas.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Salidas.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Salidas.BorderStyle.SolidColor = System.Drawing.Color.Maroon;
            this.btn_Salidas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salidas.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Salidas.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Salidas.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btn_Salidas.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salidas.Location = new System.Drawing.Point(161, 21);
            this.btn_Salidas.Name = "btn_Salidas";
            this.btn_Salidas.Size = new System.Drawing.Size(115, 25);
            this.btn_Salidas.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Maroon;
            this.btn_Salidas.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Maroon;
            this.btn_Salidas.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Salidas.TabIndex = 3;
            this.btn_Salidas.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salidas.TextStyle.Text = "Salida";
            this.btn_Salidas.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salidas.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_Salidas);
            this.groupBox1.Controls.Add(this.rd_Compras);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(296, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rd_Salidas
            // 
            this.rd_Salidas.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.rd_Salidas.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.rd_Salidas.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Salidas.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Salidas.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Salidas.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Salidas.BorderStyle.SolidColor = System.Drawing.Color.Maroon;
            this.rd_Salidas.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.rd_Salidas.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.rd_Salidas.Location = new System.Drawing.Point(111, 44);
            this.rd_Salidas.Name = "rd_Salidas";
            this.rd_Salidas.Size = new System.Drawing.Size(90, 23);
            this.rd_Salidas.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Maroon;
            this.rd_Salidas.StateStyles.FocusStyle.BorderSolidColor = System.Drawing.Color.Maroon;
            this.rd_Salidas.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White;
            this.rd_Salidas.TabIndex = 12;
            this.rd_Salidas.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Salidas.TextStyle.Text = "Salidas";
            this.rd_Salidas.TextStyle.TextIndent.Left = 5;
            this.rd_Salidas.TextStyle.TextIndent.Right = -5;
            this.rd_Salidas.Value = false;
            this.rd_Salidas.VisualStyle = Klik.Windows.Forms.v1.EntryLib.CheckBoxVisualStyles.Custom;
            // 
            // rd_Compras
            // 
            this.rd_Compras.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.rd_Compras.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.rd_Compras.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Compras.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Compras.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Compras.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.rd_Compras.BorderStyle.SolidColor = System.Drawing.Color.Green;
            this.rd_Compras.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.rd_Compras.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.rd_Compras.Location = new System.Drawing.Point(6, 44);
            this.rd_Compras.Name = "rd_Compras";
            this.rd_Compras.Size = new System.Drawing.Size(90, 23);
            this.rd_Compras.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.Color.Green;
            this.rd_Compras.StateStyles.FocusStyle.BorderSolidColor = System.Drawing.Color.Green;
            this.rd_Compras.StateStyles.FocusStyle.TextForeColor = System.Drawing.Color.White;
            this.rd_Compras.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Green;
            this.rd_Compras.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Green;
            this.rd_Compras.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.rd_Compras.TabIndex = 11;
            this.rd_Compras.TabStop = false;
            this.rd_Compras.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_Compras.TextStyle.Text = "Compras";
            this.rd_Compras.TextStyle.TextIndent.Left = 5;
            this.rd_Compras.TextStyle.TextIndent.Right = -5;
            this.rd_Compras.Value = false;
            this.rd_Compras.VisualStyle = Klik.Windows.Forms.v1.EntryLib.CheckBoxVisualStyles.Custom;
            // 
            // frm_Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.p_Opciones);
            this.Controls.Add(this.dgv_Movimientos);
            this.Controls.Add(this.p_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Movimientos";
            this.Text = "Movimientos";
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Movimientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salidasBindingSource)).EndInit();
            this.p_Opciones.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_ImprimirMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Salidas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rd_Salidas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rd_Compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_BarraTitulo;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.DataGridView dgv_Movimientos;
        private Bunifu.Framework.UI.BunifuElipse Elipse_btnCerrar;
        private System.Windows.Forms.Panel p_Opciones;
        private System.Windows.Forms.BindingSource salidasBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn folioNotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn recibioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtp_FechaFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_FechaInicial;
        private System.Windows.Forms.GroupBox groupBox2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_ImprimirMovimiento;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Compras;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Salidas;
        private System.Windows.Forms.GroupBox groupBox1;
        private Klik.Windows.Forms.v1.EntryLib.ELRadioButton rd_Salidas;
        private Klik.Windows.Forms.v1.EntryLib.ELRadioButton rd_Compras;
    }
}