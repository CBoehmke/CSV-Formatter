using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Small_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Mill function
        public string ConvertMill(string a)
        {
            switch (a)
            {
                case "AP":
                    a = "Appleton Coated";
                    break;

                case "AV":
                    a = "Appvion";
                    break;

                case "BP":
                    a = "Boise Pacific";
                    break;

                case "CT":
                    a = "Catalyst";
                    break;

                case "CV":
                    a = "CVG";
                    break;

                case "DO":
                    a = "Domtar";
                    break;

                case "EG":
                    a = "Enterprise Group";
                    break;

                case "FS":
                    a = "Felix Schoeller";
                    break;

                case "FI":
                    a = "Finch";
                    break;

                case "GP":
                    a = "Georgia Pacific";
                    break;

                case "GF":
                    a = "Glatfelter";
                    break;

                case "IP":
                    a = "International Paper";
                    break;

                case "MC":
                    a = "Mac Paper";
                    break;

                case "MA":
                    a = "Marquee";
                    break;

                case "MD":
                    a = "Midland";
                    break;

                case "MI":
                    a = "Mitsubishi";
                    break;

                case "MO":
                    a = "Mondi";
                    break;

                case "NE":
                    a = "Neenah";
                    break;

                case "NO":
                    a = "Norpac";
                    break;

                case "PP":
                    a = "Performance Papers";
                    break;

                case "PL":
                    a = "Permalite";
                    break;

                case "RE":
                    a = "Resolute";
                    break;

                case "RO":
                    a = "Roland";
                    break;

                case "VE":
                    a = "Verso";
                    break;

                case "CU":
                    a = "Custom";
                    break;
                    

            }
            return a;
        }

        // Weight Type function
        public string ConvertWeight(string a)
        {
            switch (a)
            {
                case "T":
                    a = "lb Text";
                    break;

                case "B":
                    a = "lb Bond";
                    break;

                case "C":
                    a = "lb Cover";
                    break;

                case "I":
                    a = "lb Index";
                    break;

                case "P":
                    a = "Point";
                    break;       

            }
            return a;
        }

        // Finish function
        public string ConvertFinish(string a)
        {
            switch(a)
            {
                case "IJT":
                    a = "Inkject Treated";
                    break;

                case "CDU":
                    a = "Coated Dull";
                    break;

                case "CGL":
                    a = "Coated Gloss";
                    break;

                case "CMA":
                    a = "Coated Matte";
                    break;

                case "CSA":
                    a = "Coated Satin";
                    break;

                case "CSI":
                    a = "Coated Silk";
                    break;

                case "CVV":
                    a = "Coated Velvet";
                    break;

                case "UNC":
                    a = "Uncoated";
                    break;
            }
            return a;
        }

        // Ink Type function
        public string ConvertInk(string a)
        {
            switch(a)
            {
                case "1":
                    a = "IV1 / MO5";
                    break;

                case "2":
                    a = "IV2 / MO6";
                    break;
            }
            return a;
        }

        // Color Grip function
        public string ConvertColorGrip(string a)
        {
            switch(a)
            {
                case "C":
                    a = "Enabled";
                    break;

                case "N":
                    a = "Disabled";
                    break;                     
            }
            return a;
        }

        // TAC Level function
        public string ConvertTAC(string a)
        {
            switch(a)
            {
                case "A":
                    a = "50";
                    break;

                case "B":
                    a = "60";
                    break;

                case "C":
                    a = "70";
                    break;

                case "D":
                    a = "80";
                    break;

                case "E":
                    a = "90";
                    break;

                case "F":
                    a = "100";
                    break;

                case "G":
                    a = "110";
                    break;

                case "H":
                    a = "120";
                    break;

                case "I":
                    a = "130";
                    break;

                case "J":
                    a = "140";
                    break;

                case "K":
                    a = "150";
                    break;

                case "L":
                    a = "160";
                    break;

                case "M":
                    a = "170";
                    break;

                case "N":
                    a = "180";
                    break;

                case "O":
                    a = "190";
                    break;

                case "P":
                    a = "200";
                    break;             
            }
            return a;
        }

        // Color Grip Level function
        public string ConvertColorGripLevel(string a)
        {
            switch(a)
            {
                case "A":
                    a = "5";
                    break;

                case "B":
                    a = "10";
                    break;

                case "C":
                    a = "15";
                    break;

                case "D":
                    a = "20";
                    break;

                case "E":
                    a = "25";
                    break;

                case "F":
                    a = "30";
                    break;

                case "G":
                    a = "40";
                    break;

                case "H":
                    a = "50";
                    break;

                case "0":
                    a = "0";
                    break;
            }
            return a;
        }

        // Format Description function
        public string FormatDescription(string a)
        {
            StringBuilder description = new StringBuilder(a.Length * 2);
            description.Append(a[0]);
            for (int i = 1; i < a.Length; i++)
            {
                // add space before capital letters unless a capital precedes it (acronyms)
                if (char.IsUpper(a[i]))
                {
                    if (char.IsUpper(a[i - 1]) && char.IsUpper(a[i + 1]))
                    {
                        description.Append("");
                    }
                    
                    else if (char.IsLower(a[i - 1]))
                    {
                        description.Append(' ');
                    }

                }


                // add space before numbers, unless a number precedes it
                if (char.IsDigit(a[i]))
                {

                    if (char.IsDigit(a[i - 1]))
                    {
                        description.Append("");
                    }
                    else if (char.IsLower(a[i - 1]))
                    {
                        description.Append(' ');
                    }

                    else if (char.IsUpper(a[i - 1]))
                    {
                        description.Append(' ');
                    }
                }
                // fix stubborn ones
                switch (description.ToString())
                {
                    case "Earth Choice 30Recycle":
                        description.Replace("Earth Choice 30Recycle", "Earth Choice 30 Recycle");
                        break;

                    case "Spectrum Premium 92Br":
                        description.Replace("Spectrum Premium 92Br", "Spectrum Premium 92 Br");
                        break;

                    case "Spectrum WIJColor Pro":
                        description.Replace("Spectrum WIJColor Pro", "Spectrum WIJ Color Pro");
                        break;

                    case "SSMHAccent Image Lok":
                        description.Replace("SSMHAccent Image Lok", "SSMH Accent Image Lok");
                        break;

                    case "Swordi JET 4_3Gloss":
                        description.Replace("Swordi JET 4_3Gloss", "Swordi JET 4_3 Gloss");
                        break;

                    case "DNSHigh Speed Coated Feel":
                        description.Replace("DNSHigh Speed Coated Feel", "DNS High Speed Coated Feel");
                        break;

                    case "DNSHigh Speed IJCF":
                        description.Replace("DNSHigh Speed IJCF", "DNS High Speed IJCF");
                        break;

                    case "Kromos 95Uncoated":
                        description.Replace("Kromos 95Uncoated", "Kromos 95 Uncoated");
                        break;

                    case "ORCACPMultipurpose":
                        description.Replace("ORCACPMultipurpose", "ORCACP Multipurpose");
                        break;

                    case "DNSHigh Speed IJNF":
                        description.Replace("DNSHigh Speed IJNF", "DNS High Speed IJNF");
                        break;

                    case "IQSelection Smooth":
                        description.Replace("IQSelection Smooth", "IQ Selection Smooth");
                        break;

                }



                // append line
                description.Append(a[i]);

            }
            return description.ToString();
        }

                

        // input validation variables
        public bool fileSelected = false;
        public bool saveAsSelected = false;
         
        // Open File
        private void openFileButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                // allow user to select input file and add it to label
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    
                    fileLabel.Text = openFileDialog1.FileName;
                    fileSelected = true;
                }

            }



            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Start
        private void startButton_Click(object sender, EventArgs e)
        {
            if (fileSelected == true && saveAsSelected == true)
            {

                try
                {

                    string[] line = File.ReadAllLines(fileLabel.Text);

                    StringBuilder csv = new StringBuilder();
                    csv.Append("FileName,Mill,Description,PaperWeight,WeightType,GSMWeight,Finish,InkVersion,ColorGrip,TACLevel,ColorGripLevel" + Environment.NewLine);

                    for (int i = 0; i < line.Length; i++)
                    {
                        var temp = line[i].Replace(".zip", "");

                        // Filename
                        csv.Append(line[i] + ",");

                        // Mill 2 chars
                        csv.Append(ConvertMill(temp.Substring(0, 2)) + ",");

                        // Description 1-20 chars
                        csv.Append(FormatDescription(temp.Substring(2, (temp.Length - 16)) + ","));

                        // PaperWeight 3 digits
                        csv.Append(temp.Substring(temp.Length - 14, 3) + ",");

                        // WeightType 1 char
                        csv.Append(ConvertWeight(temp.Substring(temp.Length - 11, 1)) + ",");

                        // GSMWeight 3 digits
                        csv.Append(temp.Substring(temp.Length - 10, 3) + ",");

                        // Finish 3 chars
                        csv.Append(ConvertFinish(temp.Substring(temp.Length - 7, 3)) + ",");

                        // InkVersion 1 char
                        csv.Append(ConvertInk(temp.Substring(temp.Length - 4, 1)) + ",");

                        // ColorGrip Option 1 char
                        csv.Append(ConvertColorGrip(temp.Substring(temp.Length - 3, 1)) + ",");

                        // TAC Level 1 char
                        csv.Append(ConvertTAC(temp.Substring(temp.Length - 2, 1)) + ",");

                        // ColorGripLevel 1 char
                        csv.Append(ConvertColorGripLevel(temp.Substring(temp.Length - 1, 1)) + ",");

                        // Reserved 4 chars
                        //csv += temp.Substring(35, 4) + ",";


                        csv.Append(Environment.NewLine);

                    }

                    // output contents to file

                    var output = outputLabel.Text;
                    if (!output.EndsWith(".csv"))
                    {
                        output = output + ".csv";
                    }

                    StreamWriter file = new StreamWriter(output);

                    file.WriteLine(csv);

                    file.Close();

                    MessageBox.Show("Contents successfully transferred to CSV file.");
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("You must select both an input file and a 'Save As' location before beginning.");
            }
        }

            
        // Clear labels
        private void clearButton_Click(object sender, EventArgs e)
        {
            fileLabel.Text = "";
            outputLabel.Text = "";
        }

        // Save As
        private void txtSaveAs_Click(object sender, EventArgs e)
        {
           
            // let user select file's 'save as' location
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFileDialog1.DefaultExt = "csv";
            saveFile.ShowDialog();
            outputLabel.Text = saveFile.FileName;
            saveAsSelected = true;
            

        }
    }
}









        
