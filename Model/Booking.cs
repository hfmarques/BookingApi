﻿namespace Model;

#nullable disable
public class Booking
{
    public long Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int RoomId { get; set; }
    public Room Room { get; set; }
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
}