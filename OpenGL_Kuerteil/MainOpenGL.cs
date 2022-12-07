using System.Runtime.InteropServices;
using OpenGL_Kuerteil.Tutorial;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Windowing.Common.Input;
using OpenTK.Windowing.Desktop;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Image = SixLabors.ImageSharp.Image;

// See https://aka.ms/new-console-template for more information
namespace OpenGL_Kuerteil;
public class MainOpenGL
{
    private float angleX = 0.0f;
    private float angleY = 0.0f;
    private float angleZ = 0.0f;
    private float rotate_arm_buttom = 0.0f;
    private float rotate_arm_middle = 0.0f;
    private float rotate_arm_top = 0.0f;
    private float rotate_arm_horizon = 0.0f;
    
    [STAThread]
    public static void Main()
    {
        Main mains = new Main(1280, 720, "Tutorial OpenGL Kuerteil");
        mains.Run();
        /*
        GameWindowSettings gws = GameWindowSettings.Default;
        NativeWindowSettings nws = NativeWindowSettings.Default;
        gws.IsMultiThreaded = false;
        gws.RenderFrequency = 60.0;
        gws.UpdateFrequency = 60.0;
        */

        /*
        // This line creates a new instance, and wraps the instance in a using statement so it's automatically disposed once we've exited the block.
        using (Planetsystem game = new Planetsystem(800, 600, "LearnOpenTK"))
        {
            //Run takes a double, which is how many frames per second it should strive to reach.
            //You can leave that out and it'll just update as fast as the hardware will allow it.
            game.Run();
        }
        Console.WriteLine("Hello, World!");
        MainWindow mw = new MainWindow(GameWindowSettings.Default,NativeWindowSettings.Default);
        mw.Run();
        */

    }
}