using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ClienteForm
{
    public class LogWriter
    {

        private string Path = Directory.GetCurrentDirectory();
       

        public LogWriter() {
        }

        public void Add(string logMessage) {

            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

            cadena += DateTime.Now + " - " + logMessage + Environment.NewLine;

            StreamWriter sw = new StreamWriter(Path + "/" + nombre,true);
           
            sw.Write(cadena);
            sw.Close();
        }

        #region HELPER
        private string GetNameFile() {

            string nombre = "";
            nombre = "log_Imperio-" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.DayOfWeek + ".txt";
            return nombre;
        }

        private void CreateDirectory() {
            try
            {
                if (Directory.Exists(Path))
                {
                    Directory.CreateDirectory(Path);
                }
            
            }
            catch (DirectoryNotFoundException ex) {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
