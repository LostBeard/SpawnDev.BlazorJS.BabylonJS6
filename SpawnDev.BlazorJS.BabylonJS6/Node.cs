﻿using Microsoft.JSInterop;

namespace SpawnDev.BlazorJS.BabylonJS6
{
    public static partial class BABYLON
    {
        public class Node : JSDisposable
        {
            public Node(IJSInProcessObjectReference _ref) : base(_ref) { }
        }
    }
}
