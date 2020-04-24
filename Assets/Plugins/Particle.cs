using System.Collections;
using System.Collections.Generic;
using CustomVector3;
using AsteroidsForms;
using UnityEngine;

namespace ParticleCreator
{
    public struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }

    public class Particle
    {
        Size ParticleSize;
        int LifeTime;
        MRVector InitialCoords;
        MRVector Velocity;
        float RotationAngleRadians;

        public Particle(MRVector initialCoords, MRVector velocity, float rotation, int lifeTime, int width, int height)
        {
            InitialCoords = initialCoords;
            Velocity = velocity;
            LifeTime = lifeTime;
            ParticleSize.Width = width;
            ParticleSize.Height = height;
           // RotationAngleRadians = (rotation*3.14)/180;
        }

        public void Update()
        {
            LifeTime--;
            if (LifeTime > 0)
            {
                //Velocity.X = Velocity.X * MatMathf.Cos(RotationAngleRadians);
                //Velocity.y = Velocity.Y * MatMathf.Cos(RotationAngleRadians);
                InitialCoords = InitialCoords + Velocity;
            } 
            else
            {
                    ParticleSize.Height = 0;
                    ParticleSize.Width = 0;
                    LifeTime = 0;
                    InitialCoords = null;
                    Velocity = null;
            }
        }
    }
}



