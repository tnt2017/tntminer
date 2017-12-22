namespace tntminer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox_params = new System.Windows.Forms.TextBox();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxgpu0 = new System.Windows.Forms.TextBox();
            this.textBoxgpu1 = new System.Windows.Forms.TextBox();
            this.textBoxgpu2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxgpu5 = new System.Windows.Forms.TextBox();
            this.textBoxgpu4 = new System.Windows.Forms.TextBox();
            this.textBoxgpu3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_worker = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_miner = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_currency = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_vtc_wallet = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 467);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(25, 494);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(667, 59);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = ":start\r\nexcavator.exe -a equihash -s eu1-zcash.flypool.org:3333 -u t1Tzb9vdABkyuz" +
    "T6WhR4j3LwapbBQzQHSmA:x -d 1 -ca -ca\r\nping 127.0.0.1 > nul\r\ngoto start";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(74, 559);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(618, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.Text = "http://zcash.flypool.org/miners/t1Tzb9vdABkyuzT6WhR4j3LwapbBQzQHSmA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Stats";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(73, 587);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(619, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "http://zcash.flypool.org/miners/t1Tzb9vdABkyuzT6WhR4j3LwapbBQzQHSmA/payouts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 594);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Payouts";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(12, 147);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(680, 118);
            this.textBox6.TabIndex = 15;
            // 
            // textBox_params
            // 
            this.textBox_params.Location = new System.Drawing.Point(12, 119);
            this.textBox_params.Multiline = true;
            this.textBox_params.Name = "textBox_params";
            this.textBox_params.Size = new System.Drawing.Size(679, 22);
            this.textBox_params.TabIndex = 16;
            this.textBox_params.Text = " -a lyra2v2 -o stratum+tcp://siberia.mine.nu:9181 -u VwXCETy8iN1btYctoksKibmoHs6y" +
    "AZGqEg -p c=CREA,stats --cpu-priority 3";
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(572, 90);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(56, 23);
            this.start_btn.TabIndex = 21;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Location = new System.Drawing.Point(634, 90);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(58, 23);
            this.stop_btn.TabIndex = 22;
            this.stop_btn.Text = "STOP";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(407, 56);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(112, 17);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Restart after 5 min";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxgpu0
            // 
            this.textBoxgpu0.Location = new System.Drawing.Point(64, 278);
            this.textBoxgpu0.Name = "textBoxgpu0";
            this.textBoxgpu0.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu0.TabIndex = 25;
            // 
            // textBoxgpu1
            // 
            this.textBoxgpu1.Location = new System.Drawing.Point(64, 304);
            this.textBoxgpu1.Name = "textBoxgpu1";
            this.textBoxgpu1.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu1.TabIndex = 26;
            // 
            // textBoxgpu2
            // 
            this.textBoxgpu2.Location = new System.Drawing.Point(64, 330);
            this.textBoxgpu2.Name = "textBoxgpu2";
            this.textBoxgpu2.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu2.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "GPU #0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "GPU #1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "GPU #2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(259, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 32;
            this.label10.Text = "EXCAVATOR";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(407, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 17);
            this.checkBox2.TabIndex = 33;
            this.checkBox2.Text = "Autostart mining";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 408);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "GPU #5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "GPU #4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "GPU #3";
            // 
            // textBoxgpu5
            // 
            this.textBoxgpu5.Location = new System.Drawing.Point(64, 382);
            this.textBoxgpu5.Name = "textBoxgpu5";
            this.textBoxgpu5.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu5.TabIndex = 36;
            // 
            // textBoxgpu4
            // 
            this.textBoxgpu4.Location = new System.Drawing.Point(65, 409);
            this.textBoxgpu4.Name = "textBoxgpu4";
            this.textBoxgpu4.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu4.TabIndex = 35;
            // 
            // textBoxgpu3
            // 
            this.textBoxgpu3.Location = new System.Drawing.Point(64, 356);
            this.textBoxgpu3.Name = "textBoxgpu3";
            this.textBoxgpu3.Size = new System.Drawing.Size(411, 20);
            this.textBoxgpu3.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 434);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Итого";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 434);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 20);
            this.textBox1.TabIndex = 40;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(769, 199);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 20);
            this.button5.TabIndex = 42;
            this.button5.Text = "GET_BALANCE_STAT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(542, 33);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(133, 17);
            this.checkBox3.TabIndex = 43;
            this.checkBox3.Text = "Minimize miner window";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(542, 56);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(115, 17);
            this.checkBox4.TabIndex = 44;
            this.checkBox4.Text = "Hide miner window";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(557, 423);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 31);
            this.label15.TabIndex = 45;
            this.label15.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(503, 382);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(154, 25);
            this.label16.TabIndex = 46;
            this.label16.Text = "Кол-во видюх:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "123",
            "456",
            "789"});
            this.checkedListBox1.Location = new System.Drawing.Point(697, 56);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(187, 94);
            this.checkedListBox1.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(481, 289);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 31);
            this.label17.TabIndex = 48;
            this.label17.Text = "label17";
            this.label17.TextChanged += new System.EventHandler(this.label17_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(197, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 50;
            this.label18.Text = "Worker";
            // 
            // textBox_worker
            // 
            this.textBox_worker.Location = new System.Drawing.Point(197, 33);
            this.textBox_worker.Name = "textBox_worker";
            this.textBox_worker.Size = new System.Drawing.Size(166, 20);
            this.textBox_worker.TabIndex = 51;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(695, 27);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 23);
            this.button7.TabIndex = 52;
            this.button7.Text = "SEND POST REQ";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(698, 238);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 236);
            this.richTextBox1.TabIndex = 53;
            this.richTextBox1.Text = "";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(698, 199);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(65, 20);
            this.textBox7.TabIndex = 54;
            this.textBox7.Text = "2017-12-19";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(698, 494);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(222, 112);
            this.textBox10.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(698, 222);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 13);
            this.label19.TabIndex = 56;
            this.label19.Text = "Поступления:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(695, 478);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 57;
            this.label20.Text = "Итого по дням:";
            // 
            // textBox_miner
            // 
            this.textBox_miner.Location = new System.Drawing.Point(12, 73);
            this.textBox_miner.Name = "textBox_miner";
            this.textBox_miner.Size = new System.Drawing.Size(165, 20);
            this.textBox_miner.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Miner";
            // 
            // textBox_currency
            // 
            this.textBox_currency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_currency.Location = new System.Drawing.Point(12, 33);
            this.textBox_currency.Name = "textBox_currency";
            this.textBox_currency.Size = new System.Drawing.Size(165, 20);
            this.textBox_currency.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Currency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Params";
            // 
            // textBox_vtc_wallet
            // 
            this.textBox_vtc_wallet.Location = new System.Drawing.Point(697, 173);
            this.textBox_vtc_wallet.Name = "textBox_vtc_wallet";
            this.textBox_vtc_wallet.Size = new System.Drawing.Size(223, 20);
            this.textBox_vtc_wallet.TabIndex = 66;
            this.textBox_vtc_wallet.Text = "VwXCETy8iN1btYctoksKibmoHs6yAZGqEg";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(695, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "VTC wallet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 621);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_vtc_wallet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_currency);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_miner);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox_worker);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxgpu5);
            this.Controls.Add(this.textBoxgpu4);
            this.Controls.Add(this.textBoxgpu3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxgpu2);
            this.Controls.Add(this.textBoxgpu1);
            this.Controls.Add(this.textBoxgpu0);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.textBox_params);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "TntMiner v0.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox_params;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxgpu0;
        private System.Windows.Forms.TextBox textBoxgpu1;
        private System.Windows.Forms.TextBox textBoxgpu2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxgpu5;
        private System.Windows.Forms.TextBox textBoxgpu4;
        private System.Windows.Forms.TextBox textBoxgpu3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_worker;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_miner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_currency;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_vtc_wallet;
        private System.Windows.Forms.Label label9;
    }
}

