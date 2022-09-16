
namespace Library_MVP.Views.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonCategory = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonAuther = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBook_Borrow = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDar_Nacher = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonCountry = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.pn_Container = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonCategory,
            this.barButtonAuther,
            this.barButtonBook_Borrow,
            this.barButtonDar_Nacher,
            this.barButtonCountry,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barButtonItem10});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 550;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(864, 166);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonCategory
            // 
            this.barButtonCategory.Caption = "تصنيفات الكتب";
            this.barButtonCategory.Id = 1;
            this.barButtonCategory.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonCategory.ImageOptions.SvgImage")));
            this.barButtonCategory.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCategory.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonCategory.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonCategory.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCategory.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCategory.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonCategory.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonCategory.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCategory.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCategory.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonCategory.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonCategory.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCategory.Name = "barButtonCategory";
            this.barButtonCategory.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCategory_ItemClick);
            // 
            // barButtonAuther
            // 
            this.barButtonAuther.Caption = "المؤلفين";
            this.barButtonAuther.Id = 2;
            this.barButtonAuther.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonAuther.ImageOptions.SvgImage")));
            this.barButtonAuther.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonAuther.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonAuther.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonAuther.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonAuther.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonAuther.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonAuther.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonAuther.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonAuther.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonAuther.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonAuther.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonAuther.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonAuther.Name = "barButtonAuther";
            this.barButtonAuther.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonAuther.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonAuther_ItemClick);
            // 
            // barButtonBook_Borrow
            // 
            this.barButtonBook_Borrow.Caption = "اماكن الكتب";
            this.barButtonBook_Borrow.Id = 3;
            this.barButtonBook_Borrow.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonBook_Borrow.ImageOptions.SvgImage")));
            this.barButtonBook_Borrow.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonBook_Borrow.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonBook_Borrow.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonBook_Borrow.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonBook_Borrow.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonBook_Borrow.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonBook_Borrow.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonBook_Borrow.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonBook_Borrow.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonBook_Borrow.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonBook_Borrow.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonBook_Borrow.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonBook_Borrow.Name = "barButtonBook_Borrow";
            this.barButtonBook_Borrow.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonBook_Borrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBook_Borrow_ItemClick);
            // 
            // barButtonDar_Nacher
            // 
            this.barButtonDar_Nacher.Caption = "دار النشر";
            this.barButtonDar_Nacher.Id = 4;
            this.barButtonDar_Nacher.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDar_Nacher.ImageOptions.SvgImage")));
            this.barButtonDar_Nacher.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonDar_Nacher.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonDar_Nacher.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonDar_Nacher.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonDar_Nacher.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonDar_Nacher.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonDar_Nacher.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonDar_Nacher.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonDar_Nacher.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonDar_Nacher.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonDar_Nacher.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonDar_Nacher.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonDar_Nacher.Name = "barButtonDar_Nacher";
            this.barButtonDar_Nacher.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonDar_Nacher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDar_Nacher_ItemClick);
            // 
            // barButtonCountry
            // 
            this.barButtonCountry.Caption = "الدول";
            this.barButtonCountry.Id = 5;
            this.barButtonCountry.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonCountry.ImageOptions.SvgImage")));
            this.barButtonCountry.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCountry.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonCountry.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonCountry.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCountry.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCountry.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonCountry.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonCountry.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCountry.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonCountry.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonCountry.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonCountry.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonCountry.Name = "barButtonCountry";
            this.barButtonCountry.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonCountry.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCountry_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "بيانات المستعيرين";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem6.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem6.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem6.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "استعارة كتاب";
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem7.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem7.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem7.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "تقارير الاستعارات";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.Image")));
            this.barButtonItem8.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem8.ImageOptions.LargeImage")));
            this.barButtonItem8.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem8.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem8.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem8.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "ادارة الكتب";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.Image")));
            this.barButtonItem9.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem9.ImageOptions.LargeImage")));
            this.barButtonItem9.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem9.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem9.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem9.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem9.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem9_ItemClick);
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "بحث عن الكتب";
            this.barButtonItem10.Id = 10;
            this.barButtonItem10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.Image")));
            this.barButtonItem10.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem10.ImageOptions.LargeImage")));
            this.barButtonItem10.ItemAppearance.Hovered.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Hovered.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Normal.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Normal.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.ItemAppearance.Pressed.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem10.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem10.ItemAppearance.Pressed.Options.UseTextOptions = true;
            this.barButtonItem10.ItemAppearance.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الرئيسة";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonCategory);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonAuther);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonBook_Borrow);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.AllowTextClipping = false;
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonDar_Nacher);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.AllowTextClipping = false;
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonCountry);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage2.Appearance.Options.UseFont = true;
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6,
            this.ribbonPageGroup10});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "الكتب";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.AllowTextClipping = false;
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem9);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.AllowTextClipping = false;
            this.ribbonPageGroup10.ItemLinks.Add(this.barButtonItem10);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonPage3.Appearance.Options.UseFont = true;
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup9});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "الاستعارات";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.AllowTextClipping = false;
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.AllowTextClipping = false;
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.AllowTextClipping = false;
            this.ribbonPageGroup9.ItemLinks.Add(this.barButtonItem8);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 512);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(864, 24);
            // 
            // pn_Container
            // 
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 166);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(864, 346);
            this.pn_Container.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 536);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmMain.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(866, 537);
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "الصفحة الرئيسية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonCategory;
        private DevExpress.XtraBars.BarButtonItem barButtonAuther;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barButtonBook_Borrow;
        private DevExpress.XtraBars.BarButtonItem barButtonDar_Nacher;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonCountry;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        public System.Windows.Forms.Panel pn_Container;
    }
}