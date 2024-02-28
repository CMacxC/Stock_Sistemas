namespace Stock_Sistemas
{
    partial class frm_Principal
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
            this.pMenu = new System.Windows.Forms.Panel();
            this.btn_Reportes = new FontAwesome.Sharp.IconButton();
            this.btn_Materiales = new FontAwesome.Sharp.IconButton();
            this.btn_Movimientos = new FontAwesome.Sharp.IconButton();
            this.btn_Existencias = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pBar = new System.Windows.Forms.Panel();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_ResMax = new FontAwesome.Sharp.IconButton();
            this.btn_Cerrar = new FontAwesome.Sharp.IconButton();
            this.lbl_TitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pContainer = new System.Windows.Forms.Panel();
            this.Elipse_Close = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_ResMax = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Elipse_Minimizar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pMenu.Controls.Add(this.btn_Reportes);
            this.pMenu.Controls.Add(this.btn_Materiales);
            this.pMenu.Controls.Add(this.btn_Movimientos);
            this.pMenu.Controls.Add(this.btn_Existencias);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(220, 499);
            this.pMenu.TabIndex = 0;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Reportes.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.btn_Reportes.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Reportes.IconSize = 32;
            this.btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.Location = new System.Drawing.Point(0, 290);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Reportes.Size = new System.Drawing.Size(220, 50);
            this.btn_Reportes.TabIndex = 4;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            // 
            // btn_Materiales
            // 
            this.btn_Materiales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Materiales.FlatAppearance.BorderSize = 0;
            this.btn_Materiales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Materiales.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Materiales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Materiales.IconChar = FontAwesome.Sharp.IconChar.ProjectDiagram;
            this.btn_Materiales.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Materiales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Materiales.IconSize = 32;
            this.btn_Materiales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Materiales.Location = new System.Drawing.Point(0, 240);
            this.btn_Materiales.Name = "btn_Materiales";
            this.btn_Materiales.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Materiales.Size = new System.Drawing.Size(220, 50);
            this.btn_Materiales.TabIndex = 3;
            this.btn_Materiales.Text = "Materiales";
            this.btn_Materiales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Materiales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Materiales.UseVisualStyleBackColor = true;
            this.btn_Materiales.Click += new System.EventHandler(this.btn_Materiales_Click);
            // 
            // btn_Movimientos
            // 
            this.btn_Movimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Movimientos.FlatAppearance.BorderSize = 0;
            this.btn_Movimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Movimientos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Movimientos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Movimientos.IconChar = FontAwesome.Sharp.IconChar.Exchange;
            this.btn_Movimientos.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Movimientos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Movimientos.IconSize = 32;
            this.btn_Movimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Movimientos.Location = new System.Drawing.Point(0, 190);
            this.btn_Movimientos.Name = "btn_Movimientos";
            this.btn_Movimientos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Movimientos.Size = new System.Drawing.Size(220, 50);
            this.btn_Movimientos.TabIndex = 2;
            this.btn_Movimientos.Text = "Movimientos";
            this.btn_Movimientos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Movimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Movimientos.UseVisualStyleBackColor = true;
            this.btn_Movimientos.Click += new System.EventHandler(this.btn_Movimientos_Click);
            // 
            // btn_Existencias
            // 
            this.btn_Existencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Existencias.FlatAppearance.BorderSize = 0;
            this.btn_Existencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Existencias.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Existencias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Existencias.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.btn_Existencias.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Existencias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Existencias.IconSize = 32;
            this.btn_Existencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Existencias.Location = new System.Drawing.Point(0, 140);
            this.btn_Existencias.Name = "btn_Existencias";
            this.btn_Existencias.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Existencias.Size = new System.Drawing.Size(220, 50);
            this.btn_Existencias.TabIndex = 1;
            this.btn_Existencias.Text = "Existencias";
            this.btn_Existencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Existencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Existencias.UseVisualStyleBackColor = true;
            this.btn_Existencias.Click += new System.EventHandler(this.btn_Existencias_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.label1);
            this.pLogo.Controls.Add(this.pbLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(220, 140);
            this.pLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Moccasin;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Stock Sistemas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(12, 10);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(195, 48);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Click += new System.EventHandler(this.pbLogo_Click);
            // 
            // pBar
            // 
            this.pBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.pBar.Controls.Add(this.btn_Minimize);
            this.pBar.Controls.Add(this.btn_ResMax);
            this.pBar.Controls.Add(this.btn_Cerrar);
            this.pBar.Controls.Add(this.lbl_TitleChildForm);
            this.pBar.Controls.Add(this.iconCurrentChildForm);
            this.pBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBar.Location = new System.Drawing.Point(220, 0);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(580, 100);
            this.pBar.TabIndex = 1;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 16;
            this.btn_Minimize.Location = new System.Drawing.Point(475, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_ResMax
            // 
            this.btn_ResMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ResMax.FlatAppearance.BorderSize = 0;
            this.btn_ResMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResMax.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_ResMax.IconColor = System.Drawing.Color.White;
            this.btn_ResMax.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ResMax.IconSize = 16;
            this.btn_ResMax.Location = new System.Drawing.Point(511, 3);
            this.btn_ResMax.Name = "btn_ResMax";
            this.btn_ResMax.Size = new System.Drawing.Size(30, 30);
            this.btn_ResMax.TabIndex = 3;
            this.btn_ResMax.UseVisualStyleBackColor = true;
            this.btn_ResMax.Click += new System.EventHandler(this.btn_ResMax_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btn_Cerrar.IconColor = System.Drawing.Color.White;
            this.btn_Cerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Cerrar.IconSize = 16;
            this.btn_Cerrar.Location = new System.Drawing.Point(547, 3);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(30, 30);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.UseVisualStyleBackColor = true;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // lbl_TitleChildForm
            // 
            this.lbl_TitleChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_TitleChildForm.Location = new System.Drawing.Point(44, 61);
            this.lbl_TitleChildForm.Name = "lbl_TitleChildForm";
            this.lbl_TitleChildForm.Size = new System.Drawing.Size(128, 32);
            this.lbl_TitleChildForm.TabIndex = 1;
            this.lbl_TitleChildForm.Text = "Inicio";
            this.lbl_TitleChildForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.DarkSalmon;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.DarkSalmon;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(6, 61);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // pContainer
            // 
            this.pContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(173)))), ((int)(((byte)(214)))));
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(220, 100);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(580, 399);
            this.pContainer.TabIndex = 2;
            // 
            // Elipse_Close
            // 
            this.Elipse_Close.ElipseRadius = 5;
            this.Elipse_Close.TargetControl = this.btn_Cerrar;
            // 
            // Elipse_ResMax
            // 
            this.Elipse_ResMax.ElipseRadius = 5;
            this.Elipse_ResMax.TargetControl = this.btn_ResMax;
            // 
            // Elipse_Minimizar
            // 
            this.Elipse_Minimizar.ElipseRadius = 5;
            this.Elipse_Minimizar.TargetControl = this.btn_Minimize;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.pMenu);
            this.Name = "frm_Principal";
            this.Text = "Stock_Sistemas";
            this.Load += new System.EventHandler(this.frm_Principal_Load);
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel pBar;
        private System.Windows.Forms.Panel pContainer;
        private FontAwesome.Sharp.IconButton btn_Existencias;
        private System.Windows.Forms.Panel pLogo;
        private FontAwesome.Sharp.IconButton btn_Reportes;
        private FontAwesome.Sharp.IconButton btn_Materiales;
        private FontAwesome.Sharp.IconButton btn_Movimientos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbl_TitleChildForm;
        private FontAwesome.Sharp.IconButton btn_Cerrar;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Close;
        private FontAwesome.Sharp.IconButton btn_ResMax;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private Bunifu.Framework.UI.BunifuElipse Elipse_ResMax;
        private Bunifu.Framework.UI.BunifuElipse Elipse_Minimizar;
    }
}

