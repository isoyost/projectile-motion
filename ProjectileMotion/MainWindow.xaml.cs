using System;
using System.Windows;
using System.Windows.Media;

namespace ProjectileMotion
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DrawButton_OnClick(object sender, RoutedEventArgs routedEventArgs) => ProcessInput();

        private void MainWindow_OnSizeChanged(object sender, SizeChangedEventArgs sizeChangedEventArgs) =>  ProcessInput(false);

        private void ProcessInput(bool withExceptionDisplay = true)
        {
            double initialSpeed;
            double angle;
            double sampling;

            try
            {
                initialSpeed = double.Parse(InitialSpeedBox.Text);
                angle = double.Parse(AngleBox.Text);
                sampling = double.Parse(SamplingBox.Text);
            }
            catch (FormatException)
            {
                if (withExceptionDisplay) MessageBox.Show("Input data must be a number.");
                return;
            }

            if (ValidateValues(angle, initialSpeed, sampling))
            {
                DrawPolyline(angle, initialSpeed, sampling);
            }
        }

        private bool ValidateValues(double angle, double speed, double sampling)
        {
            bool areValuesValid = true;
            
            if (speed < 0)
            {
                InitialSpeedHintTextBlock.Foreground = Brushes.Red;
                areValuesValid = false;
            }
            else InitialSpeedHintTextBlock.Foreground = Brushes.Gray;
            
            if (angle > 90 || angle < 0)
            {
                AngleHintTextBlock.Foreground = Brushes.Red;
                areValuesValid = false;
            }
            else AngleHintTextBlock.Foreground = Brushes.Gray;
            
            if (sampling < 0)
            {
                SamplingHintTextBlock.Foreground = Brushes.Red;
                areValuesValid = false;
            }
            else SamplingHintTextBlock.Foreground = Brushes.Gray;

            return areValuesValid;
        }

        private void DrawPolyline(double angle, double speed, double sampling)
        {
            ProjectileMotionCalculator calculator = new ProjectileMotionCalculator(angle, speed, sampling);
            PointCollection motion = calculator.CountMotion();
            double height = Border.ActualHeight;
            ProjectileMotionPolyline.Points = AdjustToWindow(motion, height);
        }

        private static PointCollection AdjustToWindow(PointCollection pointCollection, double height)
        {
            PointCollection adjustedPointCollection = new PointCollection();

            foreach (Point point in pointCollection)
            {
                var y = point.Y + height - 2;
                var x = point.X;
                adjustedPointCollection.Add(new Point(x, y));
            }
            
            return adjustedPointCollection;
        }
    }
}