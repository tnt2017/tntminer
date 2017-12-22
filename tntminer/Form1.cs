using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Management;
using System.Collections.Specialized;
using System.Globalization;

namespace tntminer
{    
    public partial class Form1 : Form
    {
        string title = "TntMiner v0.5";
        int counter=0;
        int vid_num = 0;

        public Form1()
        {
            InitializeComponent();
            //задаем всплывающий текст-подсказку (появляется при наведении указателя на иконку в трее)
            notifyIcon1.Text = title;
            //устанавливаем значок, отображаемый в трее:
            //либо один из стандартных:
            notifyIcon1.Icon = SystemIcons.Hand;
            //либо свой из файла:
            //notifyIcon1.Icon = new Icon("favicon.ico");
            //подписываемся на событие клика мышкой по значку в трее
            notifyIcon1.MouseClick += new MouseEventHandler(_notifyIcon_MouseClick);
            //подписываемся на событие изменения размера формы
            this.Resize += new EventHandler(FormForTray_Resize);
        }
        
        delegate void UpdateConsoleWindowDelegate(String msg);

        Process console = null;
        StreamWriter consoleStreamWriter = null;


        void check_wtm()
        {
            string url = "http://parfum-2017.ru/wtm.php";

            try
            {
                using (var webClient = new WebClient())
                {
                    var pars = new NameValueCollection();
                    pars.Add("worker", textBox_worker.Text);
                    byte[] responsedata = webClient.UploadValues(url, pars);
                    string responseText = Encoding.ASCII.GetString(responsedata);
                    string[] st = responseText.Split(new Char[] { '\n' });

                    textBox_currency.Text = st[0];
                    textBox_miner.Text = st[1]; 
                    textBox_params.Text = st[2];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = title;
            textBox_worker.Text = SystemInformation.ComputerName;
            getgpulist();

            check_wtm();

            if (checkBox2.Checked)
            {
                stop_btn_Click(null, null);
                start_btn_Click(null, null);
            }
        }


        private void ConsoleOutputHandler(object sendingProcess,
    DataReceivedEventArgs recieved)
        {
            if (!String.IsNullOrEmpty(recieved.Data))
            {
                UpdateConsoleWindow(recieved.Data + "\r\n");
            }
        }
        
        private void UpdateConsoleWindow(String message)
        {
            if (textBox6.InvokeRequired)
            {
                UpdateConsoleWindowDelegate update = new UpdateConsoleWindowDelegate(UpdateConsoleWindow);
                textBox6.Invoke(update, message);    
            }
            else
            {
                textBox6.AppendText(message);
            }

            if (message.IndexOf("GPU #0") > 0 || message.IndexOf("GPU#0") > 0)
            {
                textBoxgpu0.Text = message;

                if (vid_num < 1)
                    vid_num = 1;

                if (message.IndexOf("unknown error") > 0)
                {
                    stop_btn_Click(null, null);
                    start_btn_Click(null, null);
                }
            }
            if (message.IndexOf("GPU #1") > 0 || message.IndexOf("GPU#1") > 0)
            {
                textBoxgpu1.Text = message;

                if (vid_num < 2)
                    vid_num = 2;
            }
            if (message.IndexOf("GPU #2") > 0 || message.IndexOf("GPU#2") > 0)
            {
                textBoxgpu2.Text = message;

                if (vid_num < 3)
                    vid_num = 3;
            }
            if (message.IndexOf("GPU #3") > 0 || message.IndexOf("GPU#3") > 0)
            {
                textBoxgpu3.Text = message;

                if (vid_num < 4)
                    vid_num = 4;
            }
            if (message.IndexOf("GPU #4") > 0 || message.IndexOf("GPU#4") > 0)
            {
                textBoxgpu4.Text = message;
                if (vid_num < 5)
                    vid_num = 5;
            }
            if (message.IndexOf("GPU #5") > 0)
            {
                textBoxgpu5.Text = message;

                if (vid_num < 6)
                    vid_num = 6;
            }
            if (message.IndexOf("accepted") > 0 || message.IndexOf("[S/A/T]")>0)
            {
                textBox1.Text = message;
                string mhs=message.Substring(message.IndexOf("MH/s") - 7, 11);
                mhs = mhs.Replace(",", "");

                if (textBox_currency.Text == "vertcoin")
                    label17.Text = "VTC:" + mhs;

                if (textBox_currency.Text=="sibcoin")
                    label17.Text = "SIB:" + mhs;

                if (textBox_currency.Text == "equihash")
                    label17.Text = "ZEC:" + mhs;
            }

            if (message.IndexOf("Stratum connection interrupted") > 0)
            {
                textBox1.Text = "Stratum connection interrupted !!!";
                label17.Text = "Stratum connection interrupted !!!";
            }

            label15.Text = vid_num.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            console = new Process();
            console.StartInfo.FileName = Application.StartupPath + "\\excavator_tnt\\" + "excavator.exe"; //"start_zec_flypool_gpu_nvidia.bat"
            console.StartInfo.Arguments = " -a equihash -s eu1-zcash.flypool.org:3333 -u t1Tzb9vdABkyuzT6WhR4j3LwapbBQzQHSmA:x -d 1 -ca";
            console.StartInfo.WorkingDirectory = Application.StartupPath + "\\excavator_tnt\\";
            console.StartInfo.UseShellExecute = false;
            //console.StartInfo.CreateNoWindow = true;
            console.StartInfo.RedirectStandardInput = true;
            console.StartInfo.RedirectStandardOutput = true;
            console.OutputDataReceived += new DataReceivedEventHandler(ConsoleOutputHandler);
            console.ErrorDataReceived += new DataReceivedEventHandler(ConsoleOutputHandler);

            console.Start();
            consoleStreamWriter = console.StandardInput;
            console.BeginOutputReadLine();
        }
        
        void killproc(string s)
        {
            string target_name = s;
            System.Diagnostics.Process[] local_procs = System.Diagnostics.Process.GetProcesses();
            try
            {
                System.Diagnostics.Process target_proc = local_procs.First(p => p.ProcessName == target_name);
                target_proc.Kill();
            }
            catch (InvalidOperationException)
            {
                //MessageBox.Show("Process " + target_name + " not found!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter % 600 == 0)
            {
                check_wtm();
                stop_btn_Click(null, null);
                start_btn_Click(null, null);
            }

            if (counter % 20 == 0)
            {
                button7_Click(null, null);
            }
        }

        void get_day_itog(string html, string date, string wallet)
        {
            int pos = html.IndexOf(wallet + "\">");

            double itogo = 0;

            while (pos > 0)
            {
                html = html.Substring(pos + 1, html.Length - pos - 1);
                string s = html.Substring(0, 300);
                // MessageBox.Show(s);

                try
                {
                    string s1 = s.Substring(s.IndexOf("utc") + 5, 19);
                    string s2 = s.Substring(s.IndexOf("text-success") + 14, 5);

                    if (s.IndexOf("text-error") > 0)
                        s2 = s.Substring(s.IndexOf("text-error") + 12, 7);

                    richTextBox1.AppendText(s1 + "    " + s2 + "\r\n");

                    if (s1.IndexOf(date) > -1)
                    {
                        if (s2[0] == '-')
                        {
                            MessageBox.Show(s2);
                        }
                        else
                        {
                            s2 = s2.Replace("+", "");
                            IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
                            double b = double.Parse(s2, formatter);
                            itogo += b;
                        }
                    }

                }
                catch (Exception ex)
                {

                }

                pos = html.IndexOf(wallet + "\">");
            }

            //MessageBox.Show(itogo.ToString());
            textBox10.AppendText(date + ":" + itogo.ToString() + "\r\n");
        }


        private void button5_Click(object sender, EventArgs e)
        {
            HttpWebRequest proxy_request = (HttpWebRequest)WebRequest.Create("https://bitinfocharts.com/vertcoin/address/" + textBox_vtc_wallet.Text + "-full");
            proxy_request.Method = "GET";
            proxy_request.ContentType = "application/x-www-form-urlencoded";
            proxy_request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-US) AppleWebKit/532.5 (KHTML, like Gecko) Chrome/4.0.249.89 Safari/532.5";
            proxy_request.KeepAlive = true;
            HttpWebResponse resp = proxy_request.GetResponse() as HttpWebResponse;
            string html = "";
            using (StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding(1251)))
                html = sr.ReadToEnd();
            html = html.Trim();
            //Console.WriteLine(html);
            textBox6.Text = html;

            for (int i = 17; i < 22; i++)
            {
                string dt = "2017-12-" + i.ToString();
                get_day_itog(html, dt, textBox_vtc_wallet.Text); //textBox7.Text
            }            
        }
   
        ///
        /// здесь хранится состояние окна до сворачивания (максимизированное или нормальное)
        ///
        private FormWindowState _OldFormState;

        ///
        /// обрабатываем событие клика мышью по значку в трее
        ///
        void _notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            //проверяем, какой кнопкой было произведено нажатие
            if (e.Button == MouseButtons.Left)//если левой кнопкой мыши
            {
                //проверяем текущее состояние окна
                if (WindowState == FormWindowState.Normal || WindowState == FormWindowState.Maximized)//если оно развернуто
                {
                    //сохраняем текущее состояние
                    _OldFormState = WindowState;
                    //сворачиваем окно
                    WindowState = FormWindowState.Minimized;
                    //скрываться в трей оно будет по событию Resize (изменение размера), которое сгенерировалось после минимизации строчкой выше
                }
                else//в противном случае
                {
                    //и показываем на нанели задач
                    Show();
                    //разворачиваем (возвращаем старое состояние "до сворачивания")
                    WindowState = _OldFormState;
                }
            }
        }

        ///
        /// обрабатываем событие изменения размера
        ///
        void FormForTray_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)//если окно "свернуто"
            {
                //то скрываем его
                Hide();
            }
        }

        void getgpulist()
        {
            string s1, s2;
            ManagementObjectSearcher searcher2 = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");
            checkedListBox1.Items.Clear();

            int c = 0;
            foreach (ManagementObject queryObj in searcher2.Get())
            {
                s1 = string.Format("{0}", queryObj["Caption"]);
                //s2 = string.Format("Семейство: {0}", queryObj["VideoProcessor"]);
                //label8.Text = string.Format("Обьем: {0}", queryObj["Capacity"]);
                //MessageBox.Show(s1);
                checkedListBox1.Items.Add(s1);
                checkedListBox1.SetItemChecked(c, true);
                c++;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string url = "http://parfum-2017.ru/test.php";

            try
            {
                using (var webClient = new WebClient())
                {
                    var pars = new NameValueCollection();
                    pars.Add("worker", textBox_worker.Text);
                    pars.Add("gpu0", textBoxgpu0.Text);
                    pars.Add("gpu1", textBoxgpu1.Text);
                    pars.Add("gpu2", textBoxgpu2.Text);
                    pars.Add("gpu3", textBoxgpu3.Text);
                    pars.Add("gpu4", textBoxgpu4.Text);
                    pars.Add("gpu5", textBoxgpu5.Text);
                    pars.Add("itogo", textBox1.Text);
                    pars.Add("valute", textBox_currency.Text);

                    byte[] responsedata = webClient.UploadValues(url, pars);
                    string responseText = Encoding.ASCII.GetString(responsedata);
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void label17_TextChanged(object sender, EventArgs e)
        {
            this.Text = title + " - " + label17.Text;
            notifyIcon1.Text = title + " - " + label17.Text;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBoxgpu0.Text = "";
            textBoxgpu1.Text = "";
            textBoxgpu2.Text = "";
            textBoxgpu3.Text = "";
            textBoxgpu4.Text = "";
            textBoxgpu5.Text = "";

            console = new Process();
            console.StartInfo.FileName = Application.StartupPath + "\\ccminer64_tnt\\" + textBox_miner.Text;  
            console.StartInfo.Arguments = textBox_params.Text;  

            console.StartInfo.WorkingDirectory = Application.StartupPath + "\\excavator_tnt\\";
            console.StartInfo.UseShellExecute = false;

            if (checkBox3.Checked)
                console.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;

            if (checkBox4.Checked)
                console.StartInfo.CreateNoWindow = true;

            console.StartInfo.RedirectStandardInput = true;
            console.StartInfo.RedirectStandardOutput = true;
            console.OutputDataReceived += new DataReceivedEventHandler(ConsoleOutputHandler);
            console.ErrorDataReceived += new DataReceivedEventHandler(ConsoleOutputHandler);

            console.Start();
            consoleStreamWriter = console.StandardInput;
            console.BeginOutputReadLine();
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            killproc("ccminer-x64");
            killproc("ccminer_Alex_v1_x64-sib-cuda8");
        }
    }
}
