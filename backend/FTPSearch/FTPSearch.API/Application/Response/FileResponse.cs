namespace FTPSearch.API.Application.Response;

public record FileResponse(string Name,
    string Path,
    string Url);