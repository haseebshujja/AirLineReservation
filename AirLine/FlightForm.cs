using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine
{
    public partial class FlightForm : Form
    {

        public FlightForm()
        {

            
            InitializeComponent();
        }

        private void FlightForm_Load(object sender, EventArgs e)
        {
            flightCmbBox.Items.Add("Barcelona");
            flightCmbBox.Items.Add("Lahore");
            classComboBox.Items.Add("Business");
            classComboBox.Items.Add("Economy");

           



        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
           

                if (flightCmbBox.Text == "Barcelona")
                {


                try {
                    BarcelonaFlight barcelonaFlight = new BarcelonaFlight();

                    barcelonaFlight.Arrival = barcelonaFlight.SetArrival();
                    barcelonaFlight.Class = classComboBox.Text;
                    barcelonaFlight.Departure = barcelonaFlight.SetDeparture();
                    barcelonaFlight.Terminal = Convert.ToInt32(txtTerminal.Value);
                    barcelonaFlight.FlightTo = flightCmbBox.Text;
                    var radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                    Seat seat = new Seat();
                    seat.SeatNumber = Convert.ToInt32(txtSeatNumber.Value);
                    seat.SeatColumn = radioButton.Text;
                    Passenger passenger = new Passenger();
                    passenger.LuggageWeightCarried = Convert.ToInt32(txtLuggageWeight.Value);
                    passenger.PassengerID = Convert.ToInt32(txtPassengerID.Text);
                    passenger.PassengerName = txtPassengerName.Text;
                    passenger.Email = txtEmail.Text;
                    barcelonaFlight.BookFlight(passenger.Email, barcelonaFlight.Class, barcelonaFlight.Terminal, barcelonaFlight.SetDeparture(),
                    barcelonaFlight.SetArrival(), passenger.LuggageWeightCarried, passenger.PassengerID, passenger.PassengerName,
                    seat.SeatColumn, seat.SeatNumber, barcelonaFlight.FlightTo);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(barcelonaFlight.ShowFlightData().ToArray());
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Empty fiels are not allowed");
                }
                }
                else if (flightCmbBox.Text == "Lahore")
                {
                    LahoreFlight lahoreFlight = new LahoreFlight();
                    lahoreFlight.Arrival = lahoreFlight.SetArrival();
                    lahoreFlight.Class = classComboBox.Text;
                    lahoreFlight.Departure = lahoreFlight.SetDeparture();
                    lahoreFlight.Terminal = Convert.ToInt32(txtTerminal.Value);
                    lahoreFlight.FlightTo = flightCmbBox.Text;
                    var radioButton = groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked);
                    Seat seat = new Seat();
                    seat.SeatNumber = Convert.ToInt32(txtSeatNumber.Value);
                    seat.SeatColumn = radioButton.Text;
                    Passenger passenger = new Passenger();
                    passenger.LuggageWeightCarried = Convert.ToInt32(txtLuggageWeight.Value);
                    passenger.PassengerID = Convert.ToInt32(txtPassengerID.Text);
                    passenger.PassengerName = txtPassengerName.Text;
                    passenger.Email = txtEmail.Text;
                    lahoreFlight.BookFlight(passenger.Email, lahoreFlight.Class, lahoreFlight.Terminal, lahoreFlight.SetDeparture(),
                    lahoreFlight.SetArrival(), passenger.LuggageWeightCarried, passenger.PassengerID, passenger.PassengerName,
                    seat.SeatColumn, seat.SeatNumber, lahoreFlight.FlightTo);
                    listBox1.Items.Clear();
                    listBox1.Items.AddRange(lahoreFlight.ShowFlightData().ToArray());


                }
                else
                {
                    MessageBox.Show("You have not picked any flight");
                }
            
           






            
        }

        private void flightCmbBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flightCmbBox.SelectedIndex == 0)
            {
                BarcelonaFlight barcelonaFlight = new BarcelonaFlight();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(barcelonaFlight.ShowFlightData().ToArray());
                lblDepart.Visible = true;
                lblArrival.Visible = true;
                lblDepart.Text = barcelonaFlight.SetDeparture();
                lblArrival.Text = barcelonaFlight.SetArrival();
            }
           else if (flightCmbBox.SelectedIndex == 1)
            {
                LahoreFlight lahoreFlight = new LahoreFlight();
                
                listBox1.Items.Clear();
                listBox1.Items.AddRange(lahoreFlight.ShowFlightData().ToArray());
                lblDepart.Visible = true;
                lblArrival.Visible = true;
                lblDepart.Text = lahoreFlight.SetDeparture();
                lblArrival.Text = lahoreFlight.SetArrival();
            }
        }

        private void txtPassengerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void txtPassengerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void Go_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SelectNextControl(ActiveControl, true, true, true, true);

            }
        }

        private void txtTerminal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBookFlight.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ClearTextBoxes ()
        {
            txtEmail.Clear();
            txtPassengerID.Clear();
            txtPassengerID.Clear();
            txtPassengerName.Clear();
            txtPassengerName.Focus();
        }
    }
}
