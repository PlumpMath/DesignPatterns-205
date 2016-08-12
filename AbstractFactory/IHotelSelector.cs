namespace AbstractFactory
{
    public interface IHotelSelector
    {
        HotelInfo SelectHotel(string town, string hotelName);
    }
}