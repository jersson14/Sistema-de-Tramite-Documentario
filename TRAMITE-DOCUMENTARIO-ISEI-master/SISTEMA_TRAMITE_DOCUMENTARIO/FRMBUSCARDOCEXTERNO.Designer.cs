namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMBUSCARDOCEXTERNO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMBUSCARDOCEXTERNO));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.documento_externoDataGridView = new System.Windows.Forms.DataGridView();
            this.numeroCorrelativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRegistroMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroFolioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreTramitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniTramitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoTramitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaRegistroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagenDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nroDocumentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoexternoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.documento_externoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.documento_externoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.documento_externoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoexternoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(29, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 28);
            this.button3.TabIndex = 10;
            this.button3.Text = "Cancelar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(29, 23);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Enviar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // documento_externoDataGridView
            // 
            this.documento_externoDataGridView.AllowUserToAddRows = false;
            this.documento_externoDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.documento_externoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.documento_externoDataGridView.AutoGenerateColumns = false;
            this.documento_externoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documento_externoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.documento_externoDataGridView.ColumnHeadersHeight = 30;
            this.documento_externoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.documento_externoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroCorrelativoDataGridViewTextBoxColumn,
            this.numeroRegistroMPDataGridViewTextBoxColumn,
            this.tipodocumentoDataGridViewTextBoxColumn,
            this.numeroFolioDataGridViewTextBoxColumn,
            this.nombreTramitanteDataGridViewTextBoxColumn,
            this.dniTramitanteDataGridViewTextBoxColumn,
            this.asuntoTramitanteDataGridViewTextBoxColumn,
            this.idAreaDataGridViewTextBoxColumn,
            this.nombreAreaDataGridViewTextBoxColumn,
            this.fechaRegistroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn,
            this.imagenDataGridViewImageColumn,
            this.nroDocumentoDataGridViewTextBoxColumn});
            this.documento_externoDataGridView.DataSource = this.documentoexternoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.documento_externoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.documento_externoDataGridView.EnableHeadersVisualStyles = false;
            this.documento_externoDataGridView.Location = new System.Drawing.Point(19, 149);
            this.documento_externoDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.documento_externoDataGridView.Name = "documento_externoDataGridView";
            this.documento_externoDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.documento_externoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.documento_externoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.documento_externoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.documento_externoDataGridView.Size = new System.Drawing.Size(649, 210);
            this.documento_externoDataGridView.TabIndex = 12;
            // 
            // numeroCorrelativoDataGridViewTextBoxColumn
            // 
            this.numeroCorrelativoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn.HeaderText = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn.Name = "numeroCorrelativoDataGridViewTextBoxColumn";
            this.numeroCorrelativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroRegistroMPDataGridViewTextBoxColumn
            // 
            this.numeroRegistroMPDataGridViewTextBoxColumn.DataPropertyName = "Numero_Registro_MP";
            this.numeroRegistroMPDataGridViewTextBoxColumn.HeaderText = "Numero_Registro_MP";
            this.numeroRegistroMPDataGridViewTextBoxColumn.Name = "numeroRegistroMPDataGridViewTextBoxColumn";
            this.numeroRegistroMPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipodocumentoDataGridViewTextBoxColumn
            // 
            this.tipodocumentoDataGridViewTextBoxColumn.DataPropertyName = "Tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo_documento";
            this.tipodocumentoDataGridViewTextBoxColumn.Name = "tipodocumentoDataGridViewTextBoxColumn";
            this.tipodocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroFolioDataGridViewTextBoxColumn
            // 
            this.numeroFolioDataGridViewTextBoxColumn.DataPropertyName = "Numero_Folio";
            this.numeroFolioDataGridViewTextBoxColumn.HeaderText = "Numero_Folio";
            this.numeroFolioDataGridViewTextBoxColumn.Name = "numeroFolioDataGridViewTextBoxColumn";
            this.numeroFolioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreTramitanteDataGridViewTextBoxColumn
            // 
            this.nombreTramitanteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Tramitante";
            this.nombreTramitanteDataGridViewTextBoxColumn.HeaderText = "Nombre_Tramitante";
            this.nombreTramitanteDataGridViewTextBoxColumn.Name = "nombreTramitanteDataGridViewTextBoxColumn";
            this.nombreTramitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dniTramitanteDataGridViewTextBoxColumn
            // 
            this.dniTramitanteDataGridViewTextBoxColumn.DataPropertyName = "Dni_Tramitante";
            this.dniTramitanteDataGridViewTextBoxColumn.HeaderText = "Dni_Tramitante";
            this.dniTramitanteDataGridViewTextBoxColumn.Name = "dniTramitanteDataGridViewTextBoxColumn";
            this.dniTramitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asuntoTramitanteDataGridViewTextBoxColumn
            // 
            this.asuntoTramitanteDataGridViewTextBoxColumn.DataPropertyName = "Asunto_Tramitante";
            this.asuntoTramitanteDataGridViewTextBoxColumn.HeaderText = "Asunto_Tramitante";
            this.asuntoTramitanteDataGridViewTextBoxColumn.Name = "asuntoTramitanteDataGridViewTextBoxColumn";
            this.asuntoTramitanteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreAreaDataGridViewTextBoxColumn
            // 
            this.nombreAreaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn.HeaderText = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn.Name = "nombreAreaDataGridViewTextBoxColumn";
            this.nombreAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaRegistroDataGridViewTextBoxColumn
            // 
            this.fechaRegistroDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Registro";
            this.fechaRegistroDataGridViewTextBoxColumn.HeaderText = "Fecha_Registro";
            this.fechaRegistroDataGridViewTextBoxColumn.Name = "fechaRegistroDataGridViewTextBoxColumn";
            this.fechaRegistroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // observacionDataGridViewTextBoxColumn
            // 
            this.observacionDataGridViewTextBoxColumn.DataPropertyName = "Observacion";
            this.observacionDataGridViewTextBoxColumn.HeaderText = "Observacion";
            this.observacionDataGridViewTextBoxColumn.Name = "observacionDataGridViewTextBoxColumn";
            this.observacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imagenDataGridViewImageColumn
            // 
            this.imagenDataGridViewImageColumn.DataPropertyName = "Imagen";
            this.imagenDataGridViewImageColumn.HeaderText = "Imagen";
            this.imagenDataGridViewImageColumn.Name = "imagenDataGridViewImageColumn";
            this.imagenDataGridViewImageColumn.ReadOnly = true;
            // 
            // nroDocumentoDataGridViewTextBoxColumn
            // 
            this.nroDocumentoDataGridViewTextBoxColumn.DataPropertyName = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.HeaderText = "Nro_Documento";
            this.nroDocumentoDataGridViewTextBoxColumn.Name = "nroDocumentoDataGridViewTextBoxColumn";
            this.nroDocumentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoexternoBindingSource
            // 
            this.documentoexternoBindingSource.DataMember = "documento_externo";
            this.documentoexternoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documento_externoTableAdapter
            // 
            this.documento_externoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = this.documento_externoTableAdapter;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(513, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(443, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 74;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(409, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 25);
            this.button4.TabIndex = 73;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(224, 24);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(179, 22);
            this.txtbuscar.TabIndex = 72;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE TRAMITANTE",
            "DNI",
            "CODIGO MP"});
            this.cbbuscar.Location = new System.Drawing.Point(97, 23);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 71;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 70;
            this.label2.Text = "Buscar por:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtbuscar);
            this.groupBox2.Controls.Add(this.cbbuscar);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(19, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 59);
            this.groupBox2.TabIndex = 75;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 29);
            this.label1.TabIndex = 424;
            this.label1.Text = "Buscar Documento Externo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 362);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 432;
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
            // FRMBUSCARDOCEXTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(681, 388);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.documento_externoDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 427);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(697, 427);
            this.Name = "FRMBUSCARDOCEXTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRMBUSCARDOCEXTERNO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documento_externoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentoexternoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.documento_externoTableAdapter documento_externoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView documento_externoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCorrelativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRegistroMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroFolioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTramitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniTramitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoTramitanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaRegistroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagenDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDocumentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource documentoexternoBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}