using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using trying_search;
using trying_search.Controllers;
using trying_search.Models;

namespace trying_search.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            Locking_system loc = new Locking_system();
            loc.speed = 30;
            loc.doors = "closed";

            string actual = loc.checkifdoorslock(); // doors open
            string expected = "Lock";

            Assert.AreEqual(expected, actual); 

        }

       
    }
}
