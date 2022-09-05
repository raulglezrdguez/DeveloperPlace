using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace DeveloperPlace.Client.Shared
{
    public class InputWatcher : ComponentBase
    {
        private EditContext editContext = default!;

        [CascadingParameter]
        public EditContext EditContext
        {
            get => editContext;
            set
            {
                editContext = value;
                EditContext.OnFieldChanged += async (sender, e) =>
                {
                    await FieldChanged.InvokeAsync(e.FieldIdentifier.FieldName);
                };
            }
        }

        [Parameter]
        public EventCallback<string> FieldChanged { get; set; } = default!;

        public bool Validate() => EditContext.Validate();
    }
}