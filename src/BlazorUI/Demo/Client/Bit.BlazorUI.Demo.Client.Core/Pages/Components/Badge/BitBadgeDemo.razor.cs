﻿namespace Bit.BlazorUI.Demo.Client.Core.Pages.Components.Badge;

public partial class BitBadgeDemo
{
    private readonly List<ComponentParameter> componentParameters = new()
    {
        new()
        {
            Name = "Appearance",
            Type = "BitAppearance",
            DefaultValue = "BitAppearance.Primary",
            Description = "The appearance of badge, Possible values: Primary | Standard | Text",
            LinkType = LinkType.Link,
            Href = "#badge-appearance-enum"
        },
        new()
        {
            Name = "ChildContent",
            Type = "RenderFragment?",
            DefaultValue = "null",
            Description = "Child content of component, the content that the badge will apply to."
        },
        new()
        {
            Name = "Classes",
            Type = "BitBadgeClassStyles?",
            DefaultValue = "null",
            Description = "Custom CSS classes for different parts of the BitBadge.",
            LinkType = LinkType.Link,
            Href = "#badge-class-styles"
        },
        new()
        {
            Name = "Color",
            Type = "BitBadgeColor?",
            DefaultValue = "null",
            Description = "The color of the badge.",
            LinkType = LinkType.Link,
            Href = "#badge-color-enum"
        },
        new()
        {
            Name = "Content",
            Type = "object?",
            DefaultValue = "null",
            Description = "Content you want inside the badge. Supported types are string and integer."
        },
        new()
        {
            Name = "Dot",
            Type = "bool",
            DefaultValue = "false",
            Description = "Reduces the size of the badge and hide any of its content."
        },
        new()
        {
            Name = "Hidden",
            Type = "bool",
            DefaultValue = "false",
            Description = "The visibility of the badge."
        },
        new()
        {
            Name = "IconName",
            Type = "string?",
            DefaultValue = "null",
            Description = "Sets the Icon to use in the badge."
        },
        new()
        {
            Name = "Max",
            Type = "int",
            DefaultValue = "99",
            Description = "Max value to display when content is integer type."
        },
        new()
        {
            Name = "OnClick",
            Type = "EventCallback<MouseEventArgs>",
            DefaultValue = "",
            Description = "Button click event if set."
        },
        new()
        {
            Name = "Overlap",
            Type = "bool",
            DefaultValue = "false",
            Description = "Overlaps the badge on top of the child content."
        },
        new()
        {
            Name = "Position",
            Type = "BitBadgePosition",
            DefaultValue = "BitBadgePosition.TopRight",
            Description = "The position of the badge.",
            LinkType = LinkType.Link,
            Href = "#badge-position-enum"
        },
        new()
        {
            Name = "Size",
            Type = "BitBadgeSize?",
            DefaultValue = "null",
            Description = "The size of badge, Possible values: Small | Medium | Large",
            LinkType = LinkType.Link,
            Href = "#badge-size-enum",
        },
        new()
        {
            Name = "Styles",
            Type = "BitBadgeClassStyles?",
            DefaultValue = "null",
            Description = "Custom CSS styles for different parts of the BitBadge.",
            LinkType = LinkType.Link,
            Href = "#badge-class-styles"
        }
    };

    private readonly List<ComponentSubEnum> componentSubEnums = new()
    {
        new()
        {
            Id = "badge-appearance-enum",
            Name = "BitAppearance",
            Description = "",
            Items = new List<ComponentEnumItem>()
            {
                new()
                {
                    Name= "Primary",
                    Description="The appearance for primary actions that are high-emphasis.",
                    Value="0",
                },
                new()
                {
                    Name= "Standard",
                    Description="The appearance for important actions that are medium-emphasis.",
                    Value="1",
                },
                new()
                {
                    Name= "Text",
                    Description="The appearance for less-pronounced actions.",
                    Value="2",
                }
            }
        },
        new()
        {
            Id = "badge-color-enum",
            Name = "BitBadgeColor",
            Description = "",
            Items = new List<ComponentEnumItem>()
            {
                new()
                {
                    Name= "Info",
                    Description="Info styled badge.",
                    Value="0",
                },
                new()
                {
                    Name= "Success",
                    Description="Success styled badge.",
                    Value="1",
                },
                new()
                {
                    Name= "Warning",
                    Description="Warning styled badge.",
                    Value="2",
                },
                new()
                {
                    Name= "SevereWarning",
                    Description="Severe Warning styled badge.",
                    Value="3",
                },
                new()
                {
                    Name= "Error",
                    Description="Error styled badge.",
                    Value="4",
                }
            }
        },
        new()
        {
            Id = "badge-size-enum",
            Name = "BitBadgeSize",
            Description = "",
            Items = new List<ComponentEnumItem>()
            {
                new()
                {
                    Name= "Small",
                    Description="The small size badge.",
                    Value="0",
                },
                new()
                {
                    Name= "Medium",
                    Description="The medium size badge.",
                    Value="1",
                },
                new()
                {
                    Name= "Large",
                    Description="The large size badge.",
                    Value="2",
                }
            }
        },
        new()
        {
            Id = "badge-position-enum",
            Name = "BitBadgePosition",
            Description = "",
            Items = new List<ComponentEnumItem>()
            {
                new()
                {
                    Name = "TopRight",
                    Value = "0"
                },
                new()
                {
                    Name = "TopCenter",
                    Value = "1"
                },
                new()
                {
                    Name = "TopLeft",
                    Value = "2"
                },
                new()
                {
                    Name = "CenterLeft",
                    Value = "3"
                },
                new()
                {
                    Name = "Center",
                    Value = "4"
                },
                new()
                {
                    Name = "CenterRight",
                    Value = "5"
                },
                new()
                {
                    Name = "BottomLeft",
                    Value = "6"
                },
                new()
                {
                    Name = "BottomCenter",
                    Value = "7"
                },
                new()
                {
                    Name = "BottomRight",
                    Value = "8"
                }
            }
        }
    };

    private readonly List<ComponentSubClass> componentSubClasses = new()
    {
        new()
        {
            Id = "badge-class-styles",
            Title = "BitBadgeClassStyles",
            Parameters = new()
            {
               new()
               {
                   Name = "Root",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Custom CSS classes/styles for the root element of the BitBadge."
               },
               new()
               {
                   Name = "BadgeWrapper",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Custom CSS classes/styles for the badge wrapper of the BitBadge."
               },
               new()
               {
                   Name = "Badge",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Custom CSS classes/styles for the badge of the BitBadge."
               },
               new()
               {
                   Name = "Icon",
                   Type = "string?",
                   DefaultValue = "null",
                   Description = "Custom CSS classes/styles for the icon of the BitBadge."
               },
            }
        }
    };



    private BitBadgePosition badgePosition;
    private List<BitDropdownItem<BitBadgePosition>> badgePositionList = Enum.GetValues(typeof(BitBadgePosition))
        .Cast<BitBadgePosition>()
        .Select(enumValue => new BitDropdownItem<BitBadgePosition>
        {
            Value = enumValue,
            Text = enumValue.ToString()
        })
        .ToList();

    private int counter;



    private readonly string example1RazorCode = @"
<BitBadge Content=""5"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""15"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""25"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example2RazorCode = @"
<BitBadge Content=""35"">
    <BitButton ButtonStyle=""BitButtonStyle.Standard"">Default</BitButton>
</BitBadge>
<BitBadge Content=""45"" IsEnabled=""false"">
    <BitButton ButtonStyle=""BitButtonStyle.Standard"">Disabled</BitButton>
</BitBadge>";

    private readonly string example3RazorCode = @"
<BitBadge Content=""55"" Appearance=""BitAppearance.Standard"">
    <BitButton>Default</BitButton>
</BitBadge>
<BitBadge Content=""65"" Appearance=""BitAppearance.Standard"" IsEnabled=""false"">
    <BitButton>Disabled</BitButton>
</BitBadge>";

    private readonly string example4RazorCode = @"
<BitBadge Content=""75"" Appearance=""BitAppearance.Text"">
    <BitButton>Default</BitButton>
</BitBadge>
<BitBadge Content=""85"" Appearance=""BitAppearance.Text"" IsEnabled=""false"">
    <BitButton>Disabled</BitButton>
</BitBadge>";

    private readonly string example5RazorCode = @"
<BitBadge Content=""7"" Overlap>
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example6RazorCode = @"
<BitBadge Dot>
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example7RazorCode = @"
<BitBadge Max=""50"" Content=""100"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example8RazorCode = @"
<BitBadge Content=""@(""Text"")"">
    <BitButton ButtonStyle=""BitButtonStyle.Standard"">String content</BitButton>
</BitBadge>

<BitBadge IconName=""Clock"">
    <BitButton ButtonStyle=""BitButtonStyle.Standard"">IconName</BitButton>
</BitBadge>";

    private readonly string example9RazorCode = @"
<BitBadge Hidden>
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example10RazorCode = @"
<BitBadge Content=""100"" Position=""badgePosition"">
    <BitButton ButtonStyle=""BitButtonStyle.Standard"">Position</BitButton>
</BitBadge>

<BitDropdown Items=""badgePositionList"" @bind-Value=""badgePosition"" />";
    private readonly string example10CsharpCode = @"
private BitBadgePosition badgePosition;

private List<BitDropdownItem<BitBadgePosition>> badgePositionList = Enum.GetValues(typeof(BitBadgePosition))
    .Cast<BitBadgePosition>()
    .Select(enumValue => new BitDropdownItem<BitBadgePosition>
    {
        Value = enumValue,
        Text = enumValue.ToString()
    })
    .ToList();";

    private readonly string example11RazorCode = @"
<BitBadge Content=""100"" Color=""BitBadgeColor.Info"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Info"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Info"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Color=""BitBadgeColor.Success"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Success"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Success"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Color=""BitBadgeColor.Warning"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Warning"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Warning"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Color=""BitBadgeColor.SevereWarning"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.SevereWarning"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.SevereWarning"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Color=""BitBadgeColor.Error"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Error"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Color=""BitBadgeColor.Error"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example12RazorCode = @"
<BitBadge Content=""100"" Size=""BitBadgeSize.Small"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Medium"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Large"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Size=""BitBadgeSize.Small"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Medium"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Large"" Appearance=""BitAppearance.Standard"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Size=""BitBadgeSize.Small"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Medium"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>
<BitBadge Content=""100"" Size=""BitBadgeSize.Large"" Appearance=""BitAppearance.Text"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example13RazorCode = @"
<style>
    .custom-class {
        border-radius: 1rem;
        box-shadow: aqua 0 0 0.5rem;
    }

    .custom-class div {
        padding: 0.5rem;
        color: blueviolet;
    }

    .custom-root {
        margin-left: 2rem;
        text-shadow: aqua 0 0 0.5rem;
    }

    .custom-wrapper {
        padding: 1.25rem;
    }

    .custom-badge {
        border-end-end-radius: 0.5rem;
        border-start-end-radius: unset;
        border-end-start-radius: unset;
        border-start-start-radius: 0.5rem;
    }

    .custom-icon {
        color: dodgerblue;
    }
</style>

<BitBadge Content=""100"" Style=""color: dodgerblue;"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" Class=""custom-class"" Appearance=""BitAppearance.Standard"">
    <div>Item 1</div>
    <div>Item 2</div>
    <div>Item 3</div>
</BitBadge>

<BitBadge Content=""100"" IconName=""Info""
          Styles=""@(new() { Root = ""color: tomato;"",
                            Badge = ""border-radius: unset;"",
                            Icon = ""color: tomato;"" })"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>

<BitBadge Content=""100"" IconName=""Info""
          Appearance=""BitAppearance.Standard""
          Classes=""@(new() { Root = ""custom-root"",
                             BadgeWrapper = ""custom-wrapper"",
                             Badge = ""custom-badge"",
                             Icon = ""custom-icon"" })"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";

    private readonly string example14RazorCode = @"
<BitBadge Content=""counter"" OnClick=""() => counter++"">
    <BitIcon IconName=""@BitIconName.Mail"" />
</BitBadge>";
    private readonly string example14CsharpCode = @"
private int counter;";

}
