﻿namespace BookingApi.Features.Booking;

public class BookingException : Exception
{
    public BookingException(string message) : base(message)
    {
    }
}