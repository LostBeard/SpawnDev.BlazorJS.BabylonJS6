namespace SpawnDev.BlazorJS.BabylonJS6
{
    public class BabylonJS6Loader
    {
        static BlazorJSRuntime JS;
        public BabylonJS6Loader(BlazorJSRuntime js)
        {
            JS = js;
        }

        private Task? _Import = null;
        public Task Import
        {
            get
            {
                if (_Import == null)
                {
                    _Import = Task.Run(async () =>
                    {
                        await ImportCore;
                        await ImportGUI;
                        await ImportLoaders;
                        await ImportInspector;
                        await ImportMaterials;
                        await ImportPostProcess;
                        await ImportProceduralTextures;
                        await ImportSerializers;
                        await ImportViewer;
                    });
                }
                return _Import;
            }
        }

        private Lazy<Task> _ImportCore = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.js"));
        public Task ImportCore => _ImportCore.Value;
        private Lazy<Task> _ImportGUI = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.gui.min.js"));
        public Task ImportGUI => _ImportGUI.Value;
        private Lazy<Task> _ImportInspector = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.inspector.bundle.js"));
        public Task ImportInspector => _ImportInspector.Value;
        private Lazy<Task> _ImportViewer = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.viewer.js"));
        public Task ImportViewer => _ImportViewer.Value;
        private Lazy<Task> _ImportLoaders = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.loaders.min.js"));
        public Task ImportLoaders => _ImportLoaders.Value;
        private Lazy<Task> _ImportMaterials = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.materials.min.js"));
        public Task ImportMaterials => _ImportMaterials.Value;
        private Lazy<Task> _ImportPostProcess = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.postProcess.min.js"));
        public Task ImportPostProcess => _ImportPostProcess.Value;
        private Lazy<Task> _ImportProceduralTextures = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.proceduralTextures.min.js"));
        public Task ImportProceduralTextures => _ImportProceduralTextures.Value;
        private Lazy<Task> _ImportSerializers = new Lazy<Task>(() => JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylonjs.serializers.min.js"));
        public Task ImportSerializers => _ImportSerializers.Value;
    }
}
