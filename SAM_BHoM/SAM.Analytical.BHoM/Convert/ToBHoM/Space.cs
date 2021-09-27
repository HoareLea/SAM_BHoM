using BH.oM.Environment.Elements;
using SAM.Geometry.BHoM;

namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Space ToBHoM(this Space space)
        {
            if(space == null)
            {
                return null;
            }

            BH.oM.Environment.Elements.Space result = new BH.oM.Environment.Elements.Space()
            {
                Location = space.Location?.ToBHoM(),
                Name = space.Name
            };

            return result;
        }

        public static BH.oM.Environment.Elements.Space ToBHoM(this Space space, AnalyticalModel analyticalModel)
        {
            if (space == null)
            {
                return null;
            }

            BH.oM.Environment.Elements.Space result = ToBHoM(space, analyticalModel?.AdjacencyCluster);

            return result;
        }

        public static BH.oM.Environment.Elements.Space ToBHoM(this Space space, AdjacencyCluster adjacencyCluster)
        {
            if (space == null)
            {
                return null;
            }

            Space space_Temp = adjacencyCluster?.GetObject<Space>(space.Guid);
            if (space_Temp == null)
            {
                space_Temp = space;
            }

            BH.oM.Environment.Elements.Space result = ToBHoM(space_Temp);

            return result;
        }
    }
}