using Microsoft.JSInterop;
using SpawnDev.BlazorJS.JSObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = SpawnDev.BlazorJS.JSObjects.File;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public static class SceneLoader
        {
            public class SceneLoaderProgressEvent
            {
                /// <summary>
                /// Defines if data length to load can be evaluated
                /// </summary>
                public bool LengthComputable { get; }
                /// <summary>
                /// Defines the loaded data length
                /// </summary>
                public long Loaded { get; }
                /// <summary>
                /// Defines the data length to load
                /// </summary>
                public long Total { get; }
            }
            public static void ImportMesh(
                Union<string, IEnumerable<string>> meshNames, 
                string rootUrl, 
                Union<string, TypedArray, File>? sceneFilename = null, 
                Scene? scene = null,
                ActionCallback<Array<AbstractMesh>, Array<BaseParticleSystem>, Array<Skeleton>, Array<AnimationGroup>, Array<TransformNode>, Array<Geometry>, Array<Light>>? onSuccess = null,
                ActionCallback<SceneLoaderProgressEvent>? onProgress = null,
                ActionCallback<Scene, string, JSObject?>? onError = null,
                string? pluginExtension = null
                ) 
                => JS.CallVoid("BABYLON.SceneLoader.ImportMesh", meshNames, rootUrl, sceneFilename, scene, onSuccess, onProgress, onError, pluginExtension);
        }
    }
}
