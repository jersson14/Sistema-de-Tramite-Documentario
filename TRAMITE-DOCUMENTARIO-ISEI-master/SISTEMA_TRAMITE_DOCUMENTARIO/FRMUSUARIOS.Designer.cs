namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMUSUARIOS
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
            System.Windows.Forms.Label id_usuarioLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label tipo_administradorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMUSUARIOS));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.admsistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.correo_electronicoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.tipo_administradorComboBox = new System.Windows.Forms.ComboBox();
            this.id_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.adm_sistemaTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.adm_sistemaTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adm_sistemaDataGridView = new System.Windows.Forms.DataGridView();
            this.idUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoElectronicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseñaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAdministradorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admsistemaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            id_usuarioLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            tipo_administradorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adm_sistemaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(206, 400);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(69, 16);
            id_usuarioLabel.TabIndex = 0;
            id_usuarioLabel.Text = "id usuario:";
            id_usuarioLabel.Visible = false;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(72, 25);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(75, 16);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "Nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(69, 56);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(78, 16);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "Apellidos:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Location = new System.Drawing.Point(6, 84);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(141, 16);
            correo_electronicoLabel.TabIndex = 8;
            correo_electronicoLabel.Text = "Correo Electronico:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(81, 111);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(66, 16);
            usuarioLabel.TabIndex = 10;
            usuarioLabel.Text = "Usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(56, 140);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(91, 16);
            contraseñaLabel.TabIndex = 12;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // tipo_administradorLabel
            // 
            tipo_administradorLabel.AutoSize = true;
            tipo_administradorLabel.Location = new System.Drawing.Point(23, 167);
            tipo_administradorLabel.Name = "tipo_administradorLabel";
            tipo_administradorLabel.Size = new System.Drawing.Size(124, 16);
            tipo_administradorLabel.TabIndex = 14;
            tipo_administradorLabel.Text = "Tipo de Usuario:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(correo_electronicoLabel);
            this.groupBox1.Controls.Add(this.correo_electronicoTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Controls.Add(contraseñaLabel);
            this.groupBox1.Controls.Add(this.contraseñaTextBox);
            this.groupBox1.Controls.Add(tipo_administradorLabel);
            this.groupBox1.Controls.Add(this.tipo_administradorComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(413, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Usuarios";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(150, 25);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(251, 22);
            this.nombresTextBox.TabIndex = 2;
            this.nombresTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombresTextBox_KeyPress);
            // 
            // admsistemaBindingSource
            // 
            this.admsistemaBindingSource.DataMember = "adm_sistema";
            this.admsistemaBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(150, 53);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(251, 22);
            this.apellidosTextBox.TabIndex = 3;
            this.apellidosTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.apellidosTextBox_KeyPress);
            // 
            // correo_electronicoTextBox
            // 
            this.correo_electronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "correo_electronico", true));
            this.correo_electronicoTextBox.Location = new System.Drawing.Point(150, 81);
            this.correo_electronicoTextBox.Name = "correo_electronicoTextBox";
            this.correo_electronicoTextBox.Size = new System.Drawing.Size(251, 22);
            this.correo_electronicoTextBox.TabIndex = 4;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(150, 109);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(184, 22);
            this.usuarioTextBox.TabIndex = 5;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(150, 137);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(184, 22);
            this.contraseñaTextBox.TabIndex = 6;
            // 
            // tipo_administradorComboBox
            // 
            this.tipo_administradorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "tipo_administrador", true));
            this.tipo_administradorComboBox.FormattingEnabled = true;
            this.tipo_administradorComboBox.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "SECRETARIA",
            "DIRECTOR"});
            this.tipo_administradorComboBox.Location = new System.Drawing.Point(150, 164);
            this.tipo_administradorComboBox.Name = "tipo_administradorComboBox";
            this.tipo_administradorComboBox.Size = new System.Drawing.Size(184, 24);
            this.tipo_administradorComboBox.TabIndex = 7;
            this.tipo_administradorComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tipo_administradorComboBox_KeyPress);
            // 
            // id_usuarioTextBox
            // 
            this.id_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "id_usuario", true));
            this.id_usuarioTextBox.Location = new System.Drawing.Point(281, 397);
            this.id_usuarioTextBox.Name = "id_usuarioTextBox";
            this.id_usuarioTextBox.Size = new System.Drawing.Size(79, 22);
            this.id_usuarioTextBox.TabIndex = 1;
            this.id_usuarioTextBox.Visible = false;
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
            this.BTNELIMINAR.Location = new System.Drawing.Point(448, 260);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(139, 56);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(448, 200);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(139, 52);
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
            this.BTNEDITAR.Location = new System.Drawing.Point(448, 88);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(139, 46);
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
            this.BTNCANCELAR.Location = new System.Drawing.Point(448, 142);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(139, 50);
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
            this.BTNNUEVO.Location = new System.Drawing.Point(448, 33);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(139, 47);
            this.BTNNUEVO.TabIndex = 60;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // adm_sistemaTableAdapter
            // 
            this.adm_sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(397, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(363, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(195, 277);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(165, 22);
            this.txtbuscar.TabIndex = 67;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE",
            "APELLIDO",
            "USUARIO"});
            this.cbbuscar.Location = new System.Drawing.Point(97, 275);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(94, 24);
            this.cbbuscar.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar por:";
            // 
            // adm_sistemaDataGridView
            // 
            this.adm_sistemaDataGridView.AllowUserToAddRows = false;
            this.adm_sistemaDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.adm_sistemaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.adm_sistemaDataGridView.AutoGenerateColumns = false;
            this.adm_sistemaDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.adm_sistemaDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adm_sistemaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.adm_sistemaDataGridView.ColumnHeadersHeight = 30;
            this.adm_sistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.adm_sistemaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUsuarioDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.correoElectronicoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.contraseñaDataGridViewTextBoxColumn,
            this.tipoAdministradorDataGridViewTextBoxColumn});
            this.adm_sistemaDataGridView.DataSource = this.admsistemaBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.adm_sistemaDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.adm_sistemaDataGridView.EnableHeadersVisualStyles = false;
            this.adm_sistemaDataGridView.Location = new System.Drawing.Point(16, 323);
            this.adm_sistemaDataGridView.Name = "adm_sistemaDataGridView";
            this.adm_sistemaDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.adm_sistemaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adm_sistemaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.adm_sistemaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.adm_sistemaDataGridView.Size = new System.Drawing.Size(579, 209);
            this.adm_sistemaDataGridView.TabIndex = 69;
            // 
            // idUsuarioDataGridViewTextBoxColumn
            // 
            this.idUsuarioDataGridViewTextBoxColumn.DataPropertyName = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.HeaderText = "Id_Usuario";
            this.idUsuarioDataGridViewTextBoxColumn.Name = "idUsuarioDataGridViewTextBoxColumn";
            this.idUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "Nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // correoElectronicoDataGridViewTextBoxColumn
            // 
            this.correoElectronicoDataGridViewTextBoxColumn.DataPropertyName = "Correo_Electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.HeaderText = "Correo_Electronico";
            this.correoElectronicoDataGridViewTextBoxColumn.Name = "correoElectronicoDataGridViewTextBoxColumn";
            this.correoElectronicoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contraseñaDataGridViewTextBoxColumn
            // 
            this.contraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña";
            this.contraseñaDataGridViewTextBoxColumn.Name = "contraseñaDataGridViewTextBoxColumn";
            this.contraseñaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoAdministradorDataGridViewTextBoxColumn
            // 
            this.tipoAdministradorDataGridViewTextBoxColumn.DataPropertyName = "Tipo_Administrador";
            this.tipoAdministradorDataGridViewTextBoxColumn.HeaderText = "Tipo_Administrador";
            this.tipoAdministradorDataGridViewTextBoxColumn.Name = "tipoAdministradorDataGridViewTextBoxColumn";
            this.tipoAdministradorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // admsistemaBindingSource1
            // 
            this.admsistemaBindingSource1.DataMember = "adm_sistema";
            this.admsistemaBindingSource1.DataSource = this.dataSetTramite;
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
            this.label2.Size = new System.Drawing.Size(604, 29);
            this.label2.TabIndex = 422;
            this.label2.Text = "Registro de Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(604, 22);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FRMUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(604, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adm_sistemaDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(id_usuarioLabel);
            this.Controls.Add(this.id_usuarioTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 600);
            this.MinimumSize = new System.Drawing.Size(620, 600);
            this.Name = "FRMUSUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FRMUSUARIOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adm_sistemaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.adm_sistemaTableAdapter adm_sistemaTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox id_usuarioTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox correo_electronicoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.ComboBox tipo_administradorComboBox;
        private System.Windows.Forms.BindingSource admsistemaBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView adm_sistemaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoElectronicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseñaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAdministradorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource admsistemaBindingSource1;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}