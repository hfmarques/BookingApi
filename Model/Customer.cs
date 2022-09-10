﻿namespace Model;

#nullable disable
public class Customer
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public virtual ICollection<Booking> Bookings { get; set; }
}