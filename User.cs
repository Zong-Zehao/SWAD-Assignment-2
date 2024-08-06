using System;

public class User
{
    private int userId;
    private string name;
    private int contact;
    private DateTime dob;
    private string address;

    public User(int userId, string name, int contact, DateTime dob, string address)
    {
        this.userId = userId;
        this.name = name;
        this.contact = contact;
        this.dob = dob;
        this.address = address;
    }

    public int UserId
    {
        get { return userId; }
        set { userId = value; }
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

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    public override string ToString()
    {
        return $"ID: {userId}, Name: {name}, Contact: {contact}, Date of Birth: {dob.ToShortDateString()}, Address: {address}";
    }
}
