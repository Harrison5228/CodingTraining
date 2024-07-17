
using DecoratorPattern.DataHandler;
using DecoratorPattern.DataHandler.Interface;

IDataHandler dataHandler = new DataHandler("example.txt");
Console.WriteLine(dataHandler.ReadData());


IDataHandler encrptDataHandler = new EncryptDataHandler(dataHandler);
Console.WriteLine(encrptDataHandler.ReadData());

dataHandler.WriteData("Hello, World!");
string result = dataHandler.ReadData();

Console.WriteLine(result);