using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umfg.Dominio.Entidades
{
    public sealed class Cliente
    {
        public string Documento { get; private set; }
        public string Nome { get; private set; }

        public Cliente(string documento, string nome)
        {
            if (string.IsNullOrEmpty(documento))
                throw new ArgumentException("O valor do documento não pode estar vazio.", nameof(documento));

            if (string.IsNullOrEmpty(nome))
                throw new ArgumentException("O valor do nome não pode estar vazio.", nameof(nome));

            Documento = documento ?? throw new ArgumentNullException(nameof(documento));
            Nome = nome ?? throw new ArgumentNullException(nameof(nome)); ;
        }
    }
}
