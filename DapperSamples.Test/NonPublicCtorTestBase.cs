using System.Configuration;
using System.Data.SQLite;
using System.Reflection;
using DapperSamples.Test.Extensions;
using NUnit.Framework;

namespace DapperSamples.Test
{
  [TestFixture]
  public abstract class NonPublicCtorTestBase
  {
    #region Vars

    protected SQLiteConnection Cn;

    #endregion

    #region Setup & teardown

    [SetUp]
    public void BeforeEach()
    {
      Cn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SampleDb"].ConnectionString);
      Cn.Open();

      Cn.RunScriptFromResource(MethodBase.GetCurrentMethod().DeclaringType.Namespace + ".Fixtures.CreateAndPopulateDb.sql");
    }

    [TearDown]
    public void AfterEach()
    {
      Cn.Dispose();
    }

    #endregion
  }
}
