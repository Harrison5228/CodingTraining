using DecoratorPattern.DataHandler.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.DataHandler
{
    internal class EncryptDataHandler : DataHandlerDecorator
    {
        private IDataHandler _dataHandler;
        public EncryptDataHandler(IDataHandler dataHandler) : base(dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public override string ReadData()
        {
            var data = base.ReadData();
            return Decrypt(data);
        }

        public override void WriteData(string data)
        {
            base.WriteData(Encrypt(data));
        }

        private string Encrypt(string data) 
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }
        private string Decrypt(string data)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(data));
        }
    }
}
