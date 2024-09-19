﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.RotachAO.Sprint0.Task2.V0.Lib;
namespace Tyuiu.RotachAO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Настя";
            var res = DataService.GetMessage(name);
            Assert.AreEqual("Привет, Настя", res);
        }
    }
}
