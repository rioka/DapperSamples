
namespace DapperSamples.Test.Entities
{
  internal class UserWithPrivateCtor
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    private UserWithPrivateCtor()
    {}
  }
}
