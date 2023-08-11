using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WpfApp1;

using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;


public partial class MainWindow : Window
{
    private string mainFilePath = string.Empty;
    private string additionalFilePath = string.Empty;
    private PdfDocument mainDocument = null;
    private PdfDocument additionalDocument = null;
    private PdfDocument resultDocument = new PdfDocument();
    private int pageNumber = 0;
    private int currentPage = 0;
    private int lockVar = 0;

    private void OpenFileFirst_Click(object sender, RoutedEventArgs e)
    {
        if (mainDocument != null)
        {
            MessageBoxResult result = MessageBox.Show("File" + mainFilePath + " is selected!!!  Do you want to select another file ?", "CAUTION!", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
            {
                return;
            }
        }
        mainFilePath = SelectFile(); 
        if (mainFilePath != "error")
        {
            mainDocument = PdfReader.Open(mainFilePath, PdfDocumentOpenMode.Import);
        }

    }

    private void OpenFileSecond_Click(object sender, RoutedEventArgs e)
    {
        additionalFilePath = SelectFile();
        if (additionalFilePath != "error")
        {
            additionalDocument = PdfReader.Open(additionalFilePath, PdfDocumentOpenMode.Import);
        }
    }

    private String SelectFile()
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        openFileDialog1.Multiselect = false;
        openFileDialog1.ShowDialog();
        Debug.WriteLine("Selected file is " + openFileDialog1.FileName);

        if (openFileDialog1.FileName != string.Empty)
        {
            return openFileDialog1.FileName;
        }
        return "error";

    }

    private void AddPage(object sender, RoutedEventArgs e)
    {
        if (mainDocument==null) 
        {
            string message = "Main document is not selected.";
            string title = "ERROR!!!";
            MessageBox.Show(message, title);
            return;
        }
        if (additionalDocument == null)
        {
            string message1 = "Additional document is not selected.";
            string title1 = "ERROR!!!";
            MessageBox.Show(message1, title1);
            return;
        }
        if (NumberTextBox.Text.Trim().Equals(""))
        {
            string message2 = "Page number is not entered.";
            string title2 = "ERROR!!!";
            MessageBox.Show(message2, title2);
            return;
        }

        int tmpPageNumber = int.Parse(NumberTextBox.Text) - 1;
        if (tmpPageNumber < pageNumber)
        {
            string message3 = "Page number is too low.";
            string title3 = "ERROR!!!";
            MessageBox.Show(message3, title3);
            return;
        }
        if ((((mainDocument.PageCount+1) < int.Parse(NumberTextBox.Text))))
        {
            string message3 = "Max page is " + (mainDocument.PageCount+1) + " please enter corect value";
            string title3 = "ERROR!!!";
            MessageBox.Show(message3, title3);
            return;
        }

        pageNumber = tmpPageNumber;

        for (; currentPage < pageNumber; currentPage++)
        {
            resultDocument.AddPage(mainDocument.Pages[currentPage]);
        }

        for (int j = 0; j < additionalDocument.PageCount; j++)
        {
            resultDocument.AddPage(additionalDocument.Pages[j]);
        }

        lockVar = 1;
        string message4 = "Pages was added.";
        string title4 = "INFO";
        MessageBox.Show(message4, title4);
    }
    private void GoConvert(object sender, RoutedEventArgs e)
    {
        if (lockVar == 1)
        {
            string NewFileName = newFileName.Text;
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            NewFileName = desktopPath + '\\' + NewFileName;

            for (; currentPage < mainDocument.PageCount; currentPage++)
            {
                resultDocument.AddPage(mainDocument.Pages[currentPage]);
            }
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            resultDocument.Save(NewFileName);
            string message5 = "File is saved " + NewFileName;
            string title5 = "INFO";
            MessageBox.Show(message5, title5);
        }
        else
        {
            string message6 = "Please press \"Insert pages\" before this operation ";
            string title6 = "ERROR!!!";
            MessageBox.Show(message6, title6);
        }

    }

    private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
    {
        Regex regex = new Regex("[^0-9]+");
        e.Handled = regex.IsMatch(e.Text);
    }
}

