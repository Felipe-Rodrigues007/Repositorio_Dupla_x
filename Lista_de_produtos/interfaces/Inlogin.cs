using Lista_de_produtos.classes;

namespace Lista_de_produtos.interfaces
{
    public interface Inlogin
    {
        string  Logar ( Usuario  usuario );
        string  Deslogar ( Usuario  usuario );
    }
}