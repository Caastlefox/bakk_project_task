﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using Microsoft.Data.Sqlite;



public class Client
{
    public int Id { get; set; }
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string? Address { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? Status { get; set; }

}
