using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace devil
{
    public class Class1
    {
        public static byte[] GetByteDataSet(DataSet data)
        {
            byte[] data_rez;
            MemoryStream mem_streem = new MemoryStream();
            BinaryFormatter bin_format = new BinaryFormatter();
            bin_format.Serialize(mem_streem, data);
            data_rez = mem_streem.ToArray();
            mem_streem.Close();
            mem_streem.Dispose();
            return data_rez;
        }
    }
}
