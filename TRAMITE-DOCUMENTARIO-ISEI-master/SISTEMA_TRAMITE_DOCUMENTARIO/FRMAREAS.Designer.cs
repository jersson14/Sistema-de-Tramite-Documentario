namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMAREAS
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
            System.Windows.Forms.Label id_areaLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label encargardo_areaLabel;
            System.Windows.Forms.Label nombre_areaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMAREAS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre_areaComboBox = new System.Windows.Forms.ComboBox();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.encargardo_areaTextBox = new System.Windows.Forms.TextBox();
            this.areasDataGridView = new System.Windows.Forms.DataGridView();
            this.idAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.encargardoAreaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.areasTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.areasTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            id_areaLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            encargardo_areaLabel = new System.Windows.Forms.Label();
            nombre_areaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            id_areaLabel.Location = new System.Drawing.Point(83, 24);
            id_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(60, 15);
            id_areaLabel.TabIndex = 0;
            id_areaLabel.Text = "Id. Area:";
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            codigoLabel.Location = new System.Drawing.Point(87, 51);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(56, 15);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "Codigo:";
            // 
            // encargardo_areaLabel
            // 
            encargardo_areaLabel.AutoSize = true;
            encargardo_areaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            encargardo_areaLabel.Location = new System.Drawing.Point(10, 108);
            encargardo_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            encargardo_areaLabel.Name = "encargardo_areaLabel";
            encargardo_areaLabel.Size = new System.Drawing.Size(133, 15);
            encargardo_areaLabel.TabIndex = 6;
            encargardo_areaLabel.Text = "Encargado de Area:";
            // 
            // nombre_areaLabel
            // 
            nombre_areaLabel.AutoSize = true;
            nombre_areaLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            nombre_areaLabel.Location = new System.Drawing.Point(28, 80);
            nombre_areaLabel.Name = "nombre_areaLabel";
            nombre_areaLabel.Size = new System.Drawing.Size(115, 15);
            nombre_areaLabel.TabIndex = 7;
            nombre_areaLabel.Text = "Nombre de Area:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            label2.Location = new System.Drawing.Point(13, 208);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(213, 16);
            label2.TabIndex = 8;
            label2.Text = "Buscar por Codigo o Nombre:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(nombre_areaLabel);
            this.groupBox1.Controls.Add(this.nombre_areaComboBox);
            this.groupBox1.Controls.Add(id_areaLabel);
            this.groupBox1.Controls.Add(this.id_areaTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(encargardo_areaLabel);
            this.groupBox1.Controls.Add(this.encargardo_areaTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(446, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Areas de La Universidad Tecnologica de los Andes";
            // 
            // nombre_areaComboBox
            // 
            this.nombre_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "Nombre_Area", true));
            this.nombre_areaComboBox.FormattingEnabled = true;
            this.nombre_areaComboBox.Items.AddRange(new object[] {
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
            this.nombre_areaComboBox.Location = new System.Drawing.Point(145, 77);
            this.nombre_areaComboBox.Name = "nombre_areaComboBox";
            this.nombre_areaComboBox.Size = new System.Drawing.Size(274, 23);
            this.nombre_areaComboBox.TabIndex = 1;
            this.nombre_areaComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_areaComboBox_KeyPress);
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "areas";
            this.areasBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "Id_Area", true));
            this.id_areaTextBox.Enabled = false;
            this.id_areaTextBox.Location = new System.Drawing.Point(145, 21);
            this.id_areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(96, 21);
            this.id_areaTextBox.TabIndex = 1;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "Codigo", true));
            this.codigoTextBox.Enabled = false;
            this.codigoTextBox.Location = new System.Drawing.Point(145, 48);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(204, 21);
            this.codigoTextBox.TabIndex = 3;
            // 
            // encargardo_areaTextBox
            // 
            this.encargardo_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "Encargardo_Area", true));
            this.encargardo_areaTextBox.Location = new System.Drawing.Point(145, 108);
            this.encargardo_areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.encargardo_areaTextBox.Name = "encargardo_areaTextBox";
            this.encargardo_areaTextBox.Size = new System.Drawing.Size(274, 21);
            this.encargardo_areaTextBox.TabIndex = 2;
            this.encargardo_areaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.encargardo_areaTextBox_KeyPress);
            // 
            // areasDataGridView
            // 
            this.areasDataGridView.AllowUserToAddRows = false;
            this.areasDataGridView.AllowUserToDeleteRows = false;
            this.areasDataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.areasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.areasDataGridView.AutoGenerateColumns = false;
            this.areasDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.areasDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.areasDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.areasDataGridView.ColumnHeadersHeight = 30;
            this.areasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.areasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAreaDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreAreaDataGridViewTextBoxColumn,
            this.encargardoAreaDataGridViewTextBoxColumn});
            this.areasDataGridView.DataSource = this.areasBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.areasDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.areasDataGridView.EnableHeadersVisualStyles = false;
            this.areasDataGridView.Location = new System.Drawing.Point(16, 233);
            this.areasDataGridView.Name = "areasDataGridView";
            this.areasDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.areasDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.areasDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.areasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.areasDataGridView.Size = new System.Drawing.Size(446, 180);
            this.areasDataGridView.TabIndex = 69;
            // 
            // idAreaDataGridViewTextBoxColumn
            // 
            this.idAreaDataGridViewTextBoxColumn.DataPropertyName = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn.HeaderText = "Id_Area";
            this.idAreaDataGridViewTextBoxColumn.Name = "idAreaDataGridViewTextBoxColumn";
            this.idAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "Codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            this.codigoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreAreaDataGridViewTextBoxColumn
            // 
            this.nombreAreaDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn.HeaderText = "Nombre_Area";
            this.nombreAreaDataGridViewTextBoxColumn.Name = "nombreAreaDataGridViewTextBoxColumn";
            this.nombreAreaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // encargardoAreaDataGridViewTextBoxColumn
            // 
            this.encargardoAreaDataGridViewTextBoxColumn.DataPropertyName = "Encargardo_Area";
            this.encargardoAreaDataGridViewTextBoxColumn.HeaderText = "Encargardo_Area";
            this.encargardoAreaDataGridViewTextBoxColumn.Name = "encargardoAreaDataGridViewTextBoxColumn";
            this.encargardoAreaDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.BTNELIMINAR.Location = new System.Drawing.Point(479, 304);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(148, 59);
            this.BTNELIMINAR.TabIndex = 69;
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(479, 245);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(148, 51);
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
            this.BTNEDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNEDITAR.FlatAppearance.BorderSize = 0;
            this.BTNEDITAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNEDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNEDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEDITAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Edit_File_48px;
            this.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Location = new System.Drawing.Point(479, 117);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(148, 56);
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
            this.BTNCANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNCANCELAR.FlatAppearance.BorderSize = 0;
            this.BTNCANCELAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNCANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Imprint MT Shadow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Cancel_File_48px;
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.Location = new System.Drawing.Point(479, 181);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(148, 56);
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
            this.BTNNUEVO.Location = new System.Drawing.Point(479, 61);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(148, 48);
            this.BTNNUEVO.TabIndex = 65;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
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
            this.label1.Size = new System.Drawing.Size(640, 29);
            this.label1.TabIndex = 421;
            this.label1.Text = "Registro de Areas de la UTEA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(640, 22);
            this.statusStrip1.TabIndex = 429;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 22);
            this.textBox1.TabIndex = 430;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = this.areasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRMAREAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(640, 438);
            this.Controls.Add(label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areasDataGridView);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(656, 477);
            this.MinimumSize = new System.Drawing.Size(656, 477);
            this.Name = "FRMAREAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRMAREAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.areasTableAdapter areasTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox encargardo_areaTextBox;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.DataGridView areasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox nombre_areaComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn encargardoAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource areasBindingSource;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}