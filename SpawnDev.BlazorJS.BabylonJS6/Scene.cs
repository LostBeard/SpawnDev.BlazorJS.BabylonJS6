﻿using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public partial class Scene : AbstractScene, IJSDisposable
        {
            public Scene(IJSInProcessObjectReference _ref) : base(_ref) { }
            public Scene(Engine engine) : base(JS.New("BABYLON.Scene", engine)) { }
            public void Render() => JSRef.CallVoid("render");
            public void RegisterBeforeRender(Callback callback) => JSRef.CallVoid("registerBeforeRender", callback);
            public virtual void JSDispose(bool disposeJSRef = true)
            {
                if (IsWrapperDisposed) return;
                JSRef!.CallVoid("dispose");
                if (disposeJSRef) Dispose();
            }
        }
    }
}
