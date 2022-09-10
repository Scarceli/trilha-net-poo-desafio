namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public void AlterarNumero(string numeroAlterar){
            Numero = numeroAlterar;
            Console.WriteLine($"Seu número foi alterado para: {Numero}"); 
        }
        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Intalando o app {nomeApp} no Iphone");
        }
    }
}