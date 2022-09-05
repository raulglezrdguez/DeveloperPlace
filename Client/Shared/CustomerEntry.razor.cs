using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using DeveloperPlace.Shared;

namespace DeveloperPlace.Client.Shared
{
    public partial class CustomerEntry
    {
        [Parameter]
        public string Title { get; set; } = default!;

        [Parameter]
        public string ButtonTitle { get; set; } = default!;

        [Parameter]
        public string ButtonClass { get; set; } = default!;

        [Parameter]
        public Customer Customer { get; set; } = default!;

        [Parameter]
        public EventCallback ValidSubmit { get; set; } = default!;

        [Parameter]
        public EventCallback<Customer> CustomerChanged { get; set; } = default!;

        private void FieldChanged(string fieldName)
        {
            CustomerChanged.InvokeAsync(Customer);
            isInvalid = !inputWatcher?.Validate() ?? false;
        }

        private InputWatcher? inputWatcher = default!;

        private bool isInvalid = true;
    }
}