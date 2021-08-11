// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LifeBackupUI.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using LifeBackupUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\_Imports.razor"
using LifeBackupUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\Pages\Index.razor"
using LifeBackup.Core.Communication.Bucket;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "D:\Demoes\Dot uisng S3\LifeBackup\LifeBackupUI\Pages\Index.razor"
      
    List<ListS3BucketResponse> listS3Buckets = new List<ListS3BucketResponse>();
    CreateBucketResponse S3CreateBucket = new CreateBucketResponse();

    //public class ListS3BucketResponse
    //{
    //    public string BucketName { get; set; }
    //    public DateTime CreationDate { get; set; }
    //}
    protected override async Task OnInitializedAsync()
    {
        listS3Buckets = await http.GetJsonAsync<List<ListS3BucketResponse>>("http://localhost:57423/api/bucket/list");
    }
    private async Task GetS3BucketList()
    {
        listS3Buckets = await http.GetJsonAsync<List<ListS3BucketResponse>>("http://localhost:57423/api/bucket/list");
    }
    private async Task SaveBucket()
    {

        using (var httpClient = new HttpClient())
        {
            var content = new StringContent(S3CreateBucket.BucketName);

            using (var response = await httpClient.PostAsync("http://localhost:57423/api/bucket?bucketName="+ S3CreateBucket.BucketName, content))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
                await GetS3BucketList();
            }
        }
    }
    private async Task DeleteBucket(string bucketName)
    {
        using (var httpClient = new HttpClient())
        {
            using (var response = await httpClient.DeleteAsync("http://localhost:57423/api/bucket/list?bucketName=" + bucketName))
            {
                string apiResponse = await response.Content.ReadAsStringAsync();
            }
        }
        await GetS3BucketList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
