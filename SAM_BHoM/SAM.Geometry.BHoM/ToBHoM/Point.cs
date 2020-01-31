using BH.oM.Geometry;

namespace SAM.Geometry.BHoM
{
    public static partial class Convert
    {
        public static Point ToBHoM(this Spatial.Point3D point3D)
        {
            return new Point
            {
                X = point3D.X,
                Y = point3D.Y,
                Z = point3D.Z,
            };
        }
    }
}
