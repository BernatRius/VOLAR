using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightLib;

namespace Pruebas_GUI_Volar
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////    Clase para gestionar el menu de Datos de Vuelo   ////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public partial class Datos_de_Vuelo : Form
    {
        //////////////////////////////////////////////////////////////    Atributos   ////////////////////////////////////////////////////////////////////
        int cont;                                                                       //  Definimos un contador 
        Options menu;                                                                   //  Creamos el objeto Options con nombre menu
        MethodChecker checker = new MethodChecker();                                    //  Creamos un objeto MethodChecker
        AvisosBox av;                                                                   //  Creamos el objeto AvisoBox con nombre av
        string id;                                                                      //  Creamos el string ID
        double vel;                                                                     //  Creamos el double velocidad
        double xo;                                                                      //  Creamos el double xo
        double yo;                                                                      //  Creamos el double yo
        double xf;                                                                      //  Creamos el double xf
        double yf;                                                                      //  Creamos el double yf

        //////////////////////////////////////////////////////////////    Constructor   ///////////////////////////////////////////////////////////////////
        public Datos_de_Vuelo(Options menu)                                             //  Constructuro Datos de vuelo
        {                                                                               //
            InitializeComponent();                                                      //  Iniciamos los componentes, esto siempre esta
            cont = 0;                                                                   //  Ponemos el contador a 0
            this.menu = menu;                                                           //  Inicializamos el menu
        }                                                                               
                                                                                        //
        ////////////////////////////////////////////////////////////     Metodos voids  /////////////////////////////////////////////////////////////////////////
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)          //  Objeto para gestionar los menus en arbol
        {                                                                               //
            if (e.Node.Text == "Vuelo A")                                               //  Si tenemos seleccionada la rama Vuelo A
            {                                                                           //
                tituloVuelos.Text = "DATOS VUELO A:";                                   //  El titulo del menu pasa a ser DATOS VUELO A 
                cont = 1;                                                               //  Indicamos el contador vale 1
            }                                                                           //
            else if (e.Node.Text == "Vuelo B")                                          //  Si tenemos seleccionada la rama Vuelo B
            {                                                                           //
                tituloVuelos.Text = "DATOS VUELO B:";                                   //  El titulo del menu pasa a ser DATOS VUELO B
                cont = 2;                                                               //  Indicamos el contador vale 2
            }                                                                           //
            else cont = 0;                                                              //  Sino por si acaso ponemos siempre el contador a 0
        }                                                                               //
        private void saveButton_Click(object sender, EventArgs e)                       //  Objeto para guardar los vuelos
        {                                                                               //
            try                                                                         //  En caso que no haya ningun error de formato
            {                                                                           //
                id = IdBox.Text;                                                        //  La variable ID tiene los datos introducidos en IdBox
                vel = Convert.ToDouble(VelBox.Text);                                    //  La variable vel tiene los datos introducidos en VelBox
                xo = Convert.ToDouble(XoBox.Text);                                      //  La variable xo tiene los datos introducidos en XoBox
                yo = Convert.ToDouble(YoBox.Text);                                      //  La variable yo tiene los datos introducidos en YoBox;
                xf = Convert.ToDouble(XfBox.Text);                                      //  La variable xf tiene los datos introducidos en XfBox;
                yf = Convert.ToDouble(YfBox.Text);                                      //  La variable yf tiene los datos introducidos en YfBox;

                if (checker.check_id(id) != "0")                                        //  Si el checker del Id no devuelve un okey
                {                                                                       //
                    av = new AvisosBox(checker.check_id(id));                           //  Crea la ventana de avisos con los datos del checker
                    av.Show(this);                                                      //  Abre la ventana de avisos
                }                                                                       //
                else if (checker.check_vel(vel) != "0")                                 //  Si el checker de la velocidad no devuelve un okey
                {                                                                       //
                    av = new AvisosBox(checker.check_vel(vel));                         //  Crea la ventana de avisos con los datos del checker;
                    av.Show(this);                                                      //  Abre la ventana de avisos
                }                                                                       //
                else if (checker.check_pos(xo, yo, xf, yf) != "0")                      //  Si el checker de las posiciones no devuelve un okey
                {                                                                       //
                    av = new AvisosBox(checker.check_pos(xo, yo, xf, yf));              //  Crea la ventana de avisos con los datos del checker
                    av.Show(this);                                                      //  Abre la ventana de avisos
                }                                                                       //
                else                                                                    //  Si todo esta en orden
                {                                                                       //  
                    if (cont == 1)                                                      //  Si el contador esta en 1
                    {                                                                   //
                        menu.vueloA = new FlightPlan                                    //  Le damos los datos pertinentes al vueloA
                            (id,                                                        //  Su ID
                            xo,                                                         //  Su Vel
                            yo,                                                         //  Su xo
                            xf,                                                         //  Su yo
                            yf,                                                         //  Su xf
                            vel);                                                       //  Su yf
                        menu.planList.AddFlightPlan(menu.vueloA);
                        av = new AvisosBox("El Vuelo A esta creado!");                  //  Crea la ventana de avisando del vuelo creado
                        av.Show(this);                                                  //  Abre la ventana de avisos
                    }                                                                   //
                    else if (cont == 2)                                                 //  Si el contador esta en 2
                    {                                                                   //
                        menu.vueloB = new FlightPlan                                    //  Le damos los datos pertinentes al vueloA
                            (id,                                                        //  Su ID
                            xo,                                                         //  Su Vel
                            yo,                                                         //  Su xo
                            xf,                                                         //  Su yo
                            yf,                                                         //  Su xf
                            vel);                                                       //  Su yf
                        menu.planList.AddFlightPlan(menu.vueloB);
                        av = new AvisosBox("El Vuelo B esta creado!");                  //  Crea la ventana de avisando del vuelo creado
                        av.Show(this);                                                  //  Abre la ventana de avisos
                    }                                                                   //
                }                                                                       //
            }catch (FormatException)                                                    //  En Caso de error de formato
            {                                                                           //
                av = new AvisosBox(                                                     //  Crea la ventana avisando
                    "No se han introducido los datos con su formato correcto!");        //  Que los datos introducidos no son correctos
                av.Show(this);                                                          //  Muestra esta ventana
            }                                                                           
        }
    }
}
