using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System;
using System.Drawing;
using System.IO;

namespace Varareanu
{
    class Window3D : GameWindow

    {
        private Vector3 vertex1Color = new Vector3(1.0f, 0.0f, 0.0f); // Culoare pentru primul vârf (roșu)
        private Vector3 vertex2Color = new Vector3(0.0f, 1.0f, 0.0f); // Culoare pentru al doilea vârf (verde)
        private Vector3 vertex3Color = new Vector3(0.0f, 0.0f, 1.0f); // Culoare pentru al treilea vârf (albastru)

        private int selectedVertex = 1; // Vârful selectat inițial
        private float triangleRotation = 0.0f; // Unghiul inițial de rotație
        private float rotationSpeed = 100.0f; // Viteză de rotație
        private float colorChangeSpeed = 0.025f; // Viteză de schimbare a culorii



        public Window3D() : base(1920,1080, GraphicsMode.Default, "Triangle Color Change") { }

        protected override void OnLoad(EventArgs e)
        {
            GL.ClearColor(Color.MidnightBlue);

            // LAB 3 Citirea coordonatelor inițiale din fișierul text 
            if (File.Exists("triangle_coordinates.txt"))
            {
                string[] lines = File.ReadAllLines("triangle_coordinates.txt");

                if (lines.Length >= 3)
                {
                    string[] coordinates1 = lines[0].Split(' ');
                    string[] coordinates2 = lines[1].Split(' ');
                    string[] coordinates3 = lines[2].Split(' ');

                    if (coordinates1.Length == 2 && coordinates2.Length == 2 && coordinates3.Length == 2)
                    {
                        float x1 = float.Parse(coordinates1[0]);
                        float y1 = float.Parse(coordinates1[1]);

                        float x2 = float.Parse(coordinates2[0]);
                        float y2 = float.Parse(coordinates2[1]);

                        float x3 = float.Parse(coordinates3[0]);
                        float y3 = float.Parse(coordinates3[1]);

                    
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            var keyboard = OpenTK.Input.Keyboard.GetState();

            if (keyboard.IsKeyDown(Key.R))
            {
                selectedVertex = 1;
            }
            else if (keyboard.IsKeyDown(Key.G))
            {
                selectedVertex = 2;
            }
            else if (keyboard.IsKeyDown(Key.B))
            {
                selectedVertex = 3;
            }

            if (keyboard.IsKeyDown(Key.Escape))
            {
                this.Exit();
            }

            // LAB 3 Controlul rotației triunghiului
            if (keyboard.IsKeyDown(Key.A))
            {
                triangleRotation += rotationSpeed * (float)e.Time;
            }
            if (keyboard.IsKeyDown(Key.D))
            {
                triangleRotation -= rotationSpeed * (float)e.Time;
            }

            // LAB 3 Controlul culorii vârfurilor
            if (keyboard.IsKeyDown(Key.Up))
            {
                IncreaseColorValue(selectedVertex);
            }
            if (keyboard.IsKeyDown(Key.Down))
            {
                DecreaseColorValue(selectedVertex);
            }
        }

        private void IncreaseColorValue(int vertex) // LAB 3
        {
            switch (vertex)
            {
                case 1:
                    vertex1Color.X = Math.Min(1.0f, vertex1Color.X + colorChangeSpeed);
                    break;
                case 2:
                    vertex2Color.Y = Math.Min(1.0f, vertex2Color.Y + colorChangeSpeed);
                    break;
                case 3:
                    vertex3Color.Z = Math.Min(1.0f, vertex3Color.Z + colorChangeSpeed);
                    break;
            }
        }

        private void DecreaseColorValue(int vertex) // LAB 3
        {
            switch (vertex)
            {
                case 1:
                    vertex1Color.X = Math.Max(0.0f, vertex1Color.X - colorChangeSpeed);
                    break;
                case 2:
                    vertex2Color.Y = Math.Max(0.0f, vertex2Color.Y - colorChangeSpeed);
                    break;
                case 3:
                    vertex3Color.Z = Math.Max(0.0f, vertex3Color.Z - colorChangeSpeed);
                    break;
            }
        }

        protected override void OnRenderFrame(FrameEventArgs e) // LAB 3
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.MatrixMode(MatrixMode.Modelview);
            GL.LoadIdentity();
            GL.Rotate(triangleRotation, Vector3.UnitZ);

            GL.Begin(PrimitiveType.Triangles);

            GL.Color3(vertex1Color.X, 0.0f, 0.0f);
            GL.Vertex2(-0.5f, -0.5f);
            GL.Color3(0.0f, vertex2Color.Y, 0.0f);
            GL.Vertex2(0.5f, -0.5f);
            GL.Color3(0.0f, 0.0f, vertex3Color.Z);
            GL.Vertex2(0.0f, 0.5f);

            GL.End();

            Console.WriteLine($"Vertex 1 Color (R): {vertex1Color.X}");
            Console.WriteLine($"Vertex 2 Color (G): {vertex2Color.Y}");
            Console.WriteLine($"Vertex 3 Color (B): {vertex3Color.Z}");
            this.SwapBuffers();
        }

 
    }
}
