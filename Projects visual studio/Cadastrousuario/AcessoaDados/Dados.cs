using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastraUsuarios
{
    class Dados
    {
        public static string Conexao()
        {
            return @"Data Source=DESKTOP-USD903K\SQLEXPRESS;Initial Catalog=educaflix;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
    }
}
