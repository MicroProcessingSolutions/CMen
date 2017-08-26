namespace CMen.Project
{
    public interface IData
    {
        CMenFileType DataType { get; }
        uint ID { get; }
        string Name { get; }
    }
}