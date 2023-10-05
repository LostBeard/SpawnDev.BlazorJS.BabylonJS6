using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class Mesh : JSDisposable
        {
            public Mesh(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Vector4 Position => JSRef.Get<Vector4>("position");
        }
    }
}
