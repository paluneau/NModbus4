namespace Modbus.Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class ReportSlaveIdRequest : AbstractModbusMessage, IModbusRequest
    {
        //TODO phl

        public ReportSlaveIdRequest()
        {
        }

        public ReportSlaveIdRequest(byte functionCode, byte slaveAddress)
            : base(slaveAddress, functionCode)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public override int MinimumFrameSize
        {
            get { return 6; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="response"></param>
        public void ValidateResponse(IModbusMessage response)
        {
            //TODO phl méthode de validation (expected bytecount)
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="frame"></param>
        protected override void InitializeUnique(byte[] frame)
        {
            //TODO
        }

    }
}
