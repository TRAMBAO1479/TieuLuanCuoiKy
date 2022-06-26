using Microsoft.AspNetCore.Components;
using PizzaPlace_2022.Shared;
using System.Collections.Generic;

namespace PizzaPlace_2022.Client.Pages {
    partial class PizzaList {
        [Parameter]
        public string Title { get; set; } = default!;
        [Parameter]
        public IEnumerable<Pizza> Items { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }
    }
}
