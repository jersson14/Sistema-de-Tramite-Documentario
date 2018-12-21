namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMMENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMMENU));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.derivarDocInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.derivarDocExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.docInternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docExternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelizquierdo = new System.Windows.Forms.Panel();
            this.BTNUSUARIOS = new System.Windows.Forms.Button();
            this.BTNNUEVATRA = new System.Windows.Forms.Button();
            this.BTNNUEVOINTERNO = new System.Windows.Forms.Button();
            this.BTNNUEVOEXTERNO = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelizquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.statusStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("statusStrip1.BackgroundImage")));
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(200, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(850, 22);
            this.statusStrip1.TabIndex = 330;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel1.BackgroundImage")));
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "SITPO Version 1.0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabel2.BackgroundImage")));
            this.toolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(718, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.utea_01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 561);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.toolStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 29);
            this.panel2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.derivarDocInternoToolStripMenuItem,
            this.derivarDocExternoToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Group_Message_48px;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(152, 22);
            this.toolStripDropDownButton1.Text = "Derivar Documentos";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // derivarDocInternoToolStripMenuItem
            // 
            this.derivarDocInternoToolStripMenuItem.Name = "derivarDocInternoToolStripMenuItem";
            this.derivarDocInternoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.derivarDocInternoToolStripMenuItem.Text = "Derivar Doc. Interno";
            this.derivarDocInternoToolStripMenuItem.Click += new System.EventHandler(this.derivarDocInternoToolStripMenuItem_Click);
            // 
            // derivarDocExternoToolStripMenuItem
            // 
            this.derivarDocExternoToolStripMenuItem.Name = "derivarDocExternoToolStripMenuItem";
            this.derivarDocExternoToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.derivarDocExternoToolStripMenuItem.Text = "Derivar Doc. Externo";
            this.derivarDocExternoToolStripMenuItem.Click += new System.EventHandler(this.derivarDocExternoToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docInternoToolStripMenuItem,
            this.docExternoToolStripMenuItem});
            this.toolStripDropDownButton2.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.View_File_48px;
            this.toolStripDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(124, 22);
            this.toolStripDropDownButton2.Text = "Ver Documento";
            // 
            // docInternoToolStripMenuItem
            // 
            this.docInternoToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.new_page_document_16676;
            this.docInternoToolStripMenuItem.Name = "docInternoToolStripMenuItem";
            this.docInternoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docInternoToolStripMenuItem.Text = "Doc. Interno";
            this.docInternoToolStripMenuItem.Click += new System.EventHandler(this.docInternoToolStripMenuItem_Click);
            // 
            // docExternoToolStripMenuItem
            // 
            this.docExternoToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.new_page_document_16676;
            this.docExternoToolStripMenuItem.Name = "docExternoToolStripMenuItem";
            this.docExternoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.docExternoToolStripMenuItem.Text = "Doc. Externo";
            this.docExternoToolStripMenuItem.Click += new System.EventHandler(this.docExternoToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem,
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem,
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem,
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem,
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem});
            this.toolStripDropDownButton3.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Dossier_32;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(120, 22);
            this.toolStripDropDownButton3.Text = "Estado del Doc.";
            // 
            // busquedaDeDocumetosInternosPorFechaToolStripMenuItem
            // 
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Image")));
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Name = "busquedaDeDocumetosInternosPorFechaToolStripMenuItem";
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Text = "Busqueda de Documetos Internos por Fecha";
            this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeDocumetosInternosPorFechaToolStripMenuItem_Click);
            // 
            // busquedaDeDocumentosExternosPorFechaToolStripMenuItem
            // 
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.arrow_right_15604;
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem.Name = "busquedaDeDocumentosExternosPorFechaToolStripMenuItem";
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem.Text = "Busqueda de Documentos Externos por Fecha";
            this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeDocumentosExternosPorFechaToolStripMenuItem_Click);
            // 
            // buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem
            // 
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.arrow_right_15604;
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem.Name = "buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem";
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem.Text = "Buscaqueda de Documentos Internos por Área";
            this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem.Click += new System.EventHandler(this.buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem_Click);
            // 
            // busquedaDeDocumentosExternosPorÁreaToolStripMenuItem
            // 
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.arrow_right_15604;
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem.Name = "busquedaDeDocumentosExternosPorÁreaToolStripMenuItem";
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem.Text = "Busqueda de Documentos Externos por Área";
            this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeDocumentosExternosPorÁreaToolStripMenuItem_Click);
            // 
            // cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem
            // 
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.arrow_right_15604;
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem.Name = "cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem";
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem.Size = new System.Drawing.Size(388, 22);
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem.Text = "Cantidad de Documentos Enviados por Área y Tramitante";
            this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem_Click);
            // 
            // panelizquierdo
            // 
            this.panelizquierdo.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelizquierdo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelizquierdo.BackgroundImage")));
            this.panelizquierdo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelizquierdo.Controls.Add(this.BTNUSUARIOS);
            this.panelizquierdo.Controls.Add(this.BTNNUEVATRA);
            this.panelizquierdo.Controls.Add(this.BTNNUEVOINTERNO);
            this.panelizquierdo.Controls.Add(this.BTNNUEVOEXTERNO);
            this.panelizquierdo.Controls.Add(this.pictureBox5);
            this.panelizquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelizquierdo.Location = new System.Drawing.Point(0, 0);
            this.panelizquierdo.Name = "panelizquierdo";
            this.panelizquierdo.Size = new System.Drawing.Size(200, 561);
            this.panelizquierdo.TabIndex = 3;
            // 
            // BTNUSUARIOS
            // 
            this.BTNUSUARIOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNUSUARIOS.BackgroundImage")));
            this.BTNUSUARIOS.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.BTNUSUARIOS.FlatAppearance.BorderSize = 0;
            this.BTNUSUARIOS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BTNUSUARIOS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNUSUARIOS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNUSUARIOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUSUARIOS.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNUSUARIOS.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNUSUARIOS.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.User_48px;
            this.BTNUSUARIOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNUSUARIOS.Location = new System.Drawing.Point(6, 335);
            this.BTNUSUARIOS.Name = "BTNUSUARIOS";
            this.BTNUSUARIOS.Size = new System.Drawing.Size(184, 44);
            this.BTNUSUARIOS.TabIndex = 5;
            this.BTNUSUARIOS.Text = "Nuevos usuarios";
            this.BTNUSUARIOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNUSUARIOS.UseVisualStyleBackColor = true;
            this.BTNUSUARIOS.Click += new System.EventHandler(this.BTNUSUARIOS_Click);
            // 
            // BTNNUEVATRA
            // 
            this.BTNNUEVATRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNUEVATRA.BackgroundImage")));
            this.BTNNUEVATRA.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.BTNNUEVATRA.FlatAppearance.BorderSize = 0;
            this.BTNNUEVATRA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BTNNUEVATRA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNNUEVATRA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNNUEVATRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVATRA.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVATRA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNNUEVATRA.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Home_48px;
            this.BTNNUEVATRA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVATRA.Location = new System.Drawing.Point(6, 285);
            this.BTNNUEVATRA.Name = "BTNNUEVATRA";
            this.BTNNUEVATRA.Size = new System.Drawing.Size(184, 44);
            this.BTNNUEVATRA.TabIndex = 4;
            this.BTNNUEVATRA.Text = "Nueva Area";
            this.BTNNUEVATRA.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVATRA.UseVisualStyleBackColor = true;
            this.BTNNUEVATRA.Click += new System.EventHandler(this.BTNNUEVATRA_Click);
            // 
            // BTNNUEVOINTERNO
            // 
            this.BTNNUEVOINTERNO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNUEVOINTERNO.BackgroundImage")));
            this.BTNNUEVOINTERNO.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.BTNNUEVOINTERNO.FlatAppearance.BorderSize = 0;
            this.BTNNUEVOINTERNO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BTNNUEVOINTERNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNNUEVOINTERNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNNUEVOINTERNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVOINTERNO.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVOINTERNO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNNUEVOINTERNO.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Add_Property_48px;
            this.BTNNUEVOINTERNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVOINTERNO.Location = new System.Drawing.Point(6, 235);
            this.BTNNUEVOINTERNO.Name = "BTNNUEVOINTERNO";
            this.BTNNUEVOINTERNO.Size = new System.Drawing.Size(184, 44);
            this.BTNNUEVOINTERNO.TabIndex = 2;
            this.BTNNUEVOINTERNO.Text = "Nuevo Doc Interno";
            this.BTNNUEVOINTERNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVOINTERNO.UseVisualStyleBackColor = true;
            this.BTNNUEVOINTERNO.Click += new System.EventHandler(this.BTNNUEVOINTERNO_Click);
            // 
            // BTNNUEVOEXTERNO
            // 
            this.BTNNUEVOEXTERNO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNUEVOEXTERNO.BackgroundImage")));
            this.BTNNUEVOEXTERNO.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.BTNNUEVOEXTERNO.FlatAppearance.BorderSize = 0;
            this.BTNNUEVOEXTERNO.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.BTNNUEVOEXTERNO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BTNNUEVOEXTERNO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTNNUEVOEXTERNO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVOEXTERNO.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVOEXTERNO.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BTNNUEVOEXTERNO.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Add_Property_48px;
            this.BTNNUEVOEXTERNO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVOEXTERNO.Location = new System.Drawing.Point(6, 184);
            this.BTNNUEVOEXTERNO.Name = "BTNNUEVOEXTERNO";
            this.BTNNUEVOEXTERNO.Size = new System.Drawing.Size(184, 44);
            this.BTNNUEVOEXTERNO.TabIndex = 1;
            this.BTNNUEVOEXTERNO.Text = "Nuevo Doc Externo";
            this.BTNNUEVOEXTERNO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVOEXTERNO.UseVisualStyleBackColor = true;
            this.BTNNUEVOEXTERNO.Click += new System.EventHandler(this.BTNNUEVOEXTERNO_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Logo_EPISeI;
            this.pictureBox5.Location = new System.Drawing.Point(2, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(194, 163);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // FRMMENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1050, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelizquierdo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMMENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMMENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FRMMENU_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelizquierdo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelizquierdo;
        private System.Windows.Forms.Button BTNNUEVATRA;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem derivarDocInternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem derivarDocExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docInternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docExternoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        public System.Windows.Forms.Button BTNUSUARIOS;
        public System.Windows.Forms.Button BTNNUEVOINTERNO;
        public System.Windows.Forms.Button BTNNUEVOEXTERNO;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeDocumetosInternosPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeDocumentosExternosPorFechaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscaquedaDeDocumentosInternosPorAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeDocumentosExternosPorÁreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeDocumentosEnviadosPorÁreaYTramitanteToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}