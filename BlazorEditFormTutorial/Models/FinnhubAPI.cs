namespace BlazorEditFormTutorial.Models;

public class FinnhubAPI
{
    public int Count { get; set; }
    public List<StockInfo> result { get; set; } // Make this public or use a getter/setter method
}