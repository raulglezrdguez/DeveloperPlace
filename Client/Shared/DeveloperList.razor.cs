using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DeveloperPlace.Shared;

namespace DeveloperPlace.Client.Shared
{
    public partial class DeveloperList
    {
        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public IEnumerable<Developer> Items { get; set; } = default!;

        [Parameter]
        public string ButtonClass { get; set; } = default!;

        [Parameter]
        public string ButtonTitle { get; set; } = default!;

        [Parameter]
        public EventCallback<Developer> Selected { get; set; }
    }
}