using System;
using Microsoft.Win32;
using System.Security.Cryptography;
using System.Text;
using System.Configuration;


namespace CIS.Lib.Utils
{
    /// <summary>
    /// This file contains some applicaiton setting methods.
    /// </summary>
    public sealed class AppSetting
    {
        /// <summary>
        ///Since this class provides only static methods, make the default constructor private to prevent 
        /// instances from being created with "new AppSetting()".
        /// </summary>
        private AppSetting() { }


        /// <summary>
        /// Signature: GetConnString()
        /// This method is used get the connection string from the registry
        /// </summary>
        /// <returns>DBConnection String</returns>
        public static string GetConnString()
        {
            // getting from registry key
            // RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            // string sConnString = pRegKey.GetValue("DBConnString").ToString();
            
            // getting from web.config file
            string sConnString = ConfigurationSettings.AppSettings["DBConnString"].ToString();
            
            //string sConnString = pRegKey.GetValue("DBConnStringEncrypted").ToString();
            //string sdecript = Decrypt(sConnString, "TripleDES", true);
            //return sdecript;
            return sConnString;
        }

        public static string GetConnStringOrca()
        {
            // get from registry key
            // RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            // string sConnString = pRegKey.GetValue("DBConnStringOrca").ToString();
            
            // get from web.config file

            string sConnString = ConfigurationSettings.AppSettings["DBConnStringOrca"].ToString();


            //string sConnString = pRegKey.GetValue("DBConnStringEncrypted").ToString();
            //string sdecript = Decrypt(sConnString, "TripleDES", true);
            //return sdecript;
            return sConnString;
        }

        public static string GetDebugMode()
        {
            //RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            //string sDebugMode = pRegKey.GetValue("DebugMode").ToString();
            //return sDebugMode;
            return "0";
        }
        public static string GetLogfileName()
        {
            RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            string sLogfileName = pRegKey.GetValue("Logfile").ToString();
            return sLogfileName;
        }

        public static string GetServiceURL()
        {
            // Get service url from registry
            // RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            // string serviceURL = pRegKey.GetValue("ServiceURLOrca").ToString();

            // get from web.config file

            string serviceURL = ConfigurationSettings.AppSettings["ServiceURL"].ToString();

            return serviceURL;
        }
        public static string GetServiceURLOrca()
        {
            // Get service URL from registry
            // RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            // string serviceURL = pRegKey.GetValue("ServiceURLOrca").ToString();

            // get from web.config file

            string serviceURL = ConfigurationSettings.AppSettings["ServiceURLOrca"].ToString();

            return serviceURL;
        }
        
        // Get the encryption key
        public static string GetEncryptionKey()
        {
            // Get service URL from registry
            // RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            // string serviceURL = pRegKey.GetValue("EncryptionKey").ToString();

            // get from web.config file

            string strEncryptionKey = ConfigurationSettings.AppSettings["EncryptionKey"].ToString();

            return strEncryptionKey;
        }

        /*
        public static string GetConnString()
        {
            RegistryKey pRegKey = Registry.LocalMachine.OpenSubKey("Software\\BestowerSoft");
            string sConnString = pRegKey.GetValue("DBConnStringEncrypted").ToString();
            string sdecript = Decrypt(sConnString, "TripleDES", true);
            return sdecript;
           
            // create a writer and open the file
            //System.IO.TextWriter tw = new System.IO.StreamWriter(@"C:\KSU\CPSApp\CpsWeb\log.txt");

            // write a line of text to the file
            //tw.WriteLine(" Rows : " + dt.Rows.Count.ToString());

            // close the stream
            //tw.Close();

        }
        */
        public static string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Encrypt(string toEncrypt)
        {
            string key = AppSetting.GetEncryptionKey();
            bool useHashing = true;
 
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public static string Decrypt(string toDecrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string Decrypt(string toDecrypt)
        {
            string key = AppSetting.GetEncryptionKey();
            bool useHashing = true;

            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

    }

}
