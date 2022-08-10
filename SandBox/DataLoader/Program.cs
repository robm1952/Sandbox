using DataLoader.Steps;

namespace DataLoader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine("DataLoader.Main(string[] args)");
            BreakAndStoreData bsd = new BreakAndStoreData();
            bsd.ProcessReadLines();
        }
    }
}
