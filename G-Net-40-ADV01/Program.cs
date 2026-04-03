using System.ComponentModel;
using System.Numerics;
using System.Reflection.Metadata;

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







        }
    }
}
