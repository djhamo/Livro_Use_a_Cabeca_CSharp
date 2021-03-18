using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace DogDoorSimulator
{
    class INIFile
    {
        static readonly INIFile _instance = new INIFile();

        public INIFile()
        {
            if (File.Exists("Dados.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Config));
                using (TextReader reader = new StreamReader("Dados.xml"))
                {
                    _dd = serializer.Deserialize(reader) as Config;
                }
            }
            else
            {
                _dd = new Config();
                Save();
            }
        }

        public static INIFile Instance
        {
            get
            {
                return _instance;
            }
        }

        public static Config getConfig
        {
            get
            {
                return _dd;
            }
        }

        public static void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Config));
            using (TextWriter writer = new StreamWriter("Dados.xml"))
            {
                serializer.Serialize(writer, _dd);
            }
        }

        public static Config _dd { get; private set; }

    }

    [XmlRoot("Config")]
    public class Config
    {
        [XmlElement("Auto_Close")]
        public bool AutoClose { get; set; }
        [XmlElement("Time_Auto_Close")]
        public int TimeAutoClose { get; set; }

        public Config()
        {
            AutoClose = true;
            TimeAutoClose = 5000;
        }

    }
}
