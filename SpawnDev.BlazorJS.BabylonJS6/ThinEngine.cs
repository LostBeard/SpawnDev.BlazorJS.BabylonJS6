using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class ThinEngine : JSDisposable
        {
            /// <summary>
            /// Returns the current npm package of the sdk
            /// </summary>
            public static string NpmPackage => JS.Get<string>("ThinEngine.NpmPackage");
            /// <summary>
            /// Returns the current version of the framework
            /// </summary>
            public static string Version => JS.Get<string>("ThinEngine.Version");
            /// <summary>
            /// Returns a string describing the current engine
            /// </summary>
            public string Description => JSRef.Get<string>("description");
            /// <summary>
            /// Gets or sets the name of the engine
            /// </summary>
            public string Name { get => JSRef.Get<string>("name"); set => JSRef.Set("name", value); }
            /// <summary>
            /// Returns the version of the engine 
            /// </summary>
            public string WebGLVersion => JS.Get<string>("version");
            public bool IsDisposed => JS.Get<bool>("isDisposed");

            public static string ShadersRepository { get => JS.Get<string>("ShadersRepository"); set => JS.Set("name", value); }

            public ThinEngine(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
