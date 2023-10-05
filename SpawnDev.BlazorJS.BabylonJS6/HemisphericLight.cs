using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {

        // https://doc.babylonjs.com/typedoc/classes/BABYLON.HemisphericLight
        public class HemisphericLight : Light
        {
            public HemisphericLight(IJSInProcessObjectReference _ref) : base(_ref) { }
            public HemisphericLight(string name, Vector3 position, Scene scene) : base(JS.New("BABYLON.HemisphericLight", name, position, scene)) { }
            public HemisphericLight(string name, Vector3 position) : base(JS.New("BABYLON.HemisphericLight", name, position)) { }
            public double Intensity { get => JSRef.Get<double>("intensity"); set => JSRef.Set("intensity", value); }
        }
    }
}
