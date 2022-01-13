
namespace SmsGondermeProje3.Forms
{
    partial class Sirketfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sirketfrm));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.kaydetbtn = new DevExpress.XtraEditors.SimpleButton();
            this.dbsec = new DevExpress.XtraEditors.SimpleButton();
            this.databasetext = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kullanicitext = new System.Windows.Forms.TextBox();
            this.sunucutext = new System.Windows.Forms.TextBox();
            this.sirkettext = new System.Windows.Forms.TextBox();
            this.kullanicisifretext = new System.Windows.Forms.TextBox();
            this.sirketeklebtn = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.silcolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sil = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.baglancolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.baglan = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.duzenlecolumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.duzenle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Db_Kullanici = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sirket_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sunucu_Adi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Db_Sifre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Database_Yolu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baglan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Appearance.Options.UseBorderColor = true;
            this.panelControl1.Controls.Add(this.xtraTabControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(306, 723);
            this.panelControl1.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.Black;
            this.xtraTabControl1.Appearance.BackColor2 = System.Drawing.Color.Linen;
            this.xtraTabControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xtraTabControl1.Appearance.ForeColor = System.Drawing.Color.Linen;
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.Appearance.Options.UseFont = true;
            this.xtraTabControl1.Appearance.Options.UseForeColor = true;
            this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(302, 719);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.DarkRed;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Controls.Add(this.kaydetbtn);
            this.xtraTabPage1.Controls.Add(this.dbsec);
            this.xtraTabPage1.Controls.Add(this.databasetext);
            this.xtraTabPage1.Controls.Add(this.label10);
            this.xtraTabPage1.Controls.Add(this.kullanicitext);
            this.xtraTabPage1.Controls.Add(this.sunucutext);
            this.xtraTabPage1.Controls.Add(this.sirkettext);
            this.xtraTabPage1.Controls.Add(this.kullanicisifretext);
            this.xtraTabPage1.Controls.Add(this.sirketeklebtn);
            this.xtraTabPage1.Controls.Add(this.label1);
            this.xtraTabPage1.Controls.Add(this.label2);
            this.xtraTabPage1.Controls.Add(this.label3);
            this.xtraTabPage1.Controls.Add(this.label4);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(300, 694);
            this.xtraTabPage1.Text = "Şirket Ekle";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kaydetbtn.Appearance.Options.UseFont = true;
            this.kaydetbtn.Appearance.Options.UseForeColor = true;
            this.kaydetbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("kaydetbtn.ImageOptions.Image")));
            this.kaydetbtn.Location = new System.Drawing.Point(127, 185);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(145, 27);
            this.kaydetbtn.TabIndex = 33;
            this.kaydetbtn.Text = "Değişiklikleri Kaydet";
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click);
            // 
            // dbsec
            // 
            this.dbsec.Appearance.ForeColor = System.Drawing.Color.Linen;
            this.dbsec.Appearance.Options.UseForeColor = true;
            this.dbsec.Location = new System.Drawing.Point(247, 147);
            this.dbsec.Name = "dbsec";
            this.dbsec.Size = new System.Drawing.Size(31, 22);
            this.dbsec.TabIndex = 32;
            this.dbsec.Text = "Aç";
            this.dbsec.Click += new System.EventHandler(this.dbsec_Click);
            // 
            // databasetext
            // 
            this.databasetext.Location = new System.Drawing.Point(111, 148);
            this.databasetext.Name = "databasetext";
            this.databasetext.Size = new System.Drawing.Size(130, 21);
            this.databasetext.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Linen;
            this.label10.Location = new System.Drawing.Point(58, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "Şifre:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // kullanicitext
            // 
            this.kullanicitext.Location = new System.Drawing.Point(111, 65);
            this.kullanicitext.Name = "kullanicitext";
            this.kullanicitext.Size = new System.Drawing.Size(142, 21);
            this.kullanicitext.TabIndex = 29;
            // 
            // sunucutext
            // 
            this.sunucutext.Location = new System.Drawing.Point(111, 119);
            this.sunucutext.Name = "sunucutext";
            this.sunucutext.Size = new System.Drawing.Size(142, 21);
            this.sunucutext.TabIndex = 28;
            // 
            // sirkettext
            // 
            this.sirkettext.Location = new System.Drawing.Point(111, 38);
            this.sirkettext.Name = "sirkettext";
            this.sirkettext.Size = new System.Drawing.Size(142, 21);
            this.sirkettext.TabIndex = 27;
            // 
            // kullanicisifretext
            // 
            this.kullanicisifretext.Location = new System.Drawing.Point(111, 92);
            this.kullanicisifretext.Name = "kullanicisifretext";
            this.kullanicisifretext.Size = new System.Drawing.Size(142, 21);
            this.kullanicisifretext.TabIndex = 26;
            // 
            // sirketeklebtn
            // 
            this.sirketeklebtn.Appearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.sirketeklebtn.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sirketeklebtn.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.sirketeklebtn.Appearance.Options.UseBorderColor = true;
            this.sirketeklebtn.Appearance.Options.UseFont = true;
            this.sirketeklebtn.Appearance.Options.UseForeColor = true;
            this.sirketeklebtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sirketeklebtn.ImageOptions.Image")));
            this.sirketeklebtn.Location = new System.Drawing.Point(23, 218);
            this.sirketeklebtn.Name = "sirketeklebtn";
            this.sirketeklebtn.Size = new System.Drawing.Size(255, 47);
            this.sirketeklebtn.TabIndex = 12;
            this.sirketeklebtn.Text = "Şirket Ekle";
            this.sirketeklebtn.Click += new System.EventHandler(this.sirketeklebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Linen;
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sunucu Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Linen;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şirket Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Linen;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(47, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dosya:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(306, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.baglan,
            this.sil,
            this.duzenle});
            this.gridControl1.Size = new System.Drawing.Size(1042, 723);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Linen;
            this.gridView1.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedCell.Options.UseFont = true;
            this.gridView1.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Linen;
            this.gridView1.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.Options.UseFont = true;
            this.gridView1.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.gridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView1.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Transparent;
            this.gridView1.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F);
            this.gridView1.Appearance.Row.ForeColor = System.Drawing.Color.Linen;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseFont = true;
            this.gridView1.Appearance.Row.Options.UseForeColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.silcolumn,
            this.baglancolumn,
            this.duzenlecolumn,
            this.Db_Kullanici,
            this.Sirket_Adi,
            this.Sunucu_Adi,
            this.Db_Sifre,
            this.Database_Yolu,
            this.ID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // silcolumn
            // 
            this.silcolumn.ColumnEdit = this.sil;
            this.silcolumn.Name = "silcolumn";
            this.silcolumn.OptionsColumn.AllowMove = false;
            this.silcolumn.Visible = true;
            this.silcolumn.VisibleIndex = 7;
            // 
            // sil
            // 
            this.sil.AutoHeight = false;
            this.sil.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.sil.Name = "sil";
            this.sil.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.sil.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.sil_ButtonClick);
            // 
            // baglancolumn
            // 
            this.baglancolumn.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.baglancolumn.AppearanceCell.Options.UseForeColor = true;
            this.baglancolumn.ColumnEdit = this.baglan;
            this.baglancolumn.Name = "baglancolumn";
            this.baglancolumn.OptionsColumn.AllowMove = false;
            this.baglancolumn.Visible = true;
            this.baglancolumn.VisibleIndex = 5;
            // 
            // baglan
            // 
            this.baglan.AutoHeight = false;
            this.baglan.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK, "Bağlan", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.baglan.Name = "baglan";
            this.baglan.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.baglan.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.baglan_ButtonClick);
            // 
            // duzenlecolumn
            // 
            this.duzenlecolumn.ColumnEdit = this.duzenle;
            this.duzenlecolumn.Name = "duzenlecolumn";
            this.duzenlecolumn.OptionsColumn.AllowMove = false;
            this.duzenlecolumn.Visible = true;
            this.duzenlecolumn.VisibleIndex = 6;
            // 
            // duzenle
            // 
            this.duzenle.AutoHeight = false;
            this.duzenle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.duzenle.Name = "duzenle";
            this.duzenle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.duzenle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.duzenle_ButtonClick);
            // 
            // Db_Kullanici
            // 
            this.Db_Kullanici.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Db_Kullanici.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Db_Kullanici.AppearanceHeader.Options.UseFont = true;
            this.Db_Kullanici.AppearanceHeader.Options.UseForeColor = true;
            this.Db_Kullanici.Caption = "Kullanıcı Adı";
            this.Db_Kullanici.FieldName = "Db_Kullanici";
            this.Db_Kullanici.Name = "Db_Kullanici";
            this.Db_Kullanici.OptionsColumn.AllowEdit = false;
            this.Db_Kullanici.OptionsColumn.AllowMove = false;
            this.Db_Kullanici.Visible = true;
            this.Db_Kullanici.VisibleIndex = 1;
            // 
            // Sirket_Adi
            // 
            this.Sirket_Adi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sirket_Adi.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sirket_Adi.AppearanceHeader.Options.UseFont = true;
            this.Sirket_Adi.AppearanceHeader.Options.UseForeColor = true;
            this.Sirket_Adi.Caption = "Şirket Adı";
            this.Sirket_Adi.FieldName = "Sirket_Adi";
            this.Sirket_Adi.Name = "Sirket_Adi";
            this.Sirket_Adi.OptionsColumn.AllowEdit = false;
            this.Sirket_Adi.OptionsColumn.AllowMove = false;
            this.Sirket_Adi.Visible = true;
            this.Sirket_Adi.VisibleIndex = 0;
            // 
            // Sunucu_Adi
            // 
            this.Sunucu_Adi.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sunucu_Adi.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Sunucu_Adi.AppearanceHeader.Options.UseFont = true;
            this.Sunucu_Adi.AppearanceHeader.Options.UseForeColor = true;
            this.Sunucu_Adi.Caption = "Sunucu Adı";
            this.Sunucu_Adi.FieldName = "Sunucu_Adi";
            this.Sunucu_Adi.Name = "Sunucu_Adi";
            this.Sunucu_Adi.OptionsColumn.AllowEdit = false;
            this.Sunucu_Adi.OptionsColumn.AllowMove = false;
            this.Sunucu_Adi.Visible = true;
            this.Sunucu_Adi.VisibleIndex = 3;
            // 
            // Db_Sifre
            // 
            this.Db_Sifre.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Db_Sifre.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Db_Sifre.AppearanceHeader.Options.UseFont = true;
            this.Db_Sifre.AppearanceHeader.Options.UseForeColor = true;
            this.Db_Sifre.Caption = "Şifre";
            this.Db_Sifre.FieldName = "Db_Sifre";
            this.Db_Sifre.Name = "Db_Sifre";
            this.Db_Sifre.OptionsColumn.AllowEdit = false;
            this.Db_Sifre.OptionsColumn.AllowMove = false;
            this.Db_Sifre.Visible = true;
            this.Db_Sifre.VisibleIndex = 2;
            // 
            // Database_Yolu
            // 
            this.Database_Yolu.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Database_Yolu.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Database_Yolu.AppearanceHeader.Options.UseFont = true;
            this.Database_Yolu.AppearanceHeader.Options.UseForeColor = true;
            this.Database_Yolu.Caption = "Dosya";
            this.Database_Yolu.FieldName = "Database_Yolu";
            this.Database_Yolu.Name = "Database_Yolu";
            this.Database_Yolu.OptionsColumn.AllowEdit = false;
            this.Database_Yolu.OptionsColumn.AllowMove = false;
            this.Database_Yolu.Visible = true;
            this.Database_Yolu.VisibleIndex = 4;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.AppearanceHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.AppearanceHeader.Options.UseForeColor = true;
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowMove = false;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // Sirketfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 723);
            this.ControlBox = false;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "Sirketfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şirketler";
            this.Load += new System.EventHandler(this.Sirketfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baglan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox kullanicitext;
        private System.Windows.Forms.TextBox sunucutext;
        private System.Windows.Forms.TextBox sirkettext;
        private System.Windows.Forms.TextBox kullanicisifretext;
        private DevExpress.XtraEditors.SimpleButton sirketeklebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox databasetext;
        private DevExpress.XtraEditors.SimpleButton dbsec;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit baglan;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit sil;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit duzenle;
        private DevExpress.XtraGrid.Columns.GridColumn silcolumn;
        private DevExpress.XtraGrid.Columns.GridColumn baglancolumn;
        private DevExpress.XtraGrid.Columns.GridColumn duzenlecolumn;
        private DevExpress.XtraGrid.Columns.GridColumn Db_Kullanici;
        private DevExpress.XtraGrid.Columns.GridColumn Sirket_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn Sunucu_Adi;
        private DevExpress.XtraGrid.Columns.GridColumn Db_Sifre;
        private DevExpress.XtraGrid.Columns.GridColumn Database_Yolu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton kaydetbtn;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
    }
}