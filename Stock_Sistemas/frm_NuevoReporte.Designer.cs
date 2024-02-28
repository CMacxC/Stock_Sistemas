namespace Stock_Sistemas
{
    partial class frm_NuevoReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NuevoReporte));
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.Elipse_btnCerrar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_Nombre = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.txt_Reporte = new Klik.Windows.Forms.v1.EntryLib.ELEntryBox();
            this.cb_Check = new Klik.Windows.Forms.v1.EntryLib.ELCheckBox();
            this.btn_Archivos = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Guardar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.btn_Cancelar = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.p_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Reporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Archivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).BeginInit();
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
            this.p_BarraTitulo.Size = new System.Drawing.Size(319, 30);
            this.p_BarraTitulo.TabIndex = 0;
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nuevo Reporte";
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(277, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 1;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click_1);
            // 
            // Elipse_btnCerrar
            // 
            this.Elipse_btnCerrar.ElipseRadius = 5;
            this.Elipse_btnCerrar.TargetControl = this.btn_Cerrar;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Transparent;
            this.txt_Nombre.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Nombre.CaptionStyle.CaptionSize = 70;
            this.txt_Nombre.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Nombre.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Nombre.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.CaptionStyle.TextStyle.Text = "Nombre:";
            this.txt_Nombre.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Nombre.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Nombre.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Nombre.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Nombre.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nombre.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Nombre.Location = new System.Drawing.Point(15, 46);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(251, 30);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.ValidationStyle.PasswordChar = '\0';
            this.txt_Nombre.Value = "";
            this.txt_Nombre.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // txt_Reporte
            // 
            this.txt_Reporte.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Transparent;
            this.txt_Reporte.CaptionStyle.BorderStyle.SolidColor = System.Drawing.Color.White;
            this.txt_Reporte.CaptionStyle.CaptionSize = 70;
            this.txt_Reporte.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.txt_Reporte.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.txt_Reporte.CaptionStyle.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reporte.CaptionStyle.TextStyle.Text = "Reporte:";
            this.txt_Reporte.EditBoxStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Reporte.EditBoxStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Reporte.EditBoxStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Reporte.EditBoxStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.txt_Reporte.EditBoxStyle.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Reporte.EditBoxStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reporte.EditBoxStyle.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Reporte.Location = new System.Drawing.Point(15, 102);
            this.txt_Reporte.Name = "txt_Reporte";
            this.txt_Reporte.Size = new System.Drawing.Size(251, 30);
            this.txt_Reporte.TabIndex = 2;
            this.txt_Reporte.ValidationStyle.PasswordChar = '\0';
            this.txt_Reporte.Value = "";
            this.txt_Reporte.VisualStyle = Klik.Windows.Forms.v1.Common.ControlVisualStyles.Custom;
            // 
            // cb_Check
            // 
            this.cb_Check.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.cb_Check.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.cb_Check.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.cb_Check.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.cb_Check.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.cb_Check.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.cb_Check.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.cb_Check.Checked = true;
            this.cb_Check.CheckedValue = 1;
            this.cb_Check.CheckSize = new System.Drawing.Size(30, 30);
            this.cb_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Check.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.cb_Check.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.cb_Check.Location = new System.Drawing.Point(15, 158);
            this.cb_Check.Name = "cb_Check";
            this.cb_Check.Size = new System.Drawing.Size(105, 23);
            this.cb_Check.TabIndex = 3;
            this.cb_Check.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Check.TextStyle.Text = "Activo";
            this.cb_Check.UncheckedValue = 0;
            this.cb_Check.Value = 1;
            this.cb_Check.VisualStyle = Klik.Windows.Forms.v1.EntryLib.CheckBoxVisualStyles.Custom;
            // 
            // btn_Archivos
            // 
            this.btn_Archivos.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Archivos.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.btn_Archivos.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.btn_Archivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Archivos.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Archivos.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Archivos.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Archivos.Location = new System.Drawing.Point(272, 102);
            this.btn_Archivos.Name = "btn_Archivos";
            this.btn_Archivos.Size = new System.Drawing.Size(30, 30);
            this.btn_Archivos.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Archivos.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black;
            this.btn_Archivos.TabIndex = 4;
            this.btn_Archivos.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Archivos.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Archivos.TextStyle.Text = "...";
            this.btn_Archivos.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Archivos.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Archivos.Click += new System.EventHandler(this.btn_Archivos_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Guardar.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btn_Guardar.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_Guardar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(66)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Guardar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Guardar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.Location = new System.Drawing.Point(15, 204);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(80, 30);
            this.btn_Guardar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Guardar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Black;
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Guardar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.TextStyle.Text = "Guardar";
            this.btn_Guardar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.BackgroundStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btn_Cancelar.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(168)))), ((int)(((byte)(172)))));
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_Cancelar.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_Cancelar.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.Location = new System.Drawing.Point(222, 204);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(80, 30);
            this.btn_Cancelar.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.White;
            this.btn_Cancelar.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.Red;
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.TextStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.TextStyle.ForeColor = System.Drawing.Color.White;
            this.btn_Cancelar.TextStyle.Text = "Cancelar";
            this.btn_Cancelar.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // frm_NuevoReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 247);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Archivos);
            this.Controls.Add(this.cb_Check);
            this.Controls.Add(this.txt_Reporte);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.p_BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_NuevoReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Reporte";
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Reporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_Check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Archivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancelar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_BarraTitulo;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_btnCerrar;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Reporte;
        private Klik.Windows.Forms.v1.EntryLib.ELEntryBox txt_Nombre;
        private Klik.Windows.Forms.v1.EntryLib.ELCheckBox cb_Check;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Archivos;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Cancelar;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_Guardar;
    }
}