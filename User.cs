using System;

public class User
{
    private int id;
    private string name;
    private int contact;
    private DateTime dob;

    public User(int id, string name, int contact, DateTime dob)
    {
        this.id = id;
        this.name = name;
        this.contact = contact;
        this.dob = dob;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Contact
    {
        get { return contact; }
        set { contact = value; }
    }

    public DateTime Dob
    {
        get { return dob; }
        set { dob = value; }
    }

    public override string ToString()
    {
        return $"ID: {id}, Name: {name}, Contact: {contact}, Date of Birth: {dob.ToShortDateString()}";
    }
}



