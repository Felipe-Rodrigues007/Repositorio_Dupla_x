using System;
using System.Collections.Generic;
using Lista_de_produtos.interfaces;

namespace Lista_de_produtos.classes
{
    public class Produto : Inproduto
    {
        public int codigo ;
        public string NomeProduto ;
        public float Preco ;
         public DateTime DataCadastro;
        public Marca Marca ;
        public Usuario CadastrarPor ;

        public List<Produto> ListaDeProdutos =new List<Produto>();


        public string Cadastrar(Produto produto){
            ListaDeProdutos.Add(produto);
            return"Produto Cadastrado";
        }
        public List<Produto> Listar(){
            return ListaDeProdutos;
        } 
        public string Deletar(Produto produto){
            ListaDeProdutos.Remove(produto);
            return "Produto Deletado";
        }

        
        
    }
}