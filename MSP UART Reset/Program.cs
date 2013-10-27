using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MSP_UART_Reset {
    static class Program {
        /// <summary>
        /// Disables and Enables MSP430 devices in Windows in order to fix UART communication issues.
        /// When started, the correct architecture of the devcon library is extracted and MSP devices are disabled and then enabled.
        /// Buttons to manually disable, enable, or restart the MSP are presented.
        /// When closed, the devcon library is removed from the system.
        /// Devcon libraries used were found here: http://delphintipz.blogspot.com/2012/07/disable-failed-no-devices-disabled.html
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Unpack the correct library
            DevConController.unpackLib();

            Application.Run(new Main());

            //Clean up and delete the unpacked library
            DevConController.deleteLib();
        }
    }
}
