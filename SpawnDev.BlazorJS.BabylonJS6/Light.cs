using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class Light : Node
        {
            public Light(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
