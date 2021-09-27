using BH.oM.Environment.Elements;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static Building ToBHoM(this AnalyticalModel analyticalModel)
        {
            if(analyticalModel == null)
            {
                return null;
            }

            Building result = new Building()
            {
                Location = Core.BHoM.Convert.ToBHoM(analyticalModel.Location),
                Elevation = analyticalModel.Location.Elevation
            };

            return result;
        }
    }
}