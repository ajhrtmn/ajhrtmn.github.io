using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace Imaginators.Models
{
    public class Camera
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Vector2 MazXY { get; set; }
        public Vector2 CurrentXY { get; set; }
    }
}