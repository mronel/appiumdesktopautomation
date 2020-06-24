using System.IO;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Service;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumDesktopAutomation.Base
{
    public class Configuration
    {
        public static WindowsDriver<WindowsElement> driver;
        public static AppiumLocalService service;
        public static AppiumOptions caps; 

        public static void SetCapabilities()
        {
            caps = new AppiumOptions();
            caps.AddAdditionalCapability("platformName", "Windows");
            caps.AddAdditionalCapability("platformVersion", "10");
            caps.AddAdditionalCapability("deviceName", "WindowsPC");
            caps.AddAdditionalCapability("app", @"C:\Windows\notepad.exe");

            //caps.ToCapability("app", "Microsoft.BingWeather_8wekyb3d8bbwe!App");

            service = new AppiumServiceBuilder()
                     .UsingAnyFreePort()
                     .WithAppiumJS(new FileInfo(@"C:/Users/mateu/AppData/Roaming/npm/node_modules/appium/build/lib/main.js"))
                     .UsingDriverExecutable(new FileInfo(@"C:/Program Files/nodejs/node.exe"))
                     .Build();
            service.Start();
            
            driver = new WindowsDriver<WindowsElement>(service, caps);
        }


        public static WindowsDriver<WindowsElement> GetDriver()
        {
            return driver;
        }
    }
}
