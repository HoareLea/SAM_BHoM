
namespace SAM.Architectural.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Geometry.SettingOut.Level ToBHoM(this Level level)
        {
            if (level == null)
                return null;
            
            return new BH.oM.Geometry.SettingOut.Level
            {
                Name = level.Name,
                Elevation = level.Elevation
            };
        }
    }
}