

using static System.Formats.Asn1.AsnWriter;

double grade = double.Parse(Console.ReadLine());
static bool IsPassing(double grade)
{
    if (grade > 65)
    {
        return true;
    }
    else if (grade <= 65)
    {
        return false;
    }
    Console.WriteLine(IsPassing(grade));
}


static double AverageGrades(double grade1, double grade2, double grade3)
{
    double total = (grade1 + grade2 + grade3) / 3;
    
}

static string OddOrEvenPassing(double grade)
{
    if (IsPassing(grade) && grade % 2 != 0)
    {
        return "passing and odd";
    }
    else if (!IsPassing(grade) && grade % 2 != 0)
    {
        return "failing and odd";
    }
    else if (IsPassing(grade) && grade % 2 == 0)
    {
        return "passing and even";
    }
    else if (!IsPassing(grade) && grade % 2 == 0)
    {
        return "failing and even";
    }
    
}
