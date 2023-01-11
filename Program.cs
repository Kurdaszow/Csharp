using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;












public class Program
{
    public static void Main()
    {
        Game game = new Game();
        while (true)
        {
            game.move();
        }
    }
}