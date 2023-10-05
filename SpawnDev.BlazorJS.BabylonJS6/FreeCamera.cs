using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {

        public class ArcRotateCamera : TargetCamera
        {
            public ArcRotateCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
            public ArcRotateCamera(string name, double alpha, double beta, double radius, Vector3 target) : base(JS.New("BABYLON.ArcRotateCamera", name, alpha, beta, radius, target)) { }
            public ArcRotateCamera(string name, double alpha, double beta, double radius, Vector3 target, Scene? scene) : base(JS.New("BABYLON.ArcRotateCamera", name, alpha, beta, radius, target, scene)) { }
            public ArcRotateCamera(string name, double alpha, double beta, double radius, Vector3 target, Scene? scene, bool setActiveOnSceneIfNoneActive) : base(JS.New("BABYLON.ArcRotateCamera", name, alpha, beta, radius, target, scene, setActiveOnSceneIfNoneActive)) { }

        }

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
