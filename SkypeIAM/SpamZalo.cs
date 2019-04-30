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
    public partial class SpamZalo : Form
    {
        public SpamZalo()
        {
            InitializeComponent();
        }

        private void BtnBatdau_Click(object sender, EventArgs e)
        {
            string str_listnguoigui = txtDanhsachnguoigui.Text;
            string[] ar_nguoigui = str_listnguoigui.Split('\n');
            string str_noidunggui = txtNoidunggui.Text;
            ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--start-maximized");
            chromeOptions.AddArgument("--disable-infobars");
            chromeOptions.AddArgument("--disable-notifications");
            ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);
            driver.Navigate().GoToUrl("https://id.zalo.me/account/login?continue=https%3A%2F%2Fchat.zalo.me%2F");
            if(driver.Url.Contains("login"))
            {
                    Thread.Sleep(8000);
                    int i = 0;
                    int j = 0;
                    int solanspam = Convert.ToInt32(txtSolanSpam.Text);
                    int delaytime = Convert.ToInt32(txtDelaytime.Text) * 60000;
                    for (j = 0; j < solanspam; j++)
                    {
                        /* SỐ LẦN SPAM LẶP LẠI, NGHIÊM CẤM TẮT TRÌNH DUYỆT ẨN*/
                        foreach (string nguoigui in ar_nguoigui)
                        {
                            if (i == 0)
                            {
                                btnBatdau.Enabled = false;
                                rbLogs.AppendText("========== Bắt đầu spam lần " + j + " ==========" + '\n');
                            }
                            driver.FindElementById("contact-search-input").SendKeys(nguoigui);
                            Thread.Sleep(2000);
                            driver.FindElementById("contact-search-input").SendKeys(OpenQA.Selenium.Keys.Enter);
                            Thread.Sleep(2000);
                            driver.FindElementById("richInput").SendKeys(txtNoidunggui.Text);
                            Thread.Sleep(1000);
                            driver.FindElementById("richInput").SendKeys(OpenQA.Selenium.Keys.Enter);
                            rbLogs.AppendText("Spam " + nguoigui + " thành công " + '\n');
                            Thread.Sleep(2000);
                            if (i == ar_nguoigui.Length - 1)
                            {
                                btnBatdau.Enabled = true;
                                rbLogs.AppendText("========== Spam xong lần " + j + " ==========" + '\n');
                            }
                            i++;
                        }
                        Thread.Sleep(delaytime);
                        if (j > 1 && j == solanspam - 1)
                        {
                            driver.Close();
                            driver.Quit();
                            MessageBox.Show("Đã gửi tin nhắn spam xong. Vui lòng tắt chương trình hoặc gửi nội dung spam mới");
                        }
                    }
                
            }
            
        }
    }
}
