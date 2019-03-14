using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csd3354_2_assignment_2__c0723889
//rupinderpalsingh c0723889
//ramandeepsingh brar c0730408
{ 
class Program
{
    static void Main(string[] args)
    {
        DelegateExercises delegateExercises = new DelegateExercises();

        delegateExercises.Method2();
    }
}


public class DelegateExercises
{
    public delegate void MyDelegate();
    void Method1()
    {
        Console.WriteLine("Method1");
        Console.ReadLine();
    }
    public void Method2()
    {
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
}
