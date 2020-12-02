using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace ComboBoxTest.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new ComboBoxTest.App(), args);
            host.Run();
        }
    }
}
