
namespace probandoTp4
{
    partial class TP4
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
			this.gbxGeneracionNros = new System.Windows.Forms.GroupBox();
			this.rbCongruencialMixto = new System.Windows.Forms.RadioButton();
			this.rbAleatorio = new System.Windows.Forms.RadioButton();
			this.gbDatosActividades = new System.Windows.Forms.GroupBox();
			this.txtMaxA5 = new System.Windows.Forms.TextBox();
			this.txtMaxA4 = new System.Windows.Forms.TextBox();
			this.txtMaxA3 = new System.Windows.Forms.TextBox();
			this.txtMaxA2 = new System.Windows.Forms.TextBox();
			this.txtMaxA1 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtMinA5 = new System.Windows.Forms.TextBox();
			this.txtMinA4 = new System.Windows.Forms.TextBox();
			this.txtMinA2 = new System.Windows.Forms.TextBox();
			this.txtMinA3 = new System.Windows.Forms.TextBox();
			this.txtMinA1 = new System.Windows.Forms.TextBox();
			this.lblA5 = new System.Windows.Forms.Label();
			this.lblA4 = new System.Windows.Forms.Label();
			this.lblA3 = new System.Windows.Forms.Label();
			this.lblA2 = new System.Windows.Forms.Label();
			this.lblA1 = new System.Windows.Forms.Label();
			this.cmbA5 = new System.Windows.Forms.ComboBox();
			this.cmbA4 = new System.Windows.Forms.ComboBox();
			this.cmbA3 = new System.Windows.Forms.ComboBox();
			this.cmbA2 = new System.Windows.Forms.ComboBox();
			this.cmbA1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbSeleccionDatos = new System.Windows.Forms.RadioButton();
			this.rbPorDefecto = new System.Windows.Forms.RadioButton();
			this.label16 = new System.Windows.Forms.Label();
			this.txtNroSimulaciones = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.txtSemilla = new System.Windows.Forms.TextBox();
			this.txtCteA = new System.Windows.Forms.TextBox();
			this.txtCteC = new System.Windows.Forms.TextBox();
			this.txtCteM = new System.Windows.Forms.TextBox();
			this.gbDatosCongruencial = new System.Windows.Forms.GroupBox();
			this.btnCalcular = new System.Windows.Forms.Button();
			this.dgvFrec = new System.Windows.Forms.DataGridView();
			this.limpiar = new System.Windows.Forms.Button();
			this.gbxGeneracionNros.SuspendLayout();
			this.gbDatosActividades.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbDatosCongruencial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFrec)).BeginInit();
			this.SuspendLayout();
			// 
			// gbxGeneracionNros
			// 
			this.gbxGeneracionNros.Controls.Add(this.rbCongruencialMixto);
			this.gbxGeneracionNros.Controls.Add(this.rbAleatorio);
			this.gbxGeneracionNros.Location = new System.Drawing.Point(12, 12);
			this.gbxGeneracionNros.Name = "gbxGeneracionNros";
			this.gbxGeneracionNros.Size = new System.Drawing.Size(247, 65);
			this.gbxGeneracionNros.TabIndex = 0;
			this.gbxGeneracionNros.TabStop = false;
			this.gbxGeneracionNros.Text = "Generacion de Nros";
			// 
			// rbCongruencialMixto
			// 
			this.rbCongruencialMixto.AutoSize = true;
			this.rbCongruencialMixto.Location = new System.Drawing.Point(6, 42);
			this.rbCongruencialMixto.Name = "rbCongruencialMixto";
			this.rbCongruencialMixto.Size = new System.Drawing.Size(115, 17);
			this.rbCongruencialMixto.TabIndex = 1;
			this.rbCongruencialMixto.Text = "Congruencial Mixto";
			this.rbCongruencialMixto.UseVisualStyleBackColor = true;
			this.rbCongruencialMixto.CheckedChanged += new System.EventHandler(this.rbCongruencialMixto_CheckedChanged);
			// 
			// rbAleatorio
			// 
			this.rbAleatorio.AutoSize = true;
			this.rbAleatorio.Checked = true;
			this.rbAleatorio.Location = new System.Drawing.Point(6, 19);
			this.rbAleatorio.Name = "rbAleatorio";
			this.rbAleatorio.Size = new System.Drawing.Size(115, 17);
			this.rbAleatorio.TabIndex = 0;
			this.rbAleatorio.TabStop = true;
			this.rbAleatorio.Text = "Numeros aleatorios";
			this.rbAleatorio.UseVisualStyleBackColor = true;
			this.rbAleatorio.CheckedChanged += new System.EventHandler(this.rbAleatorio_CheckedChanged);
			// 
			// gbDatosActividades
			// 
			this.gbDatosActividades.Controls.Add(this.txtMaxA5);
			this.gbDatosActividades.Controls.Add(this.txtMaxA4);
			this.gbDatosActividades.Controls.Add(this.txtMaxA3);
			this.gbDatosActividades.Controls.Add(this.txtMaxA2);
			this.gbDatosActividades.Controls.Add(this.txtMaxA1);
			this.gbDatosActividades.Controls.Add(this.label15);
			this.gbDatosActividades.Controls.Add(this.label14);
			this.gbDatosActividades.Controls.Add(this.label13);
			this.gbDatosActividades.Controls.Add(this.label12);
			this.gbDatosActividades.Controls.Add(this.label11);
			this.gbDatosActividades.Controls.Add(this.txtMinA5);
			this.gbDatosActividades.Controls.Add(this.txtMinA4);
			this.gbDatosActividades.Controls.Add(this.txtMinA2);
			this.gbDatosActividades.Controls.Add(this.txtMinA3);
			this.gbDatosActividades.Controls.Add(this.txtMinA1);
			this.gbDatosActividades.Controls.Add(this.lblA5);
			this.gbDatosActividades.Controls.Add(this.lblA4);
			this.gbDatosActividades.Controls.Add(this.lblA3);
			this.gbDatosActividades.Controls.Add(this.lblA2);
			this.gbDatosActividades.Controls.Add(this.lblA1);
			this.gbDatosActividades.Controls.Add(this.cmbA5);
			this.gbDatosActividades.Controls.Add(this.cmbA4);
			this.gbDatosActividades.Controls.Add(this.cmbA3);
			this.gbDatosActividades.Controls.Add(this.cmbA2);
			this.gbDatosActividades.Controls.Add(this.cmbA1);
			this.gbDatosActividades.Controls.Add(this.label5);
			this.gbDatosActividades.Controls.Add(this.label4);
			this.gbDatosActividades.Controls.Add(this.label3);
			this.gbDatosActividades.Controls.Add(this.label2);
			this.gbDatosActividades.Controls.Add(this.label1);
			this.gbDatosActividades.Location = new System.Drawing.Point(279, 21);
			this.gbDatosActividades.Name = "gbDatosActividades";
			this.gbDatosActividades.Size = new System.Drawing.Size(523, 174);
			this.gbDatosActividades.TabIndex = 1;
			this.gbDatosActividades.TabStop = false;
			this.gbDatosActividades.Text = "Datos Actividades";
			// 
			// txtMaxA5
			// 
			this.txtMaxA5.Location = new System.Drawing.Point(417, 142);
			this.txtMaxA5.Name = "txtMaxA5";
			this.txtMaxA5.Size = new System.Drawing.Size(100, 20);
			this.txtMaxA5.TabIndex = 29;
			// 
			// txtMaxA4
			// 
			this.txtMaxA4.Location = new System.Drawing.Point(417, 119);
			this.txtMaxA4.Name = "txtMaxA4";
			this.txtMaxA4.Size = new System.Drawing.Size(100, 20);
			this.txtMaxA4.TabIndex = 28;
			// 
			// txtMaxA3
			// 
			this.txtMaxA3.Location = new System.Drawing.Point(417, 93);
			this.txtMaxA3.Name = "txtMaxA3";
			this.txtMaxA3.Size = new System.Drawing.Size(100, 20);
			this.txtMaxA3.TabIndex = 27;
			// 
			// txtMaxA2
			// 
			this.txtMaxA2.Location = new System.Drawing.Point(417, 65);
			this.txtMaxA2.Name = "txtMaxA2";
			this.txtMaxA2.Size = new System.Drawing.Size(100, 20);
			this.txtMaxA2.TabIndex = 26;
			// 
			// txtMaxA1
			// 
			this.txtMaxA1.Location = new System.Drawing.Point(417, 36);
			this.txtMaxA1.Name = "txtMaxA1";
			this.txtMaxA1.Size = new System.Drawing.Size(100, 20);
			this.txtMaxA1.TabIndex = 25;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(359, 66);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(52, 15);
			this.label15.TabIndex = 24;
			this.label15.Text = "Máximo";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(359, 143);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(52, 15);
			this.label14.TabIndex = 23;
			this.label14.Text = "Máximo";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(359, 120);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(52, 15);
			this.label13.TabIndex = 22;
			this.label13.Text = "Máximo";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(359, 93);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 15);
			this.label12.TabIndex = 21;
			this.label12.Text = "Máximo";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(359, 37);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(52, 15);
			this.label11.TabIndex = 20;
			this.label11.Text = "Máximo";
			// 
			// txtMinA5
			// 
			this.txtMinA5.Location = new System.Drawing.Point(253, 142);
			this.txtMinA5.Name = "txtMinA5";
			this.txtMinA5.Size = new System.Drawing.Size(100, 20);
			this.txtMinA5.TabIndex = 19;
			// 
			// txtMinA4
			// 
			this.txtMinA4.Location = new System.Drawing.Point(253, 116);
			this.txtMinA4.Name = "txtMinA4";
			this.txtMinA4.Size = new System.Drawing.Size(100, 20);
			this.txtMinA4.TabIndex = 18;
			// 
			// txtMinA2
			// 
			this.txtMinA2.Location = new System.Drawing.Point(253, 65);
			this.txtMinA2.Name = "txtMinA2";
			this.txtMinA2.Size = new System.Drawing.Size(100, 20);
			this.txtMinA2.TabIndex = 17;
			// 
			// txtMinA3
			// 
			this.txtMinA3.Location = new System.Drawing.Point(253, 91);
			this.txtMinA3.Name = "txtMinA3";
			this.txtMinA3.Size = new System.Drawing.Size(100, 20);
			this.txtMinA3.TabIndex = 16;
			// 
			// txtMinA1
			// 
			this.txtMinA1.Location = new System.Drawing.Point(253, 36);
			this.txtMinA1.Name = "txtMinA1";
			this.txtMinA1.Size = new System.Drawing.Size(100, 20);
			this.txtMinA1.TabIndex = 15;
			// 
			// lblA5
			// 
			this.lblA5.AutoSize = true;
			this.lblA5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA5.Location = new System.Drawing.Point(198, 143);
			this.lblA5.Name = "lblA5";
			this.lblA5.Size = new System.Drawing.Size(49, 15);
			this.lblA5.TabIndex = 14;
			this.lblA5.Text = "Mínimo";
			// 
			// lblA4
			// 
			this.lblA4.AutoSize = true;
			this.lblA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA4.Location = new System.Drawing.Point(198, 116);
			this.lblA4.Name = "lblA4";
			this.lblA4.Size = new System.Drawing.Size(49, 15);
			this.lblA4.TabIndex = 13;
			this.lblA4.Text = "Mínimo";
			// 
			// lblA3
			// 
			this.lblA3.AutoSize = true;
			this.lblA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA3.Location = new System.Drawing.Point(198, 93);
			this.lblA3.Name = "lblA3";
			this.lblA3.Size = new System.Drawing.Size(49, 15);
			this.lblA3.TabIndex = 12;
			this.lblA3.Text = "Mínimo";
			// 
			// lblA2
			// 
			this.lblA2.AutoSize = true;
			this.lblA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA2.Location = new System.Drawing.Point(198, 66);
			this.lblA2.Name = "lblA2";
			this.lblA2.Size = new System.Drawing.Size(49, 15);
			this.lblA2.TabIndex = 11;
			this.lblA2.Text = "Mínimo";
			// 
			// lblA1
			// 
			this.lblA1.AutoSize = true;
			this.lblA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblA1.Location = new System.Drawing.Point(198, 37);
			this.lblA1.Name = "lblA1";
			this.lblA1.Size = new System.Drawing.Size(49, 15);
			this.lblA1.TabIndex = 10;
			this.lblA1.Text = "Mínimo";
			// 
			// cmbA5
			// 
			this.cmbA5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbA5.FormattingEnabled = true;
			this.cmbA5.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial"});
			this.cmbA5.Location = new System.Drawing.Point(71, 142);
			this.cmbA5.Name = "cmbA5";
			this.cmbA5.Size = new System.Drawing.Size(121, 21);
			this.cmbA5.TabIndex = 9;
			this.cmbA5.SelectedIndexChanged += new System.EventHandler(this.cmbA5_SelectedIndexChanged);
			// 
			// cmbA4
			// 
			this.cmbA4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbA4.FormattingEnabled = true;
			this.cmbA4.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial"});
			this.cmbA4.Location = new System.Drawing.Point(71, 115);
			this.cmbA4.Name = "cmbA4";
			this.cmbA4.Size = new System.Drawing.Size(121, 21);
			this.cmbA4.TabIndex = 8;
			this.cmbA4.SelectedIndexChanged += new System.EventHandler(this.cmbA4_SelectedIndexChanged);
			// 
			// cmbA3
			// 
			this.cmbA3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbA3.FormattingEnabled = true;
			this.cmbA3.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial"});
			this.cmbA3.Location = new System.Drawing.Point(71, 88);
			this.cmbA3.Name = "cmbA3";
			this.cmbA3.Size = new System.Drawing.Size(121, 21);
			this.cmbA3.TabIndex = 7;
			this.cmbA3.SelectedIndexChanged += new System.EventHandler(this.cmbA3_SelectedIndexChanged);
			// 
			// cmbA2
			// 
			this.cmbA2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbA2.FormattingEnabled = true;
			this.cmbA2.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial"});
			this.cmbA2.Location = new System.Drawing.Point(71, 61);
			this.cmbA2.Name = "cmbA2";
			this.cmbA2.Size = new System.Drawing.Size(121, 21);
			this.cmbA2.TabIndex = 6;
			this.cmbA2.SelectedIndexChanged += new System.EventHandler(this.cmbA2_SelectedIndexChanged);
			// 
			// cmbA1
			// 
			this.cmbA1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbA1.FormattingEnabled = true;
			this.cmbA1.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial"});
			this.cmbA1.Location = new System.Drawing.Point(71, 34);
			this.cmbA1.Name = "cmbA1";
			this.cmbA1.Size = new System.Drawing.Size(121, 21);
			this.cmbA1.TabIndex = 5;
			this.cmbA1.SelectedIndexChanged += new System.EventHandler(this.cmbA1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(20, 147);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(24, 16);
			this.label5.TabIndex = 4;
			this.label5.Text = "A5";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(20, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(24, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "A4";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(20, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 16);
			this.label3.TabIndex = 2;
			this.label3.Text = "A3";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(24, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "A2";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(20, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(24, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "A1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.rbSeleccionDatos);
			this.groupBox2.Controls.Add(this.rbPorDefecto);
			this.groupBox2.Location = new System.Drawing.Point(12, 83);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(247, 74);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Seleccionar metodo para generar datos";
			// 
			// rbSeleccionDatos
			// 
			this.rbSeleccionDatos.AutoSize = true;
			this.rbSeleccionDatos.Location = new System.Drawing.Point(6, 42);
			this.rbSeleccionDatos.Name = "rbSeleccionDatos";
			this.rbSeleccionDatos.Size = new System.Drawing.Size(116, 17);
			this.rbSeleccionDatos.TabIndex = 1;
			this.rbSeleccionDatos.Text = "Seleccion de datos";
			this.rbSeleccionDatos.UseVisualStyleBackColor = true;
			this.rbSeleccionDatos.CheckedChanged += new System.EventHandler(this.rbSeleccionDatos_CheckedChanged);
			// 
			// rbPorDefecto
			// 
			this.rbPorDefecto.AutoSize = true;
			this.rbPorDefecto.Checked = true;
			this.rbPorDefecto.Location = new System.Drawing.Point(6, 19);
			this.rbPorDefecto.Name = "rbPorDefecto";
			this.rbPorDefecto.Size = new System.Drawing.Size(82, 17);
			this.rbPorDefecto.TabIndex = 0;
			this.rbPorDefecto.TabStop = true;
			this.rbPorDefecto.Text = "Por Defecto";
			this.rbPorDefecto.UseVisualStyleBackColor = true;
			this.rbPorDefecto.CheckedChanged += new System.EventHandler(this.rbPorDefecto_CheckedChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(15, 170);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(122, 13);
			this.label16.TabIndex = 3;
			this.label16.Text = "Numero de simulaciones";
			// 
			// txtNroSimulaciones
			// 
			this.txtNroSimulaciones.Location = new System.Drawing.Point(143, 167);
			this.txtNroSimulaciones.Name = "txtNroSimulaciones";
			this.txtNroSimulaciones.Size = new System.Drawing.Size(100, 20);
			this.txtNroSimulaciones.TabIndex = 4;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(9, 22);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(43, 13);
			this.label17.TabIndex = 5;
			this.label17.Text = "Semilla:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(202, 22);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(35, 13);
			this.label18.TabIndex = 6;
			this.label18.Text = "Cte a:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(17, 48);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(35, 13);
			this.label19.TabIndex = 7;
			this.label19.Text = "Cte c:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(164, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(37, 13);
			this.label20.TabIndex = 8;
			this.label20.Text = "Cte m:";
			// 
			// txtSemilla
			// 
			this.txtSemilla.Location = new System.Drawing.Point(58, 19);
			this.txtSemilla.Name = "txtSemilla";
			this.txtSemilla.Size = new System.Drawing.Size(138, 20);
			this.txtSemilla.TabIndex = 9;
			// 
			// txtCteA
			// 
			this.txtCteA.Location = new System.Drawing.Point(241, 19);
			this.txtCteA.Name = "txtCteA";
			this.txtCteA.Size = new System.Drawing.Size(100, 20);
			this.txtCteA.TabIndex = 10;
			// 
			// txtCteC
			// 
			this.txtCteC.Location = new System.Drawing.Point(58, 45);
			this.txtCteC.Name = "txtCteC";
			this.txtCteC.Size = new System.Drawing.Size(100, 20);
			this.txtCteC.TabIndex = 11;
			// 
			// txtCteM
			// 
			this.txtCteM.Location = new System.Drawing.Point(207, 45);
			this.txtCteM.Name = "txtCteM";
			this.txtCteM.Size = new System.Drawing.Size(100, 20);
			this.txtCteM.TabIndex = 12;
			// 
			// gbDatosCongruencial
			// 
			this.gbDatosCongruencial.Controls.Add(this.txtCteA);
			this.gbDatosCongruencial.Controls.Add(this.txtCteM);
			this.gbDatosCongruencial.Controls.Add(this.label17);
			this.gbDatosCongruencial.Controls.Add(this.txtCteC);
			this.gbDatosCongruencial.Controls.Add(this.label18);
			this.gbDatosCongruencial.Controls.Add(this.label19);
			this.gbDatosCongruencial.Controls.Add(this.txtSemilla);
			this.gbDatosCongruencial.Controls.Add(this.label20);
			this.gbDatosCongruencial.Location = new System.Drawing.Point(822, 31);
			this.gbDatosCongruencial.Name = "gbDatosCongruencial";
			this.gbDatosCongruencial.Size = new System.Drawing.Size(376, 88);
			this.gbDatosCongruencial.TabIndex = 13;
			this.gbDatosCongruencial.TabStop = false;
			this.gbDatosCongruencial.Text = "Datos Congruencial Mixto";
			// 
			// btnCalcular
			// 
			this.btnCalcular.Location = new System.Drawing.Point(822, 137);
			this.btnCalcular.Name = "btnCalcular";
			this.btnCalcular.Size = new System.Drawing.Size(114, 42);
			this.btnCalcular.TabIndex = 14;
			this.btnCalcular.Text = "Calcular";
			this.btnCalcular.UseVisualStyleBackColor = true;
			this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
			// 
			// dgvFrec
			// 
			this.dgvFrec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFrec.Location = new System.Drawing.Point(12, 212);
			this.dgvFrec.Name = "dgvFrec";
			this.dgvFrec.Size = new System.Drawing.Size(1215, 254);
			this.dgvFrec.TabIndex = 15;
			// 
			// limpiar
			// 
			this.limpiar.Location = new System.Drawing.Point(962, 136);
			this.limpiar.Name = "limpiar";
			this.limpiar.Size = new System.Drawing.Size(114, 42);
			this.limpiar.TabIndex = 16;
			this.limpiar.Text = "Limpiar datos";
			this.limpiar.UseVisualStyleBackColor = true;
			this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
			// 
			// TP4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1239, 629);
			this.Controls.Add(this.limpiar);
			this.Controls.Add(this.dgvFrec);
			this.Controls.Add(this.btnCalcular);
			this.Controls.Add(this.gbDatosCongruencial);
			this.Controls.Add(this.txtNroSimulaciones);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.gbDatosActividades);
			this.Controls.Add(this.gbxGeneracionNros);
			this.Name = "TP4";
			this.Text = "TP4";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbxGeneracionNros.ResumeLayout(false);
			this.gbxGeneracionNros.PerformLayout();
			this.gbDatosActividades.ResumeLayout(false);
			this.gbDatosActividades.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gbDatosCongruencial.ResumeLayout(false);
			this.gbDatosCongruencial.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFrec)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxGeneracionNros;
        private System.Windows.Forms.RadioButton rbCongruencialMixto;
        private System.Windows.Forms.RadioButton rbAleatorio;
        private System.Windows.Forms.GroupBox gbDatosActividades;
        private System.Windows.Forms.TextBox txtMaxA5;
        private System.Windows.Forms.TextBox txtMaxA4;
        private System.Windows.Forms.TextBox txtMaxA3;
        private System.Windows.Forms.TextBox txtMaxA2;
        private System.Windows.Forms.TextBox txtMaxA1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinA5;
        private System.Windows.Forms.TextBox txtMinA4;
        private System.Windows.Forms.TextBox txtMinA2;
        private System.Windows.Forms.TextBox txtMinA3;
        private System.Windows.Forms.TextBox txtMinA1;
        private System.Windows.Forms.Label lblA5;
        private System.Windows.Forms.Label lblA4;
        private System.Windows.Forms.Label lblA3;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.ComboBox cmbA5;
        private System.Windows.Forms.ComboBox cmbA4;
        private System.Windows.Forms.ComboBox cmbA3;
        private System.Windows.Forms.ComboBox cmbA2;
        private System.Windows.Forms.ComboBox cmbA1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbSeleccionDatos;
        private System.Windows.Forms.RadioButton rbPorDefecto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNroSimulaciones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtSemilla;
        private System.Windows.Forms.TextBox txtCteA;
        private System.Windows.Forms.TextBox txtCteC;
        private System.Windows.Forms.TextBox txtCteM;
        private System.Windows.Forms.GroupBox gbDatosCongruencial;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView dgvFrec;
		private System.Windows.Forms.Button limpiar;
	}
}

