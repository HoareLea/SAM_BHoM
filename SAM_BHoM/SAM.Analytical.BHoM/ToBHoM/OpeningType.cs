using BH.oM.Environment.Elements;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static OpeningType ToBHoM(this ApertureType apertureType)
        {
            switch(apertureType)
            {
                case ApertureType.Window:
                    return OpeningType.Window;
                case ApertureType.Door:
                    return OpeningType.Door;
            }

            return OpeningType.Undefined;
        }
    }
}
