namespace Gyroscopio;

public partial class PagAcel : ContentPage
{
	public PagAcel()
	{
		InitializeComponent();
	}

    private void btiniciar(object sender, EventArgs e)
    {
		//Gyroscope
		Accelerometer.ReadingChanged += Acelini_Click;
		Accelerometer.Start(SensorSpeed.UI);
    }

    private void Acelini_Click(object sender, AccelerometerChangedEventArgs e)
    {
        acelx.Text= e.Reading.Acceleration.X.ToString();
        acely.Text= e.Reading.Acceleration.Y.ToString();
        acelz.Text= e.Reading.Acceleration.Z.ToString();
    }

    private void btparar(object sender, EventArgs e)
    {
        Accelerometer.ReadingChanged -= Acelini_Click;
        Accelerometer.Stop();
    }
}