# 0x0D. C# - Text-based Interface

## Tasks:

#### Task 0. Base knowledge

Create a new solution called InventoryManagement. In the solution, add a new .NET class library project called InventoryLibrary.

Within the InventoryLibrary, create a class called BaseClass that all other classes will inherit from. BaseClass should define:

* Properties:
    * id - string
    * date_created - DateTime
    * date_updated - DateTime

#### Task 1. Taking inventory
Within the InventoryLibrary, create a class called Item that inherits from BaseClass. Item should define:

* Required properties
    * name - string
* Optional properties
    * description - string
    * price - float, limit to 2 decimal points
    * tags - a list of strings

Within the InventoryLibrary, create a class called User that inherits from BaseClass. User should define:

* Required properties
    * name - string

Within the InventoryLibrary, create a class called Inventory that inherits from BaseClass. Inventory should define:

* Required properties
    * user_id - from User id
    * item_id - from Item id
    * quantity - int, default value: 1, cannot be less than 0

A required property [b]must[/b] have a value on creation, it cannot be left blank

#### Task 2. In Store
With our classes defined, let’s create our storage class. Create a class called JSONStorage. JSONStorage should define:

* Properties:
    * objects - dictionary where keys are [ClassName].[id] and values are the objects
* Methods:
    * All() - return objects dictionary
    * New(obj) - add a new key-value pair to objects
    * Key: [obj ClassName].[obj id]
    * Value: obj
    * Save() - serializes objects to JSON and saves to the JSON file
    * Load() - deserializes JSON file to objects

Use the built-in JSON namespace for serialization/deserialization.

The JSON file should be located in a directory named storage and the file named inventory_manager.json.

#### Task 3:
Time to create the console application! Add a new console application called InventoryManager to the solution and add a reference to the InventoryLibrary.

The console application should:

* On start, load all objects from JSONStorage
    * There should only be one instance of JSONStorage during the runtime of the console application
* Print an initial prompt with the available commands and their usage. Example:

Inventory Manager
-------------------------
[ClassNames] show all ClassNames of objects
[All] show all objects
[All [ClassName]] show all objects of a ClassName
[Create [ClassName]] a new object
[Show [ClassName object_id]] an object
[Update [ClassName object_id]] an object
[Delete [ClassName object_id]] an object
[Exit]

* Take user input from the command line using the Console namespace
    * ClassNames
        * Print all class names of objects loaded in JSONStorage
    * All
        * Print all objects
    * All [ClassName]
        * Print all objects of the given ClassName
    * Create [ClassName]
        * Create and save a new object of ClassName
    * Show [ClassName] [id]
        * Print the string representation of the requested object
    * Update [ClassName] [id]
        * Update the properties of the given object
    * Delete [ClassName] [id]
        * Delete the given object from the JSONStorage
    * Exit
        * Quit the application

* For all commands that take options, if the user input is invalid, print the following errors:
    * If the given ClassName is invalid, print:
        * [ClassName] is not a valid object type
    * If the given id is invalid, print:
        * Object [id] could not be found
    * Input should not be case sensitive
* When a command is completed without error, print the initial prompt with command list again

#### Task 4. Test 1, 2, 3
Your project must have unit tests! The number of tests is less important than the quality and effectiveness of your tests. Make sure you’re checking your object operations, edge cases, all user input possibilities, etc.
