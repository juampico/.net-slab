using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Entities;
using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic.Tests
{
    [TestClass()]
    public class ShippersLogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(MaxLengthExceededException))]
        public void AddTest()
        {
            Shippers newShipper = new Shippers
            {
                CompanyName = "NUEVO TRANSPORTISTA",
                Phone = "(5099) - 249 - 431 - 429 - 562 - 122 - 130"
            };
            ShippersLogic shippersLogic = new ShippersLogic();
            shippersLogic.Add(newShipper);
        }
    }
}