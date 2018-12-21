namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMBUSCARDOCINTERNO
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBUSCARDOCINTERNO));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvbuscardocinterno = new System.Windows.Forms.DataGridView();
            this.numeroCorrelativoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRegistroMPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFolioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTramitanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniTramitanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoTramitanteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAreaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAreaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.documentointernoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.documento_internoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.documento_internoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscardocinterno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentointernoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(26, 58);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(26, 21);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Enviar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvbuscardocinterno
            // 
            this.dgvbuscardocinterno.AllowUserToAddRows = false;
            this.dgvbuscardocinterno.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvbuscardocinterno.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvbuscardocinterno.AutoGenerateColumns = false;
            this.dgvbuscardocinterno.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbuscardocinterno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvbuscardocinterno.ColumnHeadersHeight = 30;
            this.dgvbuscardocinterno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvbuscardocinterno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCorrelativoDataGridViewTextBoxColumn1,
            this.numeroRegistroMPDataGridViewTextBoxColumn1,
            this.tipodocumentoDataGridViewTextBoxColumn1,
            this.nroDocumentoDataGridViewTextBoxColumn,
            this.numeroFolioDataGridViewTextBoxColumn1,
            this.nombreTramitanteDataGridViewTextBoxColumn1,
            this.dniTramitanteDataGridViewTextBoxColumn1,
            this.asuntoTramitanteDataGridViewTextBoxColumn1,
            this.idAreaDataGridViewTextBoxColumn1,
            this.nombreAreaDataGridViewTextBoxColumn1,
            this.fechaRegistroDataGridViewTextBoxColumn1,
            this.estadoDataGridViewTextBoxColumn1,
            this.observacionDataGridViewTextBoxColumn1,
            this.imagenDataGridViewImageColumn1});
            this.dgvbuscardocinterno.DataSource = this.documentointernoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvbuscardocinterno.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbuscardocinterno.EnableHeadersVisualStyles = false;
            this.dgvbuscardocinterno.Location = new System.Drawing.Point(13, 129);
            this.dgvbuscardocinterno.Margin = new System.Windows.Forms.Padding(4);
            this.dgvbuscardocinterno.Name = "dgvbuscardocinterno";
            this.dgvbuscardocinterno.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbuscardocinterno.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvbuscardocinterno.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvbuscardocinterno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvbuscardocinterno.Size = new System.Drawing.Size(622, 200);
            this.dgvbuscardocinterno.TabIndex = 4;
            this.dgvbuscardocinterno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuscardocinterno_CellContentClick);
            // 
            // numeroCorrelativoDataGridViewTextBoxColumn1
            // 
            this.numeroCorrelativoDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn1.HeaderText = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn1.Name = "numeroCorrelativoDataGridViewTextBoxColumn1";
            this.numeroCorrelativoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // numeroRegistroMPDataGridViewTextBoxColumn1
            // 
            this.numeroRegistroMPDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Registro_MP";
            this.numeroRegistroMPDataGridViewTextBoxColumn1.HeaderText = "Numero_Registro_MP";
            this.numeroRegistroMPDataGridViewTextBoxColumn1.Name = "numeroRegistroMPDataGridViewTextBoxColumn1";
            this.numeroRegistroMPDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tipodocumentoDataGridViewTextBoxColumn1
            // 
            this.tipodocumentoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn1.HeaderText = "Tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn1.Name = "tipodocumentoDataGridViewTextBoxColumn1";
            this.tipodocumentoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFolioDataGridViewTextBoxColumn1
            // 
            this.numeroFolioDataGridViewTextBoxColumn1.DataPropertyName = "Numero_Folio";
            this.numeroFolioDataGridViewTextBoxColumn1.HeaderText = "Numero_Folio";
            this.numeroFolioDataGridViewTextBoxColumn1.Name = "numeroFolioDataGridViewTextBoxColumn1";
            this.numeroFolioDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreTramitanteDataGridViewTextBoxColumn1
            // 
            this.nombreTramitanteDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_Tramitante";
            this.nombreTramitanteDataGridViewTextBoxColumn1.HeaderText = "Nombre_Tramitante";
            this.nombreTramitanteDataGridViewTextBoxColumn1.Name = "nombreTramitanteDataGridViewTextBoxColumn1";
            this.nombreTramitanteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dniTramitanteDataGridViewTextBoxColumn1
            // 
            this.dniTramitanteDataGridViewTextBoxColumn1.DataPropertyName = "Dni_Tramitante";
            this.dniTramitanteDataGridViewTextBoxColumn1.HeaderText = "Dni_Tramitante";
            this.dniTramitanteDataGridViewTextBoxColumn1.Name = "dniTramitanteDataGridViewTextBoxColumn1";
            this.dniTramitanteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // asuntoTramitanteDataGridViewTextBoxColumn1
            // 
            this.asuntoTramitanteDataGridViewTextBoxColumn1.DataPropertyName = "Asunto_Tramitante";
            this.asuntoTramitanteDataGridViewTextBoxColumn1.HeaderText = "Asunto_Tramitante";
            this.asuntoTramitanteDataGridViewTextBoxColumn1.Name = "asuntoTramitanteDataGridViewTextBoxColumn1";
            this.asuntoTramitanteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idAreaDataGridViewTextBoxColumn1
            // 
            this.idAreaDataGridViewTextBoxColumn1.DataPropertyName = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn1.HeaderText = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn1.Name = "idAreaDataGridViewTextBoxColumn1";
            this.idAreaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nombreAreaDataGridViewTextBoxColumn1
            // 
            this.nombreAreaDataGridViewTextBoxColumn1.DataPropertyName = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn1.HeaderText = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn1.Name = "nombreAreaDataGridViewTextBoxColumn1";
            this.nombreAreaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn1
            // 
            this.fechaRegistroDataGridViewTextBoxColumn1.DataPropertyName = "Fecha_Registro";
            this.fechaRegistroDataGridViewTextBoxColumn1.HeaderText = "Fecha_Registro";
            this.fechaRegistroDataGridViewTextBoxColumn1.Name = "fechaRegistroDataGridViewTextBoxColumn1";
            this.fechaRegistroDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn1
            // 
            this.estadoDataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn1.Name = "estadoDataGridViewTextBoxColumn1";
            this.estadoDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // observacionDataGridViewTextBoxColumn1
            // 
            this.observacionDataGridViewTextBoxColumn1.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn1.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn1.Name = "observacionDataGridViewTextBoxColumn1";
            this.observacionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn1
            // 
            this.imagenDataGridViewImageColumn1.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn1.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn1.Name = "imagenDataGridViewImageColumn1";
            this.imagenDataGridViewImageColumn1.ReadOnly = true;
            // 
            // documentointernoBindingSource
            // 
            this.documentointernoBindingSource.DataMember = "documento_interno";
            this.documentointernoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(490, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 94);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(429, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 69;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(395, 25);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 23);
            this.button4.TabIndex = 68;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(215, 25);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(174, 22);
            this.txtbuscar.TabIndex = 67;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE TRAMITANTE",
            "DNI",
            "AREA",
            "CODIGO MP"});
            this.cbbuscar.Location = new System.Drawing.Point(90, 25);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(5, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar por:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(651, 29);
            this.label2.TabIndex = 423;
            this.label2.Text = "Buscar Documento Interno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(651, 22);
            this.statusStrip1.TabIndex = 431;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.toolStripStatusLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
            this.toolStripStatusLabel1.Text = "SITDO Version 1.0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.cbbuscar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(13, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 73);
            this.groupBox2.TabIndex = 432;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // documento_internoTableAdapter
            // 
            this.documento_internoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = this.documento_internoTableAdapter;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRMBUSCARDOCINTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(651, 356);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvbuscardocinterno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(667, 395);
            this.MinimumSize = new System.Drawing.Size(667, 395);
            this.Name = "FRMBUSCARDOCINTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRMBUSCARDOCINTERNO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuscardocinterno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentointernoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.documento_internoTableAdapter documento_internoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvbuscardocinterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCorrelativoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRegistroMPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFolioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTramitanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniTramitanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoTramitanteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAreaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn1;
        private System.Windows.Forms.BindingSource documentointernoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}