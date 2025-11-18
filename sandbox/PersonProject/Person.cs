class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _weight;

    public Person(string firstName, string lastName, int age, int weight)
    {
        _firstName = firstName;
        _lastName = lastName;
        SetAge(age);
        SetWeight(weight);
    }

    public string GetPersonInformation()
    {
        return $"{_firstName} {_lastName}, {_age} years old and {_weight} pounds";
    }

    public void SetAge(int age)
    {
        if(age >0)
        
        _age = age;

        else

        _age = 0;
    }

    public void SetWeight(int weight)
    {
        if (weight > 0)

        _weight = weight;

        else

        _weight = 0;
    }
}
