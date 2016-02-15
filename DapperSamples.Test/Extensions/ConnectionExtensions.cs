using System.Data.SQLite;
using System.IO;
using System.Reflection;
using Dapper;

namespace DapperSamples.Test.Extensions
{
  static class ConnectionExtensions
  {
    public static void RunScriptFromResource(this SQLiteConnection cn, string resourceName)
    {
      var assembly = Assembly.GetExecutingAssembly();
      var content = string.Empty;

      using (var stream = assembly.GetManifestResourceStream(resourceName))
        if (stream != null)
          using (var reader = new StreamReader(stream))
            content = reader.ReadToEnd();

      if (!string.IsNullOrWhiteSpace(content))
      {
        cn.Execute(content);
      }
    }
  }
}
