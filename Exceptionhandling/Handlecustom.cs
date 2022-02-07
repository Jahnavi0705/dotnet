using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptionhandling
{
    public class TempIsZeroException:Exception
    {
        public TempIsZeroException(string message):base(message)
        {

        }
    }
    

    public class TestTemperature
    {
        int temperature = 0;

        public void ShowTemperature()
        {
            if(temperature==0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("Temperature:" + temperature);
            }
        }
        static void Main(String[] args)
        {
            TestTemperature testTemperature = new TestTemperature();
            try
            {
                testTemperature.ShowTemperature();

            }
            catch(TempIsZeroException ex)
            {
                Console.WriteLine("Custom exception is:"+ex.Message);
            }
        }
    }
}
