using System;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using static System.Formats.Asn1.AsnWriter;
namespace Ali_Ahmed_Ali_6
{





    struct Point
    {
        private int x, y;

        public Point()
        {
            x = 0; y = 0;
        }
        public Point(int x)
        {
            this.x = x;
        }


        public Point(int x, int y) : this(x)
        {
            this.y = y;
        }

        override public string ToString()
        {
            return $"({x}, {y})";
        }


    }


    public class TypeA
    {
        private int f;
        internal int G;
        public int h;
        internal protected int x;

        public TypeA()
        {
            f = 1;//ok
            G = 2;//ok
            h = 3;//ok
        }
    }

    struct Employee
    {

        private int empId; private string name; private int salary;

        string GetName()
        {
            return this.name;
        }



        public int Salary
        {
            get { return salary; }
            set
            {
                salary = value;
            }
        }


        public int EmpId
        {
            get { return empId; }
            set
            {
                empId = value;
            }
        }

    }






    internal class Program
    {
        public static void Main(string[] args)
        {
            TypeA t1 = new TypeA();

            t1.G = 10;
            t1.h = 20;
            t1.x = 30;
            //t1.f = 30;  //Error


            Point p1 = new Point(5);// x = 5, y = 0
            Point p2 = new Point(10, 20);// x = 10, y = 20;

            Console.WriteLine(p1.z);
        }


    }

    //Why can't a struct inherit from another struct or class in C#? 
    //because they are value types, not designed for inheritance, and their primary purpose is to be lightweight and efficient

    //Question: How do access modifiers impact the scope and visibility of a class member?
    //public: Accessible from anywhere.
    //private: Accessible only within the same class.
    //protected: Accessible within the same class and its derived classes.
    //internal: Accessible within the same assembly.
    //protected internal: Accessible within the same assembly or derived classes.
    //private protected: Accessible within the same class or derived classes in the same assembly

    //Question: Why is encapsulation critical in software design?

    //Encapsulation is critical in software design because it protects data integrity,
    //hides implementation details, and ensures modularity, allowing controlled access to class members
    //through methods or properties.This enhances security, maintainability, and flexibility in the code


    //Question: what is constructors in structs
    //Constructors in structs are special methods used to initialize the fields of a struct


    //Question: How does overriding methods like ToString() improve code readability?
    //by providing a clear, customized representation of an object's state



    //What is copy constructor?
    //is a special constructor that creates a new object as a copy of an existing object,
    //it initializes a new object with the values of another object of the same type


    //What is Indexer, when used, as business mention cases u have to utilize it?
    //An indexer allows objects to be accessed like arrays using custom indexing syntax.
    //It is useful for simplifying data access in collections, encapsulating data, and implementing custom collections
    //cases:
    //Product Management: Access products by index or ID.
    //Inventory Systems: Access stock items by location or ID.
    //Financial Systems: Access transactions by date or ID

    //Keywords:
    //class, struct, internal, public, private, protected, override, get, set, this

}

