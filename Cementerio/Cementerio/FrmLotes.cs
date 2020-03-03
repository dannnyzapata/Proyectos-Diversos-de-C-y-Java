using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cementerio
{
    public partial class FrmLotes : Form
    {
        public FrmLotes()
        {
            InitializeComponent();
        }
        bool actualizar = false;
        private void TxtNomenclatura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Conexion conn = new Conexion();
                conn.conectar();
                int registros = conn.ejecutarQuery("select * from Lotes where Nomenclatura = '" + TxtNomenclatura.Text + "'").Rows.Count;
                if (registros > 0) 
                {
                    DataTable Resultado = conn.ejecutarQuery("select * from Lotes where Nomenclatura = '" + TxtNomenclatura.Text + "'");
                    LblID.Text = "ID:" + Resultado.Rows[0]["ID"].ToString();
                    NudCapacidad.Value = Convert.ToInt32(Resultado.Rows[0]["Capacidad"].ToString());
                    TxtTitular.Text = Resultado.Rows[0]["Titular"].ToString();
                    TxtBeneficiario1.Text = Resultado.Rows[0]["Beneficiario1"].ToString();
                    TxtBeneficiario2.Text = Resultado.Rows[0]["Beneficiario2"].ToString();
                    TxtBeneficiario3.Text = Resultado.Rows[0]["Beneficiario3"].ToString();
                    ChkPagado.Checked = Convert.ToBoolean(Resultado.Rows[0]["Pagado"].ToString());
                    TxtLugar1.Text = Resultado.Rows[0]["Lugar1"].ToString();
                    TxtLugar2.Text = Resultado.Rows[0]["Lugar2"].ToString();
                    TxtLugar3.Text = Resultado.Rows[0]["Lugar3"].ToString();
                    TxtLugar4.Text = Resultado.Rows[0]["Lugar4"].ToString();
                    actualizar = true;
                }
                NudCapacidad.Enabled = true;
                TxtTitular.ReadOnly = false;
                TxtBeneficiario1.ReadOnly = false;
                TxtBeneficiario2.ReadOnly = false;
                TxtBeneficiario3.ReadOnly = false;
                TxtLugar1.ReadOnly = false;
                TxtLugar2.ReadOnly = false;
                TxtLugar3.ReadOnly = false;
                TxtLugar4.ReadOnly = false;
                ChkPagado.Enabled = true;
                BtnGuardar.Enabled = true;
                conn.desconectar(); 
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                Conexion conn = new Conexion();
                conn.conectar();
                conn.ejecutaTransaccion("Update Lotes Set Capacidad=" + NudCapacidad.Value.ToString()
                    + ",Titular='" + TxtTitular.Text + "'"
                    + ",Beneficiario1='" + TxtBeneficiario1.Text + "'"
                    + ",Beneficiario2='" + TxtBeneficiario2.Text + "'"
                    + ",Beneficiario3='" + TxtBeneficiario3.Text + "'"
                    + ",Lugar1='" + TxtLugar1.Text + "'"
                    + ",Lugar2='" + TxtLugar2.Text + "'"
                    + ",Lugar3='" + TxtLugar3.Text + "'"
                    + ",Lugar4='" + TxtLugar4.Text + "'"
                    + ",Pagado='" + ChkPagado.Checked + "'"
                    );
                conn.desconectar();
            }
            NudCapacidad.Enabled = false;
            TxtTitular.ReadOnly = true;
            TxtBeneficiario1.ReadOnly = true;
            TxtBeneficiario2.ReadOnly = true;
            TxtBeneficiario3.ReadOnly = true;
            TxtLugar1.ReadOnly = true;
            TxtLugar2.ReadOnly = true;
            TxtLugar3.ReadOnly = true;
            TxtLugar4.ReadOnly = true;
            ChkPagado.Enabled = false;
            BtnGuardar.Enabled = false;

            TxtBeneficiario1.Clear();
            TxtBeneficiario2.Clear();
            TxtBeneficiario3.Clear();
            TxtLugar1.Clear();
            TxtLugar2.Clear();
            TxtLugar3.Clear();
            TxtLugar4.Clear();
            ChkPagado.Checked = false;
            TxtTitular.Clear();
            NudCapacidad.Value = 1;
        }
    }
}
