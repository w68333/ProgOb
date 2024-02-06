using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ResourceRepository
{
    private readonly List<Resource> _resources = new List<Resource>();

    public void AddResource(Resource resource)
    {
        _resources.Add(resource);
    }

    public IEnumerable<Resource> GetAllResources()
    {
        return _resources;
    }

    public Resource GetResourceById(int id)
    {
        return _resources.FirstOrDefault(r => r.Id == id);
    }

    public void UpdateResource(int id, Resource updatedResource)
    {
        var resource = GetResourceById(id);
        if (resource != null)
        {
            resource.Name = updatedResource.Name;
        }
    }

    public void DeleteResource(int id)
    {
        var resource = GetResourceById(id);
        if (resource != null)
        {
            _resources.Remove(resource);
        }
    }
}
