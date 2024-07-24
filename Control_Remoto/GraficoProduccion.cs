using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;

namespace Control_Remoto
{
    public partial class GraficoProduccion : Form
    {
        //VariablesPDF

        //Variables Para Graficos
        string AreaOcupadaDiario = "C"; //Area que ocupa el grafico Diario Por Default
        string AreaOcupadaSemanal = "A";
        string AreaOcupadaMensual = "B";
        //Para obtencion de resultados
        int buenas=0, malas=0; //Para resultados diarios
        int buenas2, malas2; //para resultados mensuales
        int buenas3, malas3; //para resultados semanales

        string dia = DateTime.Now.Day.ToString();
        string mes = DateTime.Now.ToString("MMMM", System.Globalization.CultureInfo.CreateSpecificCulture("es-ES"));
        string year = DateTime.Now.Year.ToString();
        string week;
        string weekselect;

        /* POSICIONES INICIALES DE LAS GRAFICAS
          *     > Grafico Diario = 27; 125
          *     > Grafico Semanal = 712; 145
          *     > Grafico Mensual = 712; 445
          *  
          *  TAMAÑOS INICIALES DE LAS GRAFICAS
          *     > Grafico Diario = 655; 512
          *     > Grafico Semanal = 244; 102
          *     > Grafico Mensual = 244; 102
          */
        public GraficoProduccion()
        {
            InitializeComponent();
        }
        private void GraficoProduccion_Load(object sender, EventArgs e)
        {
            //Poner por defecto checkbox para datos actuales
            ChboxGraficoDiario.Checked = true;
            ChBoxGraficoMensual.Checked = true;
            ChBoxGraficoSemanal.Checked = true;

            weeklist();
            week = numeroSemana(DateTime.Now).ToString();

        }
        private void ChGraficoSemanal_Click(object sender, EventArgs e)
        {
            Reubicacion("MovimientoX");
        }       
        private void ChGraficoMensual_Click(object sender, EventArgs e)
        {
            Reubicacion("MovimientoY");
        }
        private void ChGraficoDiario_Click(object sender, EventArgs e)
        {
            Reubicacion("MovimientoZ");
        }
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnGenerarDoc_Click(object sender, EventArgs e)
        {
            if (AreaOcupadaDiario == "C")
            {
                MessageBox.Show("Generando Reporte de Grafico Diario");
            }
            else if (AreaOcupadaSemanal == "C")
            {
                MessageBox.Show("Generando Reporte de Grafico Semanal");
            }
            else if (AreaOcupadaMensual == "C")
            {
                MessageBox.Show("Generando Reporte de Grafico Mensual");
            }
        }
        //ACTUALIZAR DATOS DE GRAFICAS AL SELECCIONAR FECHA NUEVA
        private void btnDiario_Click(object sender, EventArgs e)
        {
            ChGraficoDiario.Series.FindByName("Buenas").Points.Clear();
            ChGraficoDiario.Series.FindByName("Malas").Points.Clear();
            int yearsel = int.Parse(CbxAñoGD.Text);
            int messel = int.Parse(CbxMesesGD.Text);
            int diasel = int.Parse(CbxDiasGD.Text);
            DateTime datebayo = new DateTime(yearsel, messel, diasel);
            weekselect = numeroSemana(datebayo).ToString();
            resultados_diarios(CbxDiasGD.Text, CbxMesesGD.Text, CbxAñoGD.Text, weekselect);
            ChGraficoDiario.Series.FindByName("Buenas").Points.Add(buenas);
            ChGraficoDiario.Series.FindByName("Malas").Points.Add(malas);
        }

        private void btnMensual_Click(object sender, EventArgs e)
        {
            ChGraficoMensual.Series.FindByName("Buenas").Points.Clear();
            ChGraficoMensual.Series.FindByName("Malas").Points.Clear();
            resultados_mensuales(CbxMesGM.Text, CbxAñoGM.Text);
            ChGraficoMensual.Series.FindByName("Buenas").Points.Add(buenas2);
            ChGraficoMensual.Series.FindByName("Malas").Points.Add(malas2);
        }

        private void btnSemanal_Click(object sender, EventArgs e)
        {
            resultados_semanales(CbxSemana.Text);
        }

        #region Eventos Para Ubicar Las Graficas
        private void Reubicacion(string EleccionMovimiento)
        {
            switch (EleccionMovimiento)
            {
                case "MovimientoX":

                    switch (AreaOcupadaDiario)
                    {
                        case "A":
                            if (AreaOcupadaMensual == "C") //Movimiento Secundario
                            {
                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "B";
                                ChGraficoMensual.Location = new System.Drawing.Point(712, 445);
                                ChGraficoMensual.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Mensual";

                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "C";
                                ChGraficoSemanal.Location = new System.Drawing.Point(27, 125);
                                ChGraficoSemanal.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Semanal";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = true; // <--
                                GbxGraficoDiario.Visible = false;
                            }
                            break;

                        case "B":
                            if (AreaOcupadaSemanal == "A" && AreaOcupadaMensual == "C") // Sexto Movimiento
                            {
                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "A";
                                ChGraficoMensual.Location = new System.Drawing.Point(712, 145);
                                ChGraficoMensual.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Mensual";

                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "C";
                                ChGraficoSemanal.Location = new System.Drawing.Point(27, 125);
                                ChGraficoSemanal.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Semanal";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = true;// <--
                                GbxGraficoDiario.Visible = false;
                            }
                            break;

                        case "C":
                            if (AreaOcupadaSemanal == "A" && AreaOcupadaMensual == "B") // Inicio de Movimiento
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "A";
                                ChGraficoDiario.Location = new System.Drawing.Point(712, 145);
                                ChGraficoDiario.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Diario";


                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "C";
                                ChGraficoSemanal.Location = new System.Drawing.Point(27, 125);
                                ChGraficoSemanal.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Semanal";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = true;// <--
                                GbxGraficoDiario.Visible = false;

                            }
                            else if (AreaOcupadaSemanal == "B" && AreaOcupadaMensual == "A") //Cuarto Movimiento
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "B";
                                ChGraficoDiario.Location = new System.Drawing.Point(712, 445);
                                ChGraficoDiario.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Diario";

                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "C";
                                ChGraficoSemanal.Location = new System.Drawing.Point(27, 125);
                                ChGraficoSemanal.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Semanal";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = true;// <--
                                GbxGraficoDiario.Visible = false;

                            }

                            break;

                    }
                    break;

                case "MovimientoY":
                    switch (AreaOcupadaDiario)
                    {
                        case "A":
                            if (AreaOcupadaSemanal == "C") //Movimiento Secundario
                            {
                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "B";
                                ChGraficoSemanal.Location = new System.Drawing.Point(712, 445);
                                ChGraficoSemanal.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Semanal";

                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "C";
                                ChGraficoMensual.Location = new System.Drawing.Point(27, 125);
                                ChGraficoMensual.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Mensual";
                                GbxGraficoMensual.Visible = true;// <--
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = false;
                            }
                            break;

                        case "B":
                            if (AreaOcupadaSemanal == "C" && AreaOcupadaMensual == "A") // Quinto Movimiento
                            {
                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "A";
                                ChGraficoSemanal.Location = new System.Drawing.Point(712, 145);
                                ChGraficoSemanal.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Semanal";

                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "C";
                                ChGraficoMensual.Location = new System.Drawing.Point(27, 125);
                                ChGraficoMensual.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Mensual";
                                GbxGraficoMensual.Visible = true;// <--
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = false;
                            }
                            break;

                        case "C":
                            if (AreaOcupadaSemanal == "A") // Inicio de Movimiento
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "B";
                                ChGraficoDiario.Location = new System.Drawing.Point(712, 445);
                                ChGraficoDiario.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Diario";

                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "C";
                                ChGraficoMensual.Location = new System.Drawing.Point(27, 125);
                                ChGraficoMensual.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Mensual";
                                GbxGraficoMensual.Visible = true;// <--
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = false;
                            }
                            else if (AreaOcupadaSemanal == "B")
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "A";
                                ChGraficoDiario.Location = new System.Drawing.Point(712, 145);
                                ChGraficoDiario.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Diario";

                                //Cambios en Mensual
                                AreaOcupadaMensual = "C";
                                ChGraficoMensual.Location = new System.Drawing.Point(27, 125);
                                ChGraficoMensual.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Mensual";
                                GbxGraficoMensual.Visible = true;// <--
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = false;
                            }

                            break;

                    }
                    break;

                case "MovimientoZ":

                    switch (AreaOcupadaDiario)
                    {
                        case "A":
                            if (AreaOcupadaSemanal == "C") //Reinicio de ventana
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "C";
                                ChGraficoDiario.Location = new System.Drawing.Point(27, 125);
                                ChGraficoDiario.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Diario";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = true;// <--

                                //Cambios en Grafico Semanal
                                AreaOcupadaSemanal = "A";
                                ChGraficoSemanal.Location = new System.Drawing.Point(712, 145);
                                ChGraficoSemanal.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Semanal";

                            }
                            else if (AreaOcupadaMensual == "C") //Tercer Movimiento
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "C";
                                ChGraficoDiario.Location = new System.Drawing.Point(27, 125);
                                ChGraficoDiario.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Diario";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = true;// <--

                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "A";
                                ChGraficoMensual.Location = new System.Drawing.Point(712, 145);
                                ChGraficoMensual.Size = new System.Drawing.Size(244, 102);
                                LblPosicionA.Text = "Grafico Mensual";

                            }
                            break;

                        case "B":
                            if (AreaOcupadaMensual == "C") // Reinicio de ventana
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "C";
                                ChGraficoDiario.Location = new System.Drawing.Point(27, 125);
                                ChGraficoDiario.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Diario";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = true;// <--

                                //Cambios en Grafico Mensual
                                AreaOcupadaMensual = "B";
                                ChGraficoMensual.Location = new System.Drawing.Point(712, 445);
                                ChGraficoMensual.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Mensual";

                            }
                            else if (AreaOcupadaSemanal == "C") //Movimiento Secundario
                            {
                                //Cambios en Grafico Diario
                                AreaOcupadaDiario = "C";
                                ChGraficoDiario.Location = new System.Drawing.Point(27, 125);
                                ChGraficoDiario.Size = new System.Drawing.Size(655, 512);
                                LblPosicionC.Text = "Grafico Diario";
                                GbxGraficoMensual.Visible = false;
                                GbxGraficoSemanal.Visible = false;
                                GbxGraficoDiario.Visible = true;// <--

                                //Cambios en Grafico Mensual
                                AreaOcupadaSemanal = "B";
                                ChGraficoSemanal.Location = new System.Drawing.Point(712, 445);
                                ChGraficoSemanal.Size = new System.Drawing.Size(244, 102);
                                LblPosicionB.Text = "Grafico Semanal";

                            }
                            break;

                        case "C":

                            break;

                    }
                    break;
            }
        }

        #endregion

        #region Eventos CheckBox
        private void ChboxGraficoDiario_CheckedChanged(object sender, EventArgs e)
        {
            if (ChboxGraficoDiario.Checked)
            {
                CbxDiasGD.Enabled = false;
                CbxMesesGD.Enabled = false;
                CbxAñoGD.Enabled = false;
                ChGraficoDiario.Series.FindByName("Buenas").Points.Clear();
                ChGraficoDiario.Series.FindByName("Malas").Points.Clear();
                resultados_diarios(dia, mes, year, week);
                ChGraficoDiario.Series.FindByName("Buenas").Points.Add(buenas);
                ChGraficoDiario.Series.FindByName("Malas").Points.Add(malas);
            }
            else
            {
                CbxDiasGD.Enabled = true;
                CbxMesesGD.Enabled = true;
                CbxAñoGD.Enabled = true;
               
            }
        }

        private void ChBoxGraficoMensual_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxGraficoMensual.Checked)
            {
                CbxMesGM.Enabled = false;
                CbxAñoGM.Enabled = false;
                
                ChGraficoMensual.Series.FindByName("Buenas").Points.Clear();
                ChGraficoMensual.Series.FindByName("Malas").Points.Clear();
                resultados_mensuales(mes, year);                
                ChGraficoMensual.Series.FindByName("Buenas").Points.Add(buenas2);
                ChGraficoMensual.Series.FindByName("Malas").Points.Add(malas2);
            }
            else
            {
                CbxMesGM.Enabled = true;
                CbxAñoGM.Enabled = true;
            }
        }

        private void ChBoxGraficoSemanal_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxGraficoSemanal.Checked)
            {
                CbxSemana.Enabled = false;

               
            }
            else
            {
                CbxSemana.Enabled = true;
               
            }
        }


        #endregion

        #region MainFunctions
        private void resultados_diarios(string day, string month, string year2, string semana) //Funcion para obtener resultados diarios de los archivos de reportes
        {
            buenas = 0;
            malas = 0;
            try
            {
                string dirDia = @"c:\Reportes\" + month + "_" + year2 + "\\" + day + "_" + month + "_" + year2 + "_" + semana + ".csv";
                string[] list = File.ReadAllLines(dirDia);
                for (int i = 1; i < list.Length; i++)
                {
                    string[] vals = list[i].Split(',');
                    if (vals[4] == "BUENA")
                    {
                        buenas++;
                    }
                    else if (vals[4] == "MALA")
                    {
                        malas++;
                    }
                }
            }
            catch
            {
                //MessageBox.Show("ERROR: Archivo no encontrado");
            }
          

        }

        public void resultados_mensuales(string month, string year2) //Funcion para obtener resultados mensuales de los archivos de reportes
        {
            buenas2 = 0;
            malas2 = 0;
            string dirMes = @"c:\Reportes\" + month + "_" + year2;

            try
            {
                string[] files = Directory.GetFiles(dirMes);
                foreach (string f in files)
                {
                    string[] list = File.ReadAllLines(f);
                    for (int i = 1; i < list.Length; i++)
                    {
                        string[] vals = list[i].Split(',');
                        if (vals[4] == "BUENA")
                        {
                            buenas2++;
                        }
                        else if (vals[4] == "MALA")
                        {
                            malas2++;
                        }
                    }
                }
            }
            catch
            {
                //MessageBox.Show("ERROR: Archivos no encontrados");
            }
           

        }

        public void resultados_semanales(string weekselected) //Funcion para obtener resultados semanales de los archivos de reportes
        {
            buenas3 = 0;
            malas3 = 0;
            string[] weekrange = weekselected.Split('=');
            string range = weekrange[1];
            string[] range2 = range.Split('-');
            string carpeta1, carpeta2;
            int dianum;
            string[] wrange = weekrange[0].Split(',');
            string tempWeek = wrange[0].Remove(0,7);
            char[] MyChar = { 'd', 'e', ' ' };
            tempWeek = tempWeek.TrimEnd(MyChar);
            
                        
            if(range2[1] == range2[4]) //Si los rangos son dentro del mismo mes
            {
                carpeta1 = obtainFolder(range2[1], range2[2]);
                for(int i = 0; i < 7; i++)
                {
                    dianum = int.Parse(range2[0]+i);
                    sumaDiariaSem(dianum.ToString(), carpeta1, tempWeek);
                }

            }
            else //los rangos son de diferentes meses
            {
                carpeta1 = obtainFolder(range2[1], range2[2]);
                carpeta2 = obtainFolder(range2[4], range2[5]);

            }
            
            //MessageBox.Show(range2[0]+"del mes "+ range2[1]+"del año "+ range2[2]+" y "+ range2[3] + "del mes " + range2[4] + "del año " + range2[5]);

        }
        private void sumaDiariaSem(string dia, string mesanio, string numsemana) //Para ir sumando reporte por reporte diario
        {
            try
            {
                string dirDia = @"c:\Reportes\" + mesanio + "\\" + dia + "_" + mesanio + "_"+ numsemana + ".csv";
                string[] list = File.ReadAllLines(dirDia);
                for (int i = 1; i < list.Length; i++)
                {
                    string[] vals = list[i].Split(',');
                    if (vals[4] == "BUENA")
                    {
                        buenas3++;
                    }
                    else if (vals[4] == "MALA")
                    {
                        malas3++;
                    }
                }
            }
            catch
            {

            }
          
        }        

        int numeroSemana(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }      

        static DateTime primerDíaSemana(int year, int weekOfYear, CultureInfo ci)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = (int)ci.DateTimeFormat.FirstDayOfWeek - (int)jan1.DayOfWeek;
            DateTime firstWeekDay = jan1.AddDays(daysOffset);
            int firstWeek = ci.Calendar.GetWeekOfYear(jan1, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek);
            if ((firstWeek <= 1 || firstWeek >= 52) && daysOffset >= -3)
            {
                weekOfYear -= 1;
            }
            return firstWeekDay.AddDays(weekOfYear * 7);
        }
        string setRangoSemana(DateTime fecha)
        {
            var noSemana = numeroSemana(fecha);
            //Validación para verificar si es la ultima semana del año
            var semana = primerDíaSemana(noSemana == 52 ? fecha.AddYears(-1).Year : fecha.Year, noSemana, CultureInfo.CurrentCulture);
            var lunes = semana.AddDays(0);
            var domingo = semana.AddDays(6);
            return string.Format("Semana {0} de, {1} = {2}-{3}", noSemana, fecha.Year, lunes.ToShortDateString(), domingo.ToShortDateString());
        }

        private void weeklist()
        {
            DateTime actual = DateTime.Now;
            DateTime decrement = actual.AddDays(7);
            String[] semana = new String[54];
            for(int i=0; i<=53; i++)
            {
                decrement = decrement.AddDays(-7);
                semana[i] = setRangoSemana(decrement);
                CbxSemana.Items.Add(semana[i]);
            }

        }

        private string obtainFolder(string mes, string year) //Para obtener nombre de folder en reportes
        {
            string folder;
            mes = obtainMonth(mes);
            year = "20" + year;
            folder = mes + "_" + year;
            return folder;
        }
        private string obtainMonth(string mes) //Para obtener nombre largo del mes
        {
            string month;

            switch (mes)
            {
                case "Jan":
                    {
                        mes = "enero";
                        break;
                    }
                case "Feb":
                    {
                        mes = "febrero";
                        break;
                    }
                case "Mar":
                    {
                        mes = "marzo";
                        break;
                    }
                case "Apr":
                    {
                        mes = "abril";
                        break;
                    }
                case "May":
                    {
                        mes = "mayo";
                        break;
                    }
                case "Jun":
                    {
                        mes = "junio";
                        break;
                    }
                case "Aug":
                    {
                        mes = "agosto";
                        break;
                    }
                case "Sep":
                    {
                        mes = "septiembre";
                        break;
                    }
                case "Oct":
                    {
                        mes = "octubre";
                        break;
                    }
                case "Nov":
                    {
                        mes = "noviembre";
                        break;
                    }
                case "Dec":
                    {
                        mes = "diciembre";
                        break;
                    }
            }

            month = mes;

            return month;
        }

        #endregion

    }
}
