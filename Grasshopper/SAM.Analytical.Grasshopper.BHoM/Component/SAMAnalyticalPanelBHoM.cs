using System;

using Grasshopper.Kernel;
using Grasshopper.Kernel.Types;

using SAM.Core;
using SAM.Analytical.Grasshopper.BHoM.Properties;
using System.Collections.Generic;

namespace SAM.Analytical.Grasshopper.BHoM
{
    public class SAMAnalyticalPanelBHoM : GH_Component
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("f3018f46-4706-4ea0-beb3-1fbca8b6ed49");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        protected override System.Drawing.Bitmap Icon => Resources.SAM_BHoM;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public SAMAnalyticalPanelBHoM()
          : base("SAMAnalyticalPanel.BHoM", "SAMAnalyticalPanel.BHoM",
              "Convert SAM Analytical Panel, Space to BHoM",
              "SAM", "BHoM")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override void RegisterInputParams(GH_InputParamManager inputParamManager)
        {
            int index;

            index = inputParamManager.AddParameter(new GooPanelParam(), "_panel", "_panel", "SAM Analytical Panel", GH_ParamAccess.item);
            inputParamManager[index].DataMapping = GH_DataMapping.Graft;

            inputParamManager.AddTextParameter("_connectedSpaces", "_connectedSpaces", "Connected Spaces Names", GH_ParamAccess.list);
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override void RegisterOutputParams(GH_OutputParamManager outputParamManager)
        {
            outputParamManager.AddGenericParameter("BHoMPanel", "BHoMPanel", "BHoM Panel", GH_ParamAccess.item);
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">The DA object is used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            Panel panel = null;
            if (!dataAccess.GetData(0, ref panel) || panel == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            List<string> connectedSpaces = new List<string>();
            if (!dataAccess.GetDataList(1, connectedSpaces) || connectedSpaces == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            dataAccess.SetData(0, Analytical.BHoM.Convert.ToBHoM(panel, connectedSpaces));
            return;
        }
    }
}