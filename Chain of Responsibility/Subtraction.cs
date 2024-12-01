using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility
{
    public class Subtraction : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Type == "subtraction")
            {
                Console.WriteLine("Обрабатывается разность чисел:");
                Console.WriteLine($"Ответ: {request.numA - request.numB}");
            }
            else if(Next != null)
            {
                Next.HandleRequest(request);
            }
        }

    }
}
