using NAudio.Wave;

namespace Little_Spotify_Helper_App {
    public partial class MainFormView : Form {
        public MainFormView() {
            InitializeComponent();

            var reader = new Mp3FileReader("Blade_-_Vampire_Dance_Club_Theme.mp3");
            var waveOut = new WaveOut(); // or WaveOutEvent()
            waveOut.Init(reader);
            waveOut.Play();
        }
    }
}
