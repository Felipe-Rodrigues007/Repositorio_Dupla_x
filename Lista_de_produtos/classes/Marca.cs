using System;
using System.Collections.Generic;

namespace Lista_de_produtos.classes
{
    public class Marca
    {
        public string codigo;
        public string NomeMarca;

        DateTime DataCadastro;

       

       public List<Marca> ListaMarca = new List<Marca>();

        public Marca(){
            
        }

        public Marca(string _codigo, string _NomeMarca,DateTime DataCadastro)
        {
            codigo = _codigo;
            NomeMarca = _NomeMarca;
            DataCadastro =DateTime.Now;
        }
        public string Cadastrar(Marca _marca)
        {
            ListaMarca.Add(_marca);
            return$"Marca {_marca.NomeMarca} cadastrado com sucesso ;)";
        }
        public List<Marca> Listar()
        {
            return ListaMarca;
        }
        public string Deletar(Marca _marca)
        {
            ListaMarca.Remove(_marca);
            return$"O item do codigo {_marca.codigo} foi removido com sucesso :)";
        }
    }
}