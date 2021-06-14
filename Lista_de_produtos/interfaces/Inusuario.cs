using Lista_de_produtos.classes;

namespace Lista_de_produtos.interfaces
{
    public interface Inusuario
    {
        string Cadastrar(Usuario usuario);
        string  Deletar ( Usuario  usuario );
    }
}