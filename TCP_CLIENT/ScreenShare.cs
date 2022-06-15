using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TCP_CLIENT
{
    class ScreenShare
    {
        private static TcpClient _client;
        private static int _clientPort = 4000;

        private static TcpClient _imgSender;
        private static int __imgSenderPort = 4001;

        private static Thread _senderThread;

        private static string _ipAddress = "127.0.0.1";
        private static bool _useGDI = false;

        private static int _countAtt = 0;
        private static int _maxAtt = 10;

        
        public static void Connect()
        {
            try
            {
                _client = new TcpClient(_ipAddress, _clientPort);
                _senderThread = new Thread(Send);
                _senderThread.Start();
            }
            catch (Exception ex)
            {
                if (_countAtt < _maxAtt)
                {
                    _countAtt = _countAtt + 1;
                    Console.WriteLine($"Connection attemp: {_countAtt.ToString()}");
                    Connect();
                }
                else
                    Console.WriteLine("Error: ", ex.Message);
                //throw ex;  
            }
        }

        public static void Disconnect()
        {
            try
            {                
                _senderThread.Abort();
                _client.Close();
                _client.Dispose();
            }
            catch (Exception )
            {
                
            }
        }

        private static void Send()
        {
            _imgSender = new TcpClient(_ipAddress, __imgSenderPort);
            Console.WriteLine("Successfully Connected !");

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                using (NetworkStream stream = _imgSender.GetStream())
                {
                    while (_imgSender.Connected==true)
                    {
                        formatter.Serialize(stream, CaptureDesktop());
                        Thread.Sleep(1);

                    }
                       
                    
                }
                
            }
            catch (Exception)
            {

            }
        }

        public static Image CaptureDesktop()
        {
            if (_useGDI)
            {
                ScreenCaptureGDI.Capture();
                return ScreenCaptureGDI.capture;
            }
            else
                return ScreenCaptureUtil.Capture();
        }

    }
}
