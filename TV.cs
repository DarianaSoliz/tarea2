using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//aqui hacemos el codigo del didujo
namespace TV
{
   public class TV: GameWindow

    {
        private casa3D.TELE televisor;
        private casa3D.TELE televisor2;
        public TV(int WIDTH , int HEIGHT, string mititulo): base(WIDTH, HEIGHT, GraphicsMode.Default, mititulo)
        {

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

       
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {

            GL.ClearColor(Color4.White);
            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            televisor = new casa3D.TELE(0,0,0,new Vector3(0.1f,0.2f,-0.05f));
            televisor.dibujar();
            televisor2 = new casa3D.TELE(0, 0, 0, new Vector3(0.40f, 0.30f, -0.060f));
            televisor2.dibujar();

            Context.SwapBuffers();
            base.OnRenderFrame(e);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(1.0f, 0.0f, 0.1f, 0.0f);
            base.OnUpdateFrame(e);
        }


    }
}
