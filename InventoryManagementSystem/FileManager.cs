using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    internal class FileManager
    {
        public static List<string[]> ReadData(string filePath)
        {
            List<string[]> data = new List<string[]>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        data.Add(line.Split(','));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from the file: {ex.Message}");
            }

            return data;
        }

        public static bool WriteData(string filePath, List<string[]> data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, false))
                {
                    foreach (var record in data)
                    {
                        writer.WriteLine(string.Join(",", record));
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
                return false;
            }
        }
    }
}
