using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class EngineOptions : ThinEngineOptions
        {
            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? PreserveDrawingBuffer { get; set; } = null;

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? Stencil { get; set; } = null;

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? AutoEnableWebVR { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? DisableWebGL2Support { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? UseHighPrecisionFloats { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? XrCompatible { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? FailIfMajorPerformanceCaveat { get; set; }

            [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
            public bool? ForceSRGBBufferSupportState { get; set; }
        }
    }


}
