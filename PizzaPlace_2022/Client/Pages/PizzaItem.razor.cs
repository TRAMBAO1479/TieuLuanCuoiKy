using Microsoft.AspNetCore.Components;
using PizzaPlace_2022.Shared;

namespace PizzaPlace_2022.Client.Pages {
    partial class PizzaItem {
        [Parameter]
        public Pizza Pizza { get; set; } = default!;
        [Parameter]
        public string ButtonTitle { get; set; } = default!;
        [Parameter]
        public string ButtonClass { get; set; } = default!;
        [Parameter]
        public EventCallback<Pizza> Selected { get; set; }
        private string SpicinessImage(Spiciness spiciness)
        => $"images/{spiciness.ToString().ToLower()}.png";
    }
}
