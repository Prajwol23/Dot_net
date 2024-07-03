Console.Write("\t Dial: \t");

//NTC dial menu USSD 
String DefaultPin = "*1415#";
double Balance = 100.00;

//Taking user dial
string Dial = Console.ReadLine();

//Menu Design
if (Dial == DefaultPin)
{

    while (true)
    {
        Console.WriteLine("----------------Menu-------------------------");
        Console.WriteLine("Press 1 for Spring pack.");
        Console.WriteLine("Press 2 for Prepaid pack.");
        Console.WriteLine("Press 3 for Day pack.");
        Console.WriteLine("Press 4 for Balace check.");
        Console.WriteLine("Press 5 for Exit.");

        int menu = int.Parse(Console.ReadLine());

        switch (menu)
        {
            case 1:
                Spring();
                break;

            case 2:
                Prepaid();
                break;

            case 3:
                Day();
                break;

            case 4:
                BalanceCheck();
                break;

            case 5:
                Exit();
                break;

            default:
                Console.WriteLine("Incorrect info");
                break;
        }
    }
}

else
{
    Console.WriteLine("Incorrect dial format");
}

//Functions
//For Spring Pack
void Spring()
{
    Console.WriteLine("Enter Pack amount:\t");


    Double SpringAmt = double.Parse(Console.ReadLine());
    if (SpringAmt > Balance)
    {
        Console.WriteLine("Insufficient Balance");
    }
    else
    {
        Balance = Balance - SpringAmt;
        Console.WriteLine("Spring pack activated\n");
    }
}
//For Prepaid Pack
void Prepaid()
{
    Console.WriteLine("Enter Pack amount:\t");
    Double PrepaidAmt = double.Parse(Console.ReadLine());
    if (PrepaidAmt > Balance)
    {
        Console.WriteLine("Insufficient Balance");
    }
    else
    {
        Balance = Balance - PrepaidAmt;
        Console.WriteLine("Prepaid pack activated\n");
    }
}
//For Day Pack
void Day()
{
    Console.WriteLine("Enter Pack amount:\t");
    Double DayAmt = double.Parse(Console.ReadLine());
    if (DayAmt > Balance)
    {
        Console.WriteLine("Insufficient Balance");
    }
    else
    {
        Balance = Balance - DayAmt;
        Console.WriteLine("Day pack activated\n");
    }
}
//For Balance check
void BalanceCheck()
{

    Console.WriteLine("Your Balance is :" + Balance);
}
//Exit menu
void Exit()
{
    Environment.Exit(0);

}

