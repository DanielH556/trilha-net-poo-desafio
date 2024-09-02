using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

string opt = "";

do
{
    Console.WriteLine("Escolha a marca: \n1 - Nokia \n2 - Iphone \n3 - Sair");
    opt = Console.ReadLine();
    if (opt == "1")
    {
        Nokia nokia = new Nokia("988887777", "tijolão", "CV2351FS", 3);
        Console.WriteLine($"Número: {nokia.Numero} \nMarca: Nokia \nModelo: {nokia.Modelo}\nIMEI: {nokia.IMEI}\nMemória: {nokia.Memoria}");
        nokia.InstalarAplicativo("Youtube");
    }
    else if (opt == "2")
    {
        Iphone iphone = new Iphone("944443333", "series s", "HJ5343Y", 128);
        Console.WriteLine($"Número: {iphone.Numero} \nMarca: Iphone \nModelo: {iphone.Modelo}\nIMEI: {iphone.IMEI}\nMemória: {iphone.Memoria}");
        iphone.InstalarAplicativo("Instagram");
    }
}
while (opt != "3");
Console.WriteLine("Obrigado por utilizar nossa ferramenta!");