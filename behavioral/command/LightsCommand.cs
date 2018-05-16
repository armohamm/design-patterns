public class LightsCommand : Command
{
    private Lights lights;

    private string operation;

    public string Operation { get => operation; set => operation = value; }

    public LightsCommand(Lights lights, string operation){
        this.lights = lights;
        this.operation = operation;
    }

    public override void Execute()
    {
        lights.LightOperation(operation);
    }


}