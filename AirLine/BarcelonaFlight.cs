using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLine
{
    public class BarcelonaFlight : Flight
    {
        
        string seatQuery = @"IF NOT EXISTS (SELECT 1 FROM FlightToBarcelona WHERE SeatNumber = @SeatNumber AND SeatColumn = @SeatColumn)
                           BEGIN
                           INSERT INTO FlightToBarcelona (EmailAddress, FlightTo, Class, Terminal, Departure, Arrival, Weight, PassengerID, PassengerName, SeatColumn, SeatNumber)
                           VALUES (@EmailAddress, @FlightTo, @Class, @Terminal, @Departure, @Arrival, @Weight, @PassengerID, @PassengerName, @SeatColumn, @SeatNumber)
                           END";


        string planeQuery = "SELECT COUNT (*) FROM FlightToBarcelona";

        public void BookFlight(string emailAddress, string _class, int terminal, string departure, string arrival, int weight,
            int passegnerID, string passengerName, string seatColumn, int seatNumber, string flightTo)
        {


            try {
                string connectionString = "Data Source=KHAN;Initial Catalog=AirLine;Integrated Security=True";
                SqlConnection cn = new SqlConnection(connectionString);
                using (SqlCommand cmd = new SqlCommand(seatQuery, cn))
                {

                    cn.Open();
                    SqlCommand planeCmd = new SqlCommand(planeQuery, cn);
                    int count = (Int32)planeCmd.ExecuteScalar();
                    if (count < 50)
                    {
                        cmd.Parameters.AddWithValue("@Class", _class);
                        cmd.Parameters.AddWithValue("@FlightTo", flightTo);
                        cmd.Parameters.AddWithValue("@Terminal", terminal);
                        cmd.Parameters.AddWithValue("@Departure", departure);
                        cmd.Parameters.AddWithValue("@Arrival", arrival);
                        cmd.Parameters.AddWithValue("@Weight", weight);
                        cmd.Parameters.AddWithValue("@PassengerID", passegnerID);
                        cmd.Parameters.AddWithValue("@PassengerName", passengerName);
                        cmd.Parameters.AddWithValue("@SeatColumn", seatColumn);
                        cmd.Parameters.AddWithValue("@SeatNumber", seatNumber);
                        cmd.Parameters.AddWithValue("@EmailAddress", emailAddress);



                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Seat is successfully booked");
                            SendEmail(emailAddress, _class, terminal, departure, arrival, weight,
             passegnerID, passengerName, seatColumn, seatNumber, flightTo);
                            FlightForm flightForm = new FlightForm();
                            flightForm.ClearTextBoxes();


                        }
                        else
                        {
                            MessageBox.Show("Seat is already taken. Pick a different seat");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Plane is full");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Empty fields are not allowed");
            }
        }

        public List <string> ShowFlightData()
        {

            string connectionString = "Data Source=KHAN;Initial Catalog=AirLine;Integrated Security=True";
            SqlDataReader reader;
            SqlConnection cn = new SqlConnection(connectionString);
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM FlightToBarcelona ORDER BY SeatNumber", cn))
            {

                cn.Open();
                reader = cmd.ExecuteReader();
                List<string> msgList = new List<string>();
                string msg = "";


                while (reader.Read())
                {
                    Passenger p = new Passenger();
                    Seat s = new Seat();
                    FlightTo = (reader["FlightTo"]).ToString();
                    p.PassengerName = (reader["PassengerName"]).ToString();
                    p.PassengerID = Convert.ToInt32(reader["PassengerID"]);
                    s.SeatNumber = Convert.ToInt32(reader["SeatNumber"]);
                    s.SeatColumn = (reader["SeatColumn"]).ToString();
                    p.LuggageWeightCarried = Convert.ToInt32(reader["Weight"]);
                    Class = (reader["Class"]).ToString();
                    Terminal = Convert.ToInt32(reader["Terminal"]);
                    msg = "     " + s.SeatNumber + "\t\t" + s.SeatColumn + " \t       " + p.PassengerID
                        + "       \t" + p.PassengerName;

                    msg += "\t" + p.LuggageWeightCarried + "\t" + FlightTo + "\t" + Terminal + "\t" + Class;
                    msgList.Add(msg);
                    }
                
                return msgList;

                }
        }
        public string SetDeparture ()
        {
            DateTime departureTime = new DateTime(2020, 3, 20, 3, 15, 0);
           
            Departure = departureTime.ToString("dddd, MMM dd yyyy, hh:mm: ss");
            return Departure;
        }
        public string SetArrival()
        {
            DateTime arrivalTime = new DateTime(2020, 3, 20, 9, 15, 0);
           
            Arrival = arrivalTime.ToString("dddd, MMM dd yyyy, hh:mm: ss");
            return Arrival;
        }
        public void SendEmail (string emailAddress, string _class, int terminal, string departure, string arrival, int weight,
            int passegnerID, string passengerName, string seatColumn, int seatNumber, string flightTo)
        {
            try {
                string msg = "";
                msg = "Flight: " + flightTo + "\n";
                msg += "Name: " + passengerName + "\n";
                msg += "ID: " + passegnerID + "\n";
                msg = "Seat: " + seatNumber + seatColumn + "\n";
                msg += "Terminal: " + terminal + "\n";
                msg += "Departure: " + departure + "\n";
                msg += "Arrival: " + arrival + "\n";
                msg += "Weight: " + terminal + "\n";
                msg += "Class: " + _class + "\n";



                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("fakeairline62@gmail.com");
                mail.To.Add(emailAddress);
                mail.Body = msg;
                mail.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                NetworkCredential netCre = new NetworkCredential("fakeairline62@gmail.com", "Lahore123");
                smtp.Credentials = netCre;
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Either emial text was empty or in incorrect format");
            }


        }
    }
}
