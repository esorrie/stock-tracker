public class IndexMarket
{ 
    public string Id { get; set; }
    public string Name { get; set; }
    public DateTime StartDateTime { get; set; }
    public decimal StartPrice { get; set; }
    public int NoOfDays { get; set; }
    public decimal TradeHoursPerDay { get; set; }
    public decimal ChangeBy { get; set; }
    public decimal MaxDailyChangePercentMin { get; set; }
    public decimal MaxDailyChangePercentMax { get; set; }
}