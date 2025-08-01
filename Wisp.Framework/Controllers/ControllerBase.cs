// This file is part of Wisp Framework.
// 
// Licensed under either of
//   * Apache License, Version 2.0 (https://www.apache.org/licenses/LICENSE-2.0)
//   * MIT License (https://opensource.org/licenses/MIT)
// at your option.

using Wisp.Framework.Views;

namespace Wisp.Framework.Controllers;

/// <summary>
/// A collection of convenience features for MVC controllers
/// </summary>
public abstract class ControllerBase
{
    protected internal IView View(string templateName, object? model = null)
        => new TemplateView(templateName, model);

    protected internal IView Redirect(string url)
        => new TemplateView(new Uri(url));
}