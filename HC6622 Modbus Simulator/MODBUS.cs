using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;


// update V1.10 : Support function 3 and 4 
//              : Minor bug fixed



namespace HC6622_Modbus_Simulator
{
    public class modbusRTU
    {
        public uint address;
        public Int16[] regAnalog = new Int16[14];
        public Int16[] regFault = new Int16[4];

        public modbusRTU() 
        {
            for (int i = 0; i < regAnalog.Length; i++)
            {
                regAnalog[i] = 0;
            }
        }

        public bool Response(byte[] message, ref SerialPort port)
        {
            if(this.address != message[0])
            {
                return false;
            }

            if (message[1] == 3)    // function
            {   
                UInt16 startReg = (UInt16)((message[2] * 256) + message[3]);
                UInt16 count = (UInt16)((message[4] * 256) + message[5]);
                if (startReg == 64 && count == 14)
                {
                    List<byte> responseBuffer = new List<byte>();
                    responseBuffer.Add(1);
                    responseBuffer.Add(3);
                    responseBuffer.Add(28);

                    //-------- data ------------//
                    for (int i = 0; i < regAnalog.Length; i++)
                    {
                        responseBuffer.Add((byte)((regAnalog[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regAnalog[i] & 0x00FF));
                    }

                    //-------- CRC -------------//
                    //MessageBox.Show(responseBuffer.ToArray.
                    UInt16 CRC = modbusCRC.buildCRC(responseBuffer.ToArray());

                    responseBuffer.Add((byte)(CRC & 0x00FF));
                    responseBuffer.Add((byte)((CRC & 0xFF00) / 256));
                    port.Write(responseBuffer.ToArray(), 0, responseBuffer.Count);
                    return true;
                }
                else if (startReg == 64 && count == 18)
                {
                    List<byte> responseBuffer = new List<byte>();
                    responseBuffer.Add(1);
                    responseBuffer.Add(4);
                    responseBuffer.Add(36);

                    //-------- data ------------//
                    for (int i = 0; i < regAnalog.Length; i++)
                    {
                        responseBuffer.Add((byte)((regAnalog[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regAnalog[i] & 0x00FF));
                    }

                    for (int i = 0; i < regFault.Length; i++)
                    {
                        responseBuffer.Add((byte)((regFault[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regFault[i] & 0x00FF));
                    }

                    //-------- CRC -------------//
                    //MessageBox.Show(responseBuffer.ToArray.
                    UInt16 CRC = modbusCRC.buildCRC(responseBuffer.ToArray());

                    responseBuffer.Add((byte)(CRC & 0x00FF));
                    responseBuffer.Add((byte)((CRC & 0xFF00) / 256));
                    port.Write(responseBuffer.ToArray(), 0, responseBuffer.Count);
                    return true;
                }
                return false;
            }

            else if (message[1] == 4)    // function
            {
                UInt16 startReg = (UInt16)((message[2] * 256) + message[3]);
                UInt16 count = (UInt16)((message[4] * 256) + message[5]);

                if (startReg == 64 && count == 14)
                {
                    List<byte> responseBuffer = new List<byte>();
                    responseBuffer.Add(1);
                    responseBuffer.Add(4);
                    responseBuffer.Add(28);

                    //-------- data ------------//
                    for (int i = 0; i < regAnalog.Length; i++)
                    {
                        responseBuffer.Add((byte)((regAnalog[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regAnalog[i] & 0x00FF));
                    }

                    //-------- CRC -------------//
                    //MessageBox.Show(responseBuffer.ToArray.
                    UInt16 CRC = modbusCRC.buildCRC(responseBuffer.ToArray());

                    responseBuffer.Add((byte)(CRC & 0x00FF));
                    responseBuffer.Add((byte)((CRC & 0xFF00) / 256));
                    port.Write(responseBuffer.ToArray(), 0, responseBuffer.Count);
                    return true;
                }

                else if (startReg == 64 && count == 18)
                {
                    List<byte> responseBuffer = new List<byte>();
                    responseBuffer.Add(1);
                    responseBuffer.Add(4);
                    responseBuffer.Add(36);

                    //-------- data ------------//
                    for (int i = 0; i < regAnalog.Length; i++)
                    {
                        responseBuffer.Add((byte)((regAnalog[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regAnalog[i] & 0x00FF));
                    }

                    for (int i = 0; i < regFault.Length; i++)
                    {
                        responseBuffer.Add((byte)((regFault[i] & 0xFF00) / 256));
                        responseBuffer.Add((byte)(regFault[i] & 0x00FF));
                    }

                    //-------- CRC -------------//
                    //MessageBox.Show(responseBuffer.ToArray.
                    UInt16 CRC = modbusCRC.buildCRC(responseBuffer.ToArray());

                    responseBuffer.Add((byte)(CRC & 0x00FF));
                    responseBuffer.Add((byte)((CRC & 0xFF00) / 256));
                    port.Write(responseBuffer.ToArray(), 0, responseBuffer.Count);
                    return true;
                }
                return false;
            }

            return false;
        }

    }

    static class modbusCRC
    {
        public static ushort calCRC(byte[] message)
        {
            //Function expects a modbus message of any length as well as a 2 byte CRC array in which to 
            //return the CRC values:

            ushort CRCFull = 0xFFFF;
            //byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            return CRCFull;
            //CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            //CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }

        public static ushort buildCRC(byte[] message)
        {
            //Function expects a modbus message of any length as well as a 2 byte CRC array in which to 
            //return the CRC values:

            ushort CRCFull = 0xFFFF;
            //byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < (message.Length); i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            return CRCFull;
            //CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            //CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        }

        public static bool chkCRC(byte[] message)
        {
            //Function expects a modbus message of any length as well as a 2 byte CRC array in which to 
            //return the CRC values:

            ushort CRCFull = 0xFFFF;
            //byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;

            for (int i = 0; i < (message.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ message[i]);

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            ushort crcIN = (ushort)((message[message.Length-1] * 256) + message[message.Length-2]);
            if (CRCFull == crcIN) return true;
            else return false;
            //CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            //CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
        } 
    }
  
}
