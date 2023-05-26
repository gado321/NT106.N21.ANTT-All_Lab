using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
                MessageBox.Show("Vui long nhap dung URL");
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
            // Lấy nội dung HTML của Control WebBrowser
            string htmlCode = webBrowser1.DocumentText;

            // Parse HTML để lấy danh sách các đường dẫn đến các file đínhkèm
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(htmlCode);

            // Tạo một thư mục để lưu trữ các file được tải xuống
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "WebSource");
            Directory.CreateDirectory(folderPath);

            // Tải xuống các hình ảnh và các file liên quan
            foreach (HtmlNode imgNode in doc.DocumentNode.Descendants("img"))
            {
                string imgUrl = imgNode.GetAttributeValue("src", "");
                if (!string.IsNullOrEmpty(imgUrl))
                {
                    // Xoá Token
                    imgUrl = Regex.Replace(imgUrl, @"\?.*", "");
                    try
                    {
                        // Tạo tên file từ đường dẫn url của hình ảnh
                        string fileName = Path.GetFileName(imgUrl);

                        // Tải xuống hình ảnh
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(imgUrl, Path.Combine(folderPath, fileName));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        //MessageBox.Show(ex.Message);
                    }
                }
            }

            // Tải xuống các file liên quan khác
            foreach (HtmlNode linkNode in doc.DocumentNode.SelectNodes("//a[@href]"))
            {
                string linkUrl = linkNode.GetAttributeValue("href", "");
                if (!string.IsNullOrEmpty(linkUrl) && linkUrl.StartsWith("http"))
                {
                    try
                    {
                        // Tạo tên file từ đường dẫn url
                        string fileName = Path.GetFileName(linkUrl);

                        // Tải xuống file
                        using (WebClient client = new WebClient())
                        {
                            client.DownloadFile(linkUrl, Path.Combine(folderPath, fileName));
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        //MessageBox.Show(ex.Message);
                    }
                }
            }
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
    }
}
