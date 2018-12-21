namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMSEGUIMIENTODOCUMENTOEXTERNO
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
            System.Windows.Forms.Label numero_respuesta_extLabel;
            System.Windows.Forms.Label numero_correlativoLabel;
            System.Windows.Forms.Label asuntoLabel;
            System.Windows.Forms.Label derivar_areaLabel;
            System.Windows.Forms.Label fecha_salidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSEGUIMIENTODOCUMENTOEXTERNO));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.observacionTextBox1 = new System.Windows.Forms.TextBox();
            this.detalle_documento_externoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.button2 = new System.Windows.Forms.Button();
            this.numero_respuesta_extTextBox = new System.Windows.Forms.TextBox();
            this.numero_correlativoTextBox = new System.Windows.Forms.TextBox();
            this.asuntoTextBox = new System.Windows.Forms.TextBox();
            this.derivar_areaComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.detalle_documento_externoDataGridView = new System.Windows.Forms.DataGridView();
            this.numeroRespuestaExternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCorrelativoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asuntoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.derivarAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaSalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.detalle_documento_externoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.detalle_documento_externoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            numero_respuesta_extLabel = new System.Windows.Forms.Label();
            numero_correlativoLabel = new System.Windows.Forms.Label();
            asuntoLabel = new System.Windows.Forms.Label();
            derivar_areaLabel = new System.Windows.Forms.Label();
            fecha_salidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numero_respuesta_extLabel
            // 
            numero_respuesta_extLabel.AutoSize = true;
            numero_respuesta_extLabel.Location = new System.Drawing.Point(4, 30);
            numero_respuesta_extLabel.Name = "numero_respuesta_extLabel";
            numero_respuesta_extLabel.Size = new System.Drawing.Size(201, 16);
            numero_respuesta_extLabel.TabIndex = 0;
            numero_respuesta_extLabel.Text = "Numero Respuesta Externo:";
            // 
            // numero_correlativoLabel
            // 
            numero_correlativoLabel.AutoSize = true;
            numero_correlativoLabel.Location = new System.Drawing.Point(59, 54);
            numero_correlativoLabel.Name = "numero_correlativoLabel";
            numero_correlativoLabel.Size = new System.Drawing.Size(146, 16);
            numero_correlativoLabel.TabIndex = 2;
            numero_correlativoLabel.Text = "Número Correlativo:";
            // 
            // asuntoLabel
            // 
            asuntoLabel.AutoSize = true;
            asuntoLabel.Location = new System.Drawing.Point(146, 83);
            asuntoLabel.Name = "asuntoLabel";
            asuntoLabel.Size = new System.Drawing.Size(59, 16);
            asuntoLabel.TabIndex = 4;
            asuntoLabel.Text = "Asunto:";
            // 
            // derivar_areaLabel
            // 
            derivar_areaLabel.AutoSize = true;
            derivar_areaLabel.Location = new System.Drawing.Point(105, 137);
            derivar_areaLabel.Name = "derivar_areaLabel";
            derivar_areaLabel.Size = new System.Drawing.Size(100, 16);
            derivar_areaLabel.TabIndex = 6;
            derivar_areaLabel.Text = "Derivar Área:";
            // 
            // fecha_salidaLabel
            // 
            fecha_salidaLabel.AutoSize = true;
            fecha_salidaLabel.Location = new System.Drawing.Point(101, 168);
            fecha_salidaLabel.Name = "fecha_salidaLabel";
            fecha_salidaLabel.Size = new System.Drawing.Size(104, 16);
            fecha_salidaLabel.TabIndex = 8;
            fecha_salidaLabel.Text = "Fecha Salida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(110, 194);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(95, 16);
            descripcionLabel.TabIndex = 10;
            descripcionLabel.Text = "Descripción:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(145, 233);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(61, 16);
            estadoLabel.TabIndex = 12;
            estadoLabel.Text = "Estado:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(107, 263);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(100, 16);
            observacionLabel.TabIndex = 14;
            observacionLabel.Text = "Observación:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.observacionTextBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(numero_respuesta_extLabel);
            this.groupBox1.Controls.Add(this.numero_respuesta_extTextBox);
            this.groupBox1.Controls.Add(numero_correlativoLabel);
            this.groupBox1.Controls.Add(this.numero_correlativoTextBox);
            this.groupBox1.Controls.Add(asuntoLabel);
            this.groupBox1.Controls.Add(this.asuntoTextBox);
            this.groupBox1.Controls.Add(derivar_areaLabel);
            this.groupBox1.Controls.Add(this.derivar_areaComboBox);
            this.groupBox1.Controls.Add(fecha_salidaLabel);
            this.groupBox1.Controls.Add(this.fecha_salidaDateTimePicker);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(observacionLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Seguimiento de Documentos";
            // 
            // observacionTextBox1
            // 
            this.observacionTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Observacion", true));
            this.observacionTextBox1.Location = new System.Drawing.Point(211, 263);
            this.observacionTextBox1.Multiline = true;
            this.observacionTextBox1.Name = "observacionTextBox1";
            this.observacionTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacionTextBox1.Size = new System.Drawing.Size(251, 55);
            this.observacionTextBox1.TabIndex = 24;
            // 
            // detalle_documento_externoBindingSource
            // 
            this.detalle_documento_externoBindingSource.DataMember = "detalle_documento_externo";
            this.detalle_documento_externoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Settings_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(308, 50);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 24);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // numero_respuesta_extTextBox
            // 
            this.numero_respuesta_extTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Numero_Respuesta_Externo", true));
            this.numero_respuesta_extTextBox.Enabled = false;
            this.numero_respuesta_extTextBox.Location = new System.Drawing.Point(211, 24);
            this.numero_respuesta_extTextBox.Name = "numero_respuesta_extTextBox";
            this.numero_respuesta_extTextBox.Size = new System.Drawing.Size(90, 22);
            this.numero_respuesta_extTextBox.TabIndex = 1;
            // 
            // numero_correlativoTextBox
            // 
            this.numero_correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Numero_Correlativo", true));
            this.numero_correlativoTextBox.Location = new System.Drawing.Point(211, 52);
            this.numero_correlativoTextBox.Name = "numero_correlativoTextBox";
            this.numero_correlativoTextBox.Size = new System.Drawing.Size(90, 22);
            this.numero_correlativoTextBox.TabIndex = 2;
            this.numero_correlativoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_correlativoTextBox_KeyPress);
            // 
            // asuntoTextBox
            // 
            this.asuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Asunto", true));
            this.asuntoTextBox.Location = new System.Drawing.Point(211, 83);
            this.asuntoTextBox.Multiline = true;
            this.asuntoTextBox.Name = "asuntoTextBox";
            this.asuntoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asuntoTextBox.Size = new System.Drawing.Size(251, 45);
            this.asuntoTextBox.TabIndex = 3;
            // 
            // derivar_areaComboBox
            // 
            this.derivar_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Derivar_Area", true));
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
            this.derivar_areaComboBox.Location = new System.Drawing.Point(211, 134);
            this.derivar_areaComboBox.Name = "derivar_areaComboBox";
            this.derivar_areaComboBox.Size = new System.Drawing.Size(251, 24);
            this.derivar_areaComboBox.TabIndex = 4;
            // 
            // fecha_salidaDateTimePicker
            // 
            this.fecha_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detalle_documento_externoBindingSource, "Fecha_Salida", true));
            this.fecha_salidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_salidaDateTimePicker.Location = new System.Drawing.Point(211, 163);
            this.fecha_salidaDateTimePicker.Name = "fecha_salidaDateTimePicker";
            this.fecha_salidaDateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.fecha_salidaDateTimePicker.TabIndex = 5;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(211, 191);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descripcionTextBox.Size = new System.Drawing.Size(251, 32);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "Estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "Archivado",
            "Proveido",
            "Obaservado"});
            this.estadoComboBox.Location = new System.Drawing.Point(211, 230);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(175, 24);
            this.estadoComboBox.TabIndex = 7;
            // 
            // detalle_documento_externoDataGridView
            // 
            this.detalle_documento_externoDataGridView.AllowUserToAddRows = false;
            this.detalle_documento_externoDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.detalle_documento_externoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.detalle_documento_externoDataGridView.AutoGenerateColumns = false;
            this.detalle_documento_externoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_documento_externoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.detalle_documento_externoDataGridView.ColumnHeadersHeight = 30;
            this.detalle_documento_externoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.detalle_documento_externoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroRespuestaExternoDataGridViewTextBoxColumn,
            this.numeroCorrelativoDataGridViewTextBoxColumn,
            this.asuntoDataGridViewTextBoxColumn,
            this.derivarAreaDataGridViewTextBoxColumn,
            this.fechaSalidaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.observacionDataGridViewTextBoxColumn});
            this.detalle_documento_externoDataGridView.DataSource = this.detalle_documento_externoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalle_documento_externoDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.detalle_documento_externoDataGridView.EnableHeadersVisualStyles = false;
            this.detalle_documento_externoDataGridView.Location = new System.Drawing.Point(12, 401);
            this.detalle_documento_externoDataGridView.Name = "detalle_documento_externoDataGridView";
            this.detalle_documento_externoDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalle_documento_externoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.detalle_documento_externoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.detalle_documento_externoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle_documento_externoDataGridView.Size = new System.Drawing.Size(625, 197);
            this.detalle_documento_externoDataGridView.TabIndex = 1;
            // 
            // numeroRespuestaExternoDataGridViewTextBoxColumn
            // 
            this.numeroRespuestaExternoDataGridViewTextBoxColumn.DataPropertyName = "Numero_Respuesta_Externo";
            this.numeroRespuestaExternoDataGridViewTextBoxColumn.HeaderText = "Numero_Respuesta_Externo";
            this.numeroRespuestaExternoDataGridViewTextBoxColumn.Name = "numeroRespuestaExternoDataGridViewTextBoxColumn";
            this.numeroRespuestaExternoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(502, 230);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(138, 56);
            this.BTNGUARDAR.TabIndex = 68;
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
            this.BTNEDITAR.Location = new System.Drawing.Point(502, 110);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(138, 51);
            this.BTNEDITAR.TabIndex = 66;
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
            this.BTNCANCELAR.Location = new System.Drawing.Point(502, 170);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(138, 51);
            this.BTNCANCELAR.TabIndex = 67;
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
            this.BTNNUEVO.Location = new System.Drawing.Point(502, 48);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(138, 53);
            this.BTNNUEVO.TabIndex = 65;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
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
            this.BTNELIMINAR.Location = new System.Drawing.Point(502, 292);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(138, 51);
            this.BTNELIMINAR.TabIndex = 69;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(482, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 74;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(448, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(234, 367);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(207, 22);
            this.txtbuscar.TabIndex = 72;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "ASUNTO",
            "FECHA",
            "AREA"});
            this.cbbuscar.Location = new System.Drawing.Point(107, 367);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(14, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 70;
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
            this.label2.Size = new System.Drawing.Size(664, 29);
            this.label2.TabIndex = 422;
            this.label2.Text = "Seguimiento de Documento Externo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 598);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(664, 22);
            this.statusStrip1.TabIndex = 430;
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
            // detalle_documento_externoTableAdapter
            // 
            this.detalle_documento_externoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = this.detalle_documento_externoTableAdapter;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRMSEGUIMIENTODOCUMENTOEXTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(681, 548);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.detalle_documento_externoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(680, 587);
            this.MinimumSize = new System.Drawing.Size(680, 587);
            this.Name = "FRMSEGUIMIENTODOCUMENTOEXTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Activated += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOEXTERNO_Activated);
            this.Load += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOEXTERNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox numero_respuesta_extTextBox;
        private System.Windows.Forms.TextBox numero_correlativoTextBox;
        private System.Windows.Forms.TextBox asuntoTextBox;
        private System.Windows.Forms.ComboBox derivar_areaComboBox;
        private System.Windows.Forms.DateTimePicker fecha_salidaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DataGridView detalle_documento_externoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox observacionTextBox1;
        private DataSetTramite dataSetTramite;
        private System.Windows.Forms.BindingSource detalle_documento_externoBindingSource;
        private DataSetTramiteTableAdapters.detalle_documento_externoTableAdapter detalle_documento_externoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRespuestaExternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCorrelativoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asuntoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn derivarAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaSalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacionDataGridViewTextBoxColumn;
    }
}