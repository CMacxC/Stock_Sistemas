namespace Stock_Sistemas
{
    partial class frm_RegistrarSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_RegistrarSalida));
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Elipse_btnCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_Folio = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_Cantidad = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_ClaveProducto = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_DProducto = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_CatalogoProductos = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_FechaSalida = new System.Windows.Forms.DateTimePicker();
            this.txt_Recibio = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_Aceptar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.p_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Folio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClaveProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CatalogoProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Recibio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
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
            this.p_BarraTitulo.Controls.Add(this.label1);
            this.p_BarraTitulo.Controls.Add(this.btn_Cerrar);
            this.p_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.p_BarraTitulo.Name = "p_BarraTitulo";
            this.p_BarraTitulo.Size = new System.Drawing.Size(429, 30);
            this.p_BarraTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registrar Salida";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(387, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
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
            // txt_Folio
            // 
            this.txt_Folio.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Folio.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Folio.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Folio.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Folio.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Folio.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Folio.CaptionStyle.TextStyle.Text = "Folio:";
            this.txt_Folio.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Folio.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Folio.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Folio.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Folio.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Folio.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Folio.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Folio.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Folio.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Folio.Location = new System.Drawing.Point(15, 49);
            this.txt_Folio.Name = "txt_Folio";
            this.txt_Folio.Size = new System.Drawing.Size(180, 30);
            this.txt_Folio.TabIndex = 1;
            this.txt_Folio.ValidationStyle.PasswordChar = '\0';
            this.txt_Folio.Value = "";
            this.txt_Folio.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_Folio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Folio_KeyDown);
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Cantidad.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Cantidad.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Cantidad.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Cantidad.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Cantidad.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.CaptionStyle.TextStyle.Text = "Cantidad:";
            this.txt_Cantidad.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Cantidad.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Cantidad.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Cantidad.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Cantidad.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Cantidad.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Cantidad.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Cantidad.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Cantidad.Location = new System.Drawing.Point(15, 153);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(180, 30);
            this.txt_Cantidad.TabIndex = 2;
            this.txt_Cantidad.ValidationStyle.PasswordChar = '\0';
            this.txt_Cantidad.Value = "";
            this.txt_Cantidad.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_Cantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Cantidad_KeyDown);
            // 
            // txt_ClaveProducto
            // 
            this.txt_ClaveProducto.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_ClaveProducto.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_ClaveProducto.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_ClaveProducto.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_ClaveProducto.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_ClaveProducto.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClaveProducto.CaptionStyle.TextStyle.Text = "Producto:";
            this.txt_ClaveProducto.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_ClaveProducto.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_ClaveProducto.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_ClaveProducto.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_ClaveProducto.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ClaveProducto.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ClaveProducto.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_ClaveProducto.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ClaveProducto.Location = new System.Drawing.Point(15, 101);
            this.txt_ClaveProducto.Name = "txt_ClaveProducto";
            this.txt_ClaveProducto.Size = new System.Drawing.Size(180, 30);
            this.txt_ClaveProducto.TabIndex = 3;
            this.txt_ClaveProducto.ValidationStyle.PasswordChar = '\0';
            this.txt_ClaveProducto.Value = "";
            this.txt_ClaveProducto.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            this.txt_ClaveProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ClaveProducto_KeyDown);
            // 
            // txt_DProducto
            // 
            this.txt_DProducto.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_DProducto.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_DProducto.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_DProducto.CaptionStyle.CaptionSize = 0;
            this.txt_DProducto.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_DProducto.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_DProducto.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.txt_DProducto.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DProducto.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DProducto.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DProducto.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DProducto.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_DProducto.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DProducto.EditBoxStyle.ForeColor = System.Drawing.Color.Black;
            this.txt_DProducto.Enabled = false;
            this.txt_DProducto.Location = new System.Drawing.Point(201, 101);
            this.txt_DProducto.Name = "txt_DProducto";
            this.txt_DProducto.Size = new System.Drawing.Size(180, 30);
            this.txt_DProducto.TabIndex = 4;
            this.txt_DProducto.ValidationStyle.PasswordChar = '\0';
            this.txt_DProducto.Value = "";
            this.txt_DProducto.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // btn_CatalogoProductos
            // 
            this.btn_CatalogoProductos.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_CatalogoProductos.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_CatalogoProductos.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoProductos.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoProductos.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoProductos.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoProductos.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CatalogoProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CatalogoProductos.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_CatalogoProductos.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_CatalogoProductos.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_CatalogoProductos.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CatalogoProductos.Location = new System.Drawing.Point(387, 101);
            this.btn_CatalogoProductos.Name = "btn_CatalogoProductos";
            this.btn_CatalogoProductos.Size = new System.Drawing.Size(30, 30);
            this.btn_CatalogoProductos.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CatalogoProductos.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_CatalogoProductos.TabIndex = 5;
            this.btn_CatalogoProductos.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CatalogoProductos.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_CatalogoProductos.Click += new System.EventHandler(this.btn_CatalogoProductos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha:";
            // 
            // dtp_FechaSalida
            // 
            this.dtp_FechaSalida.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaSalida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_FechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaSalida.Location = new System.Drawing.Point(97, 200);
            this.dtp_FechaSalida.Name = "dtp_FechaSalida";
            this.dtp_FechaSalida.Size = new System.Drawing.Size(114, 25);
            this.dtp_FechaSalida.TabIndex = 7;
            this.dtp_FechaSalida.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_FechaSalida_KeyDown);
            // 
            // txt_Recibio
            // 
            this.txt_Recibio.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Recibio.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Recibio.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Recibio.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Recibio.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Recibio.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recibio.CaptionStyle.TextStyle.Text = "Recibio:";
            this.txt_Recibio.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Recibio.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Recibio.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Recibio.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Recibio.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Recibio.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recibio.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Recibio.Location = new System.Drawing.Point(15, 244);
            this.txt_Recibio.Name = "txt_Recibio";
            this.txt_Recibio.Size = new System.Drawing.Size(196, 30);
            this.txt_Recibio.TabIndex = 8;
            this.txt_Recibio.ValidationStyle.PasswordChar = '\0';
            this.txt_Recibio.Value = "";
            this.txt_Recibio.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
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
            this.btn_Aceptar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Aceptar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Aceptar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Aceptar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Aceptar.Location = new System.Drawing.Point(15, 304);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(100, 35);
            this.btn_Aceptar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Aceptar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Aceptar.TabIndex = 9;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(317, 304);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(100, 35);
            this.btn_Cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.TabIndex = 10;
            this.btn_Cancelar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.TextStyle.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Cancelar.TextStyle.Text = "Cancelar";
            this.btn_Cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // frm_RegistrarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(429, 351);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_Recibio);
            this.Controls.Add(this.dtp_FechaSalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_CatalogoProductos);
            this.Controls.Add(this.txt_DProducto);
            this.Controls.Add(this.txt_ClaveProducto);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.txt_Folio);
            this.Controls.Add(this.p_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_RegistrarSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_RegistrarSalida";
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Folio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Cantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ClaveProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CatalogoProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Recibio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Aceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Panel p_BarraTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_btnCerrar;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Cantidad;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Folio;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_DProducto;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_ClaveProducto;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_CatalogoProductos;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Recibio;
        private System.Windows.Forms.DateTimePicker dtp_FechaSalida;
        private System.Windows.Forms.Label label2;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Cancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Aceptar;
    }
}