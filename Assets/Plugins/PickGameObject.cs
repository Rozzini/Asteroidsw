using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AsteroidsForms
{
    public class PickGameObject 
    {
        public static List<GameObject> Prefabs = new List<GameObject>();

        public static void LoadPrefabs()
        {
            for (int i = 0; i < 5;  i++)
            {
                Prefabs.Add((GameObject)Resources.Load("prefabs/prefab" + i, typeof(GameObject)));
            }
        }

        public static GameObject GetGameObject(int num)
        {
            return Prefabs[num];
        }
    }
}
