using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialisationandeserialisation
{
    [Serializable]
    class CustomerDetails
    {
        public int customerID { get; set; }
        public string customerName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Step1:
            CustomerDetails obj = new CustomerDetails();
            obj.customerID = 1;
            obj.customerName = "John";

            //Step2
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"C:\aa\New.txt", FileMode.Create, FileAccess.Write);

            //Step3 Serialise
            formatter.Serialize(stream, obj);
            stream.Close();

            //Step4 Deserialize
            stream = new FileStream(@"C:\aa\New.txt", FileMode.Open, FileAccess.Read);
            CustomerDetails objnew = (CustomerDetails)formatter.Deserialize(stream);

            Console.WriteLine("After Deserialization Customer Id: " + objnew.customerID);
            Console.WriteLine("After Deserialization Customer Name: " + objnew.customerName);

            Console.ReadLine();
        }
    }
}
