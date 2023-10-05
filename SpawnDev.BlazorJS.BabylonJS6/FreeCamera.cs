using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        // https://doc.babylonjs.com/typedoc/classes/BABYLON.FreeCamera
        public partial class FreeCamera : TargetCamera
        {
            public FreeCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
            public FreeCamera(string name, Vector3 position, Scene scene, bool setActiveOnSceneIfNoneActive) : base(JS.New("BABYLON.FreeCamera", name, position, scene, setActiveOnSceneIfNoneActive)) { }
            public FreeCamera(string name, Vector3 position, Scene scene) : base(JS.New("BABYLON.FreeCamera", name, position, scene)) { }
            public FreeCamera(string name, Vector3 position) : base(JS.New("BABYLON.FreeCamera", name, position)) { }

        }
    }
}
