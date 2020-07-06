using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;


//namespace _21.Network
//{
//    class EchoServer
//    {
//        static void Main(string[] args)
//        {
//            if (args.Length < 1)
//            {
//                Console.WriteLine("사용법 : {0} <Bind IP>",
//                    Process.GetCurrentProcess().ProcessName);
//                return;
//            }

//            string bindIP = args[0];
//            const int bindPort = 5425;
//            TcpListener server = null;
//            try
//            {
//                IPEndPoint localAddress =
//                    new IPEndPoint(IPAddress.Parse(bindIP), bindPort);

//                // TcpListener => 1)서버 애플리케이션에서 사용
//                //                2)클라이언트의 연결 요청을 기다리는 역할
//                server = new TcpListener(localAddress);

//                // 연결 요청 수신 대기를 시작
//                server.Start();

//                Console.WriteLine("메아리 서버 시작...");

//                while (true)
//                {
//                    // TcpClient => 1)서버 애플리케이션과 클라이언트 애플리케이션 양쪽에서 사용
//                    //              2)클라이언트에서는 서버에 연결 요청하는 역할을 수행
//                    //              3)서버에서는 클라이언트의 요청을 수락하면 TcpClient의 인스턴스가 반환됨
//                    // AcceptTcpClient() => 클라이언트위 연결 요청을 수락, TcpClient 객체를 반환
//                    TcpClient client = server.AcceptTcpClient();
//                    Console.WriteLine("클라이언트 접속 : {0} ",
//                        ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

//                    // GetStream() => 데이터를 주고받는데 사용하는 매개체인 NetworkStream을 가져옴
//                    NetworkStream stream = client.GetStream();

//                    int length;
//                    string data = null;
//                    byte[] bytes = new byte[256];

//                    while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
//                    {
//                        data = Encoding.Default.GetString(bytes, 0, length);
//                        Console.WriteLine(String.Format("수신: {0}", data));

//                        byte[] msg = Encoding.Default.GetBytes(data);

//                        stream.Write(msg, 0, msg.Length);
//                        Console.WriteLine(String.Format("송신: {0}", data));
//                    }

//                    // Close() => 연결을 닫음
//                    stream.Close();
//                    client.Close();
//                }
//            }
//            catch (SocketException e)
//            {
//                Console.WriteLine(e);
//            }
//            finally
//            {
//                // 연결 요청 수신 대기를 종료
//                server.Stop();
//            }
//            Console.WriteLine("서버를 종료합니다.");
//        }
//    }
//}
