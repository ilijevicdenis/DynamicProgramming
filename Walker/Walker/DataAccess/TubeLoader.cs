using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using Walker.Interfaces;
using Walker.Model;

namespace Walker.DataAccess
{
    public sealed class TubeLoader : ILoader<TubesheetModel>
    {
        private const string DATA_DIR = "Data";
        private const string FILE_SOURCE = "Tubesheet.txt";
        public TubesheetModel Load()
        {
            var dataPath = Path.Combine(Directory.GetCurrentDirectory(), DATA_DIR, FILE_SOURCE);

            if(File.Exists(dataPath))
            {
                try
                {
                    var xmlData = XDocument.Load(dataPath).Root;
                    var tsDiameter = Convert.ToDecimal(xmlData.Element("TubesheetDiameter").Value);
                    var tsPitch = Convert.ToDecimal(xmlData.Element("TubesheetPitch").Value);
                    var tubes = xmlData.Element("Tubes").Elements("Tube")
                                .ToList()
                                .Select(tubeNode =>
                                {
                                    return new Tube
                                    (
                                           row: Convert.ToInt32(tubeNode.Element("Row").Value),
                                           col: Convert.ToInt32(tubeNode.Element("Column").Value),
                                           status: tubeNode.Element("Status").Value
                                    );
                                });

                    return new TubesheetModel(tsDiameter, tsPitch, tubes);
          
                }
                catch
                {
                    throw;
                }
            }
            else
                return null;
        }
    }
}
