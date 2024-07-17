using DecoratorPattern.DataHandler.Interface;

namespace DecoratorPattern.DataHandler;

internal class DataHandlerDecorator : IDataHandler
{
    private readonly IDataHandler _dataHandler;
    
    public DataHandlerDecorator(IDataHandler dataHandler)
    {
        _dataHandler = dataHandler;
    }

    public virtual string ReadData()
    {
        return _dataHandler.ReadData();
    }

    public virtual void WriteData(string data)
    {
        _dataHandler.WriteData(data);
    }
}
