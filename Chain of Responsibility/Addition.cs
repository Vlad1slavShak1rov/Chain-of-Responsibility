using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Chain_of_Responsibility
{
    public class Addition : Handler
    {
        public override void HandleRequest(Request request)
        {
            if(request.Type == "addition")
            {
                Console.WriteLine("Обрабатывается сложение чисел:");
                Console.WriteLine($"Ответ: {request.numA+request.numB}");
            }
            else if (Next != null)
            {
                Next.HandleRequest(request);
            }
        }
    }
}
