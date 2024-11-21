using Microsoft.Win32;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInOne.NET
{
    public partial class Form1 : Form
    {
        private const string RegistryPath = @"HKEY_CURRENT_USER\Software\MyApp";
        private const string ValueName = "UserSetting";

        // List to hold the image names (without extension)
        private List<string> imageNames;
        private Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();

            imageNames = new List<string>
            {
                "South Hills Logo.png",
                "SSINC LOGO",
                "trump.png"
            };
        }

        private void btnPostToWebhook_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void btnAllCaps_Click(object sender, EventArgs e)
        {
            txtCapitalization.Text = txtCapitalization.Text.ToUpper();
        }

        private void btnReadCSV_Click(object sender, EventArgs e)
        {
            txtCSV4.Clear();
            string csvLine = $"{QuoteIfNecessary(txtCSV1.Text)},{QuoteIfNecessary(txtCSV2.Text)},{QuoteIfNecessary(txtCSV3.Text)}";
            txtCSV4.AppendText(csvLine);
            MessageBox.Show(txtCSV4.Text);
        }

        private string QuoteIfNecessary(string value)
        {
            if (value.Contains(",") || value.Contains("\""))
            {
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }

        private void btnAddTextToListBox_Click(object sender, EventArgs e)
        {
            string inputText = txtListBoxText.Text;
            if (!string.IsNullOrWhiteSpace(inputText))
            {
                lib1.Items.Add(inputText);
                txtListBoxText.Clear();
            }
            else
            {
                MessageBox.Show("Please enter some text.");
            }
        }

        private void btnWriteRegistryValue_Click(object sender, EventArgs e)
        {
            try
            {
                string valueToWrite = "Hello, Registry!";
                Registry.SetValue(RegistryPath, ValueName, valueToWrite);
                MessageBox.Show($"Written '{valueToWrite}' to the registry.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to registry: {ex.Message}");
            }
        }

        private void btnReadRegistryValue_Click(object sender, EventArgs e)
        {
            try
            {
                object valueRead = Registry.GetValue(RegistryPath, ValueName, "Default Value");
                if (valueRead != null)
                {
                    MessageBox.Show($"Registry Value: {valueRead.ToString()}");
                }
                else
                {
                    MessageBox.Show("Registry key or value not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from registry: {ex.Message}");
            }
        }

        private void btnWriteDataToFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");
                File.WriteAllText(filePath, txtFilePath.Text);
                MessageBox.Show($"Data written to file: {filePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}");
            }
        }

        private void btnReadDataInFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");
                if (File.Exists(filePath))
                {
                    string fileContent = File.ReadAllText(filePath);
                    MessageBox.Show($"File content:\n{fileContent}");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from file: {ex.Message}");
            }
        }

        private void btnUpdateDataInFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");
                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, "\n" + txtFilePath.Text);
                    MessageBox.Show("Data updated in file.");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating file: {ex.Message}");
            }
        }

        private void btnDeleteDataInFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(Application.StartupPath, "data.txt");
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted successfully.");
                }
                else
                {
                    MessageBox.Show("File not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting the file: {ex.Message}");
            }
        }

        private void btnOpenFileDialogue_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    MessageBox.Show("File selected: " + openFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file dialog: {ex.Message}");
            }
        }

        private void btnChangeBGColor_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    this.BackColor = colorDialog.Color;
                    MessageBox.Show("Background color changed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing background color: {ex.Message}");
            }
        }

        // This is the changeImage_Click method that changes images
        private void changeImage_Click(object sender, EventArgs e)
        {
            try
            {
                if (imageNames.Count > 0)
                {
                    // Select a random image name from the list
                    string randomImageName = imageNames[random.Next(imageNames.Count)];

                    // Load the image from resources using the image name
                    var image = (Image)Properties.Resources.ResourceManager.GetObject(randomImageName);

                    if (image != null)
                    {
                        // Assuming 'picChangablePicture' is the PictureBox on your form
                        picChangablePicture.Image = image;
                    }
                    else
                    {
                        MessageBox.Show($"Image '{randomImageName}' not found in resources.");
                    }
                }
                else
                {
                    MessageBox.Show("No images available to shuffle.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing image: {ex.Message}");
            }
        }
    }
}

