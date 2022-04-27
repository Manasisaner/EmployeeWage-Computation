class Program
{ 
   static void Main(string[] args)
{
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

        int IS_PART_TIME = 1;
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
        Console.WriteLine("Emp Wage :" + empWage);


    }
}