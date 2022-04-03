using Microsoft.AspNetCore.Components.Forms;

namespace BlazorBasic.Pages;

public partial class Index
{
    public string errmsg = string.Empty;
    private List<IBrowserFile> files = new ();

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public void LoadFiles(InputFileChangeEventArgs ea)
    {
        foreach (var file in ea.GetMultipleFiles())
        {
            try
            {
                files.Add(file);
                errmsg= file.Name;
            }
            catch (System.Exception ex)
            {
                errmsg = ex.Message;
            }
        }
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}