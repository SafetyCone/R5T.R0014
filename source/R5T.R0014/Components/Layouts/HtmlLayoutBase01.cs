using System;

using Microsoft.AspNetCore.Components;

using R5T.T0154;


namespace R5T.R0014.Layouts
{
    /// <summary>
    /// Base class for HTML layouts that defines head and body render fragments.
    /// </summary>
    [RazorComponentMarker]
    public class HtmlLayoutBase01 : ComponentBase
    {
        /// <summary>
        /// The head content for the layout.
        /// </summary>
        [Parameter]
        public RenderFragment Head { get; set; }

        /// <summary>
        /// Body content for the layout.
        /// </summary>
        [Parameter]
        public RenderFragment Body { get; set; }
    }
}
