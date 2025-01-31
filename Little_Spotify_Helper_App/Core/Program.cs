namespace Little_Spotify_Helper_App.Core {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainFormView());
        }
    }
}