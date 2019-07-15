namespace CPKTool
{
    partial class CPKTool
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numModifeTime = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numCreatTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numCPK = new System.Windows.Forms.NumericUpDown();
            this.tPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lPath = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModifeTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreatTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCPK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numModifeTime);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numCreatTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.numCPK);
            this.groupBox1.Controls.Add(this.tPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lPath);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 235);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置";
            // 
            // numModifeTime
            // 
            this.numModifeTime.Location = new System.Drawing.Point(169, 165);
            this.numModifeTime.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numModifeTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numModifeTime.Name = "numModifeTime";
            this.numModifeTime.Size = new System.Drawing.Size(120, 33);
            this.numModifeTime.TabIndex = 9;
            this.numModifeTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "修改修改时间内:";
            // 
            // numCreatTime
            // 
            this.numCreatTime.Location = new System.Drawing.Point(169, 123);
            this.numCreatTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numCreatTime.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numCreatTime.Name = "numCreatTime";
            this.numCreatTime.Size = new System.Drawing.Size(120, 33);
            this.numCreatTime.TabIndex = 7;
            this.numCreatTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "监控创建时间内:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(348, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "开始监控";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numCPK
            // 
            this.numCPK.DecimalPlaces = 1;
            this.numCPK.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numCPK.Location = new System.Drawing.Point(169, 73);
            this.numCPK.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCPK.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numCPK.Name = "numCPK";
            this.numCPK.Size = new System.Drawing.Size(120, 33);
            this.numCPK.TabIndex = 4;
            this.numCPK.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // tPath
            // 
            this.tPath.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tPath.Location = new System.Drawing.Point(169, 24);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(267, 33);
            this.tPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPK期望:";
            // 
            // lPath
            // 
            this.lPath.AutoSize = true;
            this.lPath.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lPath.Location = new System.Drawing.Point(55, 32);
            this.lPath.Name = "lPath";
            this.lPath.Size = new System.Drawing.Size(93, 25);
            this.lPath.TabIndex = 0;
            this.lPath.Text = "文件路径:";
            // 
            // CPKTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 235);
            this.Controls.Add(this.groupBox1);
            this.Name = "CPKTool";
            this.Text = "CPK助手";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numModifeTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreatTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCPK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.NumericUpDown numCPK;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown numCreatTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numModifeTime;
        private System.Windows.Forms.Label label3;
    }
}

