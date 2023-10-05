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
        }
    }
}
