/*
public class TankAction
{
    public void tankMethod()
    {
        Tank    tank1 = new Tank();
        int     tankSpeed;
        string  inputSpeedInfo = "Введите скорость танка:";

        Console.WriteLine(inputSpeedInfo);
        tankSpeed = int.Parse(Console.ReadLine());
        
        tank1.Speed = tankSpeed;
        tank1.MoveRight();
        tank1.MoveRight();
        Console.WriteLine(tank1.GetPositionX());
    }
}

class Tank
{
    public int Speed;
    private int _positionX;
    public void MoveLeft()
    {
        _positionX -= Speed;
    }
    public void MoveRight()
    {
        _positionX += Speed;
    }

    public int GetPositionX()
    {
        return _positionX;
    }
}
*/

class Boundary
{
    public bool IsAvailable(int positionX)
    {
        bool ret;
        if(positionX > 100 || positionX < 0)
            ret = false;
        else
            ret = true;
        return ret;
    }
}

class Tank_2
{
    public int Speed;
    private int _positionX;
    private Boundary _boundary;

    public Tank_2(int speed, int positionX)
    {
        Speed = speed;
        _positionX = positionX;
    }

    public void TankBoundary(Boundary boundary)
    {
        _boundary = boundary;
    }
    public void MoveLeft()
    {
        Move(Speed * -1);
    }
    public void MoveRight()
    {
        Move(Speed);
    }

    private void Move(int delta)
    {
        if (_boundary.IsAvailable(_positionX + delta))
        {
            _positionX += delta;
            _boundary.IsAvailable(10);
        }
        
    }
    public int GetPositionX()
    {
        return _positionX;
    }
}
