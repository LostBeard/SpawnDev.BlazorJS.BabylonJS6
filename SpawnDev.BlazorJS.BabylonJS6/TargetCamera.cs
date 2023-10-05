using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        // https://doc.babylonjs.com/typedoc/classes/BABYLON.TargetCamera
        public partial class TargetCamera : Camera
        {
            public TargetCamera(IJSInProcessObjectReference _ref) : base(_ref) { }
            public void SetTarget(Vector3 target) => JSRef.CallVoid("setTarget", target);
            public Vector3 Target { get => JSRef.Get<Vector3>("target"); set => JSRef.Set("target", value); }
        }
    }
}
