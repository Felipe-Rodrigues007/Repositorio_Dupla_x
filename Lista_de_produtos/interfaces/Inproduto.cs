using System.Collections.Generic;
using Lista_de_produtos.classes;

namespace Lista_de_produtos.interfaces
{
    public interface Inproduto
    {
        string  Cadastrar ( Produto  produto );
        List<Produto> Listar();
        string  Deletar ( Produto  produto );
    }
}