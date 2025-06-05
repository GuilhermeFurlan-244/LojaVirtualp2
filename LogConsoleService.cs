using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
   public class LogConsoleService : ILogService
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine($"[LOG - {DateTime.Now}] {mensagem}");
        }
    }
}
