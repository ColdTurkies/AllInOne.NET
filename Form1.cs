using Microsoft.Win32;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllInOne.NET
{
    public partial class Form1 : Form
    {
        private const string RegistryPath = @"zsnare\Software\MyApp";
        private const string ValueName = "Value";
        public Form1()
        {
            InitializeComponent();
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
            // Check if the value
            if (value.Contains(",") || value.Contains("\""))
            {
                // Enclose in quotes and escape existing quotes
                return "\"" + value.Replace("\"", "\"\"") + "\"";
            }
            return value;
        }
        private void btnAddTextToListBox_Click(object sender, EventArgs e)
        {
            //Naming convention terrible for practice purposes
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
                // Set a registry key with a string value
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
                // Read the registry value
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
    }
}
