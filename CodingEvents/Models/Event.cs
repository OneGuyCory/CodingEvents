﻿using System;
namespace CodingEvents.Models;

public class Event
{
    public string? Name { get; set;  }
    public string? Description { get; set; }
    public string? ContactEmail { get; set; }
    public int Id { get; }
    private static int nextid = 1;

    public Event()
    {
        Id = nextid;
        nextid++;
    }
    public Event(string name, string description)
    {
        Name = name;
        Description = description;
        Id = nextid;
        nextid++;
    }

    public override string? ToString()
    {
        return Name;
    }

    public override bool Equals(object? obj)
    {
        return obj is Event @event && Id == @event.Id;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id);
    }
}