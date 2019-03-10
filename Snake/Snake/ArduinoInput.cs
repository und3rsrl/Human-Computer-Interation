using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public class ArduinoInput
    {
        private SerialPort _serialPort;

        public ArduinoInput(string portName)
        {
            _serialPort = new SerialPort(portName);
            _serialPort.Open();
        }

        public SerialPort SerialPort => _serialPort;

        public void Dispose()
        {
            if (_serialPort != null)
            {
                _serialPort.Dispose();
            }
        }
    }
}

