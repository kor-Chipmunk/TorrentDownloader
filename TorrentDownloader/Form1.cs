using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TorrentDownloader
{
    public partial class Form1 : Form
    {
        HttpClient client;
        public Form1()
        {
            InitializeComponent();

            client = new HttpClient();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String html = client.GetHttpResponse("https://torrentkim12.com/bbs/s.php?k=%EA%B0%80%EC%9A%94%EB%8C%80%EC%A0%84&b=&q=", "");


        }
    }
}
