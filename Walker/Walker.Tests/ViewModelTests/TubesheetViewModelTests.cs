using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Walker.Tests.WalkerViewModelTests
{
    [TestClass]
    public class TubesheetViewModelTests
    {
        private readonly TubesheetViewModel _instance;
        public TubesheetViewModelTests()
        {
            _instance = new TubesheetViewModel(Factory.TubesheetDal);
        }

        //[DataRow("Unknown",  Constants.GRAY_COLOR)]
        //[DataRow("Plugged",  Constants.BLACK_COLOR)]
        //[DataRow("Critical", Constants.RED_COLOR)]
        //[DataTestMethod]
        //public void TubeColorIsResolvedForGivenStatus(string status, string colorName)
        //{
        //    var tube = _instance.TubesheetData
        //               .Tubes
        //               .FirstOrDefault(t => string.Compare(t.Status, status, true, CultureInfo.InvariantCulture) == 0);

        //    Assert.AreEqual(colorName, _instance.Colorize(tube).Name);
        //}
    }
}
