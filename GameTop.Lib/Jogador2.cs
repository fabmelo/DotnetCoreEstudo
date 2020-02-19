using GameTop.Interface;

namespace GameTop.Lib
{
  public class Jogador2 : iJogador
  {    

    // chuta
    public string Chuta(){
        return "Maradona estas pateando\n";
    }

    // corre
    public string Corre(){
        return "Maradona estas corriendo\n";
    }

    // passe
    public string Passe(){
        return "Maradona estas pasando\n";
    }
  }
}