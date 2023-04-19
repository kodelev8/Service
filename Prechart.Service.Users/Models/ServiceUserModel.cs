using System.ComponentModel.DataAnnotations;

namespace Prechart.Service.Users.Models;

public class ServiceUserModel
{
    public string UserName { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Email { get; set; }
    public string[] Roles { get; set; }
    public string PersonId { get; set; }
}