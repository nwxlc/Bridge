namespace Bridge;

public class MemoryRemoteControl : RemoteControl
{
    private Dictionary<int, (int Power, int Mode)> memory = new Dictionary<int, (int Power, int Mode)>();

    public MemoryRemoteControl(IRemoteControl remote) :
        base(remote)
    {
        ArgumentNullException.ThrowIfNull(Remote);
    }

    public void Save(int index)
    {
        if (index <= 0)
        {
            throw new ArgumentException("index должен быть положительным числом", nameof(index));
        }

        memory[index] = (Power, Mode);
        Console.WriteLine($"Сохраненный режим {index}: Мощность {Power}, Режим {Mode}");
    }
    
    public void Load(int index)
    {
        if (index <= 0)
        {
            throw new ArgumentException("index должен быть положительным числом", nameof(index));
        }

        if (memory.ContainsKey(index))
        {
            var d = memory[index];
            int savedPower = d.Power;
            int savedMode = d.Mode;

            Power = savedPower;
            Mode = savedMode;
            Remote.SetPower(Power);
            Remote.SetMode(Mode);
            Console.WriteLine($"Загруженный режим {index}: Мощность {Power}, Режим {Mode}");
        }
        else
        {
            Console.WriteLine($"Режим с индексом {index} не найден.");
        }
    }
}