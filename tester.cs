using System;
namespace CSCD349Project
{
    public class tester
    {
        public static void Main(string[] args)
        {
            Map thisMap = new Map(new int[] {10,10});
            Party thisParty = new Party("party one", thisMap.GetCellAt(3,3));
            Console.WriteLine(thisParty);
        }
    }
}