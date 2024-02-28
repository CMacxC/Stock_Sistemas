namespace Stock_Sistemas
{
    partial class frm_AgregarConsumible
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AgregarConsumible));
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.txt_Id = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_Descripcion = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_Modelo = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_IdMarca = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_DescripcionMarca = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.btn_Guardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_CatalogoMarcas = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Modelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CatalogoMarcas)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.lbl_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 30);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_Titulo.Location = new System.Drawing.Point(12, 7);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(43, 17);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "label1";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(360, 1);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            // 
            // txt_Id
            // 
            this.txt_Id.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Id.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_Id.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_Id.CaptionStyle.CaptionSize = 90;
            this.txt_Id.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Id.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Id.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.CaptionStyle.TextStyle.Text = "Id:";
            this.txt_Id.EditBoxStyle.BackColor = System.Drawing.Color.White;
            this.txt_Id.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Id.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Id.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Id.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Id.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Id.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Id.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Id.Enabled = false;
            this.txt_Id.Location = new System.Drawing.Point(15, 48);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(180, 30);
            this.txt_Id.TabIndex = 1;
            this.txt_Id.ValidationStyle.PasswordChar = '\0';
            this.txt_Id.Value = "";
            this.txt_Id.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Descripcion.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Descripcion.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Descripcion.CaptionStyle.CaptionSize = 90;
            this.txt_Descripcion.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Descripcion.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Descripcion.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.CaptionStyle.TextStyle.Text = "Descripción:";
            this.txt_Descripcion.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Descripcion.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Descripcion.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Descripcion.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Descripcion.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Descripcion.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Descripcion.Location = new System.Drawing.Point(15, 94);
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(342, 30);
            this.txt_Descripcion.TabIndex = 2;
            this.txt_Descripcion.ValidationStyle.PasswordChar = '\0';
            this.txt_Descripcion.Value = "";
            this.txt_Descripcion.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_Modelo
            // 
            this.txt_Modelo.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Modelo.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_Modelo.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_Modelo.CaptionStyle.CaptionSize = 90;
            this.txt_Modelo.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Modelo.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Modelo.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Modelo.CaptionStyle.TextStyle.Text = "Modelo:";
            this.txt_Modelo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_Modelo.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Modelo.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Modelo.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Modelo.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Modelo.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Modelo.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Modelo.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Modelo.Location = new System.Drawing.Point(15, 140);
            this.txt_Modelo.Name = "txt_Modelo";
            this.txt_Modelo.Size = new System.Drawing.Size(342, 30);
            this.txt_Modelo.TabIndex = 3;
            this.txt_Modelo.ValidationStyle.PasswordChar = '\0';
            this.txt_Modelo.Value = "";
            this.txt_Modelo.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_IdMarca
            // 
            this.txt_IdMarca.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_IdMarca.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_IdMarca.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_IdMarca.CaptionStyle.CaptionSize = 90;
            this.txt_IdMarca.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_IdMarca.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_IdMarca.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdMarca.CaptionStyle.TextStyle.Text = "Marca:";
            this.txt_IdMarca.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_IdMarca.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_IdMarca.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_IdMarca.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_IdMarca.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_IdMarca.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_IdMarca.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IdMarca.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_IdMarca.EditBoxStyle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IdMarca.Location = new System.Drawing.Point(15, 186);
            this.txt_IdMarca.Name = "txt_IdMarca";
            this.txt_IdMarca.Size = new System.Drawing.Size(156, 30);
            this.txt_IdMarca.TabIndex = 4;
            this.txt_IdMarca.ValidationStyle.PasswordChar = '\0';
            this.txt_IdMarca.Value = "";
            this.txt_IdMarca.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_DescripcionMarca
            // 
            this.txt_DescripcionMarca.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_DescripcionMarca.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_DescripcionMarca.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.Transparent;
            this.txt_DescripcionMarca.CaptionStyle.CaptionSize = 0;
            this.txt_DescripcionMarca.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_DescripcionMarca.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_DescripcionMarca.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DescripcionMarca.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DescripcionMarca.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DescripcionMarca.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_DescripcionMarca.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_DescripcionMarca.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescripcionMarca.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_DescripcionMarca.Location = new System.Drawing.Point(177, 186);
            this.txt_DescripcionMarca.Name = "txt_DescripcionMarca";
            this.txt_DescripcionMarca.Size = new System.Drawing.Size(180, 30);
            this.txt_DescripcionMarca.TabIndex = 5;
            this.txt_DescripcionMarca.ValidationStyle.PasswordChar = '\0';
            this.txt_DescripcionMarca.Value = "";
            this.txt_DescripcionMarca.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Guardar.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btn_Guardar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Guardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Guardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(15, 242);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(80, 30);
            this.btn_Guardar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Guardar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(62)))), ((int)(((byte)(92)))));
            this.btn_Guardar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.TextStyle.Text = "Guardar";
            this.btn_Guardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btn_Cancelar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Cancelar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(310, 242);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 30);
            this.btn_Cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Cancelar.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btn_Cancelar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Cancelar.TabIndex = 7;
            this.btn_Cancelar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.TextStyle.Text = "Cancelar";
            this.btn_Cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // btn_CatalogoMarcas
            // 
            this.btn_CatalogoMarcas.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_CatalogoMarcas.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(184)))));
            this.btn_CatalogoMarcas.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoMarcas.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoMarcas.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoMarcas.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_CatalogoMarcas.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(184)))));
            this.btn_CatalogoMarcas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CatalogoMarcas.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_CatalogoMarcas.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_CatalogoMarcas.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_CatalogoMarcas.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CatalogoMarcas.Location = new System.Drawing.Point(363, 186);
            this.btn_CatalogoMarcas.Name = "btn_CatalogoMarcas";
            this.btn_CatalogoMarcas.Size = new System.Drawing.Size(30, 30);
            this.btn_CatalogoMarcas.StateStyles.HoverStyle.BorderSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(123)))));
            this.btn_CatalogoMarcas.TabIndex = 8;
            this.btn_CatalogoMarcas.Tag = "Ver catlogo de marcas";
            this.btn_CatalogoMarcas.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CatalogoMarcas.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            // 
            // frm_AgregarConsumible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 284);
            this.Controls.Add(this.btn_CatalogoMarcas);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_DescripcionMarca);
            this.Controls.Add(this.txt_IdMarca);
            this.Controls.Add(this.txt_Modelo);
            this.Controls.Add(this.txt_Descripcion);
            this.Controls.Add(this.txt_Id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AgregarConsumible";
            this.Text = "Agregar Consumible";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Descripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Modelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_IdMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DescripcionMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_CatalogoMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Cerrar;
        public System.Windows.Forms.Label lbl_Titulo;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Id;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Descripcion;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_IdMarca;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Modelo;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_DescripcionMarca;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Guardar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_CatalogoMarcas;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Cancelar;
    }
}