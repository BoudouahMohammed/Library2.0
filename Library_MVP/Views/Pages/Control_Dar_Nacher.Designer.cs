
namespace Library_MVP.Views.Pages
{
    partial class Control_Dar_Nacher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Dar_Nacher));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.PL_EditText = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCountryDarNacher = new System.Windows.Forms.ComboBox();
            this.txbNameDarNacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDarNacherID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PL_ControlsButton = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimerAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefriche = new DevExpress.XtraEditors.SimpleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControlDarNacher = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewDarNacher = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالدار = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالدار = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالدولة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.PL_EditText.SuspendLayout();
            this.PL_ControlsButton.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDarNacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDarNacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // PL_EditText
            // 
            this.PL_EditText.Controls.Add(this.label3);
            this.PL_EditText.Controls.Add(this.cmbCountryDarNacher);
            this.PL_EditText.Controls.Add(this.txbNameDarNacher);
            this.PL_EditText.Controls.Add(this.label2);
            this.PL_EditText.Controls.Add(this.txbDarNacherID);
            this.PL_EditText.Controls.Add(this.label1);
            this.PL_EditText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_EditText.Location = new System.Drawing.Point(0, 0);
            this.PL_EditText.Name = "PL_EditText";
            this.PL_EditText.Size = new System.Drawing.Size(866, 56);
            this.PL_EditText.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 117;
            this.label3.Text = "الدولة :";
            // 
            // cmbCountryDarNacher
            // 
            this.cmbCountryDarNacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCountryDarNacher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCountryDarNacher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountryDarNacher.FormattingEnabled = true;
            this.cmbCountryDarNacher.Location = new System.Drawing.Point(4, 16);
            this.cmbCountryDarNacher.Name = "cmbCountryDarNacher";
            this.cmbCountryDarNacher.Size = new System.Drawing.Size(166, 24);
            this.cmbCountryDarNacher.TabIndex = 118;
            // 
            // txbNameDarNacher
            // 
            this.txbNameDarNacher.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNameDarNacher.Location = new System.Drawing.Point(263, 16);
            this.txbNameDarNacher.MaxLength = 100;
            this.txbNameDarNacher.Name = "txbNameDarNacher";
            this.txbNameDarNacher.Size = new System.Drawing.Size(214, 24);
            this.txbNameDarNacher.TabIndex = 113;
            this.txbNameDarNacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 116;
            this.label2.Text = "اسم الدار :";
            // 
            // txbDarNacherID
            // 
            this.txbDarNacherID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbDarNacherID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbDarNacherID.Location = new System.Drawing.Point(608, 16);
            this.txbDarNacherID.MaxLength = 15;
            this.txbDarNacherID.Name = "txbDarNacherID";
            this.txbDarNacherID.ReadOnly = true;
            this.txbDarNacherID.Size = new System.Drawing.Size(174, 24);
            this.txbDarNacherID.TabIndex = 115;
            this.txbDarNacherID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "رقم الدار :";
            // 
            // PL_ControlsButton
            // 
            this.PL_ControlsButton.Controls.Add(this.btnPrint);
            this.PL_ControlsButton.Controls.Add(this.btnAdd);
            this.PL_ControlsButton.Controls.Add(this.btnModifier);
            this.PL_ControlsButton.Controls.Add(this.btnSuprimer);
            this.PL_ControlsButton.Controls.Add(this.btnSuprimerAll);
            this.PL_ControlsButton.Controls.Add(this.btnRefriche);
            this.PL_ControlsButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PL_ControlsButton.Location = new System.Drawing.Point(0, 491);
            this.PL_ControlsButton.Name = "PL_ControlsButton";
            this.PL_ControlsButton.Size = new System.Drawing.Size(866, 46);
            this.PL_ControlsButton.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(97, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 31);
            this.btnPrint.TabIndex = 30;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(662, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnModifier.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Appearance.Options.UseFont = true;
            this.btnModifier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.ImageOptions.Image")));
            this.btnModifier.Location = new System.Drawing.Point(549, 8);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(107, 31);
            this.btnModifier.TabIndex = 26;
            this.btnModifier.Text = "تعديل";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuprimer.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimer.Appearance.Options.UseFont = true;
            this.btnSuprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuprimer.ImageOptions.Image")));
            this.btnSuprimer.Location = new System.Drawing.Point(436, 8);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(107, 31);
            this.btnSuprimer.TabIndex = 27;
            this.btnSuprimer.Text = "حذف";
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnSuprimerAll
            // 
            this.btnSuprimerAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuprimerAll.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimerAll.Appearance.Options.UseFont = true;
            this.btnSuprimerAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuprimerAll.ImageOptions.SvgImage")));
            this.btnSuprimerAll.Location = new System.Drawing.Point(323, 8);
            this.btnSuprimerAll.Name = "btnSuprimerAll";
            this.btnSuprimerAll.Size = new System.Drawing.Size(107, 31);
            this.btnSuprimerAll.TabIndex = 28;
            this.btnSuprimerAll.Text = "حذف الكل";
            this.btnSuprimerAll.Click += new System.EventHandler(this.btnSuprimerAll_Click);
            // 
            // btnRefriche
            // 
            this.btnRefriche.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefriche.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefriche.Appearance.Options.UseFont = true;
            this.btnRefriche.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefriche.ImageOptions.Image")));
            this.btnRefriche.Location = new System.Drawing.Point(210, 8);
            this.btnRefriche.Name = "btnRefriche";
            this.btnRefriche.Size = new System.Drawing.Size(107, 31);
            this.btnRefriche.TabIndex = 29;
            this.btnRefriche.Text = "تحديث";
            this.btnRefriche.Click += new System.EventHandler(this.btnRefriche_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControlDarNacher);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 435);
            this.panel3.TabIndex = 2;
            // 
            // gridControlDarNacher
            // 
            this.gridControlDarNacher.DataMember = "dar_NashrGetAll";
            this.gridControlDarNacher.DataSource = this.sqlDataSource1;
            this.gridControlDarNacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDarNacher.Location = new System.Drawing.Point(0, 0);
            this.gridControlDarNacher.MainView = this.gridViewDarNacher;
            this.gridControlDarNacher.Name = "gridControlDarNacher";
            this.gridControlDarNacher.Size = new System.Drawing.Size(866, 435);
            this.gridControlDarNacher.TabIndex = 0;
            this.gridControlDarNacher.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDarNacher});
            this.gridControlDarNacher.DoubleClick += new System.EventHandler(this.gridControlDarNacher_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Library_Pro_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "dar_NashrGetAll";
            storedProcQuery1.StoredProcName = "dar_NashrGetAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewDarNacher
            // 
            this.gridViewDarNacher.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.Empty.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.OddRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.Preview.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.Row.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.VertLine.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewDarNacher.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewDarNacher.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Lines.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.Lines.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewDarNacher.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewDarNacher.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewDarNacher.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDarNacher.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewDarNacher.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالدار,
            this.colاسمالدار,
            this.colاسمالدولة});
            this.gridViewDarNacher.GridControl = this.gridControlDarNacher;
            this.gridViewDarNacher.Name = "gridViewDarNacher";
            this.gridViewDarNacher.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewDarNacher.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colرقمالدار
            // 
            this.colرقمالدار.FieldName = "رقم الدار";
            this.colرقمالدار.Name = "colرقمالدار";
            this.colرقمالدار.OptionsColumn.AllowEdit = false;
            this.colرقمالدار.OptionsColumn.AllowFocus = false;
            this.colرقمالدار.Visible = true;
            this.colرقمالدار.VisibleIndex = 0;
            // 
            // colاسمالدار
            // 
            this.colاسمالدار.FieldName = "اسم الدار";
            this.colاسمالدار.Name = "colاسمالدار";
            this.colاسمالدار.OptionsColumn.AllowEdit = false;
            this.colاسمالدار.OptionsColumn.AllowFocus = false;
            this.colاسمالدار.Visible = true;
            this.colاسمالدار.VisibleIndex = 1;
            // 
            // colاسمالدولة
            // 
            this.colاسمالدولة.FieldName = "اسم الدولة";
            this.colاسمالدولة.Name = "colاسمالدولة";
            this.colاسمالدولة.OptionsColumn.AllowEdit = false;
            this.colاسمالدولة.OptionsColumn.AllowFocus = false;
            this.colاسمالدولة.Visible = true;
            this.colاسمالدولة.VisibleIndex = 2;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "93be915c-711d-4ed9-aff3-b895656d696d";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("593b50ab-82a4-443f-8d4c-2aa8d3c3ff74", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية بنجاح", "تمت عملية بنجاح", "تمت عملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("6e46b25d-00b4-409b-964d-86e8dfc3fb9f", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "خطأ في العملية", "خطأ في العملية", "خطأ في العملية", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Control_Dar_Nacher
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PL_ControlsButton);
            this.Controls.Add(this.PL_EditText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Dar_Nacher";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(866, 537);
            this.Load += new System.EventHandler(this.Control_Dar_Nacher_Load);
            this.PL_EditText.ResumeLayout(false);
            this.PL_EditText.PerformLayout();
            this.PL_ControlsButton.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDarNacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDarNacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PL_EditText;
        private System.Windows.Forms.Panel PL_ControlsButton;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSuprimer;
        private DevExpress.XtraEditors.SimpleButton btnSuprimerAll;
        private DevExpress.XtraEditors.SimpleButton btnRefriche;
        public System.Windows.Forms.TextBox txbNameDarNacher;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbDarNacherID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCountryDarNacher;
        private DevExpress.XtraGrid.GridControl gridControlDarNacher;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDarNacher;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالدار;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالدار;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالدولة;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
