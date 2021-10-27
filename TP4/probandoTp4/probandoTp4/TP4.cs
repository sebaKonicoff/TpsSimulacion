using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics;

namespace probandoTp4
{
    public partial class TP4 : Form
    {
        enum tipo_distribucion { Uniforme, Normal, Exponencial };
        int distribucion_seleccionadaA1, distribucion_seleccionadaA2, distribucion_seleccionadaA3, distribucion_seleccionadaA4, distribucion_seleccionadaA5;
        double acumInt1, acumInt2, acumInt3, acumInt4, acumInt5, acumInt6, acumInt7, acumInt8, acumInt9, acumInt10, acumInt11, acumInt12, acumInt13, acumInt14, acumInt15;
        double acumPor1, acumPor2, acumPor3, acumPor4, acumPor5, acumPor6, acumPor7, acumPor8, acumPor9, acumPor10, acumPor11, acumPor12, acumPor13, acumPor14, acumPor15;
        double[] vecActual, vecAnterior;
        double minA1, minA2, minA3, mediaA3, minA4, minA5, maxA1, maxA2, maxA3, maxA4, maxA5, mediaA5, semilla, cteA, cteC, cteM, desde, hasta;

        

        double medA1, medA2, medA3, medA4, medA5, desvA1, desvA2, desvA3, desvA4, desvA5, n;
        bool primerSimulacion = true;
        DataTable dt = new DataTable();
        Random r = new Random();
        double contDuracion = 0;
        double promDuracion = 0;
        public TP4()
        {
            InitializeComponent();
        }
        /// Verificaciones
        private void rbPorDefecto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPorDefecto.Checked)
            {
                gbDatosActividades.Enabled = false;
            }
        }

		private void limpiar_Click(object sender, EventArgs e)
		{
            dgvFrec.DataSource = null;
            dgvFrec.Rows.Clear();
            dgvFrec.Refresh();
            txtNroSimulaciones.Text = "";
            cmbA1.Text="";
            cmbA2.Text = "";
            cmbA3.Text = "";
            cmbA5.Text = "";
            txtMinA1.Text = "";
            txtMinA2.Text = "";
            txtMinA3.Text = "";
            txtMinA4.Text = "";
            txtMinA5.Text = "";
            txtMaxA1.Text = "";
            txtMaxA2.Text = "";
            txtMaxA3.Text = "";
            txtMaxA4.Text = "";
            txtMaxA5.Text = "";
            txtSemilla.Text = "";
            txtCteA.Text = "";
            txtCteC.Text = "";
            txtCteM.Text = "";
            vecActual = new double [63];
            vecAnterior = new double[63];
            seleccionDatos();

        }

        private void rbPrimeros5000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPrimeros5000.Checked)
            {
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
            }
        }
        private void rbUltimos5000_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUltimos5000.Checked)
            {
                txtDesde.Enabled = false;
                txtHasta.Enabled = false;
            }
        }
        private void rbDesdeHasta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesdeHasta.Checked)
            {
                txtHasta.Enabled = true;
                txtDesde.Enabled = true;
            }
        }
        private void rbSeleccionDatos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSeleccionDatos.Checked)
            {
                gbDatosActividades.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbDatosCongruencial.Enabled = false;
            gbDatosActividades.Enabled = false;
            cmbA1.SelectedIndex = 0;
            txtMinA1.Text = "20";
            txtMaxA1.Text = "30";
            cmbA2.SelectedIndex = 0;
            txtMinA2.Text = "30";
            txtMaxA2.Text = "50";
            cmbA3.SelectedIndex = 2;
            txtMediaA3.Text = "30";
            cmbA4.SelectedIndex = 0;
            txtMinA4.Text = "10";
            txtMaxA4.Text = "20";
            cmbA5.SelectedIndex = 2;
            txtMediaA5.Text = "5";
            acumInt1 = 1;
            acumInt2 = 1;
            acumInt3 = 1;
            acumInt4 = 1;
            acumInt5 = 1;
            acumInt6 = 1;
            acumInt7 = 1;
            acumInt8 = 1;
            acumInt9 = 1;
            acumInt10 = 1;
            acumInt11 = 1;
            acumInt12 = 1;
            acumInt13 = 1;
            acumInt14 = 1;
            acumPor1 = 1;
            acumPor2 = 1;
            acumPor3 = 1;
            acumPor4 = 1;
            acumPor5 = 1;
            acumPor6 = 1;
            acumPor7 = 1;
            acumPor8 = 1;
            acumPor9 = 1;
            acumPor10 = 1;
            acumPor11 = 1;
            acumPor12 = 1;
            acumPor13 = 1;
            acumPor14 = 1;
            acumPor15 = 1;
            dt.Columns.Add("Nro");
            dt.Columns.Add("A1");
            dt.Columns.Add("A2");
            dt.Columns.Add("A3");
            dt.Columns.Add("A4");
            dt.Columns.Add("A5");
            dt.Columns.Add("Camino 1");
            dt.Columns.Add("Camino 2");
            dt.Columns.Add("Camino 3");
            dt.Columns.Add("Duración");
            dt.Columns.Add("Promedio");
            dt.Columns.Add("D Min");
            dt.Columns.Add("D Max");
            dt.Columns.Add("Prob Ocurrencia");
            dt.Columns.Add("Desv");
            dt.Columns.Add("Fec90");
            dt.Columns.Add("Int 1");
            dt.Columns.Add("Int 2");
            dt.Columns.Add("Int 3");
            dt.Columns.Add("Int 4");
            dt.Columns.Add("Int 5");
            dt.Columns.Add("Int 6");
            dt.Columns.Add("Int 7");
            dt.Columns.Add("Int 8");
            dt.Columns.Add("Int 9");
            dt.Columns.Add("Int 10");
            dt.Columns.Add("Int 11");
            dt.Columns.Add("Int 12");
            dt.Columns.Add("Int 13");
            dt.Columns.Add("Int 14");
            dt.Columns.Add("Int 15");
            dt.Columns.Add("P. Int 1");
            dt.Columns.Add("P. Int 2");
            dt.Columns.Add("P. Int 3");
            dt.Columns.Add("P. Int 4");
            dt.Columns.Add("P. Int 5");
            dt.Columns.Add("P. Int 6");
            dt.Columns.Add("P. Int 7");
            dt.Columns.Add("P. Int 8");
            dt.Columns.Add("P. Int 9");
            dt.Columns.Add("P. Int 10");
            dt.Columns.Add("P. Int 11");
            dt.Columns.Add("P. Int 12");
            dt.Columns.Add("P. Int 13");
            dt.Columns.Add("P. Int 14");
            dt.Columns.Add("P. Int 15");
            dt.Columns.Add("Int 1 %");
            dt.Columns.Add("Int 2 %");
            dt.Columns.Add("Int 3 %");
            dt.Columns.Add("Int 4 %");
            dt.Columns.Add("Int 5 %");
            dt.Columns.Add("Int 6 %");
            dt.Columns.Add("Int 7 %");
            dt.Columns.Add("Int 8 %");
            dt.Columns.Add("Int 9 %");
            dt.Columns.Add("Int 10 %");
            dt.Columns.Add("Int 11 %");
            dt.Columns.Add("Int 12 %");
            dt.Columns.Add("Int 13 %");
            dt.Columns.Add("Int 14 %");
            dt.Columns.Add("Int 15 %");
        }

        private void rbCongruencialMixto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCongruencialMixto.Checked)
            {
                gbDatosCongruencial.Enabled = true;
            }
        }

        private void rbAleatorio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAleatorio.Checked)
            {
                gbDatosCongruencial.Enabled = false;
            }
        }
        private void DistribucionSeleccionada(int index, TextBox min, TextBox max, TextBox media, TextBox desv)
        {
            switch (index)
            {
                case 0:
                    min.Enabled = true;
                    max.Enabled = true;
                    media.Enabled = false;
                    media.Text = "";
                    desv.Enabled = false;
                    desv.Text = "";
                    break;
                case 1:
                    min.Enabled = false;
                    min.Text = "";
                    max.Enabled = false;
                    max.Text = "";
                    media.Enabled = true;
                    desv.Enabled = true;
                    break;
                case 2:
                    min.Enabled = false;
                    min.Text = "";
                    max.Enabled = false;
                    max.Text = "";
                    media.Enabled = true;
                    desv.Enabled = false;
                    desv.Text = "";
                    break;
            }
        }
        private void cmbA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribucionSeleccionada(cmbA1.SelectedIndex, txtMinA1, txtMaxA1, txtMediaA1, txtDesvA1);
        }

        private void cmbA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribucionSeleccionada(cmbA2.SelectedIndex, txtMinA2, txtMaxA2, txtMediaA2, txtDesvA2);
        }
        private void cmbA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribucionSeleccionada(cmbA3.SelectedIndex, txtMinA3, txtMaxA3, txtMediaA3, txtDesvA3);
        }

        private void cmbA4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribucionSeleccionada(cmbA4.SelectedIndex, txtMinA4, txtMaxA4, txtMediaA4, txtDesvA4);
        }

        private void cmbA5_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistribucionSeleccionada(cmbA5.SelectedIndex, txtMinA5, txtMaxA5, txtMediaA5, txtDesvA5);
        }

        public void validacionTxt()
        {
            if (txtMinA1.Text == "") { txtMinA1.Text = "0"; }
            if (txtMinA2.Text == "") { txtMinA2.Text = "0"; }
            if (txtMinA3.Text == "") { txtMinA3.Text = "0"; }
            if (txtMinA4.Text == "") { txtMinA4.Text = "0"; }
            if (txtMinA5.Text == "") { txtMinA5.Text = "0"; }
            if (txtMaxA1.Text == "") { txtMaxA1.Text = "0"; }
            if (txtMaxA2.Text == "") { txtMaxA2.Text = "0"; }
            if (txtMaxA3.Text == "") { txtMaxA3.Text = "0"; }
            if (txtMaxA4.Text == "") { txtMaxA4.Text = "0"; }
            if (txtMaxA5.Text == "") { txtMaxA5.Text = "0"; }
            if (txtMediaA1.Text == "") { txtMediaA1.Text = "0"; }
            if (txtMediaA2.Text == "") { txtMediaA2.Text = "0"; }
            if (txtMediaA3.Text == "") { txtMediaA3.Text = "0"; }
            if (txtMediaA4.Text == "") { txtMediaA4.Text = "0"; }
            if (txtMediaA5.Text == "") { txtMediaA5.Text = "0"; }
            if (txtDesvA1.Text == "") { txtDesvA1.Text = "0"; }
            if (txtDesvA2.Text == "") { txtDesvA2.Text = "0"; }
            if (txtDesvA3.Text == "") { txtDesvA3.Text = "0"; }
            if (txtDesvA4.Text == "") { txtDesvA4.Text = "0"; }
            if (txtDesvA5.Text == "") { txtDesvA5.Text = "0"; }

        }
        public void seleccionDatos()
        {
            if (rbPorDefecto.Checked)
            {
                minA1 = 20;
                minA2 = 30;
                minA3 = 40;
                mediaA3 = 30;
                minA4 = 10;
                minA5 = 4;
                maxA1 = 30;
                maxA2 = 50;
                maxA3 = 0.115;
                maxA4 = 20;
                maxA5 = 5;
                mediaA5 = 5;
                distribucion_seleccionadaA1 = 0;
                distribucion_seleccionadaA2 = 0;
                distribucion_seleccionadaA3 = 2;
                distribucion_seleccionadaA4 = 0;
                distribucion_seleccionadaA5 = 2;

            }
            else
            {
                validacionTxt();

                minA1 = int.Parse(txtMinA1.Text);
                minA2 = int.Parse(txtMinA2.Text);
                minA3 = int.Parse(txtMinA3.Text);
                minA4 = int.Parse(txtMinA4.Text);
                minA5 = int.Parse(txtMinA5.Text);
                maxA1 = int.Parse(txtMaxA1.Text);
                maxA2 = int.Parse(txtMaxA2.Text);
                maxA3 = int.Parse(txtMaxA3.Text);
                maxA4 = int.Parse(txtMaxA4.Text);
                maxA5 = int.Parse(txtMaxA5.Text);
                medA1 = int.Parse(txtMediaA1.Text);
                medA2 = int.Parse(txtMediaA2.Text);
                medA3 = int.Parse(txtMediaA3.Text);
                medA4 = int.Parse(txtMediaA4.Text);
                medA5 = int.Parse(txtMediaA5.Text);
                desvA1 = int.Parse(txtDesvA1.Text);
                desvA2 = int.Parse(txtDesvA2.Text);
                desvA3 = int.Parse(txtDesvA3.Text);
                desvA4 = int.Parse(txtDesvA4.Text);
                desvA5 = int.Parse(txtDesvA5.Text);
                distribucion_seleccionadaA1 = cmbA1.SelectedIndex;
                distribucion_seleccionadaA2 = cmbA2.SelectedIndex;
                distribucion_seleccionadaA3 = cmbA3.SelectedIndex;
                distribucion_seleccionadaA4 = cmbA4.SelectedIndex;
                distribucion_seleccionadaA5 = cmbA5.SelectedIndex;
            }
        }
        private bool ValidarDatos()
        {
            string val = "Validación de datos";
            if (txtNroSimulaciones.Text == "")
            {
                MessageBox.Show("Debe ingresar un nunmero de simulaciones válidos!.", val, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Debe ingresar un nunmero de simulaciones válido!");
                return false;
            }

            
            if (cmbA1.Text == "" || cmbA2.Text == "" || cmbA3.Text == "" || cmbA4.Text == "" || cmbA5.Text == "")
            {
                MessageBox.Show("ERROR! Debe seleccionar una opcion de los combos");
                return false;
            }
            if (!ValidarTodasUniformes() || !ValidarTodasExponenciales() || !ValidarTodasNormales())
			{
                MessageBox.Show("ERROR! Debe Ingresar valores válidos");
                return false;
            }
            if (n > 5000)
            {
                if (!rbDesdeHasta.Checked && !rbPrimeros5000.Checked && !rbUltimos5000.Checked)
                {
                    MessageBox.Show("ERROR! Debe seleccionar algun rango para mostrar");
                    return false;
                }
                if (rbDesdeHasta.Checked && (txtDesde.Text == "" || txtHasta.Text == ""))
                {
                    MessageBox.Show("ERROR! Debe ingresar rango para mostrar");
                    return false;
                }

            }           
            return true;
        }

        private bool ValidarTodasUniformes()
        {
            if (!ValidarUniforme(cmbA1, txtMinA1, txtMaxA1))
                return false;
            if (!ValidarUniforme(cmbA2, txtMinA2, txtMaxA2))
                return false;
            if (!ValidarUniforme(cmbA3, txtMinA3, txtMaxA3))
                return false;
            if (!ValidarUniforme(cmbA4, txtMinA4, txtMaxA4))
                return false;
            if (!ValidarUniforme(cmbA5, txtMinA5, txtMaxA5))
                return false;
            return true;
        }
        private bool ValidarTodasExponenciales()
        {
            if (!ValidarExponencial(cmbA1, txtMediaA1))
                return false;
            if (!ValidarExponencial(cmbA2, txtMediaA2))
                return false;
            if (!ValidarExponencial(cmbA3, txtMediaA3))
                return false;
            if (!ValidarExponencial(cmbA4, txtMediaA4))
                return false;
            if (!ValidarExponencial(cmbA5, txtMediaA5))
                return false;
            return true;
        }
        private bool ValidarTodasNormales()
        {
            if (!ValidarNormal(cmbA1, txtMediaA1, txtDesvA1))
                return false;
            if (!ValidarNormal(cmbA2, txtMediaA2, txtDesvA2))
                return false;
            if (!ValidarNormal(cmbA3, txtMediaA3, txtDesvA3))
                return false;
            if (!ValidarNormal(cmbA4, txtMediaA4, txtDesvA4))
                return false;
            if (!ValidarNormal(cmbA5, txtMediaA5, txtDesvA5))
                return false;
            return true;
        }
        private bool ValidarUniforme(ComboBox distribucion, TextBox min, TextBox max)
        {
            if (distribucion.SelectedIndex == 0)
            {
                if (min.Text == "" || max.Text == "")
                    return false;
                if (Convert.ToInt32(min.Text) >= Convert.ToInt32(max.Text))
                    return false;
                if (Convert.ToInt32(min.Text) <= 0)
                    return false;
            }
            return true;
        }

        private bool ValidarExponencial(ComboBox distribucion, TextBox media)
        {
            if (distribucion.SelectedIndex == 2)
            {
                if (media.Text == "")
                    return false;
                if (Convert.ToInt32(media.Text) <= 0)
                    return false;
            }
            return true;
        }
        private bool ValidarNormal(ComboBox distribucion, TextBox media, TextBox desviacion)
        {
            if (distribucion.SelectedIndex == 1)
            {
                validacionTxt();
                
                minA1 = int.Parse(txtMinA1.Text);
                minA2 = int.Parse(txtMinA2.Text);
                minA3 = int.Parse(txtMinA3.Text);
                minA4 = int.Parse(txtMinA4.Text);
                minA5 = int.Parse(txtMinA5.Text);
                maxA1 = int.Parse(txtMaxA1.Text);
                maxA2 = int.Parse(txtMaxA2.Text);
                maxA3 = int.Parse(txtMaxA3.Text);
                maxA4 = int.Parse(txtMaxA4.Text);
                maxA5 = int.Parse(txtMaxA5.Text);
                medA1 = int.Parse(txtMediaA1.Text);
                medA2 = int.Parse(txtMediaA2.Text);
                medA3 = int.Parse(txtMediaA3.Text);
                medA4 = int.Parse(txtMediaA4.Text);
                medA5 = int.Parse(txtMediaA5.Text);
                desvA1 = int.Parse(txtDesvA1.Text);
                desvA2 = int.Parse(txtDesvA2.Text);
                desvA3 = int.Parse(txtDesvA3.Text);
                desvA4 = int.Parse(txtDesvA4.Text);
                desvA5 = int.Parse(txtDesvA5.Text);
                distribucion_seleccionadaA1 = cmbA1.SelectedIndex;
                distribucion_seleccionadaA2 = cmbA2.SelectedIndex;
                distribucion_seleccionadaA3 = cmbA3.SelectedIndex;
                distribucion_seleccionadaA4 = cmbA4.SelectedIndex;
                distribucion_seleccionadaA5 = cmbA5.SelectedIndex;

                if (media.Text == "" || desviacion.Text == "")
                    return false;
                if (Convert.ToInt32(media.Text) <= 0 || Convert.ToInt32(desviacion.Text) <= 0)
                    return false;
            }
            return true;
        }

        public void rangoAMostrar(double n)
        {
            if (n <= 5000)
            {
                desde = 1;
                hasta = n;
            }
            else if (rbPrimeros5000.Checked)
            {
                desde = 1;
                hasta = 5000;
            }
            else if (rbUltimos5000.Checked)
            {
                desde = n - 5000;
                hasta = n;
            }
            else
            {
                desde = Convert.ToDouble(txtDesde.Text);
                hasta = Convert.ToDouble(txtHasta.Text);
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvFrec.DataSource = null;
            dgvFrec.Rows.Clear();
            dgvFrec.Refresh();
            vecActual = new double[63];
            vecAnterior = new double[63];

            

            this.seleccionDatos();

            if (ValidarDatos())
            {
                dgvFrec.DataSource = null;
                dgvFrec.Refresh();
                vecActual = new double[63];
                vecAnterior = new double[63];

                n = Convert.ToDouble(txtNroSimulaciones.Text);
                int posicion = 18;
                double[] vecIntervalos = new double[15];
                Boolean ordenado = false;
                rangoAMostrar(n);

                for (int i = 1; i <= n; i++)
                {
                    vecActual = generarPrimerosValores(vecActual);
                    //obtenemos el tiempo de cada camino y el camino más largo
                    vecActual = tiempoCamino(vecActual);
                    durPromedio(vecActual, i);
                    identMaxMin(vecActual, vecAnterior);
                    probOcurrencia45Dias(vecActual, i);
                    desviacion(vecActual, i);
                    if (i > 1)
                    {
                        prob90(vecActual, i);
                    }
                    armarIntervalos(vecActual, vecIntervalos, i, posicion, ordenado);
                    //i>15 --> tengo que empezar en el 16
                    if (i>15)
                    {
                        calcularProb(vecActual, i);
                        acumPorc(vecActual, i);
                    }
                    //MessageBox.Show("Tamaño del vector: " + vecActual.Length);
                    if (i >= desde && i <= hasta)
                    {
                        agregarDatosTabla(vecActual, i);                 
                    }
                    if (i == n && !rbUltimos5000.Checked)
                    {
                        agregarDatosTabla(vecActual, i);
                    }
                    vecAnterior = vecActual;
                }
            }
            
        }

        public double[] generarPrimerosValores(double[] v)
        {
            double rnd, x;
            
            if (rbAleatorio.Checked)
            {
                for (int i = 1; i <= 5; i++)
                {
                    v[i] = r.NextDouble();
                    
                }
                x = 0;
            }
            else
            {
                if (primerSimulacion)
                {
                    semilla = Convert.ToDouble(txtSemilla.Text);
                    cteA = Convert.ToDouble(txtCteA.Text);
                    cteC = Convert.ToDouble(txtCteC.Text);
                    cteM = Convert.ToDouble(txtCteM.Text);
                    x = generarRandom(semilla, cteA, cteC, cteM);
                    rnd = x / cteM;
                }
                else
                {
                    x = generarRandom(v[0], cteA, cteC, cteM);
                    rnd = x / cteM;
                }
                
                for (int i = 1; i <= 5; i++)
                {
                    v[i] = rnd;
                }
                
            }
            v[0] = x;
            if (rbPorDefecto.Checked)
            {
                v[1] = Distribucion.Distribuciones.generarUniforme(minA1, maxA1, v[1]);
                v[2] = Distribucion.Distribuciones.generarUniforme(minA2, maxA2, v[2]);
                v[3] = Distribucion.Distribuciones.generarExponencial(mediaA3, v[3]);
                v[4] = Distribucion.Distribuciones.generarUniforme(minA4, maxA4, v[4]);
                v[5] = Distribucion.Distribuciones.generarExponencial(mediaA5, v[5]);
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        v[i] = datosPorTeclado(v[i], distribucion_seleccionadaA1, minA1, maxA1, medA1, desvA1, n);
                    }
                    else if (i == 2)
                    {
                        v[i] = datosPorTeclado(v[i], distribucion_seleccionadaA2, minA2, maxA2, medA2, desvA2, n);
                    }
                    else if (i == 3)
                    {
                        v[i] = datosPorTeclado(v[i], distribucion_seleccionadaA3, minA3, maxA3, medA3, desvA3, n);
                    }
                    else if (i == 4)
                    {
                        v[i] = datosPorTeclado(v[i], distribucion_seleccionadaA4, minA4, maxA4, medA4, desvA4, n);
                    }
                    else if (i == 5)
                    {
                        v[i] = datosPorTeclado(v[i], distribucion_seleccionadaA5, minA5, maxA5, medA5, desvA5, n);
                    }
                }
            }
            
            return v;
        }

        //según lo que seleccionó por teclado, va a llamar a la distribución correspondiente.
        public double datosPorTeclado(double rnd, int distrSelecc, double min, double max, double media, double desv, double n)
        {
            switch (distrSelecc)
            {
                case 0:
                    rnd = Distribucion.Distribuciones.generarUniforme(min, max, rnd);
                    break;
                case 1:
                    //v = Distribucion.Distribuciones.generarNormal(n, media, desv);
                    break;
                case 2:
                    rnd = Distribucion.Distribuciones.generarExponencial(media, rnd);
                    break;
            }
            return rnd;
        }

        public double generarRandom(double semilla, double a, double c, double m)
        {
            double x;
            x = ((semilla * a + c) % m);         
            return x;
        }

        //obtenemos el tiempo de cada camino y el camino más largo
        public double[] tiempoCamino(double[] v)
        {
            double c1, c2, c3;
            c1 = v[1] + v[4] + v[5];
            c2 = v[2] + v[5];
            c3 = v[3];
            v[6] = c1;
            v[7] = c2;
            v[8] = c3;
            if (c1 > c2 && c1 > c3)
            {
                v[9] = v[6];
            }
            else
            {
                if (c2 > c3)
                {
                    v[9] = v[7];
                }
                else
                {
                    v[9] = v[8];
                }
            }                    
            return v;
        }

        public void durPromedio(double[] vactual, int i)
        {
            contDuracion += vactual[9];
            promDuracion = Math.Round(contDuracion / i, 3);
            vactual[10] = promDuracion;
        }

        public void identMaxMin(double[] vActual, double[] vAnterior)
        {
            // nos fijamos si es la 1ra iteracion para poner los maximos y mínimos
            if (primerSimulacion)
            {
                //vecActual[9] es la duración más larga de los caminos
                primerSimulacion = false;
                this.vecActual[11] = this.vecActual[9];//vec10 es la Dmín
                this.vecActual[12] = this.vecActual[9];//vec11 es la Dmax
            }
            else
            {
                if (this.vecActual[9] < this.vecAnterior[11])
                {
                    this.vecActual[11] = this.vecActual[9];
                }
                else { this.vecActual[11] = this.vecAnterior[11]; }
                if (this.vecActual[9] > this.vecAnterior[12])
                {
                    this.vecActual[12] = this.vecActual[9];
                }
                else { this.vecActual[12] = this.vecAnterior[12]; }
            }
        }

        public void probOcurrencia45Dias(double[] v, int n)
        {
            if (v[9] <= 45)
            {
                v[13] += 1; 
            }
            v[14] = Math.Round(v[13] / n, 3);
        }

        public void desviacion(double[] v, int n)
        {
            double a = (v[9] - v[10]) * (v[9] - v[10]);
            v[15] += a;

            v[16] = Math.Round(Math.Sqrt(v[15] / n),3);
        }

        public void prob90(double[] v, int n)
        {
            double ts = MathNet.Numerics.ExcelFunctions.TInv(0.90, n-1);
            double res = Math.Round(v[10] + ts * v[16], 3);
            v[17] = res;

        }

        public void armarIntervalos(double[] vact, double[] vInt, int i, int posicion, Boolean ordenado)
        {           
            if (i < 15)
            {
                vInt[i - 1] = vact[9];
                vact[posicion] = vInt[i-1];
            }
            else
            {                
                if (!ordenado)
                {
                    posicion = 18;
                    vInt[14] = 9999;
                    Array.Sort(vInt);
                    for (int j=0; j<15;j++)
                    {
                        vact[posicion] = vInt[j];
                        posicion +=1;
                    }
                    ordenado = true;                 
                }
                // i está valiendo 33

            }                      
        }

        public void calcularProb(double[] vAct, int i)
        {
            if (vAct[9] <= vAct[18]) 
            { 
                acumInt1 += 1;                
            }
            else if (vAct[9] <= vAct[19])
            {
                acumInt2 += 1;                
            }
            else if (vAct[9] <= vAct[20])
            {
                acumInt3 += 1;                
            }
            else if (vAct[9] <= vAct[21])
            {
                acumInt4 += 1;                
            }
            else if (vAct[9] <= vAct[22])
            {
                acumInt5 += 1;               
            }
            else if (vAct[9] <= vAct[23])
            {
                acumInt6 += 1;                
            }
            else if (vAct[9] <= vAct[24])
            {
                acumInt7 += 1;               
            }
            else if (vAct[9] <= vAct[25])
            {
                acumInt8 += 1;               
            }
            else if (vAct[9] <= vAct[26])
            {
                acumInt9 += 1;               
            }
            else if (vAct[9] <= vAct[27])
            {
                acumInt10 += 1;                
            }
            else if (vAct[9] <= vAct[28])
            {
                acumInt11 += 1;             
            }
            else if (vAct[9] <= vAct[29])
            {
                acumInt12 += 1;               
            }
            else if (vAct[9] <= vAct[30])
            {
                acumInt13 += 1;              
            }
            else if (vAct[9] <= vAct[31])
            {
                acumInt14 += 1;                
            }
            else
            {
                acumInt15 += 1;               
            }
            vAct[33] = Math.Round(acumInt1 / i, 4);
            vAct[34] = Math.Round(acumInt2 / i, 4);
            vAct[35] = Math.Round(acumInt3 / i, 4);
            vAct[36] = Math.Round(acumInt4 / i, 4);
            vAct[37] = Math.Round(acumInt5 / i, 4);
            vAct[38] = Math.Round(acumInt6 / i, 4);
            vAct[39] = Math.Round(acumInt7 / i, 4);
            vAct[40] = Math.Round(acumInt8 / i, 4);
            vAct[41] = Math.Round(acumInt9 / i, 4);
            vAct[42] = Math.Round(acumInt10 / i, 4);
            vAct[43] = Math.Round(acumInt11 / i, 4);
            vAct[44] = Math.Round(acumInt12 / i, 4);
            vAct[45] = Math.Round(acumInt13 / i, 4);
            vAct[46] = Math.Round(acumInt14 / i, 4);
            vAct[47] = Math.Round(acumInt15 / i, 4);
        }

        public void acumPorc(double[] vAct, int i)
        {
            if (vAct[9] <= vAct[18]) { acumPor1 += 1; }
            if (vAct[9] <= vAct[19]) { acumPor2 += 1; }
            if (vAct[9] <= vAct[20]) { acumPor3 += 1; }
            if (vAct[9] <= vAct[21]) { acumPor4 += 1; }
            if (vAct[9] <= vAct[22]) { acumPor5 += 1; }
            if (vAct[9] <= vAct[23]) { acumPor6 += 1; }
            if (vAct[9] <= vAct[24]) { acumPor7 += 1; }
            if (vAct[9] <= vAct[25]) { acumPor8 += 1; }
            if (vAct[9] <= vAct[26]) { acumPor9 += 1; }
            if (vAct[9] <= vAct[27]) { acumPor10 += 1; }
            if (vAct[9] <= vAct[28]) { acumPor11 += 1; }
            if (vAct[9] <= vAct[29]) { acumPor12 += 1; }
            if (vAct[9] <= vAct[30]) { acumPor13 += 1; }
            if (vAct[9] <= vAct[31]) { acumPor14 += 1; }
            acumPor15 += 1;
            vAct[48] = Math.Round((acumPor1 / i) * 100, 2);
            vAct[49] = Math.Round((acumPor2 / i) * 100, 2);
            vAct[50] = Math.Round((acumPor3 / i) * 100, 2);
            vAct[51] = Math.Round((acumPor4 / i) * 100, 2);
            vAct[52] = Math.Round((acumPor5 / i) * 100, 2);
            vAct[53] = Math.Round((acumPor6 / i) * 100, 2);
            vAct[54] = Math.Round((acumPor7 / i) * 100, 2);
            vAct[55] = Math.Round((acumPor8 / i) * 100, 2);
            vAct[56] = Math.Round((acumPor9 / i) * 100, 2);
            vAct[57] = Math.Round((acumPor10 / i) * 100, 2);
            vAct[58] = Math.Round((acumPor11 / i) * 100, 2);
            vAct[59] = Math.Round((acumPor12 / i) * 100, 2);
            vAct[60] = Math.Round((acumPor13 / i) * 100, 2);
            vAct[61] = Math.Round((acumPor14 / i) * 100, 2);
            vAct[62] = Math.Round((acumPor15 / i) * 100, 2);

        }

            public void agregarDatosTabla(double[] v, int i)
        {
            //Agregando los datos a la tabla
            
            DataRow dr = dt.NewRow();
            dr["Nro"] = i;
            dr["A1"] = v[1];
            dr["A2"] = v[2];
            dr["A3"] = v[3];
            dr["A4"] = v[4];
            dr["A5"] = v[5];
            dr["Camino 1"] = v[6];
            dr["Camino 2"] = v[7];
            dr["Camino 3"] = v[8];
            dr["Duración"] = v[9];
            dr["Promedio"] = v[10];
            dr["D Min"] = v[11];
            dr["D Max"] = v[12];
            dr["Prob Ocurrencia"] = v[14];
            dr["Desv"] = v[16];
            dr["Fec90"] = v[17];
            dr["Int 1"] = v[18];
            dr["Int 2"] = v[19];
            dr["Int 3"] = v[20];
            dr["Int 4"] = v[21];
            dr["Int 5"] = v[22];
            dr["Int 6"] = v[23];
            dr["Int 7"] = v[24];
            dr["Int 8"] = v[25];
            dr["Int 9"] = v[26];
            dr["Int 10"] = v[27];
            dr["Int 11"] = v[28];
            dr["Int 12"] = v[29];
            dr["Int 13"] = v[30];
            dr["Int 14"] = v[31];
            dr["Int 15"] = v[32];
            dr["P. Int 1"] = v[33];
            dr["P. Int 2"] = v[34];
            dr["P. Int 3"] = v[35];
            dr["P. Int 4"] = v[36];
            dr["P. Int 5"] = v[37];
            dr["P. Int 6"] = v[38];
            dr["P. Int 7"] = v[39];
            dr["P. Int 8"] = v[40];
            dr["P. Int 9"] = v[41];
            dr["P. Int 10"] = v[42];
            dr["P. Int 11"] = v[43];
            dr["P. Int 12"] = v[44];
            dr["P. Int 13"] = v[45];
            dr["P. Int 14"] = v[46];
            dr["P. Int 15"] = v[47];
            dr["Int 1 %"] = v[48];
            dr["Int 2 %"] = v[49];
            dr["Int 3 %"] = v[50];
            dr["Int 4 %"] = v[51];
            dr["Int 5 %"] = v[52];
            dr["Int 6 %"] = v[53];
            dr["Int 7 %"] = v[54];
            dr["Int 8 %"] = v[55];
            dr["Int 9 %"] = v[56];
            dr["Int 10 %"] = v[57];
            dr["Int 11 %"] = v[58];
            dr["Int 12 %"] = v[59];
            dr["Int 13 %"] = v[60];
            dr["Int 14 %"] = v[61];
            dr["Int 15 %"] = v[62];
            dt.Rows.Add(dr);
            dgvFrec.DataSource = dt;
        }
        
    }
}
