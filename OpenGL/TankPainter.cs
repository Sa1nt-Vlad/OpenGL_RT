﻿using System.Drawing;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace OpenGL
{
    public class TankPainter
    {
        private static readonly Vector3[] corpusPoints = {
            /* 0 */ Vector3.Zero,
            /* 1 */ new Vector3(0.2f, 0, -0.94f), 
            /* 2 */ new Vector3(0.2f, 0.1f, -0.78f), 
            /* 3 */ new Vector3(-0.2f, 0.1f, -0.78f),
            /* 4 */ new Vector3(-0.2f, 0, -0.94f),
            /* 5 */ new Vector3(0.3f, 0.1f, -0.78f),
            /* 6 */ new Vector3(0.3f, 0.17f, -0.66f),
            /* 7 */ new Vector3(-0.3f, 0.17f, -0.66f),
            /* 8 */ new Vector3(-0.3f, 0.1f, -0.78f),
            /* 9 */ new Vector3(-0.3f, 0.2f, -0.55f),
            /* 10 */ new Vector3(0.3f, 0.2f, -0.55f),
                
            /* 11 */ new Vector3(0.3f, 0.1f, -0.52f),
            /* 12 */ new Vector3(0.3f, 0.12f, 0.21f),
            /* 13 */ new Vector3(0.3f, 0.22f, 0.2f), 
            /* 14 */ new Vector3(-0.3f, 0.1f, -0.52f),
            /* 15 */ new Vector3(-0.3f, 0.12f, 0.21f),
            /* 16 */ new Vector3(-0.3f, 0.22f, 0.2f),
            /* 17 */ new Vector3(0.3f, 0.1f, 0.22f),
            /* 18 */ new Vector3(0.3f, 0.1f, 0.97f),
            /* 19 */ new Vector3(0.3f, 0.12f, 0.97f),
            /* 20 */ new Vector3(-0.3f, 0.1f, 0.22f),
            /* 21 */ new Vector3(-0.3f, 0.1f, 0.97f),
            /* 22 */ new Vector3(-0.3f, 0.12f, 0.97f),
                
            /* 23 */ new Vector3(0.2f, 0.1f, -0.52f),
            /* 24 */ new Vector3(0.2f, -0.12f, -0.74f),
            /* 25 */ new Vector3(0.2f, -0.12f, 0.8f),
            /* 26 */ new Vector3(0.2f, 0.1f, 0.97f),
            /* 27 */ new Vector3(-0.2f, -0.12f, -0.74f),
            /* 28 */ new Vector3(-0.2f, 0.1f, -0.52f),
            /* 29 */ new Vector3(-0.2f, 0.1f, 0.97f),
            /* 30 */ new Vector3(-0.2f, -0.12f, 0.8f),
        };
        private static readonly Vector3[] towerPoints = {
            /* 0 */ Vector3.Zero,
            /* 1 */ new Vector3(0.07f, 0.12f, 0.24f), 
            /* 2 */ new Vector3(0.15f, 0.12f, 0.29f), 
            /* 3 */ new Vector3(0.07f, 0.29f, 0.26f),
            /* 4 */ new Vector3(0.15f, 0.31f, 0.31f),
            /* 5 */ new Vector3(0.182f, 0.37f, 0.4f),
            /* 6 */ new Vector3(0.07f, 0.37f, 0.4f),
            /* 7 */ new Vector3(0.07f, 0.45f, 0.54f),
            /* 8 */ new Vector3(-0.3f, 0.1f, -0.78f),
            /* 9 */ new Vector3(0.24f, 0.45f, 0.55f),
            /* 10 */ new Vector3(0.3f, 0.2f, -0.55f),
            /* 11 */ new Vector3(0.25f, 0.12f, 0.55f),
            /* 12 */ new Vector3(0.31f, 0.24f, 0.73f),
            /* 13 */ new Vector3(0.26f, 0.48f, 0.61f), 
            /* 14 */ new Vector3(0.34f, 0.43f, 0.83f),
            /* 15 */ new Vector3(0.34f, 0.24f, 0.83f),
            /* 16 */ new Vector3(0.34f, 0.24f, 1.12f),
            /* 17 */ new Vector3(0.34f, 0.43f, 1.12f),
            /* 18 */ new Vector3(0.28f, 0.47f, 1.08f),
            /* 19 */ new Vector3(0.3f, 0.12f, 0.97f),
            /* 20 */ new Vector3(-0.3f, 0.1f, 0.22f),
            /* 21 */ new Vector3(0, 0.56f, 0.73f),
            /* 22 */ new Vector3(0, 0.56f, 0.99f), 
            
            /* 23 */ new Vector3(-0.07f, 0.12f, 0.24f), 
            /* 24 */ new Vector3(-0.15f, 0.12f, 0.29f), 
            /* 25 */ new Vector3(-0.07f, 0.29f, 0.26f),
            /* 26 */ new Vector3(-0.15f, 0.31f, 0.31f),
            /* 27 */ new Vector3(-0.182f, 0.37f, 0.4f),
            /* 28 */ new Vector3(-0.07f, 0.37f, 0.4f),
            /* 29 */ new Vector3(-0.07f, 0.45f, 0.54f),
            /* 30 */ new Vector3(-0.3f, 0.1f, -0.78f),
            /* 31 */ new Vector3(-0.24f, 0.45f, 0.55f),
            /* 32 */ new Vector3(-0.3f, 0.2f, -0.55f),
            /* 33 */ new Vector3(-0.25f, 0.12f, 0.55f),
            /* 34 */ new Vector3(-0.31f, 0.24f, 0.73f),
            /* 35 */ new Vector3(-0.26f, 0.48f, 0.61f), 
            /* 36 */ new Vector3(-0.34f, 0.43f, 0.83f),
            /* 37 */ new Vector3(-0.34f, 0.24f, 0.83f),
            /* 38 */ new Vector3(-0.34f, 0.24f, 1.12f),
            /* 39 */ new Vector3(-0.34f, 0.43f, 1.12f),
            /* 40 */ new Vector3(-0.28f, 0.47f, 1.08f),
            /* 41 */ new Vector3(-0.3f, 0.12f, 0.97f),
            /* 42 */ new Vector3(-0.3f, 0.1f, 0.22f),
            /* 43 */ new Vector3(-0, 0.56f, 0.73f),
            /* 44 */ new Vector3(-0, 0.56f, 0.99f), 
        };
        private static readonly Vector3[] trackPoints = {
            /* 0 */ Vector3.Zero,
            /* 1 */ new Vector3(0.21f, 0.035f, -0.4f), 
            /* 2 */ new Vector3(0.395f, 0.035f, -0.4f), 
            /* 3 */ new Vector3(0.21f, 0.05f, 0.82f),
            /* 4 */ new Vector3(0.395f, 0.05f, 0.82f),
            /* 5 */ new Vector3(0.425f, 0.035f, 0.82f),
            /* 6 */ new Vector3(0.425f, 0.02f, -0.4f),
            /* 7 */ new Vector3(0.425f, 0.067f, -0.76f),
            /* 8 */ new Vector3(0.395f, 0.082f, -0.76f),
            /* 9 */ new Vector3(0.21f, 0.082f, -0.76f),
            /* 10 */ new Vector3(0.21f, 0.045f, -0.86f),
            /* 11 */ new Vector3(0.395f, 0.045f, -0.86f),
            /* 12 */ new Vector3(0.425f, 0.045f, -0.86f),
            /* 13 */ new Vector3(0.425f, -0.04f, -0.9f), 
            /* 14 */ new Vector3(0.395f, -0.04f, -0.9f),
            /* 15 */ new Vector3(0.21f, -0.04f, -0.9f),
            /* 16 */ new Vector3(0.21f, -0.15f, -0.84f),
            /* 17 */ new Vector3(0.395f, -0.15f, -0.84f),
            /* 18 */ new Vector3(0.425f, -0.15f, -0.84f),
            /* 19 */ new Vector3(0.425f, -0.22f, -0.6f),
            /* 20 */ new Vector3(0.395f, -0.22f, -0.6f),
            /* 21 */ new Vector3(0.21f, -0.22f, -0.6f),
            /* 22 */ new Vector3(0.21f, -0.22f, 0.63f),
            /* 23 */ new Vector3(0.395f, -0.22f, 0.63f),
            /* 24 */ new Vector3(0.425f, -0.22f, 0.63f),
            /* 25 */ new Vector3(0.425f, -0.1f, 0.88f),
            /* 26 */ new Vector3(0.395f, -0.1f, 0.88f),
            /* 27 */ new Vector3(0.21f, -0.1f, 0.88f),
            /* 28 */ new Vector3(0.425f, 0f, 0.9f),
            /* 29 */ new Vector3(0.395f, 0f, 0.9f),
            /* 30 */ new Vector3(0.21f, 0f, 0.9f),
        };

        private static readonly Vector3[] detailsPoints = {
            /* 0 */ Vector3.Zero,
            /* 1 */ new Vector3(0.25f, 0.23f, -0.2f), 
            /* 2 */ new Vector3(0.25f, 0.23f, 0.15f), 
            /* 3 */ new Vector3(0.03f, 0.23f, 0.15f),
            /* 4 */ new Vector3(0.03f, 0.23f, -0.2f),
            /* 5 */ new Vector3(0.25f, 0.2f, -0.2f),
            /* 6 */ new Vector3(0.25f, 0.2f, 0.15f),
            /* 7 */ new Vector3(0.03f, 0.2f, 0.15f),
            /* 8 */ new Vector3(0.03f, 0.2f, -0.2f),
        };
        
        private static readonly Vector3[] details2Points = {
            /* 0 */ Vector3.Zero,
            /* 1 */ new Vector3(0, 0.3f, 0.28f), 
            /* 2 */ new Vector3(0.04f, 0.3f, 0.28f), 
            /* 3 */ new Vector3(0.04f, 0.33f, 0.28f),
            /* 4 */ new Vector3(0, 0.33f, 0.28f),
            /* 5 */ new Vector3(0.07f, 0.3f, 0.28f),
            /* 6 */ new Vector3(0.07f, 0.38f, 0.28f),
            /* 7 */ new Vector3(0.04f, 0.38f, 0.28f),
            /* 8 */ new Vector3(0.05f, 0.38f, 0.95f),
            /* 9 */ new Vector3(0.07f, 0.38f, 0.95f),
            /* 10 */ new Vector3(0.07f, 0.3f, 0.95f),
            /* 11 */ new Vector3(0.05f, 0.3f, 0.95f),
            /* 12 */ new Vector3(0.05f, 0.33f, 0.95f),
            /* 13 */ new Vector3(0, 0.33f, 0.95f),    
            /* 14 */ new Vector3(0, 0.3f, 0.95f)
        };
        
        public static void DrawTank(double turretAngle)
        {
            DrawCorpus();
            DrawTower();
            DrawGun();
            DrawRollers();
            DrawTrack();
            DrawDetails();
        }

        private static void DrawDetails()
        {
            // детали спереди
            GL.Color3(Color.Coral);
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[3]);
            
            GL.Begin(PrimitiveType.Quads);
            MakeSquare(detailsPoints[1], detailsPoints[2], detailsPoints[3], detailsPoints[4]);
            MakeSquare(detailsPoints[1], detailsPoints[2], detailsPoints[3], detailsPoints[4], true);
            GL.End();

            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[0]);
            GL.Begin(PrimitiveType.Quads);
            MakeSquare(detailsPoints[1], detailsPoints[2], detailsPoints[6], detailsPoints[5]);
            MakeSquare(detailsPoints[1], detailsPoints[4], detailsPoints[8], detailsPoints[5]);
            MakeSquare(detailsPoints[4], detailsPoints[8], detailsPoints[7], detailsPoints[3]);
            MakeSquare(detailsPoints[3], detailsPoints[7], detailsPoints[6], detailsPoints[2]);
            
            MakeSquare(detailsPoints[1], detailsPoints[2], detailsPoints[6], detailsPoints[5], true);
            MakeSquare(detailsPoints[1], detailsPoints[4], detailsPoints[8], detailsPoints[5], true);
            MakeSquare(detailsPoints[4], detailsPoints[8], detailsPoints[7], detailsPoints[3], true);
            MakeSquare(detailsPoints[3], detailsPoints[7], detailsPoints[6], detailsPoints[2], true);
            GL.End();
            
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[1]);
            Painter.PaintCylinder(Axis.Y, new Vector3(0, 0.19f, -0.4f), 0.12f, 0.08f, Color.Aqua, Color.Aqua);
            
            // держатель орудия
            
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[5]);
            GL.Begin(PrimitiveType.Quads);
            
            MakeSquare(details2Points[1], details2Points[2], details2Points[3], details2Points[4]);
            MakeSquare(details2Points[2], details2Points[5], details2Points[6], details2Points[7]);
            MakeSquare(details2Points[8], details2Points[9], details2Points[10], details2Points[11]);
            MakeSquare(details2Points[11], details2Points[12], details2Points[13], details2Points[14]);
            MakeSquare(details2Points[1], details2Points[2], details2Points[3], details2Points[4], true);
            MakeSquare(details2Points[2], details2Points[5], details2Points[6], details2Points[7], true);
            MakeSquare(details2Points[8], details2Points[9], details2Points[10], details2Points[11], true);
            MakeSquare(details2Points[11], details2Points[12], details2Points[13], details2Points[14], true);
            MakeSquare(details2Points[1], details2Points[5], details2Points[10], details2Points[14]);
            MakeSquare(details2Points[3], details2Points[4], details2Points[13], details2Points[12]);
            MakeSquare(details2Points[6], details2Points[7], details2Points[8], details2Points[9]);
            MakeSquare(details2Points[5], details2Points[6], details2Points[9], details2Points[10]);
            MakeSquare(details2Points[3], details2Points[7], details2Points[8], details2Points[12]);
            MakeSquare(details2Points[1], details2Points[5], details2Points[10], details2Points[14], true);
            MakeSquare(details2Points[3], details2Points[4], details2Points[13], details2Points[12], true);
            MakeSquare(details2Points[6], details2Points[7], details2Points[8], details2Points[9], true);
            MakeSquare(details2Points[5], details2Points[6], details2Points[9], details2Points[10], true);
            MakeSquare(details2Points[3], details2Points[7], details2Points[8], details2Points[12], true);
            
            GL.End();
            
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[5]);
            Painter.PaintCube(new Vector3(0, 0.2f, 0.45f), 0.2f);
        }

        private static void DrawTower()
        {
            GL.Begin(PrimitiveType.Quads);
            MakeSquare(towerPoints[1], towerPoints[2], towerPoints[4], towerPoints[3]);
            MakeSquare(towerPoints[14], towerPoints[15], towerPoints[16], towerPoints[17]);
            MakeSquare(towerPoints[23], towerPoints[24], towerPoints[26], towerPoints[25]);
            MakeSquare(towerPoints[36], towerPoints[37], towerPoints[38], towerPoints[39]);
            MakeSquare(towerPoints[1], towerPoints[3], towerPoints[25], towerPoints[23]);
            MakeSquare(towerPoints[2], towerPoints[4], towerPoints[5], towerPoints[11]);
            MakeSquare(towerPoints[5], towerPoints[11], towerPoints[12], towerPoints[13]);
            MakeSquare(towerPoints[12], towerPoints[13], towerPoints[14], towerPoints[15]);
            MakeSquare(towerPoints[24], towerPoints[26], towerPoints[27], towerPoints[33]);
            MakeSquare(towerPoints[27], towerPoints[33], towerPoints[34], towerPoints[35]);
            MakeSquare(towerPoints[34], towerPoints[35], towerPoints[36], towerPoints[37]);
            MakeSquare(towerPoints[3], towerPoints[4], towerPoints[5], towerPoints[6]);
            MakeSquare(towerPoints[13], towerPoints[14], towerPoints[17], towerPoints[18]);
            MakeSquare(towerPoints[25], towerPoints[26], towerPoints[27], towerPoints[28]);
            MakeSquare(towerPoints[35], towerPoints[36], towerPoints[39], towerPoints[40]);
            MakeSquare(towerPoints[11], towerPoints[12], towerPoints[34], towerPoints[33]);
            MakeSquare(towerPoints[28], towerPoints[27], towerPoints[31], towerPoints[29]);
            MakeSquare(towerPoints[6], towerPoints[5], towerPoints[9], towerPoints[7]);
            MakeSquare(towerPoints[21], towerPoints[22], towerPoints[18], towerPoints[13]);
            MakeSquare(towerPoints[43], towerPoints[44], towerPoints[40], towerPoints[35]);
            
            GL.End();
        }

        private static void DrawGun()
        {
            GL.Disable(EnableCap.Lighting);
            GL.Disable(EnableCap.Texture2D);

            var sideColor = Color.FromArgb(72, 72, 72);
            var faceColor = Color.FromArgb(39, 39, 39);
            
            Painter.PaintCylinder(Axis.Z, new Vector3(0, 0.42f, -0.1f), 0.018f, 0.028f, 1.7f, faceColor, sideColor);
            Painter.PaintCylinder(Axis.Z, new Vector3(0, 0.42f, 0.53f), 0.038f, 0.7f, faceColor, sideColor);
            Painter.PaintCylinder(Axis.Z, new Vector3(0, 0.42f, 0.38f), 0.03f, 0.031f, 0.7f, faceColor, sideColor);
            Painter.PaintCylinder(Axis.Z, new Vector3(0, 0.483f, 0.55f), 0.028f, 0.45f, faceColor, sideColor);
            Painter.PaintCylinder(Axis.Z, new Vector3(0, 0.36f, 0.455f), 0.023f, 0.45f, faceColor, sideColor);
            
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Texture2D);
        }

        private static void DrawTrack()
        {
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[2]);
            GL.Begin(PrimitiveType.Quads);
            MakeSquare(trackPoints[1], trackPoints[2], trackPoints[4], trackPoints[3]);
            MakeSquare(trackPoints[1], trackPoints[2], trackPoints[4], trackPoints[3], true);
            MakeSquare(trackPoints[8], trackPoints[9], trackPoints[10], trackPoints[11]);
            MakeSquare(trackPoints[8], trackPoints[9], trackPoints[10], trackPoints[11], true);
            MakeSquare(trackPoints[14], trackPoints[15], trackPoints[16], trackPoints[17]);
            MakeSquare(trackPoints[14], trackPoints[15], trackPoints[16], trackPoints[17], true);
            MakeSquare(trackPoints[20], trackPoints[21], trackPoints[22], trackPoints[23]);
            MakeSquare(trackPoints[20], trackPoints[21], trackPoints[22], trackPoints[23], true);
            MakeSquare(trackPoints[25], trackPoints[26], trackPoints[29], trackPoints[28]);
            MakeSquare(trackPoints[25], trackPoints[26], trackPoints[29], trackPoints[28], true);
            MakeSquare(trackPoints[2], trackPoints[6], trackPoints[5], trackPoints[4]);
            MakeSquare(trackPoints[2], trackPoints[6], trackPoints[5], trackPoints[4], true);
            MakeSquare(trackPoints[7], trackPoints[8], trackPoints[11], trackPoints[12]);
            MakeSquare(trackPoints[7], trackPoints[8], trackPoints[11], trackPoints[12], true);
            MakeSquare(trackPoints[13], trackPoints[14], trackPoints[17], trackPoints[18]);
            MakeSquare(trackPoints[13], trackPoints[14], trackPoints[17], trackPoints[18], true);
            MakeSquare(trackPoints[19], trackPoints[20], trackPoints[23], trackPoints[24]);
            MakeSquare(trackPoints[19], trackPoints[20], trackPoints[23], trackPoints[24], true);
            MakeSquare(trackPoints[26], trackPoints[27], trackPoints[30], trackPoints[29]);
            MakeSquare(trackPoints[26], trackPoints[27], trackPoints[30], trackPoints[29], true);
            MakeSquare(trackPoints[1], trackPoints[2], trackPoints[8], trackPoints[9]);
            MakeSquare(trackPoints[1], trackPoints[2], trackPoints[8], trackPoints[9], true);
            MakeSquare(trackPoints[10], trackPoints[11], trackPoints[14], trackPoints[15]);
            MakeSquare(trackPoints[10], trackPoints[11], trackPoints[14], trackPoints[15], true);
            MakeSquare(trackPoints[16], trackPoints[17], trackPoints[20], trackPoints[21]);
            MakeSquare(trackPoints[16], trackPoints[17], trackPoints[20], trackPoints[21], true);
            MakeSquare(trackPoints[22], trackPoints[23], trackPoints[26], trackPoints[27]);
            MakeSquare(trackPoints[22], trackPoints[23], trackPoints[26], trackPoints[27], true);
            MakeSquare(trackPoints[29], trackPoints[30], trackPoints[3], trackPoints[4]);
            MakeSquare(trackPoints[29], trackPoints[30], trackPoints[3], trackPoints[4], true);
            MakeSquare(trackPoints[2], trackPoints[6], trackPoints[7], trackPoints[8]);
            MakeSquare(trackPoints[2], trackPoints[6], trackPoints[7], trackPoints[8], true);
            MakeSquare(trackPoints[11], trackPoints[12], trackPoints[13], trackPoints[14]);
            MakeSquare(trackPoints[11], trackPoints[12], trackPoints[13], trackPoints[14], true);
            MakeSquare(trackPoints[17], trackPoints[18], trackPoints[19], trackPoints[20]);
            MakeSquare(trackPoints[17], trackPoints[18], trackPoints[19], trackPoints[20], true);
            MakeSquare(trackPoints[23], trackPoints[24], trackPoints[25], trackPoints[26]);
            MakeSquare(trackPoints[23], trackPoints[24], trackPoints[25], trackPoints[26], true);
            MakeSquare(trackPoints[28], trackPoints[29], trackPoints[4], trackPoints[5]);
            MakeSquare(trackPoints[28], trackPoints[29], trackPoints[4], trackPoints[5], true);

            GL.End();
        }

        private static void DrawRollers()
        {
            GL.Disable(EnableCap.Lighting);
            GL.Disable(EnableCap.Texture2D);
            var stepZ = 0f;
            var stepX = 0f;
            var color1 = Color.FromArgb(72, 72, 72);
            var sideColor = Color.FromArgb(39, 39, 39);
            
            
            for (int i = 0; i < 8; i++)
            {
                stepX = i % 2 == 0 ? 0 : 0.095f;
                Painter.PaintCylinder(Axis.X, new Vector3(0.25f + stepX, -0.1f, -0.53f + stepZ), 0.09f, 0.03f, sideColor, sideColor);
                Painter.PaintCylinder(Axis.X, new Vector3(0.25f + stepX, -0.1f, -0.53f + stepZ), 0.02f, 0.05f, color1, sideColor);
                Painter.PaintClampedCylinder(Axis.X, new Vector3(0.25f + stepX, -0.1f, -0.53f + stepZ), 0.12f, 0.09f, 0.08f, color1, sideColor);
                Painter.PaintCylinder(Axis.X, new Vector3(-0.25f - stepX, -0.1f, -0.53f + stepZ), 0.09f, 0.03f, sideColor, sideColor);
                Painter.PaintCylinder(Axis.X, new Vector3(-0.25f - stepX, -0.1f, -0.53f + stepZ), 0.02f, 0.05f, color1, sideColor);
                Painter.PaintClampedCylinder(Axis.X, new Vector3(-0.25f - stepX, -0.1f, -0.53f + stepZ), 0.12f, 0.09f, 0.08f, color1, sideColor);
                stepZ += 0.16f;
            }
            
            // передние катки
            Painter.PaintCylinder(Axis.X, new Vector3(-0.32f, -0.04f, -0.77f), 0.11f, 0.11f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(0.32f, -0.04f, -0.77f), 0.11f, 0.11f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(-0.2f, -0.04f, -0.77f), 0.02f, 0.2f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(0.2f, -0.04f, -0.77f), 0.02f, 0.2f, color1, sideColor);
            
            // задние катки
            Painter.PaintCylinder(Axis.X, new Vector3(-0.32f, -0.042f, 0.8f), 0.085f, 0.12f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(0.32f, -0.042f, 0.8f), 0.085f, 0.12f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(-0.2f, -0.042f, 0.8f), 0.02f, 0.2f, color1, sideColor);
            Painter.PaintCylinder(Axis.X, new Vector3(0.2f, -0.042f, 0.8f), 0.02f, 0.2f, color1, sideColor);
            GL.Enable(EnableCap.Lighting);
            GL.Enable(EnableCap.Texture2D);
        }

        private static void DrawCorpus()
        {
            GL.BindTexture(TextureTarget.Texture2D, TankGameWindow.TextureIds[7]);
            GL.Begin(PrimitiveType.Quads);
            MakeSquare(corpusPoints[1], corpusPoints[2], corpusPoints[3], corpusPoints[4]);
            MakeSquare(corpusPoints[5], corpusPoints[6], corpusPoints[7], corpusPoints[8]);
            MakeSquare(corpusPoints[6], corpusPoints[10], corpusPoints[9], corpusPoints[7]);
            MakeSquare(corpusPoints[9], corpusPoints[10], corpusPoints[13], corpusPoints[16]);
            MakeSquare(corpusPoints[5], corpusPoints[6], corpusPoints[10], corpusPoints[11]);
            MakeSquare(corpusPoints[8], corpusPoints[7], corpusPoints[9], corpusPoints[14]);
            MakeSquare(corpusPoints[10], corpusPoints[13], corpusPoints[17], corpusPoints[11]);
            MakeSquare(corpusPoints[9], corpusPoints[14], corpusPoints[20], corpusPoints[16]);
            MakeSquare(corpusPoints[20], corpusPoints[16], corpusPoints[13], corpusPoints[17]);
            MakeSquare(corpusPoints[12], corpusPoints[17], corpusPoints[18], corpusPoints[19]);
            MakeSquare(corpusPoints[15], corpusPoints[20], corpusPoints[21], corpusPoints[22]);
            MakeSquare(corpusPoints[21], corpusPoints[22], corpusPoints[19], corpusPoints[18]);
            MakeSquare(corpusPoints[15], corpusPoints[22], corpusPoints[19], corpusPoints[12]);
            MakeSquare(corpusPoints[1], corpusPoints[2], corpusPoints[23], corpusPoints[24]);
            MakeSquare(corpusPoints[3], corpusPoints[4], corpusPoints[27], corpusPoints[28]);
            MakeSquare(corpusPoints[24], corpusPoints[23], corpusPoints[26], corpusPoints[25]);
            MakeSquare(corpusPoints[27], corpusPoints[28], corpusPoints[29], corpusPoints[30]);
            MakeSquare(corpusPoints[4], corpusPoints[1], corpusPoints[24], corpusPoints[27]);
            MakeSquare(corpusPoints[17], corpusPoints[18], corpusPoints[21], corpusPoints[20]);
            MakeSquare(corpusPoints[2], corpusPoints[5], corpusPoints[11], corpusPoints[23]);
            MakeSquare(corpusPoints[3], corpusPoints[8], corpusPoints[14], corpusPoints[28]);
            MakeSquare(corpusPoints[24], corpusPoints[27], corpusPoints[30], corpusPoints[25]);
            MakeSquare(corpusPoints[11], corpusPoints[14], corpusPoints[20], corpusPoints[17]);
            MakeSquare(corpusPoints[25], corpusPoints[30], corpusPoints[29], corpusPoints[26]);

            GL.End();
        }

        private static void MakeSquare(Vector3 point1, Vector3 point2, Vector3 point3, Vector3 point4, bool isMirrored = false)
        {
            if (isMirrored)
            {
                point1 = new Vector3(-point1.X, point1.Y, point1.Z);
                point2 = new Vector3(-point2.X, point2.Y, point2.Z);
                point3 = new Vector3(-point3.X, point3.Y, point3.Z);
                point4 = new Vector3(-point4.X, point4.Y, point4.Z);
            }
            
            Painter.PaintSquare(point1, point2, point3, point4);
        }
    }
}