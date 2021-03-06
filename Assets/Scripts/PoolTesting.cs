using System;
using System.IO;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class PoolTesting : MonoBehaviour
    {
        public Pooling cubePool;
        // Start is called before the first frame update
        void Start()
        {
            cubePool.Spawn();
            Transform test = cubePool.Spawn();
            cubePool.Despawn(test);
            cubePool.Spawn();
            cubePool.Spawn();
            Transform test2 = cubePool.Spawn();
            cubePool.Despawn(test2);
            Debug.Log("Spawned Cubes");
            Debug.LogWarning("Spawned Cubes 2");
            Debug.LogError("Spawned Cubes 3");
            int y = 0;
            try
            {
                int x = 10 / y;
            }
            catch (DivideByZeroException e)
            {
                Debug.LogWarning(e.Message);
            }
            catch (Exception e)
            {
                Debug.LogError(e.Message);
            }
            finally
            {
                //file.Close();
            }
            Debug.Log("We are here");
        }

      
    }
}