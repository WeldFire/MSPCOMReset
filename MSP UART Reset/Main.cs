using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP_UART_Reset {
    public partial class Main :Form {

        public Main() {
            InitializeComponent();

            //Automatically try and restart the MSP device
            btnReset_Click(this, null);
        }

        private void btnDisable_Click(object sender, EventArgs e) {
            //Disable the MSP device
            DevConController.deviceEnable(false);
        }

        private void btnEnable_Click(object sender, EventArgs e) {
            //Enable the MSP device
            DevConController.deviceEnable(true);
        }

        private void btnReset_Click(object sender, EventArgs e) {
            //Show the restart panel
            displayRestart();

            //Restart the MSP Device in a new thread
            Task.Factory.StartNew(DevConController.deviceReset, TaskCreationOptions.AttachedToParent);
        }

        private void displayRestart() {
            //Make sure the progress bar is reset
            progressRestart.Value = 0;

            //Enable the restart panel and timer
            timerRestart.Enabled = true;
            refreshPanel.Visible = true;
        }

        private void timerRestart_Tick(object sender, EventArgs e) {
            //Wait until we are funished (about 5 seconds)
            if(progressRestart.Value != 100) {
                progressRestart.Value += 2;
            } else {
                //Disable the restart panel and timer
                timerRestart.Enabled = false;
                refreshPanel.Visible = false;
            }
        }
    }
}
