using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FD.Core
{

    [System.Serializable]
    public class FAED_ScenePoolingObject
    {

        public string sceneName;
        public List<FAED_PoolingObject> scenePoolingObjects;

    }

    [System.Serializable]
    public class FAED_PoolingObject
    {

        public string poolingKey;
        public GameObject poolingObject;
        public int poolCount;

    }

    public class FAED_PoolObj
    {

        public GameObject originObj;
        public Queue<GameObject> objectQuque;

        public FAED_PoolObj(GameObject originObj, Queue<GameObject> objectQuque)
        {
            this.originObj = originObj;
            this.objectQuque = objectQuque;
        }
    }

}