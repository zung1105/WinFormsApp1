using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using WinFormsApp1.Screen;

namespace WinFormsApp1
{
    public class AppController
    {
        private readonly IAppMainScreenNavigator appMainScreenNavigator;
        private readonly ScreenDashboard screenDashboard = new ScreenDashboard();
        private readonly ScreenStatistic screenStatistic = new ScreenStatistic();
        private readonly ScreenWalletsManagement screenWalletsManagement = new ScreenWalletsManagement();
        private readonly ScreenCategoriesManagement screenCategoriesManagement = new ScreenCategoriesManagement();
        
        private string curScreenSwitchContext = AppContext.ScreenSwitchContext.Undifined;

        public AppController(IAppMainScreenNavigator appNavigator)
        {
            this.appMainScreenNavigator = appNavigator;

            appMainScreenNavigator.SwitchScreenRequested += OnSwitchScreenRequested;
        }

        private void OnSwitchScreenRequested(string screenName)
        {
            if (curScreenSwitchContext == screenName)
            {
                return;
            }

            try
            {
                curScreenSwitchContext = screenName;

                if(curScreenSwitchContext == AppContext.ScreenSwitchContext.Statistic)
                {

                    appMainScreenNavigator.ShowMainContent(screenStatistic);
                }
                else if(curScreenSwitchContext == AppContext.ScreenSwitchContext.WalletsManagement)
                {
                    appMainScreenNavigator.ShowMainContent(screenWalletsManagement);
                }
                else if(curScreenSwitchContext == AppContext.ScreenSwitchContext.CategoriesManagement)
                {
                    appMainScreenNavigator.ShowMainContent(screenCategoriesManagement);
                }
                else if(curScreenSwitchContext == AppContext.ScreenSwitchContext.Dashboard)
                {
                    appMainScreenNavigator.ShowMainContent(screenDashboard);
                }
                else
                {
                    throw new Exception($"Tính năng đang phát triển! Chờ thêm nhé.");
                }
            }
            catch (Exception ex)
            {
                appMainScreenNavigator.ShowMesssage($"Error switching screen: {ex.Message}");
            }
        }
    }
}
