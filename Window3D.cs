using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Drawing;

namespace Varareanu
{
    class Window3D : GameWindow
    {
        private float objectX = 0.0f;
        private float objectY = 0.0f;
        private float objectSpeed = 0.02f;

        public Window3D() : base(800, 600)
        {
            KeyDown += Keyboard_KeyDown;
            MouseMove += OnMouseMove;
        }

        void Keyboard_KeyDown(object sender, KeyboardKeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                this.Exit();

            if (e.Key == Key.F11)
            {
                if (this.WindowState == WindowState.Fullscreen)
                    this.WindowState = WindowState.Normal;
                else
                    this.WindowState = WindowState.Fullscreen;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);

            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(-2.0, 2.0, -2.0, 2.0, 0.0, 4.0);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
          


            var keyboard = OpenTK.Input.Keyboard.GetState();

            if (keyboard.IsKeyDown(Key.Left))
            {
                objectX -= objectSpeed;
            }
            if (keyboard.IsKeyDown(Key.Right))
            {
                objectX += objectSpeed;
            }
            if (keyboard.IsKeyDown(Key.Up))
            {
                objectY += objectSpeed;
            }
            if (keyboard.IsKeyDown(Key.Down))
            {
                objectY -= objectSpeed;
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Translate(objectX, objectY, 0.0f);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(Color.SkyBlue);
            GL.Vertex2(-0.5f, 1.0f);
            GL.Color3(Color.DarkCyan);
            GL.Vertex2(0.0f, -0.5f);
            GL.Color3(Color.Azure);
            GL.Vertex2(0.5f, 0.5f);

            GL.End();

            this.SwapBuffers();
        }

        protected void OnMouseMove(object sender, MouseMoveEventArgs e)
        {
            objectX = (e.X / (float)Width) * 2 - 1;
            objectY = -((e.Y / (float)Height) * 2 - 1);
        }

    }
}
