using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public enum SupplierCategory
    {
        Computers,
        Smartphones,
        Electronics,
        Accessories,
        Audio,
        Wearables

        // Add more categories as needed
    }
    internal class Supplier
    {
        public int SupplierID { get; private set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public long PhoneNumber { get; set; }
        public SupplierCategory Category { get; set; } // Updated to Category
        public string Address { get; set; } // Street Number, Name
        public string City { get; set; }
        private static string dataDirectory = "../../../Data/";
        private static string suppliersFilePath = Path.Combine(dataDirectory, "suppliers.csv");
        public Supplier(int supplierId, string name, string emailAddress, long phoneNumber, SupplierCategory category, string address, string city)
        {
            SupplierID = supplierId;
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Category = category;
            Address = address;
            City = city;
        }

        public static bool AddSupplier(Supplier supplier, List<Supplier> suppliers)
        {
            try
            {
                suppliers.Add(supplier);
                List<string[]> data = suppliers.Select(s => s.ToCSV()).ToList();
                FileManager.WriteDataSupplier(suppliersFilePath, data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while adding the supplier: {ex.Message}");
                return false;
            }
        }
        public static bool EditSupplier(int supplierId, string newName, string newEmailAddress,
            long newPhoneNumber, SupplierCategory newCategory, string newAddress, string newCity, List<Supplier> suppliers)
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
                    supplier.City = newCity;

                    List<string[]> data = suppliers.Select(s => s.ToCSV()).ToList();
                    FileManager.WriteDataSupplier(suppliersFilePath, data); // Save changes to CSV
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
                    FileManager.WriteDataSupplier(suppliersFilePath, data); // Save changes to CSV
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
                    phoneNumber: long.Parse(record[3]),
                    category: (SupplierCategory)Enum.Parse(typeof(SupplierCategory) ,record[4]),
                    address: record[5],
                    city: record[6]
                ));
            }

            return suppliers;
        }
        public static bool Exists(int id)
        {
            List<Supplier> suppliers = LoadSuppliers();
            return suppliers.Any(p => p.SupplierID == id);
        }
        public string[] ToCSV()
        {
            return new string[]
            {
            SupplierID.ToString(),
            Name,
            EmailAddress,
            PhoneNumber.ToString(),
            Category.ToString(),
            Address,
            City
            };
        }

    }
}
