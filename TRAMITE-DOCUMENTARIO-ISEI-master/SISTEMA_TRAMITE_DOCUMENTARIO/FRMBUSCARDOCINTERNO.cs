using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    public partial class FRMBUSCARDOCINTERNO : Form
    {
        public FRMBUSCARDOCINTERNO()
        {
            InitializeComponent();
        }
        public static string NumeroDoc,NombreAsunto;
       
        private void documento_internoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentointernoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void ocultarcolumnas()
        {
            dgvbuscardocinterno.Columns[8].Visible = false;
        }
        private void agrandarcolumnas()
        {
            dgvbuscardocinterno.Columns[0].Width = 150;
            dgvbuscardocinterno.Columns[1].Width = 150;
            dgvbuscardocinterno.Columns[2].Width = 290;
            dgvbuscardocinterno.Columns[3].Width = 125;
            dgvbuscardocinterno.Columns[4].Width = 125;
            dgvbuscardocinterno.Columns[5].Width = 200;
            dgvbuscardocinterno.Columns[6].Width = 130;
            dgvbuscardocinterno.Columns[7].Width = 350;
            dgvbuscardocinterno.Columns[8].Width = 120;
            dgvbuscardocinterno.Columns[9].Width = 280;
            dgvbuscardocinterno.Columns[10].Width = 130;
            dgvbuscardocinterno.Columns[11].Width = 120;
            dgvbuscardocinterno.Columns[12].Width = 350;
            dgvbuscardocinterno.Columns[13].Width = 220;
        }
        private void FRMBUSCARDOCINTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
            this.documento_internoTableAdapter.Fill(this.dataSetTramite.documento_interno);
            agrandarcolumnas();
            ocultarcolumnas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numerodoc,nombreasunto;
            try
            {
                numerodoc = dgvbuscardocinterno[0, dgvbuscardocinterno.CurrentCell.RowIndex].Value.ToString();
                nombreasunto = dgvbuscardocinterno[2, dgvbuscardocinterno.CurrentCell.RowIndex].Value.ToString();

                NumeroDoc = numerodoc;
                NombreAsunto = nombreasunto;
                Close();
            }
            catch
            {
                MessageBox.Show("No hay registros de documentos");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            this.documento_internoTableAdapter.buscarporMPnombredni(this.dataSetTramite.documento_interno, txtbuscar.Text);
        }

        private void dgvbuscardocinterno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.cbbuscar.Text == "NOMBRE TRAMITANTE")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarnombretramitante(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "DNI")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarpordni(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "AREA")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarporarea(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "CODIGO MP")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarporcodigoMP(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documento_internoTableAdapter.Fill(this.dataSetTramite.documento_interno);
        }
    }
}
