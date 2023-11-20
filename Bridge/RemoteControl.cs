namespace Bridge;

public class RemoteControl
{
    protected IRemoteControl Remote { get; private set; }
    public int Power { get;  set; }
    public int Mode { get;  set; }

    public RemoteControl(IRemoteControl Remote)
    {
        ArgumentNullException.ThrowIfNull(nameof(Remote));
        this.Remote = Remote;
    }
}