
namespace Library_MVP.Views.Pages
{
    partial class Control_Author
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Author));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.dateTimeAuther = new System.Windows.Forms.DateTimePicker();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PL_ControlsButton = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimerAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefriche = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControlAuthor = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewAuthor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمؤلف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالمؤلف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colالتاريخ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالدولة = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.panel2.SuspendLayout();
            this.PL_ControlsButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeAuther
            // 
            this.dateTimeAuther.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimeAuther.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeAuther.Location = new System.Drawing.Point(17, 198);
            this.dateTimeAuther.Name = "dateTimeAuther";
            this.dateTimeAuther.Size = new System.Drawing.Size(166, 24);
            this.dateTimeAuther.TabIndex = 11;
            // 
            // cmbCountry
            // 
            this.cmbCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbCountry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCountry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(17, 261);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(166, 24);
            this.cmbCountry.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "الدولة :";
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbName.Location = new System.Drawing.Point(17, 127);
            this.txbName.MaxLength = 100;
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(166, 24);
            this.txbName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "اسم المؤلف  :";
            // 
            // txbID
            // 
            this.txbID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbID.Location = new System.Drawing.Point(17, 63);
            this.txbID.MaxLength = 15;
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(166, 24);
            this.txbID.TabIndex = 6;
            this.txbID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "رقم المؤلف :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PL_ControlsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 46);
            this.panel2.TabIndex = 1;
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
            this.PL_ControlsButton.Location = new System.Drawing.Point(0, 0);
            this.PL_ControlsButton.Name = "PL_ControlsButton";
            this.PL_ControlsButton.Size = new System.Drawing.Size(866, 46);
            this.PL_ControlsButton.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPrint.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(97, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 31);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Location = new System.Drawing.Point(662, 8);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 31);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnModifier.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Appearance.Options.UseFont = true;
            this.btnModifier.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.ImageOptions.Image")));
            this.btnModifier.Location = new System.Drawing.Point(549, 8);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(107, 31);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.Text = "تعديل";
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSuprimer.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimer.Appearance.Options.UseFont = true;
            this.btnSuprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuprimer.ImageOptions.Image")));
            this.btnSuprimer.Location = new System.Drawing.Point(436, 8);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(107, 31);
            this.btnSuprimer.TabIndex = 15;
            this.btnSuprimer.Text = "حذف";
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // btnSuprimerAll
            // 
            this.btnSuprimerAll.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSuprimerAll.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuprimerAll.Appearance.Options.UseFont = true;
            this.btnSuprimerAll.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuprimerAll.ImageOptions.SvgImage")));
            this.btnSuprimerAll.Location = new System.Drawing.Point(323, 8);
            this.btnSuprimerAll.Name = "btnSuprimerAll";
            this.btnSuprimerAll.Size = new System.Drawing.Size(107, 31);
            this.btnSuprimerAll.TabIndex = 16;
            this.btnSuprimerAll.Text = "حذف الكل";
            this.btnSuprimerAll.Click += new System.EventHandler(this.btnSuprimerAll_Click);
            // 
            // btnRefriche
            // 
            this.btnRefriche.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefriche.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefriche.Appearance.Options.UseFont = true;
            this.btnRefriche.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRefriche.ImageOptions.Image")));
            this.btnRefriche.Location = new System.Drawing.Point(210, 8);
            this.btnRefriche.Name = "btnRefriche";
            this.btnRefriche.Size = new System.Drawing.Size(107, 31);
            this.btnRefriche.TabIndex = 17;
            this.btnRefriche.Text = "تحديث";
            this.btnRefriche.Click += new System.EventHandler(this.btnRefriche_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimeAuther);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbCountry);
            this.panel1.Controls.Add(this.txbID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(666, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 491);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "الدولة :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControlAuthor);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(666, 491);
            this.panel3.TabIndex = 4;
            // 
            // gridControlAuthor
            // 
            this.gridControlAuthor.DataMember = "authorGetAll";
            this.gridControlAuthor.DataSource = this.sqlDataSource1;
            this.gridControlAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAuthor.Location = new System.Drawing.Point(0, 0);
            this.gridControlAuthor.MainView = this.gridViewAuthor;
            this.gridControlAuthor.Name = "gridControlAuthor";
            this.gridControlAuthor.Size = new System.Drawing.Size(666, 491);
            this.gridControlAuthor.TabIndex = 0;
            this.gridControlAuthor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAuthor});
            this.gridControlAuthor.DoubleClick += new System.EventHandler(this.gridControlAuthor_DoubleClick_1);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Library_Pro_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "authorGetAll";
            storedProcQuery2.StoredProcName = "authorGetAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewAuthor
            // 
            this.gridViewAuthor.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewAuthor.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewAuthor.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewAuthor.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewAuthor.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.Empty.Options.UseFont = true;
            this.gridViewAuthor.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewAuthor.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewAuthor.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewAuthor.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewAuthor.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewAuthor.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewAuthor.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.OddRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.Preview.Options.UseFont = true;
            this.gridViewAuthor.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.Row.Options.UseFont = true;
            this.gridViewAuthor.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewAuthor.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewAuthor.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.VertLine.Options.UseFont = true;
            this.gridViewAuthor.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewAuthor.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewAuthor.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Lines.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.Lines.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewAuthor.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewAuthor.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewAuthor.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewAuthor.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewAuthor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالمؤلف,
            this.colاسمالمؤلف,
            this.colالتاريخ,
            this.colاسمالدولة});
            this.gridViewAuthor.GridControl = this.gridControlAuthor;
            this.gridViewAuthor.Name = "gridViewAuthor";
            this.gridViewAuthor.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewAuthor.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colرقمالمؤلف
            // 
            this.colرقمالمؤلف.FieldName = "رقم المؤلف";
            this.colرقمالمؤلف.Name = "colرقمالمؤلف";
            this.colرقمالمؤلف.OptionsColumn.AllowEdit = false;
            this.colرقمالمؤلف.OptionsColumn.AllowFocus = false;
            this.colرقمالمؤلف.Visible = true;
            this.colرقمالمؤلف.VisibleIndex = 0;
            // 
            // colاسمالمؤلف
            // 
            this.colاسمالمؤلف.FieldName = "اسم المؤلف";
            this.colاسمالمؤلف.Name = "colاسمالمؤلف";
            this.colاسمالمؤلف.OptionsColumn.AllowEdit = false;
            this.colاسمالمؤلف.OptionsColumn.AllowFocus = false;
            this.colاسمالمؤلف.Visible = true;
            this.colاسمالمؤلف.VisibleIndex = 1;
            // 
            // colالتاريخ
            // 
            this.colالتاريخ.FieldName = "التاريخ";
            this.colالتاريخ.Name = "colالتاريخ";
            this.colالتاريخ.OptionsColumn.AllowEdit = false;
            this.colالتاريخ.OptionsColumn.AllowFocus = false;
            this.colالتاريخ.Visible = true;
            this.colالتاريخ.VisibleIndex = 2;
            // 
            // colاسمالدولة
            // 
            this.colاسمالدولة.FieldName = "اسم الدولة";
            this.colاسمالدولة.Name = "colاسمالدولة";
            this.colاسمالدولة.OptionsColumn.AllowEdit = false;
            this.colاسمالدولة.OptionsColumn.AllowFocus = false;
            this.colاسمالدولة.Visible = true;
            this.colاسمالدولة.VisibleIndex = 3;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "93be915c-711d-4ed9-aff3-b895656d696d";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("96e27447-c7cc-405b-ae54-2aa4f6885d0c", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية بنجاح", "تمت عملية بنجاح", "تمت عملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("4a64b4ac-a880-4bbe-9ab9-dab9b4a88874", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "خطأ في العملية", "خطأ في العملية", "خطأ في العملية", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Control_Author
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Author";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(866, 537);
            this.Load += new System.EventHandler(this.Control_Auther_Load);
            this.panel2.ResumeLayout(false);
            this.PL_ControlsButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PL_ControlsButton;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSuprimer;
        private DevExpress.XtraEditors.SimpleButton btnSuprimerAll;
        private DevExpress.XtraEditors.SimpleButton btnRefriche;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraGrid.GridControl gridControlAuthor;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewAuthor;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمؤلف;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالمؤلف;
        private DevExpress.XtraGrid.Columns.GridColumn colالتاريخ;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالدولة;
        private System.Windows.Forms.DateTimePicker dateTimeAuther;
    }
}
