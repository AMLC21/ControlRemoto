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
            //MessageBox.Show("Numero de semana es " + week);

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
            int messel = obtainMonthShort(CbxMesesGD.Text); //int.Parse(CbxMesesGD.Text);
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
            ChGraficoSemanal.Series.FindByName("Buenas").Points.Clear();
            ChGraficoSemanal.Series.FindByName("Malas").Points.Clear();
            resultados_semanales(CbxSemana.Text);
            ChGraficoSemanal.Series.FindByName("Buenas").Points.Add(buenas3);
            ChGraficoSemanal.Series.FindByName("Malas").Points.Add(malas3);
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
                week = numeroSemana(DateTime.Now).ToString();                
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
                week = numeroSemana(DateTime.Now).ToString();
                CbxSemana.Enabled = false;

                ChGraficoSemanal.Series.FindByName("Buenas").Points.Clear();
                ChGraficoSemanal.Series.FindByName("Malas").Points.Clear();
                resultados_semanales2(week);
                ChGraficoSemanal.Series.FindByName("Buenas").Points.Add(buenas3);
                ChGraficoSemanal.Series.FindByName("Malas").Points.Add(malas3);

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
            //La cadena que se recibe aparece como "Semana X de , 20XX = dia1-mes1-año1-dia2-mes2-año2
            buenas3 = 0;
            malas3 = 0;
            string[] weekrange = weekselected.Split('='); //Separa la cadena seleccionada (posicion [0] primera parte antes del = y posicion [1] segunda parte.
            string range = weekrange[1]; //Guardar segunda parte en una variable (el rango de fechas que ocupa la semana)
            string[] range2 = range.Split('-'); //Define otra cadena para guardar cada elemento del rango de fechas separando dias, meses y años
            string carpeta1, carpeta2;
            int dianum;
            string[] wrange = weekrange[0].Split(','); // toma la primera parte de la cadena antes del = y la divide por la , para sacar el numero de semana
            string tempWeek = wrange[0].Remove(0,7); //Toma el primer elemento de la division "semana x de " y remueve los primeros 7 caracteres para eliminar palabra "semana"
            char[] MyChar = { 'd', 'e', ' ' }; //Arreglo de caracteres que debe eliminar del final de la cadena anterior resultante
            tempWeek = tempWeek.TrimEnd(MyChar); //Quita los caracteres finales del string segun el arreglo anterior para dejar solo el numero de la semana.       

            //range[0] = dia1 --- [1] = mes1 --- [2] = año1 --- [3] = dia2 --- [4] = mes2 --- [5] = año2

            try
            {
                carpeta1 = obtainFolder(range2[1], range2[2]);
                string[] files = Directory.GetFiles(carpeta1); //obtener los archivos que contiene la carpeta
                foreach (string f in files)
                {
                    string[] name = f.Split('_'); //Para dividir los componentes del nombre por el separador del guion bajo
                    string[] namesemana = name[4].Split('.');//Para quitarle la extension .csv y que quede solo el numero de semana
                    string[] list = File.ReadAllLines(f); //Asigna a la lista el contenido del archivo en curso, en un arreglo de lineas por cada linea que contenga el archivo
                    if (namesemana[0] == tempWeek)
                    {
                        for (int i = 1; i < list.Length; i++) //Recorrer la lista con el contenido del archivo (linea por linea)
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
                }

                if (range2[1] != range2[4]) //Si el rango de fechas son de distintos meses
                {
                    carpeta2 = obtainFolder(range2[4], range2[5]); //Obtener carpeta del otro rango de fechas
                    string[] files2 = Directory.GetFiles(carpeta2);
                    foreach (string f2 in files2)
                    {
                        string[] name2 = f2.Split('_');
                        string[] namesemana2 = name2[4].Split('.');
                        string[] list2 = File.ReadAllLines(f2);
                        if (namesemana2[0] == tempWeek)
                        {
                            for (int i = 1; i < list2.Length; i++)
                            {
                                string[] vals2 = list2[i].Split(',');
                                if (vals2[4] == "BUENA")
                                {
                                    buenas3++;
                                }
                                else if (vals2[4] == "MALA")
                                {
                                    malas3++;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {

            }         
                      
                      

        }

        public void resultados_semanales2(string numweek) //Funcion para obtener resultados semanales de semana actual solicitando solo el numero de semana
        {
            buenas3 = 0;
            malas3 = 0;

            try
            {
                string carpeta = obtainFolder(mes, year); //Carpeta del mes actual
                int yearant = int.Parse(year);
                if (mes == "enero")
                {
                    yearant = yearant - 1;
                }
                string carpeta2 = obtainFolder(mesAnterior(mes), yearant.ToString()); //Carpeta del mes anterior

                //Busqueda en la primera carpeta (Del mes actual)
                string[] files = Directory.GetFiles(carpeta); //Carpeta del mes actual
                foreach (string f in files) //f es el nombre del archivo en curso
                {
                    string[] name = f.Split('_'); //Para dividir los componentes del nombre por el separador del guion bajo
                    string[] namesemana = name[4].Split('.');//Para quitarle la extension .csv y que quede solo el numero de semana
                    string[] list = File.ReadAllLines(f); //Asigna a la lista el contenido del archivo en curso, en un arreglo de lineas por cada linea que contenga el archivo
                    if (namesemana[0] == numweek) //Compara si el archivo actual pertenece al numero de semana solicitado
                    {
                        for (int i = 1; i < list.Length; i++) //Recorrer la lista con el contenido del archivo (linea por linea)
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


                }

                //Por si la semana abarca dos meses (Carpeta del mes anterior)

                string[] files2 = Directory.GetFiles(carpeta2);
                foreach (string f2 in files2)
                {
                    string[] name = f2.Split('_'); //Para dividir los componentes del nombre por el separador del guion bajo
                    string[] namesemana = name[4].Split('.');//Para quitarle la extension .csv y que quede solo el numero de semana
                    string[] list = File.ReadAllLines(f2);

                    if (namesemana[0] == numweek)
                    {
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

                }
            }
            catch
            {

            }
          
            

        }

        public string mesAnterior(string mesactual)
        {
            string mesant="";
            switch (mesactual)
            {
                case "enero":
                    {
                        mesant = "diciembre";
                        break;
                    }
                case "febrero":
                    {
                        mesant = "enero";
                        break;
                    }
                case "marzo":
                    {
                        mesant = "febrero";
                        break;
                    }
                case "abril":
                    {
                        mesant = "marzo";
                        break;
                    }
                case "mayo":
                    {
                        mesant = "abril";
                        break;
                    }
                case "junio":
                    {
                        mesant = "mayo";
                        break;
                    }
                case "julio":
                    {
                        mesant = "junio";
                        break;
                    }
                case "agosto":
                    {
                        mesant = "julio";
                        break;
                    }
                case "septiembre":
                    {
                        mesant = "agosto";
                        break;
                    }
                case "octubre":
                    {
                        mesant = "septiembre";
                        break;
                    }
                case "noviembre":
                    {
                        mesant = "octubre";
                        break;
                    }
                case "diciembre":
                    {
                        mesant = "noviembre";
                        break;
                    }
            }

            return mesant;
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
            if(year.Length < 3) { year = "20" + year; }            
            folder = mes + "_" + year;
            return @"c:\Reportes\" + folder;
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
                case "Jul":
                    {
                        mes = "julio";
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

        private int obtainMonthShort(string mes)
        {
            int mesnum = 0;

            switch (mes)
            {
                case "enero":
                    {
                        mesnum = 1;
                        break;
                    }
                case "febrero":
                    {
                        mesnum = 2;
                        break;
                    }
                case "marzo":
                    {
                        mesnum = 3;
                        break;
                    }
                case "abril":
                    {
                        mesnum = 4;
                        break;
                    }
                case "mayo":
                    {
                        mesnum = 5;
                        break;
                    }
                case "junio":
                    {
                        mesnum = 6;
                        break;
                    }
                case "julio":
                    {
                        mesnum = 7;
                        break;
                    }
                case "agosto":
                    {
                        mesnum = 8;
                        break;
                    }
                case "septiembre":
                    {
                        mesnum = 9;
                        break;
                    }
                case "octubre":
                    {
                        mesnum = 10;
                        break;
                    }
                case "noviembre":
                    {
                        mesnum = 11;
                        break;
                    }
                case "diciembre":
                    {
                        mesnum = 12;
                        break;
                    }
            }

            return mesnum;
        }

        #endregion

    }
}
