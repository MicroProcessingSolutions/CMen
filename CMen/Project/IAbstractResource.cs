namespace CMen.Project
{
    public interface IAbstractResource
    {
        CMenAbstractResourceType ResourceType { get; }
        uint ID { get; }
        string Name { get; }
    }
}