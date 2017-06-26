namespace Modbus.Data
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Net;

    class ByteCollection : Collection<byte>, IModbusMessageDataCollection
    {

        public ByteCollection(List<byte> bytes)
            : base(bytes)
        {
        }

        public ByteCollection(byte[] bytes)
            : this(bytes.ToList<byte>())
        {
        }

        /// <summary>
        ///     Gets the network bytes.
        /// </summary>
        public byte[] NetworkBytes
        {
            get
            {
                return this.ToArray();
            }
        }

        /// <summary>
        ///     Gets the byte count.
        /// </summary>
        public byte ByteCount
        {
            get { return (byte)(Count); }
        }

        /// <summary>
        ///     Returns a <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.
        /// </summary>
        /// <returns>
        ///     A <see cref="T:System.String" /> that represents the current <see cref="T:System.Object" />.
        /// </returns> 
        public override string ToString()
        {
            return String.Concat("{", String.Join(", ", this.Select(v => v.ToString()).ToArray()), "}");
        }

    }
}
