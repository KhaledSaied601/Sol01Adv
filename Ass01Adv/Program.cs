using System.Numerics;

namespace Ass01Adv
{


    class Employee:IComparable<Employee>,ISubtractionOperators<Employee,Employee,int>
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public decimal Salary { get; set; }

        public Employee(int id,string name,decimal salary) 
        {

            Id = id;
            Name = name;
            Salary = salary;
        
        }

        public int CompareTo(Employee? other)
        {
            

            return this.Id.CompareTo(other?.Id);


        }

        public static int operator -(Employee left, Employee right)
        {
            return left.Id - right.Id;
        }
    }


    internal class Program
    {
        #region 1- The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm

        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }

       static void BubbleSort(int[] arr)
        {
            if (arr == null) return;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {

                    if (arr[j] > arr[j + 1]) 

                        Swap(ref arr[j], ref arr[j + 1]);

                }
            }

        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 1- The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm



            //int x = 5, y = 10;
            //Swap(ref x, ref y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //int[] arr = { 10, 2, 13, 8, 1 };
            //BubbleSort(arr);

            //for (int i = 0; i < arr.Length; i++)
            //    Console.WriteLine(arr[i]);

            #endregion


            #region 2- create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range. 

            //Range<Employee>.MaxValue = new Employee(10, "Khaled", 5000);
            //Range<Employee>.MinValue = new Employee(5, "Elbahedy", 50000);

            //Console.WriteLine(Range<Employee>.IsInRange(new Employee(7, "Saied", 200)));
            //Console.WriteLine(Range<Employee>.GetLength());

            #endregion
        }
    }
}
