﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SpecFlowHelpers;
using SpecFlowHelpers.Pages;

namespace SeleniumWebDriver.Pages
{
    public class ChambaDashboard : IChambaDashboard
    {

        private readonly IWebDriver _driver;

        public ChambaDashboard(IWebDriver driver)
        {
            _driver = driver;
            Address = string.Concat(Constants.BaseAddress, Constants.ChambaDashboard);
        }


        #region Implementation of IPage

        public string Address { get; set; }
        public string MensajeBienvenida()
        {
            var userName = _driver.FindElement(By.CssSelector(".user-name li"));
            return userName.Text;
        }

        #endregion
    }
}
