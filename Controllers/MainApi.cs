using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace lange_week3Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainApi : ControllerBase
    {

        [HttpPost(Name = "GetWeatherForecast")]

        public ActionResult<List<string>> IntListWork(List<int> lint)
            
        {
           List<string> slist = new List<string>();

            double sum = 0;
            double sumSquares = 0;
            double counter = 0;
            double mean = 0;
            double stdDev = 0;

            lint.Sort();

            try
            {


                foreach (int i in lint)
                {
                    System.Console.WriteLine(LogObject(i));
                    counter++;
                    sum += i;
                    sumSquares += i * i;
                    mean = sum / counter;
                    stdDev = Math.Sqrt((sumSquares - sum * sum / counter) / (counter - 1));
                    if (counter > 1)
                    {
                        slist.Add("Element " + counter + ": Current Standard Deviation: " + stdDev);
                    }
                    else
                    {
                        slist.Add("List too small");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Double ");
            }
            Console.WriteLine("Program Running... " );


            return slist;
        }
        string LogObject(double i)
        {   
            System.Diagnostics.Debug.WriteLine(i);
            //System.Console.WriteLine();
            string j = Convert.ToString(i);
            return j;
        }
    }
}