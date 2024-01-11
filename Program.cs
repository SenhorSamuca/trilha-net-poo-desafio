using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// I M P L E M E N T A D O ! ! !

Console.WriteLine("----- Smartphone Nokia -----");
Smartphone nokia = new Nokia(numero: "01234", modelo: "G60", imei: "1111111111", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n--------------------------------------------------\n");

Console.WriteLine("----- Smartphone iPhone -----");
Smartphone iphone = new Iphone(numero: "56789", modelo: "iPhone 15 Pro Max", imei: "2222222222", memoria: 1024);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

Console.WriteLine("\n--------------------------------------------------\n");
