
using System.Net.Http.Headers;

namespace DecoratorPattern.DataHandler.Interface;

internal interface IDataHandler
{
    public string ReadData();
    public void WriteData(string data);
}
