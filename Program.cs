// See https://aka.ms/new-console-template for more information
using Garage;

Zero fxs = new Zero();
Tesla modelS = new Tesla();
Cessna mx410 = new Cessna();
Ram x1500 = new Ram();

fxs.Drive();
fxs.Turn("left", "Zero", "sharply");
fxs.Stop("quickly");
Console.WriteLine("");

modelS.Drive();
modelS.Turn("right", "Tesla", "quietly");
modelS.Stop("quietly");
Console.WriteLine("");


mx410.Drive();
mx410.Turn("right", "Cessna", "above");
mx410.Stop("plummets and");
Console.WriteLine("");


x1500.Drive();
x1500.Turn("left", "Ram", "annoyingly");
x1500.Stop("wildy");
Console.WriteLine("");
