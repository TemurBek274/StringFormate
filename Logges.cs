using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHomework
{
    internal class Logger : IDisposable
    {
        private FileStream _fs;

        public Logger()
        {
            _fs = new FileStream("Logger.log", FileMode.Open);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
