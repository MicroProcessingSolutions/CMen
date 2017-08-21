namespace CMen.Project
{
    public interface IData
    {
        CMenFileType Type { get; set;}
        uint ID { get; set; }
        string Name { get; set; }
    }
}