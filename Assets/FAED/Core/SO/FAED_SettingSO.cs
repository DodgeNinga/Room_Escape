using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FD.Core
{

    public class FAED_SettingSO : ScriptableObject
    {

        [HideInInspector] public bool usePooling;

        public FAED_PoolingSO poolingSO;

    }


}