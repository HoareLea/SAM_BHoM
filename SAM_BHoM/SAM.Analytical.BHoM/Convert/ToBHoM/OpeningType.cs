using BH.oM.Environment.Elements;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.OpeningType ToBHoM(this ApertureType apertureType)
        {
            switch (apertureType)
            {
                case ApertureType.Window:
                    return BH.oM.Environment.Elements.OpeningType.Window;

                case ApertureType.Door:
                    return BH.oM.Environment.Elements.OpeningType.Door;
            }

            return BH.oM.Environment.Elements.OpeningType.Undefined;
        }
    }
}