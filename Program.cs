using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Nokia n1 = new Nokia("(11)11111-1111", "Modelo x10", "111111111111111", 1024);
Iphone i1 = new Iphone("(22)22222-2222", "Modelo y20", "222222222222222", 2048);

Console.WriteLine($"----- Smartphone Nokia -------"); 
Console.WriteLine($"Número: {n1.Numero}");
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Outlook");
n1.AlterarNumero("(11) 11111-2222");

Console.WriteLine($"----- Smartphone Iphone -------"); 
Console.WriteLine($"Número: {i1.Numero}");
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Outlook");
i1.AlterarNumero("(22) 22222-3333");        