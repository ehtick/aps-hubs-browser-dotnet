using System.Collections.Generic;
using System.Threading.Tasks;
using Autodesk.DataManagement;
using Autodesk.DataManagement.Model;

public partial class APS
{
    public async Task<IEnumerable<HubData>> GetHubs(Tokens tokens)
    {
        var dataManagementClient = new DataManagementClient();
        var hubs = await dataManagementClient.GetHubsAsync(accessToken: tokens.InternalToken);
        return hubs.Data;
    }

    public async Task<IEnumerable<ProjectData>> GetProjects(string hubId, Tokens tokens)
    {
        var dataManagementClient = new DataManagementClient();
        var projects = await dataManagementClient.GetHubProjectsAsync(hubId, accessToken: tokens.InternalToken);
        return projects.Data;
    }

    public async Task<IEnumerable<TopFolderData>> GetTopFolders(string hubId, string projectId, Tokens tokens)
    {
        var dataManagementClient = new DataManagementClient();
        var folders = await dataManagementClient.GetProjectTopFoldersAsync(hubId, projectId, accessToken: tokens.InternalToken);
        return folders.Data;
    }

    public async Task<IEnumerable<IFolderContentsData>> GetFolderContents(string projectId, string folderId, Tokens tokens)
    {
        var dataManagementClient = new DataManagementClient();
        var contents = await dataManagementClient.GetFolderContentsAsync(projectId, folderId, accessToken: tokens.InternalToken);
        return contents.Data;
    }

    public async Task<IEnumerable<VersionData>> GetVersions(string projectId, string itemId, Tokens tokens)
    {
        var dataManagementClient = new DataManagementClient();
        var versions = await dataManagementClient.GetItemVersionsAsync(projectId, itemId, accessToken: tokens.InternalToken);
        return versions.Data;
    }
}
