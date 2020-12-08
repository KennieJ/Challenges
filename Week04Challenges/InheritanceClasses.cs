using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Challenges
{
    abstract class ChemicalInventory
    {
        public string FullName { get; set; }
        public string CommonName { get; set; }
        public string Vendor { get; set; }
        public string LotNumber { get; set; }
        public bool InStock { get; set; }
        public string StorageLocation { get; set; }

        public ChemicalInventory() { }

        public ChemicalInventory(string fullName, string commonName, string vendor, string lotNumber, bool inStock, string storageLocation)
        {
            FullName = fullName;
            CommonName = commonName;
            Vendor = vendor;
            LotNumber = lotNumber;
            InStock = inStock;
            StorageLocation = storageLocation;
        }
    }

    class ReferenceStandards : ChemicalInventory
    {
        public bool IsDeuterated { get; set; }
        public string DrugClass { get; set; }

        public ReferenceStandards() { }
        public ReferenceStandards(string fullName, string commonName, string vendor, string lotNumber, bool inStock, string storageLocation, bool isDeuterated, string drugClass)
            :base(fullName, commonName, vendor, lotNumber, inStock, storageLocation)
        {
            IsDeuterated = isDeuterated;
            DrugClass = drugClass;
        }
    }

    class Reagents : ChemicalInventory
    {
        public bool UseInFumeHood { get; set; }
        public double LitersRemaining { get; set; }

        public Reagents() { }
        public Reagents(string fullName, string commonName, string vendor, string lotNumber, bool inStock, string storageLocation, bool useInFumeHood, double litersRemaining)
            :base(fullName, commonName, vendor, lotNumber, inStock, storageLocation)
        {
            UseInFumeHood = useInFumeHood;
            LitersRemaining = litersRemaining;
        }
    }

    class StockSolutions : ReferenceStandards
    {
        public bool PassedLotTest { get; set; }
        public DateTime PrepDate { get; set; }

        public StockSolutions() { }

        public StockSolutions(string fullName, string commonName, string vendor, string lotNumber, bool inStock, string storageLocation, bool isDeuterated,
            string drugClass, bool passedLotTest, DateTime prepDate)
            :base (fullName, commonName, vendor, lotNumber, inStock, storageLocation, isDeuterated, drugClass)
        {
            PassedLotTest = passedLotTest;
            PrepDate = prepDate;
        }
        
    }
}
