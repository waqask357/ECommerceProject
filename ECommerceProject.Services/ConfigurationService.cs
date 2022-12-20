using ECommerceProject.Database;
using ECommerceProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceProject.Services
{
    public class ConfigurationService
    {
        #region Singleton
        public static ConfigurationService Instance
        {
            get
            {
                if (instance == null) instance = new ConfigurationService();
                return instance;
            }
        }

        private static ConfigurationService instance { get; set; }
        private ConfigurationService()
        {

        }
        #endregion

        public Config getConfigs(string key)
        {
            using (AppDatabaseContext context=new AppDatabaseContext())
            {
                return context.Configurations.Find(key);
            }
        }
    }
}
