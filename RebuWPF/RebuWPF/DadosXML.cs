using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;

namespace RebuWPF
{
    public class DataBB
    {
        static readonly DataBB _instance = new DataBB();

        public DataBB() 
        {
            if (File.Exists("Dados.xml")) 
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DadosXML));
                using (TextReader reader = new StreamReader("Dados.xml"))
                {
                    _dd = serializer.Deserialize(reader) as DadosXML;
                }
            }
            else
            {
                _dd = new DadosXML();
            }
        }

        public static DataBB Instance
        {
            get
            {
                return _instance;
            }
        }

        public static DadosXML Database
        {
            get
            {
                return _dd;
            }
        }

        public static void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(DadosXML));
            using (TextWriter writer = new StreamWriter("Dados.xml"))
            {
                serializer.Serialize(writer, _dd);
            }
        }

        public static DadosXML _dd { get; private set; }
    }

    [XmlRoot("Rebu")]
    public class DadosXML
    {
        [XmlElement("Proprietario")]
        public string DirectoryOwner { get; set; }

        [XmlElement("Rebus")]
        //public Dictionary<int, RebuDetail> rebus = new Dictionary<int, RebuDetail>();
        public List<RebuDetail> rebus = new List<RebuDetail>();

        [XmlElement("Empresas")]
        //public Dictionary<int, EmpresaDetail> empresas = new Dictionary<int, EmpresaDetail>();
        public List<EmpresaDetail> empresas = new List<EmpresaDetail>();

        private int _ultimoID;
        [XmlElement("UltimoID")]
        public int UltimoID
        {
            get
            {
                _ultimoID++;
                return _ultimoID;
            }
            set
            {
                _ultimoID = value;
            }
        }
    }

    public class RebuDetail
    {
        [XmlAttribute("RebuID")]
        public int RebuId { get; set; }

        [XmlElement("Data")]
        public string Data { get; set; }

        [XmlElement("Empresa")]
        public EmpresaDetail mEmpresa { get; set; }

        [XmlElement("OcorrenciaInicial")]
        public string OcorrenciaInicial { get; set; }

        [XmlElement("Detalhes")]
        //public Dictionary<int, RebuStepDetail> detalhes = new Dictionary<int, RebuStepDetail>();
        public List<RebuStepDetail> detalhes = new List<RebuStepDetail>();

        public override string ToString()
        {
            string saida = String.Format("{0} - {1} - {2} - {3}", RebuId, Data, mEmpresa, OcorrenciaInicial);
            foreach (RebuStepDetail step in detalhes)
            {
                saida += " { ";
                saida += step;
                saida += " } ";
            }
            return saida;
        }

        public override bool Equals(object obj)
        {
            if (obj is RebuDetail)
            {
                return this.RebuId == (obj as RebuDetail).RebuId;
            }
            return false;
        }

        public static bool operator ==(RebuDetail x, int _id)
        {
            return x.RebuId == _id;
        }

        public static bool operator !=(RebuDetail x, int _id)
        {
            return x.RebuId == _id;
        }

        public override int GetHashCode()
        {
            return this.RebuId;
        }

    }

    public class EmpresaDetail
    {
        [XmlAttribute("EmpresaID")]
        public int EmpresaId { get; set; }

        [XmlAttribute("Nome")]
        public string Nome { get; set; }

        [XmlAttribute("Telefone")]
        public string Telefone { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} ", Nome, Telefone);
        }

        public override bool Equals(object obj)
        {
            if (obj is EmpresaDetail)
            {
                return this.EmpresaId == (obj as EmpresaDetail).EmpresaId;
            }
            return false;
        }

        public static bool operator ==(EmpresaDetail x, int _id)
        {
            return x.EmpresaId == _id;
        }

        public static bool operator !=(EmpresaDetail x, int _id)
        {
            return x.EmpresaId == _id;
        }

        public override int GetHashCode()
        {
            return this.EmpresaId;
        }
    }

    public class RebuStepDetail
    {
        [XmlAttribute("RebuStepID")]
        public int RebuStepId { get; set; }

        [XmlElement("Data")]
        public string Data { get; set; }

        [XmlElement("Protocolo")]
        public string Protocolo { get; set; }

        [XmlElement("Atendente")]
        public string Atendente { get; set; }

        [XmlText]
        public string Ocorrencia { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {2} - {3}", RebuStepId, Data, Protocolo, Ocorrencia);
        }

        public override bool Equals(object obj)
        {
            if (obj is RebuStepDetail)
            {
                return this.RebuStepId == (obj as RebuStepDetail).RebuStepId;
            }
            return false;
        }

        public static bool operator ==(RebuStepDetail x, int _id)
        {
            return x.RebuStepId == _id;
        }

        public static bool operator !=(RebuStepDetail x, int _id)
        {
            return x.RebuStepId == _id;
        }

        public override int GetHashCode()
        {
            return this.RebuStepId;
        }
    }
}

/*
            serializerXXX = new XmlSerializer(typeof(AddressDirectory));
            using (TextWriter writer = new StreamWriter("Address2.xml"))
            {
                serializerXXX.Serialize(writer, AddressListTTT);
            }

            using (TextReader reader = new StreamReader("Address2.xml"))
            {
                AddressListTTT = serializerXXX.Deserialize(reader) as AddressDirectory;
            }
*/