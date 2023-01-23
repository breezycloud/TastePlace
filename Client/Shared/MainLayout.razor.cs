using TastePlace.Shared.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using TastePlace.Client.AppTheme;

namespace TastePlace.Client.Shared;

public partial class MainLayout : LayoutComponentBase, IDisposable
{
    
    [CascadingParameter] private Task<AuthenticationState> AuthenticationStateTask { get; set; } = default!;

    protected override void OnInitialized()
    {        
        LayoutService?.SetBaseTheme(Theme.DocsTheme());
        LayoutService!.MajorUpdateOccured += LayoutServiceOnMajorUpdateOccured!;
        base.OnInitialized();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);

        if (firstRender)
        {
            //await LayoutService!.ApplyUserPreferences();
            StateHasChanged();
        }
    }
   
    public void Dispose()
    {
        LayoutService!.MajorUpdateOccured -= LayoutServiceOnMajorUpdateOccured!;
    }

    private void LayoutServiceOnMajorUpdateOccured(object sender, EventArgs e) => StateHasChanged();
}
