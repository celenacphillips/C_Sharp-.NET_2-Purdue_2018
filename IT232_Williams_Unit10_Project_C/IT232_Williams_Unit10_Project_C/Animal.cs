using System;
public class Animal
{
    private string position = "";

    //Method
    public void Move (string distance)
    {
        position = distance;
    }

    //Getter
    public string ReturnMovement ()
    {
        return position;
    }
}