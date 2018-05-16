using System;

public class Lights
{

    private bool? isOn = null;

    public void LightOperation(string status)
    {
        switch (status)
        {
            case "ON":
            isOn = true;
                break;
            case "OFF":
            isOn = false;
                break;
            default:
            isOn = null;
                break;
        }

        Console.WriteLine(isOn == null ? "Nothing was done." : String.Format("Light is {0}", status));
    }
}