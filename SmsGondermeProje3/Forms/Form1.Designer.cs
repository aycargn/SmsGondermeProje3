
namespace SmsGondermeProje3.Forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.anasfbtn = new DevExpress.XtraEditors.SimpleButton();
            this.sirketanasfbtn = new DevExpress.XtraEditors.SimpleButton();
            this.ayarlarbtn = new DevExpress.XtraEditors.SimpleButton();
            this.raporbtn = new DevExpress.XtraEditors.SimpleButton();
            this.mesajislembtn = new DevExpress.XtraEditors.SimpleButton();
            this.caribtn = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msgtimer = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Gray;
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Linen;
            this.panelControl1.Appearance.BorderColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Appearance.Options.UseImage = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Controls.Add(this.anasfbtn);
            this.panelControl1.Controls.Add(this.sirketanasfbtn);
            this.panelControl1.Controls.Add(this.ayarlarbtn);
            this.panelControl1.Controls.Add(this.raporbtn);
            this.panelControl1.Controls.Add(this.mesajislembtn);
            this.panelControl1.Controls.Add(this.caribtn);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(74, 869);
            this.panelControl1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.simpleButton1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(74, 176);
            this.panel2.TabIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Appearance.Options.UseTextOptions = true;
            this.simpleButton1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.simpleButton1.Location = new System.Drawing.Point(12, 9);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(46, 35);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Şirket Değiştir";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(0, 833);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 394);
            this.panel1.TabIndex = 7;
            // 
            // anasfbtn
            // 
            this.anasfbtn.Appearance.BackColor = System.Drawing.Color.DimGray;
            this.anasfbtn.Appearance.BackColor2 = System.Drawing.Color.Linen;
            this.anasfbtn.Appearance.BorderColor = System.Drawing.Color.Black;
            this.anasfbtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasfbtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.anasfbtn.Appearance.Options.UseBackColor = true;
            this.anasfbtn.Appearance.Options.UseBorderColor = true;
            this.anasfbtn.Appearance.Options.UseFont = true;
            this.anasfbtn.Appearance.Options.UseForeColor = true;
            this.anasfbtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.house;
            this.anasfbtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.anasfbtn.Location = new System.Drawing.Point(0, 182);
            this.anasfbtn.Name = "anasfbtn";
            this.anasfbtn.Size = new System.Drawing.Size(76, 105);
            this.anasfbtn.TabIndex = 6;
            this.anasfbtn.Click += new System.EventHandler(this.anasfbtn_Click);
            // 
            // sirketanasfbtn
            // 
            this.sirketanasfbtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sirketanasfbtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sirketanasfbtn.Appearance.Options.UseFont = true;
            this.sirketanasfbtn.Appearance.Options.UseForeColor = true;
            this.sirketanasfbtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.company;
            this.sirketanasfbtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sirketanasfbtn.Location = new System.Drawing.Point(0, 293);
            this.sirketanasfbtn.Name = "sirketanasfbtn";
            this.sirketanasfbtn.Size = new System.Drawing.Size(76, 105);
            this.sirketanasfbtn.TabIndex = 5;
            this.sirketanasfbtn.Click += new System.EventHandler(this.sirketanasfbtn_Click_1);
            // 
            // ayarlarbtn
            // 
            this.ayarlarbtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ayarlarbtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ayarlarbtn.Appearance.Options.UseFont = true;
            this.ayarlarbtn.Appearance.Options.UseForeColor = true;
            this.ayarlarbtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.wrench__1_;
            this.ayarlarbtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.ayarlarbtn.Location = new System.Drawing.Point(0, 722);
            this.ayarlarbtn.Name = "ayarlarbtn";
            this.ayarlarbtn.Size = new System.Drawing.Size(76, 105);
            this.ayarlarbtn.TabIndex = 4;
            this.ayarlarbtn.Click += new System.EventHandler(this.ayarlarbtn_Click);
            // 
            // raporbtn
            // 
            this.raporbtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporbtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.raporbtn.Appearance.Options.UseFont = true;
            this.raporbtn.Appearance.Options.UseForeColor = true;
            this.raporbtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.file;
            this.raporbtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.raporbtn.Location = new System.Drawing.Point(2, 616);
            this.raporbtn.Name = "raporbtn";
            this.raporbtn.Size = new System.Drawing.Size(74, 100);
            this.raporbtn.TabIndex = 3;
            this.raporbtn.Click += new System.EventHandler(this.raporbtn_Click);
            // 
            // mesajislembtn
            // 
            this.mesajislembtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mesajislembtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mesajislembtn.Appearance.Options.UseFont = true;
            this.mesajislembtn.Appearance.Options.UseForeColor = true;
            this.mesajislembtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.email;
            this.mesajislembtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.mesajislembtn.Location = new System.Drawing.Point(2, 510);
            this.mesajislembtn.Name = "mesajislembtn";
            this.mesajislembtn.Size = new System.Drawing.Size(74, 100);
            this.mesajislembtn.TabIndex = 2;
            this.mesajislembtn.Click += new System.EventHandler(this.mesajislembtn_Click);
            // 
            // caribtn
            // 
            this.caribtn.Appearance.Font = new System.Drawing.Font("Sitka Subheading", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.caribtn.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.caribtn.Appearance.Options.UseFont = true;
            this.caribtn.Appearance.Options.UseForeColor = true;
            this.caribtn.ImageOptions.Image = global::SmsGondermeProje3.Properties.Resources.user__1_;
            this.caribtn.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.caribtn.Location = new System.Drawing.Point(2, 404);
            this.caribtn.Name = "caribtn";
            this.caribtn.Size = new System.Drawing.Size(74, 100);
            this.caribtn.TabIndex = 1;
            this.caribtn.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // msgtimer
            // 
            this.msgtimer.Enabled = true;
            this.msgtimer.Interval = 60100;
            this.msgtimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 869);
            this.Controls.Add(this.panelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj Gönderme Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ayarlarbtn;
        private DevExpress.XtraEditors.SimpleButton raporbtn;
        private DevExpress.XtraEditors.SimpleButton mesajislembtn;
        private DevExpress.XtraEditors.SimpleButton caribtn;
        private DevExpress.XtraEditors.SimpleButton sirketanasfbtn;
        private DevExpress.XtraEditors.SimpleButton anasfbtn;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Timer msgtimer;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.Timer timer1;
    }
}