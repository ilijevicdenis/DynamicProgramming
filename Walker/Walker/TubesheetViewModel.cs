using System;
using Walker.Interfaces;
using Walker.Model;

namespace Walker
{
    public sealed class TubesheetViewModel
    {
        private TubesheetModel _tubeSheetData;
        public TubesheetViewModel(ILoader<TubesheetModel> tubesheetData)
        {
            _tubeSheetData = tubesheetData.Load() ?? throw new ArgumentNullException(nameof(tubesheetData));
        }

        public TubesheetModel TubesheetData
        {
            get { return _tubeSheetData; }
        }        
    }
}
