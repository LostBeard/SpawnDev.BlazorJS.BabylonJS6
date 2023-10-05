namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public static partial class MeshBuilder
        {
            static BlazorJSRuntime JS => BlazorJSRuntime.JS;

            // CreateSphere
            public static Mesh CreateSphere(string name) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateSphere", name);
            public static Mesh CreateSphere(string name, CreateSphereOptions options) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateSphere", name, options);
            public static Mesh CreateSphere(string name, CreateSphereOptions options, Scene scene) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateSphere", name, options, scene);

            // CreateGround
            public static Mesh CreateGround(string name) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateGround", name);
            public static Mesh CreateGround(string name, CreateGroundOptions options) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateGround", name, options);
            public static Mesh CreateGround(string name, CreateGroundOptions options, Scene scene) => JS.Call<Mesh>("BABYLON.MeshBuilder.CreateGround", name, options, scene);
        }
    }
}
