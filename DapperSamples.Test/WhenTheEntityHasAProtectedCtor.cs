using System.Linq;
using Dapper;
using DapperSamples.Test.Entities;
using NUnit.Framework;

namespace DapperSamples.Test
{
  [TestFixture]
  public class WhenTheEntityHasAProtectedCtor : NonPublicCtorTestBase
  {
    #region Tests
    
    [Test]
    public void The_entity_is_materialized()
    {
      // arrange

      // act
      var user = Cn.Query<UserWithProtectedCtor>("select * from Users").First();

      // assert
      Assert.IsNotNull(user);
      Assert.AreEqual("John", user.FirstName);
      Assert.AreEqual("Doe", user.LastName);
    }

    #endregion
  }
}
