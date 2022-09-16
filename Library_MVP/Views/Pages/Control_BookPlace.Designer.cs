
namespace Library_MVP.Views.Pages
{
    partial class Control_BookPlace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_BookPlace));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery2 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.PL_EditText = new System.Windows.Forms.Panel();
            this.txbNameBookPlace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDBookPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PL_ControlsButton = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimerAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefriche = new DevExpress.XtraEditors.SimpleButton();
            this.PL_Container = new System.Windows.Forms.Panel();
            this.gridControlBookPlace = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewBookPlace = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colرقمالمكان = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colاسمالمكان = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.PL_EditText.SuspendLayout();
            this.PL_ControlsButton.SuspendLayout();
            this.PL_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBookPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBookPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // PL_EditText
            // 
            this.PL_EditText.Controls.Add(this.txbNameBookPlace);
            this.PL_EditText.Controls.Add(this.label2);
            this.PL_EditText.Controls.Add(this.txbIDBookPlace);
            this.PL_EditText.Controls.Add(this.label1);
            this.PL_EditText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_EditText.Location = new System.Drawing.Point(0, 0);
            this.PL_EditText.Name = "PL_EditText";
            this.PL_EditText.Size = new System.Drawing.Size(866, 56);
            this.PL_EditText.TabIndex = 0;
            // 
            // txbNameBookPlace
            // 
            this.txbNameBookPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNameBookPlace.Location = new System.Drawing.Point(44, 16);
            this.txbNameBookPlace.MaxLength = 100;
            this.txbNameBookPlace.Name = "txbNameBookPlace";
            this.txbNameBookPlace.Size = new System.Drawing.Size(292, 24);
            this.txbNameBookPlace.TabIndex = 109;
            this.txbNameBookPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 112;
            this.label2.Text = "اسم المكان  :";
            // 
            // txbIDBookPlace
            // 
            this.txbIDBookPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIDBookPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDBookPlace.Location = new System.Drawing.Point(470, 16);
            this.txbIDBookPlace.MaxLength = 15;
            this.txbIDBookPlace.Name = "txbIDBookPlace";
            this.txbIDBookPlace.ReadOnly = true;
            this.txbIDBookPlace.Size = new System.Drawing.Size(268, 24);
            this.txbIDBookPlace.TabIndex = 111;
            this.txbIDBookPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 110;
            this.label1.Text = "رقم المكان :";
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
            this.btnPrint.TabIndex = 24;
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
            this.btnAdd.TabIndex = 19;
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
            this.btnModifier.TabIndex = 20;
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
            this.btnSuprimer.TabIndex = 21;
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
            this.btnSuprimerAll.TabIndex = 22;
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
            this.btnRefriche.TabIndex = 23;
            this.btnRefriche.Text = "تحديث";
            this.btnRefriche.Click += new System.EventHandler(this.btnRefriche_Click);
            // 
            // PL_Container
            // 
            this.PL_Container.Controls.Add(this.gridControlBookPlace);
            this.PL_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PL_Container.Location = new System.Drawing.Point(0, 56);
            this.PL_Container.Name = "PL_Container";
            this.PL_Container.Size = new System.Drawing.Size(866, 435);
            this.PL_Container.TabIndex = 2;
            // 
            // gridControlBookPlace
            // 
            this.gridControlBookPlace.DataMember = "placeGetAll";
            this.gridControlBookPlace.DataSource = this.sqlDataSource1;
            this.gridControlBookPlace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBookPlace.Location = new System.Drawing.Point(0, 0);
            this.gridControlBookPlace.MainView = this.gridViewBookPlace;
            this.gridControlBookPlace.Name = "gridControlBookPlace";
            this.gridControlBookPlace.Size = new System.Drawing.Size(866, 435);
            this.gridControlBookPlace.TabIndex = 0;
            this.gridControlBookPlace.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBookPlace});
            this.gridControlBookPlace.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Library_Pro_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery2.Name = "placeGetAll";
            storedProcQuery2.StoredProcName = "placeGetAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery2});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewBookPlace
            // 
            this.gridViewBookPlace.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.Empty.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.OddRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.Preview.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.Row.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.VertLine.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewBookPlace.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewBookPlace.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Lines.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.Lines.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewBookPlace.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewBookPlace.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewBookPlace.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewBookPlace.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewBookPlace.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colرقمالمكان,
            this.colاسمالمكان});
            this.gridViewBookPlace.GridControl = this.gridControlBookPlace;
            this.gridViewBookPlace.Name = "gridViewBookPlace";
            this.gridViewBookPlace.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewBookPlace.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // colرقمالمكان
            // 
            this.colرقمالمكان.FieldName = "رقم المكان";
            this.colرقمالمكان.Name = "colرقمالمكان";
            this.colرقمالمكان.OptionsColumn.AllowEdit = false;
            this.colرقمالمكان.OptionsColumn.AllowFocus = false;
            this.colرقمالمكان.Visible = true;
            this.colرقمالمكان.VisibleIndex = 0;
            // 
            // colاسمالمكان
            // 
            this.colاسمالمكان.FieldName = "اسم المكان";
            this.colاسمالمكان.Name = "colاسمالمكان";
            this.colاسمالمكان.OptionsColumn.AllowEdit = false;
            this.colاسمالمكان.OptionsColumn.AllowFocus = false;
            this.colاسمالمكان.Visible = true;
            this.colاسمالمكان.VisibleIndex = 1;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "93be915c-711d-4ed9-aff3-b895656d696d";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("3781fe64-5293-41c7-868f-d2f838e0dd43", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية بنجاح", "تمت عملية بنجاح", "تمت عملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("e17aa1d8-200a-4ca1-b503-1a631220eea9", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "خطأ في العملية", "خطأ في العملية", "خطأ في العملية", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Control_BookPlace
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PL_Container);
            this.Controls.Add(this.PL_ControlsButton);
            this.Controls.Add(this.PL_EditText);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_BookPlace";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(866, 537);
            this.Load += new System.EventHandler(this.Control_BookPlace_Load);
            this.PL_EditText.ResumeLayout(false);
            this.PL_EditText.PerformLayout();
            this.PL_ControlsButton.ResumeLayout(false);
            this.PL_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBookPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBookPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PL_EditText;
        private System.Windows.Forms.Panel PL_ControlsButton;
        private System.Windows.Forms.Panel PL_Container;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSuprimer;
        private DevExpress.XtraEditors.SimpleButton btnSuprimerAll;
        private DevExpress.XtraEditors.SimpleButton btnRefriche;
        public System.Windows.Forms.TextBox txbNameBookPlace;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txbIDBookPlace;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlBookPlace;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBookPlace;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colرقمالمكان;
        private DevExpress.XtraGrid.Columns.GridColumn colاسمالمكان;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
    }
}
