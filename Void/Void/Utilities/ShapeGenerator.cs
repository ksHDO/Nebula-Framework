using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Void.Utilities
{
    public static class ShapeGenerator
    {
        
        //public static Texture2D GenerateCircle(int radius, Color color)
        //{
        //    int outerRadius = radius * 2 + 2;
        //    Texture2D texture = new Texture2D(GraphicsDevice, outerRadius, outerRadius);

        //    Color[] data = new Color[outerRadius * outerRadius];

        //    for (int i = 0; i < data.Length; i++)
        //        data[i] = Color.Transparent;

        //    double angleStep = 1f / radius;

        //    for (double angle = 0; angle < Math.PI * 2; angle += angleStep)
        //    {
        //        int x = (int)Math.Round(radius + radius * Math.Cos(angle));
        //        int y = (int)Math.Round(radius + radius * Math.Sin(angle));

        //        data[y * outerRadius + x + 1] = Color.White;
        //    }

        //    texture.SetData(data);
        //    return texture;
        //}
    }
}
