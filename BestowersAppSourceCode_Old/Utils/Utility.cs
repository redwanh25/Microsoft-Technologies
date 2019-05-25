using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CIS.Lib.Utils
{
    public sealed class Utility
    {
        /// <summary>
        ///Since this class provides only static methods, 
        /// make the default constructor private to prevent 
        /// instances from being created with "new Utils()".
        /// </summary>
        private Utility() { }



        /// <summary>
        /// Write logs to a file for debug purposes
        /// </summary>
        /// <param name="sFileName"></param>
        /// <param name="sText"></param>
        /// <param name="sHeader"></param>
        public static void WriteLog(string sFileName, string sText, string sHeader)
        {
            // See if it is in debug mode
            int debugMode = Convert.ToInt32(AppSetting.GetDebugMode());
         
            if (debugMode == 1)
            {
                if (sFileName.Equals(string.Empty))
                {
                    sFileName = AppSetting.GetLogfileName();
                }

                TextWriter tw = new StreamWriter(sFileName,true);

                // If header exists then print it...
                if (!String.IsNullOrEmpty(sHeader))
                {
                    tw.WriteLine("---------------------------------");
                    tw.WriteLine("-- " + sHeader + " - " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString());
                    tw.WriteLine("---------------------------------");
                }
                
                // Write the content to the file
                tw.WriteLine(sText);

                tw.Close();
            }
        }

    }
}

