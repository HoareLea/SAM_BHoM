using Grasshopper.Kernel;
using SAM.Analytical.Grasshopper.BHoM.Properties;
using SAM.Core;
using System;

namespace SAM.Analytical.Grasshopper.BHoM
{
    public class SAMAnalyticalBHoM : GH_Component
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f3018f46-4706-4ea0-beb3-1fbca8b6ed47");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon => Resources.SAM_BHoM;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SAMAnalyticalBHoM()
          : base("SAMAnalytical.BHoM", "SAMAnalytical.BHoM",
              "Convert SAM Analytical Object ie. Panel, Space to BHoM",
              "SAM", "BHoM")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            inputParamManager.AddParameter(new Core.Grasshopper.GooSAMObjectParam<SAMObject>(), "_SAMAnalytical", "_SAMAnalytical", "SAM Analytical Object", GH_ParamAccess.item);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            outputParamManager.AddGenericParameter("BHoM", "BHoM", "BHoM Object", GH_ParamAccess.list);
        }

        /// <summary>
        /// Solves the instance.
        /// </summary>
        /// <param name="dataAccess">The data access.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            SAMObject sAMObject = null;
            if (!dataAccess.GetData(0, ref sAMObject) || sAMObject == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            if (sAMObject is Panel)
            {
                dataAccess.SetData(0, Analytical.BHoM.Convert.ToBHoM(((Panel)sAMObject)));
                return;
            }

            AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
        }
    }
}