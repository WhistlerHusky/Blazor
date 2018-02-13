using Microsoft.AspNetCore.Blazor.Browser.Rendering;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.RenderTree;
using System;

namespace WebApplication.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            new BrowserRenderer().AddComponent<MyComponent>("app");
        }
    }

    public class MyComponent : IComponent
    {
        public void Init(RenderHandle renderHandle)
        {
        }

        public void SetParameters(ParameterCollection parameters)
        {
        }

        public void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddText(1, "Hello2 from RenderTree");
            builder.CloseElement();

            builder.OpenElement(2, "ul");

            builder.OpenElement(3, "li");
            builder.AddText(4, "First2 item");
            builder.CloseElement();

            builder.OpenElement(5, "li");
            builder.AddText(6, "Second2 item");
            builder.CloseElement();

            builder.CloseElement();
        }
    }
}
