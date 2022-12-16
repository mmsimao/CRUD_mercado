using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Mercado.Classes
{
    public class Produtos
    {
        public int ID { get; set; }
        public string descricao { get; set; }
        public int qtd { get; set; }
        public double preco { get; set; }
    }
}