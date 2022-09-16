
namespace Library_MVP.Views.Pages
{
    partial class Control_Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Category));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.PL_EditText = new System.Windows.Forms.Panel();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDCategory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PL_ControlsButton = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimerAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefriche = new DevExpress.XtraEditors.SimpleButton();
            this.PL_Container = new System.Windows.Forms.Panel();
            this.gridControlCategory = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewCategory = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالتصنيف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالتصنيف = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.PL_EditText.SuspendLayout();
            this.PL_ControlsButton.SuspendLayout();
            this.PL_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // PL_EditText
            // 
            this.PL_EditText.Controls.Add(this.txbNameCategory);
            this.PL_EditText.Controls.Add(this.label2);
            this.PL_EditText.Controls.Add(this.txbIDCategory);
            this.PL_EditText.Controls.Add(this.label1);
            this.PL_EditText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_EditText.Location = new System.Drawing.Point(0, 0);
            this.PL_EditText.Name = "PL_EditText";
            this.PL_EditText.Size = new System.Drawing.Size(866, 56);
            this.PL_EditText.TabIndex = 0;
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNameCategory.Location = new System.Drawing.Point(43, 16);
            this.txbNameCategory.MaxLength = 100;
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(292, 24);
            this.txbNameCategory.TabIndex = 105;
            this.txbNameCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 108;
            this.label2.Text = "اسم التصنيف  :";
            // 
            // txbIDCategory
            // 
            this.txbIDCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIDCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCategory.Location = new System.Drawing.Point(469, 16);
            this.txbIDCategory.MaxLength = 15;
            this.txbIDCategory.Name = "txbIDCategory";
            this.txbIDCategory.ReadOnly = true;
            this.txbIDCategory.Size = new System.Drawing.Size(268, 24);
            this.txbIDCategory.TabIndex = 107;
            this.txbIDCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 106;
            this.label1.Text = "رقم التصنيف :";
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
            this.btnPrint.TabIndex = 18;
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
            this.btnAdd.TabIndex = 13;
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
            this.btnModifier.TabIndex = 14;
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
            this.btnSuprimer.TabIndex = 15;
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
            this.btnSuprimerAll.TabIndex = 16;
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
            this.btnRefriche.TabIndex = 17;
            this.btnRefriche.Text = "تحديث";
            this.btnRefriche.Click += new System.EventHandler(this.btnRefriche_Click);
            // 
            // PL_Container
            // 
            this.PL_Container.Controls.Add(this.gridControlCategory);
            this.PL_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PL_Container.Location = new System.Drawing.Point(0, 56);
            this.PL_Container.Name = "PL_Container";
            this.PL_Container.Size = new System.Drawing.Size(866, 435);
            this.PL_Container.TabIndex = 2;
            // 
            // gridControlCategory
            // 
            this.gridControlCategory.DataMember = "categoryGetAll";
            this.gridControlCategory.DataSource = this.sqlDataSource1;
            this.gridControlCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCategory.Location = new System.Drawing.Point(0, 0);
            this.gridControlCategory.MainView = this.gridViewCategory;
            this.gridControlCategory.Name = "gridControlCategory";
            this.gridControlCategory.Size = new System.Drawing.Size(866, 435);
            this.gridControlCategory.TabIndex = 0;
            this.gridControlCategory.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategory});
            this.gridControlCategory.DoubleClick += new System.EventHandler(this.gridControlCategory_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Library_Pro_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "categoryGetAll";
            storedProcQuery1.StoredProcName = "categoryGetAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewCategory
            // 
            this.gridViewCategory.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewCategory.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewCategory.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewCategory.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewCategory.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.Empty.Options.UseFont = true;
            this.gridViewCategory.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewCategory.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewCategory.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewCategory.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewCategory.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCategory.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewCategory.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewCategory.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewCategory.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCategory.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewCategory.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.OddRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.Preview.Options.UseFont = true;
            this.gridViewCategory.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.Row.Options.UseFont = true;
            this.gridViewCategory.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewCategory.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewCategory.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.VertLine.Options.UseFont = true;
            this.gridViewCategory.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewCategory.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewCategory.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCategory.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridViewCategory.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewCategory.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCategory.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCategory.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالتصنيف,
            this.colاسمالتصنيف});
            this.gridViewCategory.GridControl = this.gridControlCategory;
            this.gridViewCategory.Name = "gridViewCategory";
            this.gridViewCategory.OptionsPrint.EnableAppearanceEvenRow = true;
            // 
            // colرقمالتصنيف
            // 
            this.colرقمالتصنيف.FieldName = "رقم التصنيف";
            this.colرقمالتصنيف.Name = "colرقمالتصنيف";
            this.colرقمالتصنيف.OptionsColumn.AllowEdit = false;
            this.colرقمالتصنيف.OptionsColumn.AllowFocus = false;
            this.colرقمالتصنيف.Visible = true;
            this.colرقمالتصنيف.VisibleIndex = 0;
            // 
            // colاسمالتصنيف
            // 
            this.colاسمالتصنيف.FieldName = "اسم التصنيف";
            this.colاسمالتصنيف.Name = "colاسمالتصنيف";
            this.colاسمالتصنيف.OptionsColumn.AllowEdit = false;
            this.colاسمالتصنيف.OptionsColumn.AllowFocus = false;
            this.colاسمالتصنيف.Visible = true;
            this.colاسمالتصنيف.VisibleIndex = 1;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "93be915c-711d-4ed9-aff3-b895656d696d";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("71956731-18dc-44cc-b3b9-0e7f5f1fe056", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية بنجاح", "تمت عملية بنجاح", "تمت عملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("46789b9d-25d7-4fbd-b527-570122da7d06", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "خطأ في العملية", "خطأ في العملية", "خطأ في العملية", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Control_Category
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PL_Container);
            this.Controls.Add(this.PL_ControlsButton);
            this.Controls.Add(this.PL_EditText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Category";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(866, 537);
            this.Load += new System.EventHandler(this.Control_Category_Load);
            this.PL_EditText.ResumeLayout(false);
            this.PL_EditText.PerformLayout();
            this.PL_ControlsButton.ResumeLayout(false);
            this.PL_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PL_EditText;
        public System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIDCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PL_ControlsButton;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSuprimer;
        private DevExpress.XtraEditors.SimpleButton btnSuprimerAll;
        private DevExpress.XtraEditors.SimpleButton btnRefriche;
        private System.Windows.Forms.Panel PL_Container;
        private DevExpress.XtraGrid.GridControl gridControlCategory;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالتصنيف;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالتصنيف;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
