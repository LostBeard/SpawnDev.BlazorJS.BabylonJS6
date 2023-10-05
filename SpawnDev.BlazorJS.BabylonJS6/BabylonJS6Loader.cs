namespace SpawnDev.BlazorJS.BabylonJS6
{
    public class BabylonJS6Loader
    {
        BlazorJSRuntime JS;
        public BabylonJS6Loader(BlazorJSRuntime js)
        {
            JS = js;
        }
        public async Task ImportCore()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.js", "BABYLON");
        }
        public async Task ImportGUI()
        {
            await JS.LoadScript("_content/SpawnDev.BlazorJS.BabylonJS6/babylon.gui.min.js", "BABYLON.GUI");
        }
    }
}
