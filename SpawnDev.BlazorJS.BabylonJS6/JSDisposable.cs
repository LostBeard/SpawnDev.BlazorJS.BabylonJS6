using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    // https://doc.babylonjs.com/typedoc/interfaces/BABYLON.IDisposable
    public class JSDisposable : JSObject
    {
        public JSDisposable(IJSInProcessObjectReference _ref) : base(_ref) { }
        /// <summary>
        /// Calls object.dispose()
        /// Not called Dispose to prevent conflict with JSObject.Dispose() which only releases the IJSInProcessObjectReference
        /// </summary>
        /// <param name="disposeJSRef">If true (default) Dispose will also be called to release the IJSInProcessObjectReference</param>
        public virtual void JSDispose(bool disposeJSRef = true)
        {
            if (IsWrapperDisposed) return;
            JSRef!.CallVoid("dispose");
            if (disposeJSRef) Dispose();
        }
    }
}
