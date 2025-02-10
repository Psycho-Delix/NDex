using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Player : MonoBehaviour
    {
        private Dictionary<Type, IPlayerBehavior> _behaviorsMap;
        private IPlayerBehavior _behaviorCurrent;

        private void Start()
        {
            InitBehaviors();
            SetBehaviorByDefault();
        }

        private void Update()
        {
            if(_behaviorCurrent != null)
            {
                _behaviorCurrent.Update();
            }
        }

        public void SetBehaviorIdle()
        {
            var behavior = GetBehavior<PlayerBehaviorIdle>();
            SetBehavior(behavior);
        }

        public void SetBehaviorActive()
        {
            var behavior = GetBehavior<PlayerBehaviorActive>();
            SetBehavior(behavior);
        }

        public void SetBehaviorAggressive()
        {
            var behavior = GetBehavior<PlayerBehaviorAggressive>();
            SetBehavior(behavior);
        }

        private void InitBehaviors()
        {
            _behaviorsMap = new Dictionary<Type, IPlayerBehavior>();
            _behaviorsMap[typeof(PlayerBehaviorActive)] = new PlayerBehaviorActive();
            _behaviorsMap[typeof(PlayerBehaviorAggressive)] = new PlayerBehaviorAggressive();
            _behaviorsMap[typeof(PlayerBehaviorIdle)] = new PlayerBehaviorIdle();
        }

        private void SetBehavior(IPlayerBehavior newBehavior)
        {
            if(_behaviorCurrent != null)
            {
                _behaviorCurrent.Exit();
            }

            _behaviorCurrent = newBehavior;
            _behaviorCurrent.Enter();
        }

        private void SetBehaviorByDefault()
        {
            SetBehaviorIdle();
        }

        private IPlayerBehavior GetBehavior<T>() where T : IPlayerBehavior
        {
            var type = typeof(T);
            return _behaviorsMap[type];
        }
    }
}


