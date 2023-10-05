using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class TransformNode : Node
        {
            public static implicit operator Vector3(TransformNode node) => node.Position;
            public TransformNode(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Vector3 Position { get => JSRef.Get<Vector3>("position"); set => JSRef.Set("position", value); }
            public Vector3 Scaling { get => JSRef.Get<Vector3>("scaling"); set => JSRef.Set("scaling", value); }
        }
    }
}
