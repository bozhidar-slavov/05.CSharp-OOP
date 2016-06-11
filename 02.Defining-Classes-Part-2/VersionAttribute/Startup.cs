namespace Attribute
{
    using System;

    [Version("1.00")]
    public class Startup
    {
        public static void Main()
        {
            Type type = typeof(Startup);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in allAttributes)
            {
                Console.WriteLine("Version {0}", versionAttribute.Version);
            }
        }
    }
}
