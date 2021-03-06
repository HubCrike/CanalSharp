﻿using CanalSharp.Common.Exception;

namespace CanalSharp.Common
{
    public abstract class AbstractCanalLifeCycle : ICanalLifeCycle
    {
        /// <summary>
        /// 是否处于运行中
        /// </summary>
        protected volatile bool Running; 

        public bool IsStart()
        {
            return Running;
        }

        public virtual void Start()
        {
            if (Running)
            {
                throw new CanalException($" {nameof(AbstractCanalLifeCycle)} has startup , don't repeat start");
            }

            Running = true;
        }

        public virtual void Stop()
        {
            if (!Running)
            {
                throw new CanalException($"{nameof(AbstractCanalLifeCycle)} isn't start , please check");
            }

            Running = false;
        }
    }
}