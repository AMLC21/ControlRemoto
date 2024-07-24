using System;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Control_Remoto
{
    class TCP_IP
    {
        private const int RECV_DATA_MAX = 1024000;
        public ClientSocket clientSocketInstance;
        public Boolean conectado = false;
        //String ip = "";
        int puerto = 0;

        public TCP_IP(int puertoConexion)//REcibe puerto de conexion (por defecto 23)
        {
            puerto = puertoConexion;
        }

        public Boolean Conectar(String ip) //Conectar a dispositivo TCP_IP. Recibe la IP en formato String
        {
            Boolean ok = false;

            if (!conectado)
            {
                try
                {
                    conectado = false;

                    //Configurar
                    //Convierte la IP string a formato IPAddress.
                    String[] _ip = ip.Split(".".ToCharArray());
                    byte[] ipAddress = { byte.Parse(_ip[0]), byte.Parse(_ip[1]), byte.Parse(_ip[2]), byte.Parse(_ip[3]) };
                    IPAddress iTACIpAddress = new IPAddress(ipAddress);

                    clientSocketInstance = new ClientSocket(ipAddress, puerto);

                    //Conectar socket
                    try
                    {
                        if (clientSocketInstance.commandSocket != null)
                        {
                            clientSocketInstance.commandSocket.Close();
                        }

                        clientSocketInstance.commandSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        clientSocketInstance.commandSocket.Connect(clientSocketInstance.readerCommandEndPoint);
                        clientSocketInstance.commandSocket.ReceiveTimeout = 1000;

                        conectado = true;
                    }
                    catch (SocketException ex)
                    {
                        conectado = false;
                    }
                }
                catch (Exception ex)
                {
                    conectado = false;
                }
            }
            else
            {
                ok = true;
            }

            return ok;
        }

        public String EnviarComando(String comando)//Envia comando y recibe respuesta 
        {
            String respuesta = "";
            Boolean ok = true;

            if (conectado)
            {
                byte[] command = ASCIIEncoding.ASCII.GetBytes(comando);

                if (ok && conectado)
                {

                    try
                    {

                        if (clientSocketInstance.commandSocket != null)//Si el dispositivo existe
                        {

                            //Enviar comando
                            try
                            {
                                clientSocketInstance.commandSocket.Send(command); //Manda el comando transformado en bytes
                            }
                            catch (Exception exc)
                            {
                            }

                            //Esperar respuesta

                            byte[] recvBytes = new byte[RECV_DATA_MAX];
                            int recvSize = 0;

                            if (clientSocketInstance.commandSocket != null)
                            {
                                try
                                {
                                    recvSize = clientSocketInstance.commandSocket.Receive(recvBytes);
                                }
                                catch (SocketException exc)
                                {
                                    try
                                    {
                                        recvSize = clientSocketInstance.commandSocket.Receive(recvBytes);
                                    }
                                    catch (Exception ex2)
                                    {
                                        respuesta = "Error de conexion";
                                    }
                                }
                            }
                            else
                            {
                                respuesta = "0";
                            }


                            if (recvSize == 0)
                            {
                                respuesta = "No responde";
                            }
                            else
                            {
                                //Codificar datos
                                respuesta = "";
                                for (int i = 0; i < recvSize && i < recvBytes.Length; i++)
                                {
                                    respuesta += (char)recvBytes[i];
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        respuesta = "Error general al enviar comando";
                    }
                }

            }
            else
            {
                respuesta = "No conectado";
            }

            return respuesta;
        }

        public void EnviarComandoSinRespuesta(String comando) //Envia comando sin leer ninguna respuesta
        {
            Boolean ok = true;

            if (conectado)
            {
                byte[] command = ASCIIEncoding.ASCII.GetBytes(comando);

                if (ok && conectado)
                {
                    try
                    {
                        if (clientSocketInstance.commandSocket != null)
                        {
                            //Enviar comando
                            try
                            {
                                clientSocketInstance.commandSocket.Send(command);
                            }
                            catch (Exception exc)
                            {
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }

            }
        }

        public String Leer()
        {
            String respuesta = "";

            //Esperar respuesta

            byte[] recvBytes = new byte[RECV_DATA_MAX];
            int recvSize = 0;

            if (clientSocketInstance.commandSocket != null)
            {
                try
                {
                    recvSize = clientSocketInstance.commandSocket.Receive(recvBytes);
                }
                catch (SocketException exc)
                {
                    try
                    {
                        recvSize = clientSocketInstance.commandSocket.Receive(recvBytes);
                    }
                    catch (Exception ex2)
                    {
                        respuesta = "Error de conexion";
                    }
                }
            }
            else
            {
                respuesta = "0";
            }


            if (recvSize == 0)
            {
                respuesta = "No responde";
            }
            else
            {
                //Codificar datos Shift-JIS.
                recvBytes[recvSize] = 0;
                respuesta = Encoding.GetEncoding("Shift_JIS").GetString(recvBytes);
            }

            return respuesta;
        }

        public void Desconectar()
        {

            //Cerrar socket
            if (conectado)
            {
                try
                {
                    clientSocketInstance.commandSocket.Close();
                    clientSocketInstance.commandSocket.Disconnect(true);
                    clientSocketInstance.commandSocket = null;
                }
                catch (Exception ex)
                {

                }

            }
            conectado = false;
        }

        public class ClientSocket
        {
            public Socket commandSocket;
            public IPEndPoint readerCommandEndPoint;

            public ClientSocket(byte[] ipAddress, int readerCommandPort)
            {
                IPAddress readerIpAddress = new IPAddress(ipAddress);
                readerCommandEndPoint = new IPEndPoint(readerIpAddress, readerCommandPort);
                commandSocket = null;
            }
        }

    }
}
