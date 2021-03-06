﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UITestAutomation.HomePageClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class HomePage
    {
        
        #region Properties
        public UIASPNETMVCMusicStoreWWindow UIASPNETMVCMusicStoreWWindow
        {
            get
            {
                if ((this.mUIASPNETMVCMusicStoreWWindow == null))
                {
                    this.mUIASPNETMVCMusicStoreWWindow = new UIASPNETMVCMusicStoreWWindow();
                }
                return this.mUIASPNETMVCMusicStoreWWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIASPNETMVCMusicStoreWWindow mUIASPNETMVCMusicStoreWWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIASPNETMVCMusicStoreWWindow : BrowserWindow
    {
        
        public UIASPNETMVCMusicStoreWWindow()
        {
            #region Search Criteria
            this.SearchProperties[UITestControl.PropertyNames.Name] = "ASP.NET MVC Music Store";
            this.SearchProperties[UITestControl.PropertyNames.ClassName] = "IEFrame";
            this.WindowTitles.Add("ASP.NET MVC Music Store");
            #endregion
        }
        
        public void LaunchUrl(System.Uri url)
        {
            this.CopyFrom(BrowserWindow.Launch(url));
        }
        
        #region Properties
        public UIASPNETMVCMusicStoreDocument UIASPNETMVCMusicStoreDocument
        {
            get
            {
                if ((this.mUIASPNETMVCMusicStoreDocument == null))
                {
                    this.mUIASPNETMVCMusicStoreDocument = new UIASPNETMVCMusicStoreDocument(this);
                }
                return this.mUIASPNETMVCMusicStoreDocument;
            }
        }
        #endregion
        
        #region Fields
        private UIASPNETMVCMusicStoreDocument mUIASPNETMVCMusicStoreDocument;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIASPNETMVCMusicStoreDocument : HtmlDocument
    {
        
        public UIASPNETMVCMusicStoreDocument(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[HtmlDocument.PropertyNames.Id] = null;
            this.SearchProperties[HtmlDocument.PropertyNames.RedirectingPage] = "False";
            this.SearchProperties[HtmlDocument.PropertyNames.FrameDocument] = "False";
            this.FilterProperties[HtmlDocument.PropertyNames.Title] = "ASP.NET MVC Music Store";
            this.FilterProperties[HtmlDocument.PropertyNames.AbsolutePath] = "/";
            this.FilterProperties[HtmlDocument.PropertyNames.PageUrl] = "http://localhost:26641/";
            this.WindowTitles.Add("ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public UIAlbumlistCustom UIAlbumlistCustom
        {
            get
            {
                if ((this.mUIAlbumlistCustom == null))
                {
                    this.mUIAlbumlistCustom = new UIAlbumlistCustom(this);
                }
                return this.mUIAlbumlistCustom;
            }
        }
        
        public UICategoriesCustom UICategoriesCustom
        {
            get
            {
                if ((this.mUICategoriesCustom == null))
                {
                    this.mUICategoriesCustom = new UICategoriesCustom(this);
                }
                return this.mUICategoriesCustom;
            }
        }
        
        public UINavlistCustom UINavlistCustom
        {
            get
            {
                if ((this.mUINavlistCustom == null))
                {
                    this.mUINavlistCustom = new UINavlistCustom(this);
                }
                return this.mUINavlistCustom;
            }
        }
        
        public HtmlHyperlink UICartHyperlink
        {
            get
            {
                if ((this.mUICartHyperlink == null))
                {
                    this.mUICartHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUICartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = "cart-status";
                    this.mUICartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUICartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUICartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Cart (0)";
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/ShoppingCart";
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/ShoppingCart?Length=12";
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "id=\"cart-status\" href=\"/ShoppingCart?Len";
                    this.mUICartHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "4";
                    this.mUICartHyperlink.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUICartHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private UIAlbumlistCustom mUIAlbumlistCustom;
        
        private UICategoriesCustom mUICategoriesCustom;
        
        private UINavlistCustom mUINavlistCustom;
        
        private HtmlHyperlink mUICartHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIAlbumlistCustom : HtmlCustom
    {
        
        public UIAlbumlistCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "album-list";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"album-list\"";
            this.FilterProperties["TagInstance"] = "3";
            this.WindowTitles.Add("ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UITheBestOfMenAtWorkHyperlink
        {
            get
            {
                if ((this.mUITheBestOfMenAtWorkHyperlink == null))
                {
                    this.mUITheBestOfMenAtWorkHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = " The Best Of Men At Work ";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/Details/1";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/Details/1";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/Details/1\"";
                    this.mUITheBestOfMenAtWorkHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUITheBestOfMenAtWorkHyperlink.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUITheBestOfMenAtWorkHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUITheBestOfMenAtWorkHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICategoriesCustom : HtmlCustom
    {
        
        public UICategoriesCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "categories";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"categories\"";
            this.FilterProperties["TagInstance"] = "2";
            this.WindowTitles.Add("ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlCustom UIRockCustom
        {
            get
            {
                if ((this.mUIRockCustom == null))
                {
                    this.mUIRockCustom = new HtmlCustom(this);
                    #region Search Criteria
                    this.mUIRockCustom.SearchProperties["TagName"] = "LI";
                    this.mUIRockCustom.SearchProperties["Id"] = null;
                    this.mUIRockCustom.SearchProperties[UITestControl.PropertyNames.Name] = null;
                    this.mUIRockCustom.FilterProperties["Class"] = null;
                    this.mUIRockCustom.FilterProperties["ControlDefinition"] = null;
                    this.mUIRockCustom.FilterProperties["InnerText"] = "Rock ";
                    this.mUIRockCustom.FilterProperties["TagInstance"] = "1";
                    this.mUIRockCustom.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIRockCustom;
            }
        }
        
        public HtmlHyperlink UIRockHyperlink
        {
            get
            {
                if ((this.mUIRockHyperlink == null))
                {
                    this.mUIRockHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIRockHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIRockHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIRockHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIRockHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Rock";
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/Browse";
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/Browse?Genre=Rock";
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/Browse?Genre=Rock\"";
                    this.mUIRockHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "1";
                    this.mUIRockHyperlink.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIRockHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlCustom mUIRockCustom;
        
        private HtmlHyperlink mUIRockHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UINavlistCustom : HtmlCustom
    {
        
        public UINavlistCustom(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties["TagName"] = "UL";
            this.SearchProperties["Id"] = "navlist";
            this.SearchProperties[UITestControl.PropertyNames.Name] = null;
            this.FilterProperties["Class"] = null;
            this.FilterProperties["ControlDefinition"] = "id=\"navlist\"";
            this.FilterProperties["TagInstance"] = "1";
            this.WindowTitles.Add("ASP.NET MVC Music Store");
            #endregion
        }
        
        #region Properties
        public HtmlHyperlink UIStoreHyperlink
        {
            get
            {
                if ((this.mUIStoreHyperlink == null))
                {
                    this.mUIStoreHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIStoreHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIStoreHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIStoreHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIStoreHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Store";
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/Store/";
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/Store/";
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/Store/\"";
                    this.mUIStoreHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "2";
                    this.mUIStoreHyperlink.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIStoreHyperlink;
            }
        }
        
        public HtmlHyperlink UIAdminHyperlink
        {
            get
            {
                if ((this.mUIAdminHyperlink == null))
                {
                    this.mUIAdminHyperlink = new HtmlHyperlink(this);
                    #region Search Criteria
                    this.mUIAdminHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Id] = null;
                    this.mUIAdminHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Name] = null;
                    this.mUIAdminHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.Target] = null;
                    this.mUIAdminHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText] = "Admin";
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.AbsolutePath] = "/StoreManager/";
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Title] = null;
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Href] = "http://localhost:26641/StoreManager/";
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.Class] = null;
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.ControlDefinition] = "href=\"/StoreManager/\"";
                    this.mUIAdminHyperlink.FilterProperties[HtmlHyperlink.PropertyNames.TagInstance] = "4";
                    this.mUIAdminHyperlink.WindowTitles.Add("ASP.NET MVC Music Store");
                    #endregion
                }
                return this.mUIAdminHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private HtmlHyperlink mUIStoreHyperlink;
        
        private HtmlHyperlink mUIAdminHyperlink;
        #endregion
    }
}
