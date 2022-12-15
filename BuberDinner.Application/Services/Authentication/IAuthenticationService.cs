using BuberDinner.Application.Services.Authentication;

namespace BuberDinner.Application.Service.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register (string firstName, string lastName, string email, string password);
    AuthenticationResult Login (string email, string password);
}