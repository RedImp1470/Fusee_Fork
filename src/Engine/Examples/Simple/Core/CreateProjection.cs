using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Fusee.Math.Core;


namespace Fusee.Engine.Examples.Simple.Core
{
    public static class CreateProjection
    {

        public static StreamReader Reader;
        private const string LineSeparator = "\n";
        private const string KeyValueSeparator = "=";


        // Use this for initialization
        public static float4x4 CreateProjectionMat(Dictionary<string, string> parsedFile, float near, float far)
        {
            var intrinsic = new float3x3();
            var focalLength = -1 * float.Parse(parsedFile["c"], CultureInfo.InvariantCulture);
            intrinsic.M11 = focalLength;
            intrinsic.M22 = focalLength;

            intrinsic.M13 = float.Parse(parsedFile["xh"], CultureInfo.InvariantCulture);
            intrinsic.M23 = float.Parse(parsedFile["yh"], CultureInfo.InvariantCulture);
            intrinsic.M33 = 1;

            var projection = new float4x4();
            var a = near + far / (far - near);
            var b = a * near;

            projection.M11 = intrinsic.M11;
            projection.M12 = intrinsic.M12;
            projection.M13 = intrinsic.M13;

            projection.M21 = intrinsic.M21;
            projection.M22 = intrinsic.M22;
            projection.M23 = intrinsic.M23;

            projection.M33 = a;
            projection.M34 = b;

            projection.M43 = 1;

            var pixelSize = float.Parse(parsedFile["PIXELSIZE"], CultureInfo.InvariantCulture);
            var width = float.Parse(parsedFile["SENSOR_WIDTH_PIX"], CultureInfo.InvariantCulture) * pixelSize;
            var height = float.Parse(parsedFile["SENSOR_HEIGHT_PIX"], CultureInfo.InvariantCulture) * pixelSize;
            var ortho = float4x4.CreateOrthographic(width, height, near, far);

            var res = ortho * projection;

            return res;
        }

        public static float4x4 CreateOrtho(float width, float height, float near, float far)
        {
            var ortho = float4x4.Identity;
            var left = -width / 2;
            var right = width / 2;
            var bottom = -height / 2;
            var top = height / 2;

            ortho.M11 = -2 / (left - right);
            ortho.M22 = 2 / (top - bottom);
            ortho.M33 = -2 / (far - near);
            ortho.M14 = (right + left) / (right - left);
            ortho.M24 = (top - bottom) / (top - bottom);
            ortho.M34 = (far + near) / (far - near);

            return ortho;
        }

        public static float4x4 CreateViewMat(Dictionary<string, string> parsedFile)
        {
            var x = float.Parse(parsedFile["B_dx"], CultureInfo.InvariantCulture) * 1000;
            var y = float.Parse(parsedFile["B_dz"], CultureInfo.InvariantCulture) * 1000;
            var z = float.Parse(parsedFile["B_dy"], CultureInfo.InvariantCulture) * 1000;
            var translVec = new float3(x, y, z);

            var extrinsicRotX = float3x3.Identity.CreateRotationX(float.Parse(parsedFile["B_rotx"], CultureInfo.InvariantCulture));
            var extrinsicRotY = float3x3.Identity.CreateRotationY(float.Parse(parsedFile["B_rotz"], CultureInfo.InvariantCulture));
            var extrinsicRotZ = float3x3.Identity.CreateRotationZ(float.Parse(parsedFile["B_roty"], CultureInfo.InvariantCulture));
            var extrinsicRot = extrinsicRotX * extrinsicRotY * extrinsicRotZ;

            var extrinsic = float4x4.Identity;
            extrinsic.M11 = extrinsicRot.M11;
            extrinsic.M12 = extrinsicRot.M12;
            extrinsic.M13 = extrinsicRot.M13;

            extrinsic.M21 = extrinsicRot.M21;
            extrinsic.M22 = extrinsicRot.M22;
            extrinsic.M23 = extrinsicRot.M23;

            extrinsic.M31 = extrinsicRot.M31;
            extrinsic.M32 = extrinsicRot.M32;
            extrinsic.M33 = extrinsicRot.M33;

            extrinsic.M14 = translVec.x;
            extrinsic.M24 = translVec.y;
            extrinsic.M34 = translVec.z;

            return extrinsic;
        }

        public static float3x3 CreateRotationX(this float3x3 src, float rad)
        {
            src.M22 = M.Cos(rad);
            src.M23 = -M.Sin(rad);
            src.M32 = M.Sin(rad);
            src.M33 = M.Cos(rad);
            return src;
        }

        public static float3x3 CreateRotationY(this float3x3 src, float rad)
        {
            src.M11 = M.Cos(rad);
            src.M13 = M.Sin(rad);
            src.M31 = -M.Sin(rad);
            src.M33 = M.Cos(rad);
            return src;
        }

        public static float3x3 CreateRotationZ(this float3x3 src, float rad)
        {
            src.M11 = M.Cos(rad);
            src.M12 = -M.Sin(rad);
            src.M21 = M.Sin(rad);
            src.M22 = M.Cos(rad);
            return src;
        }

        public static Dictionary<string, string> Read(string config)
        {
            var _s = new Dictionary<string, string>();
            var lines = config.Split(new string[] { LineSeparator }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var l in lines)
            {
                var t = l.Trim();
                if (t[0] == '#')
                {
                    // Es wurde ein Kommentar gefunden ('#' als erstes Zeichen der Zeile).
                    // Dieser wird beim lesen ignoriert.
                }
                else
                {
                    string[] kv = t.Split(new string[] { KeyValueSeparator }, StringSplitOptions.None);
                    // Wenn es mehr oder weniger als 2 Einträge in dieser Zeile sind, dann ist der Eintrag ungültig formatiert worden 
                    // order es handelt sich um eine Sektion, e.g. "[Section-Name]"
                    if (kv.Length == 2)
                    {
                        _s.Add(kv[0].Trim(), kv[1].Trim());
                    }
                }
            }
            return _s;
        }
    }
}
