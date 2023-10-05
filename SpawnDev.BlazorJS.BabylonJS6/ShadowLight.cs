using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class ShadowLight : Light
        {
            public ShadowLight(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Vector3 Position { get => JSRef.Get<Vector3>("position"); set => JSRef.Set("position", value); }
        }
    }
}
