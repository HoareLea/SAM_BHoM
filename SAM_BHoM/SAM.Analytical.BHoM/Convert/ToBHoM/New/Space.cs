namespace SAM.Analytical.BHoM
{
    public static partial class Convert
    {
        public static BH.oM.Environment.Elements.Space ToBHoM(this Space space, ArchitecturalModel architecturalModel)
        {
            if (space == null)
            {
                return null;
            }

            Space space_Temp = architecturalModel?.GetObject<Space>(space.Guid);
            if (space_Temp == null)
            {
                space_Temp = space;
            }

            BH.oM.Environment.Elements.Space result = ToBHoM(space_Temp);

            return result;
        }
    }
}