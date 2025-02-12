using System;
using Gtk;

namespace lab4
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var application = new Application("bondarenkoi07.lab4", GLib.ApplicationFlags.None);
            var mainWindow = new MainWindow();
            
            application.Register(GLib.Cancellable.Current);
            application.AddWindow(mainWindow);
            mainWindow.Show();
            Application.Run();
        }
    }
}