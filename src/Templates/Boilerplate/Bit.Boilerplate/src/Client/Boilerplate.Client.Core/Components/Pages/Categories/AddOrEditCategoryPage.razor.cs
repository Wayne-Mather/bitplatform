﻿using Boilerplate.Shared.Dtos.Categories;

namespace Boilerplate.Client.Core.Components.Pages.Categories;

[Authorize]
public partial class AddOrEditCategoryPage
{
    [Parameter] public int? Id { get; set; }

    private bool isLoading;
    private bool isSaving;
    private string? saveMessage;
    private bool isColorPickerOpen;
    private BitMessageBarType saveMessageType;
    private CategoryDto category = new();

    protected override async Task OnInitAsync()
    {
        await LoadCategory();
    }

    private async Task LoadCategory()
    {
        if (Id is null) return;

        isLoading = true;

        try
        {
            category = await HttpClient.GetFromJsonAsync($"Category/Get/{Id}", AppJsonContext.Default.CategoryDto, CurrentCancellationToken) ?? new();
        }
        finally
        {
            isLoading = false;
        }
    }

    private void SetCategoryColor(string color)
    {
        category.Color = color;
    }

    private void ToggleColorPicker()
    {
        isColorPickerOpen = !isColorPickerOpen;
    }

    private async Task Save()
    {
        if (isSaving) return;

        isSaving = true;

        try
        {
            if (category.Id == 0)
            {
                await HttpClient.PostAsJsonAsync("Category/Create", category, AppJsonContext.Default.CategoryDto, CurrentCancellationToken);
            }
            else
            {
                await HttpClient.PutAsJsonAsync("Category/Update", category, AppJsonContext.Default.CategoryDto, CurrentCancellationToken);
            }

            NavigationManager.NavigateTo("categories");
        }
        catch (ResourceValidationException e)
        {
            saveMessageType = BitMessageBarType.Error;

            saveMessage = string.Join(Environment.NewLine, e.Payload.Details.SelectMany(d => d.Errors).Select(e => e.Message));
        }
        catch (KnownException e)
        {
            saveMessage = e.Message;
            saveMessageType = BitMessageBarType.Error;
        }
        finally
        {
            isSaving = false;
        }
    }
}
