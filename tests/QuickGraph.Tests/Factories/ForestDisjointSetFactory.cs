// <copyright file="ForestDisjointSetFactory.cs" company="MSIT">Copyright © MSIT 2007</copyright>

using System;
using Microsoft.Pex.Framework;
using QuickGraph.Collections;

namespace QuickGraph.Collections
{
    public static partial class ForestDisjointSetFactory
    {
        [PexFactoryMethod(typeof(ForestDisjointSet<int>))]
        public static ForestDisjointSet<int> Create(int[] elements, int[] unions)
        {
            var ds = new ForestDisjointSet<int>();
            for (int i = 0; i < elements.Length; ++i)
                ds.MakeSet(i);
            for (int i = 0; i+1 < unions.Length; i+=2)
            {
                PexAssume.IsTrue(ds.Contains(unions[i]));
                PexAssume.IsTrue(ds.Contains(unions[i+1]));
                ds.Union(unions[i], unions[i+1]);
            }
            return ds;
        }
    }
}
