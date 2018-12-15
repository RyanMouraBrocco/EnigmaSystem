using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaSystem
{
    public static class UsuarioAtual
    {
        public static int ID { get; set; }
        public static string Nome { get; set; }
        public static string Email { get; set; }
        public static string Senha { get; set; }
        public static string TipoConta { get; set; }
        public static byte[] Foto { get; set; }
    }
}
