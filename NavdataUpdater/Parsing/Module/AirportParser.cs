using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanielSchiffer.HCS.Logic.NavdataUpdater.Parsing.Module
{
    public class AirportParser
    {
        private string fileName = "apts.txt";
        private string _path;
        public AirportParser(string path)
        {
            _path = System.IO.Path.Combine(path,fileName);
        }

        public async void StartParsing()
        {
            Console.WriteLine("AirportParsing started");

        }
    }
}
