using BH.Engine.Environment;

using SAM.Geometry.BHoM;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts SAM Aperture to BHoM opening.
        /// </summary>
        /// <param name="opening">SAM Analytical Opening</param>
        /// <returns name="opening">BHoM opening <see cref="BH.oM.Environment.Elements.Opening"/></returns>
        public static BH.oM.Environment.Elements.Opening ToBHoM(this IOpening opening)
        {
            BH.oM.Environment.Elements.OpeningType? openingType = opening?.OpeningType();
            if (openingType == null || !openingType.HasValue)
            {
                return null;
            }

            Geometry.Spatial.Face3D face3D = opening.Face3D;
            if(face3D == null)
            {
                return null;
            }

            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge3D() as Geometry.Spatial.Polygon3D;

            return new BH.oM.Environment.Elements.Opening
            {
                Edges = polygon3D.ToBHoM().ToEdges(),
                Type = openingType.Value
            };
        }
    }
}