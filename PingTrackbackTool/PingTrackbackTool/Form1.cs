using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace PingTrackbackTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SendTrackBackBtn_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();

            client.Encoding = Encoding.UTF8;
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
            string postString = "title=# has visited this place &url=http://travel.msra.cn/&excerpt=Travel+Guide+Test&blog_name=MSRA";
            byte[] postData = Encoding.UTF8.GetBytes(postString);
            byte[] responseData = client.UploadData("http://cellkey.spaces.live.com/blog/cns!FA9BF57159458E6B!138.trak", "POST", postData);
            string srcString = Encoding.UTF8.GetString(responseData);

            Console.WriteLine(srcString);

        }
    }
}
