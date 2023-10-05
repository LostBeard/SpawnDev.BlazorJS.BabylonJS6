using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class PointLight : ShadowLight
        {
            public PointLight(IJSInProcessObjectReference _ref) : base(_ref) { }
            public PointLight(string name, Vector3 position, Scene scene) : base(JS.New("BABYLON.PointLight", name, position, scene)) { }
            public PointLight(string name, Vector3 position) : base(JS.New("BABYLON.PointLight", name, position)) { }
        }
    }
}
