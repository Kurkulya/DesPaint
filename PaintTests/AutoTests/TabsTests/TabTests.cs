﻿using System;
using NUnit.Framework;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using PaintTests.AutoTests;

namespace PaintTests.AutoTests
{
    [TestFixture]
    public class TabTests
    {
        Window window = null;
        [SetUp]
        public void StartUp()
        {
            Application application = Application.Launch(POM.AppPath);
            window = application.GetWindow(POM.WindowName, InitializeOption.NoCache);
            POM.Window = window;
        }

        [Test]
        public void TestExistTabs()
        {
            Assert.AreEqual(true, POM.Window.Tabs.Find(x => true).Enabled);
        }


        [TearDown]
        public void TearDown()
        {
            window.Close();
        }
    }
}


