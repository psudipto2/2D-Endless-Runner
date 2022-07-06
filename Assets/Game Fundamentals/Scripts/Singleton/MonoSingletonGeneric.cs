using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Singleton
{
    public class MonoSingletonGeneric<T> : MonoBehaviour where T : MonoSingletonGeneric<T>  //creating a generic Singleton
    {
        private static T instance;
        public static T Instance
        {
            get
            {
                return instance;
            }
        }
        protected virtual void Awake()
        {
            if (instance == null)
            {
                instance = (T)this;
                DontDestroyOnLoad(this);
            }
            else if(instance!=this)
            {
                Destroy(instance.gameObject);
                instance = (T)this;
                DontDestroyOnLoad(gameObject);
            }
        }
    }
}
