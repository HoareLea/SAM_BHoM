namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Space ToBHoM(this Space space, BuildingModel buildingModel)
        {
            if (space == null)
            {
                return null;
            }

            Space space_Temp = buildingModel?.GetObject<Space>(space.Guid);
            if (space_Temp == null)
            {
                space_Temp = space;
            }

            BH.oM.Environment.Elements.Space result = ToBHoM(space_Temp);

            return result;
        }
    }
}