using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_KP_2Kurs
{
    public partial class EditingForm : Form
    {
        Controller controller;
        public EditingForm(ref Controller controll)
        {
            InitializeComponent();
            controller = controll;
            ShowRailwayTransport();
        }

        private void railwayTransportRB_CheckedChanged(object sender, EventArgs e)
        {
            ShowRailwayTransport();
        }

        private void busRB_CheckedChanged(object sender, EventArgs e)
        {
            ShowBusTransport();
        }

        private void riverTramRB_CheckedChanged(object sender, EventArgs e)
        {
            ShowRiverTram();
        }

        private void ShowRailwayTransport()
        {
            numberRailwayTransportLb.Show();
            numberRailwayTransportTb.Show();
            pointOfArrivalLb.Show();
            pointOfArrivalTb.Show();
            pointOfDepartureLb.Show();
            pointOfDepartureTb.Show();
            pathRailwayTransportLb.Show();
            pathRailwayTransportTb.Show();
            busNumberLb.Hide();
            busNumberTB.Hide();
            busIntervalLb.Hide();
            busIntervalTB.Hide();
            busRouteLb.Hide();
            busRouteTB.Hide();
            numberRiverTramLb.Hide();
            numberRiverTramTB.Hide();
            departurePierRiverTramLb.Hide();
            departurePierRiverTramTB.Hide();
            departureTimeRiverTramLb.Hide();
            departureTimeRiverTramTB.Hide();
            arrivalPierRiverTramLb.Hide();
            arrivalPierRiverTramTB.Hide();
            timeArrivalRiverTramLb.Hide();
            timeArrivalRiverTramTB.Hide();
            EditingBusBtn.Hide();
            EditingRailwayTransportBtn.Show();
            EditingRiverTramBtn.Hide();
        }

        private void ShowBusTransport()
        {
            numberRailwayTransportLb.Hide();
            numberRailwayTransportTb.Hide();
            pointOfArrivalLb.Hide();
            pointOfArrivalTb.Hide();
            pointOfDepartureLb.Hide();
            pointOfDepartureTb.Hide();
            pathRailwayTransportLb.Hide();
            pathRailwayTransportTb.Hide();
            busNumberLb.Show();
            busNumberTB.Show();
            busIntervalLb.Show();
            busIntervalTB.Show();
            busRouteLb.Show();
            busRouteTB.Show();
            numberRiverTramLb.Hide();
            numberRiverTramTB.Hide();
            departurePierRiverTramLb.Hide();
            departurePierRiverTramTB.Hide();
            departureTimeRiverTramLb.Hide();
            departureTimeRiverTramTB.Hide();
            arrivalPierRiverTramLb.Hide();
            arrivalPierRiverTramTB.Hide();
            timeArrivalRiverTramLb.Hide();
            timeArrivalRiverTramTB.Hide();
            EditingBusBtn.Show();
            EditingRailwayTransportBtn.Hide();
            EditingRiverTramBtn.Hide();
        }

        private void ShowRiverTram()
        {
            numberRailwayTransportLb.Hide();
            numberRailwayTransportTb.Hide();
            pointOfArrivalLb.Hide();
            pointOfArrivalTb.Hide();
            pointOfDepartureLb.Hide();
            pointOfDepartureTb.Hide();
            pathRailwayTransportLb.Hide();
            pathRailwayTransportTb.Hide();
            busNumberLb.Hide();
            busNumberTB.Hide();
            busIntervalLb.Hide();
            busIntervalTB.Hide();
            busRouteLb.Hide();
            busRouteTB.Hide();
            numberRiverTramLb.Show();
            numberRiverTramTB.Show();
            departurePierRiverTramLb.Show();
            departurePierRiverTramTB.Show();
            departureTimeRiverTramLb.Show();
            departureTimeRiverTramTB.Show();
            arrivalPierRiverTramLb.Show();
            arrivalPierRiverTramTB.Show();
            timeArrivalRiverTramLb.Show();
            timeArrivalRiverTramTB.Show();
            EditingBusBtn.Hide();
            EditingRailwayTransportBtn.Hide();
            EditingRiverTramBtn.Show();
        }

        private void EditingRailwayTransportBtn_Click(object sender, EventArgs e)
        {
            string[] decemitional_0 = { " ", "  ", "\t" };
            string[] fileElement = pathRailwayTransportTb.Text.Split(decemitional_0,
                StringSplitOptions.RemoveEmptyEntries);
            List<string> route = new List<string>();
            List<DateTime> time = new List<DateTime>();
            for (int i = 0; i < fileElement.Length; i += 2)
            {
                route.Add(fileElement[i]);
                time.Add(DateTime.Parse(fileElement[i + 1]));
            }
           // controller.EditingRailwayTransport(int.Parse(numberRailwayTransportTb.Text), pointOfDepartureTb.Text,
           //     pointOfArrivalTb.Text, route, time, Controller.);
        }

        private void EditingBusBtn_Click(object sender, EventArgs e)
        {
            string[] decemitional_0 = { " ", "  ", "\t" };
            string[] fileElement = busRouteTB.Text.Split(decemitional_0,
                StringSplitOptions.RemoveEmptyEntries);
            List<string> route = new List<string>();
            foreach(string elem in fileElement)
            {
                route.Add(elem);
            }
           // controller.EditingBusTransport(busNumberTB.Text, int.Parse(busIntervalTB.Text), route);
        }

        private void EditingRiverTramBtn_Click(object sender, EventArgs e)
        {
            //controller.EditingRiverTram(int.Parse(numberRiverTramTB.Text),
            //    DateTime.Parse(departureTimeRiverTramTB.Text),
            //    DateTime.Parse(timeArrivalRiverTramTB.Text),
            //    departurePierRiverTramTB.Text, arrivalPierRiverTramTB.Text);
        }
    }
}
