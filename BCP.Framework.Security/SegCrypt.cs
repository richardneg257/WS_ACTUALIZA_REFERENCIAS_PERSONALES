using BCP.Framework.Logs;
using Newtonsoft.Json;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace BCP.Framework.Security
{
    public class SegCrypt
    {
        [DllImport(@"C:/Windows/SysWOW64/SegCryptSoli.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EncryptDecrypt([MarshalAs(UnmanagedType.Bool)] bool fEncrypt, string lpszInBuffer, StringBuilder sOut, [MarshalAs(UnmanagedType.I4)] ref int dsize);

        public static string EncryptDecrypt(bool fEncrypt, string text)
        {
            string res = string.Empty;
            if (string.IsNullOrWhiteSpace(text))
                return res;
            try
            {
                int nSize = text.Length * 2 + 1;
                bool bRet;
                StringBuilder outString = new StringBuilder(nSize);
                bRet = EncryptDecrypt(fEncrypt, text, outString, ref nSize);
                res = outString.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en EncryptDecrypt, " + ex.Message);
            }

            return res;
        }

        public static bool EncryptDecrypt(bool enDec, string strInput, ref string strOutput)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(strInput))
                    return false;

                int nSize = strInput.Length * 2 + 1;
                bool bRet;
                StringBuilder outString = new StringBuilder(nSize);
                bRet = EncryptDecrypt(enDec, strInput, outString, ref nSize);
                strOutput = outString.ToString();
                return true;
            }
            catch (Exception ex)
            {
                Logger.Error("Ha ocurrido un error de cifrado simetrico: {0}", JsonConvert.SerializeObject(ex));
                throw new Exception(ex.Message);
            }
        }

        public static string Encrypt(string value)
        {
            try
            {
                string valueOutput = string.Empty;
                EncryptDecrypt(true, value, ref valueOutput);
                return valueOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string Decrypt(string value)
        {
            try
            {
                string valueOutput = string.Empty;
                EncryptDecrypt(false, value, ref valueOutput);
                return valueOutput;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
