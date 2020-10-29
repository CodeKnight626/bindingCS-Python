using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BindingCS_Python
{
    class RunPython
    {
        //argumentos args separados por espacios
        public string RunPythonConsole(string rCodeFilePath, string args)
        {
            // Variables para el nombre del archivo y el resultado
            string file = rCodeFilePath;
            string result = string.Empty;

            try
            {
                //Generamos la informacion del nuevo proceso a ejecutar
                var info = new ProcessStartInfo(@"C:\Users\cesar\AppData\Local\Programs\Python\Python37\python.exe");
                info.Arguments = file + " " + args;

                info.RedirectStandardInput = false;
                info.RedirectStandardOutput = true;
                info.UseShellExecute = false;
                info.CreateNoWindow = true;

                using (var proc = new Process())
                {
                    //Abrimos proceso
                    proc.StartInfo = info;
                    proc.Start();
                    proc.WaitForExit();

                    // Si el Script de python es ejecutado sin errores, devolvemos el texto imprimido en pantalla y lo guardamos en la variable resultado
                    if(proc.ExitCode == 0)
                    {
                        result = proc.StandardOutput.ReadToEnd();
                    }
                }

                //Devolvemos a nuestro main el resultado
                return result;
            }

            //Si no se encuentra el script de python py o exe se ejecuta el siguiente catch
            catch (Exception ex)
            {
                throw new Exception("Pyhton Script failed: " + result, ex);
            }
        }
    }
}
