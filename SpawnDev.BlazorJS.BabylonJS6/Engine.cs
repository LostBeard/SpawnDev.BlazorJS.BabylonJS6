using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.BabylonJS6
{

    public static partial class BABYLON
    {
        public class Engine : ThinEngine
        {
            public Engine(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Engine(HTMLCanvasElement canvasOrContext, bool antialias, EngineOptions options, bool adaptToDeviceRatio = false) : base(JS.New("BABYLON.Engine", canvasOrContext, antialias, options, adaptToDeviceRatio)) { }
            public Engine(HTMLCanvasElement canvasOrContext, bool antialias = false) : base(JS.New("BABYLON.Engine", canvasOrContext, antialias)) { }
            public Engine(ElementReference canvasOrContext, bool antialias, EngineOptions options, bool adaptToDeviceRatio = false) : base(JS.New("BABYLON.Engine", canvasOrContext, antialias, options, adaptToDeviceRatio)) { }
            public Engine(ElementReference canvasOrContext, bool antialias = false) : base(JS.New("BABYLON.Engine", canvasOrContext, antialias)) { }

            public void RunRenderLoop(Callback callback) => JSRef.CallVoid("runRenderLoop", callback);
            public void Resize() => JSRef.CallVoid("resize");
        }
    }


}
