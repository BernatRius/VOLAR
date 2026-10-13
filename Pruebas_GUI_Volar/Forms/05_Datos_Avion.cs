using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_GUI_Volar
{
    public partial class _05_Datos_Avion : Form
    {
        public _05_Datos_Avion(string id, string vel, string px, string py)
        {
            InitializeComponent();
            ID_DA.Text = id;
            Vel_DA.Text = vel;
            PosX_DA.Text = px;
            PosY_DA.Text = py;
        }
    }
}
