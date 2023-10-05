using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class ThinEngineOptions { 

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public double? LimitDeviceRatio { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? AudioEngine { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public AudioEngineOptions? AudioEngineOptions { get; set; }

            public bool? DeterministicLockstep { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public double? LockstepMaxSteps { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public double? TimeStep { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? DoNotHandleContextLost { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? DoNotHandleTouchAction { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? UseHighPrecisionMatrix { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? AdaptToDeviceRatio { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? UseExactSrgbConversions { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? Antialias { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? PremultipliedAlpha { get; set; }
        }
    }


}
