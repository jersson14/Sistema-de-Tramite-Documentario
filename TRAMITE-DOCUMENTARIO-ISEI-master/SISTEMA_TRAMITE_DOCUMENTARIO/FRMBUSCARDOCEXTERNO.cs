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
    public partial class FRMBUSCARDOCEXTERNO : Form
    {
        public FRMBUSCARDOCEXTERNO()
        {
            InitializeComponent();
        }
        public static string NumeroDoc, NombreAsunto;
       
        private void documento_externoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentoexternoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void ocultarcolumnas()
        {
            documento_externoDataGridView.Columns[8].Visible = false;
        }
        private void agrandarcolumnas()
        {
            documento_externoDataGridView.Columns[0].Width = 150;
            documento_externoDataGridView.Columns[1].Width = 150;
            documento_externoDataGridView.Columns[2].Width = 290;
            documento_externoDataGridView.Columns[3].Width = 125;
            documento_externoDataGridView.Columns[4].Width = 125;
            documento_externoDataGridView.Columns[5].Width = 200;
            documento_externoDataGridView.Columns[6].Width = 130;
            documento_externoDataGridView.Columns[7].Width = 350;
            documento_externoDataGridView.Columns[8].Width = 120;
            documento_externoDataGridView.Columns[9].Width = 280;
            documento_externoDataGridView.Columns[10].Width = 130;
            documento_externoDataGridView.Columns[11].Width = 120;
            documento_externoDataGridView.Columns[12].Width = 350;
            documento_externoDataGridView.Columns[13].Width = 220;
        }

        private void FRMBUSCARDOCEXTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_externo' Puede moverla o quitarla según sea necesario.
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);
            ocultarcolumnas();
            agrandarcolumnas();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numerodoc, nombreasunto;
            try
            {

                numerodoc = documento_externoDataGridView[1, documento_externoDataGridView.CurrentCell.RowIndex].Value.ToString();
                nombreasunto = documento_externoDataGridView[6, documento_externoDataGridView.CurrentCell.RowIndex].Value.ToString();

                NumeroDoc=numerodoc;
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
            this.documento_externoTableAdapter.buscarpornombredniMP(this.dataSetTramite.documento_externo, txtbuscar.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.cbbuscar.Text == "NOMBRE TRAMITANTE")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarpornombre(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "DNI")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarpordni(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "CODIGO MP")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarMP(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);
        }
    }
}
