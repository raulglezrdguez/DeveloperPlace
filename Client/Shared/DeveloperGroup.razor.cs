using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DeveloperPlace.Shared;

namespace DeveloperPlace.Client.Shared
{
    public partial class DeveloperGroup
    {
        [Parameter]
        public IEnumerable<int> Members { get; set; } = default!;

        [Parameter]
        public EventCallback<int> Selected { get; set; } = default!;

        [Parameter]
        public Func<int, Developer> GetDeveloperFromId { get; set; } = default!;

        public IEnumerable<(Developer developer, int pos)> Developers { get; set; } = default!;

        private decimal TotalSalary { get; set; } = default!;

        protected override void OnParametersSet()
        {
            Developers = Members.Select((id, pos) => (developer: GetDeveloperFromId(id), pos: pos));
            TotalSalary = Developers.Sum(tuple => tuple.developer.Salary);
            // TotalSalary = Developers.Select(tuple => tuple.developer.Salary).Sum();
        }
    }
}