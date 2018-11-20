namespace EdrpgDLL.Abstract
{
    public interface iComponent
    {
        string Name { get; set; }
        int Size { get; set; }
        char Class { get; set; }
        int Cost { get; set; }
        int Strength { get; set; }
        bool Military { get; set; }
        double PowerCost { get; set; }
    }
}
