class Program
{
    //static void Main(string[] args);

    //constants
    //int IS_FULL_TIME = 1;
    //Random random = new Random();
    ////computaaion
    //int empCheck = random.Next(0, 2);
    //if (empCheck == IS_FULL_TIME)
    //    {
    //        Console.WriteLine("Employee is present");
    //    }
    //else
    //    {
    //        Console.WriteLine("Employee is  absent");
    //    }

    /*int IS_FULL_TIME = 1;
     int EMP_RATE_PER_HOUR = 20;
     int empWage = 0;
     int empHrs = 0;
     Random obj = new Random();
     int empCheck = obj.Next(0, 3);
     if (empCheck == IS_FULL_TIME)
     {
         empHrs = 8;
     }
     else
     {
         empHrs = 0;
     }
     empWage = empHrs * EMP_RATE_PER_HOUR;
     Console.WriteLine("Emp Wage : + empwage");*/

    /* int IS_PART_TIME = 1;
    int IS_FULL_TIME = 2;
    int EMP_RATE_PER_HOUR = 20;
    int empHrs = 0;
    int empWage = 0;
    Random random = new Random();
    int empCheck = random.Next(0, 3);
    if (empCheck == IS_PART_TIME)
    {
        empHrs = 4;
    }
    else if (empCheck == IS_FULL_TIME)
    {
        empHrs = 8;
    }
    else
    {
        empHrs = 0;
    }
    empWage = empHrs * EMP_RATE_PER_HOUR;
    Console.WriteLine("Emp Wage :" + empWage); */

    /*public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
   public const int EMP_RATE_PER_HOUR = 20;

  static void Main(string[] args)   
{
    int empHrs = 0;
    int empWage = 0;
    Random random = new Random();
    int empCheck = random.Next(0, 3);
    switch (empCheck)
    {
        case IS_PART_TIME:
            empHrs = 4;
            break;
        case IS_FULL_TIME:
            empHrs = 8;
            break;
        default:
            empHrs = 0;
            break;

    }
    empWage = empHrs * EMP_RATE_PER_HOUR;
    Console.WriteLine("emp Wage :" + empWage);*/

    /*public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    static void Main(string[] args)
    {
        int empHrs = 0, empWage = 0, totalEmpWage = 0;
        for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            totalEmpWage += empWage;
            Console.WriteLine("Emp Wage : " + empWage);
        }
        Console.WriteLine("Total Emp Wage : " + totalEmpWage);*/

    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
    public const int EMP_RATE_PER_HOUR = 20;
    public const int NUM_OF_WORKING_DAYS = 2;
    public const int MAX_HRS_IN_MONTH = 10;
    static void Main(string[] args)
    {
        int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
        while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            totalWorkingDays++;
        Random random = new Random();
        int empCheck = random.Next(0, 3);
        switch (empCheck)
        {
            case IS_PART_TIME:
                empHrs = 4;
                break;
            case IS_FULL_TIME:
                empHrs = 8;
                break;
            default:
                empHrs = 0;
                break;
        }
        totalEmpHrs += empHrs;
        Console.WriteLine("Days:" + totalWorkingDays + "Emp Hrs :" + empHrs);
    }
     int totalEmpwage = totalEmpHrs * EMP_RATE_PER_HOUR;
      Console.writeLine("Total Emp Wage : " + totalEmpWage);

 }
