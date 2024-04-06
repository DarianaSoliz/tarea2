using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casa3D
{
    internal class TELE
    {
        public float x;
        public float y;
        public float z;
        public Vector3 pos;

        public TELE(float x, float y, float z, Vector3 posi){

               this.x = x;
               this.y = y;
               this.z = z;
               pos = posi;

        }

        public void dibujar()
        {
            GL.Begin(PrimitiveType.Lines);

            //PARTE DELANTERA
            GL.Color4(Color.Black);
            //lineas horizontales
            GL.Vertex3(pos.X+0, pos.Y+0,pos.Z+0);
            GL.Vertex3(pos.X+0.5,pos.Y+0,pos.Z+0);

            GL.Vertex3(pos.X+0,pos.Y+0.4,pos.Z+0);
            GL.Vertex3(pos.X + 0.5, pos.Y + 0.4, pos.Z + 0);

            //lineas verticales
            GL.Vertex3(pos.X + 0, pos.Y + 0, pos.Z + 0);
            GL.Vertex3(pos.X + 0.4, pos.Y + 0, pos.Z + 0);

            GL.Vertex3(pos.X + 0.5, pos.Y + 0, pos.Z + 0);
            GL.Vertex3(pos.X + 0.5, pos.Y + 0.4, pos.Z + 0);

            //tubo vertical 
            GL.Vertex3(pos.X + 0.22, pos.Y + 0, pos.Z + 0);
            GL.Vertex3(pos.X+0.22,pos.Y-0.05,pos.Z+0);

            GL.Vertex3(pos.X + 0.26, pos.Y + 0, pos.Z + 0);
            GL.Vertex3(pos.X+0.26,pos.Y-0.05, pos.Z + 0);

            //soporte 
            GL.Vertex3(pos.X + 0.12, pos.Y - 0.05, pos.Z + 0);
            GL.Vertex3(pos.X + 0.36, pos.Y - 0.05, pos.Z + 0);

            GL.Vertex3(pos.X+0.12, pos.Y-0.06,pos.Z+0);
            GL.Vertex3(pos.X + 0.36, pos.Y - 0.06, pos.Z + 0);

            GL.Vertex3(pos.X + 0.12, pos.Y - 0.05, pos.Z + 0);
            GL.Vertex3(pos.X + 0.12, pos.Y - 0.06, pos.Z + 0);

            GL.Vertex3(pos.X + 0.36, pos.Y - 0.05, pos.Z + 0);
            GL.Vertex3(pos.X + 0.36, pos.Y - 0.06, pos.Z + 0);

            //pantalla
            //lineas verticales
            GL.Vertex3(pos.X+0.02, pos.Y+0.03, pos.Z+0);
            GL.Vertex3(pos.X+0.02, pos.Y+0.37, pos.Z+0);

            GL.Vertex3(pos.X + 0.48, pos.Y + 0.03,pos.Z+0);
            GL.Vertex3(pos.X + 0.48, pos.Y + 0.37, pos.Z + 0);

            //lineas horizontales
            GL.Vertex3(pos.X + 0.02, pos.Y + 0.03, pos.Z + 0);
            GL.Vertex3(pos.X+0.48, pos.Y+0.03, pos.Z+0);

            GL.Vertex3(pos.X + 0.02, pos.Y + 0.37, pos.Z + 0);
            GL.Vertex3(pos.X + 0.48, pos.Y + 0.37, pos.Z + 0);

            //PARTE TRASERA
            //lineas horizontales
            GL.Vertex3(pos.X + 0, pos.Y + 0, pos.Z - 0.02);
            GL.Vertex3(pos.X + 0.5, pos.Y + 0, pos.Z - 0.02);

            GL.Vertex3(pos.X + 0, pos.Y + 0.4, pos.Z - 0.02);
            GL.Vertex3(pos.X + 0.5, pos.Y + 0.4, pos.Z - 0.02);

            //lineas verticales
            GL.Vertex3(pos.X+0,pos.Y+0,pos.Z-0.02);
            GL.Vertex3(pos.X+0,pos.Y+0.4,pos.Z-0.02);

            GL.Vertex3(pos.X+0.5,pos.Y+0, pos.Z-0.02);
            GL.Vertex3(pos.X+0.5,pos.Y+0.4, pos.Z-0.02);

            //tubo vertical 
            GL.Vertex3(pos.X+0.22,pos.Y+0, pos.Z - 0.02);
            GL.Vertex3(pos.X + 0.22, pos.Y - 0.05, pos.Z - 0.02);

            GL.Vertex3(pos.X+0.26,pos.Y+0,pos.Z-0.02);
            GL.Vertex3(pos.X + 0.26, pos.Y - 0.05, pos.Z - 0.02);

            //soporte 
            GL.Vertex3(pos.X + 0.12, pos.Y - 0.05, pos.Z - 0.02);
            GL.Vertex3(pos.X + 0.36, pos.Y - 0.05, pos.Z - 0.02);

            GL.Vertex3(pos.X + 0.12, pos.Y - 0.06, pos.Z - 0.02);
            GL.Vertex3(pos.X + 0.36, pos.Y - 0.06, pos.Z - 0.02);

            GL.Vertex3(pos.X + 0.12, pos.Y - 0.05, pos.Z - 0.02);
            GL.Vertex3(pos.X+0.12,pos.Y-0.06,pos.Z-0.02);

            GL.Vertex3(pos.X+0.36,pos.Y-0.05,pos.Z-0.02);
            GL.Vertex3(pos.X+0.36,pos.Y-0.06,pos.Z-0.02);


            //UNIENDO PARTE DELANTERA CON TRASERA 
            GL.Vertex3(pos.X + 0, pos.Y + 0, pos.Z + 0);
            GL.Vertex3(pos.X + 0, pos.Y + 0, pos.Z - 0.02);

            GL.Vertex3(pos.X + 0, pos.Y + 0.4, pos.Z+0);
            GL.Vertex3(pos.X + 0, pos.Y + 0.4, pos.Z - 0.02);

            GL.Vertex3(pos.X + 0.5, pos.Y + 0,pos.Z+0);
            GL.Vertex3(pos.X+0.5, pos.Y+ 0,pos.Z-0.02);

            GL.Vertex3(pos.X+0.5,pos.Y+0.4,pos.Z+0);
            GL.Vertex3(pos.X+0.5,pos.Y+0.4,pos.Z-0.02);

            //soporte 
            GL.Vertex3(pos.X+0.12,pos.Y -0.05, pos.Z-0.02);
            GL.Vertex3(pos.X + 0.12, pos.Y - 0.05, pos.Z + 0);

            GL.Vertex3(pos.X + 0.12, pos.Y - 0.06, pos.Z + 0);
            GL.Vertex3(pos.X+0.12, pos.Y-0.06,pos.Z -0.02);

            GL.Vertex3(pos.X + 0.36, pos.Y - 0.05, pos.Z + 0);
            GL.Vertex3(pos.X+0.36,pos.Y -0.05, pos.Z-0.02);

            GL.Vertex3(pos.X + 0.36, pos.Y - 0.06, pos.Z + 0);
            GL.Vertex3(pos.X+0.36,pos.Y-0.06,pos.Z-0.02);

            GL.End();

        }

    }
}
