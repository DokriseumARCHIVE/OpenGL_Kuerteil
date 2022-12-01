using OpenTK.Graphics.OpenGL4;
using OpenTK.Windowing.Desktop;

namespace OpenGL_Kuerteil;

public class ObjectExa : GameWindow
{
    private int _program;

    public ObjectExa(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings) : base(gameWindowSettings, nativeWindowSettings)
    {
        _program = 0;
    }
    public ObjectExa(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings, int program) : base(gameWindowSettings, nativeWindowSettings)
    {
        _program = program;
    }

    private int CompileShaders()
    {
        var vertexShader = GL.CreateShader(ShaderType.VertexShader);
        GL.ShaderSource(vertexShader, File.ReadAllText(@"Components\Shaders\vertexShader.vert"));
        GL.CompileShader(vertexShader);

        var fragmentShader = GL.CreateShader(ShaderType.FragmentShader);
        GL.ShaderSource(fragmentShader, File.ReadAllText(@"Components\Shaders\fragmentShader.frag"));
        GL.CompileShader(fragmentShader);

        var program = GL.CreateProgram();
        GL.AttachShader(program, vertexShader);
        GL.AttachShader(program, fragmentShader);
        GL.LinkProgram(program);

        GL.DetachShader(program, vertexShader);
        GL.DetachShader(program, fragmentShader);
        GL.DeleteShader(vertexShader);
        GL.DeleteShader(fragmentShader);
        return program;
    }
    protected override void OnLoad()
    {
        CursorVisible = true;
        _program = CompileShaders();
        Closed += OnClosed;
    }
    private void OnClosed(object sender, EventArgs eventArgs)
    {
        Exit();
    }

    public void Exit()
    {
     GL.DeleteProgram(_program);
     //base.Exit();
    }
}