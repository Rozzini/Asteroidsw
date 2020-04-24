using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ObjectEmiter;

namespace ObjectParticleSystem
{
    public class ParticleSystem : MonoBehaviour
    {
        public MRVector GameFieldLeftTopCoord;
        public MRVector GameFieldRightBottom;
        EmiterClass emiter;

        public MRVector PickEmiterLocation(int location)
        {
            switch(location)
            {
                case 1:
                    return new MRVector();
                case 2:
                    return new MRVector();
                case 3:
                    return new MRVector();
                case 4:
                    return new MRVector();

            }
        }
        public static CreateEmiter()
        {
            int ParticlesQuantity = Random.Range(1, 5);
          
            emiter = new EmiterClass(new MrVector(0, 0, 0), "FirstEmiter", ParticlesQuantity);
           
        }

        public void ShootParticles()
        {
            List<var> = emiter.SpawnParticles();
        }

        void Start()
        {

        }

        void Update()
        {
            
        }
    }
}
