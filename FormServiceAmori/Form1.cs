using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormServiceAmori
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicioAmori.TipoCambio servicio = new ServicioAmori.TipoCambio();

            var respuesta = servicio.TipoCambioDia();


            txt_Fecha.Text = respuesta.CambioDolar.First().fecha;
            txt_Referencia.Text = (respuesta.CambioDolar.First().referencia).ToString();
        }
    }
}
