using System;
using System.Collections.Generic;

namespace Lista_de_produtos.classes
{
    public class Usuario
    {
        public int codigo;
        public string nome;
        public string email;
        public int senha;

        public DateTime DataCadastro;

        public List<Usuario> listaUsuario = new List<Usuario>();

        public Usuario(){

        }

        public Usuario(string _email,int _senha){
            senha=_senha;
            email=_email;
        }

        public string Cadastrar(Usuario u){
            listaUsuario.Add(u);
            return$"Usuario cadastrado com sucesso ;)";
        }
        public string Deletar(Usuario u){
            listaUsuario.Remove(u);
            return$"Usuario deletado com sucesso";
        }
    }
}