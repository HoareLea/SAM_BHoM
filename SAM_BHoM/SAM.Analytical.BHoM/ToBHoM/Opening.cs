﻿using BH.Engine.Environment;

using SAM.Geometry.BHoM;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        /// <summary>
        /// Converts SAM Aperture to BHoM opening.
        /// </summary>
        /// <param name="aperture">The aperture.</param>
        /// <returns name="opening">BHoM opening <see cref="BH.oM.Environment.Elements.Opening"/></returns>
        public static BH.oM.Environment.Elements.Opening ToBHoM(this Aperture aperture)
        {
            PlanarBoundary3D planarBoundary3D = aperture.PlanarBoundary3D;
            Geometry.Spatial.Face3D face3D = planarBoundary3D.GetFace3D();
            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge3D() as Geometry.Spatial.Polygon3D;

            return new BH.oM.Environment.Elements.Opening
            {
                Edges = polygon3D.ToBHoM().ToEdges(),
                Type = aperture.ApertureConstruction.ApertureType.ToBHoM()
            };
        }
    }
}