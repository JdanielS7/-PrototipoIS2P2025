using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_RRHH
{
    public partial class Mant_Vendedores : Form
    {
        public Mant_Vendedores()
        {
            InitializeComponent();

            string idUsuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "ID Vendedor", "Nombre", "Dirección", "Telefono","NIT", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(ColorTranslator.FromHtml("#B4D2F0"));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("20001");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idUsuario);
            navegador1.AsignarTabla("vendedores");

            navegador1.AsignarNombreForm("VENDEDORES");
        }
    }
}
