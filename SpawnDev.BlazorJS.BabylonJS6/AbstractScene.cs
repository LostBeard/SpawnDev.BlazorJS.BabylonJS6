using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class AbstractScene : JSObject
        {
            public AbstractScene(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Array<AbstractMesh> Meshes => JSRef.Get<Array<AbstractMesh>>("meshes");
        }
    }
}
