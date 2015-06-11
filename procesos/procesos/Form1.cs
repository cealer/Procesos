using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Llenar el combobox Proceso
            cboProceso.Items.Add("A");
            cboProceso.Items.Add("B");
            cboProceso.Items.Add("C");
            cboProceso.Items.Add("D");
            cboProceso.Items.Add("E");
            cboProceso.Items.Add("F");
            cboProceso.Items.Add("G");
            cboProceso.Items.Add("H");
            //LLenar el combobox Tiempo
            for (int i = 1; i < 9; i++)
            {
                //Agregar T de pagina al combo box
                cboPagina.Items.Add(i.ToString());
                //Iniciando Filas para los procesos
                dgvProceso.Rows.Add("0");
            }
        }
        //Contandor usado para colorear
        int c = 0;
        int usados = 0;
        //Variable para Espera Procesos
        static int esperaTiempo;
        static string esperaProceso;

        //Boton Inicar Procesos
        //t de pagina
       static int tpagEspera = 0;
        //Contar cuantos procesos han entrado
      static  int cProcesos = 0;
        //Contar cuantos procesos falta ingresar a la pila
       static int cProcesosPendiente =0;

        //Contar bloques disponibles (Boton Ejecutar)
       static int cBloques;

        //Contar Bloques 
        static int cBloqueEjecucion;

        void Ejecucion(int tpro, string op)
        {

            //Se reinicia el contador
            c = 0;
            //COndicion para trabajar solo con 8 procesos
            if (usados <= 8)
            {
                //Usuados lo voy sumando con t Pagina
                usados += tpro;
                if (usados <= 8)
                {
                    //Se agrega el proceso al listbox teniendo en cuenta que escogió en el combobox
                    lblEjecucion.Items.Add(cboProceso.SelectedItem.ToString());
                    //Se agrega como un proceso a terminar
                    cboTermino.Items.Add(cboProceso.SelectedItem.ToString());
                }
                else
                {
                    //Contar Cuantos bloques diponibles hay
                    foreach (DataGridViewRow row in dgvProceso.Rows)
                    {
                        if (row.Cells[0].Value.Equals(cboProceso.SelectedItem.ToString()))
                        {
                            cBloques++;
                        }
                    }
                    usados -= tpro;
                    esperaTiempo = Convert.ToInt32(cboPagina.SelectedItem.ToString());
                    esperaProceso = cboProceso.SelectedItem.ToString();
                    lblEspera.Items.Add(cboProceso.SelectedItem.ToString());
                    

                    //Contar Cuantos bloques
                    foreach (DataGridViewRow row in dgvProceso.Rows)
                    {
                        if (row.Cells[0].Value.Equals(cboProceso.SelectedItem.ToString()))
                        {
                            cBloqueEjecucion++;
                        }
                    }
                    if (cBloqueEjecucion.Equals(8))
                    {
                        lblEjecucion.Items.Add(cboProceso.SelectedItem.ToString());
                    }
                    if (cProcesosPendiente > 0)
                    {
                        lblEjecucion.Items.Add(cboProceso.SelectedItem.ToString());
                    }
                    MessageBox.Show("Lleno");
                }
           
            }

            #region Proceso para colorear
            for (int i = 0; i < 8; i++)
            {
                if (usados <= 8)
                {
                    if (dgvProceso.Rows[i].Cells[0].Value.Equals("0") && c < tpro)
                    {
                        switch (op)
                        {
                            case "A":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                                dgvProceso.Rows[i].Cells[0].Value = "A";
                                break;
                            case "B":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                                dgvProceso.Rows[i].Cells[0].Value = "B";
                                break;
                            case "C":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                                dgvProceso.Rows[i].Cells[0].Value = "C";
                                break;
                            case "D":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Violet;
                                dgvProceso.Rows[i].Cells[0].Value = "D";
                                break;
                            case "E":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.SkyBlue;
                                dgvProceso.Rows[i].Cells[0].Value = "E";
                                break;
                            case "F":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Tan;
                                dgvProceso.Rows[i].Cells[0].Value = "F";
                                break;
                            case "G":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                                dgvProceso.Rows[i].Cells[0].Value = "G";
                                break;
                            case "H":
                                dgvProceso.Rows[i].DefaultCellStyle.BackColor = Color.Gold;
                                dgvProceso.Rows[i].Cells[0].Value = "H";
                                break;
                            default:
                                break;
                        }
                        c++;
                    }
                }
            }
            #endregion
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //Asignamos el proceso
            string op = cboProceso.SelectedItem.ToString();
            //Asignamos su T de página
            int tpro = Convert.ToInt32(cboPagina.SelectedItem.ToString());
            //Metodo para Ejecutar el proceso
            Ejecucion(tpro, op);
        }
        //Incrementador
        int borrar = 0;

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            borrar = 0;
            foreach (DataGridViewRow row in dgvProceso.Rows)
            {
                if (row.Cells[0].Value.Equals(cboTermino.SelectedItem.ToString()))
                {
                    row.Cells[0].Value = "0";
                    row.DefaultCellStyle.BackColor = Color.White;
                    borrar++;
                }
            }
            MessageBox.Show(borrar.ToString());
            usados = usados - borrar;
            MessageBox.Show(usados.ToString());
            // 
            //MessageBox.Show(borrar.ToString());
            //MessageBox.Show(usados.ToString());
        }



        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            //Contar Cuantos bloques diponibles hay
            foreach (DataGridViewRow row in dgvProceso.Rows)
            {
                if (row.Cells[0].Value.Equals(cboProceso.SelectedItem.ToString()))
                {
                    cBloques++;
                }
            }
            if (!cboPagina.SelectedItem.Equals(cBloques))
            {
                //Si tiene los bloques diponibles completos
                lblEspera.Items.RemoveAt(0);
                //Obtener t de pagina para Espera 
                tpagEspera = Convert.ToInt32(cboPagina.Text);

                foreach (DataGridViewRow row in dgvProceso.Rows)
                {
                    if (row.Cells[0].Value.Equals(cboProceso.SelectedItem.ToString()))
                    {
                        cProcesos++;
                    }
                }
                cProcesosPendiente = tpagEspera - cProcesos;
                Ejecucion(cProcesosPendiente, esperaProceso);
                //Ejecucion(esperaTiempo, esperaProceso);
                MessageBox.Show("Condicion");
            }
     
        }

        private void cboProceso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTermino_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Obtener t de pagina para Espera 
            tpagEspera = Convert.ToInt32(cboPagina.Text);

            foreach (DataGridViewRow row in dgvProceso.Rows)
            {
                if (row.Cells[0].Value.Equals(cboProceso.SelectedItem.ToString()))
                {
                    cProcesos++;
                }
            }
            cProcesosPendiente = tpagEspera - cProcesos;
            MessageBox.Show("T pagina: " + tpagEspera.ToString());
            MessageBox.Show("Procesos ingresados: " + cProcesos.ToString());
            MessageBox.Show("Procesos pendientes: " + cProcesosPendiente.ToString());
                   
        }
    }
}
