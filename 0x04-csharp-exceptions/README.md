# 0x04. C# - Exceptions

## Tasks:

#### Task 0. Safe list printing
Write a method that prints n elements of a list.

* Class Name: List
* Prototype: public static int SafePrint(List<int> myList, int n)
* n represents the number of elements to print
* n can be bigger than the length of myList
* Returns number of elements actually printed
* You have to use try / catch


#### Task 1. Integer division
Write a function that divides 2 integers and prints the result.

* Class Name: Int
* Prototype: public static void divide(int a, int b)
* You can assume that a and b are integers
* You have to use try / catch / finally
* The result of the division should print in the finally section in the format shown in the example

#### Task 2. Divide lists
Write a function that divides element by element 2 lists.

* Class Name: List
* Prototype: public static List<int> Divide(List<int> list1, List<int> list2, int listLength) length can be bigger than the length of either list
* Returns a new list of all division results
* If 2 elements can’t be divided, the division result should be equal to 0
* If the division can’t be done (dividing by 0):
** print Cannot divide by zero
* If either list is too short:
** print Out of range
* You have to use try / catch

#### Task 3. Throw exception
Write a function that throws an Exception.

* Class Name: Except
* Prototype: public static void Throw()


#### Task 4. Throw exception with message
Write a method that throws an Exception with a message.

* Class Name: Except
* Prototype: public static void ThrowMsg(string msg)