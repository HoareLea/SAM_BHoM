using BH.oM.Geometry;

namespace SAM.Geometry.BHoM
{
    public static partial class Convert
    {
        public static Spatial.Point3D ToSAM(this Point point)
        {
            return new Spatial.Point3D
            {
                X = point.X,
                Y = point.Y,
                Z = point.Z,
            };
        }
    }
}
