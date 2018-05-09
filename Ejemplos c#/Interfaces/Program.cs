using System;
using System.Collections.Generic;

namespace Interfaces
{
    class Program
    {

        static void Main(string[] args)
        {
            List<ILogger> loggers = new List<ILogger>();

            loggers.Add(new DatabaseLogger());

            loggers.Add(new ConsoleLogger());

            MetodoQueHaceAlgo(loggers);

            try
            {
                // Este metodo muere y queremos lograr la excepcion
                throw new ArgumentNullException();
            }
            catch(ArgumentNullException ex)
            {
                // se ha producido un error de argumento nulo, quiero guardar el error
                foreach (var logger in loggers)
                {
                    logger.LogError(ex.Message);
                }
            }
        }

        private static void MetodoQueHaceAlgo(List<ILogger> loggers)
        {
            foreach (var logger in loggers)
            {
                logger.LogInfo("He usado el MetodoQueHaceAlgo");
            }
        }
    }


    public interface ILogger
    {
        void LogError(string LogMessage);

        void LogInfo(string LogMessage);

        string GetStorage();
    }

    public class DatabaseLogger : ILogger
    {
        public string GetStorage()
        {
            return "Database";
        }

        public void LogError(string LogMessage)
        {
            Console.WriteLine("Error guardado en DB: " + LogMessage);
        }

        public void LogInfo(string LogMessage)
        {
            Console.WriteLine("Informacion guardada en DB: " + LogMessage);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public string GetStorage()
        {
            return "Console";
        }

        public void LogError(string LogMessage)
        {
            Console.WriteLine("Error volcado en consola: " + LogMessage);
        }

        public void LogInfo(string LogMessage)
        {
            Console.WriteLine("Informacion volcada en consola: " + LogMessage);
        }
    }

}


