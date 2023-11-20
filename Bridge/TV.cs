namespace Bridge;

public class TV : IRemoteControl
{
    public void TurnOn()
    {
        Console.WriteLine("Телевизор включен.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Телевизор выключен.");
    }

    public void SetPower(int power)
    {
        if (power > 0)
        {
            Console.WriteLine($"Громкость телевизор установлена на {power}");
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
            Console.WriteLine($"Режим телевизора установлен на {mode}");
        }
        else
        {
            throw new ArgumentException("Значение 'режима' не может быть равно 0 и отрицательно.", nameof(mode));
        }
    }
}