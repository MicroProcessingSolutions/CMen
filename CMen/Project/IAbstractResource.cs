namespace CMen.Project
{
    public interface IAbstractResource
    {
        CMenAbstractResourceType ResourceType { get; set; }
        uint ID { get; set; }
        string Name { get; set; }
    }
}