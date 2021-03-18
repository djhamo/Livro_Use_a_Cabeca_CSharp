using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace GenDicXML
{
    class Program
    {
        static void Main(string[] args)
        {
            DadosXML nData = new DadosXML();
            nData.UltimoID = 0;

            nData.DirectoryOwner = "Luciana Satie Oguma";

            RebuDetail rebu = new RebuDetail();
            rebu.RebuId = nData.UltimoID;
            int RebuIDTest = rebu.RebuId;
            rebu.Data = "01/04/2015";
            rebu.OcorrenciaInicial = "A Internet caiu";

            RebuStepDetail step = new RebuStepDetail();
            step.RebuStepId = nData.UltimoID;
            step.Data = "03/04/2015";
            step.Ocorrencia = "Os caras deram uma de João sem braço";

            //rebu.detalhes.Add(step.RebuStepId, step);
            rebu.detalhes.Add(step.RebuStepId, step);

            step = new RebuStepDetail();
            step.RebuStepId = nData.UltimoID;
            step.Data = "04/04/2015";
            step.Ocorrencia = "O Cara veio e arrumou";

            //rebu.detalhes.Add(step.RebuStepId, step);
            rebu.detalhes.Add(step.RebuStepId, step);

            //dd.rebus.Add(rebu.RebuId, rebu);
            nData.rebus.Add(rebu.RebuId, rebu);

            XmlSerializer serializer = new XmlSerializer(typeof(DadosXML));
            using (TextWriter writer = new StreamWriter("Dados.xml"))
            {
                serializer.Serialize(writer, nData);
            }

            //XmlSerializer serializer = new XmlSerializer(typeof(DadosXML));
            using (TextReader reader = new StreamReader("Dados.xml"))
            {
                nData = serializer.Deserialize(reader) as DadosXML;
            }

            RebuDetail temp = nData.rebus[RebuIDTest];
            Console.WriteLine("Rebu {0}", temp);
            Console.ReadLine();
        }
    }
}
