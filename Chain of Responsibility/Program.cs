using Chain_of_Responsibility;
using System;

Handler addition = new Addition();
Handler subtraction = new Subtraction();
Handler multiplication = new Multiplication();
Handler divided = new Division();

addition.SetNext(subtraction);
subtraction.SetNext(multiplication);
multiplication.SetNext(divided);

addition.HandleRequest(new Request("addition", 20, 5));
addition.HandleRequest(new Request("subtraction", 20, 5));
addition.HandleRequest(new Request("multiplication", 20, 5));
addition.HandleRequest(new Request("divide", 20, 5));
addition.HandleRequest(new Request("sqrt", 20, 5));