using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;
using G_Net_40_ADV01.Genaric_Class;
using G_Net_40_ADV01.Genaric_Interface;
using G_Net_40_ADV01.Genaric_Method;
using G_Net_40_ADV01.Generic_Constraints;
using G_Net_40_ADV01.Pair_Genaic_Class;

namespace G_Net_40_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            // Q1: What is a generic class? Why use generics? 

            // Answer Q1:
            // What is a generic class?

            // A generic class uses type parameters that are replaced with actual types when you create an instance.
            // The type parameter T acts as a placeholder.

            //    Example: Generic Stack :

            //    internal class MyStack<T>
            //    {
            //    private T[] _items;
            //    private int _top;
            //    public int Count => _top;

            //    public MyStack(int capacity)
            //    {
            //        _items = new T[capacity];
            //        _top = 0;
            //    }
            //    //push
            //    public void Push(T item)
            //    {
            //        if (_top < _items.Length)
            //            _items[_top++] = item;
            //    }
            //    //pop
            //    public T? Pop()
            //    {
            //        if (_top > 0)
            //        {
            //            var item = _items[--_top];
            //            _items[_top] = default;
            //            return item;
            //        }
            //        return default;
            //    }
            //    //peek
            //    public T? Peek() => _items[_top - 1];

            //    //override ToString
            //    public override string ToString() => $"{_items[_top]}";
            //}

            //----------------------------------------------------------------------------------------------

            // Using the Generic Stack :
            // MyStack<int> myStack = new MyStack<int>(5);

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);

            ////Console.WriteLine(myStack.Count);

            ////Console.WriteLine(myStack.Peek());
            ////Console.WriteLine(myStack.Count);

            //myStack.Pop();
            //Console.WriteLine(myStack.Count);
            //-----------------------------------------------------------------------------------------------

            // Why use generics ?

            // Answer:
            // Before generics, we had two bad choices: duplicate code for each type,
            // or use object and lose type safety + performance.

            // Benifites of Genarics:
            // Type Safety: الـ compiler بيكشف الأخطاء وقت الـ compile مش الـ runtime
            // Code Reuse: كود واحد بيشتغل مع أي type
            // Performance: مفيش boxing/unboxing للـ value types
            // IntelliSense : Better IDE support and discovery

            //------------------------------------------------------------------------------------------------
            #endregion

            #region Question 02
            //Q2: Write a generic class Container<T> with Add and Get methods.

            //Answer Q2:

            //var container01 = new G_Net_40_ADV01.Genaric_Class.Container<int>();

            //container01.Add(10);
            //container01.Add(20);

            //Console.WriteLine(container01.Count);   // 2
            //Console.WriteLine(container01.Get(0));  // 10
            //Console.WriteLine(container01.Get(5));  // 0 (القيمة الافتراضية)
            #endregion

            #region  Question 03

            //Q3:What are multiple type parameters? Write Pair<TKey, TValue>.


            //Answer Q3:

            //Multiple Type Parameters:
            //Generic classes can have multiple type parameters.
            //Common examples: Dictionary<TKey, TValue>, Tuple<T1, T2>

            // Apply Example : Pair<TKey, TValue>.

            //var emp01 = new Employee<int,string>(1,"Islam");
            //Console.WriteLine(emp01);
            ////----------------------------------------------------

            //Employee<int, string> emp02 = new(3, "Dina");
            //Console.WriteLine(emp02);
            #endregion


            #region Question 04

            //Q4: What is a generic method? Write Swap<T> method.

            // Answer Q4:
            // Generic Methods:
            // A generic method declares its own type parameter(s).
            // It can exist in both generic and non-generic classes.
            // The compiler often infers the type argument.


            //Apply Swap

            //int num01 = 10, num02 = 33;

            //Console.WriteLine("Before Swapping");

            //Console.WriteLine($"num01 = {num01}");
            //Console.WriteLine($"num02 = {num02}");
            //Console.WriteLine("==================================================");

            //Console.WriteLine("After Swapping");

            //Utilities.Swap(ref num01, ref num02); // 

            //Console.WriteLine($"num01 = {num01}");
            //Console.WriteLine($"num02 = {num02}");

            //-------------------------------------------------------------------------------------------


            //string name01 = "ahmed", name02 = "ali";

            //Console.WriteLine("Before Swapping");

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"name02 = {name02}");
            //Console.WriteLine("==================================================");

            //Console.WriteLine("After Swapping");

            //Utilities.Swap(ref name01, ref name02); // 

            //Console.WriteLine($"name01 = {name01}");
            //Console.WriteLine($"name02 = {name02}");
            #endregion

            #region Question 05

            //Q5: Write a generic method FindMax<T> that finds maximum value

            //Answer Q5:

            //int[] numbers = { 11, 22, 33, 4, 54, 60, 7, 81, };

            //Console.WriteLine(Utilities.FindMaxValue(numbers));
            //-----------------------------------------------------------------------------------------
            //Developer[] developers =
            //{
            //    new("Islam",9000),
            //    new("ALi",10000),
            //    new("Youssef",15000)
            //};

            //Console.WriteLine(Utilities.FindMaxValue(developers));

            #endregion

            #region Question 06

            // Q6: What is a generic interface? Write IRepository<T>. 

            //Answer Q6:

            // Generic Interfaces:
            // Generic interfaces define contracts with type parameters.
            // Classes implementing them specify the actual types.

            // Apply Genaric Interface

            //var prod01 = new G_Net_40_ADV01.Genaric_Interface.Product(111, "Iphone12Pro", 20000);
            //var prod02 = new G_Net_40_ADV01.Genaric_Interface.Product(144, "Lap-Top", 33000);
            //var prod03 = new G_Net_40_ADV01.Genaric_Interface.Product(100, "Note Book", 100);

            //ProductRepository productRepository = new ProductRepository();
            //productRepository.Add(prod01);
            //productRepository.Add(prod02);
            //productRepository.Add(prod03);

            //--------------------------------------------------------------------------------------------

            //foreach (var item in  productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------

            //Console.WriteLine(productRepository.GetById(111));

            //--------------------------------------------------------------------------------------------
            //productRepository.Delete(prod01);


            //foreach (var item in productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}

            //--------------------------------------------------------------------------------------------

            //productRepository.Update(new Product(100,"Pen",12));

            //foreach (var item in productRepository.GetAll())
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question 07
            // Q7: What is the 'struct' constraint? Write an example.

            //Answer Q7:

            // Constraint: struct (Value Types):
            // where T : struct restricts T to value types only.
            // Useful when you need value semantics (copy, no null).

            // where T : struct => T must be a value type

            // Apply Constraint: struct 

            // var box = new ConstraintStruct<int> { Value = 42 }; // valid int is value type
            // new ConstraintStruct<string>(); //  Error - string is reference type
            #endregion

            #region Question 08

            // Q8: What is the 'class' constraint? Write an example.

            //Answer Q8:
            // Constraint: class (Reference Types):
            // where T : class restricts T to reference types only.
            // This allows T to be null and enables reference comparison.

            // where T : class => T must be a reference type

            //Appy Example about 'class' constraint:

            //var ConstrainClass = new ConstrainClass<string>();  //  string is class
            //ConstrainClass.Set("Hello");
            //// var bad = new ConstrainClass<int>();      //  int is struct!

            #endregion



        }
    }
}
