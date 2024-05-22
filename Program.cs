using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "1234", modelo: "Modelo 1", imei: "123324", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "123674", modelo: "Modelo 2", imei: "1233", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");