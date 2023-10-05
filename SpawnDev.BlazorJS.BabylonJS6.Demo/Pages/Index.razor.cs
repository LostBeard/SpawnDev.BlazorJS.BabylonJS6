using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS.JSObjects;

namespace SpawnDev.BlazorJS.BabylonJS6.Demo.Pages
{
    // Based on the BabylonJS example at the link below
    // https://doc.babylonjs.com/setup/starterHTML
    public partial class Index : IDisposable
    {
        [Inject]
        BabylonJS6Loader BabylonJS6Loader { get; set; }

        [Inject]
        Window window { get; set; }

        ElementReference canvas;
        BABYLON.Engine? engine;
        BABYLON.Scene? scene;
        ActionCallback? RenderLoopCallback;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("FirstRender");
                await BabylonJS6Loader.ImportCore();
                await BabylonJS6Loader.ImportGUI();
                engine = new BABYLON.Engine(canvas, true);
                scene = CreateScene();
                RenderLoopCallback = new ActionCallback(Engine_RenderLoop);
                engine.RunRenderLoop(RenderLoopCallback);
                window.OnResize += Window_OnResize;
            }
        }

        void Window_OnResize(UIEvent uiEvent)
        {
            engine?.Resize();
        }

        void Engine_RenderLoop()
        {
            scene?.Render();
        }

        BABYLON.Scene CreateScene()
        {
            // Creates a basic Babylon Scene object
            var scene = new BABYLON.Scene(engine);
            // Creates and positions a free camera
            var camera = new BABYLON.FreeCamera("camera1", new BABYLON.Vector3(0, 5, -10), scene);
            // Targets the camera to scene origin
            camera.SetTarget(BABYLON.Vector3.Zero());
            // This attaches the camera to the canvas
            camera.AttachControl(canvas, true);
            // Creates a light, aiming 0,1,0 - to the sky
            var light = new BABYLON.HemisphericLight("light", new BABYLON.Vector3(0, 1, 0), scene);
            // Dim the light a small amount - 0 to 1
            light.Intensity = 0.7;
            // Built-in 'sphere' shape.
            var sphere = BABYLON.MeshBuilder.CreateSphere("sphere", new BABYLON.MeshBuilder.CreateSphereOptions { Diameter = 2, Segments = 32 }, scene);
            // Move the sphere upward 1/2 its height
            sphere.Position.Y = 1;
            // Built-in 'ground' shape.
            var ground = BABYLON.MeshBuilder.CreateGround("ground", new BABYLON.MeshBuilder.CreateGroundOptions { Width = 6, Height = 6 }, scene);
            return scene;
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose");
            if (engine != null)
            {
                window.OnResize -= Window_OnResize;
                scene?.JSDispose();
                engine.JSDispose();
                RenderLoopCallback?.Dispose();
            }
        }
    }
}
