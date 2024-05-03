using System;
using System.IO;
using System.Windows.Forms;
using TextAnalyzer.Properties;

namespace TextAnalyzer;

public partial class Menu : Form
{
    public Menu() => InitializeComponent();

    private string Data { get; set; }
    private string FilePath { get; set; }

    private char CharToFind =>
        charTextBox.Text.Length > 0 ? charTextBox.Text[0] : ' ';

    private void selectFileButton_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();

        openFileDialog.Filter =
            Resources.ResourceManager.GetString("File_Dialog_Filter");
        openFileDialog.FilterIndex = 1;
        openFileDialog.Multiselect = false;

        var result = openFileDialog.ShowDialog();
        if (result != DialogResult.OK) return;

        try
        {
            FilePath = openFileDialog.FileName;
            Data = File.ReadAllText(FilePath);
            dataTextBox.Text = Data;
        }
        catch (Exception ex)
        {
            var errorMessage =
                Resources.ResourceManager.GetString("Could_not_read_file");
            MessageBox.Show(errorMessage + ex.Message);
        }
    }

    private void reloadButton_Click(object sender, EventArgs e)
    {
        var analyzer = new DataAnalyzer(Data);

        // ReSharper disable HeapView.BoxingAllocation
        spaceLabel.Text = $@"Space count: {analyzer.GetCharCount(' ')}";
        charLabel.Text = $@"Char count: {analyzer.GetCharCount(CharToFind)}";
        // ReSharper restore HeapView.BoxingAllocation
    }
}