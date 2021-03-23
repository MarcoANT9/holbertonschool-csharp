# 0x0B. C# - Interfaces

## Tasks:

#### Task 0. Abstract thinking 
Create an abstract class called Base containing the following:

* Public property name
    * Name should be a string
* Override ToString() method to return the following:
    * <name> is a <type> (ex. Garden Gate is a Door)


#### Task 1. User interface
Based on 0-abstract_thinking, create an interface called IInteractive.

* Method void Interact()

Create an interface called IBreakable

* Property durability
    * Durability should be an int
* Method void Break()

Create an interface called ICollectable.

* Property isCollected
    * isCollected should be a bool
* Method void Collect()

You do not need to fully implement the methods for this task.

Create a new class called TestObject that inherits from Base and all three interfaces.

#### Task 2. Escape room
Based on 1-user_interface, delete the TestObject class. Create a new class called Door that inherits from Base and IInteractive.

* Define constructor that sets the value of name
    * If name isn’t provided, the default value should be Door
* Implement Interact() so that it prints:
    * You try to open the <name>. It's locked.


#### Task 3. Interior decorating
Based on 2-doors, create a new class called Decoration that inherits from Base, IInteractive, and IBreakable.

* Add public bool isQuestItem
* Define constructor that sets the value of name, durability, and isQuestItem
    * the method declaration should use name, durability, and isQuestItem as the parameter names (why?)
    * if name isn’t provided, the default value should be Decoration
    * if durability isn’t provided, the default value should be 1
    * if durability is 0 or less, throw an exception that states Durability must be greater than 0
    * if isQuestItem isn’t provided, the default value should be false
* Implement Interact()
    * if the durability is 0 or less, print:
        * The <name> has been broken.
    * otherwise, if isQuestItem is true, print:
        * You look at the <name>. There's a key inside.
    * if isQuestItem is false, write:
        * You look at the <name>. Not much to see here.
* implement Break() so that it decrements durability by 1
    * if durability is greater than 0, print:
        * You hit the <name>. It cracks.
    * if durability is 0, print:
        * You smash the <name>. What a mess.
    * if durability is less than 0, print:
        * The <name> is already broken.

#### Task 4. Key collecting
Based on 3-decorations, create a new class called Key that inherits from Base and ICollectable.

* Define constructor that sets the value of name and isCollected
    * The method declaration should use name and isCollected as the parameter names (why?)
    * if name isn’t provided, the default value should be Key
    * if isCollected isn’t provided, the default value should be false
* Implement Collect()
    * if isCollected is false, set it to true and print:
        * You pick up the <name>.
    * if isCollected is true, print:
        * You have already picked up the <name>.

#### Task 5. Iterate and act 
Based on 4-keys, create a new class called RoomObjects and a method called IterateAction. This method should take a list of all objects, iterate through it, and execute methods depending on what interface that item implements. (ex: if the item uses IInteractive, your IterateAction method should call Interact() on it)

* Class: RoomObjects
* Prototype: public static void IterateAction(List<Base> roomObjects, Type type)

#### Task 6. Better iterating and acting
Based on 5-iterate_act, remove the RoomObjects class created in the previous task. Create a new generic class Objs<T> that creates a collection of type T objects that can be iterated through using foreach.

* Class: Objs<T>
* Objs<T> must inherit from and implement IEnumerable<T>


