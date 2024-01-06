using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine();

Console.WriteLine("Smartphone iPhone:");
Smartphone iPhone = new Iphone(numero: "98765", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Telegram");
