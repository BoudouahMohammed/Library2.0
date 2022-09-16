
namespace Library_MVP.Views.Controls
{
    partial class Control_Country
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Control_Country));
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            this.PL_ControlsButton = new System.Windows.Forms.Panel();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnModifier = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimer = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuprimerAll = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefriche = new DevExpress.XtraEditors.SimpleButton();
            this.PL_Container = new System.Windows.Forms.Panel();
            this.PL_GridView = new System.Windows.Forms.Panel();
            this.gridControlCountry = new DevExpress.XtraGrid.GridControl();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.gridViewCountry = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.idCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.nameCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PL_EditText = new System.Windows.Forms.Panel();
            this.txbNameCountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbIDCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.PL_ControlsButton.SuspendLayout();
            this.PL_Container.SuspendLayout();
            this.PL_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).BeginInit();
            this.PL_EditText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
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
            this.btnPrint.TabIndex = 12;
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
            this.btnAdd.TabIndex = 7;
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
            this.btnModifier.TabIndex = 8;
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
            this.btnSuprimer.TabIndex = 9;
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
            this.btnSuprimerAll.TabIndex = 10;
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
            this.btnRefriche.TabIndex = 11;
            this.btnRefriche.Text = "تحديث";
            this.btnRefriche.Click += new System.EventHandler(this.btnRefriche_Click);
            // 
            // PL_Container
            // 
            this.PL_Container.Controls.Add(this.PL_GridView);
            this.PL_Container.Controls.Add(this.PL_EditText);
            this.PL_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PL_Container.Location = new System.Drawing.Point(0, 0);
            this.PL_Container.Name = "PL_Container";
            this.PL_Container.Size = new System.Drawing.Size(866, 491);
            this.PL_Container.TabIndex = 2;
            // 
            // PL_GridView
            // 
            this.PL_GridView.Controls.Add(this.gridControlCountry);
            this.PL_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PL_GridView.Location = new System.Drawing.Point(0, 56);
            this.PL_GridView.Name = "PL_GridView";
            this.PL_GridView.Size = new System.Drawing.Size(866, 435);
            this.PL_GridView.TabIndex = 2;
            // 
            // gridControlCountry
            // 
            this.gridControlCountry.DataMember = "countryGetAll";
            this.gridControlCountry.DataSource = this.sqlDataSource1;
            this.gridControlCountry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCountry.Location = new System.Drawing.Point(0, 0);
            this.gridControlCountry.MainView = this.gridViewCountry;
            this.gridControlCountry.Name = "gridControlCountry";
            this.gridControlCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControlCountry.Size = new System.Drawing.Size(866, 435);
            this.gridControlCountry.TabIndex = 1;
            this.gridControlCountry.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCountry});
            this.gridControlCountry.DoubleClick += new System.EventHandler(this.gridControlCountry_DoubleClick);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "localhost_Library_Pro_Connection";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "countryGetAll";
            storedProcQuery1.StoredProcName = "countryGetAll";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // gridViewCountry
            // 
            this.gridViewCountry.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewCountry.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewCountry.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewCountry.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewCountry.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.Empty.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.Empty.Options.UseFont = true;
            this.gridViewCountry.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewCountry.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewCountry.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewCountry.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewCountry.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewCountry.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewCountry.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewCountry.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewCountry.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewCountry.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewCountry.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.OddRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.Preview.Options.UseFont = true;
            this.gridViewCountry.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.Row.Options.UseFont = true;
            this.gridViewCountry.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewCountry.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewCountry.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.VertLine.Options.UseFont = true;
            this.gridViewCountry.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewCountry.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewCountry.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.EvenRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.EvenRow.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.FilterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.FilterPanel.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.FilterPanel.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.FooterPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.FooterPanel.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.FooterPanel.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.GroupFooter.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.GroupFooter.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.GroupFooter.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.GroupRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.GroupRow.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.GroupRow.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.HeaderPanel.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.HeaderPanel.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.Lines.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.Lines.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.Lines.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.Lines.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.Lines.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.OddRow.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.OddRow.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.OddRow.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.Preview.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.Preview.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.Preview.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.AppearancePrint.Row.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewCountry.AppearancePrint.Row.Options.UseFont = true;
            this.gridViewCountry.AppearancePrint.Row.Options.UseTextOptions = true;
            this.gridViewCountry.AppearancePrint.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewCountry.AppearancePrint.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewCountry.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.idCountry,
            this.nameCountry});
            this.gridViewCountry.GridControl = this.gridControlCountry;
            this.gridViewCountry.Name = "gridViewCountry";
            this.gridViewCountry.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gridViewCountry.OptionsPrint.EnableAppearanceOddRow = true;
            // 
            // idCountry
            // 
            this.idCountry.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idCountry.AppearanceHeader.Options.UseFont = true;
            this.idCountry.FieldName = "رقم الدولة";
            this.idCountry.Name = "idCountry";
            this.idCountry.OptionsColumn.AllowEdit = false;
            this.idCountry.OptionsColumn.AllowFocus = false;
            this.idCountry.Visible = true;
            this.idCountry.VisibleIndex = 0;
            // 
            // nameCountry
            // 
            this.nameCountry.AppearanceHeader.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameCountry.AppearanceHeader.Options.UseFont = true;
            this.nameCountry.FieldName = "اسم الدولة";
            this.nameCountry.Name = "nameCountry";
            this.nameCountry.OptionsColumn.AllowEdit = false;
            this.nameCountry.OptionsColumn.AllowFocus = false;
            this.nameCountry.Visible = true;
            this.nameCountry.VisibleIndex = 1;
            // 
            // PL_EditText
            // 
            this.PL_EditText.Controls.Add(this.txbNameCountry);
            this.PL_EditText.Controls.Add(this.label2);
            this.PL_EditText.Controls.Add(this.txbIDCountry);
            this.PL_EditText.Controls.Add(this.label1);
            this.PL_EditText.Dock = System.Windows.Forms.DockStyle.Top;
            this.PL_EditText.Location = new System.Drawing.Point(0, 0);
            this.PL_EditText.Name = "PL_EditText";
            this.PL_EditText.Size = new System.Drawing.Size(866, 56);
            this.PL_EditText.TabIndex = 1;
            // 
            // txbNameCountry
            // 
            this.txbNameCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbNameCountry.Location = new System.Drawing.Point(43, 16);
            this.txbNameCountry.MaxLength = 100;
            this.txbNameCountry.Name = "txbNameCountry";
            this.txbNameCountry.Size = new System.Drawing.Size(292, 24);
            this.txbNameCountry.TabIndex = 1;
            this.txbNameCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 104;
            this.label2.Text = "اسم الدولة  :";
            // 
            // txbIDCountry
            // 
            this.txbIDCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txbIDCountry.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txbIDCountry.Location = new System.Drawing.Point(469, 16);
            this.txbIDCountry.MaxLength = 15;
            this.txbIDCountry.Name = "txbIDCountry";
            this.txbIDCountry.ReadOnly = true;
            this.txbIDCountry.Size = new System.Drawing.Size(268, 24);
            this.txbIDCountry.TabIndex = 102;
            this.txbIDCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(743, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "رقم الدولة :";
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "93be915c-711d-4ed9-aff3-b895656d696d";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("275ca5bd-59bf-43f5-a0d3-0d372010b158", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية بنجاح", "تمت عملية بنجاح", "تمت عملية بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01),
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("ffe4e270-2b80-42f2-8045-a5feb23f3cc1", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications1"))), "خطأ في العملية", "خطأ في العملية", "خطأ في العملية", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // Control_Country
            // 
            this.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PL_Container);
            this.Controls.Add(this.PL_ControlsButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Control_Country";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(866, 537);
            this.Load += new System.EventHandler(this.Control_Country_Load);
            this.PL_ControlsButton.ResumeLayout(false);
            this.PL_Container.ResumeLayout(false);
            this.PL_GridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCountry)).EndInit();
            this.PL_EditText.ResumeLayout(false);
            this.PL_EditText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PL_ControlsButton;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnModifier;
        private DevExpress.XtraEditors.SimpleButton btnSuprimer;
        private DevExpress.XtraEditors.SimpleButton btnSuprimerAll;
        private DevExpress.XtraEditors.SimpleButton btnRefriche;
        private System.Windows.Forms.Panel PL_Container;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.Panel PL_EditText;
        public System.Windows.Forms.TextBox txbIDCountry;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txbNameCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PL_GridView;
        public DevExpress.XtraGrid.GridControl gridControlCountry;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCountry;
        private DevExpress.XtraGrid.Columns.GridColumn idCountry;
        private DevExpress.XtraGrid.Columns.GridColumn nameCountry;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
