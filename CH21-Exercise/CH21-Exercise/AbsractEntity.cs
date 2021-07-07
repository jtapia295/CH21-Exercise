using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH21_Exercise
{
    public abstract class AbsractEntity
    {
        Random _id = new Random();
        static List<int> devices = new List<int>();
        //public int deviceID { get; set; }
        
        static int i = -1;
        int iteration;
        public int GetID()
        {
            return devices[iteration];
        }

        public AbsractEntity()
        {
            int number;
            do
            {
                number = _id.Next(000001, 99999);
            } while (devices.Contains(number));
            devices.Add(number);
            i++;
            iteration = i;
            
        }
    }
}
