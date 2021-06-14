using System.Collections.Generic;
using Lista_de_produtos.classes;

namespace Lista_de_produtos.interfaces
{
    public interface Inmarca
    {
        string Cadastrar(Marca marca);
        List<Marca> Listar();
        string Deletar(Marca marca);
    }
}