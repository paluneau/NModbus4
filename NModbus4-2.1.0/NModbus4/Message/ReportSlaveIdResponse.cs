namespace Modbus.Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Data;
    using Unme.Common;
    using System.Globalization;


    //TODO phl
    class ReportSlaveIdResponse : AbstractModbusMessageWithData<ByteCollection>, IModbusMessage
    {

        public ReportSlaveIdResponse()
        {
        }

        public ReportSlaveIdResponse(byte functionCode, byte slaveAddress, byte byteCount, ByteCollection data)
            : base(slaveAddress, functionCode)
        {
            ByteCount = byteCount;
            Data = data;
        }

        public byte ByteCount
        {
            get { return MessageImpl.ByteCount.Value; }
            set { MessageImpl.ByteCount = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int MinimumFrameSize
        {
            get { return 3; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        protected override void InitializeUnique(byte[] frame)
        {
            if (frame.Length < 3 + frame[2])
                throw new FormatException("Message frame data segment does not contain enough bytes.");
            ByteCount = frame[2];
            //Slice ajuste l'offset
            Data = new ByteCollection(frame.Slice(3, ByteCount).ToArray<byte>());
        }

    }
}
