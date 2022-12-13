using System.Reflection;
using System.Runtime.InteropServices;

namespace ConsoloeApp5
{
    class Program
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(IntPtr x, String message, String title, int options);

        public static void Main(string[] args)
        {

            int x = 2;
            MessageBox(IntPtr.Zero, sqr(x).ToString(), $"Sqr of {x}", 0);
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Console.WriteLine(assembly.FullName);
            }

        }
        public static double sqr(double x) { return x * x; }
    }
}