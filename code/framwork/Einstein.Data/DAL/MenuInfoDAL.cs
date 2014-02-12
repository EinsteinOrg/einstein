using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Einstein.Utility;

namespace Einstein.Data.DAL
{
    public class MenuInfoDAL
    {
        public void Add(MenuInfo info)
        {
            using (EinsteinEntities entities = new EinsteinEntities())
            {
                entities.MenuInfo.AddObject(info);
                entities.SaveChanges();
            }
        }

        public void Remove(string menuID)
        {
            using (EinsteinEntities context = new EinsteinEntities())
            {
                foreach (var item in context.MenuInfo.Where(c => c.MenuID == menuID))
                {
                    context.DeleteObject(item);
                }
                context.SaveChanges();
            }
        }

        public IList<MenuInfo> SelectAll()
        {
            using (EinsteinEntities entities = new EinsteinEntities())
            {
                return entities.MenuInfo.ToList<MenuInfo>();
            }
        }

        public MenuInfo SelectByMenuID(string menuID)
        {
            using (EinsteinEntities entities = new EinsteinEntities())
            {
                var query = entities.MenuInfo.Where(c => c.MenuID == menuID);

                return query.First<MenuInfo>();
            }
        }

        public void Update(string menuID, string menuName)
        {
            using (EinsteinEntities entities = new EinsteinEntities())
            {
                foreach(var item in entities.MenuInfo.Where(c=>c.MenuID == menuID))
                {
                    item.MenuName = menuName;
                }
                entities.SaveChanges();
            }

        }

    }
}
