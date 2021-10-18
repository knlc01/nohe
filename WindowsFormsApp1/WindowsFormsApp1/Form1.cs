using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class NOCHE : Form
    {
        string tiempo;
        double total;
        TimeSpan time = TimeSpan.Parse("00:01:00:00");
        

        public NOCHE()
        {
            InitializeComponent();
            items_cb_tiempo();
            lb_tiempo.Text = "00:00:00";
        }

        void items_cb_tiempo()
        {
            cb_tiempo.Items.Add("10 minuto");
            cb_tiempo.Items.Add("30 minutos");
            cb_tiempo.Items.Add("1 hora");
            cb_tiempo.Items.Add("1 hora y 30 minutos");
            cb_tiempo.Items.Add("2 horas");
            cb_tiempo.Items.Add("2 horas y 20 minutos");
        }

        string traductor_tiempo(ComboBox cb)
        {
            string resultado = "60";

            if (cb.Text == "10 minuto")
            {
                resultado = "600";
                time = TimeSpan.Parse("00:10:00");
            }
            else if (cb.Text == "30 minutos")
            {
                resultado = "1800";
                time = TimeSpan.Parse("00:30:00");
            }
            else if (cb.Text == "1 hora")
            {
                resultado = "3600";
                time = TimeSpan.Parse("01:00:00");
            }
            else if (cb.Text == "1 hora y 30 minutos")
            {
                resultado = "5400";
                time = TimeSpan.Parse("01:30:00");
            }
            else if (cb.Text == "2 horas")
            {
                resultado = "7200";
                time = TimeSpan.Parse("02:00:00");
            }
            else if (cb.Text == "2 horas y 20 minutos")
            {
                resultado = "8400";
                time = TimeSpan.Parse("02:20:00");
            }
            return resultado;
        }

        private void bt_apagar_Click(object sender, EventArgs e)
        {
            tiempo = traductor_tiempo(cb_tiempo);
            string linea = "/c shutdown -s -t " + tiempo;
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", linea);
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = info;
            timer1.Start();
            proceso.Start();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo("cmd", "/c shutdown -a");
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo = info;
            timer1.Stop();
            proceso.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Subtract(new TimeSpan(0, 0, 1));
            this.lb_tiempo.Text = String.Format("{0:00}:{1:00}:{2:00}", time.Hours, time.Minutes, time.Seconds);
            if(time.Minutes < 1 && time.Hours < 1)
            {
                lb_tiempo.ForeColor = Color.Red;
            }
        }

        private void NOCHE_Load(object sender, EventArgs e)
        {

        }
    }
}
