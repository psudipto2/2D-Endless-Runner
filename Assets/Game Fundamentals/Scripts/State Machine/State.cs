using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using Singleton;
using ObstacleScriptable;
using ObstacleMVC;

namespace StateMachine
{
    public class State : MonoSingletonGeneric<State>
    {
        [SerializeField] protected ObstacleScriptableObjectList[] obstacleScriptableObjectLists;
        [SerializeField] private State[] states;
        protected ObstacleScriptableObjectList ObstacleScriptableObjectList;
        protected ObstacleScriptableObject obstacle;
        protected State currentState;
        protected State activeState;
        protected float timeBetweenChangeState=10f;
        protected float timeBeweenSpawn = 0.9f;
        protected float changeStateTime;
        protected float spawnTime;
        protected void Start()
        {
            int rand = Random.Range(0, 4);
            currentState = states[rand];
            currentState.OnStateEnter();
        }
        public virtual void OnStateEnter()
        {
            this.enabled = true;
        }
        public virtual void OnStateExit()
        {
            this.enabled = false;
        }
        protected void Update()
        {
            ChangeState();
            SpawnObstacle();
        }

        private void SpawnObstacle()
        {
            if (Time.time > spawnTime)
            {
                SetObstacle();
                ObstacleService.Instance.CreateNewObstacle(obstacle);
                spawnTime = Time.time + timeBeweenSpawn;
            }
        }

        private void ChangeState()
        {
            if (Time.time > changeStateTime)
            {
                int rand = Random.Range(0, 4);
                currentState = states[rand];
                if (currentState != activeState)
                {
                    currentState.OnStateEnter();
                }
                changeStateTime = Time.time + timeBetweenChangeState;
            }
        }

        private void SetObstacle()
        {
            int direction = Random.Range(0, 2);
            ObstacleScriptableObjectList = currentState.obstacleScriptableObjectLists[direction];
            int chooseObs = Random.Range(0, 3);
            obstacle = ObstacleScriptableObjectList.Obstacles[chooseObs];
        }

    }
}
