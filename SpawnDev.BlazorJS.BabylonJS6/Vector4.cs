using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class Vector4 : JSObject
        {
            public Vector4(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Vector4(double x, double y, double z, double w) : base(JS.New("BABYLON.Vector4", x, y, z, w)) { }
            public Vector4() : base(JS.New("BABYLON.Vector4")) { }
            public static Vector4 Zero() => JS.Call<Vector4>("BABYLON.Vector4.Zero");
            public double X { get => JSRef.Get<double>("x"); set => JSRef.Set("x", value); }
            public double Y { get => JSRef.Get<double>("y"); set => JSRef.Set("y", value); }
            public double Z { get => JSRef.Get<double>("z"); set => JSRef.Set("z", value); }
            public double W { get => JSRef.Get<double>("w"); set => JSRef.Set("w", value); }
        }
    }
}
