namespace CMen.Project
{
    public interface IData : IAbstractResource
    {
        CMenFileType Type { get; }
    }
}