using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StateMachine;
using Singleton;
using ObstacleScriptable;
using ObstacleMVC;
using GroundScriptable;
using GroundMVC;

namespace StateMachine
{
    public class State : MonoSingletonGeneric<State>
    {
        [SerializeField] protected ObstacleScriptableObjectList[] obstacleScriptableObjectLists;
        [SerializeField] private State[] states;
        [SerializeField] private GroundScriptableObjectList groundSOList;
        [SerializeField] protected GroundScriptableObject ground;
        protected ObstacleScriptableObjectList ObstacleScriptableObjectList;
        protected ObstacleScriptableObject obstacle;
        protected State currentState;
        protected State activeState;
        protected float timeBetweenChangeState=10f;
        protected float timeBeweenSpawn = 0.9f;
        protected float changeStateTime;
        protected float obstacleSpawnTime;
        protected float groundSpawnTime;

        protected void Start()
        {
            int rand = Random.Range(0, 4);
            currentState = states[rand];
            currentState.OnStateEnter();
            currentState.ground = groundSOList.groundList[rand];
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
            SpawnGround();
        }

        private void SpawnObstacle()
        {
            if (Time.time > obstacleSpawnTime)
            {
                SetObstacle();
                ObstacleService.Instance.CreateNewObstacle(obstacle);
                obstacleSpawnTime = Time.time + timeBeweenSpawn;
            }
        }
        private void SpawnGround()
        {
            if (Time.time > groundSpawnTime)
            {
                GroundService.Instance.CreateNewGround(currentState.ground);
                groundSpawnTime = Time.time + 0.53f;
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
                    currentState.ground = groundSOList.groundList[rand];
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
