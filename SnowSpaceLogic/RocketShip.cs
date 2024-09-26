namespace SnowSpaceLogic;

public class RocketShip
{
    private string name;
    private int numberOfFins;

    public RocketShip(string name)
    {
        SetName(name);
    }

    public void SetNumberOfFins(int numFins)
    {
        if(numFins >= 0)
        {
            numberOfFins = numFins;
        }
    }

    public int GetNumberOfFins()
    {
        return numberOfFins;
    }

    public void SetName(string newName)
    {
        if (newName == null)
        {
            throw new Exception("new name cannot be null");
        }
        if (hasNoNumber(newName))
        {
            throw new Exception("Name must have a number");
        }
        name = newName;
    }

    bool hasNoNumber(string s)
    {
        int index = 0;
        while (s.Length > index)
        {
            if (char.IsDigit(s[index]))
            {
                return false;
            }
            index++;
        }
        return true;
    }

    public string GetName()
    {
        return name;
    }

    public string Takeoff()
    {
        if (name == "Doomed1")
        {
            return "Boom!";
        }

        return $"{name}: shhhkjshfdlkahmcueyiaehdfalilwueslkg";
    }
}
