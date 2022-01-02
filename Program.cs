using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceRest_20190140015_Muhamad_Arief_P_Suradi;
using System.ServiceModel;

namespace ServerConfigRest_20190140015_Muhamad_Arief_P_Suradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost hostObj = null;

            try
            {
                hostObj = new ServiceHost(typeof(TI_UMY));
                hostObj.Open();
                Console.WriteLine("Servicenya nyala ges...");
                Console.ReadLine();
                hostObj.Close();
            }
            catch (Exception ex)
            {
                hostObj = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
