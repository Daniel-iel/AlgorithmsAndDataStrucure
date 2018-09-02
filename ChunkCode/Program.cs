using System;
using System.Collections.Generic;
using System.Linq;

namespace ChunkCode
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            var result1 = Chunk1(list, 3);
            var result2 = Chunk2(list.ToArray(), 3);
            var result3 = Chunk3(list, 3);
        }
             
        public static IEnumerable<IEnumerable<T>> Chunk1<T>(IEnumerable<T> list, int chunkSize)
        {
            while (list.Any())
            {
                yield return list.Take(chunkSize);
                list = list.Skip(chunkSize);
            }
        }

        public static List<List<int>> Chunk2(int[] arr, int size)
        {
            var chunked = new List<List<int>>() { new List<int>() };

            foreach (var element in arr)
            {
                var last = chunked[chunked.Count - 1];

                if (last.Count() == 0 || last.Count == size)
                    chunked.Add(new List<int> { element });
                else
                    last.Add(element);
            }

            chunked.RemoveAt(0);

            return chunked;
        }
        
        public static IEnumerable<IEnumerable<int>> Chunk3(IEnumerable<int> list, int chunkSize)
        {
            var chunked = new List<List<int>>();
       
            while (list.Any())
            {
                chunked.Add(list.Take(chunkSize).ToList());
                list = list.Skip(chunkSize);
            }

            return chunked;
        }
    }
}
