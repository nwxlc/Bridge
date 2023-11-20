namespace Bridge;

public interface IRemoteControl
{
    void TurnOn();
    void TurnOff();
    void SetPower(int power);
    void SetMode(int mode);
    
}