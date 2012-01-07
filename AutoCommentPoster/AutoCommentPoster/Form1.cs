using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoCommentPoster
{
    public partial class AutoCommentPoster : Form
    {
        public readonly string TargetUrl = @"http://cellkey.spaces.live.com/blog/cns!FA9BF57159458E6B!138.entry";
        private int indexTmp = 0;

        public AutoCommentPoster()
        {
            InitializeComponent();
        }

        private void AutoCommentPoster_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(TargetUrl);
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
        }



        //WebBrowser 控件触发 DocumentComplete 事件的 ReadyState 属性更改为 READYSTATE_COMPLETE 时。 这表示 WebBrowser 控件已完成下载网页。 以下是有关此事件的一些要点：
        //在带有没有框架页的情况下 DocumentComplete 触发一次所有完成后。
        //在多个的帧的情况下 DocumentComplete 获取触发多次。 并非每个框架将触发此事件，但触发 DownloadBegin 事件的每个框架将触发相应的 DocumentComplete 事件。 
        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //Deal with the case if there is frame element in the Website.
            if (e.Url != webBrowser1.Document.Url)
                return;
            //Detail function
            string actualUrl = webBrowser1.Document.Url.ToString().Split('?')[0].ToString();
            if (actualUrl == TargetUrl)
            {
                HtmlDocument doc = webBrowser1.Document; //获取document对象
                HtmlElement btn = doc.GetElementById("sn_ccaddbtnCommentControl");
                HtmlElement commentText = doc.GetElementById("sn_ccTextCommentControl");
                if (btn != null & commentText != null)
                {
                    commentText.SetAttribute("value", "# has visited this place. " + indexTmp + " times in total");
                    btn.InvokeMember("click");
                    indexTmp++;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
