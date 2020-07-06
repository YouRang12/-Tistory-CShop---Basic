using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _21.Network
{
    class EchoClient
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine(
                    "사용법 : {0} <Bind IP> <Bind Port> <Server IP> <Message>",
                    Process.GetCurrentProcess().ProcessName);
                return;
            }

            string bindIP = args[0];
            int bindPort = Convert.ToInt32(args[1]);
            string serverIp = args[2];
            const int serverPort = 5425;
            string message = args[3];

            try
            {
                IPEndPoint clientAddress =
                    new IPEndPoint(IPAddress.Parse(bindIP), bindPort);
                IPEndPoint serverAddress =
                    new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

                Console.WriteLine("클라이언트: {0}, 서버{1}",
                    clientAddress.ToString(), serverAddress.ToString());
                // TcpClient => 1)서버 애플리케이션과 클라이언트 애플리케이션 양쪽에서 사용
                //              2)클라이언트에서는 서버에 연결 요청하는 역할을 수행
                //              3)서버에서는 클라이언트의 요청을 수락하면 TcpClient의 인스턴스가 반환됨
                TcpClient client = new TcpClient(clientAddress);

                // Connect() => 서버에 연결을 요청
                client.Connect(serverAddress);

                byte[] data = System.Text.Encoding.Default.GetBytes(message);

                // GetStream() => 데이터를 주고받는데 사용하는 매개체인 NetworkStream을 가져옴
                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);

                Console.WriteLine("송신: {0}", message);

                data = new byte[256];

                string responseData = "";

                int bytes = stream.Read(data, 0, data.Length);
                responseData = Encoding.Default.GetString(data, 0, bytes);
                Console.WriteLine("수신: {0}", responseData);

                // Close() => 연결을 닫음
                stream.Close();
                client.Close();
            }
            catch (SocketException e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("클라이언트를 종료합니다.");
        }
    }
}
