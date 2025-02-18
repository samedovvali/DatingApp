using System;

namespace API.Entities;

public class AppUser
{
    public int Id { get; set; }
    public required string UserName { get; set; }
    public required byte[] PasswordHash { get; set; } // first way of encryption 
    public required byte[] PasswordSalt { get; set; } // further way of encryption


}
