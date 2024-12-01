using Chain_of_Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chain_of_Responsibility
{
    public  class Division : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == "divide")
            {
                try
                {
                    Console.WriteLine("Обрабатывается деление чисел:");
                    Console.WriteLine($"Ответ: {request.numA / request.numB}");

                }catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            }
            else if (Next != null)
            {
                Next.HandleRequest(request);
            }
        }
    }
}
