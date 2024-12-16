namespace DesafioPOO.Models
{
    //Herdando da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        //Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"instalando o app {nomeApp} no Nokia ");
        }
    }
}