class Program_1
{
    void tankMethod()
    {
        Tank    tank1 = new Tank();
        int     tankSpeed;
        string  inputSpeedInfo = "Введите скорость танка:";

        Console.WriteLine(inputSpeedInfo);
        tankSpeed = int.Parse(Console.ReadLine());
        
        tank1.Speed = tankSpeed;
        tank1.MoveRight();
        tank1.MoveRight();
        Console.WriteLine(tank1.PositionX);
    }
}

class Tank
{
    public int Speed;
    public int PositionX;
    public void MoveLeft()
    {
        PositionX -= Speed;
    }
    public void MoveRight()
    {
        PositionX += Speed;
    }
}