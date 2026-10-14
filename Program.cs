using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Program
    {
        static void Main()
        {
        public class MaglevControl
        {
            public static void ForecastSpeedDrop(double currentSpeed, double airDensity, int seconds, out double newSpeed)
            {
                if (seconds <= 0)
                {
                    newSpeed = currentSpeed;
                    return;
                }

                // Нелинейное падение скорости из-за аэродинамического сопротивления
                double dragForce = currentSpeed * airDensity * 0.01; // Упрощённое моделирование
                double newSpeedValue = currentSpeed - dragForce;
                newSpeed = newSpeedValue;

                ForecastSpeedDrop(newSpeed, airDensity, seconds - 1, out newSpeed);
            }
        }
    }
}