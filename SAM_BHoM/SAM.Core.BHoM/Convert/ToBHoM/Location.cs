

namespace SAM.Core.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Climate.Location ToBHoM(this Location location)
        {
            if(location == null)
            {
                return null;
            }

            BH.oM.Environment.Climate.Location result = new BH.oM.Environment.Climate.Location()
            {
                Latitude = location.Latitude,
                Longitude = location.Longitude,
                Elevation = location.Elevation
            };

            return result;
        }
    }
}