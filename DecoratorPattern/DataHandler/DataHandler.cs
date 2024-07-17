using DecoratorPattern.DataHandler.Interface;

namespace DecoratorPattern.DataHandler;

internal class DataHandler : IDataHandler
{
    private readonly string _fileName;
    public DataHandler(string fileName)
    {
        _fileName = fileName;
    }

    public string ReadData()
    {
        return File.ReadAllText(_fileName);
    }

    public void WriteData(string data)
    {
        File.WriteAllText(_fileName, data); 
    }
}
