﻿using LeetCode.Src;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test {
    [TestClass]
    public class P1288RemoveCoveredIntervalsTest {
        [TestMethod]
        public void RemoveCoveredIntervalsTest () {
            Assert.AreEqual(2, P1288RemoveCoveredIntervals.RemoveCoveredIntervals(new int[][] { new int[] { 1, 4 }, new int[] { 3, 6 }, new int[] { 2, 8 } }));
            Assert.AreEqual(1, P1288RemoveCoveredIntervals.RemoveCoveredIntervals(new int[][] { new int[] { 1, 4 }, new int[] { 2, 3 } }));
            Assert.AreEqual(2, P1288RemoveCoveredIntervals.RemoveCoveredIntervals(new int[][] { new int[] { 0, 10 }, new int[] { 5, 12 } }));
            Assert.AreEqual(2, P1288RemoveCoveredIntervals.RemoveCoveredIntervals(new int[][] { new int[] { 3, 10 }, new int[] { 4, 10 }, new int[] { 5, 11 } }));
            Assert.AreEqual(1, P1288RemoveCoveredIntervals.RemoveCoveredIntervals(new int[][] { new int[] { 1, 2 }, new int[] { 1, 4 }, new int[] { 3, 4 } }));
        }
    }
}
