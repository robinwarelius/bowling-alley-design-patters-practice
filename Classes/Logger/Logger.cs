using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BengansBowlingApplikation.Classes.Logger
{
    public sealed class Logger
    {
        private static Logger _instance;

        public static Logger GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Logger();
                }

                return _instance;
            }
        }

        public void WriteLog(string message)
        {         
            string logPath = ConfigurationManager.AppSettings["logPath"];
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($" {DateTime.Now} : {message}");
            }

            //Debug.WriteLine(message);
        }

    }
}



