using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoritmoDelBanquero
{
    public partial class Form1 : Form
    {
        private int[,] necesarios;
        private int[,] asignados;
        private int[,] maximos;
        private int[,] disponibles;
        private int numeroProcesos;
        private int numeroRecursos;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrearArray_Click(object sender, EventArgs e)
        {
            numeroRecursos = Convert.ToInt32(txtNoRecursos.Text);
            numeroProcesos = Convert.ToInt32(txtNoProcesos.Text);

            for (int i = 0; i < numeroRecursos; i++)
            {
                dgvAsignados.Columns.Add("" + i, "" + i);
                dgvMaximos.Columns.Add("" + i, "" + i);
                dgvDisponibles.Columns.Add("" + i, "" + i);
            }

            for (int i = 0; i < numeroProcesos; i++)
            {
                dgvAsignados.Rows.Add("");
                dgvMaximos.Rows.Add("");
            }

            for (int i = 0; i < 1; i++)
            {
                dgvDisponibles.Rows.Add("");
            }
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            asignados = new int[dgvAsignados.Rows.Count, dgvAsignados.Columns.Count];

            foreach (DataGridViewRow row in dgvAsignados.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        asignados[cel.RowIndex, cel.ColumnIndex] = Convert.ToInt32(cel.Value);
                    }
                }
            }

            maximos = new int[dgvMaximos.Rows.Count, dgvMaximos.Columns.Count];

            foreach (DataGridViewRow row in dgvMaximos.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        maximos[cel.RowIndex, cel.ColumnIndex] = Convert.ToInt32(cel.Value);
                    }
                }
            }

            disponibles = new int[dgvDisponibles.Rows.Count, dgvDisponibles.Columns.Count];

            foreach (DataGridViewRow row in dgvDisponibles.Rows)
            {
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cel in row.Cells)
                    {
                        //disponibles[cel.RowIndex, cel.ColumnIndex] = Convert.ToInt32(cel.Value);
                        disponibles[0, cel.ColumnIndex] = Convert.ToInt32(cel.Value);
                    }
                }
            }
            necesarios = new int[numeroProcesos, numeroRecursos];
            calculoNecesarios();

            Boolean[] done = new Boolean[numeroProcesos];
            int j = 0;

            while (j < numeroProcesos)
            {  //hasta que todos los procesos se asignen
                Boolean asignado = false;
                for (int i = 0; i < numeroProcesos; i++)
                {
                    if (!done[i] && chequear(i))
                    {  //intentando asignar
                        for (int k = 0; k < numeroRecursos; k++)
                        {
                            disponibles[0, k] = disponibles[0, k] - necesarios[i, k] + maximos[i, k];
                        }
                        MessageBox.Show("Proceso asignado : " + i);
                        //Console.WriteLine("Proceso asignado : " + i);
                        asignado = done[i] = true;
                        j++;
                    }
                }
                if (!asignado)
                {
                    break;  //si no esta asignado
                }
            }
            if (j == numeroProcesos) //si todos los procesos estan asignados
            {
                MessageBox.Show("\nAsignado de forma segura");
                //Console.WriteLine("\nAsignado de forma segura");
            }
            else
            {
                MessageBox.Show("Todos los procesos se pueden asignar de forma segura");
                //Console.WriteLine("Todos los procesos se pueden asignar de forma segura");
            }
        }


        private int[,] calculoNecesarios()
        {
            for (int i = 0; i < numeroProcesos; i++)
            {
                for (int j = 0; j < numeroRecursos; j++) //calculando matriz de necesarios
                {
                    necesarios[i, j] = maximos[i, j] - asignados[i, j];
                }
            }

            return necesarios;
        }

        private Boolean chequear(int i)
        {
            //chequeando si todos los recursos para el proceso pueden ser asignados
            for (int j = 0; j < numeroRecursos; j++)
            {
                if (disponibles[0, j] < necesarios[i, j])
                {
                    return false;
                }
            }

            return true;
        }


    }
}
