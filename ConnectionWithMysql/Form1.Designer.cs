
namespace ConnectionWithMysql
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnProbarConexión = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCalleMySql = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRealizarMySQL = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbOperacionMySQL = new System.Windows.Forms.ComboBox();
            this.txtNombreMySql = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDMySql = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtCalleSql = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRealizarSql = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbOperacionSQL = new System.Windows.Forms.ComboBox();
            this.txtNombreSql = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtIDSql = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dgvDatosMySQL = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTipoFragmentación = new System.Windows.Forms.Label();
            this.btnFragmentacion = new System.Windows.Forms.Button();
            this.cmbTipoFragmentacion = new System.Windows.Forms.ComboBox();
            this.btnMostrarDatosSQL = new System.Windows.Forms.Button();
            this.dgvDatosSQL = new System.Windows.Forms.DataGridView();
            this.dgvConsultaFragmentacion = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMySQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFragmentacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtHost.Location = new System.Drawing.Point(148, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(197, 26);
            this.txtHost.TabIndex = 1;
            this.txtHost.Text = "192.168.0.111";
            // 
            // btnProbarConexión
            // 
            this.btnProbarConexión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.btnProbarConexión.FlatAppearance.BorderSize = 0;
            this.btnProbarConexión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbarConexión.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbarConexión.Location = new System.Drawing.Point(148, 147);
            this.btnProbarConexión.Name = "btnProbarConexión";
            this.btnProbarConexión.Size = new System.Drawing.Size(197, 37);
            this.btnProbarConexión.TabIndex = 5;
            this.btnProbarConexión.Text = "Conectar";
            this.btnProbarConexión.UseVisualStyleBackColor = false;
            this.btnProbarConexión.Click += new System.EventHandler(this.btnProbarConexión_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuario.Location = new System.Drawing.Point(148, 45);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(197, 26);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Text = "david";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Base de datos:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPassword.Location = new System.Drawing.Point(148, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 26);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "123";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Usuario:";
            // 
            // txtBD
            // 
            this.txtBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBD.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtBD.Location = new System.Drawing.Point(148, 110);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(197, 26);
            this.txtBD.TabIndex = 4;
            this.txtBD.Text = "TiendaCarBD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contraseña:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 252);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(391, 285);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCalleMySql);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.btnRealizarMySQL);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.cmbOperacionMySQL);
            this.tabPage1.Controls.Add(this.txtNombreMySql);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtIDMySql);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(383, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registrar Datos de MySQL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCalleMySql
            // 
            this.txtCalleMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleMySql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCalleMySql.Location = new System.Drawing.Point(142, 89);
            this.txtCalleMySql.Name = "txtCalleMySql";
            this.txtCalleMySql.Size = new System.Drawing.Size(160, 26);
            this.txtCalleMySql.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(88, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Calle:";
            // 
            // btnRealizarMySQL
            // 
            this.btnRealizarMySQL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRealizarMySQL.FlatAppearance.BorderSize = 0;
            this.btnRealizarMySQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarMySQL.Location = new System.Drawing.Point(62, 201);
            this.btnRealizarMySQL.Name = "btnRealizarMySQL";
            this.btnRealizarMySQL.Size = new System.Drawing.Size(239, 41);
            this.btnRealizarMySQL.TabIndex = 12;
            this.btnRealizarMySQL.Text = "Realizar";
            this.btnRealizarMySQL.UseVisualStyleBackColor = false;
            this.btnRealizarMySQL.Click += new System.EventHandler(this.btnRealizarMySQL_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 144);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Selecciona una operación:";
            // 
            // cmbOperacionMySQL
            // 
            this.cmbOperacionMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacionMySQL.FormattingEnabled = true;
            this.cmbOperacionMySQL.Items.AddRange(new object[] {
            "Insertar",
            "Actualizar",
            "Eliminar"});
            this.cmbOperacionMySQL.Location = new System.Drawing.Point(62, 167);
            this.cmbOperacionMySQL.Name = "cmbOperacionMySQL";
            this.cmbOperacionMySQL.Size = new System.Drawing.Size(239, 28);
            this.cmbOperacionMySQL.TabIndex = 12;
            this.cmbOperacionMySQL.SelectedIndexChanged += new System.EventHandler(this.cmbOperacion_SelectedIndexChanged);
            // 
            // txtNombreMySql
            // 
            this.txtNombreMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMySql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreMySql.Location = new System.Drawing.Point(142, 57);
            this.txtNombreMySql.Name = "txtNombreMySql";
            this.txtNombreMySql.Size = new System.Drawing.Size(160, 26);
            this.txtNombreMySql.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nombre:";
            // 
            // txtIDMySql
            // 
            this.txtIDMySql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMySql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIDMySql.Location = new System.Drawing.Point(142, 19);
            this.txtIDMySql.Name = "txtIDMySql";
            this.txtIDMySql.Size = new System.Drawing.Size(160, 26);
            this.txtIDMySql.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(110, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCalleSql);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.btnRealizarSql);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.cmbOperacionSQL);
            this.tabPage2.Controls.Add(this.txtNombreSql);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtIDSql);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(383, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Regisrar Datos de SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtCalleSql
            // 
            this.txtCalleSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalleSql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCalleSql.Location = new System.Drawing.Point(151, 85);
            this.txtCalleSql.Name = "txtCalleSql";
            this.txtCalleSql.Size = new System.Drawing.Size(160, 26);
            this.txtCalleSql.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(97, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "Calle:";
            // 
            // btnRealizarSql
            // 
            this.btnRealizarSql.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnRealizarSql.FlatAppearance.BorderSize = 0;
            this.btnRealizarSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRealizarSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarSql.Location = new System.Drawing.Point(71, 197);
            this.btnRealizarSql.Name = "btnRealizarSql";
            this.btnRealizarSql.Size = new System.Drawing.Size(239, 41);
            this.btnRealizarSql.TabIndex = 17;
            this.btnRealizarSql.Text = "Realizar";
            this.btnRealizarSql.UseVisualStyleBackColor = false;
            this.btnRealizarSql.Click += new System.EventHandler(this.btnRealizarSql_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 140);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(196, 20);
            this.label13.TabIndex = 18;
            this.label13.Text = "Selecciona una operación:";
            // 
            // cmbOperacionSQL
            // 
            this.cmbOperacionSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperacionSQL.FormattingEnabled = true;
            this.cmbOperacionSQL.Items.AddRange(new object[] {
            "Insertar",
            "Actualizar",
            "Eliminar"});
            this.cmbOperacionSQL.Location = new System.Drawing.Point(71, 163);
            this.cmbOperacionSQL.Name = "cmbOperacionSQL";
            this.cmbOperacionSQL.Size = new System.Drawing.Size(239, 28);
            this.cmbOperacionSQL.TabIndex = 19;
            this.cmbOperacionSQL.SelectedIndexChanged += new System.EventHandler(this.cmbOperacionSQL_SelectedIndexChanged);
            // 
            // txtNombreSql
            // 
            this.txtNombreSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtNombreSql.Location = new System.Drawing.Point(151, 53);
            this.txtNombreSql.Name = "txtNombreSql";
            this.txtNombreSql.Size = new System.Drawing.Size(160, 26);
            this.txtNombreSql.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(76, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Nombre:";
            // 
            // txtIDSql
            // 
            this.txtIDSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDSql.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtIDSql.Location = new System.Drawing.Point(151, 15);
            this.txtIDSql.Name = "txtIDSql";
            this.txtIDSql.Size = new System.Drawing.Size(160, 26);
            this.txtIDSql.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(119, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 20);
            this.label15.TabIndex = 21;
            this.label15.Text = "ID:";
            // 
            // dgvDatosMySQL
            // 
            this.dgvDatosMySQL.AllowUserToAddRows = false;
            this.dgvDatosMySQL.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDatosMySQL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDatosMySQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosMySQL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvDatosMySQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosMySQL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatosMySQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosMySQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDatosMySQL.ColumnHeadersHeight = 30;
            this.dgvDatosMySQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosMySQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatosMySQL.EnableHeadersVisualStyles = false;
            this.dgvDatosMySQL.GridColor = System.Drawing.Color.White;
            this.dgvDatosMySQL.Location = new System.Drawing.Point(418, 33);
            this.dgvDatosMySQL.Name = "dgvDatosMySQL";
            this.dgvDatosMySQL.ReadOnly = true;
            this.dgvDatosMySQL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatosMySQL.RowHeadersVisible = false;
            this.dgvDatosMySQL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosMySQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosMySQL.Size = new System.Drawing.Size(541, 119);
            this.dgvDatosMySQL.TabIndex = 10;
            this.dgvDatosMySQL.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(414, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consulta MySQL";
            // 
            // txtPuerto
            // 
            this.txtPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPuerto.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPuerto.Location = new System.Drawing.Point(28, 152);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(103, 26);
            this.txtPuerto.TabIndex = 12;
            this.txtPuerto.Text = "Puerto";
            this.txtPuerto.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(414, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Consulta SQL Server";
            // 
            // lblTipoFragmentación
            // 
            this.lblTipoFragmentación.AutoSize = true;
            this.lblTipoFragmentación.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFragmentación.ForeColor = System.Drawing.Color.White;
            this.lblTipoFragmentación.Location = new System.Drawing.Point(414, 346);
            this.lblTipoFragmentación.Name = "lblTipoFragmentación";
            this.lblTipoFragmentación.Size = new System.Drawing.Size(292, 20);
            this.lblTipoFragmentación.TabIndex = 16;
            this.lblTipoFragmentación.Text = "Consulta Fragmentacion Horizontal";
            // 
            // btnFragmentacion
            // 
            this.btnFragmentacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.btnFragmentacion.FlatAppearance.BorderSize = 0;
            this.btnFragmentacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFragmentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFragmentacion.Location = new System.Drawing.Point(418, 505);
            this.btnFragmentacion.Name = "btnFragmentacion";
            this.btnFragmentacion.Size = new System.Drawing.Size(313, 34);
            this.btnFragmentacion.TabIndex = 15;
            this.btnFragmentacion.Text = "Consultar Fragmentacion Seleccionada:";
            this.btnFragmentacion.UseVisualStyleBackColor = false;
            this.btnFragmentacion.Click += new System.EventHandler(this.btnFragmentacion_Click);
            // 
            // cmbTipoFragmentacion
            // 
            this.cmbTipoFragmentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoFragmentacion.FormattingEnabled = true;
            this.cmbTipoFragmentacion.Items.AddRange(new object[] {
            "Horizontal",
            "Deriva",
            "HorizontalDeriva"});
            this.cmbTipoFragmentacion.Location = new System.Drawing.Point(737, 509);
            this.cmbTipoFragmentacion.Name = "cmbTipoFragmentacion";
            this.cmbTipoFragmentacion.Size = new System.Drawing.Size(206, 28);
            this.cmbTipoFragmentacion.TabIndex = 15;
            // 
            // btnMostrarDatosSQL
            // 
            this.btnMostrarDatosSQL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(227)))), ((int)(((byte)(102)))));
            this.btnMostrarDatosSQL.FlatAppearance.BorderSize = 0;
            this.btnMostrarDatosSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarDatosSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDatosSQL.Location = new System.Drawing.Point(718, 308);
            this.btnMostrarDatosSQL.Name = "btnMostrarDatosSQL";
            this.btnMostrarDatosSQL.Size = new System.Drawing.Size(241, 34);
            this.btnMostrarDatosSQL.TabIndex = 17;
            this.btnMostrarDatosSQL.Text = "Mostrar Datos de SQL Server";
            this.btnMostrarDatosSQL.UseVisualStyleBackColor = false;
            this.btnMostrarDatosSQL.Click += new System.EventHandler(this.btnMostrarDatosSQL_Click);
            // 
            // dgvDatosSQL
            // 
            this.dgvDatosSQL.AllowUserToAddRows = false;
            this.dgvDatosSQL.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvDatosSQL.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDatosSQL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosSQL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvDatosSQL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDatosSQL.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDatosSQL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDatosSQL.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDatosSQL.ColumnHeadersHeight = 30;
            this.dgvDatosSQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDatosSQL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDatosSQL.EnableHeadersVisualStyles = false;
            this.dgvDatosSQL.GridColor = System.Drawing.Color.White;
            this.dgvDatosSQL.Location = new System.Drawing.Point(418, 183);
            this.dgvDatosSQL.Name = "dgvDatosSQL";
            this.dgvDatosSQL.ReadOnly = true;
            this.dgvDatosSQL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDatosSQL.RowHeadersVisible = false;
            this.dgvDatosSQL.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDatosSQL.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosSQL.Size = new System.Drawing.Size(541, 119);
            this.dgvDatosSQL.TabIndex = 18;
            this.dgvDatosSQL.SelectionChanged += new System.EventHandler(this.dgvDatosSQL_SelectionChanged);
            // 
            // dgvConsultaFragmentacion
            // 
            this.dgvConsultaFragmentacion.AllowUserToAddRows = false;
            this.dgvConsultaFragmentacion.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvConsultaFragmentacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvConsultaFragmentacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsultaFragmentacion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(230)))), ((int)(((byte)(240)))));
            this.dgvConsultaFragmentacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsultaFragmentacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvConsultaFragmentacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(152)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsultaFragmentacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvConsultaFragmentacion.ColumnHeadersHeight = 30;
            this.dgvConsultaFragmentacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsultaFragmentacion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvConsultaFragmentacion.EnableHeadersVisualStyles = false;
            this.dgvConsultaFragmentacion.GridColor = System.Drawing.Color.White;
            this.dgvConsultaFragmentacion.Location = new System.Drawing.Point(418, 370);
            this.dgvConsultaFragmentacion.Name = "dgvConsultaFragmentacion";
            this.dgvConsultaFragmentacion.ReadOnly = true;
            this.dgvConsultaFragmentacion.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsultaFragmentacion.RowHeadersVisible = false;
            this.dgvConsultaFragmentacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvConsultaFragmentacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsultaFragmentacion.Size = new System.Drawing.Size(541, 133);
            this.dgvConsultaFragmentacion.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(971, 555);
            this.Controls.Add(this.dgvConsultaFragmentacion);
            this.Controls.Add(this.dgvDatosSQL);
            this.Controls.Add(this.btnMostrarDatosSQL);
            this.Controls.Add(this.cmbTipoFragmentacion);
            this.Controls.Add(this.btnFragmentacion);
            this.Controls.Add(this.lblTipoFragmentación);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvDatosMySQL);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProbarConexión);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MySQL with C#";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosMySQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosSQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaFragmentacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnProbarConexión;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRealizarMySQL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbOperacionMySQL;
        private System.Windows.Forms.TextBox txtNombreMySql;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDMySql;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dgvDatosMySQL;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTipoFragmentación;
        private System.Windows.Forms.Button btnFragmentacion;
        private System.Windows.Forms.ComboBox cmbTipoFragmentacion;
        private System.Windows.Forms.TextBox txtCalleMySql;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCalleSql;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnRealizarSql;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbOperacionSQL;
        private System.Windows.Forms.TextBox txtNombreSql;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtIDSql;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnMostrarDatosSQL;
        public System.Windows.Forms.DataGridView dgvDatosSQL;
        public System.Windows.Forms.DataGridView dgvConsultaFragmentacion;
    }
}

