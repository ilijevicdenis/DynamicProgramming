using System.Collections.Generic;
using Walker.DataAccess;
using Walker.Interfaces;
using Walker.Model;

namespace Walker.Tests
{

    internal static class Factory
    {
        private static ILoader<TubesheetModel> _tubeSheetModelLoader;

        internal static ILoader<TubesheetModel> TubesheetDal => _tubeSheetModelLoader ?? (_tubeSheetModelLoader = new TubeLoader());

        internal static TubeFinder TubeFinder => new TubeFinder(
            new Tubes(
                new List<Tube>
                    {
                        new Tube(1, 2, "Unknown"),
                        new Tube(1, 5, "Unknown"),
                        new Tube(1, 1, "Unknown"),
                        new Tube(1, 4, "Unknown"),
                        new Tube(1, 3, "Unknown"),
                        new Tube(1, 6, "Unknown")
                    }));
    }
}
