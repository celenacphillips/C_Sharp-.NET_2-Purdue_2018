using System;
public class Dog : Mammal
{
    private string name = "";
    private string breed = "";
    private string hairColor = "";
    private string hairLength = "";
    private string barkSound = "";

    //Internal method
    private string Bark ()
    {
        return barkSound;                
    }




    //Setter
    public void SetName (string newName)
    {
        name = newName;
    }

    //Setter
    public void SetBreed (string newBreed)
    {
        breed = newBreed;
    }

    //Setter
    public void SetHairColor (string newColor)
    {
        hairColor = newColor;
    }

    //Setter
    public void SetHairLength (string length)
    {
        hairLength = length;
    }

    //Setter
    public void SetBarkSound (string sound)
    {
        barkSound = sound;
    }




    //Method
    public void Speak()
    {
        Bark();
    }

    //Method
    public void Sit()
    {
        Move("sitting");
    }

    //Method
    public void Run()
    {
        Move("running");
    }

    //Method
    public void Stand()
    {
        Move("standing");
    }




    //Getter
    public string GetName()
    {
        return name;
    }

    //Getter
    public string GetBreed()
    {
        return breed;
    }

    //Getter
    public string GetHairColor()
    {
        return hairColor;
    }

    //Getter
    public string GetHairLength()
    {
        return hairLength;
    }

    //Getter
    public string GetBarkSound()
    {
        return barkSound;
    }

    //Getter
    public string GetMovement()
    {
        return ReturnMovement();
    }
}