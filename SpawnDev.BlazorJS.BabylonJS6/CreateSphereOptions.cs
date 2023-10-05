using System.Text.Json.Serialization;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public static partial class MeshBuilder
        {
            public class CreateSphereOptions
            {
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Arc { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public Vector4? BackUVs { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Diameter { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? DiameterX { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? DiameterY { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? DiameterZ { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public Vector4? FrontUVs { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Segments { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? SideOrientation { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public double? Slice { get; set; } = null;
                [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
                public bool? Updatable { get; set; } = null;

            }
        }
    }
}
