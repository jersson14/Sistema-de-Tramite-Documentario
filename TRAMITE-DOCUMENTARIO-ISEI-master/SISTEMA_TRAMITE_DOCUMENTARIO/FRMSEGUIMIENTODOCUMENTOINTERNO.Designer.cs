namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMSEGUIMIENTODOCUMENTOINTERNO
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
            System.Windows.Forms.Label numero_respuesta_intLabel;
            System.Windows.Forms.Label numero_correlativoLabel;
            System.Windows.Forms.Label derivar_areaLabel;
            System.Windows.Forms.Label fecha_salidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.Label asunto_documentoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSEGUIMIENTODOCUMENTOINTERNO));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numero_correlativoTextBox = new System.Windows.Forms.TextBox();
            this.detalledocumentointernoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.derivar_areaComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.asunto_documentoTextBox = new System.Windows.Forms.TextBox();
            this.numero_respuesta_intTextBox = new System.Windows.Forms.TextBox();
            this.detalle_documento_internoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.detalle_documento_internoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.detalle_documento_internoDataGridView = new System.Windows.Forms.DataGridView();
            this.numeroRespuestaInternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCorrelativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derivarAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            numero_respuesta_intLabel = new System.Windows.Forms.Label();
            numero_correlativoLabel = new System.Windows.Forms.Label();
            derivar_areaLabel = new System.Windows.Forms.Label();
            fecha_salidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            asunto_documentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalledocumentointernoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero_respuesta_intLabel
            // 
            numero_respuesta_intLabel.AutoSize = true;
            numero_respuesta_intLabel.Location = new System.Drawing.Point(166, 543);
            numero_respuesta_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_respuesta_intLabel.Name = "numero_respuesta_intLabel";
            numero_respuesta_intLabel.Size = new System.Drawing.Size(171, 16);
            numero_respuesta_intLabel.TabIndex = 0;
            numero_respuesta_intLabel.Text = "Numero Respuesta interno:";
            numero_respuesta_intLabel.Visible = false;
            // 
            // numero_correlativoLabel
            // 
            numero_correlativoLabel.AutoSize = true;
            numero_correlativoLabel.Location = new System.Drawing.Point(31, 26);
            numero_correlativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_correlativoLabel.Name = "numero_correlativoLabel";
            numero_correlativoLabel.Size = new System.Drawing.Size(146, 16);
            numero_correlativoLabel.TabIndex = 2;
            numero_correlativoLabel.Text = "Numero Correlativo:";
            // 
            // derivar_areaLabel
            // 
            derivar_areaLabel.AutoSize = true;
            derivar_areaLabel.Location = new System.Drawing.Point(77, 118);
            derivar_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            derivar_areaLabel.Name = "derivar_areaLabel";
            derivar_areaLabel.Size = new System.Drawing.Size(100, 16);
            derivar_areaLabel.TabIndex = 4;
            derivar_areaLabel.Text = "Derivar Área:";
            // 
            // fecha_salidaLabel
            // 
            fecha_salidaLabel.AutoSize = true;
            fecha_salidaLabel.Location = new System.Drawing.Point(73, 151);
            fecha_salidaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fecha_salidaLabel.Name = "fecha_salidaLabel";
            fecha_salidaLabel.Size = new System.Drawing.Size(104, 16);
            fecha_salidaLabel.TabIndex = 6;
            fecha_salidaLabel.Text = "Fecha Salida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(82, 178);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(95, 16);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "Descripción:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(116, 231);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(61, 16);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "Estado:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(77, 260);
            observacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(100, 16);
            observacionLabel.TabIndex = 12;
            observacionLabel.Text = "Observación:";
            // 
            // asunto_documentoLabel
            // 
            asunto_documentoLabel.AutoSize = true;
            asunto_documentoLabel.Location = new System.Drawing.Point(118, 56);
            asunto_documentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            asunto_documentoLabel.Name = "asunto_documentoLabel";
            asunto_documentoLabel.Size = new System.Drawing.Size(59, 16);
            asunto_documentoLabel.TabIndex = 14;
            asunto_documentoLabel.Text = "Asunto:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(numero_correlativoLabel);
            this.groupBox1.Controls.Add(this.numero_correlativoTextBox);
            this.groupBox1.Controls.Add(derivar_areaLabel);
            this.groupBox1.Controls.Add(this.derivar_areaComboBox);
            this.groupBox1.Controls.Add(fecha_salidaLabel);
            this.groupBox1.Controls.Add(this.fecha_salidaDateTimePicker);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(observacionLabel);
            this.groupBox1.Controls.Add(this.observacionTextBox);
            this.groupBox1.Controls.Add(asunto_documentoLabel);
            this.groupBox1.Controls.Add(this.asunto_documentoTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(19, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(460, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de seguimiento del Documento";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Settings_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(280, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 24);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numero_correlativoTextBox
            // 
            this.numero_correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Numero_Correlativo", true));
            this.numero_correlativoTextBox.Location = new System.Drawing.Point(180, 23);
            this.numero_correlativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numero_correlativoTextBox.Name = "numero_correlativoTextBox";
            this.numero_correlativoTextBox.Size = new System.Drawing.Size(92, 22);
            this.numero_correlativoTextBox.TabIndex = 2;
            this.numero_correlativoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_correlativoTextBox_KeyPress);
            // 
            // detalledocumentointernoBindingSource
            // 
            this.detalledocumentointernoBindingSource.DataMember = "detalle_documento_interno";
            this.detalledocumentointernoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // derivar_areaComboBox
            // 
            this.derivar_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Derivar_Area", true));
            this.derivar_areaComboBox.FormattingEnabled = true;
            this.derivar_areaComboBox.Items.AddRange(new object[] {
            "Rectorado",
            "Vice Rectorado Académico ",
            "Vice Rectorado de Investigación",
            "Ofic. de Control Interno ",
            "Ofic. de Asesoría Jurídica ",
            "Ofic. de Imagen Institucional ",
            "Ofic. de Planificación de Desarrollo Universitario",
            "Ofic. Cooperación Técnica y Relaciones Universitarias",
            "Dirección General de Administración ",
            "Sub Dirección de Contabilidad ",
            "Sub Dirección de Tesorería",
            "Área Cuentas por Cobrar",
            "Sub Dirección de Logística y Servicios Generales",
            "Sub Dirección de Proyectos y Obras",
            "Sub Dirección de Recursos Humanos",
            "Sub Dirección de Producciones de Bienes y Servicios",
            "Dirección  de Servicios Académicos",
            "Sub Dirección de Computo e Informática",
            "Dirección de Responsabilidad Social",
            "Biblioteca",
            "Bienestar Universitario",
            "Grados y Títulos",
            "Tribunal de Honor",
            "Caja",
            "Dirección de la Escuela de posgrado (EPG)",
            "Dirección de Calidad y Acreditación Universitaria (DCAU)",
            "Facultad de Ciencias Jurídicas, Contables y Sociales",
            "Escuela Profesional de Derecho",
            "Escuela Profesional de Contabilidad",
            "Escuela Profesional de Educación",
            "Escuela Profesional de Turismo, Hotelería y Gastronomía",
            "Facultad de Ciencias de la Salud",
            "Escuela Profesional de Enfermaría",
            "Escuela Profesional de Entomología",
            "Facultad de Ingeniería",
            "Escuela Profesional de Agronomía",
            "Escuela Profesional de Ingeniería Ambiental y Recursos Naturales",
            "Escuela Profesional de Ingeniería Civil",
            "Escuela Profesional de Ingeniería DE Sistemas e Informática"});
            this.derivar_areaComboBox.Location = new System.Drawing.Point(180, 115);
            this.derivar_areaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.derivar_areaComboBox.Name = "derivar_areaComboBox";
            this.derivar_areaComboBox.Size = new System.Drawing.Size(231, 24);
            this.derivar_areaComboBox.TabIndex = 4;
            // 
            // fecha_salidaDateTimePicker
            // 
            this.fecha_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detalledocumentointernoBindingSource, "Fecha_Salida", true));
            this.fecha_salidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_salidaDateTimePicker.Location = new System.Drawing.Point(180, 145);
            this.fecha_salidaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fecha_salidaDateTimePicker.Name = "fecha_salidaDateTimePicker";
            this.fecha_salidaDateTimePicker.Size = new System.Drawing.Size(231, 22);
            this.fecha_salidaDateTimePicker.TabIndex = 5;
            this.fecha_salidaDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_salidaDateTimePicker_ValueChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(180, 175);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descripcionTextBox.Size = new System.Drawing.Size(231, 45);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Archivado",
            "Proveido",
            "Obaservado"});
            this.estadoComboBox.Location = new System.Drawing.Point(180, 228);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(171, 24);
            this.estadoComboBox.TabIndex = 7;
            this.estadoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estadoComboBox_KeyPress);
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(180, 260);
            this.observacionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacionTextBox.Size = new System.Drawing.Size(231, 51);
            this.observacionTextBox.TabIndex = 8;
            // 
            // asunto_documentoTextBox
            // 
            this.asunto_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Asunto", true));
            this.asunto_documentoTextBox.Location = new System.Drawing.Point(180, 53);
            this.asunto_documentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.asunto_documentoTextBox.Multiline = true;
            this.asunto_documentoTextBox.Name = "asunto_documentoTextBox";
            this.asunto_documentoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asunto_documentoTextBox.Size = new System.Drawing.Size(231, 54);
            this.asunto_documentoTextBox.TabIndex = 3;
            this.asunto_documentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.asunto_documentoTextBox_KeyPress);
            // 
            // numero_respuesta_intTextBox
            // 
            this.numero_respuesta_intTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalledocumentointernoBindingSource, "Numero_Respuesta_Interno", true));
            this.numero_respuesta_intTextBox.Enabled = false;
            this.numero_respuesta_intTextBox.Location = new System.Drawing.Point(364, 539);
            this.numero_respuesta_intTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numero_respuesta_intTextBox.Name = "numero_respuesta_intTextBox";
            this.numero_respuesta_intTextBox.Size = new System.Drawing.Size(92, 22);
            this.numero_respuesta_intTextBox.TabIndex = 1;
            this.numero_respuesta_intTextBox.Visible = false;
            // 
            // detalle_documento_internoTableAdapter
            // 
            this.detalle_documento_internoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = this.detalle_documento_internoTableAdapter;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNELIMINAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.BackgroundImage")));
            this.BTNELIMINAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNELIMINAR.FlatAppearance.BorderSize = 0;
            this.BTNELIMINAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Delete_File_48px;
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(493, 323);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(135, 50);
            this.BTNELIMINAR.TabIndex = 64;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNGUARDAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.BackgroundImage")));
            this.BTNGUARDAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BTNGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGUARDAR.FlatAppearance.BorderSize = 0;
            this.BTNGUARDAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Save_Archive_48px;
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(493, 260);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(135, 47);
            this.BTNGUARDAR.TabIndex = 63;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNEDITAR
            // 
            this.BTNEDITAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNEDITAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNEDITAR.BackgroundImage")));
            this.BTNEDITAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNEDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNEDITAR.FlatAppearance.BorderSize = 0;
            this.BTNEDITAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNEDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNEDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEDITAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Edit_File_48px;
            this.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Location = new System.Drawing.Point(493, 147);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(135, 44);
            this.BTNEDITAR.TabIndex = 61;
            this.BTNEDITAR.Text = "EDITAR";
            this.BTNEDITAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNEDITAR.UseVisualStyleBackColor = false;
            this.BTNEDITAR.Click += new System.EventHandler(this.BTNEDITAR_Click);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNCANCELAR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNCANCELAR.BackgroundImage")));
            this.BTNCANCELAR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNCANCELAR.FlatAppearance.BorderSize = 0;
            this.BTNCANCELAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNCANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Cancel_File_48px;
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.Location = new System.Drawing.Point(493, 199);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(135, 49);
            this.BTNCANCELAR.TabIndex = 62;
            this.BTNCANCELAR.Text = "CANCELAR";
            this.BTNCANCELAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNCANCELAR.UseVisualStyleBackColor = false;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackColor = System.Drawing.Color.Transparent;
            this.BTNNUEVO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.BackgroundImage")));
            this.BTNNUEVO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNNUEVO.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNNUEVO.FlatAppearance.BorderSize = 0;
            this.BTNNUEVO.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNNUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNNUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVO.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Add_List_48px;
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(493, 85);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(135, 46);
            this.BTNNUEVO.TabIndex = 60;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // detalle_documento_internoDataGridView
            // 
            this.detalle_documento_internoDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.detalle_documento_internoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.detalle_documento_internoDataGridView.AutoGenerateColumns = false;
            this.detalle_documento_internoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_documento_internoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.detalle_documento_internoDataGridView.ColumnHeadersHeight = 30;
            this.detalle_documento_internoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.detalle_documento_internoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRespuestaInternoDataGridViewTextBoxColumn,
            this.numeroCorrelativoDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.derivarAreaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn});
            this.detalle_documento_internoDataGridView.DataSource = this.detalledocumentointernoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalle_documento_internoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.detalle_documento_internoDataGridView.EnableHeadersVisualStyles = false;
            this.detalle_documento_internoDataGridView.Location = new System.Drawing.Point(13, 398);
            this.detalle_documento_internoDataGridView.Name = "detalle_documento_internoDataGridView";
            this.detalle_documento_internoDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_documento_internoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.detalle_documento_internoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.detalle_documento_internoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle_documento_internoDataGridView.Size = new System.Drawing.Size(624, 204);
            this.detalle_documento_internoDataGridView.TabIndex = 64;
            // 
            // numeroRespuestaInternoDataGridViewTextBoxColumn
            // 
            this.numeroRespuestaInternoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Respuesta_Interno";
            this.numeroRespuestaInternoDataGridViewTextBoxColumn.HeaderText = "Numero_Respuesta_Interno";
            this.numeroRespuestaInternoDataGridViewTextBoxColumn.Name = "numeroRespuestaInternoDataGridViewTextBoxColumn";
            this.numeroRespuestaInternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroCorrelativoDataGridViewTextBoxColumn
            // 
            this.numeroCorrelativoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn.HeaderText = "Numero_Correlativo";
            this.numeroCorrelativoDataGridViewTextBoxColumn.Name = "numeroCorrelativoDataGridViewTextBoxColumn";
            this.numeroCorrelativoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // asuntoDataGridViewTextBoxColumn
            // 
            this.asuntoDataGridViewTextBoxColumn.DataPropertyName = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.HeaderText = "Asunto";
            this.asuntoDataGridViewTextBoxColumn.Name = "asuntoDataGridViewTextBoxColumn";
            this.asuntoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // derivarAreaDataGridViewTextBoxColumn
            // 
            this.derivarAreaDataGridViewTextBoxColumn.DataPropertyName = "Derivar_Area";
            this.derivarAreaDataGridViewTextBoxColumn.HeaderText = "Derivar_Area";
            this.derivarAreaDataGridViewTextBoxColumn.Name = "derivarAreaDataGridViewTextBoxColumn";
            this.derivarAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaSalidaDataGridViewTextBoxColumn
            // 
            this.fechaSalidaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Salida";
            this.fechaSalidaDataGridViewTextBoxColumn.HeaderText = "Fecha_Salida";
            this.fechaSalidaDataGridViewTextBoxColumn.Name = "fechaSalidaDataGridViewTextBoxColumn";
            this.fechaSalidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
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
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(447, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 79;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(413, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(226, 370);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(181, 22);
            this.txtbuscar.TabIndex = 77;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "ASUNTO",
            "FECHA",
            "AREA"});
            this.cbbuscar.Location = new System.Drawing.Point(101, 368);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 76;
            this.cbbuscar.SelectedIndexChanged += new System.EventHandler(this.cbbuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(10, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 75;
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
            this.label2.Size = new System.Drawing.Size(647, 29);
            this.label2.TabIndex = 423;
            this.label2.Text = "Seguimiento de Documento Interno";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 602);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(647, 22);
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
            // FRMSEGUIMIENTODOCUMENTOINTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(664, 576);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detalle_documento_internoDataGridView);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(numero_respuesta_intLabel);
            this.Controls.Add(this.numero_respuesta_intTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 615);
            this.MinimumSize = new System.Drawing.Size(680, 615);
            this.Name = "FRMSEGUIMIENTODOCUMENTOINTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOINTERNO_Activated);
            this.Load += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOINTERNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalledocumentointernoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.detalle_documento_internoTableAdapter detalle_documento_internoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numero_respuesta_intTextBox;
        private System.Windows.Forms.TextBox numero_correlativoTextBox;
        private System.Windows.Forms.ComboBox derivar_areaComboBox;
        private System.Windows.Forms.DateTimePicker fecha_salidaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.TextBox asunto_documentoTextBox;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView detalle_documento_internoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRespuestaInternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCorrelativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derivarAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detalledocumentointernoBindingSource;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}