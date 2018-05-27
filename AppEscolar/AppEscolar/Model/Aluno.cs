using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;
namespace AppEscolar.Model
{
    public class Aluno
    {
        [PrimaryKey, AutoIncrement]
        public long? Id { get; set; }

        [MaxLength(50)]
        public string Nome { get; set; }

        [MaxLength(2)]
        public int idade { get; set; }

        public string Telefone { get; set; }

        public string Rg { get; set; }

        [MaxLength(50)]
        public string Bairro { get; set; }

        public string Foto { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Nome, Rg, Telefone, Bairro);
        }
    }
}
