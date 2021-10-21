using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probandoTp4
{
    public partial class TP4 : Form
    {
        enum tipo_distribucion { Uniforme, Normal, Exponencial };
        int distribucion_seleccionadaA1, distribucion_seleccionadaA2, distribucion_seleccionadaA3, distribucion_seleccionadaA4, distribucion_seleccionadaA5;
        double[] vecActual, vecAnterior;
        double minA1, minA2, minA3, mediaA3, minA4, minA5, maxA1, maxA2, maxA3, maxA4, maxA5, mediaA5, semilla, cteA, cteC, cteM;
        double medA1, medA2, medA3, medA4, medA5, desvA1, desvA2, desvA3, desvA4, desvA5;
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
            vecActual = new double [15];
            vecAnterior = new double[15];
            seleccionDatos();
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
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvFrec.DataSource = null;
            dgvFrec.Rows.Clear();
            dgvFrec.Refresh();
            vecActual = new double[15];
            vecAnterior = new double[15];

            
            //le damos los valores por defecto o los ingresados por teclado
            this.seleccionDatos();

            if (ValidarDatos())
            {
                dgvFrec.DataSource = null;
                dgvFrec.Refresh();
                vecActual = new double[15];
                vecAnterior = new double[15];

                double n = Convert.ToDouble(txtNroSimulaciones.Text);


                for (int i = 1; i <= n; i++)
                {
                    vecActual = generarPrimerosValores(vecActual);
                    //obtenemos el tiempo de cada camino y el camino más largo
                    vecActual = tiempoCamino(vecActual);
                    //vecActual[10] = Math.Round((vecActual[9] + vecAnterior[10]) / i ,3);//la duracion promedio
                    durPromedio(vecActual, i);
                    identMaxMin(vecActual, vecAnterior);
                    probOcurrencia45Dias(vecActual, i);


                    //MessageBox.Show("Tamaño del vector: " + vecActual.Length);
                    agregarDatosTabla(vecActual, i);
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

                }
            }
            
            

            

            return v;
        }

        public void seleccionDistribucion(int nroDistr, int i, double minA, double maxA, double medA, double desvA, double[] v)
        {
            int a = 0;
            switch (nroDistr)
            {
                case 0:
                    v[i] = Distribucion.Distribuciones.generarUniforme(minA, maxA, v[i]);
                    break;
                case 1:
                    v[i] = Distribucion.Distribuciones.generarExponencial(medA, v[i]);
                    break;
                case 2:
                    //v[i] = Distribucion.Distribuciones.generarNormal(a ,medA, desvA);
                    break;
            }
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
            dt.Rows.Add(dr);

            dgvFrec.DataSource = dt;
        }
        
    }
}
