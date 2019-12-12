using System;
using System.Windows;
using System.Windows.Media;

namespace ProjectileMotion
{
    public class ProjectileMotionCalculator
    {
        private readonly double _angleSin;
        private readonly double _angleCos;
        private readonly double _speed;
        private readonly double _sampling;
        private const double Gravity = 9.81;

        public ProjectileMotionCalculator(double angle, double initialSpeed, double sampling)
        {
            if (angle > 90 || angle < 0) throw new Exception("Invalid angle value.");
            if (initialSpeed > 1000 || initialSpeed < 0) throw new Exception("Invalid speed value.");
            if (sampling <= 0) throw new Exception("Sampling equal or lesser than 0.");
            angle = ToRadians(angle);
            _angleSin = Math.Sin(angle);
            _angleCos = Math.Cos(angle);
            _speed = initialSpeed;
            _sampling = 1 / sampling;
        }

        public PointCollection CountMotion()
        {
            PointCollection motion = new PointCollection();
            double currentX;
            double currentY;
            double time = 0;

            do
            {
                currentX = CalculateX(time);
                // multiplication by -1 because otherwise graph would be upside down
                currentY = -1 * CalculateY(time);
                motion.Add(new Point(currentX, currentY));
                time += _sampling;
            } while (currentY <= 0);

            return motion;
        }

        private double CalculateX(double time) => _speed * _angleCos * time;

        private double CalculateY(double time) => _speed * _angleSin * time - 0.5 * Gravity * Math.Pow(time, 2);

        private static double ToRadians(double angle) => angle * Math.PI / 180;
    }
}