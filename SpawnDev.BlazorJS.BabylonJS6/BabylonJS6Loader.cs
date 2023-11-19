namespace SpawnDev.BlazorJS.BabylonJS6
{
    public class BabylonJS6Loader
    {
        BlazorJSRuntime JS;
        public BabylonJS6Loader(BlazorJSRuntime js)
        {
            JS = js;
        }

        public async Task Import()
        {
            await ImportCore();
            await ImportGUI();
            await ImportLoaders();
            await ImportInspector();
            await ImportMaterials();
            await ImportPostProcess();
            await ImportProceduralTextures();
            await ImportSerializers();
            await ImportViewer();
        }

        public async Task ImportCore()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.js", "BABYLON");
        }
        public async Task ImportGUI()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.gui.min.js", "BABYLON.GUI");
        }
        public async Task ImportInspector()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.inspector.bundle.js");
        }
        public async Task ImportViewer()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.viewer.js");
        }
        public async Task ImportLoaders()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.loaders.min.js");
        }
        public async Task ImportMaterials()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.materials.min.js");
        }
        public async Task ImportPostProcess()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.postProcess.min.js");
        }
        public async Task ImportProceduralTextures()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.proceduralTextures.min.js");
        }
        public async Task ImportSerializers()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.serializers.min.js");
        }
    }
}
