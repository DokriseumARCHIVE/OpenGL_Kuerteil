using OpenTK.Graphics.OpenGL;
using OpenTK;
using OpenTK.Windowing.Desktop;

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
        Console.WriteLine("Hello, World!");
        MainWindow mw = new MainWindow(GameWindowSettings.Default,NativeWindowSettings.Default);
        mw.Run();
    }
}