namespace Bridge;

public class AirConditioner : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Кондиционер включен");
    }
    
    public void TurnOff()
    {
        Console.WriteLine("Кондиционер выключен");
    }
    
    public void SetPower(int power)
    {
        if (power > 0)
        {
            Console.WriteLine($"Уровень мощности кондиционера установлен на {power}%");
        }
        else
        {
            throw new ArgumentException("Значение 'мощности' не может быть равно 0 и отрицательно.", nameof(power));
        }
    }

    public void SetMode(int mode)
    {
        if (mode > 0)
        {
            Console.WriteLine("Режим кондиционера установлен на {0}", mode);
        }
        else
        {
            throw new ArgumentException("Значение 'режима' не может быть равно 0 и отрицательно.", nameof(mode));
        }
    }
}