using System;

namespace BindingCS_Python
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables a usar
            // Numeros que sumara el programa de python
            string numbersToAdd = "1 2";

            //Variable donde guardaremos el reusltado devuelto por el script de Python
            string result = string.Empty;

            // Generamos uns instancia de la clase Run Python
            RunPython runPython = new RunPython();
            // Y utilizamos su metodo "RunPythonConsole", con dos parametros
            // La ruta del programa de python y los numeros que se sumaran
            result = runPython.RunPythonConsole(@"pythonScript.py", numbersToAdd);

            // Imprimimos el resultado de la suma devuelto por python
            Console.WriteLine(result);
        }
    }
}
