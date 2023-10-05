using Microsoft.AspNetCore.Components;
using SpawnDev.BlazorJS.JSObjects;
using static SpawnDev.BlazorJS.BabylonJS6.BABYLON;
using File = SpawnDev.BlazorJS.JSObjects.File;

namespace SpawnDev.BlazorJS.BabylonJS6.Demo.Pages
{
    // Based on the BabylonJS example at the link below
    // https://doc.babylonjs.com/setup/starterHTML
    public partial class Index : IDisposable
    {
        [Inject]
        BlazorJSRuntime JS { get; set; }

        [Inject]
        HttpClient HttpClient { get; set; }

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
                await BabylonJS6Loader.ImportLoaders();
                await BabylonJS6Loader.ImportMaterials();
                engine = new BABYLON.Engine(canvas, true);
                //scene = CreateScene();
                scene = await CreateMeshScene();
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

        async Task<BABYLON.Scene> CreateMeshScene()
        {
            // Creates a basic Babylon Scene object
            var scene = new BABYLON.Scene(engine);
            // Creates and positions a free camera
            var camera = new BABYLON.FreeCamera("camera1", new BABYLON.Vector3(1000, 1000, 1000), scene);
            // Targets the camera to scene origin
            camera.SetTarget(BABYLON.Vector3.Zero());
            // This attaches the camera to the canvas
            camera.AttachControl(canvas, true);
            // Creates a light, aiming 0,1,0 - to the sky
            var light = new BABYLON.HemisphericLight("light", new BABYLON.Vector3(0, 1, 0), scene);
            // Dim the light a small amount - 0 to 1
            light.Intensity = 0.7;
            // load .obj
            // https://free3d.com/3d-model/office-filing-cabinet-341696.html
            var objBytes = await HttpClient.GetByteArrayAsync("assets/filing_cabinet.obj");
            var val = await JS.Fetch("/assets/filing_cabinet.obj");
            var blob = await val.Blob();
            var file = new File([blob], "filing_cabinet.obj");
            BABYLON.SceneLoader.ImportMesh("", "", file, scene, Callback.CreateOne<Array<AbstractMesh>, Array<BaseParticleSystem>, Array<Skeleton>, Array<AnimationGroup>, Array<TransformNode>, Array<Geometry>, Array<Light>>((meshes, particaleSystems, skeletons, animationGroups, transformNodes, geometries, lights) =>
            {
                // Set the target of the camera to the first imported mesh
                camera.Target = meshes[0].Position;
                meshes.Map(m => m.Scaling = new Vector3(0.2));
            }));
            return scene;
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
