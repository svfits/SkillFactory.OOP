using System;
using System.Collections.Generic;
using System.Text;

namespace SkillFactory.StartOOP.Library
{
    public abstract class UserAbstract
    {
        public UserAbstract()
        {

        }
        
        public UserAbstract(NervousSystem nervousSystem, Heart heart)
        {
            this.NervousSystem = nervousSystem;
            this.Heart = heart;
        }

        private readonly NervousSystem NervousSystem;
        private readonly Heart Heart;

        /// <summary>
        /// Нервная система работает ли?
        /// </summary>
        public virtual string NervousSystemWork(string name)
        {
            NervousSystem.NervousSystemWorked();
            return name;
        }

        /// <summary>
        /// Сердце работает ли
        /// </summary>
        public virtual string HearWork(string name)
        {
            Heart.HeartBeats();
            return name;
        }
    }
}
