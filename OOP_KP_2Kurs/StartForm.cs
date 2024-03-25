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
    public partial class StartForm : Form
    {
        Controller controller = new Controller();
        public StartForm()
        {
            InitializeComponent();
        }

        private void BusBtn_Click(object sender, EventArgs e)
        {
            controller.Print(informationListBox, "bus");
        }

        private void riverTramBtn_Click(object sender, EventArgs e)
        {
            controller.Print(informationListBox, "river tram");
        }

        private void numberOfBusBtn_Click(object sender, EventArgs e)
        {
            controller.GetBusFromNumber(informationListBox,numberOfBusTB.Text.ToString());
        }

        private void railwayTransportBtn_Click(object sender, EventArgs e)
        {
            controller.Print(informationListBox, "railway transport");
        }

        private void pointDepartueBtn_Click(object sender, EventArgs e)
        {
            controller.GetTransportFromPointDepartue(informationListBox, pointDepartueTb.Text.ToString());
        }

        private void pointArrivalBtn_Click(object sender, EventArgs e)
        {
            controller.GetTransportFromPointArrival(informationListBox, pointArrivalTb.Text.ToString());
        }

        private void editingBtn_Click(object sender, EventArgs e)
        {
            EditingForm editingForm = new EditingForm(ref controller);
            editingForm.Show();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            controller.SaveInformation();
        }
    }
}
