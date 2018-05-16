public class User{
    private Lights lights = new Lights();

    public void ChangeLight(string operation){
        Command command = new LightsCommand(lights, operation);
        command.Execute();
    }
}