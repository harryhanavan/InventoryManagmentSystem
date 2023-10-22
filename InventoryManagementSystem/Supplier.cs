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
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Category { get; set; } // Updated to Category from ContactInfo
        public string Address { get; set; } // Street Number, Name and State
        private static string dataDirectory = "../../../Data/";
        private static string suppliersFilePath = Path.Combine(dataDirectory, "suppliers.csv");
        public Supplier(int supplierId, string name, string emailAddress, string phoneNumber, string category, string address)
        {
            SupplierID = supplierId;
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Category = category;
            Address = address;
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
        public static bool EditSupplier(int supplierId, string newName, string newEmailAddress,
            string newPhoneNumber, string newCategory, string newAddress, List<Supplier> suppliers)
        {
            try
            {
                Supplier supplier = suppliers.Find(s => s.SupplierID == supplierId);
                if (supplier != null)
                {
                    supplier.Name = newName;
                    supplier.EmailAddress = newEmailAddress;
                    supplier.PhoneNumber = newPhoneNumber;
                    supplier.Category = newCategory;
                    supplier.Address = newAddress;

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
                    emailAddress: record[2],
                    phoneNumber: record[3],
                    category: record[4],
                    address: record[5]
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
            EmailAddress,
            PhoneNumber,
            Category,
            Address
            };
        }

    }
}
