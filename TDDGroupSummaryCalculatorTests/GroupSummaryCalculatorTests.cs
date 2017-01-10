using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using TDD;

namespace TDD.Tests {
    [TestClass()]
    public class GroupSummaryCalculatorTests {
        private List<SalesList> _item;

        [TestInitialize]
        public void Init() {
            _item = new List<SalesList> {
                new SalesList { id=1, Cost=1, Revenue=11, SellPrice=21},
                new SalesList { id=2, Cost=2, Revenue=12, SellPrice=22},
                new SalesList { id=3, Cost=3, Revenue=13, SellPrice=23},
                new SalesList { id=4, Cost=4, Revenue=14, SellPrice=24},
                new SalesList { id=5, Cost=5, Revenue=15, SellPrice=25},
                new SalesList { id=6, Cost=6, Revenue=16, SellPrice=26},
                new SalesList { id=7, Cost=7, Revenue=17, SellPrice=27},
                new SalesList { id=8, Cost=8, Revenue=18, SellPrice=28},
                new SalesList { id=9, Cost=9, Revenue=19, SellPrice=29},
                new SalesList { id=10, Cost=10, Revenue=20, SellPrice=30},
                new SalesList { id=11, Cost=11, Revenue=21, SellPrice=31},
            };
        }

        [TestMethod()]
        public void In_Sets_of_Three_Check_Sum_of_Cost_Should_Be_6_15_24_21() {
            //arrange
            List<int> expected = new List<int> { 6, 15, 24, 21};
            //act
            var actual = _item.CheckSummary(3, x => x.Cost).ToList();
            //assert
            actual.Should().Equal(expected);
        }

        [TestMethod]
        public void In_Sets_of_Four_Check_Sum_of_Revenue_Should_Be_50_66_60() {
            //arrange
            List<int> expected = new List<int> { 50, 66, 60 };
            //act
            var actual = _item.CheckSummary(4, x => x.Revenue).ToList();
            //assert
            actual.Should().Equal(expected);
        }

        [TestMethod]
        public void In_Sets_of_One_Check_Sum_of_SellPrice_Should_Be_Itself() {
            //arrange
            var expected = _item.Select(x => x.SellPrice).ToList();
            //act
            var actual = _item.CheckSummary(1, x => x.SellPrice).ToList();
            //assert
            actual.ShouldBeEquivalentTo(expected);
        }
        [TestMethod]
        public void In_Sets_of_Two_Chck_Sum_of_Cost_Should_Be_3_7_11_15_19_11() {
            //arrange
            var expected = new List<int> { 3, 7, 11, 15, 19, 11 };
            //act
            var act = _item.CheckSummary(2, x => x.Cost).ToList();
            //assert
            act.ShouldBeEquivalentTo(expected);
        }
        [TestMethod]
        public void In_Sets_of_Negative_Should_Throw_Exception() {
            //arrange 
            //act
            Action act = () => _item.CheckSummary(-1, x => x.Cost).ToList();
            //assert
            act.ShouldThrow<ArgumentOutOfRangeException>();
        }
        [TestMethod]
        public void In_Sets_of_Zero_Should_Be_Zero() {
            //arrange
            var expected = new List<int> { 0 };
            //act
            var act = _item.CheckSummary(0, x => x.Cost).ToList();
            //assert
            act.ShouldBeEquivalentTo(expected);
        }
    }
    public class SalesList {
        public int id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}