using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Walker.Interfaces;
using Walker.Model;

namespace Walker.Tests.DataLoadTest
{
    [TestClass]
    public class TubeDataLoaderTests : DataLoadTestBase<TubesheetModel>
    {
        public override void LoaderContainsData() => Assert.IsTrue(Instance.Load().Tubes.Any());

        protected override ILoader<TubesheetModel> CreateInstance()
        {
            return Factory.TubesheetDal;
        }

        [TestMethod]
        public void TubeModelsHaveValidRowEntry() => Assert.IsTrue(Instance.Load().Tubes.All(tube => tube.Row > 0));

        [TestMethod]
        public void TubeModelsHaveValidColumnEntry() => Assert.IsTrue(Instance.Load().Tubes.All(tube => tube.Column > 0));

        [TestMethod]
        public void TubeModelsHaveNonEmptyStatusEntry() => Assert.IsTrue(Instance.Load().Tubes.All(tube => !string.IsNullOrEmpty(tube.Status)));

        [TestMethod]
        public void TubesheetModelHasDiameterValueGreaterThenZero() => Assert.IsTrue(Instance.Load().TubesheetDiameter > default(decimal));

        [TestMethod]
        public void TubesheetModelHasPitchValueGreaterThenZero() => Assert.IsTrue(Instance.Load().TubesheetPitch > default(decimal));
    }
}
