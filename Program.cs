using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
namespace program
{
    class program
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Nokia("587226", "Asus", "222222222", 256);
            nokia.Ligar();
            nokia.InstalarAplicativo("Whatsapp");
            Console.WriteLine("\n");

            Smartphone iphone = new Iphone("241358","Iphone 18"," 1111111111111",458);
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");

        }
    }
}