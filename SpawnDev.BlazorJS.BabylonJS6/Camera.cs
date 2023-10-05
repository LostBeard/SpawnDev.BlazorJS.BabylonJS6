using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class Camera : Node
        {
            public static int PERSPECTIVE_CAMERASearch = 0;
            public static int ORTHOGRAPHIC_CAMERA = 1;
            public Camera(IJSInProcessObjectReference _ref) : base(_ref) { }
            public int Mode { get => JSRef.Get<int>("mode"); set => JSRef.Set("mode", value); }
            public float OrthoTop { get => JSRef.Get<float>("orthoTop"); set => JSRef.Set("orthoTop", value); }
            public float OrthoBottom { get => JSRef.Get<float>("orthoBottom"); set => JSRef.Set("orthoBottom", value); }
            public float OrthoLeft { get => JSRef.Get<float>("orthoLeft"); set => JSRef.Set("orthoLeft", value); }
            public float OrthoRight { get => JSRef.Get<float>("orthoRight"); set => JSRef.Set("orthoRight", value); }
            public float MaxZ { get => JSRef.Get<float>("maxZ"); set => JSRef.Set("maxZ", value); }
            public float MinZ { get => JSRef.Get<float>("minZ"); set => JSRef.Set("minZ", value); }
            public void AttachControl(object? ignored, bool noPreventDefault) => JSRef.CallVoid("attachControl", ignored, noPreventDefault);
            public void AttachControl(bool noPreventDefault) => JSRef.CallVoid("attachControl", noPreventDefault);
            public Vector3 Position { get => JSRef.Get<Vector3>("position"); set => JSRef.Set("position", value); }
        }
    }
}
