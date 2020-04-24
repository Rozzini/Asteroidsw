using System.Collections;
using System.Collections.Generic;
using CustomVector3;
using ParticleCreator;
using UnityEngine;


namespace ObjectEmiter
{
    public class EmiterClass 
    {
        public int ParticlesSpawnQuantity;
        public string CurrentEmiterName;
        private MRVector EmitertCoords;

        public EmiterClass(MRVector emiterCoords, string emiterName, int particlesSpawnQuantity)
        {
            HPosition = hPosition;
            EmitertCoords = emiterCoords;
            Width = width;
            CurrentEmiterName = emiterName;
            ParticlesSpawnQuantity = particlesSpawnQuantity;
        }

        public List<Particle> SpawnParticles()
        {
            List<Particle> particles = new List<Particle>();

            int particleLifetime = 15;
            float rotation = 0;

            for (int i = 1; i <= ParticlesSpawnQuantity; i++)
            {
                int ParticleWidth = Random.Range(2, 10);
                int ParticleHeight = Random.Range(2, 10);
                float XDirection = Random.Range(0.0f, 1.0f);
                float YDirection = Random.Range(0.0f, 1.0f);
                Particle particle = new Particle(EmitertCoords, XDirection, YDirection, 0, rotation, particleLifetime, ParticleWidth, ParticleHeight);

                particles.Add(particle);
               
            }
            return particles;
        }

    }
}
