using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson26
{
    class Car
    {
        //константа для предоставленяи максимальной скорости
        public const int MaxSpeed = 100;

        //свойства автомобиля
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";

        //не вышел ли из строя автомобиль
        private bool _carIsDead;

        //в автомобиле имеется радиоприемник
        private readonly Radio _theMusicBox = new Radio();

        //конструкторы
        public Car() { }
        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }

        public void CrankTunes(bool state)
        {
            //делегировать запрос внутренему обьекту
            _theMusicBox.TurnOn(state);
        }

        //проверить не перегрелся ли автомобиль
        public void Accelerate(int delta)
        {
            if (_carIsDead)
            {
                Console.WriteLine("{0} is out of order...", PetName);
            }
            else
            {
                CurrentSpeed += delta;
                if (CurrentSpeed > MaxSpeed)
                {
                    CurrentSpeed = 0;
                    _carIsDead = true;
                    //использовать ключевое слово throw для генерации исключения 
                    throw new Exception($"{PetName} has overheated");
                }
            else
                {
                    Console.WriteLine("=> CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }


    }
}
