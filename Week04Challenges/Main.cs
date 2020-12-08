using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week04Challenges
{
    [TestClass]
    public class Main
    {
        [TestMethod]
        public void InventoryTest()
        {
            var alpraz = new ReferenceStandards("Alprazolam", "Xanax", "Cerilliant", "FN195264802", true, "Freezer 1", false, "Benzodiazepines");
            var opiStock1 = new StockSolutions("Opioid Method Stock Solution", "OpiSS", "In-house", "20201206-OSS", true, "Freezer 2", false, "Opioids", true, DateTime.Today);

            var ACN = new Reagents();
            ACN.FullName = "Acetonitrile";
            ACN.InStock = true;
            ACN.LitersRemaining = 5.5;
            ACN.UseInFumeHood = true;
            ACN.StorageLocation = "Flammables Cabinet";
        }
    }
}
