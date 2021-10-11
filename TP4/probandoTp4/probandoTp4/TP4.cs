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
        double minA1, minA2, minA3, minA4, minA5, maxA1, maxA2, maxA3, maxA4, maxA5, semilla, cteA, cteC, cteM;
        Boolean primerSimulacion = true;
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
        private void cmbA1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbA1.SelectedIndex == 2)
            {
                lblA1.Text = "Media";
            }
        }

        private void cmbA2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbA1.SelectedIndex == 2)
            {
                lblA2.Text = "Media";
            }
        }

        private void cmbA3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbA1.SelectedIndex == 2)
            {
                lblA3.Text = "Media";
            }
        }

        private void cmbA4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbA1.SelectedIndex == 2)
            {
                lblA4.Text = "Media";
            }
        }

        private void cmbA5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbA1.SelectedIndex == 2)
            {
                lblA5.Text = "Media";
            }
        }

        public void seleccionDatos()
        {
            if (int.Parse(txtNroSimulaciones.Text) <= 0 || txtNroSimulaciones.Text == "") 
            {
                MessageBox.Show("Debe ingresar un nunmero de simulaciones válidos!");
            }

            if (rbPorDefecto.Checked)
            {
                minA1 = 20;
                minA2 = 30;
                minA3 = 40;
                minA4 = 10;
                minA5 = 4;
                maxA1 = 30;
                maxA2 = 50;
                maxA3 = 0.115;
                maxA4 = 20;
                maxA5 = 5;
                distribucion_seleccionadaA1 = 0;
                distribucion_seleccionadaA2 = 0;
                distribucion_seleccionadaA3 = 2;
                distribucion_seleccionadaA4 = 0;
                distribucion_seleccionadaA5 = 2;

            }
            else
            {
                if (cmbA1.Text == "" || cmbA2.Text == "" || cmbA3.Text == "" || cmbA4.Text == "" || cmbA5.Text == "")
                {
                    MessageBox.Show("ERROR! Debe seleccionar una opcion de los combos");
                }
                

                if (int.Parse(txtMinA1.Text) <= 0 || txtMinA1.Text == "" || int.Parse(txtMinA2.Text) <= 0 || txtMinA2.Text == ""
                    || int.Parse(txtMinA3.Text) <= 0 || txtMinA3.Text == "" || int.Parse(txtMinA4.Text) <= 0 || txtMinA4.Text == ""
                    || int.Parse(txtMinA5.Text) <= 0 || txtMinA5.Text == "")
				{
                    MessageBox.Show("ERROR! Debe Ingresar valores válidos");
                }

                


            }
        }
        /// fin de las verificaciones

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            dgvFrec.DataSource = null;
            dgvFrec.Refresh();
            vecActual = new double[15];
            vecAnterior = new double[15];


            //le damos los valores por defecto o los ingresados por teclado
            this.seleccionDatos();

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
                
                MessageBox.Show("Valor de x: " + x);
                for (int i = 1; i <= 5; i++)
                {
                    v[i] = rnd;
                }
                
            }
            v[0] = x;
            v[1] = Distribucion.Distribuciones.generarUniforme(minA1, maxA1, v[1]);
            v[2] = Distribucion.Distribuciones.generarUniforme(minA2, maxA2, v[2]);
            v[3] = Distribucion.Distribuciones.generarUniforme(minA3, maxA3, v[3]);
            v[4] = Distribucion.Distribuciones.generarUniforme(minA4, maxA4, v[4]);
            v[5] = Distribucion.Distribuciones.generarUniforme(minA5, maxA5, v[5]);

            return v;
        }

        public double generarRandom(double semilla, double a, double c, double m)
        {
            double x;
            x = ((semilla * a + c) % m);         
            MessageBox.Show("rnd generado: " + x);
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
