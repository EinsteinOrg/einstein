using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Einstein.Data.DAL;
using Einstein.Data;
using DevComponents.DotNetBar;
using System.Windows.Forms;

namespace Einstein.Platform
{
    public class Navigations
    {
        DevComponents.DotNetBar.RibbonControl ribbonControl = null;
        System.ComponentModel.ComponentResourceManager resourceManager= null;
        ImageList imageList = null;
        
        public Navigations(RibbonControl currentRibbonControl,System.ComponentModel.ComponentResourceManager resource,ImageList images)
        {
            ribbonControl = currentRibbonControl;
            resourceManager = resource;
            imageList = images;
        }

        public void Creat()
        {
            MenuInfoDAL dal = new MenuInfoDAL();
            var menuList = dal.SelectAll();
            foreach (var info in menuList.Where(c => c.ParentID == "-1"))
            {
                //Create Parent menu
                var ribbonPanel = CreateParentMenu(info);
                foreach (var subMenu in menuList.Where(c => c.ParentID == info.MenuID))
                {
                    //Create Children menus
                    var ribbonBar = CreateChildMenus(subMenu);
                    ribbonPanel.Controls.Add(ribbonBar);
                }
            }

        }

        private RibbonPanel CreateParentMenu(MenuInfo menuInfo)
        {
            RibbonTabItem newTab = ribbonControl.CreateRibbonTab(menuInfo.MenuName, menuInfo.MenuID);
            RibbonPanel ribbonPanel = new DevComponents.DotNetBar.RibbonPanel();
            ribbonPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ribbonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            ribbonPanel.Location = new System.Drawing.Point(0, 0);
            ribbonPanel.Name = System.Guid.NewGuid().ToString();
            ribbonPanel.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            ribbonPanel.Size = new System.Drawing.Size(75, 20);
            ribbonPanel.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonPanel.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonPanel.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonPanel.TabIndex = 13;
            ribbonPanel.ColorSchemeStyle = eDotNetBarStyle.Office2007;
            ribbonPanel.Visible = true;
            newTab.Panel = ribbonPanel;
            return ribbonPanel;
        }

        private  RibbonBar CreateChildMenus(MenuInfo subMenuInfo)
        {
            ButtonItem buttonItem = new DevComponents.DotNetBar.ButtonItem();
            buttonItem.Name = subMenuInfo.MenuID;
            buttonItem.Text = subMenuInfo.MenuName;
            buttonItem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            //buttonItem.Image = ((System.Drawing.Image)(resourceManager.GetObject("buttonItem1.Image")));
            //buttonItem.Image = ((System.Drawing.Image)(resourceManager.GetObject("OpenExistingPlace")));
            buttonItem.Image = imageList.Images["OpenExistingPlace"];
            buttonItem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            buttonItem.RibbonWordWrap = false;
            buttonItem.Visible = true;

            DevComponents.DotNetBar.RibbonBar ribbonBar = new DevComponents.DotNetBar.RibbonBar();

            
            ribbonBar.AutoOverflowEnabled = true;
            ribbonBar.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonBar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonBar.ContainerControlProcessDialogKey = true;
            ribbonBar.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            buttonItem});
            ribbonBar.Location = new System.Drawing.Point(3, 0);
            ribbonBar.Name = System.Guid.NewGuid().ToString();
            ribbonBar.Size = new System.Drawing.Size(337, 82);
            ribbonBar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            ribbonBar.TabIndex = 0;
            //ribbonBar.Text = subMenuInfo.MenuName;
            ribbonBar.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonBar.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            ribbonBar.Visible = true;

            return ribbonBar;
        }

    }
}
