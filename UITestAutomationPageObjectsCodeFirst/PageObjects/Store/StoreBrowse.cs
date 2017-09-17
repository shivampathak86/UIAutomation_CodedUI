﻿namespace UITestAutomationPageObjects.PageObjects.Store.StoreBrowseClasses
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Input;
    using System.CodeDom.Compiler;
    using System.Text.RegularExpressions;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses;
    using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;


    public partial class StoreBrowse : SharedActionsAndElements
    {
        public StoreBrowse(BrowserWindow browserWindow):base(browserWindow)
        {
        }
        public StoreDetail SelectProduct(string productName)
        {
            HtmlControl productList = new HtmlControl(_browserWindow);
            //productList.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch)
            
            productList.SearchProperties[HtmlControl.PropertyNames.Id]="album-list";
            productList.WaitForControlReady();
            productList.FilterProperties[HtmlCustom.PropertyNames.ControlDefinition] = "id=\"album - list\"";
            HtmlHyperlink productLink = new HtmlHyperlink(productList);
            //productLink.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            productLink.SearchProperties.Add(HtmlHyperlink.PropertyNames.InnerText, productName, PropertyExpressionOperator.Contains);
            productLink.FilterProperties.Add(HtmlHyperlink.PropertyNames.ClassName,"HtmlHyperlink");
            productLink.FilterProperties.Add(HtmlHyperlink.PropertyNames.ControlType, "Hyperlink");
           
            Mouse.Click(productLink);
            return new StoreDetail(_browserWindow);
        }
    }
}
