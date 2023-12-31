﻿using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class Vector3 : JSObject
        {
            public Vector3(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Vector3(double x, double y, double z) : base(JS.New("BABYLON.Vector3", x, y, z)) { }
            public Vector3(double xyz) : base(JS.New("BABYLON.Vector3", xyz, xyz, xyz)) { }
            public Vector3() : base(JS.New("BABYLON.Vector3")) { }
            public static Vector3 Zero() => JS.Call<Vector3>("BABYLON.Vector3.Zero");
            public double X { get => JSRef.Get<double>("x"); set => JSRef.Set("x", value); }
            public double Y { get => JSRef.Get<double>("y"); set => JSRef.Set("y", value); }
            public double Z { get => JSRef.Get<double>("z"); set => JSRef.Set("z", value); }
            public Vector3 ScaleInPlace(double scale) => JSRef.Call<Vector3>("scaleInPlace", scale);
            public Vector3 Set(double x, double y, double z) => JSRef.Call<Vector3>("set", x, y, z);
            public Vector3 SetAll(double v) => JSRef.Call<Vector3>("setAll", v);
        }
    }
}
