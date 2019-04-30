using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZaloSpammer
{
    public partial class KetBanZalo : Form
    {
        public KetBanZalo()
        {
            InitializeComponent();
        }

        private void BtnBatdau1_Click(object sender, EventArgs e)
        {
            string str_listnguoigui = txtDanhsachnguoigui1.Text;
            string[] ar_nguoigui = str_listnguoigui.Split('\n');
            string str_noidunggui = txtNoidunggui1.Text;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("--disable-notifications");
            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl("https://id.zalo.me/account/login?continue=https%3A%2F%2Fchat.zalo.me%2F");
            Thread.Sleep(10000);
            var j = 0;
            foreach (string sdt in ar_nguoigui)
            {
                if (j == 0)
                {
                    btnBatdau1.Enabled = false;
                    rbLogs1.AppendText("======= BẮT ĐẦU KẾT BẠN ======"+'\n');
                }
                driver.FindElementByXPath(@"//*[@id=""inviteBtn""]/div").Click();
                Thread.Sleep(1000);
                driver.FindElementByClassName("input-prepended").SendKeys(sdt);
                Thread.Sleep(1000);
                driver.FindElementByXPath(@"//*[@id=""findFriend""]/div[3]/span[2]").Click();
                Thread.Sleep(2000);
                driver.FindElementByXPath(@"//*[@id=""findFriend""]/div[2]/div[2]/div/div[2]/span").Click();
                Thread.Sleep(1000);
                driver.FindElementByXPath(@"//*[@id=""_sendRequest""]/span").Click();
                Thread.Sleep(1000);
                rbLogs1.AppendText("Gửi lời mời kết bạn: " + sdt + " thành công" + '\n');
                if (j>1 && j == ar_nguoigui.Length - 1)
                {
                    btnBatdau1.Enabled = true;
                    rbLogs1.AppendText("====== XONG ======"+'\n');
                    driver.Close();
                    driver.Quit();
                    MessageBox.Show("Đã gửi lời mời kết bạn xong. Vui lòng tắt chương trình hoặc thêm mới danh sách kết bạn mới.");
                }
                j++;
            }
        }
    }
}
