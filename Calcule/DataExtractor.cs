using System;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;

public class DataExtractor 
{
        string pretkgInput, GreutateInput,pretkgdistrr;
        float pretkgInputint, GreutateInputInt, pretkgdistrrint;
        string filePath;

    public DataExtractor(string filePath) {
        this.filePath = filePath;
    }


        public float FindMatchingRow(RadioButton formaInput, ComboBox materialInput, RadioButton culoareInput, TextBox grosimeInput)
        {
            string[] lines = File.ReadAllLines(this.filePath);

            string[] headers = lines[0].Split(',');

            int formaIndex = Array.IndexOf(headers, "Forma");
            int materialIndex = Array.IndexOf(headers, "Material");
            int culoareIndex = Array.IndexOf(headers, "Culoare");
            int grosimeIndex = Array.IndexOf(headers, "Grosime");
            int pretkgIndex = Array.IndexOf(headers, "Pretkg");
            int pretkgdistr = Array.IndexOf(headers, "Pretkgd");
        Boolean founded = false;

            string formainput1=formaInput.Text;
            string materialinput1=materialInput.Text;
            string culoareinput1=culoareInput.Text;
            string grosimeInput1=grosimeInput.Text;

            for (int i = 1; i < lines.Length; i++)
            {
                string[] fields = lines[i].Split(',');

                if (fields[formaIndex] == formainput1 &&
                    fields[materialIndex] == materialinput1 &&
                    fields[culoareIndex] == culoareinput1 &&
                    fields[grosimeIndex] == grosimeInput1)
                {
                    pretkgInput = fields[pretkgIndex];
                    pretkgdistrr = fields[pretkgdistr];
                    float.TryParse(pretkgInput, out pretkgInputint);
                    float.TryParse(pretkgdistrr, out pretkgdistrrint);
                    founded = true;
                    break;
                }
            }

        if (founded == true)
        {
            return pretkgInputint;
            }
            return pretkgInputint;
    }
    public float FindMatchingRowd(RadioButton formaInput, ComboBox materialInput, RadioButton culoareInput, TextBox grosimeInput)
    {
        string[] lines = File.ReadAllLines(this.filePath);

        string[] headers = lines[0].Split(',');

        int formaIndex = Array.IndexOf(headers, "Forma");
        int materialIndex = Array.IndexOf(headers, "Material");
        int culoareIndex = Array.IndexOf(headers, "Culoare");
        int grosimeIndex = Array.IndexOf(headers, "Grosime");
        int pretkgIndex = Array.IndexOf(headers, "Pretkg");
        int pretkgdistr = Array.IndexOf(headers, "Pretkgd");
        Boolean founded = false;

        string formainput1 = formaInput.Text;
        string materialinput1 = materialInput.Text;
        string culoareinput1 = culoareInput.Text;
        string grosimeInput1 = grosimeInput.Text;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] fields = lines[i].Split(',');

            if (fields[formaIndex] == formainput1 &&
                fields[materialIndex] == materialinput1 &&
                fields[culoareIndex] == culoareinput1 &&
                fields[grosimeIndex] == grosimeInput1)
            {
                pretkgInput = fields[pretkgIndex];
                pretkgdistrr = fields[pretkgdistr];
                float.TryParse(pretkgInput, out pretkgInputint);
                float.TryParse(pretkgdistrr, out pretkgdistrrint);
                founded = true;
                break;
            }
        }

        if (founded == true)
        {
            return pretkgdistrrint;
        }
        return pretkgdistrrint;
    }

    public float FindMatchingRowGreutate(RadioButton formaInput, ComboBox materialInput, RadioButton culoareInput, TextBox grosimeInput)
    {
        string[] lines = File.ReadAllLines(filePath);

        string[] headers = lines[0].Split(',');

        int formaIndex = Array.IndexOf(headers, "Forma");
        int materialIndex = Array.IndexOf(headers, "Material");
        int culoareIndex = Array.IndexOf(headers, "Culoare");
        int grosimeIndex = Array.IndexOf(headers, "Grosime");
        int GreutateIndex = Array.IndexOf(headers, "Greutate");
        Boolean founded = false;

        string formainput1 = formaInput.Text;
        string materialinput1 = materialInput.Text;
        string culoareinput1 = culoareInput.Text;
        string grosimeInput1 = grosimeInput.Text;

        for (int i = 1; i < lines.Length; i++)
        {
            string[] fields = lines[i].Split(',');

            if (fields[formaIndex] == formainput1 &&
                fields[materialIndex] == materialinput1 &&
                fields[culoareIndex] == culoareinput1 &&
                fields[grosimeIndex] == grosimeInput1)
            {
                GreutateInput = fields[GreutateIndex];
                float.TryParse(GreutateInput, out GreutateInputInt);
                founded = true;
                break;
            }
        }

        if (founded == true)
        {
            return GreutateInputInt;
        }else if (founded == false)
        {
            MessageBox.Show("Valoare inexistenta in tabel!", "Atentie!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        return GreutateInputInt;
    }

}
