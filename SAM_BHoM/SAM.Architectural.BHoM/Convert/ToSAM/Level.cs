
namespace SAM.Architectural.BHoM
{
    public static partial class Convert
    {
        public static Level ToSAM(this BH.oM.Geometry.SettingOut.Level level)
        {
            if (level == null)
                return null;

            return new Level(level.Name, level.Elevation);
        }
    }
}