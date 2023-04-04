using System;

class Program
{
    public enum Days
{
        Monday,  
        Tuesday,  
        Wednesday,  
        Thursday,  
        Friday,  
        Saturday,  
        Sunday
}

    static void Main() {
        
        // Mode 1
        int mondayValue=(int)Days.Monday; //0
        int tuesdayValue=(int)Days.Tuesday; //1
        int wednesdayValue=(int)Days.Wednesday; //2
        int thursdayValue=(int)Days.Thursday; //3
        int fridayValue=(int)Days.Friday; //4
        int saturdayValue=(int)Days.Saturday; //5
        int sundayValue=(int)Days.Sunday; //6
        Console.WriteLine(mondayValue);
        
        // Mode 2
        int mondayValue=Convert.ToInt32(Days.Moday); //0
        Console.WriteLine(mondayValue);
        
        
    }
}