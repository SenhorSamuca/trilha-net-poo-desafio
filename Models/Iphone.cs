namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone{
        // I M P L E M E N T A D O ! ! !
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        // I M P L E M E N T A D O ! ! !

        public override void InstalarAplicativo(string nomeApp){
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Smartphone iPhone.");
        }
    }
}
