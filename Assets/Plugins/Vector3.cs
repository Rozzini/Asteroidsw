using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CustomVector3
{
    public class MRVector
    {
        private float x;
        private float y;
        private float z;

        public float X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public float Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public float Z
        {
            get
            {
                return z;
            }

            set
            {
                z = value;
            }
        }

        public MRVector(float _x, float _y, float _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }

        public static MRVector operator +(MRVector vec1, MRVector vec2)
        => new MRVector(vec1.x + vec2.X, vec1.Y + vec2.Y, vec1.Z + vec2.Z);

        public static MRVector operator -(MRVector vec1, MRVector vec2)
        => new MRVector(vec1.x - vec2.X, vec1.Y - vec2.Y, vec1.Z - vec2.Z);

        public static MRVector operator *(MRVector vec1, MRVector vec2)
        => new MRVector(vec1.x * vec2.X, vec1.Y * vec2.Y, vec1.Z * vec2.Z);

        public static MRVector operator /(MRVector vec1, MRVector vec2)
        => new MRVector(vec1.x / vec2.X, vec1.Y / vec2.Y, vec1.Z / vec2.Z);
    }
}

