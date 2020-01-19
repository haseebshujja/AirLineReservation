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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnBookSeat_Click(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#a4d4ae");
          
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            chbTheme.Appearance = System.Windows.Forms.Appearance.Button;
            ToolTip toolTip1 = new ToolTip();
           
            toolTip1.SetToolTip(this.chbTheme, "Change program's theme");
            toolTip1.SetToolTip(this.btnBookSeat, "Book seats");
            toolTip1.SetToolTip(this.btnPassengerDetails, "Get passenger details");
            toolTip1.SetToolTip(this.btnEditData, "This will enable you to edit data");
            toolTip1.SetToolTip(this.btnClose, "Close program");

        }

        private void chbTheme_CheckedChanged(object sender, EventArgs e)
        {
            System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#a4d4ae");
            System.Drawing.Color darkCol = System.Drawing.ColorTranslator.FromHtml("#333333");
            if (chbTheme.Checked)
            {
                leftPanel.BackColor = col;
                topPanel.BackColor = col;
                btnBookSeat.BackColor = col;
                btnEditData.BackColor = col;
                btnPassengerDetails.BackColor = col;
                chbTheme.BackColor = col;
                btnBookSeat.ForeColor = darkCol;
                btnEditData.ForeColor = darkCol;
                btnPassengerDetails.ForeColor = darkCol;
                
                btnBookFlight.ForeColor = darkCol;
                btnBookFlight.BackColor = col;


            }
            else
            {
                leftPanel.BackColor = darkCol;
                topPanel.BackColor = darkCol;
                btnBookSeat.ForeColor = Color.White;
                btnBookFlight.ForeColor = Color.White;
                btnEditData.ForeColor = Color.White;
                btnPassengerDetails.ForeColor = Color.White;
                btnBookSeat.BackColor = darkCol;
                btnBookFlight.BackColor = darkCol;
                btnEditData.BackColor = darkCol;
                btnPassengerDetails.BackColor = darkCol;
                chbTheme.BackColor = darkCol;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBookFlight_Click(object sender, EventArgs e)
        {
            FlightForm flightForm = new FlightForm();
            flightForm.Show();
        }
    }
}
