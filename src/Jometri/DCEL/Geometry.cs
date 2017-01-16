﻿using System;
using System.Collections.Generic;
using System.Linq;
using Fusee.Base.Core;
using Fusee.Jometri.Triangulation;
using Fusee.Math.Core;

namespace Fusee.Jometri.DCEL
{
    /// <summary>
    /// Each vertex contains:
    /// A handle to assign a abstract reference to it.
    /// Attribute information, e.g. the position of the vertex.
    /// </summary>
    public struct Vertex
    {
        /// <summary>
        /// The vertex' reference.
        /// </summary>
        internal int Handle;

        /// <summary>
        /// The handle to the half edge with this vertex as origin.
        /// </summary>
        internal int IncidentHalfEdge;

        /// <summary>
        /// Attribute information.
        /// </summary>
        public VertexData VertData;

        /// <summary>
        /// Constructor for creating a new Vertex.
        /// </summary>
        /// <param name="pos">The coordinate of the vertex.</param>
        public Vertex(float3 pos)
        {
            Handle = default(int);
            IncidentHalfEdge = default(int);
            VertData = new VertexData {Pos = pos};
        }

        #region  Overloading comparison operators

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the vertex' handle.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator <(Vertex first, Vertex second)
        {
            return first.Handle < second.Handle;
        }

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the vertex' handle.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator >(Vertex first,Vertex second)
        {
            return first.Handle > second.Handle;
        }

        /// <summary>
        /// Overload for != operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator !=(Vertex first, Vertex second)
        {
            return first.Handle != second.Handle;
        }

        /// <summary>
        /// Overload for == operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator ==(Vertex first, Vertex second)
        {
            return first.Handle == second.Handle;
        }

        /// <summary>Overwrites "Equals".</summary>
        /// <returns>true, if <paramref name="obj" /> and this instance of the object are of the same type and represent the same value.</returns>
        /// <param name="obj">Object to compare with.</param>
        public override bool Equals(object obj)
        {
            if (!(obj is Vertex))
                return false;

            var comp = (Vertex)obj;
            return this == comp;

        }


        /// <summary>Overwrites GetHashCode.</summary>
        /// <returns>Handle as code.</returns>
        public override int GetHashCode()
        {
            return Handle;
        }

        #endregion

    }

    /// <summary>
    /// Represents a half edge.
    /// Each half edge contains:
    /// A handle to assign a abstract reference to it.
    /// A handle to the half edges' origin vertex.
    /// A handle to the next half edge.
    /// A handle to the previous half edge.
    /// A handle to the face it belongs to.
    /// Attribute information, e.g. the normal and the texture coordinates.
    /// </summary>
    public struct HalfEdge
    {
        internal int Handle;

        internal int OriginVertex;
        internal int TwinHalfEdge;
        internal int NextHalfEdge;
        internal int PrevHalfEdge;
        internal int IncidentFace;

        /// <summary>
        /// Attribute information.
        /// </summary>
        public HalfEdgeData HalfEdgeData;

        /// <summary>
        /// Constructor for creating a new HalfEdge.
        /// </summary>
        public HalfEdge(int handle = 0, int originVertex = 0, int twinHalfEdge = 0, int nextHalfEdge = 0, int prevHalfEdge = 0, int incidentFace = 0)
        {
            Handle = handle;
            OriginVertex = originVertex;
            TwinHalfEdge = twinHalfEdge;
            NextHalfEdge = nextHalfEdge;
            PrevHalfEdge = prevHalfEdge;
            IncidentFace = incidentFace;
            HalfEdgeData = new HalfEdgeData();
        }

        #region  Overloading comparison operators

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the HalfEdges' handle.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator <(HalfEdge first, HalfEdge second)
        {
            return first.Handle < second.Handle;
        }

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the HalfEdges' handle
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator >(HalfEdge first, HalfEdge second)
        {
            return first.Handle > second.Handle;
        }

        /// <summary>
        /// Overload for != operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator !=(HalfEdge first, HalfEdge second)
        {
            return first.Handle != second.Handle;
        }

        /// <summary>
        /// Overload for == operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator ==(HalfEdge first, HalfEdge second)
        {
            return (first.Handle == second.Handle);
        }

        /// <summary>Overwrites "Equals".</summary>
        /// <returns>true, if <paramref name="obj" /> and this instance are of the same type and represent the same value.</returns>
        /// <param name="obj">Comparison object.</param>
        public override bool Equals(object obj)
        {
            if (!(obj is HalfEdge))
                return false;

            var comp = (HalfEdge)obj;
            return this == comp;

        }


        /// <summary>Overwrites GetHashCode</summary>
        /// <returns>Handle as hash code.</returns>
        public override int GetHashCode()
        {
            return Handle;
        }

        #endregion
    }


    /// <summary>
    /// Needed for the basic functions of Geometry to work with both, 2D and 3D faces.
    /// </summary>
    public interface IFace
    {
        /// <summary>
        /// Handle to assign a abstract reference.
        /// </summary>
        int Handle { get; set; }

        /// <summary>
        /// Handle to one of the half edges that belongs to the faces outer boundary.
        /// </summary>
        int OuterHalfEdge { get; set; }
    }

    /// <summary>
    /// Each face belonging to a 2D geometry contains:
    /// A handle to assign a abstract reference to it.
    /// A handle to one of the half edges that belongs to the faces outer boundary.
    /// A List that contains handles to one half edge for each hole in a face.
    /// Attribute information, e.g. the face nromal.
    /// Note that unbounded faces can't have a OuterHalfEdge but must have at least one InnerHalfEdge - bounded faces must have a OuterComponent.
    /// </summary>
    internal struct Face2D : IFace
    {
        public int Handle { get; set; }
        public int OuterHalfEdge { get; set; }

        public FaceData FaceData;

        internal List<int> InnerHalfEdges;

        /// <summary>
        /// Constructor for creating a new Face.
        /// </summary>
        public Face2D(int handle = 0, int outerHalfEdge = 0) : this()
        {
            Handle = handle;
            OuterHalfEdge = outerHalfEdge;
            FaceData = new FaceData();
            InnerHalfEdges = new List<int>();
        }

        #region  Overloading comparison operators

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the Faces' handle.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator <(Face2D first, Face2D second)
        {
            return first.Handle < second.Handle;
        }

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the Faces' handle.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator >(Face2D first, Face2D second)
        {
            return first.Handle > second.Handle;
        }

        /// <summary>
        /// Overload for != operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator !=(Face2D first, Face2D second)
        {
            return first.Handle != second.Handle;
        }

        /// <summary>
        /// Overload for == operator.
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator ==(Face2D first, Face2D second)
        {
            return (first.Handle == second.Handle);
        }

        /// <summary>Overwrites "Equals"</summary>
        /// <returns>true, if <paramref name="obj" /> and this instance are of the same type and represent the same value.</returns>
        /// <param name="obj">Comparison object.</param>
        public override bool Equals(object obj)
        {
            if (!(obj is Face2D))
                return false;

            var comp = (Face2D)obj;
            return this == comp;

        }


        /// <summary>Overwrites GetHashCode</summary>
        /// <returns>Handle as hash code.</returns>
        public override int GetHashCode()
        {
            return Handle;
        }

        #endregion
    }

    /// <summary>
    /// Each face belonging to a 3D geometry contains:
    /// A handle to assign a abstract reference to it.
    /// A handle to one of the half edges that belongs to this faces outer boundary.
    /// Attribute information, e.g. the face nromal.
    /// </summary>
    internal struct Face3D : IFace
    {
        public int Handle { get; set; }
        public int OuterHalfEdge { get; set; }

        public FaceData FaceData;

        /// <summary>
        /// Constructor for creating a new Face.
        /// </summary>
        public Face3D(int handle = 0, int outerHalfEdge = 0) : this()
        {
            Handle = handle;
            OuterHalfEdge = outerHalfEdge;
            FaceData = new FaceData();
            
        }

        #region  Overloading comparison operators

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the Faces' handle
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator <(Face3D first, Face3D second)
        {
            return first.Handle < second.Handle;
        }

        /// <summary>
        /// Overload for "smaller than" operator. Comparison based on the Faces' handle
        /// </summary>
        /// <param name="first">First comparison parameter.</param>
        /// <param name="second">Second comparison parameter.</param>
        /// <returns></returns>
        public static bool operator >(Face3D first, Face3D second)
        {
            return first.Handle > second.Handle;
        }

        /// <summary>
        /// Overload for != operator
        /// </summary>
        /// <param name="first">First parameter to be compared</param>
        /// <param name="second">Second parameter to be compared</param>
        /// <returns></returns>
        public static bool operator !=(Face3D first, Face3D second)
        {
            return first.Handle != second.Handle;
        }

        /// <summary>
        /// Overload for == operator
        /// </summary>
        /// <param name="first">First parameter to be compared</param>
        /// <param name="second">Second parameter to be compared</param>
        /// <returns></returns>
        public static bool operator ==(Face3D first, Face3D second)
        {
            return (first.Handle == second.Handle);
        }

        /// <summary>Overwrites Equals</summary>
        /// <returns>true, if <paramref name="obj" /> and this instance are of the same type and represent the same value.</returns>
        /// <param name="obj">Object to compare with.</param>
        public override bool Equals(object obj)
        {
            if (!(obj is Face3D))
                return false;

            var comp = (Face3D)obj;
            return this == comp;

        }


        /// <summary>Overwrites GetHashCode</summary>
        /// <returns>Handle is the hash code.</returns>
        public override int GetHashCode()
        {
            return Handle;
        }

        #endregion
    }

    /// <summary>
    /// Represents an outer or inner boundary of a polygon.
    /// </summary>
    public struct PolyBoundary
    {
        /// <summary>
        /// The geometric information of the vertices which belong to a boundary
        /// </summary>
        public IList<float3> Points;

        /// <summary>
        /// Determines whether a boundary is a outer bondary or a inner boundary (which forms a hole in the face).
        /// </summary>
        public bool IsOuter;
    }

    /// <summary>
    /// Base class - Geometry, stored in a DCEL (half edge data structure).
    /// </summary>
    public abstract class Geometry
    {
        #region Members

        /// <summary>
        /// Contains all vertices of the Geometry.
        /// </summary>
        protected internal Dictionary<int, Vertex> DictVertices { get; set; }

        /// <summary>
        /// Contains all half edges of the Geometry.
        /// </summary>
        protected internal Dictionary<int, HalfEdge> DictHalfEdges { get; set; }

        /// <summary>
        /// Contains all Faces of the Geometry.
        /// </summary>
        protected internal Dictionary<int, IFace> DictFaces { get; set; }

        /// <summary>
        /// The highest handle of all half edge handles - used to create a new handle.
        /// </summary>
        protected internal int HighestHalfEdgeHandle { get; private set; }

        /// <summary>
        /// The highest handle of all vertex handles - used to create a new handle.
        /// </summary>
        protected internal int HighestVertHandle { get; private set; }

        /// <summary>
        /// The highest handle of all face handles - used to create a new handle.
        /// </summary>
        protected internal int HighestFaceHandle { get; private set; }

        #endregion

        /// <summary>
        /// Used in the initialisation process of a new Geometry.
        /// A BoundaryEdge contains one edge of the boundary and the information whether the source vertex of the half edge (not the twin half edge) is already part of the Geometry
        /// </summary>
        protected struct BoundaryEdge
        {
            internal bool IsOriginOldVert;
            internal HalfEdge HalfEdge;
            internal HalfEdge TwinHalfEdge;
        }

        /// <summary>
        /// Returns all Vertices of the Geometry.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Vertex> GetAllVertices()
        {
            foreach (var vert in DictVertices)
            {
                yield return vert.Value;
            }
        }

        /// <summary>
        /// Returns all HalfEdges of the Geometry.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetAllHalfEdges()
        {
            foreach (var he in DictHalfEdges)
            {
                yield return he.Value;
            }
        }

        /// <summary>
        /// Returns all Faces of the Geometry.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IFace> GetAllFaces()
        {
            foreach (var face in DictFaces)
            {
                yield return face.Value;
            }
        }

        /// <summary>
        /// Gets a vertex by its handle.
        /// </summary>
        /// <param name="vHandle">The vertex' reference</param>
        /// <returns></returns>
        public Vertex GetVertexByHandle(int vHandle)
        {

            if (DictVertices.ContainsKey(vHandle))
            {
                return DictVertices[vHandle];
            }
            throw new HandleNotFoundException("HalfEdge with id " + vHandle + " not found!");
        }

        internal HalfEdge GetHalfEdgeByHandle(int hehandle)
        {
            if (DictHalfEdges.ContainsKey(hehandle))
            {
                return DictHalfEdges[hehandle];
            }
            throw new HandleNotFoundException("HalfEdge with id " + hehandle + " not found!");
        }

        internal IFace GetFaceByHandle(int fHandle)
        {
            if (DictFaces.ContainsKey(fHandle))
            {
                return DictFaces[fHandle];
            }
            throw new HandleNotFoundException("HalfEdge with id " + fHandle + " not found!");
        }

        #region circulators 

        /// <summary>
        /// This collection contains all vertices neighbouring a given vertex.
        /// </summary>
        /// <param name="vHandle">The reference of the vertex.</param>
        /// <returns></returns>
        public IEnumerable<Vertex> GetVertexAdjacentVertices(int vHandle)
        {
            var vert = GetVertexByHandle(vHandle);
            var e = GetHalfEdgeByHandle(vert.IncidentHalfEdge);
            var startEdge = e;

            var twin = GetHalfEdgeByHandle(e.TwinHalfEdge);
            yield return GetVertexByHandle(twin.OriginVertex);

            while (TwinNext(e).Handle != startEdge.Handle)
            {
                e = TwinNext(e);
                twin = GetHalfEdgeByHandle(e.TwinHalfEdge);
                yield return GetVertexByHandle(twin.OriginVertex);
            }
        }

        /// <summary>
        /// This collection contains all handles to Faces adjacent to a given vertex.
        /// </summary>
        /// <param name="vHandle">The reference of the vertex.</param>
        /// <returns></returns>
        public IEnumerable<IFace> GetVertexAdajacentFaces(int vHandle)
        {
            var vert = GetVertexByHandle(vHandle);
            var e = GetHalfEdgeByHandle(vert.IncidentHalfEdge);
            var startEdge = e;

            yield return GetFaceByHandle(startEdge.IncidentFace);

            while (TwinNext(e).Handle != startEdge.Handle)
            {
                e = TwinNext(e);
                yield return GetFaceByHandle(e.IncidentFace);
            }
        }

        /// <summary>
        /// This collection contains all handles to HalfEdges starting at or targeting a given vertex.
        /// </summary>
        /// <param name="vHandle">The reference of the vertex.</param>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetVertexIncidentHalfEdges(int vHandle)
        {
            var vert = GetVertexByHandle(vHandle);
            var e = GetHalfEdgeByHandle(vert.IncidentHalfEdge);
            var startEdge = e;

            yield return GetHalfEdgeByHandle(startEdge.Handle);

            while (TwinNext(e).Handle != startEdge.Handle)
            {
                e = TwinNext(e);
                yield return GetHalfEdgeByHandle(e.Handle);
                yield return GetHalfEdgeByHandle(e.TwinHalfEdge);
            }
        }

        /// <summary>
        /// This collection contains all handles to HalfEdges starting at a given vertex.
        /// </summary>
        /// <param name="vHandle">The reference of the vertex.</param>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetVertexStartingHalfEdges(int vHandle)
        {
            var vert = GetVertexByHandle(vHandle);
            var e = GetHalfEdgeByHandle(vert.IncidentHalfEdge);
            var startEdge = e;

            yield return GetHalfEdgeByHandle(startEdge.Handle);

            while (TwinNext(e).Handle != startEdge.Handle)
            {
                e = TwinNext(e);
                yield return GetHalfEdgeByHandle(e.Handle);
            }
        }

        /// <summary>
        /// This collection contains all handles to HalfEdges ending at a given vertex.
        /// </summary>
        /// <param name="vHandle">The reference of the vertex.</param>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetVertexTargetingHalfEdges(int vHandle)
        {
            var vert = GetVertexByHandle(vHandle);
            var e = GetHalfEdgeByHandle(vert.IncidentHalfEdge);
            var startEdge = e;

            yield return GetHalfEdgeByHandle(e.TwinHalfEdge);

            while (TwinNext(e).Handle != startEdge.Handle)
            {
                e = TwinNext(e);
                yield return GetHalfEdgeByHandle(e.TwinHalfEdge);
            }
        }

        private HalfEdge TwinNext(HalfEdge halfEdge)
        {
            if (halfEdge.TwinHalfEdge == default(int))
                return default(HalfEdge);

            var twin = GetHalfEdgeByHandle(halfEdge.TwinHalfEdge);
            return GetHalfEdgeByHandle(twin.NextHalfEdge);
        }

        /// <summary>
        /// This collection contains all handles to HalfEdges belonging to a closed loop.
        /// </summary>
        /// <param name="heHandle">The reference to the HalfEdge with which the loop starts.</param>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetHalfEdgeLoop(int heHandle)
        {
            var currentHandle = heHandle;

            do
            {
                var currentHalfEdge = GetHalfEdgeByHandle(currentHandle);
                currentHandle = currentHalfEdge.NextHalfEdge;
                yield return GetHalfEdgeByHandle(currentHalfEdge.Handle);

            } while (currentHandle != heHandle);
        }

        /// <summary>
        /// This collection contains all faces neighbouring a given face.
        /// </summary>
        /// <param name="fHandle">The reference of the face.</param>
        /// <returns></returns>
        public IEnumerable<IFace> GetFacesAdajacentToFace(int fHandle)
        {
            var face = GetFaceByHandle(fHandle);
            var firstHandle = face.OuterHalfEdge;
            var current = GetHalfEdgeByHandle(face.OuterHalfEdge);
            do
            {
                yield return GetFaceByHandle(current.IncidentFace);
                current = GetHalfEdgeByHandle(current.NextHalfEdge);
            } while (firstHandle != current.Handle);


            if (!(face is Face2D)) yield break;

            var face2D = (Face2D)face;
            var innerComponents = face2D.InnerHalfEdges;
            if (innerComponents.Count == 0) yield break;

            foreach (var he in innerComponents)
            {
                var cur = GetHalfEdgeByHandle(he);
                do
                {
                    yield return GetFaceByHandle(cur.IncidentFace);
                    cur = GetHalfEdgeByHandle(cur.NextHalfEdge);

                } while (he != cur.Handle);
            }
        }

        /// <summary>
        /// This collection contains all Vertices of a given face.
        /// </summary>
        /// <param name="fHandle">The reference of the face.</param>
        /// <returns></returns>
        public IEnumerable<Vertex> GetFaceVertices(int fHandle)
        {
            //Outer Outline
            var fistHalfEdgeHandle = GetFaceByHandle(fHandle).OuterHalfEdge;
            var halfEdgeOuter = GetHalfEdgeByHandle(fistHalfEdgeHandle);

            do
            {
                var originVert = halfEdgeOuter.OriginVertex;
                yield return GetVertexByHandle(originVert);
                halfEdgeOuter = GetHalfEdgeByHandle(halfEdgeOuter.NextHalfEdge);

            } while (halfEdgeOuter.Handle != fistHalfEdgeHandle);

            //Inner Outlines
            var face = GetFaceByHandle(fHandle);

            if (!(face is Face2D)) yield break;
            var face2D = (Face2D)face;
            var innerComponents = face2D.InnerHalfEdges;

            if (innerComponents.Count == 0) yield break;

            foreach (var comp in innerComponents)
            {
                var halfEdgeInner = GetHalfEdgeByHandle(comp);

                do
                {
                    var originVert = halfEdgeInner.OriginVertex;
                    yield return GetVertexByHandle(originVert);
                    halfEdgeInner = GetHalfEdgeByHandle(halfEdgeInner.NextHalfEdge);

                } while (halfEdgeInner.Handle != comp);

            }
        }

        /// <summary>
        /// This collection contains all handles to HalfEdges of a given face.
        /// </summary>
        /// <param name="fHandle">The reference of the face.</param>
        /// <returns></returns>
        public IEnumerable<HalfEdge> GetFaceHalfEdges(int fHandle)
        {
            var face = GetFaceByHandle(fHandle);
            var firstHandle = face.OuterHalfEdge;
            var current = GetHalfEdgeByHandle(face.OuterHalfEdge);
            do
            {
                yield return GetHalfEdgeByHandle(current.Handle);
                current = GetHalfEdgeByHandle(current.NextHalfEdge);
            } while (firstHandle != current.Handle);


            if (!(face is Face2D)) yield break;

            var face2D = (Face2D)face;

            foreach (var he in face2D.InnerHalfEdges)
            {
                var cur = GetHalfEdgeByHandle(he);
                do
                {
                    yield return GetHalfEdgeByHandle(cur.Handle);
                    cur = GetHalfEdgeByHandle(cur.NextHalfEdge);

                } while (he != cur.Handle);
            }
        }
        #endregion

        /// <summary>
        /// Tests if a vertex is a direct neighbour of an other vertex. Use this if you do not know the vertices incident half edges. 
        /// </summary>
        /// <param name="p">First vertex</param>
        /// <param name="q">Secound vertex</param>
        /// <returns></returns>
        protected bool IsVertexAdjacentToVertex(int p, int q)
        {
            var vertP = GetVertexByHandle(p);
            var vertPStartHe = GetHalfEdgeByHandle(vertP.IncidentHalfEdge);

            var vertQ = GetVertexByHandle(q);
            var vertQStartHe = GetHalfEdgeByHandle(vertQ.IncidentHalfEdge);

            var nextHeP = GetHalfEdgeByHandle(vertPStartHe.NextHalfEdge);
            var nextHeQ = GetHalfEdgeByHandle(vertQStartHe.NextHalfEdge);

            return nextHeP.OriginVertex == q || nextHeQ.OriginVertex == p;
        }

        /// <summary>
        /// Tests if a vertex is a direct neighbour of an other vertex. Use this only if you know the vertices incident half edges. 
        /// </summary>
        /// <param name="p">First vertex</param>
        /// <param name="q">Secound vertex</param>
        /// <param name="vertPStartHe">p incident half edge </param>
        /// <param name="vertQStartHe">q incident half edge</param>
        /// <returns></returns>
        protected bool IsVertexAdjacentToVertex(int p, int q, HalfEdge vertPStartHe, HalfEdge vertQStartHe)
        {
            var nextHeP = GetHalfEdgeByHandle(vertPStartHe.NextHalfEdge);
            var nextHeQ = GetHalfEdgeByHandle(vertQStartHe.NextHalfEdge);

            return nextHeP.OriginVertex == q || nextHeQ.OriginVertex == p;
        }

        internal void ReplaceVertex(Vertex vert)
        {
            var key = vert.Handle;
            DictVertices[key] = vert;
        }

        internal void ReplaceHalfEdge(HalfEdge halfEdge)
        {
            var key = halfEdge.Handle;
            DictHalfEdges[key] = halfEdge;
        }

        internal void ReplaceFace(IFace face)
        {
            var key = face.Handle;
            DictFaces[key] = face;            
        }

        #region ID creation for Vert-, Face- and HalfEdgeHandles

        internal int CreateVertHandleId()
        {
            var newId = HighestVertHandle + 1;
            HighestVertHandle = newId;
            return newId;
        }

        internal int CreateHalfEdgeHandleId()
        {
            var newId = HighestHalfEdgeHandle + 1;
            HighestHalfEdgeHandle = newId;
            return newId;
        }

        internal int CreateFaceHandleId()
        {
            var newId = HighestFaceHandle + 1;
            HighestFaceHandle = newId;
            return newId;
        }

        internal void SetHighestHandles()
        {
            HighestVertHandle = DictVertices.Keys.Max();
            HighestHalfEdgeHandle = DictHalfEdges.Keys.Max();
            HighestFaceHandle = DictFaces.Keys.Max();
        }

        #endregion


    }

    /// <summary>
    /// 2D Geometry, stored in a DCEL (half edge data structure).
    /// </summary>
    public class Geometry2D : Geometry
    {
        /// <summary>
        /// Creates an empty geometry, that can be filled by the user using InsertFace, InsertHalfEdge and InsertVertex methodes
        /// </summary>
        protected Geometry2D()
        {
            DictVertices = new Dictionary<int, Vertex>();
            DictHalfEdges = new Dictionary<int, HalfEdge>();
            DictFaces = new Dictionary<int, IFace>();
        }

        /// <summary>
        /// 2D Geometry, stored in a DCEL (half edge data structure).
        /// </summary>
        /// <param name="outlines">A collection of the geometrys' outlines, each containing the geometric information as a list of float3 in ccw order.</param>
        public Geometry2D(IEnumerable<PolyBoundary> outlines)
        {
            DictVertices = new Dictionary<int, Vertex>();
            DictHalfEdges = new Dictionary<int, HalfEdge>();
            DictFaces = new Dictionary<int, IFace>();

            CreateHalfEdgesForGeometry(outlines);

            this.Triangulate();
        }

        //Clones a existing Geometry object. E.g to create a backface for an extrusion.
        internal Geometry2D CloneGeometry()
        {
            var clone = new Geometry2D
            {
                DictVertices = new Dictionary<int, Vertex>(DictVertices),
                DictHalfEdges = new Dictionary<int, HalfEdge>(DictHalfEdges),
                DictFaces = new Dictionary<int, IFace>()
            };

            foreach (var f in DictFaces)
            {
                var oldFace = (Face2D)f.Value;
                var face = new Face2D(oldFace.Handle, oldFace.OuterHalfEdge);
                face.InnerHalfEdges.AddRange(oldFace.InnerHalfEdges);
                clone.DictFaces.Add(face.Handle, face);
            }

            return clone;
        }

        #region 2D geometry initialisation

        private void CreateHalfEdgesForGeometry(IEnumerable<PolyBoundary> outlines)
        {
            var unboundedFace = new Face2D(DictHalfEdges.Count + 1);
            
            DictFaces.Add(unboundedFace.Handle, unboundedFace);

            foreach (var o in outlines)
            {
                var boundaryHalfEdges = CreateHalfEdgesForBoundary(o);
                foreach (var be in boundaryHalfEdges)
                {
                    DictHalfEdges.Add(be.HalfEdge.Handle, be.HalfEdge);
                    DictHalfEdges.Add(be.TwinHalfEdge.Handle, be.TwinHalfEdge);
                }
            }

            SetHighestHandles();
        }

        private IEnumerable<BoundaryEdge> CreateHalfEdgesForBoundary(PolyBoundary outline)
        {
            var outlineVerts = OutlineVertices(outline);
            var boundaryEdges = BoundaryEdges(outlineVerts, outline);

            SetPrevAndNextForBoundary(boundaryEdges);

            var halfEdgesToUpdate = new List<HalfEdge>();

            for (var i = boundaryEdges.Count - 1; i > -1; i--)
            {
                var bEdge = boundaryEdges[i];

                if (!bEdge.IsOriginOldVert) continue; //A half-edge can only exist if its source vertex is an old one.

                int existingHeHandle;
                if (!IsEdgeExisting(bEdge.HalfEdge, boundaryEdges, out existingHeHandle)) continue; //Check the target vert to identify the existing half edge

                //If the existing half edge is halfedge.IncidentFace.OuterHalfEdge - replace
                var face = (Face2D)GetFaceByHandle(bEdge.HalfEdge.IncidentFace);
                if (face.OuterHalfEdge == bEdge.HalfEdge.Handle)
                {
                    face.OuterHalfEdge = existingHeHandle;
                    ReplaceFace(face);
                }

                //If the existing half edge is one of the unbounded faces inner half edges - replace
                var unboundedFace = (Face2D)DictFaces[1];
                for (var k = 0; k < unboundedFace.InnerHalfEdges.Count; k++)
                {
                    var heHandle = unboundedFace.InnerHalfEdges[k];
                    if (heHandle != existingHeHandle) continue;
                    var nextHe = GetHalfEdgeByHandle(heHandle).NextHalfEdge;

                    unboundedFace.InnerHalfEdges[k] = nextHe;
                    DictFaces[1] = unboundedFace;
                    break;
                }

                var existingHe = GetHalfEdgeByHandle(existingHeHandle);

                existingHe.NextHalfEdge = bEdge.HalfEdge.NextHalfEdge;
                existingHe.PrevHalfEdge = bEdge.HalfEdge.PrevHalfEdge;
                existingHe.IncidentFace = bEdge.HalfEdge.IncidentFace;

                halfEdgesToUpdate.Add(existingHe);

                SetPrevAndNextToExistingHalfEdge(bEdge, existingHeHandle, boundaryEdges, halfEdgesToUpdate);

                boundaryEdges.RemoveAt(i);
            }

            if (halfEdgesToUpdate.Count == 0) return boundaryEdges;

            foreach (var he in halfEdgesToUpdate)
            {
                ReplaceHalfEdge(he);
            }
            return boundaryEdges;
        }

        private int AddFace(int firstHalfEdge, out Face2D face)
        {
            face = new Face2D(DictFaces.Count + 1, firstHalfEdge);
            return face.Handle;
        }

        private Vertex CreateOrFindVertex(float3 pointCoord, out bool isOldVertex, int handle)
        {
            int vertHandle;
            Vertex vert;

            //Check if a Vertex already exists and assign it to the HalfEdge instead of createing a new
            if (DictVertices.Count != 0)
            {
                foreach (var v in GetAllVertices())
                {
                    if (!pointCoord.Equals(v.VertData.Pos)) continue;
                    isOldVertex = true;
                    return v;
                }

                //Create Vertice and VertHandle
                vertHandle = handle;
                vert = new Vertex(pointCoord);
                vert.Handle = vertHandle;
            }
            else
            {
                //Create Vertices and VertHandle
                vertHandle = handle;
                vert = new Vertex(pointCoord);
                vert.Handle = vertHandle;
            }
            isOldVertex = false;
            return vert;
        }

        private List<KeyValuePair<Vertex, bool>> OutlineVertices(PolyBoundary polyBoundary)
        {
            var outlineVerts = new List<KeyValuePair<Vertex, bool>>();

            var handle = 0;
            if (DictVertices.Count != 0)
                handle = DictVertices.Count;

            foreach (var coord in polyBoundary.Points)
            {
                bool isOldVert;
                handle ++;
                var vert = CreateOrFindVertex(coord, out isOldVert, handle);
                outlineVerts.Add(new KeyValuePair<Vertex, bool>(vert, isOldVert));
            }
            return outlineVerts;
        }

        private List<BoundaryEdge> BoundaryEdges(IList<KeyValuePair<Vertex, bool>> outlineVerts, PolyBoundary polyBoundary)
        {
            var faceHandle = new int();
            var boundaryEdges = new List<BoundaryEdge>();

            var halfEdgeHandle = 0;
            if (DictHalfEdges.Count != 0)
                halfEdgeHandle = DictHalfEdges.Count;

            for (var j = 0; j < outlineVerts.Count; j++)
            {
                var currentVert = outlineVerts[j];
                halfEdgeHandle ++;

                if (!currentVert.Value)
                {
                    //Only necessary for new Vertices
                    var vert = currentVert.Key;
                    vert.IncidentHalfEdge = halfEdgeHandle;
                    DictVertices.Add(vert.Handle, vert);
                }

                var halfEdge = new HalfEdge(halfEdgeHandle, currentVert.Key.Handle);
                

                halfEdgeHandle ++;
                var twinHalfEdge = new HalfEdge(halfEdgeHandle, outlineVerts[(j + 1)%outlineVerts.Count].Key.Handle,
                    halfEdge.Handle, 0, 0, 1); //The unbounded face is always added at first and therefor has 1 as handle.
                

                halfEdge.TwinHalfEdge = twinHalfEdge.Handle;

                //Assumption: outlines are processed from outer to inner for every face, therfore faceHandle will never has its default value if "else" is hit.
                if (polyBoundary.IsOuter)
                {
                    if (faceHandle == default(int))
                    {
                        Face2D face;
                        faceHandle = AddFace(halfEdge.Handle, out face);
                        DictFaces.Add(face.Handle, face);
                    }
                }
                else
                {
                    if (j == 0)
                    {
                        var lastFace = (Face2D)DictFaces[DictFaces.Keys.Max()];
                        lastFace.InnerHalfEdges.Add(halfEdge.Handle);
                    }
                    faceHandle = DictFaces.LastItem().Value.Handle;
                }

                halfEdge.IncidentFace = faceHandle;

                if (!outlineVerts[j].Value)
                {
                    var unboundFace = (Face2D)DictFaces[1];

                    if (j == 0)
                    {
                        unboundFace.InnerHalfEdges.Add(twinHalfEdge.Handle);
                        DictFaces[1] = unboundFace;
                    }
                }

                var boundaryEdge = new BoundaryEdge
                {
                    IsOriginOldVert = currentVert.Value,
                    HalfEdge = halfEdge,
                    TwinHalfEdge = twinHalfEdge
                };
                boundaryEdges.Add(boundaryEdge);
            }
            return boundaryEdges;
        }

        private static void SetPrevAndNextForBoundary(IList<BoundaryEdge> boundaryEdges)
        {
            for (var i = 0; i < boundaryEdges.Count; i++)
            {
                var bEdge = boundaryEdges[i];
                var halfEdge = bEdge.HalfEdge;
                var twinHalfEdge = bEdge.TwinHalfEdge;

                //Assumption: a boundary is always closed!
                halfEdge.NextHalfEdge = boundaryEdges[(i + 1) % boundaryEdges.Count].HalfEdge.Handle;
                twinHalfEdge.PrevHalfEdge = boundaryEdges[(i + 1) % boundaryEdges.Count].TwinHalfEdge.Handle;

                if (i - 1 < 0)
                {
                    halfEdge.PrevHalfEdge = boundaryEdges.LastItem().HalfEdge.Handle;
                    twinHalfEdge.NextHalfEdge = boundaryEdges.LastItem().TwinHalfEdge.Handle;
                }
                else
                {
                    halfEdge.PrevHalfEdge = boundaryEdges[i - 1].HalfEdge.Handle;
                    twinHalfEdge.NextHalfEdge = boundaryEdges[i - 1].TwinHalfEdge.Handle;
                }

                bEdge.HalfEdge = halfEdge;
                bEdge.TwinHalfEdge = twinHalfEdge;

                boundaryEdges[i] = bEdge;
            }
        }

        private void SetPrevAndNextToExistingHalfEdge(BoundaryEdge bEdge, int existingHeHandle, List<BoundaryEdge> boundaryEdges, List<HalfEdge> halfEdgesToUpdate)
        {
            var existingHe = GetHalfEdgeByHandle(existingHeHandle);
            var existingHeNext = GetHalfEdgeByHandle(existingHe.NextHalfEdge);
            var existingHePrev = GetHalfEdgeByHandle(existingHe.PrevHalfEdge);

            existingHe.NextHalfEdge = bEdge.HalfEdge.NextHalfEdge;
            existingHe.PrevHalfEdge = bEdge.HalfEdge.PrevHalfEdge;
            existingHe.IncidentFace = bEdge.HalfEdge.IncidentFace;

            for (var j = 0; j < boundaryEdges.Count; j++)
            {
                var count = 0;
                var be = boundaryEdges[j];
                if (be.TwinHalfEdge.Handle == bEdge.TwinHalfEdge.PrevHalfEdge)
                {
                    var twinHalfEdge = be.TwinHalfEdge;
                    twinHalfEdge.NextHalfEdge = existingHeNext.Handle;

                    var halfEdge = be.HalfEdge;
                    halfEdge.PrevHalfEdge = existingHeHandle;

                    be.TwinHalfEdge = twinHalfEdge;
                    be.HalfEdge = halfEdge;

                    existingHeNext.PrevHalfEdge = twinHalfEdge.Handle;

                    halfEdgesToUpdate.Add(existingHeNext);

                    boundaryEdges[j] = be;
                    count++;
                }

                if (be.TwinHalfEdge.Handle == bEdge.TwinHalfEdge.NextHalfEdge)
                {
                    var twinHalfEdge = be.TwinHalfEdge;
                    twinHalfEdge.PrevHalfEdge = existingHePrev.Handle;

                    var halfEdge = be.HalfEdge;
                    halfEdge.NextHalfEdge = existingHeHandle;

                    be.TwinHalfEdge = twinHalfEdge;
                    be.HalfEdge = halfEdge;

                    existingHePrev.NextHalfEdge = twinHalfEdge.Handle;

                    halfEdgesToUpdate.Add(existingHePrev);

                    boundaryEdges[j] = be;
                    count++;
                }
                if (count == 2)
                    break;
            }
        }

        private bool IsEdgeExisting(HalfEdge halfEdge, IEnumerable<BoundaryEdge> boundaryEdges, out int existingHeHandle)
        {
            existingHeHandle = new int();

            var newHeTargetVert = new int();

            foreach (var be in boundaryEdges)
            {
                if (be.HalfEdge.Handle == halfEdge.NextHalfEdge)
                    newHeTargetVert = be.HalfEdge.OriginVertex;
            }

            if (newHeTargetVert == default(int))
                throw new ArgumentException("target vert not found");

            var heStartingAtOldV = GetVertexStartingHalfEdges(halfEdge.OriginVertex).ToList();

            foreach (var heHandle in heStartingAtOldV)
            {
                var he = heHandle;
                var oldHeTargetVert = GetHalfEdgeByHandle(he.NextHalfEdge).OriginVertex;

                if (oldHeTargetVert != newHeTargetVert) continue;
                existingHeHandle = heHandle.Handle;
                return true;
            }
            return false;
        }

        #endregion

        #region Insert Diagonal
        /// <summary>
        /// Inserts a pair of half edges between two (non adjacant) vertices of a face.
        /// </summary>
        /// <param name="p">First vertex handle.</param>
        /// <param name="q">Second vertex handle.</param>
        /// <exception cref="Exception"></exception>
        public void InsertDiagonal(int p, int q)
        {
            var heStartingAtP = GetVertexStartingHalfEdges(p).ToList();
            var heStaringAtQ = GetVertexStartingHalfEdges(q).ToList();

            var face = new Face2D();
            var pStartHe = new HalfEdge();
            var qStartHe = new HalfEdge();

            foreach (var heP in heStartingAtP)
            {
                var faceHandleP = heP.IncidentFace;

                foreach (var heQ in heStaringAtQ)
                {
                    var faceHandleQ = heQ.IncidentFace;

                    if (faceHandleP != faceHandleQ) continue;

                    var commonFace = GetFaceByHandle(faceHandleP);

                    if (commonFace.OuterHalfEdge == default(int)) break;

                    face = (Face2D)GetFaceByHandle(faceHandleP);
                    pStartHe = heP;
                    qStartHe = heQ;

                    break;
                }
            }
            if (pStartHe.Handle == default(int))
                throw new ArgumentException("Vertex " + p + " vertex " + q + " have no common Face!");

            if (IsVertexAdjacentToVertex(p, q, pStartHe, qStartHe))
                throw new ArgumentException("A diagonal can not be insertet beween adjacent Vertices!");

            var holes = GetHoles(face);

            var newFromP = new HalfEdge();
            var newFromQ = new HalfEdge();

            newFromP.OriginVertex = p;
            newFromP.NextHalfEdge = qStartHe.Handle;
            newFromP.PrevHalfEdge = pStartHe.PrevHalfEdge;
            newFromP.IncidentFace = face.Handle;
            newFromP.Handle = CreateHalfEdgeHandleId();
            
            newFromQ.OriginVertex = q;
            newFromQ.NextHalfEdge = pStartHe.Handle;
            newFromQ.PrevHalfEdge = qStartHe.PrevHalfEdge;
            newFromQ.IncidentFace = face.Handle;
            newFromQ.Handle = CreateHalfEdgeHandleId();
            
            newFromP.TwinHalfEdge = newFromQ.Handle;
            newFromQ.TwinHalfEdge = newFromP.Handle;

            DictHalfEdges.Add(newFromP.Handle, newFromP);
            DictHalfEdges.Add(newFromQ.Handle, newFromQ);

            //Assign new Next to previous HalfEdges from p and q & assign new prev for qStartHe and pStartHe
            var prevHeP = GetHalfEdgeByHandle(pStartHe.PrevHalfEdge);
            var prevHeQ = GetHalfEdgeByHandle(qStartHe.PrevHalfEdge);
            
            var prevHePUpdate = DictHalfEdges[prevHeP.Handle];
            prevHePUpdate.NextHalfEdge = newFromP.Handle;
            DictHalfEdges[prevHeP.Handle] = prevHePUpdate;

            var prevHeQUpdate = DictHalfEdges[prevHeQ.Handle];
            prevHeQUpdate.NextHalfEdge = newFromQ.Handle;
            DictHalfEdges[prevHeQ.Handle] = prevHeQUpdate;

            var nextHePUpdate = DictHalfEdges[pStartHe.Handle];
            nextHePUpdate.PrevHalfEdge = newFromQ.Handle;
            DictHalfEdges[pStartHe.Handle] = nextHePUpdate;

            var nextHeQUpdate = DictHalfEdges[qStartHe.Handle];
            nextHeQUpdate.PrevHalfEdge = newFromP.Handle;
            DictHalfEdges[qStartHe.Handle] = nextHeQUpdate;

            if (holes.Count != 0 && IsHalfEdgeToHole(holes, p, q, face)) return;

            var newFace = new Face2D(CreateFaceHandleId(), newFromQ.Handle);

            DictFaces.Add(newFace.Handle, newFace);

            //Assign the handle of the new face to its half edges.
            AssignFaceHandle(newFace.OuterHalfEdge, newFace);

            //Set face.OuterHalfEdge to newFromP - old OuterHalfEdge can be part of new face now!
            var faces = GetAllFaces().ToList();
            for (var i = 0; i < faces.Count; i++)
            {
                if (faces[i].Handle != face.Handle) continue;

                var currentFace = faces[i];
                currentFace.OuterHalfEdge = newFromP.Handle;
                faces[i] = currentFace;
                DictFaces[faces[i].Handle] = faces[i]; //TODO:Check if possible
            }
        }

        private Dictionary<int, List<HalfEdge>> GetHoles(Face2D face)
        {
            var holes = new Dictionary<int, List<HalfEdge>>();

            foreach (var he in face.InnerHalfEdges)
            {
                holes.Add(he, GetHalfEdgeLoop(he).ToList());
            }

            return holes;
        }

        private void AssignFaceHandle(int heHandle, Face2D newFace)
        {
            var oldFaceHandle = GetHalfEdgeByHandle(heHandle).IncidentFace;
            var currentHe = GetHalfEdgeByHandle(heHandle);
            do
            {
                currentHe.IncidentFace = newFace.Handle;

                DictHalfEdges[currentHe.Handle] = currentHe;
                
                currentHe = GetHalfEdgeByHandle(currentHe.NextHalfEdge);
            } while (currentHe.Handle != heHandle);

            //Assign newFace to possible holes in the "old" face

            var oldFace = (Face2D)GetFaceByHandle(oldFaceHandle);
            if (oldFace.InnerHalfEdges.Count == 0) return;

            var inner = new List<int>();
            inner.AddRange(oldFace.InnerHalfEdges);

            foreach (var heh in inner)
            {
                var origin = GetHalfEdgeByHandle(heh).OriginVertex;

                if (!IsPointInPolygon(newFace.Handle, GetVertexByHandle(origin))) continue;

                oldFace.InnerHalfEdges.Remove(heh);
                newFace.InnerHalfEdges.Add(heh);

                var curHe = GetHalfEdgeByHandle(heh);
                do
                {
                    curHe.IncidentFace = newFace.Handle;

                    DictHalfEdges[curHe.Handle] = curHe;
                    
                    curHe = GetHalfEdgeByHandle(curHe.NextHalfEdge);

                } while (curHe.Handle != heh);
            }
        }

        private static bool IsHalfEdgeToHole(Dictionary<int, List<HalfEdge>> holes, int pHandle, int qHandle, Face2D face)
        {
            if (holes.Count == 0) return false;

            foreach (var hole in holes)
            {
                foreach (var heHandle in hole.Value)
                {
                    var he = heHandle;
                    if (pHandle != he.OriginVertex && qHandle != he.OriginVertex) continue;

                    face.InnerHalfEdges.Remove(hole.Key);
                    return true;
                }
            }
            return false;
        }
        #endregion

        //Vertices need to be reduced to 2D
        //see Akenine-Möller, Tomas; Haines, Eric; Hoffman, Naty (2016): Real-Time Rendering, p. 754
        /// <summary>
        /// Tests if a point/vertex lies inside or outside a face - only works in 2D!
        /// </summary>
        /// <param name="fHandle">The handle to the face.</param>
        /// <param name="v">The vertex to be tested.</param>
        /// <returns></returns>
        protected bool IsPointInPolygon(int fHandle, Vertex v)
        {
            v.VertData.Pos = v.VertData.Pos.Reduce2D();

            var inside = false;
            var faceVerts = GetFaceVertices(fHandle).ToList();

            var e0 = GetVertexByHandle(faceVerts.LastItem().Handle);
            e0.VertData.Pos = e0.VertData.Pos.Reduce2D();

            var y0 = e0.VertData.Pos.y >= v.VertData.Pos.y;

            foreach (var vert in faceVerts)
            {
                var e1 = vert;
                e1.VertData.Pos = e1.VertData.Pos.Reduce2D();

                var y1 = e1.VertData.Pos.y >= v.VertData.Pos.y;
                if (y0 != y1)
                {
                    if ((e1.VertData.Pos.y - v.VertData.Pos.y) * (e0.VertData.Pos.x - e1.VertData.Pos.x) >=
                        (e1.VertData.Pos.x - v.VertData.Pos.x) * (e0.VertData.Pos.y - e1.VertData.Pos.y) == y1)
                    {
                        inside = !inside;
                    }
                }
                y0 = y1;
                e0 = e1;
            }
            return inside;
        }
    }

    /// <summary>
    /// 3D Geometry, stored in a DCEL (doubly conneted edge list).
    /// </summary>
    public class Geometry3D : Geometry
    {


    }

}



