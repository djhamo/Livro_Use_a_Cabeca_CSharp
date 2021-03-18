using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GenDicXML
{
    [XmlRoot("Dictionary")]
    public class SerializableDictionary<TKey, TValue>
        : Dictionary<TKey, TValue>, IXmlSerializable
    {
        #region IXmlSerializable Members
        public System.Xml.Schema.XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(System.Xml.XmlReader reader)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            bool wasEmpty = reader.IsEmptyElement;
            reader.Read();

            if (wasEmpty)
                return;

            while (reader.NodeType != System.Xml.XmlNodeType.EndElement)
            {
                reader.ReadStartElement("item");

                reader.ReadStartElement("key");
                TKey key = (TKey)keySerializer.Deserialize(reader);
                reader.ReadEndElement();

                reader.ReadStartElement("value");
                TValue value = (TValue)valueSerializer.Deserialize(reader);
                reader.ReadEndElement();

                this.Add(key, value);

                reader.ReadEndElement();
                reader.MoveToContent();
            }
            reader.ReadEndElement();
        }

        public void WriteXml(System.Xml.XmlWriter writer)
        {
            XmlSerializer keySerializer = new XmlSerializer(typeof(TKey));
            XmlSerializer valueSerializer = new XmlSerializer(typeof(TValue));

            foreach (TKey key in this.Keys)
            {
                writer.WriteStartElement("item");

                writer.WriteStartElement("key");
                keySerializer.Serialize(writer, key);
                writer.WriteEndElement();

                writer.WriteStartElement("value");
                TValue value = this[key];
                valueSerializer.Serialize(writer, value);
                writer.WriteEndElement();

                writer.WriteEndElement();
            }
        }
        #endregion
    }

    public class RebuDetail
    {
        [XmlAttribute("RebuID")]
        public int RebuId { get; set; }

        [XmlElement("Data")]
        public string Data { get; set; }

        [XmlElement("OcorrenciaInicial")]
        public string OcorrenciaInicial { get; set; }

        [XmlElement("Detalhes")]
        //public Dictionary<int, RebuStepDetail> detalhes = new Dictionary<int, RebuStepDetail>();
        public SerializableDictionary<int, RebuStepDetail> detalhes = new SerializableDictionary<int, RebuStepDetail>();

        public override string ToString()
        {
            return String.Format("{0} - {1} ", RebuId, OcorrenciaInicial);
        }

        public override bool Equals(object obj)
        {
            if (obj is RebuDetail)
            {
                return this.RebuId == (obj as RebuDetail).RebuId;
            }
            return false;
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

        [XmlText]
        public string Ocorrencia { get; set; }
    }

    [XmlRoot("Rebu")]
    public class DadosXML
    {
        [XmlElement("Proprietario")]
        public string DirectoryOwner { get; set; }

        [XmlElement("Rebus")]
        //public Dictionary<int, RebuDetail> rebus = new Dictionary<int, RebuDetail>();
        public SerializableDictionary<int, RebuDetail> rebus = new SerializableDictionary<int, RebuDetail>();

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

}
