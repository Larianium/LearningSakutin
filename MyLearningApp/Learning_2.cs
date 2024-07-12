//________________________________________________________________
//Пример
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

//________________________________________________________________
//Пример
/*
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
*/

//________________________________________________________________
//Пример
/*
class Gun
{
    public int CurrentBullet { get; private set; }
    public List<int> Bullets { get; private set; }

    public Gun(List<int> bullets = null) 
    {
        Bullets = bullets ?? new List<int>();
        CurrentBullet = 0;
    }

    public void Shot()
    {
        if (CurrentBullet >= Bullets.Count)
            return;

        Console.WriteLine(Bullets[CurrentBullet]);
        CurrentBullet++;
    }
    public void Reload(List<int> bullets = null)
    {
        Bullets = bullets ?? new List<int>();        
        CurrentBullet = 0;  
    }
}
*/

//________________________________________________________________
//Пример
// class Warrior
// {
//     public int Health;
//     public int Armor;
//     public Warrior(int health, int armor)
//     {
//         Health = health;
//         Armor = armor;
//     }
//     public void TakeDamage(int damage)
//     {
//         Health -= damage - Armor;
//         Console.WriteLine($"Жизнь: {Health}");
//     }
// }

// class Knight : Warrior
// {
//     public Knight(int health, int armor) : base(health, armor) 
//     { 

//     }
//     public void Pray()
//     {
//         Armor += 1;
//         Console.WriteLine($"Жизнь: {Armor}");
//     }
// }

// class Barbarian : Warrior
// {
//     public int LenghtOfAxe;
//     public Barbarian(int health, int armor, int lenghtOfAxe) : base(health, armor)
//     {
//         LenghtOfAxe = lenghtOfAxe;
//     }

//     // public Barbarian(int armor, int lenghtOfAxe) : base(100, armor)
//     // {
//     //     LenghtOfAxe = lenghtOfAxe;
//     // }

//     public void Waaaagh()
//     {
//         Health += 10;
//         Armor -= 1;
//         Console.WriteLine($"Жизнь: {Health}");
//         Console.WriteLine($"Жизнь: {Armor}");
//     }
// }



class Player
{
    private float _health; 
    public Player(float health)
    {
        _health = health;
    }

    public void ApplyDamage(float amount)
    {
        _health -= amount;
    }
}
class Gun
{
    private int _bullets;
    private float _damage;
    public void Fire(Player player)
    {
        Console.WriteLine("Ввести количество патронов: ");
        _bullets = int.Parse(Console.ReadLine());
        if (_bullets <= 0)
            return;
        _damage = _bullets * 5;
        player.ApplyDamage(_damage);
        _bullets--; 
    }
}

class Battle
{
    private Gun _gun;
    private Player[] _players;
    public Battle(Gun gun, Player[] players)
    {
        _gun = gun;
        _players = players; 
    }
    public void Simulate()
    {
        foreach (var player in _players)
        {
            _gun.Fire(player);
        }
    }
}


