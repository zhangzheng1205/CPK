using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPKTool
{
    public partial class CPKTool : Form
    {
        //第三次提交
        //第二次提交
        //初次提交项目
        public CPKTool()
        {
            InitializeComponent();
            this.timer1.Interval = 1000;
            this.timer1.Tick += Timer1_Tick;
        }

        private string Path = string.Empty;
        private double cpkDef = 0.5;
        private TimeSpan timeSpan1 = new TimeSpan(0, 30, 0);
        private TimeSpan timeSpan2 = new TimeSpan(0, 5, 0);

        /// <summary>
        /// 存储修改过的文件
        /// </summary>
        private List<string> ChangedFileName = new List<string>();

        /// <summary>
        /// 定时监控 1s 一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo root = new DirectoryInfo(this.Path);
                FileInfo[] files = root.GetFiles();
                foreach(FileInfo fileInfo in files)
                {
                    if (DateTime.Now - fileInfo.CreationTime < timeSpan1) // 大于 时间间隔以上不监控
                    {
                        if (DateTime.Now - fileInfo.LastWriteTime > timeSpan2) // 大于 时间间隔以上才修改
                        {
                            if (!this.ChangedFileName.Contains(fileInfo.FullName)) // 没有修改过
                            {
                                this.ChangeCPK(fileInfo.FullName);
                                this.ChangedFileName.Add(fileInfo.FullName);
                            }
                        }
                    }
                }
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Path = this.tPath.Text;
            this.timeSpan1 = new TimeSpan(0, (int)this.numCreatTime.Value, 0);
            this.timeSpan2 = new TimeSpan(0, (int)this.numModifeTime.Value, 0);
            this.cpkDef = (double)this.numCPK.Value;
            this.Visible = false;
            this.timer1.Start();
        }

        /// <summary>
        /// 获得随机数
        /// </summary>
        /// <param name="seed">标准值</param>
        /// <param name="mid">震荡幅度</param>
        /// <returns></returns>
        private Tuple<double, double> GetRandom(double seed, double mid)
        {
            Random rd = new Random();
            var result = (rd.Next((int)(mid * 2000)) - mid * 1000) * this.cpkDef / 1000.0; // 扩大2000倍随机, 0.6 CPK >1.33 振幅就必须要小于60%
            return new Tuple<double, double>(seed + result, result);
        }

        private void ChangeCPK(string path)
        {
            //string path = @"C:\Users\lichen\Desktop\0983内轨.txt";
            string[] content = File.ReadAllLines(path);

            for (int i = 0; i < content.Length; ++i)
            {
                if (!(content[i].Contains("BEGIN") || content[i].Contains("END")))
                {
                    string[] lineArg = content[i].Split('\t');
                    if (lineArg.Length >= 6)
                    {
                        double real = double.Parse(lineArg[1]);
                        double need = double.Parse(lineArg[2]);
                        double mid = double.Parse(lineArg[3]);
                        if (Math.Abs(real - need) >= (mid * this.cpkDef))
                        {
                            var tuple = GetRandom(need, mid);
                            lineArg[1] = tuple.Item1.ToString("f4");
                            lineArg[5] = tuple.Item2.ToString("f4");
                            content[i] = $"{lineArg[0]}\t{lineArg[1]}\t{lineArg[2]}\t{lineArg[3]}\t{lineArg[4]}\t{lineArg[5]}\t";
                        }
                    }
                }
            }

            File.WriteAllLines(path, content);
        }
    }
}
