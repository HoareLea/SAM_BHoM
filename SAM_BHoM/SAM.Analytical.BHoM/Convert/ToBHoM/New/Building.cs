using BH.oM.Environment.Elements;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static Building ToBHoM(this BuildingModel buildingModel)
        {
            if(buildingModel == null)
            {
                return null;
            }

            Building result = new Building()
            {
                Location = Core.BHoM.Convert.ToBHoM(buildingModel.Location),
                Elevation = buildingModel.Location.Elevation
            };

            return result;
        }
    }
}