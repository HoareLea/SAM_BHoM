using BH.oM.Environment.Elements;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static Building ToBHoM(this ArchitecturalModel architecturalModel)
        {
            if(architecturalModel == null)
            {
                return null;
            }

            Building result = new Building()
            {
                Location = Core.BHoM.Convert.ToBHoM(architecturalModel.Location),
                Elevation = architecturalModel.Location.Elevation
            };

            return result;
        }
    }
}