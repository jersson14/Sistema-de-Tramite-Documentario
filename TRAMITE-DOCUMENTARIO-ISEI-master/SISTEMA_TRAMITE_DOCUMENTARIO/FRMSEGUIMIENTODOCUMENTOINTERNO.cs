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
    public partial class FRMSEGUIMIENTODOCUMENTOINTERNO : Form
    {
        //DateTimePickerFormat fecha = DateTimePickerFormat.Long;
        DateTime fecha = DateTime.UtcNow;
        public FRMSEGUIMIENTODOCUMENTOINTERNO()
        {
            InitializeComponent();
        }


        Validacion validacion = new Validacion();
        private void detalle_documento_internoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.detalledocumentointernoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
           // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.detalle_documento_interno' Puede moverla o quitarla según sea necesario.
            this.detalle_documento_internoTableAdapter.Fill(this.dataSetTramite.detalle_documento_interno);

        }

       
        public void agrandarcolumnas()
        {

            detalle_documento_internoDataGridView.Columns[0].Width = 180;
            detalle_documento_internoDataGridView.Columns[1].Width = 180;
            detalle_documento_internoDataGridView.Columns[2].Width = 180;
            detalle_documento_internoDataGridView.Columns[3].Width = 280;
            detalle_documento_internoDataGridView.Columns[4].Width = 150;
            detalle_documento_internoDataGridView.Columns[5].Width = 280;
            detalle_documento_internoDataGridView.Columns[6].Width = 130;
            detalle_documento_internoDataGridView.Columns[7].Width = 350;

        }
        private void FRMSEGUIMIENTODOCUMENTOINTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.detalle_documento_interno' Puede moverla o quitarla según sea necesario.
            this.detalle_documento_internoTableAdapter.Fill(this.dataSetTramite.detalle_documento_interno);
            BTNGUARDAR.Tag = "Guardar";
            cargardatos();
            botones_desactivados();
            BTNNUEVO.Enabled = true;
            BTNEDITAR.Enabled = true;
            BTNCANCELAR.Enabled = false;
            BTNELIMINAR.Enabled = true;
            BTNGUARDAR.Enabled = false;

            agrandarcolumnas();
        }
        public void botones_activos()
        {
            numero_respuesta_intTextBox.Enabled = false;
            numero_correlativoTextBox.Enabled = true;
            derivar_areaComboBox.Enabled = true;
            fecha_salidaDateTimePicker.Enabled = true;
            descripcionTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            observacionTextBox.Enabled = true;
            asunto_documentoTextBox.Enabled = true;
            button1.Enabled = true;
           
        }
        public void botones_desactivados()
        {
            numero_respuesta_intTextBox.Enabled = false;
            numero_correlativoTextBox.Enabled = false;
            derivar_areaComboBox.Enabled = false;
            fecha_salidaDateTimePicker.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            observacionTextBox.Enabled = false;
            asunto_documentoTextBox.Enabled = false;
            button1.Enabled = false;

        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            detalledocumentointernoBindingSource.AddNew();
            BTNGUARDAR.Tag = "GuardarI";
            botones_activos();
            numero_correlativoTextBox.Focus();
            fecha_salidaDateTimePicker.Text = fecha.ToString();
            numero_correlativoTextBox.Focus();
            BTNNUEVO.Enabled = false;
            BTNEDITAR.Enabled = false;
            BTNCANCELAR.Enabled = true;
            BTNELIMINAR.Enabled = false;
            BTNGUARDAR.Enabled = true;
        }

        private void BTNEDITAR_Click(object sender, EventArgs e)
        {
            botones_activos();
            BTNNUEVO.Enabled = false;
            BTNEDITAR.Enabled = false;
            BTNCANCELAR.Enabled = true;
            BTNELIMINAR.Enabled = false;
            BTNGUARDAR.Enabled = true;

            BTNGUARDAR.Tag = "GuardarE";
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            botones_desactivados();

            BTNNUEVO.Enabled = true;
            BTNEDITAR.Enabled = true;
            BTNCANCELAR.Enabled = false;
            BTNELIMINAR.Enabled = true;
            BTNGUARDAR.Enabled = false;
            cargardatos();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (BTNGUARDAR.Tag == "GuardarI")
            {
                if (MessageBox.Show("¿Desea guardar?", "Guardar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
                {
                    try
                    {
                        this.Validate();
                        this.detalledocumentointernoBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.dataSetTramite);

                        BTNNUEVO.Enabled = true;
                        BTNEDITAR.Enabled = true;
                        BTNCANCELAR.Enabled = false;
                        BTNELIMINAR.Enabled = true;
                        BTNGUARDAR.Enabled = false;

                        MessageBox.Show("Documento Guardado");

                        botones_desactivados();
                        cargardatos();
                    }


                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }

                }
            
            }
            else if (BTNGUARDAR.Tag == "GuardarE")
            {
                try
                {
                    this.Validate();
                    this.detalledocumentointernoBindingSource.EndEdit();
                    detalle_documento_internoTableAdapter.Update(this.dataSetTramite);

                    BTNNUEVO.Enabled = true;
                    BTNEDITAR.Enabled = true;
                    BTNCANCELAR.Enabled = false;
                    BTNELIMINAR.Enabled = true;
                    BTNGUARDAR.Enabled = false;

                    MessageBox.Show("desea editar el documento", "Editar documento", MessageBoxButtons.OKCancel);

                    botones_desactivados();
                    cargardatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar?", "Eliminar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
                try
                {
                    detalledocumentointernoBindingSource.RemoveCurrent();
                    this.Validate();
                    detalledocumentointernoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSetTramite);
                    MessageBox.Show("Registro Eliminado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void FRMSEGUIMIENTODOCUMENTOINTERNO_Activated(object sender, EventArgs e)
        {
            numero_correlativoTextBox.Text = FRMBUSCARDOCINTERNO.NumeroDoc;
            asunto_documentoTextBox.Text = FRMBUSCARDOCINTERNO.NombreAsunto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMBUSCARDOCINTERNO buscar = new FRMBUSCARDOCINTERNO();
            buscar.Show();
        }

        private void detalle_documento_internoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fecha_salidaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.cbbuscar.Text == "ASUNTO")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.detalle_documento_internoTableAdapter.asunto(this.dataSetTramite.detalle_documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "FECHA")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.detalle_documento_internoTableAdapter.fecha(this.dataSetTramite.detalle_documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "AREA")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.detalle_documento_internoTableAdapter.area(this.dataSetTramite.detalle_documento_interno, txtbuscar.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.detalle_documento_internoTableAdapter.Fill(this.dataSetTramite.detalle_documento_interno);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numero_correlativoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void asunto_documentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void estadoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}
