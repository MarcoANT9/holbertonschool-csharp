# 0x06. C# - Classes and Namespaces

## Tasks:

#### Task 0. Braaainsss
Create a new namespace Enemies. Create an empty public class Zombie within Enemies that defines a zombie.

#### Task 1. Healthy competition
Based on 0-enemy, write a public class Zombie that defines a zombie by:

* public field health
* health should be an int and have no value
* public constructor: public Zombie()
    * sets the value of health to 0

#### Task 2. Health validation
Based on 1-enemy, write a public class Zombie that defines a zombie by:

* public field health
* health should be an int and have no value
* public constructor: public Zombie()
    * sets the value of health to 0
* a new public constructor: public Zombie(int value)
    * value must be greater than or equal to 0
    * if value is less than 0, throw an ArgumentException with the message Health must be greater than or equal to 0

#### Task 3. Zombie health
Based on 2-enemy, write a public class Zombie that defines a zombie by:

* __private__ field health
* health should be an int and have no value
* public constructor: public Zombie()
    * sets the value of health to 0
* public constructor: public Zombie(int value)
    * value must be greater than or equal to 0
*public method public int GetHealth() that returns the value of health of the Zombie object

#### Task 4. Hello, my name is
Based on 3-enemy, write a public class Zombie that defines a zombie by:

* private field health
* health should be an int and have no value
* public constructor: public Zombie()
    * sets the value of health to 0
* public constructor: public Zombie(int value)
    * value must be greater than or equal to 0
* private field name
* name should be a string and have a default value of (No name)
* public property Name
    * get: retrieve name
    * set: set name
* public method public int GetHealth() that returns the value of health of the Zombie object

#### Task 5. Printing a zombie
Based on 4-enemy, write a public class Zombie that defines a zombie by:

* private field health
* health should be an int and have no value
* public constructor: public Zombie()
    * sets the value of health to 0
* public constructor: public Zombie(int value)
    * value must be greater than or equal to 0
* private field name
* name should be a string and have a default value of (No name)
* public property Name
    * get: retrieve name
    * set: set name
* public method public int GetHealth() that returns the value of health of the Zombie object
* public .toString() override that prints the Zombie object’s attributes to stdout
    * Format: Zombie name: <name> / Total Health: <health>