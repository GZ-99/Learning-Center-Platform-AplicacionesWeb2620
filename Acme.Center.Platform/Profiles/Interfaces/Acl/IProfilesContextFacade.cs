namespace Acme.Center.Platform.Profiles.Interfaces.Acl;

public interface IProfilesContextFacade
{
    Task<int> CreateProfile(string firstName, string lastName, string email, string street, string number, string city, string postalCode, string country,
        CancellationToken cancellationToken);
    
    Task<int> FetchProfileIdByEmail(string email, CancellationToken cancellationToken);
}
