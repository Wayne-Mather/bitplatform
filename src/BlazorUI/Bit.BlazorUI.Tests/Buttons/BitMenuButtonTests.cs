﻿using System.Collections.Generic;
using System.Linq;
using Bunit;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bit.BlazorUI.Tests.Buttons;

[TestClass]
public class BitMenuButtonTests : BunitTestContext
{
    private readonly List<BitMenuButtonItem> items = new()
    {
        new BitMenuButtonItem()
        {
            Text = "Item A",
            Key = "A"
        },
        new BitMenuButtonItem()
        {
            Text = "Item B",
            Key = "B"
        }
    };

    [DataTestMethod,
       DataRow(true, BitButtonStyle.Primary),
       DataRow(true, BitButtonStyle.Standard),
       DataRow(false, BitButtonStyle.Primary),
       DataRow(false, BitButtonStyle.Standard)
    ]
    public void BitMenuButtonTest(bool isEnabled, BitButtonStyle buttonStyle)
    {
        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.IsEnabled, isEnabled);
            parameters.Add(p => p.ButtonStyle, buttonStyle);
            parameters.Add(p => p.Items, items);
        });

        var bitMenuButton = com.Find(".bit-mnb");

        if (isEnabled)
        {
            Assert.IsFalse(bitMenuButton.ClassList.Contains("bit-dis"));
        }
        else
        {
            Assert.IsTrue(bitMenuButton.ClassList.Contains("bit-dis"));
        }

        if (buttonStyle == BitButtonStyle.Standard)
        {
            Assert.IsFalse(bitMenuButton.ClassList.Contains("bit-mnb-pri"));
            Assert.IsTrue(bitMenuButton.ClassList.Contains("bit-mnb-std"));
        }
        else
        {
            Assert.IsTrue(bitMenuButton.ClassList.Contains("bit-mnb-pri"));
            Assert.IsFalse(bitMenuButton.ClassList.Contains("bit-mnb-std"));
        }
    }

    [DataTestMethod,
        DataRow("A", "Add"),
        DataRow("B", "Edit")
    ]
    public void BitMenuButtonShouldHaveTextAndIcon(string text, string iconName)
    {
        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, items);
            parameters.Add(p => p.Text, text);
            parameters.Add(p => p.IconName, iconName);
        });

        var iconNameClass = $"bit-icon--{iconName}";

        var menuButtonIcon = com.Find(".bit-mnb .bit-icon");

        var menuButtonText = com.Find(".bit-mnb .bit-mnb-btx");

        Assert.IsTrue(menuButtonIcon.ClassList.Contains(iconNameClass));

        Assert.AreEqual(text, menuButtonText.TextContent);
    }

    [DataTestMethod,
        DataRow("A", "Add"),
        DataRow("B", "Edit")
    ]
    public void BitMenuButtonShouldHaveTextAndIconInItem(string itemText, string itemIconName)
    {
        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, new List<BitMenuButtonItem>()
            {
                new BitMenuButtonItem()
                {
                    Text = itemText,
                    IconName = itemIconName
                }
            });
        });

        var itemIconNameClass = $"bit-icon--{itemIconName}";
        var menuButtonItemText = com.Find(".bit-mnb-itm .bit-mnb-btx");
        var menuButtonItemIcon = com.Find(".bit-mnb-itm .bit-icon");

        Assert.AreEqual(itemText, menuButtonItemText.TextContent);
        Assert.IsTrue(menuButtonItemIcon.ClassList.Contains(itemIconNameClass));
    }

    [DataTestMethod,
        DataRow(true),
        DataRow(false)
    ]
    public void BitMenuButtonShouldBeItemClickIfEnabled(bool itemIsEnabled)
    {
        BitMenuButtonItem clickedItem = default!;

        items.Last().IsEnabled = itemIsEnabled;

        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, items);
            parameters.Add(p => p.OnClick, (item) => clickedItem = item);
        });

        var lastItem = com.Find("li:last-child .bit-mnb-itm");
        lastItem.Click();

        Assert.AreEqual(itemIsEnabled, lastItem.ClassList.Contains("bit-dis") is false);

        if (itemIsEnabled)
        {
            Assert.AreEqual(clickedItem, items.Last());
        }
        else
        {
            Assert.IsNull(clickedItem);
        }
    }

    [DataTestMethod,
        DataRow(true),
        DataRow(false)
    ]
    public void BitMenuButtonOpenMenu(bool isEnabled)
    {
        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, items);
            parameters.Add(p => p.IsEnabled, isEnabled);
        });

        var bitMenuButton = com.Find(".bit-mnb");
        var operatorButton = com.Find(".bit-mnb-opb");
        Assert.IsFalse(bitMenuButton.ClassList.Contains("bit-mnb-omn"));
        operatorButton.Click();

        if (isEnabled)
        {
            Assert.IsTrue(bitMenuButton.ClassList.Contains("bit-mnb-omn"));
        }
        else
        {
            Assert.IsFalse(bitMenuButton.ClassList.Contains("bit-mnb-omn"));
        }
    }

    [DataTestMethod,
        DataRow(true),
        DataRow(false)
    ]
    public void BitMenuButtonStickyTest(bool isSticky)
    {
        BitMenuButtonItem clickedItem = default!;

        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, items);
            parameters.Add(p => p.Sticky, isSticky);
            parameters.Add(p => p.OnClick, (item) => clickedItem = item);
        });

        var lastItem = com.Find("li:last-child .bit-mnb-itm");
        lastItem.Click();

        var operatorButton = com.Find(".bit-mnb-opb");
        operatorButton.Click();

        if (isSticky)
        {
            Assert.AreEqual(clickedItem, items.Last());
        }
        else
        {
            Assert.IsNull(clickedItem);
        }
    }

    [DataTestMethod,
        DataRow(true)
    ]
    public void BitMenuButtonSplitTest(bool isSplit)
    {
        var com = RenderComponent<BitMenuButton<BitMenuButtonItem>>(parameters =>
        {
            parameters.Add(p => p.Items, items);
            parameters.Add(p => p.Split, isSplit);
        });

        var seperator = com.Find(".bit-mnb > .bit-mnb-spb");
        var chevronDownButton = com.Find(".bit-mnb > .bit-mnb-chb");

        if (isSplit)
        {
            Assert.IsNotNull(seperator);
            Assert.IsNotNull(chevronDownButton);
        }
    }
}
