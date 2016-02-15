
namespace DapperSamples.Test.Entities
{
  internal class UserWithProtectedCtor
  {
    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    protected UserWithProtectedCtor()
    {}
  }
}
