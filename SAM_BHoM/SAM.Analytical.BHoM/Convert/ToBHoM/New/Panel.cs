using BH.Engine.Environment;

using SAM.Geometry.BHoM;
using System.Collections.Generic;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Panel ToBHoM(this IPartition partition)
        {
            Geometry.Spatial.Face3D face3D = partition?.Face3D;
            if(face3D == null)
            {
                return null;
            }

            Geometry.Spatial.Polygon3D polygon3D = face3D.GetExternalEdge3D() as Geometry.Spatial.Polygon3D;

            BH.oM.Environment.Elements.Panel result = new BH.oM.Environment.Elements.Panel
            {
                ExternalEdges = polygon3D.ToBHoM().ToEdges(),
            };

            if (partition is IHostPartition)
            {
                List<BH.oM.Environment.Elements.Opening> openings_BHoM = new List<BH.oM.Environment.Elements.Opening>();

                List<IOpening> openings = ((IHostPartition)partition).GetOpenings();
                if (openings != null && openings.Count > 0)
                    openings.ForEach(x => openings_BHoM.Add(x.ToBHoM()));

                result.Openings = openings_BHoM;
            }

            return result;
        }

        public static BH.oM.Environment.Elements.Panel ToBHoM(this IPartition partition, ArchitecturalModel architecturalModel)
        {
            if (partition == null || architecturalModel == null)
            {
                return null;
            }

            IPartition partition_Temp = architecturalModel?.GetObject<IPartition>(partition.Guid);
            if(partition_Temp == null)
            {
                return null;
            }

            BH.oM.Environment.Elements.Panel result = ToBHoM(partition_Temp);

            List<Space> spaces = architecturalModel.GetSpaces(partition_Temp);
            if (spaces != null)
            {
                result.ConnectedSpaces = spaces.ConvertAll(x => x.Name);
            }

            PartitionAnalyticalType partitionAnalyticalType = architecturalModel.PartitionAnalyticalType(partition_Temp);
            result.Type = partitionAnalyticalType.ToBHoM();

            return result;
        }
    }
}