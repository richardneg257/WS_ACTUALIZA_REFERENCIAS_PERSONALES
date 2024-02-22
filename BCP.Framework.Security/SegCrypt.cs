using System;
using System.Runtime.InteropServices;
using System.Text;

namespace BCP.Framework.Security
{
    public class SegCrypt
    {
        ////[DllImport(@"C:/Windows/SysWOW64/SegCryptOpenApi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //[DllImport(@"C:/Windows/SysWOW64/SegCryptWebApi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //public static extern bool EncryptDecrypt([MarshalAs(UnmanagedType.Bool)] bool fEncrypt, string lpszInBuffer, StringBuilder sOut, [MarshalAs(UnmanagedType.I4)] ref int dsize);

        //public static string EncryptDecrypt(bool fEncrypt, string text)
        //{
        //    string res = string.Empty;
        //    if (string.IsNullOrWhiteSpace(text))
        //        return res;
        //    try
        //    {
        //        int nSize = text.Length * 2 + 1;
        //        bool bRet;
        //        StringBuilder outString = new StringBuilder(nSize);
        //        bRet = EncryptDecrypt(fEncrypt, text, outString, ref nSize);
        //        res = outString.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("Error en EncryptDecrypt, " + ex.Message);
        //    }

        //    return res;
        //}

        /// <summary>  
        /// <summary>
        /// Función wraper para encriptar y desencriptar valores - Segurinet
        /// </summary>
        /// <param name="enDec">true - Encriptar, false - Desencriptar</param>
        /// <param name="strInput">String Valor</param>
        /// <param name="strOutput">Resultado encriptado o desencriptado</param>
        /// <returns>boolean</returns>
        //unsafe public static bool EncryptDecrypt(bool enDec, string strInput, ref string strOutput)
        //{
        //    try
        //    {
        //        bool res = false;
        //        int chrSize = strInput.Length * 2 + 1;
        //        byte[] byteRes = new byte[chrSize];
        //        strOutput = "";

        //        fixed (byte* pByteRes = &byteRes[0])
        //        {
        //            res = EncryptDecrypt(enDec, strInput, pByteRes, &chrSize);
        //            for (int i = 0; i < chrSize; i++)
        //                strOutput += ((char)*(pByteRes + i));
        //        }
        //        return res;
        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //}

        //[DllImport(@"C:/Windows/SysWOW64/SegCryptDigitalizacion.dll")]
        //unsafe public static extern bool EncryptDecrypt(bool EnDec, string InputString, byte* OutputRaw, int* Length);

        /// <summary>
        /// Función para encriptar y desencriptar valores - Segurinet
        /// </summary>
        /// <param name="EnDec">true - Encriptar, false - Desencriptar</param>
        /// <param name="InputString">String Valor</param>
        /// <param name="OutputRaw">Resultado encriptado o desencriptado</param>
        /// <param name="Length">Tamaño del string destino.</param>
        /// <returns></returns>




        //[DllImport(@"C:/Windows/SysWOW64/SegCryptDigitalizacion.dll")]
        //unsafe private static extern bool EncryptDecrypt(
        //   bool encriptar, string entrada, byte* salida, int* tamañoSalida
        //   );

        /// <summary>
        /// 
        /// </summary>
        /// <param name="encriptar"></param>
        /// <param name="entrada"></param>
        /// <param name="tamaño"></param>
        /// <returns></returns>
        //public static string EncryptDecrypt(bool encriptar, string entrada)
        //{
        //    string salida = null;
        //    byte[] bytes = null;
        //    bool realizado = false;
        //    unsafe
        //    {
        //        int tamaño = entrada.Length * 2;
        //        int tamañoLocal = tamaño;
        //        byte* punteroBuffer = stackalloc byte[tamañoLocal];

        //        realizado =
        //            EncryptDecrypt(
        //                encriptar, entrada,
        //                punteroBuffer, &tamañoLocal
        //                );

        //        if (realizado)
        //        {
        //            //tamañoLocal = tamañoLocal - 1; //Menos el caracter 0 \0
        //            bytes = new byte[tamañoLocal];
        //            for (int i = 0; i < tamañoLocal; i++)
        //            {
        //                bytes[i] = (byte)(*(punteroBuffer + i));
        //            }
        //        }

        //    }

        //    if (realizado)
        //    {
        //        salida = Encoding.UTF8.GetString(bytes);
        //        salida = salida.Replace("\0", string.Empty);
        //    }
        //    else
        //    {
        //        salida = string.Empty;
        //    }

        //    return salida;
        //}



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
    }
}
