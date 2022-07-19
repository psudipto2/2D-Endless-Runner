using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Singleton;
using System;

namespace Common
{
    public class EventService : MonoSingletonGeneric<EventService>
    {
        public event Action passedObstacle;
        public event Action collectedStar;
        public void InvokeOnPassingObstacle()
        {
            passedObstacle?.Invoke();
        }
        public void InvokeOnCollectingStar()
        {
            collectedStar?.Invoke();
        }
    }
}
