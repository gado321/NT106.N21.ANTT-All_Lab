using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Navigate(textBox1.Text);
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            catch 
            {
                MessageBox.Show("Enter a valid URL");
            }
        }

        private void Document_Window_Error(object sender, HtmlElementErrorEventArgs e)
        {
            e.Handled = true;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Window.Error += new HtmlElementErrorEventHandler(Document_Window_Error);
            textBox1.Text = webBrowser1.Url.ToString();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Tạo một thư mục để lưu trữ các file được tải xuống
            string folderPath = Path.Combine(Directory.GetDirectoryRoot("D:/").ToString(), "downloaded_files");
            Directory.CreateDirectory(folderPath);

            using (WebClient client = new WebClient())
            {
                

                string html = webBrowser1.DocumentText;

                Stream response = client.OpenRead(textBox1.Text);
                string htmlfilepath = Regex.Replace(webBrowser1.Url.ToString(), "^(http:\\/\\/www.|https:\\/\\/www.)", string.Empty);
                client.DownloadFile(textBox1.Text, Path.Combine("D:/downloaded_files", htmlfilepath.Replace("/", "_") + ".html"));

                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                var fileNodes = doc.DocumentNode.SelectNodes("//img | //link | //script | //a");

                if (fileNodes != null)
                {
                    string downloadFolder = Path.Combine("D:/downloaded_files", Regex.Replace(webBrowser1.Url.ToString(), "^(http:\\/\\/|https:\\/\\/)", string.Empty));
                    Directory.CreateDirectory(downloadFolder);

                    foreach (var fileNode in fileNodes)
                    {
                        string fileUrl = null;

                        if (fileNode.Name == "img" || fileNode.Name == "script")
                        {
                            fileUrl = fileNode.GetAttributeValue("src", null);
                        }
                        else if (fileNode.Name == "link")
                        {
                            string rel = fileNode.GetAttributeValue("rel", "").ToLower();
                            if (rel == "shortcut icon" || rel == "icon" || rel == "preload" || rel == "stylesheet")
                            {
                                fileUrl = fileNode.GetAttributeValue("href", null);
                            }
                        }
                        else if (fileNode.Name == "a")
                        {
                            // Download only specific file types, e.g., PDF documents
                            fileUrl = fileNode.GetAttributeValue("href", null);

                            if (!fileUrl.ToLower().EndsWith(".pdf"))
                            {
                                fileUrl = null;
                            }
                        }

                        if (fileUrl == null)
                            continue;

                        // Replace token (if any)
                        //fileUrl = Regex.Replace(fileUrl, @"\?.*", "");

                        // Resolve relative URLs
                        Uri baseUri = new Uri(textBox1.Text);
                        Uri resolvedUri = new Uri(baseUri, fileUrl);

                        string fileName = Path.GetFileName(resolvedUri.LocalPath);
                        string fileSavePath = Path.Combine(downloadFolder, fileName);

                        try
                        {
                            await client.DownloadFileTaskAsync(resolvedUri, fileSavePath);
                        }
                        catch (Exception ex)
                        {
                            // Handle download errors (e.g., 404 Not Found)
                            MessageBox.Show($"Error downloading file '{resolvedUri}': {ex.Message}");
                        }
                    }
                }
            }
            MessageBox.Show("Files downloaded successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            try
            {
                webBrowser1.Navigate(ofd.FileName);
                webBrowser1.ScriptErrorsSuppressed = true;
            }
            catch
            {
                MessageBox.Show("Please choose valid HTML file!");
            }
        }
    }
}
