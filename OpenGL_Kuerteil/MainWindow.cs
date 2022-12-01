using OpenTK;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

namespace OpenGL_Kuerteil
{
    public sealed class MainWindow : GameWindow
    {
        private int Width = 1280;
        private int Height = 720;
        public MainWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
        {
            Title += ": OpenGL Version: " + GL.GetString(StringName.Version);
        }

        protected override void OnResize(ResizeEventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnLoad()
        {
            CursorVisible = false;
            
        }
    }
}