using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSocialNetworkManager.Utilities.log
{
    public class LogText : ILog
    { 
        public void SaveLog(string action)
        {
            //print cambios
            //Directorio donde se esta ejecutando la aplicacion actualmente
            string logPath = Directory.GetCurrentDirectory()+@"\Log.txt";

            var streamWritter = new StreamWriter(logPath);  

            //Escribe una linea de texto completa 
            streamWritter.WriteLine($"{DateTime.Now} - {action}");
            streamWritter.Close();
        }
    }
}
