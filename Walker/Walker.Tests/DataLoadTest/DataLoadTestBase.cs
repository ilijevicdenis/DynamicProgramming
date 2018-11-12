using Microsoft.VisualStudio.TestTools.UnitTesting;
using Walker.Interfaces;

namespace Walker.Tests.DataLoadTest
{
    [TestClass]
    public abstract class DataLoadTestBase<T> where  T : class
    {
        protected ILoader<T> Instance { get; private set; }

        public DataLoadTestBase()
        {
            Instance = CreateInstance();
        }
        protected abstract ILoader<T> CreateInstance();

        [TestMethod]
        public void LoaderInstanceIsCreated() => Assert.IsNotNull(Instance);

        [TestMethod]
        public abstract void LoaderContainsData();
       
    }
}
