﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WrittingTestableCode.Module1.Easy;

namespace WrittingTestableCode.Module1
{
    [TestFixture]
    public class CalculatorTest
    {
        private Calculator _calculator;
        [SetUp]
        public void SetUp()
        {
            _calculator=new Calculator();
        }
        [Test]
        public void TestGetTotalShouldReturnTotalPrice()
        {
            var result = _calculator.GetTotal(1.00m, 2.00m, 0.50m);
            Assert.That(result,Is.EqualTo(2.50m));
            
        }
    }
}
