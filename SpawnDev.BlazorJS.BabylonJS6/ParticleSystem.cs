using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class ParticleSystem : BaseParticleSystem, IParticleSystem
        {
            public ParticleSystem(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
