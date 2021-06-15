namespace SplashEx
{
    using System.Reflection;
    using System.Runtime.InteropServices;

    public static class MutEx
    {
        /// <summary>
        /// Метод для получения статистически уникального 128-битного идентификатора
        /// </summary>
        /// <returns>Guid</returns>
        public static string GUID
        {
            get
            {
                string result = string.Empty;
                try
                {
                    Assembly assembly = typeof(Program).Assembly;
                    var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
                    result = attribute.Value;
                }
                catch { }
                return result?.ToUpper();
            }
        }
    }
}