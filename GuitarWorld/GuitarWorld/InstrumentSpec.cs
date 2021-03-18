using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld
{
    class InstrumentSpec
    {
        public Dictionary<string, string> properties { get; private set; }

        public InstrumentSpec(Dictionary<string, string> properties)
        {
            if (properties == null)
            {
                this.properties = new Dictionary<string, string>();
            }        
            else
            {
                this.properties = new Dictionary<string, string>(properties);
            }
        }

        public string getProperty(string propertyName)
        {
            return properties[propertyName];
        }


        public override bool Equals(object obj)
        {
            bool equal = false;
            if (obj is InstrumentSpec)
            {
                InstrumentSpec mSpec = obj as InstrumentSpec;

                if (properties.Count == mSpec.properties.Count)
                {
                    equal = true;
                    foreach (var pair in properties)
                    {
                        string value;
                        if (mSpec.properties.TryGetValue(pair.Key, out value))
                        {
                            // Require value be equal.
                            if (value.ToLower() != pair.Value.ToLower())
                            {
                                equal = false;
                                break;
                            }
                        }
                        else
                        {
                            // Require key be present.
                            equal = false;
                            break;
                        }
                    }
                }
            }
            return equal;
        }

        public static bool operator ==(InstrumentSpec x, InstrumentSpec y)
        {
            return x.Equals(y);
        }

        public static bool operator !=(InstrumentSpec x, InstrumentSpec y)
        {
            return !(x.Equals(y));
        }

        public override string ToString()
        {
            string result = "";
            foreach (var pair in properties)
            {
                result += String.Format("{0}: {1} \n", pair.Key, pair.Value);
            }
            return result;
        }
    }
}
