namespace UITestAutomationPageObjects.PageObjects.Store.StoreDetailClasses
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
    
using Microsoft.VisualStudio.TestTools.UITesting.HtmlControls;
    using UITestAutomationPageObjects.PageObjects.Shared;
    using UITestAutomationPageObjectsCodeFirst.PageObjects.ShoppingCart;


    public partial class StoreDetail : SharedActionsAndElements
    {
        public StoreDetail(BrowserWindow browserWindow):base(browserWindow)
        {
        }
        public ShoppingCart AddItemToCart()

        {
            //Point location = GetAddToCartLink().BoundingRectangle.Location;
            //location.Offset(GetAddToCartLink().BoundingRectangle.Width / 2, GetAddToCartLink().BoundingRectangle.Height / 2);
            //var AddItemLink = GetAddToCartLink();
            Mouse.Click(GetAddToCartLink());
            return new ShoppingCart(_browserWindow);
        }

        private HtmlHyperlink GetAddToCartLink()
        {
            HtmlHyperlink CartHyperlink = new HtmlHyperlink(_browserWindow);
            CartHyperlink.SearchProperties[HtmlHyperlink.PropertyNames.InnerText]="Add to cart";
            CartHyperlink.FilterProperties.Add(HtmlHyperlink.PropertyNames.ControlType,"Hyperlink");
            CartHyperlink.FilterProperties.Add(HtmlHyperlink.PropertyNames.ClassName, "HtmlHyperlink");
            // CategoryList.FilterProperties.Add(HtmlHyperlink.PropertyNames.ControlDefinition, "href=\" / ShoppingCart / AddToCart / 75/\" length=\"0\"");
            CartHyperlink.Find();
            return CartHyperlink;
        }

        public HtmlDiv Header
        {
            get{
                HtmlDiv Header = new HtmlDiv(_browserWindow);
                Header.SearchProperties.Add(HtmlControl.PropertyNames.Id, "album-details");
                Header.Find();
                return Header;
            }
        }
    }
}
