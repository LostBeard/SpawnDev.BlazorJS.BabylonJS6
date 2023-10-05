using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public static partial class MeshBuilder
        {
            public class CreateGroundOptions
            {
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Height { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Subdivisions { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? SubdivisionsX { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? SubdivisionsY { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public bool? Updatable { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Width { get; set; } = null;

            }
        }
    }
}
