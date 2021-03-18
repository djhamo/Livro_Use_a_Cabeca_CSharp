using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace YeldTest
{
    [DataContract(Name = "Guy", Namespace = "http://www.headfirst.com")]
    class SerializableGuy
    {
        [DataMember]
        public string Name { get; private set; }

        [DataMember]
        public int Age { get; private set; }

        [DataMember]
        public int Cash { get; private set; }

        [DataMember]
        private int secretNumberOne = new Random().Next();

        private int secretNumberTwo = new Random().Next();

        public SerializableGuy(string name, int age, int cash)
        {
            Name = name;
            Age = age;
            Cash = cash;
        }

        public override string ToString()
        {
            return String.Format("{0} tem {1} anos e possui R$ {2} - segredos: {3}-{4}",
                Name, Age, Cash, secretNumberOne, secretNumberTwo);
        }
    }

}
