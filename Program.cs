using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "968584506", modelo: "G60", imei: "101010", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Facebook");

Console.WriteLine("==============");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "986553814", modelo: "14 pro max", imei: "202020", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");