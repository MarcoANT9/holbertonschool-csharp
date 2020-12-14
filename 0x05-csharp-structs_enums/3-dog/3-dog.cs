using System;

public enum Rating
{
    Good,
    Great,
    Excellent,
}

public struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string name, float age, string owner, Rating rating)
    {
        this.name = name;
        this.age = age;
        this.owner = owner;
        this.rating = rating;
    }

    public override string ToString()
    {
        string ret_str = $"Dog name: {name.ToString()}\nAge: {age.ToString()}\nOwner: {owner.ToString()}\nRating: {rating.ToString()}";
        return ret_str;
    }
}