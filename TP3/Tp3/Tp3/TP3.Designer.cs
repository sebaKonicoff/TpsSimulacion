
namespace WindowsFormsApplication1
{
	partial class TP3
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_n = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbo_distrib = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_lambda = new System.Windows.Forms.TextBox();
			this.txt_desv = new System.Windows.Forms.TextBox();
			this.txt_media = new System.Windows.Forms.TextBox();
			this.txt_max = new System.Windows.Forms.TextBox();
			this.txt_min = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lst_distrib = new System.Windows.Forms.ListView();
			this.valoresGenerados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.chrt_histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txt_confianza = new System.Windows.Forms.TextBox();
			this.txt_intervalos = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btn_generar = new System.Windows.Forms.Button();
			this.dgv_frec = new System.Windows.Forms.DataGridView();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.lbl_resultadoPrueba = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chrt_histograma)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_frec)).BeginInit();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_n);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cbo_distrib);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(24, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(314, 117);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Elija distribucion y muestra";
			// 
			// txt_n
			// 
			this.txt_n.Location = new System.Drawing.Point(165, 72);
			this.txt_n.Name = "txt_n";
			this.txt_n.Size = new System.Drawing.Size(121, 26);
			this.txt_n.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(9, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tamaño de la muestra";
			// 
			// cbo_distrib
			// 
			this.cbo_distrib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_distrib.FormattingEnabled = true;
			this.cbo_distrib.Items.AddRange(new object[] {
            "Uniforme",
            "Normal",
            "Exponencial",
            "Poisson"});
			this.cbo_distrib.Location = new System.Drawing.Point(165, 35);
			this.cbo_distrib.Name = "cbo_distrib";
			this.cbo_distrib.Size = new System.Drawing.Size(121, 24);
			this.cbo_distrib.TabIndex = 1;
			this.cbo_distrib.Text = "--Seleccionar--";
			this.cbo_distrib.SelectedIndexChanged += new System.EventHandler(this.cbo_distrib_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Distribución";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt_lambda);
			this.groupBox2.Controls.Add(this.txt_desv);
			this.groupBox2.Controls.Add(this.txt_media);
			this.groupBox2.Controls.Add(this.txt_max);
			this.groupBox2.Controls.Add(this.txt_min);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(380, 34);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(588, 117);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Parametros inciales";
			// 
			// txt_lambda
			// 
			this.txt_lambda.Location = new System.Drawing.Point(472, 29);
			this.txt_lambda.Name = "txt_lambda";
			this.txt_lambda.Size = new System.Drawing.Size(100, 26);
			this.txt_lambda.TabIndex = 9;
			// 
			// txt_desv
			// 
			this.txt_desv.Location = new System.Drawing.Point(310, 66);
			this.txt_desv.Name = "txt_desv";
			this.txt_desv.Size = new System.Drawing.Size(100, 26);
			this.txt_desv.TabIndex = 8;
			// 
			// txt_media
			// 
			this.txt_media.Location = new System.Drawing.Point(275, 29);
			this.txt_media.Name = "txt_media";
			this.txt_media.Size = new System.Drawing.Size(100, 26);
			this.txt_media.TabIndex = 7;
			// 
			// txt_max
			// 
			this.txt_max.Location = new System.Drawing.Point(91, 69);
			this.txt_max.Name = "txt_max";
			this.txt_max.Size = new System.Drawing.Size(100, 26);
			this.txt_max.TabIndex = 6;
			// 
			// txt_min
			// 
			this.txt_min.Location = new System.Drawing.Point(91, 29);
			this.txt_min.Name = "txt_min";
			this.txt_min.Size = new System.Drawing.Size(100, 26);
			this.txt_min.TabIndex = 5;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(405, 32);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(67, 20);
			this.label7.TabIndex = 4;
			this.label7.Text = "Lambda";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(218, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(86, 20);
			this.label6.TabIndex = 3;
			this.label6.Text = "Desviacion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(218, 32);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 20);
			this.label5.TabIndex = 2;
			this.label5.Text = "Media";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(26, 75);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 20);
			this.label4.TabIndex = 1;
			this.label4.Text = "Maximo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(26, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 20);
			this.label3.TabIndex = 0;
			this.label3.Text = "Mínimo";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.lst_distrib);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(24, 167);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(567, 158);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Numeros generados";
			// 
			// lst_distrib
			// 
			this.lst_distrib.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.valoresGenerados});
			this.lst_distrib.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lst_distrib.HideSelection = false;
			this.lst_distrib.Location = new System.Drawing.Point(12, 25);
			this.lst_distrib.Name = "lst_distrib";
			this.lst_distrib.Size = new System.Drawing.Size(541, 132);
			this.lst_distrib.TabIndex = 9;
			this.lst_distrib.UseCompatibleStateImageBehavior = false;
			this.lst_distrib.View = System.Windows.Forms.View.Details;
			// 
			// valoresGenerados
			// 
			this.valoresGenerados.Tag = "";
			this.valoresGenerados.Text = "Valores Generados";
			this.valoresGenerados.Width = 165;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.chrt_histograma);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(24, 383);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(498, 336);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Histograma generado";
			// 
			// chrt_histograma
			// 
			chartArea1.Name = "ChartArea1";
			this.chrt_histograma.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chrt_histograma.Legends.Add(legend1);
			this.chrt_histograma.Location = new System.Drawing.Point(0, 25);
			this.chrt_histograma.Name = "chrt_histograma";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Frecuencia";
			this.chrt_histograma.Series.Add(series1);
			this.chrt_histograma.Size = new System.Drawing.Size(498, 311);
			this.chrt_histograma.TabIndex = 0;
			this.chrt_histograma.Text = "chart1";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.txt_confianza);
			this.groupBox5.Controls.Add(this.txt_intervalos);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(619, 180);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(349, 134);
			this.groupBox5.TabIndex = 4;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "K-S";
			// 
			// txt_confianza
			// 
			this.txt_confianza.Location = new System.Drawing.Point(204, 75);
			this.txt_confianza.Name = "txt_confianza";
			this.txt_confianza.Size = new System.Drawing.Size(100, 23);
			this.txt_confianza.TabIndex = 3;
			this.txt_confianza.Text = "0.95";
			// 
			// txt_intervalos
			// 
			this.txt_intervalos.Location = new System.Drawing.Point(204, 41);
			this.txt_intervalos.Name = "txt_intervalos";
			this.txt_intervalos.Size = new System.Drawing.Size(100, 23);
			this.txt_intervalos.TabIndex = 2;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(30, 81);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(124, 17);
			this.label9.TabIndex = 1;
			this.label9.Text = "Nivel de confianza";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 44);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(149, 17);
			this.label8.TabIndex = 0;
			this.label8.Text = "Cantidad de intervalos";
			// 
			// btn_generar
			// 
			this.btn_generar.Location = new System.Drawing.Point(422, 331);
			this.btn_generar.Name = "btn_generar";
			this.btn_generar.Size = new System.Drawing.Size(169, 52);
			this.btn_generar.TabIndex = 5;
			this.btn_generar.Text = "Aceptar";
			this.btn_generar.UseVisualStyleBackColor = true;
			this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
			// 
			// dgv_frec
			// 
			this.dgv_frec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_frec.Location = new System.Drawing.Point(6, 19);
			this.dgv_frec.Name = "dgv_frec";
			this.dgv_frec.Size = new System.Drawing.Size(788, 281);
			this.dgv_frec.TabIndex = 7;
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.dgv_frec);
			this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(528, 389);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(817, 306);
			this.groupBox7.TabIndex = 8;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Tabla de valores generados";
			// 
			// lbl_resultadoPrueba
			// 
			this.lbl_resultadoPrueba.AutoSize = true;
			this.lbl_resultadoPrueba.Location = new System.Drawing.Point(6, 47);
			this.lbl_resultadoPrueba.Name = "lbl_resultadoPrueba";
			this.lbl_resultadoPrueba.Size = new System.Drawing.Size(54, 17);
			this.lbl_resultadoPrueba.TabIndex = 0;
			this.lbl_resultadoPrueba.Text = "label10";
			this.lbl_resultadoPrueba.Visible = false;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.lbl_resultadoPrueba);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(1005, 34);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(317, 158);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Decisión";
			this.groupBox6.Visible = false;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(12, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(382, 13);
			this.label10.TabIndex = 9;
			this.label10.Text = "Integrantes: Diaz Lucas, Falco Gonzalo, Konicoff Sebastian y Rey Nores Mateo";
			// 
			// TP3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1334, 749);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.btn_generar);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "TP3";
			this.Text = "Trabajo práctico 3 - Grupo H";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chrt_histograma)).EndInit();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_frec)).EndInit();
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cbo_distrib;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_n;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_lambda;
		private System.Windows.Forms.TextBox txt_desv;
		private System.Windows.Forms.TextBox txt_media;
		private System.Windows.Forms.TextBox txt_max;
		private System.Windows.Forms.TextBox txt_min;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chrt_histograma;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txt_confianza;
		private System.Windows.Forms.TextBox txt_intervalos;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button btn_generar;
		private System.Windows.Forms.DataGridView dgv_frec;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.ListView lst_distrib;
		private System.Windows.Forms.ColumnHeader valoresGenerados;
		private System.Windows.Forms.Label lbl_resultadoPrueba;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label10;
	}
}

