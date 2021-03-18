using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;


namespace GuitarWorld
{

    public enum InstrumentType
    {
        Guitar,
        Banjo,
        Dobro,
        Fiddle,
        Bass,
        Manodlin,
        Unspecified,
    }

    public enum Style
    {
        A,
        F,
    }

    public enum TypeGuitar
    {
        [Description("Acoustic")]
        ACOUSTIC,
        [Description("Electric")]
        ELECTRIC,
    }

    public enum Builder
    {
        [Description("Fender")]
        FENDER,
        [Description("Martin")]
        MARTIN,
        [Description("Gibson")]
        GIBSON,
        [Description("Collins")]
        COLLINGS,
        [Description("Olson")]
        OLSON,
        [Description("Ryan")]
        RYAN,
        [Description("Prs")]
        PRS,
        [Description("Any")]
        ANY,
    }

    public enum Wood
    {
        [Description("Indian Rosewood")]
        INDIAN_ROSEWOOD,
        [Description("Brazilian Rosewood")]
        BRAZILIAN_ROSEWOOD, 
        [Description("Mahogany")]
        MAHOGANY, 
        [Description("Maple")]
        MAPLE, 
        [Description("Cocobolo")]
        COCOBOLO, 
        [Description("Cedar")]
        CEDAR, 
        [Description("Adirondack")]
        ADIRONDACK,
        [Description("Alder")]
        ALDER, 
        [Description("Sitka")]
        SITKA,
        [Description("Bordo")]
        BORDO,
    }

    class Types
    {
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes =
                (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }

        public static IEnumerable<T> EnumToList<T>()
        {
            Type enumType = typeof(T);

            // Can't use generic type constraints on value types,
            // so have to do check like this
            if (enumType.BaseType != typeof(Enum))
                throw new ArgumentException("T must be of type System.Enum");

            Array enumValArray = Enum.GetValues(enumType);
            List<T> enumValList = new List<T>(enumValArray.Length);

            foreach (int val in enumValArray)
            {
                enumValList.Add((T)Enum.Parse(enumType, val.ToString()));
            }

            return enumValList;
        }
    }
}
