using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class Supplier
    {
        public int SupplierID { get; private set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        private static string dataDirectory = "../../../Data/";
        private static string suppliersFilePath = Path.Combine(dataDirectory, "suppliers.csv");
        public Supplier(int supplierId, string name, string contactInfo)
        {
            SupplierID = supplierId;
            Name = name;
            ContactInfo = contactInfo;
        }

        public static bool AddSupplier(Supplier supplier, List<Supplier> suppliers)
        {
            try
            {
                suppliers.Add(supplier);
                List<string[]> data = suppliers.Select(s => s.ToCSV()).ToList();
                FileManager.WriteData(suppliersFilePath, data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the supplier: {ex.Message}");
                return false;
            }
        }
        public static bool EditSupplier(int supplierId, string newName, string newContactInfo, List<Supplier> suppliers)
        {
            try
            {
                Supplier supplier = suppliers.Find(s => s.SupplierID == supplierId);
                if (supplier != null)
                {
                    supplier.Name = newName;
                    supplier.ContactInfo = newContactInfo;
                    List<string[]> data = suppliers.Select(s => s.ToCSV()).ToList();
                    FileManager.WriteData(suppliersFilePath, data); // Save changes to CSV
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while editing the supplier: {ex.Message}");
                return false;
            }
        }

        public static bool DeleteSupplier(int supplierId, List<Supplier> suppliers)
        {
            try
            {
                Supplier supplier = suppliers.Find(s => s.SupplierID == supplierId);
                if (supplier != null)
                {
                    suppliers.Remove(supplier);
                    List<string[]> data = suppliers.Select(s => s.ToCSV()).ToList();
                    FileManager.WriteData(suppliersFilePath, data); // Save changes to CSV
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the supplier: {ex.Message}");
                return false;
            }
        }
        public static List<Supplier> LoadSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();
            List<string[]> data = FileManager.ReadData(suppliersFilePath);

            foreach (var record in data.Skip(1))
            {
                suppliers.Add(new Supplier(
                    supplierId: int.Parse(record[0]),
                    name: record[1],
                    contactInfo: record[2]
                ));
            }

            return suppliers;
        }

        public string[] ToCSV()
        {
            return new string[]
            {
                SupplierID.ToString(),
                Name,
                ContactInfo
            };
        }

    }
}
