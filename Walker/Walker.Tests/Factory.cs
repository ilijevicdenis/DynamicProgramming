using Walker.DataAccess;
using Walker.Interfaces;
using Walker.Model;

namespace Walker.Tests
{
    
    internal static class Factory
    {
        private static ILoader<TubesheetModel> _tubeSheetModelLoader;

        public static ILoader<TubesheetModel> TubesheetDal => _tubeSheetModelLoader ?? (_tubeSheetModelLoader = new TubeLoader());
    }
}
