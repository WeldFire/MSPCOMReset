using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

public class DevConController {
    //Setup file paths
    private static string libDirectory =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\DevCon\\";
    private static string libPath =
        libDirectory + "devcon.exe";

    private static bool unpackedLib = false;

    public static void deviceEnable(bool enable) {
        if(unpackedLib) {
            //Are we enabling or disabling?
            string state = ((enable == true) ? "enable" : "disable");

            //Create the argument list
            string args = "" + state + " \"USB\\VID_0451&PID_F432&MI_00*\"";

            //Start the process with the arguments above and wait for it to finish executing
            using(Process libProcess = Process.Start(libPath, args)) {
                libProcess.WaitForExit();
            }
        }
    }

    public static void deviceReset() {//Disable then reenable the device
        if(unpackedLib){
            deviceEnable(false);
            System.Threading.Thread.Sleep(5000);//Wait 5 seconds for Windows to settle
            deviceEnable(true);
        }
    }

    public static void unpackLib() {
        if(!unpackedLib) {
            byte[] exeBytes;

            if(systemCheck.is64BitOperatingSystem) {//Which archetecture are we?
                exeBytes = MSP_UART_Reset.Properties.Resources.devcon64;
            } else {
                exeBytes = MSP_UART_Reset.Properties.Resources.devcon32;
            }


            if(!Directory.Exists(libDirectory)) {//Make sure that the folder we want to write to exists
                Directory.CreateDirectory(libDirectory);
            }

            using(FileStream exeFile = new FileStream(libPath, FileMode.Create)) {//Unpack library to file
                exeFile.Write(exeBytes, 0, exeBytes.Length);
            }

            unpackedLib = true;
        }
    }

    public static void deleteLib() {
        if(unpackedLib) {
            File.Delete(libPath);//Delete the file
            unpackedLib = false;
        }
    }

    private class systemCheck {
        public static bool is64BitProcess = (IntPtr.Size == 8);
        public static bool is64BitOperatingSystem = is64BitProcess || InternalCheckIsWow64();

        [DllImport("kernel32.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool IsWow64Process(
            [In] IntPtr hProcess,
            [Out] out bool wow64Process
        );

        public static bool InternalCheckIsWow64() {
            //Check the version of Windows that we are using is capable of 64Bit
            if((Environment.OSVersion.Version.Major == 5 && Environment.OSVersion.Version.Minor >= 1) ||
                Environment.OSVersion.Version.Major >= 6) {

                using(Process p = Process.GetCurrentProcess()) {
                    bool retVal;
                    //Is our current process 64Bit?
                    if(!IsWow64Process(p.Handle, out retVal)) {
                        return false;
                    }
                    return retVal;
                }
            } else {
                return false;
            }
        }
    }
}