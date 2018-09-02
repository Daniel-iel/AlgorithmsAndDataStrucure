using ChunkCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;

namespace ChunkTest
{
    [TestClass]
    public class ChunkTest
    {
        [TestMethod]
        public void Chunk1()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = Program.Chunk1(list, 3);

            var expected = new List<List<int>>();

            expected.Add(new List<int>());
            expected[0].Add(1);
            expected[0].Add(2);
            expected[0].Add(3);

            expected.Add(new List<int>());
            expected[1].Add(4);
            expected[1].Add(5);
            expected[1].Add(6);

            expected.Add(new List<int>());
            expected[2].Add(7);

            var resultList = result.SelectMany(item => item).ToList();
            var expectedList = expected.SelectMany(item => item).ToList();

            CollectionAssert.AreEqual(resultList, expectedList);
        }

        [TestMethod]
        public void Chunk2()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = Program.Chunk2(list.ToArray(), 3);

            var expected = new List<List<int>>();

            expected.Add(new List<int>());
            expected[0].Add(1);
            expected[0].Add(2);
            expected[0].Add(3);

            expected.Add(new List<int>());
            expected[1].Add(4);
            expected[1].Add(5);
            expected[1].Add(6);

            expected.Add(new List<int>());
            expected[2].Add(7);
            
            var resultList = result.SelectMany(item => item).ToList();
            var expectedList = expected.SelectMany(item => item).ToList();

            CollectionAssert.AreEqual(resultList, expectedList);
        }

        [TestMethod]
        public void Chunk3()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            var result = Program.Chunk3(list.ToArray(), 3);

            var expected = new List<List<int>>();

            expected.Add(new List<int>());
            expected[0].Add(1);
            expected[0].Add(2);
            expected[0].Add(3);

            expected.Add(new List<int>());
            expected[1].Add(4);
            expected[1].Add(5);
            expected[1].Add(6);

            expected.Add(new List<int>());
            expected[2].Add(7);

            var resultList = result.SelectMany(item => item).ToList();
            var expectedList = expected.SelectMany(item => item).ToList();

            CollectionAssert.AreEqual(resultList, expectedList);
        }
    }
}
