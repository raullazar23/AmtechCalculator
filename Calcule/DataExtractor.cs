using System;
using System.IO;
using System.Linq;

class Program
{
    internal class DataExtractor
    {
        string formaInput = "user_forma_input";
        string materialInput = "user_material_input";
        string culoareInput = "user_culoare_input";
        string greutateInput = "user_greutate_input";
        string pretkgInput;
        int pretkgInputint;
        
        string filePath = "your_file.csv";



        private string[] FindMatchingRow(string filePath, string formaInput, string materialInput, string culoareInput, string greutateInput)
        {
            string[] lines = File.ReadAllLines(filePath);

            string[] headers = lines[0].Split(',');

            int formaIndex = Array.IndexOf(headers, "Forma");
            int materialIndex = Array.IndexOf(headers, "Material");
            int culoareIndex = Array.IndexOf(headers, "Culoare");
            int greutateIndex = Array.IndexOf(headers, "Greutate");
            int pretkgIndex = Array.IndexOf(headers, "Pretkg");
            

            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                if (fields[formaIndex] == formaInput &&
                    fields[materialIndex] == materialInput &&
                    fields[culoareIndex] == culoareInput &&
                    fields[greutateIndex] == greutateInput)
                {
                    pretkgInput = fields[pretkgIndex];
                    int.TryParse(pretkgInput, out pretkgInputint);
                    
                }
            }

            return null;
        }
    }
}
