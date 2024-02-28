namespace Stock_Sistemas
{
    partial class frm_Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Reportes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Elipse_Form = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_Reportes = new System.Windows.Forms.DataGridView();
            this.p_BarraTitulo = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NuevoReporte = new Klik.Windows.Forms.v1.EntryLib.ELButton();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Elipse_Close = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.idReporteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xMLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reportesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).BeginInit();
            this.p_BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NuevoReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipse_Form
            // 
            this.Elipse_Form.ElipseRadius = 15;
            this.Elipse_Form.TargetControl = this;
            // 
            // dgv_Reportes
            // 
            this.dgv_Reportes.AllowUserToAddRows = false;
            this.dgv_Reportes.AllowUserToDeleteRows = false;
            this.dgv_Reportes.AllowUserToResizeColumns = false;
            this.dgv_Reportes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Reportes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Reportes.AutoGenerateColumns = false;
            this.dgv_Reportes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Reportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Reportes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Reportes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Reportes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Reportes.ColumnHeadersHeight = 30;
            this.dgv_Reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Reportes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idReporteDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.xMLDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.Editar,
            this.Eliminar});
            this.dgv_Reportes.DataSource = this.reportesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Reportes.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Reportes.EnableHeadersVisualStyles = false;
            this.dgv_Reportes.GridColor = System.Drawing.Color.Silver;
            this.dgv_Reportes.Location = new System.Drawing.Point(12, 85);
            this.dgv_Reportes.Name = "dgv_Reportes";
            this.dgv_Reportes.ReadOnly = true;
            this.dgv_Reportes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Reportes.RowHeadersVisible = false;
            this.dgv_Reportes.RowTemplate.Height = 25;
            this.dgv_Reportes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Reportes.Size = new System.Drawing.Size(500, 218);
            this.dgv_Reportes.TabIndex = 0;
            this.dgv_Reportes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Reportes_CellContentClick);
            this.dgv_Reportes.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgv_Reportes_CurrentCellDirtyStateChanged);
            // 
            // p_BarraTitulo
            // 
            this.p_BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.p_BarraTitulo.Controls.Add(this.btn_Cerrar);
            this.p_BarraTitulo.Controls.Add(this.label1);
            this.p_BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.p_BarraTitulo.Name = "p_BarraTitulo";
            this.p_BarraTitulo.Size = new System.Drawing.Size(524, 30);
            this.p_BarraTitulo.TabIndex = 1;
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cerrar.BackgroundImage")));
            this.btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Location = new System.Drawing.Point(482, 0);
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
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reportes";
            // 
            // btn_NuevoReporte
            // 
            this.btn_NuevoReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NuevoReporte.BackgroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoReporte.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_NuevoReporte.BackgroundStyle.SolidColor = System.Drawing.Color.White;
            this.btn_NuevoReporte.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_NuevoReporte.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_NuevoReporte.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_NuevoReporte.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Chamfer;
            this.btn_NuevoReporte.BorderStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.btn_NuevoReporte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NuevoReporte.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid;
            this.btn_NuevoReporte.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(191)))));
            this.btn_NuevoReporte.ForegroundImageStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btn_NuevoReporte.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NuevoReporte.Location = new System.Drawing.Point(395, 49);
            this.btn_NuevoReporte.Name = "btn_NuevoReporte";
            this.btn_NuevoReporte.Size = new System.Drawing.Size(117, 30);
            this.btn_NuevoReporte.StateStyles.HoverStyle.BackgroundSolidColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(81)))), ((int)(((byte)(135)))));
            this.btn_NuevoReporte.StateStyles.HoverStyle.TextForeColor = System.Drawing.Color.White;
            this.btn_NuevoReporte.TabIndex = 2;
            this.btn_NuevoReporte.TextStyle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NuevoReporte.TextStyle.Text = "Nuevo reporte";
            this.btn_NuevoReporte.VisualStyle = Klik.Windows.Forms.v1.EntryLib.ButtonVisualStyles.Custom;
            this.btn_NuevoReporte.Click += new System.EventHandler(this.btn_NuevoReporte_Click);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Eliminar.Image")));
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 50;
            // 
            // Elipse_Close
            // 
            this.Elipse_Close.ElipseRadius = 5;
            this.Elipse_Close.TargetControl = this.btn_Cerrar;
            // 
            // idReporteDataGridViewTextBoxColumn
            // 
            this.idReporteDataGridViewTextBoxColumn.DataPropertyName = "Id_Reporte";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.idReporteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.idReporteDataGridViewTextBoxColumn.HeaderText = "Id Reporte";
            this.idReporteDataGridViewTextBoxColumn.Name = "idReporteDataGridViewTextBoxColumn";
            this.idReporteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // xMLDataGridViewTextBoxColumn
            // 
            this.xMLDataGridViewTextBoxColumn.DataPropertyName = "XML";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.xMLDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.xMLDataGridViewTextBoxColumn.HeaderText = "XML";
            this.xMLDataGridViewTextBoxColumn.Name = "xMLDataGridViewTextBoxColumn";
            this.xMLDataGridViewTextBoxColumn.ReadOnly = true;
            this.xMLDataGridViewTextBoxColumn.Width = 50;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.FalseValue = "0";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.estatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.estatusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.estatusDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // reportesBindingSource
            // 
            this.reportesBindingSource.DataSource = typeof(Business_Layer.Entidades.Reportes);
            // 
            // frm_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(524, 315);
            this.Controls.Add(this.btn_NuevoReporte);
            this.Controls.Add(this.p_BarraTitulo);
            this.Controls.Add(this.dgv_Reportes);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Reportes)).EndInit();
            this.p_BarraTitulo.ResumeLayout(false);
            this.p_BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_NuevoReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse Elipse_Form;
        private System.Windows.Forms.DataGridView dgv_Reportes;
        private System.Windows.Forms.Panel p_BarraTitulo;
        private System.Windows.Forms.BindingSource reportesBindingSource;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Label label1;
        private Klik.Windows.Forms.v1.EntryLib.ELButton btn_NuevoReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn idReporteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xMLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Close;
    }
}