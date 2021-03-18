using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarWorld
{
    class Factory
    {
        public static InstrumentSpec newGuitarSpec(Builder builder, string model, TypeGuitar typeGuitar, int numString, Wood topWood, Wood backWood)
        {
            Dictionary<string, string> prop = new Dictionary<string, string>();
            prop.Add("InstrumentType", Types.GetEnumDescription(InstrumentType.Guitar));
            prop.Add("Builder", Types.GetEnumDescription(builder));
            prop.Add("Model", model);
            prop.Add("Type", Types.GetEnumDescription(typeGuitar));
            prop.Add("NumString", numString.ToString());
            prop.Add("TopWood", Types.GetEnumDescription(topWood));
            prop.Add("BackWood", Types.GetEnumDescription(backWood));

            InstrumentSpec result = new InstrumentSpec(prop);
            return result;
        }

        public static InstrumentSpec newBanjoSpec(Builder builder, string model, TypeGuitar type, int numString, Wood backWood)
        {
            Dictionary<string, string> prop = new Dictionary<string, string>();
            prop.Add("InstrumentType", Types.GetEnumDescription(InstrumentType.Banjo));
            prop.Add("Builder", Types.GetEnumDescription(builder));
            prop.Add("Model", model);
            prop.Add("Type", Types.GetEnumDescription(type));
            prop.Add("NumString", numString.ToString());
            prop.Add("BackWood", Types.GetEnumDescription(backWood));

            InstrumentSpec result = new InstrumentSpec(prop);
            return result;
        }

        public static InstrumentSpec newMandolinSpec(Builder builder, string model, TypeGuitar type, Wood topWood, Wood backWood)
        {
            Dictionary<string, string> prop = new Dictionary<string, string>();
            prop.Add("InstrumentType", Types.GetEnumDescription(InstrumentType.Banjo));
            prop.Add("Builder", Types.GetEnumDescription(builder));
            prop.Add("Model", model);
            prop.Add("Type", Types.GetEnumDescription(type));
            prop.Add("TopWood", Types.GetEnumDescription(topWood));
            prop.Add("BackWood", Types.GetEnumDescription(backWood));

            InstrumentSpec result = new InstrumentSpec(prop);
            return result;
        }

    }
}
