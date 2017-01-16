﻿using System;
using System.Collections.Generic;
using System.Linq;
using Fusee.Engine.Core;
using Fusee.Jometri.DCEL;
using Fusee.Math.Core;


namespace Fusee.Engine.Examples.MeshingAround.Core
{
    public class HalfEdgeListToMesh : Mesh
    {
        public HalfEdgeListToMesh(Geometry3D geometry)
        {
            float3[] vertices;
            ushort[] triangles;
            List<float3> normals;

            ConvertToMesh(geometry, out vertices, out triangles, out normals);

            Vertices = vertices;
            Triangles = triangles;
            Normals = normals.ToArray();
        }

        //geometry has to be trinagulated
        private static void ConvertToMesh(Geometry3D geometry, out float3[] vertices, out ushort[] triangles, out List<float3> normals)
        {
            var triangleCount = geometry.GetAllFaces().ToList().Count;
            var vertCount = triangleCount * 3;

            var verts = new List<float3>();

            vertices = new float3[vertCount];
            triangles = new ushort[vertCount];
            normals = new List<float3>();

            foreach (var face in geometry.GetAllFaces())
            {
                var faceVerts = geometry.GetFaceVertices(face.Handle).ToList();

                if (faceVerts.Count > 3)
                    throw new ArgumentException("Invalid triangle - face has more than 3 Vertices");

                foreach (var vertex in faceVerts)
                {
                    var vert = vertex;
                    verts.Add(vert.VertData.Pos);
                }
            }

            for (var i = 0; i < vertices.Length; i++)
            {
                vertices[i] = verts[i];
                triangles[i] = (ushort)i;
            }

            for (var i = 0; i < vertices.Length; i += 3)
            {
                var a = vertices[i + 1] - vertices[i];
                var b = vertices[i + 2] - vertices[i];

                var cross = float3.Cross(b, a);
                cross.Normalize();

                for (var j = 0; j < 3; j++)
                {
                    normals.Add(cross);
                }
            }
        }
    }
}
