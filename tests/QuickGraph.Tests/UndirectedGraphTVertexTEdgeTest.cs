// <copyright file="UndirectedGraphTVertexTEdgeTest.cs" company="Jonathan de Halleux">Copyright http://quickgraph.codeplex.com/</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuickGraph;

namespace QuickGraph
{
    /// <summary>This class contains parameterized unit tests for UndirectedGraph`2</summary>
    [TestClass]
    [PexClass(typeof(UndirectedGraph<, >))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexGenericArguments(typeof(int), typeof(Edge<int>))]
    [PexGenericArguments(typeof(int), typeof(SEdge<int>))]
    public partial class UndirectedGraphTVertexTEdgeTest
    {
        /// <summary>Test stub for AddEdge(!1)</summary>
        [PexMethod]
        public bool AddEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddEdge(UndirectedGraph`2<!!0,!!1>, !!1)
            bool result = target.AddEdge(edge);
            return result;
        }

        /// <summary>Test stub for AddEdgeRange(IEnumerable`1&lt;!1&gt;)</summary>
        [PexMethod]
        public int AddEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddEdgeRange(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
            int result = target.AddEdgeRange(edges);
            return result;
        }

        /// <summary>Test stub for AddVertex(!0)</summary>
        [PexMethod]
        public bool AddVertex<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVertex(UndirectedGraph`2<!!0,!!1>, !!0)
            bool result = target.AddVertex(v);
            return result;
        }

        /// <summary>Test stub for AddVertexRange(IEnumerable`1&lt;!0&gt;)</summary>
        [PexMethod]
        public int AddVertexRange<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TVertex> vertices
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVertexRange(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!0>)
            int result = target.AddVertexRange(vertices);
            return result;
        }

        /// <summary>Test stub for AddVerticesAndEdge(!1)</summary>
        [PexMethod]
        public bool AddVerticesAndEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVerticesAndEdge(UndirectedGraph`2<!!0,!!1>, !!1)
            bool result = target.AddVerticesAndEdge(edge);
            return result;
        }

        /// <summary>Test stub for AddVerticesAndEdgeRange(IEnumerable`1&lt;!1&gt;)</summary>
        [PexMethod]
        public int AddVerticesAndEdgeRange<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AddVerticesAndEdgeRange(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
            int result = target.AddVerticesAndEdgeRange(edges);
            return result;
        }

        /// <summary>Test stub for AdjacentDegree(!0)</summary>
        [PexMethod]
        public int AdjacentDegree<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentDegree(UndirectedGraph`2<!!0,!!1>, !!0)
            int result = target.AdjacentDegree(v);
            return result;
        }

        /// <summary>Test stub for AdjacentEdge(!0, Int32)</summary>
        [PexMethod]
        public TEdge AdjacentEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            TVertex v,
            int index
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentEdge(UndirectedGraph`2<!!0,!!1>, !!0, Int32)
            TEdge result = target.AdjacentEdge(v, index);
            return result;
        }

        /// <summary>Test stub for AdjacentEdges(!0)</summary>
        [PexMethod]
        public IEnumerable<TEdge> AdjacentEdges<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AdjacentEdges(UndirectedGraph`2<!!0,!!1>, !!0)
            IEnumerable<TEdge> result = target.AdjacentEdges(v);
            return result;
        }

        /// <summary>Test stub for AllowParallelEdges</summary>
        [PexMethod]
        public void AllowParallelEdgesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.AllowParallelEdgesGet(UndirectedGraph`2<!!0,!!1>)
            bool result = target.AllowParallelEdges;
        }

        /// <summary>Test stub for Clear()</summary>
        [PexMethod]
        public void Clear<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Clear(UndirectedGraph`2<!!0,!!1>)
            target.Clear();
        }

        /// <summary>Test stub for ClearAdjacentEdges(!0)</summary>
        [PexMethod]
        public void ClearAdjacentEdges<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ClearAdjacentEdges(UndirectedGraph`2<!!0,!!1>, !!0)
            target.ClearAdjacentEdges(v);
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public UndirectedGraph<TVertex, TEdge> Constructor<TVertex,TEdge>()
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Constructor()
            UndirectedGraph<TVertex, TEdge> target = new UndirectedGraph<TVertex, TEdge>();
            return target;
        }

        /// <summary>Test stub for .ctor(Boolean)</summary>
        [PexMethod]
        public UndirectedGraph<TVertex, TEdge> Constructor01<TVertex,TEdge>(bool allowParallelEdges)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.Constructor01(Boolean)
            UndirectedGraph<TVertex, TEdge> target
               = new UndirectedGraph<TVertex, TEdge>(allowParallelEdges);
            return target;
        }

        /// <summary>Test stub for ContainsEdge(!0, !0)</summary>
        [PexMethod]
        public bool ContainsEdge<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target01,
            TVertex source,
            TVertex target
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsEdge(UndirectedGraph`2<!!0,!!1>, !!0, !!0)
            bool result = target01.ContainsEdge(source, target);
            return result;
        }

        /// <summary>Test stub for ContainsEdge(!1)</summary>
        [PexMethod]
        public bool ContainsEdge01<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsEdge01(UndirectedGraph`2<!!0,!!1>, !!1)
            bool result = target.ContainsEdge(edge);
            return result;
        }

        /// <summary>Test stub for ContainsVertex(!0)</summary>
        [PexMethod]
        public bool ContainsVertex<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            TVertex vertex
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.ContainsVertex(UndirectedGraph`2<!!0,!!1>, !!0)
            bool result = target.ContainsVertex(vertex);
            return result;
        }

        /// <summary>Test stub for EdgeCapacity</summary>
        [PexMethod]
        public void EdgeCapacityGetSet<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            int value
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.EdgeCapacityGetSet(UndirectedGraph`2<!!0,!!1>)
            target.EdgeCapacity = value;
            int result = target.EdgeCapacity;
            PexAssert.AreEqual((object)value, (object)result);
        }

        /// <summary>Test stub for EdgeCount</summary>
        [PexMethod]
        public void EdgeCountGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.EdgeCountGet(UndirectedGraph`2<!!0,!!1>)
            int result = target.EdgeCount;
        }

        /// <summary>Test stub for Edges</summary>
        [PexMethod]
        public void EdgesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.EdgesGet(UndirectedGraph`2<!!0,!!1>)
            IEnumerable<TEdge> result = target.Edges;
        }

        /// <summary>Test stub for IsAdjacentEdgesEmpty(!0)</summary>
        [PexMethod]
        public bool IsAdjacentEdgesEmpty<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsAdjacentEdgesEmpty(UndirectedGraph`2<!!0,!!1>, !!0)
            bool result = target.IsAdjacentEdgesEmpty(v);
            return result;
        }

        /// <summary>Test stub for IsDirected</summary>
        [PexMethod]
        public void IsDirectedGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsDirectedGet(UndirectedGraph`2<!!0,!!1>)
            bool result = target.IsDirected;
        }

        /// <summary>Test stub for IsEdgesEmpty</summary>
        [PexMethod]
        public void IsEdgesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsEdgesEmptyGet(UndirectedGraph`2<!!0,!!1>)
            bool result = target.IsEdgesEmpty;
        }

        /// <summary>Test stub for IsVerticesEmpty</summary>
        [PexMethod]
        public void IsVerticesEmptyGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.IsVerticesEmptyGet(UndirectedGraph`2<!!0,!!1>)
            bool result = target.IsVerticesEmpty;
        }

        /// <summary>Test stub for RemoveAdjacentEdgeIf(!0, EdgePredicate`2&lt;!0,!1&gt;)</summary>
        [PexMethod]
        public int RemoveAdjacentEdgeIf<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            TVertex v,
            EdgePredicate<TVertex, TEdge> predicate
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveAdjacentEdgeIf(UndirectedGraph`2<!!0,!!1>, !!0, EdgePredicate`2<!!0,!!1>)
            int result = target.RemoveAdjacentEdgeIf(v, predicate);
            return result;
        }

        /// <summary>Test stub for RemoveEdge(!1)</summary>
        [PexMethod]
        public bool RemoveEdge<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TEdge edge)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveEdge(UndirectedGraph`2<!!0,!!1>, !!1)
            bool result = target.RemoveEdge(edge);
            return result;
        }

        /// <summary>Test stub for RemoveEdgeIf(EdgePredicate`2&lt;!0,!1&gt;)</summary>
        [PexMethod]
        public int RemoveEdgeIf<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            EdgePredicate<TVertex, TEdge> predicate
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveEdgeIf(UndirectedGraph`2<!!0,!!1>, EdgePredicate`2<!!0,!!1>)
            int result = target.RemoveEdgeIf(predicate);
            return result;
        }

        /// <summary>Test stub for RemoveEdges(IEnumerable`1&lt;!1&gt;)</summary>
        [PexMethod]
        public int RemoveEdges<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            IEnumerable<TEdge> edges
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveEdges(UndirectedGraph`2<!!0,!!1>, IEnumerable`1<!!1>)
            int result = target.RemoveEdges(edges);
            return result;
        }

        /// <summary>Test stub for RemoveVertex(!0)</summary>
        [PexMethod]
        public bool RemoveVertex<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target, TVertex v)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveVertex(UndirectedGraph`2<!!0,!!1>, !!0)
            bool result = target.RemoveVertex(v);
            return result;
        }

        /// <summary>Test stub for RemoveVertexIf(VertexPredicate`1&lt;!0&gt;)</summary>
        [PexMethod]
        public int RemoveVertexIf<TVertex,TEdge>(
            [PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target,
            VertexPredicate<TVertex> pred
        )
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.RemoveVertexIf(UndirectedGraph`2<!!0,!!1>, VertexPredicate`1<!!0>)
            int result = target.RemoveVertexIf(pred);
            return result;
        }

        /// <summary>Test stub for TrimEdgeExcess()</summary>
        [PexMethod]
        public void TrimEdgeExcess<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.TrimEdgeExcess(UndirectedGraph`2<!!0,!!1>)
            target.TrimEdgeExcess();
        }

        /// <summary>Test stub for VertexCount</summary>
        [PexMethod]
        public void VertexCountGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.VertexCountGet(UndirectedGraph`2<!!0,!!1>)
            int result = target.VertexCount;
        }

        /// <summary>Test stub for Vertices</summary>
        [PexMethod]
        public void VerticesGet<TVertex,TEdge>([PexAssumeUnderTest]UndirectedGraph<TVertex, TEdge> target)
            where TEdge : IEdge<TVertex>
        {
            // TODO: add assertions to method UndirectedGraphTVertexTEdgeTest.VerticesGet(UndirectedGraph`2<!!0,!!1>)
            IEnumerable<TVertex> result = target.Vertices;
        }
    }
}
