namespace DomainLayer.Models.Pets
{
    public interface IPetsModel
    {
        string petbday { get; set; }
        string petbreed { get; set; }
        int petID { get; set; }
        string petname { get; set; }
    }
}