using Microsoft.VisualStudio.TestTools.UnitTesting;
using Slab.Net.EF.Commons.Exceptions;
using Slab.Net.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slab.Net.EF.Logic.Tests
{
    [TestClass()]
    public class CustomersLogicTests
    {
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void RemoveTest()
        {
            string toRemoveId = "ACSMZX";
            CustomersLogic customersLogic = new CustomersLogic();
            customersLogic.Remove(toRemoveId);
        }

    }
}