using FlightLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_GUI_Volar
{
    public partial class _03_Espacio_Aereo : Form
    {
        Options menu;
        FlightPlan plane;
        Image avion_40;
        _05_Datos_Avion da;
        bool conflictoDetectado = false;

        public _03_Espacio_Aereo(Options menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.avion_40 = Properties.Resources.avion_40;

            // Connectem el amb el mètode automàtic.
            simulacionTimer.Tick += SimulacionTimer_Tick;

            // Connectem els botons amb els mètodes.
            IniciarAutoSim.Click += InicarAutoSim_Click;
            DetenerAutoSim.Click += DetenerAutoSim_Click;

            for (int i = 0; i < 10; i++)
            {
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    menu.planList.GetFlightPlan(i).Restart();
                }
            }

            EspAereo.Paint += new PaintEventHandler(EspAereo_Paint);
        }

        private void LoadBut_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    menu.planList.GetFlightPlan(i).Restart();
                }
            }
            EspAereo.Invalidate();
        }

        private void CicloBut_Click(object sender, EventArgs e)
        {
            if (conflictoDetectado) // Si s'ha detectat un conflicte no podem continuar la simulació
                return;
            for (int i = 0; i < 10; i++)
            {
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    menu.planList.GetFlightPlan(i).Mover(menu.tCicl);
                }
            }
            EspAereo.Invalidate();
            ComprovarConflictes();
        }

        // Executa automàticament cada 500 ms.
        private void SimulacionTimer_Tick(object sender, EventArgs e)
        {
            if (conflictoDetectado) // Si s'ha detectat un conflicte, aturem la simulació automàtica
            {
                simulacionTimer.Stop();
                return;
            }
            // Recorrem les 10 posicions possibles de la llista de plans de vol.
            for (int i = 0; i < 10; i++)
            {
                // Comprovem que hi hagi un pla de vol
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    // Movem l'avió segons el temps de cicle establert.
                    menu.planList.GetFlightPlan(i).Mover(menu.tCicl);
                }
            }

            // Actualitzem el dibuix per mostrar les noves posicions dels avions.
            EspAereo.Invalidate();
            ComprovarConflictes();
        }

        //Inicia la simulació automàtica quan premem el botó
        private void InicarAutoSim_Click(object sender, EventArgs e)
        {
            // Posem en marxa el temporitzador.
            simulacionTimer.Start();
        }

        //Atura la simulació automàtica quan premem el botó
        private void DetenerAutoSim_Click(object sender, EventArgs e)
        {
            simulacionTimer.Stop();
        }

        private void EspAereo_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen rojo = new Pen(Color.Red, 3);

            for (int i = 0; i < 10; i++)
            {
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    plane = menu.planList.GetFlightPlan(i);

                    Point inicio = new Point
                        (
                        (int)plane.GetinitialPosition().GetX(),
                        (int)plane.GetinitialPosition().GetY()
                        );
                    Point final = new Point
                        (
                        (int)plane.GetfinalPosition().GetX(),
                        (int)plane.GetfinalPosition().GetY()
                        );
                    Point centro = new Point
                        ((int)plane.GetcurrentPosition().GetX(),
                         (int)plane.GetcurrentPosition().GetY()
                        );
                    float radio = (float)menu.dSeg;

                    g.DrawEllipse(rojo, centro.X - radio, centro.Y - radio, 2 * radio, 2 * radio);
                    g.DrawLine(rojo, inicio, final);
                    g.DrawImage(avion_40,
                                centro.X - avion_40.Width / 2,
                                centro.Y - avion_40.Height / 2);
                }
            }
        }


        private void ComprovarConflictes()
        {
            for (int i = 0; i < 10; i++) // Recorrem les 10 posicions possibles de la llista de plans de vol (anirem comparant cada avió amb els seguents de la llista)
            {
                FlightPlan avio1 = menu.planList.GetFlightPlan(i);

                if (avio1 != null)
                {
                    for (int j = i + 1; j < 10; j++)
                    {
                        FlightPlan avio2 = menu.planList.GetFlightPlan(j);

                        if (avio2 != null)
                        {
                            if (avio1.Conflicto(avio2, menu.dSeg)) // Utilitzem el metode Conflicto de la classe FlightPlan (Fase 1)
                            {
                                simulacionTimer.Stop(); // Aturem la simulació automàtica si hi ha un conflicte

                                AlertaConflicto alerta = new AlertaConflicto(); 
                                alerta.ShowDialog(this); // Mostrem el missatge d'alerta de conflicte

                                return;
                            }
                        }
                    }
                }
            }
        }


        private void EspAereo_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (menu.planList.GetFlightPlan(i) != null)
                {
                    FlightPlan plan = menu.planList.GetFlightPlan(i);

                    double dx = e.X - plan.GetcurrentPosition().GetX();
                    double dy = e.Y - plan.GetcurrentPosition().GetY();
                    double dist = Math.Sqrt(dx * dx + dy * dy);

                    if (dist <= avion_40.Width / 2)
                    {
                        da = new _05_Datos_Avion
                            (
                                plan.Getid(),
                                Convert.ToString(plan.GetVelocidad()),
                                Convert.ToString(plan.GetcurrentPosition().GetX()),
                                Convert.ToString(plan.GetcurrentPosition().GetY())
                            );
                        da.Show();
                    }
                }
            }
        }

        private void IniciarAutoSim_Click(object sender, EventArgs e)
        {

        }
    }
}