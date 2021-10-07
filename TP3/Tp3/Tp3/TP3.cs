using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class TP3 : Form
	{
		enum tipo_distribucion { Uniforme, Poisson, Normal, Exponencial };
		double confianza = 0.95;
		int distribucion_seleccionada = 0;
		double[] numeros;
		double intervalos;

		public TP3()
		{
			InitializeComponent();
		}

		private void TP3Inicio_Load(object sender, EventArgs e)
		{
			lbl_resultadoPrueba.Visible = false;
			txt_confianza.Text = confianza.ToString();
			txt_confianza.Enabled = false;
			txt_n.Text = "1000";

		}

		public void btn_generar_Click(object sender, EventArgs e)
		{
			lbl_resultadoPrueba.Text = "";

			dgv_frec.DataSource = null;
			dgv_frec.Refresh();
			chrt_histograma.Series["Frecuencia"].Points.Clear(); //limpio grafico
			lst_distrib.Items.Clear(); // limpio bloc

			// paso generar valores
			numeros = generarValores();

			// Paso generar tabla y grafico 
			switch (distribucion_seleccionada)
			{
				case (int)tipo_distribucion.Uniforme:
					generar_tabla_distribucion_Uniforme(numeros, Convert.ToDouble(txt_min.Text), Convert.ToDouble(txt_max.Text));
					break;
				case (int)tipo_distribucion.Exponencial:
					generar_tablasExp(numeros);
					break;
				case (int)tipo_distribucion.Poisson:
					generar_tablasPoisson(numeros);
					break;
				case (int)tipo_distribucion.Normal:
					generar_tablasNormal(numeros);
					break;
			}
			evaluarPrueba();
		}

		public double[] generarValores()
		{
			// limpia campos
			dgv_frec.DataSource = null;
			dgv_frec.Refresh();
			chrt_histograma.Series["Frecuencia"].Points.Clear(); //Inicia el grafico
			lst_distrib.Items.Clear();
			numeros = null;

			//Creo el objeto de la clase Random 
			Random RND = new Random();
			int n = Convert.ToInt32(txt_n.Text);

			//Creamos un array que va a contener cantidad aleatoria de numeros que ingresamos por el texbox
			numeros = new double[n];

			//Recorremos el array y vamos asignando a cada posición un número aleatorio
			double min, max, media, desv, lambdaPoisson;
			switch (distribucion_seleccionada)
			{
				case (int)tipo_distribucion.Uniforme:
					min = Convert.ToDouble(txt_min.Text);
					max = Convert.ToDouble(txt_max.Text);
					numeros = Distribucion.generarUniforme(min, max, n);
					for (int i = 0; i < n; i++)
					{
						lst_distrib.Items.Add(numeros[i].ToString());
					}
					break;

				case (int)tipo_distribucion.Exponencial:
					media = Convert.ToDouble(txt_media.Text);
					numeros = Distribucion.generarExponencial(media, n);

					for (int i = 0; i < n; i++)
					{

						lst_distrib.Items.Add(numeros[i].ToString());
					}
					break;

				case (int)tipo_distribucion.Poisson:
					lambdaPoisson = Convert.ToDouble(txt_lambda.Text);
					numeros = Distribucion.generarPoisson(lambdaPoisson, n);
					for (int i = 0; i < n; i++)
					{

						lst_distrib.Items.Add(numeros[i].ToString());
					}
					break;

				case (int)tipo_distribucion.Normal:
					media = Convert.ToDouble(txt_media.Text);
					desv = Convert.ToDouble(txt_desv.Text);
					numeros = Distribucion.generarNormal(n, media, desv);
					for (int i = 0; i < n; i++)
					{
						// numeros = Distribucion.generarNormal(n, media, desv) // muy eneficiente 
						lst_distrib.Items.Add(numeros[i].ToString());
					}
					break;
			}
			return numeros;
		}

		public void generar_tabla_distribucion_Uniforme(double[] numeros, double min, double max)
		{
			double n = numeros.Length;
			int intervalos = Convert.ToInt32(txt_intervalos.Text);
			double pe;
			DataTable dt = new DataTable();
			dt.Columns.Add("N°");
			dt.Columns.Add("MIN");
			dt.Columns.Add("MAX");
			dt.Columns.Add("MC");
			dt.Columns.Add("FO");
			dt.Columns.Add("FE");
			dt.Columns.Add("PO");
			dt.Columns.Add("PE");
			dt.Columns.Add("POAc");
			dt.Columns.Add("PEAC");
			dt.Columns.Add("POAc-PEAc");

			double frec = 0;
			double poAc = 0;
			double peAc = 0;
			double numero = 0;
			double cteIntervalo = (max - min) / intervalos;
			double j = min;

			for (numero = 0; numero < intervalos; numero++)
			{
				double intSig = j + cteIntervalo;
				double marcaClase = (intSig + j) / 2;

				for (int i = 0; i < n; i++)
				{

					if (numeros[i] >= j && numeros[i] < intSig)
						frec++;
				}

				double fe = n / intervalos;
				double po = frec / n;
				poAc += po;

				//Generar histograma
				chrt_histograma.Series["Frecuencia"].Points.AddXY(Math.Round(marcaClase, 4), frec);

				DataRow dr = dt.NewRow();
				dr["N°"] = numero + 1;
				dr["MIN"] = j;
				dr["MAX"] = intSig;
				dr["MC"] = Math.Round(marcaClase, 4);
				dr["FO"] = Math.Round(frec, 4);
				dr["FE"] = Math.Round(fe, 4);
				dr["PO"] = Math.Round(po, 4);
				dr["PE"] = Math.Round((double)1 / intervalos, 4);
				dr["POAc"] = Math.Round(poAc, 4);
				pe = (double)1 / intervalos;
				peAc += pe;
				dr["PEAc"] = Math.Round(peAc, 4);
				dr["POAc-PEAc"] = Math.Round(Math.Abs(poAc - peAc), 4);
				dt.Rows.Add(dr);

				frec = 0;
				j += cteIntervalo;
			}

			dgv_frec.DataSource = dt;
		}

		public void generar_tablasNormal(double[] numeros)
		{
			double n = numeros.Length;
			DataTable dt = new DataTable();
			dt.Columns.Add("N°");
			dt.Columns.Add("MIN");
			dt.Columns.Add("MAX");
			dt.Columns.Add("MC");
			dt.Columns.Add("FO");
			dt.Columns.Add("FE");
			dt.Columns.Add("PO");
			dt.Columns.Add("PE");
			dt.Columns.Add("POAc");
			dt.Columns.Add("PEAc");
			dt.Columns.Add("POAc-PEAc");

			intervalos = Convert.ToInt32(txt_intervalos.Text);

			double min = numeros[0];
			double max = numeros[0];
			double intSig, marcaClase, fe, po, pe, poAc, peAc, abs, numero;
			int frec;

			// Intervalos
			for (int i = 0; i < n; i++)
			{
				if (numeros[i] > max)
				{
					max = numeros[i];
				}
				if (numeros[i] < min)
				{
					min = numeros[i];
				}
			}
			min = Math.Floor(min);
			max = Math.Ceiling(max);
			double j = min;
			double cteIntervalo = (max - min) / intervalos;
			numero = 0;
			frec = 0;
			poAc = 0;
			peAc = 0;
			for (numero = 0; numero < intervalos; numero++)
			{
				intSig = j + cteIntervalo;
				marcaClase = (intSig + j) / 2;
				for (int i = 0; i < n; i++)
				{
					if (numeros[i] >= j && numeros[i] < intSig)
						frec++;
				}


				pe = FuncionDistribucionNormal(j + cteIntervalo) - FuncionDistribucionNormal(j);

				fe = pe * n;
				po = frec / n;
				poAc += po;
				peAc += pe;
				abs = Math.Abs(poAc - peAc);
				chrt_histograma.Series["Frecuencia"].Points.AddXY(Math.Round(marcaClase, 4), frec);


				DataRow dr = dt.NewRow();
				dr["N°"] = numero + 1;
				dr["MIN"] = j;
				dr["MAX"] = intSig;
				dr["MC"] = Math.Round(marcaClase, 4);
				dr["FO"] = frec;
				dr["FE"] = Math.Round(fe, 4);
				dr["PO"] = Math.Round(po, 4);
				dr["PE"] = Math.Round(pe, 4);
				dr["POAc"] = Math.Round(poAc, 4);
				dr["PEAc"] = Math.Round(peAc, 4);
				dr["POAc-PEAc"] = Math.Round(abs, 4);
				dt.Rows.Add(dr);

				frec = 0;
				j += cteIntervalo;
			}

			dgv_frec.DataSource = dt;
		}

		// Exponencial 
		public void generar_tablasExp(double[] numeros)
		{
			double n = numeros.Length;
			double media = Convert.ToDouble(txt_media.Text);

			DataTable dt = new DataTable();
			dt.Columns.Add("N°");
			dt.Columns.Add("MIN");
			dt.Columns.Add("MAX");
			dt.Columns.Add("MC");
			dt.Columns.Add("FO");
			dt.Columns.Add("FE");
			dt.Columns.Add("PO");
			dt.Columns.Add("PE");
			dt.Columns.Add("POAc");
			dt.Columns.Add("PEAc");
			dt.Columns.Add("POAc-PEAc");

			int intervalos = Convert.ToInt32(txt_intervalos.Text);

			double max = numeros[0];
			double intSig;
			int frec = 0;
			double marcaClase;
			double j = 0;

			double lamdaExp = 1 / media;

			double fe;
			double po;
			double pe;
			double poAc = 0;
			double peAc = 0;
			double abs;
			double numero = 0;

			// Intervalos
			for (int i = 0; i < n; i++)
			{
				if (numeros[i] > max)
				{
					max = numeros[i];
				}
			}
			max = Math.Ceiling(max);

			double cteIntervalo = max / intervalos;
			for (numero = 0; numero < intervalos; numero++)
			{
				intSig = j + cteIntervalo;
				marcaClase = (intSig + j) / 2;
				for (int i = 0; i < n; i++)
				{
					if (numeros[i] >= j && numeros[i] < intSig)
					{
						frec++;

					}
				}

				double prob = (1 - Math.Exp(-(lamdaExp * (j + cteIntervalo)))) - (1 - Math.Exp(-(lamdaExp * j)));

				fe = prob * n;
				po = frec / n;
				pe = prob;
				poAc += po;
				peAc += pe;
				abs = Math.Abs(poAc - peAc);

				chrt_histograma.Series["Frecuencia"].Points.AddXY(Math.Round(marcaClase, 4), frec);

				DataRow dr = dt.NewRow();
				dr["N°"] = numero + 1;
				dr["MIN"] = Math.Round(j, 4);
				dr["MAX"] = Math.Round(intSig, 4);
				dr["MC"] = Math.Round(marcaClase, 4);
				dr["FO"] = frec;
				dr["FE"] = Math.Round(fe, 4);
				dr["PO"] = Math.Round(po, 4);
				dr["PE"] = Math.Round(pe, 4);
				dr["POAc"] = Math.Round(poAc, 4);
				dr["PEAc"] = Math.Round(peAc, 4);
				dr["POAc-PEAc"] = Math.Round(abs, 4);
				dt.Rows.Add(dr);

				frec = 0;
				j += cteIntervalo;
			}

			dgv_frec.DataSource = dt;
		}

		public void generar_tablasPoisson(double[] numeros) //Distribucion Poisson
		{
			int n = numeros.Length;

			DataTable dt = new DataTable();
			dt.Columns.Add("N°");
			dt.Columns.Add("MIN");
			dt.Columns.Add("MAX");
			dt.Columns.Add("MC");
			dt.Columns.Add("FO");
			dt.Columns.Add("FE");
			dt.Columns.Add("PO");
			dt.Columns.Add("PE");
			dt.Columns.Add("POAc");
			dt.Columns.Add("PEAc");
			dt.Columns.Add("POAc-PEAc");

			int intervalos = Convert.ToInt32(txt_intervalos.Text);

			double max = numeros[0];
			double intSig = 0;
			int frec = 0;
			double marcaClase = 0;
			double j = 0;

			double lambdaPoisson = Convert.ToDouble(txt_lambda.Text);

			double poAc = 0;
			double peAc = 0;
			double abs = 0;
			int numero = 0;

			// Intervalos
			for (int i = 0; i < n; i++)
			{
				if (numeros[i] > max)
				{
					max = Convert.ToInt32(numeros[i]);
				}
			}
			max++;

			double cteIntervalo = max / intervalos;  // Calculo del paso
			for (numero = 0; numero < intervalos; numero++)
			{
				intSig = j + cteIntervalo;
				marcaClase = (intSig + j) / 2;
				for (int i = 0; i < n; i++)
				{
					if (numeros[i] >= j && numeros[i] < intSig)
					{
						frec++;

					}
				}

				double pe = ProbIntervaloPoisson(j, intSig, lambdaPoisson);
				double po = Po(frec, n);
				double fe = pe * n;
				poAc += po;
				peAc += pe;
				abs = Math.Abs(poAc - peAc);

				chrt_histograma.Series["Frecuencia"].Points.AddXY(Math.Round(marcaClase, 4), frec);

				DataRow dr = dt.NewRow();

				dr["N°"] = numero + 1;
				dr["MIN"] = Math.Round(j, 4);
				dr["MAX"] = Math.Round(intSig, 4);
				dr["MC"] = Math.Round(marcaClase, 4);
				dr["FO"] = frec;
				dr["FE"] = Math.Round(fe, 4);
				dr["PO"] = Math.Round((double)frec / n, 4);
				dr["PE"] = Math.Round(pe, 4);
				dr["POAc"] = Math.Round(poAc, 4);
				dr["PEAc"] = Math.Round(peAc, 4);
				dr["POAc-PEAc"] = Math.Round(abs, 4);

				dt.Rows.Add(dr);

				frec = 0;
				j += cteIntervalo;

			}

			dgv_frec.DataSource = dt;
		}

		private double Po(double frec, double n)
		{
			return frec / n;
		}

		private double ProbIntervaloPoisson(double j, double intSig, double lambda)
		{
			j = Math.Ceiling(j);
			double prob = 0;
			for (int i = (int)j; i < intSig; i++)
			{
				prob += (Math.Pow(lambda, i) * Math.Exp(-lambda)) / factorial(i);
			}
			return prob;
		}

		private void evaluarPrueba() //Recorre la tabla y valida para ver si se acepta o rechaza
		{

			double mayor = 0;
			foreach (DataGridViewRow row in dgv_frec.Rows)
			{

				double valor_ac = Convert.ToDouble(row.Cells["POAc-PEAc"].Value);

				if (valor_ac > mayor)
				{

					mayor = valor_ac;

				}

			}
			int n = Convert.ToInt32(txt_n.Text);
			double valor = 1.36 / Math.Sqrt(n);

			lbl_resultadoPrueba.Text = "Para un nivel de confianza " +

			txt_confianza.Text + " (" + valor + "), y el máximo valor obtenido de la prueba " + mayor + ", obtenemos entonces como conclusión que";

			if (valor > mayor)
			{

				lbl_resultadoPrueba.Text += " SE ACEPTA la prueba.";

			}

			else
			{

				lbl_resultadoPrueba.Text += " SE RECHAZA la prueba.";

			}
			MessageBox.Show(lbl_resultadoPrueba.Text);


		}

		private void cbo_distrib_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbl_resultadoPrueba.Text = "";
			dgv_frec.DataSource = null;
			dgv_frec.Refresh();
			chrt_histograma.Series["Frecuencia"].Points.Clear();
			lst_distrib.Items.Clear();

			switch (cbo_distrib.SelectedIndex)
			{
				case 0:
					distribucion_seleccionada = (int)tipo_distribucion.Uniforme;


					txt_min.Enabled = true;
					txt_max.Enabled = true;
					txt_media.Enabled = false;
					txt_desv.Enabled = false;
					txt_lambda.Enabled = false;
					break;
				case 1:
					distribucion_seleccionada = (int)tipo_distribucion.Normal;
					txt_min.Enabled = false;
					txt_max.Enabled = false;
					txt_media.Enabled = true;
					txt_desv.Enabled = true;
					txt_lambda.Enabled = false;
					break;
				case 2:
					distribucion_seleccionada = (int)tipo_distribucion.Exponencial;
					txt_min.Enabled = false;
					txt_max.Enabled = false;
					txt_media.Enabled = true;
					txt_desv.Enabled = false;
					txt_lambda.Enabled = false;
					break;
				case 3:
					distribucion_seleccionada = (int)tipo_distribucion.Poisson;
					txt_min.Enabled = false;
					txt_max.Enabled = false;
					txt_media.Enabled = false;
					txt_desv.Enabled = false;
					txt_lambda.Enabled = true;
					break;
			}
			txt_min.Text = "";
			txt_max.Text = "";
			txt_media.Text = "";
			txt_desv.Text = "";
			txt_lambda.Text = "";
		}

		private static double factorial(double n)
		{
			double fact = 1;
			for (int i = 1; i <= n; i++)
			{
				fact *= i;
			}
			return fact;
		}

		static double Erf(double x)
		{
			// constants
			double a1 = 0.254829592;
			double a2 = -0.284496736;
			double a3 = 1.421413741;
			double a4 = -1.453152027;
			double a5 = 1.061405429;
			double p = 0.3275911;

			// Save the sign of x
			int sign = 1;
			if (x < 0)
				sign = -1;
			x = Math.Abs(x);

			// A&S formula 7.1.26
			double t = 1.0 / (1.0 + p * x);
			double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

			return sign * y;
		}

		public double FuncionDistribucionNormal(double x)
		{
			double numerador, fraccion, valor;
			numerador = x - Convert.ToDouble(txt_media.Text);
			fraccion = numerador / (Convert.ToDouble(txt_desv.Text) * Math.Sqrt(2));
			valor = 0.5 * (1 + Erf(fraccion));
			return valor;
		}
	}







}

