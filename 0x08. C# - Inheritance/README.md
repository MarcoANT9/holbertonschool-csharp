# 0x08. C# - Inheritance

## Tasks:

#### Task 0. This is one of these
Write a method that returns True if the object is an int, otherwise return False.

* Class: Obj
* Prototype: public static bool IsOfTypeInt(object obj)

#### Task 1. For instance
Write a method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.

* Class: Obj
* Prototype: public static bool IsInstanceOfArray(object obj)

#### Task 2. Only subclass
Write a method that returns True if the object is an instance of a class that inherits from the specified class, otherwise return False. The object must be a subclass; your method cannot return True if the object is an instance of the base class.

* Class: Obj
* Prototype: public static bool IsOnlyASubclass(Type derivedType, Type baseType)

#### Task 3. Type
Write a method that prints the names of the available properties and methods of an object.

* Class: Obj
* Prototype: public static void Print(object myObj)

References:
* [TypeInfo Class] <https://intranet.hbtn.io/rltoken/-Zh3a1z8f_FKtWOHA1pRPg>
* [PropertyInfo Class] <https://intranet.hbtn.io/rltoken/VWXS7JiUbql6Yn1hQ4qXqg>
* [MethodInfo Class] <https://intranet.hbtn.io/rltoken/iTsNiYm3K4ZCpaM9vv0gqw>

#### Task 4. It's not a lesson in classes and inheritance without a Dog
Write a empty class Dog that inherits from empty class Animal.

* Base Class: Animal
* Derived Class: Dog


#### Task 5. Basic shapes
Write a class Shape.

* Class: Shape
    * public method: public virtual int Area()
        * Throws an NotImplementedException with the message Area() is not implemented

#### Task 6. Rectangle
Based on 5-shape, write a class Rectangle that inherits from Shape.

* Class: Rectangle
    * private field: private int width
    * private field: private int height
    * public property: public int Width
        * get: retrieve width
        * set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
    * public property: public int Height
        * get: retrieve height
        * set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.

#### Task 7. Full rectangle
Based on 6-shape, write a class Rectangle that inherits from Shape.

* Class: Rectangle
    * private field: private int width
    * private field: private int height
    * public property: public int Width
        * get: retrieve width
        * set: if value is negative, throw an ArgumentException with the message Width must be greater than or equal to 0. Otherwise, set width to the value.
    * public property: public int Height
        * get: retrieve height
        * set: if value is negative, throw an ArgumentException with the message Height must be greater than or equal to 0. Otherwise, set Height to the value.
    * public method: public new int Area()
        * This will override the Area() method defined in the Shape base class. (Try changing new to override and run the program. What happens?) returns the area of the rectangle
    * public method: public override ToString()
        * returns [Rectangle] <width> / <height>

#### Task 8. Square #1
Based on 7-shape, write a class Square that inherits from Rectangle

* Class: Square
    * private field: private int size
    * public property: public int Size
        * get: retrieve size
        * set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, height, and width to the value.

#### Task 9. Square #2
Based on 8-shape, write a class Square that inherits from Rectangle

* Class: Square
    * private field: private int size
    * public property: public int Size
        * get: retrieve size
        * set: if value is negative, throw an ArgumentException with the message Size must be greater than or equal to 0. Otherwise, set size, Height, and Width to the value.
    * Area() should work without writing a new Area() method within your Square class
    * .ToString() should return [Square] <size> / <size>

#### Task 10. Lisko
In the previous tasks, we created a class Square that inherits from Rectangle. However, what happens if you try to assign a Square’s width and height directly.

Here we see there’s a flaw in our implementation of Square as inheriting from Rectangle. This is because this hierarchy violates [Liskov’s substitution principle] <https://intranet.hbtn.io/rltoken/Y4OBliliHK_G38LnNOM4Pg>. What would the ideal hierarchy involving Shape, Rectangle, and Square look like instead?

Write a blog post that explains the problem with implementing a Square class as a derived class of Rectangle. It should cover:

* what Liskov’s substitution principle is
* why Square inheriting from Rectangle is not an ideal design choice
* ways that this class hierarchy could be improved

Your posts should have examples and at least one picture, at the top. Publish your blog post on Medium or LinkedIn, and share it at least on Twitter and LinkedIn.

Please, remember that these blogs must be written in English to further your technical ability in a variety of settings.


#### Task 


#### Task 


#### Task 
