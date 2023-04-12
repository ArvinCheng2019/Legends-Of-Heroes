﻿namespace ET
{
    /// <summary>
	/// 技能事件类型
	/// </summary>
    public enum ESkillEventType
    {
        /// <summary>
		/// 范围伤害
		/// </summary>
	    RangeDamage = 1,
        /// <summary>
		/// 子弹
		/// </summary>
	    Bullet = 2,
        /// <summary>
		/// 添加buff
		/// </summary>
	    AddBuff = 3,
        /// <summary>
		/// 移除buff
		/// </summary>
	    RemoveBuff = 4,
        /// <summary>
		/// 隐身
		/// </summary>
        Stealth = 5,
    }

    /// <summary>
    /// 技能抽象类型
    /// </summary>
    public enum ESkillAbstractType
    {
        /// <summary>
        /// 普攻
        /// </summary>
        NormalAttack = 1,
        /// <summary>
        /// 主动技能
        /// </summary>
        ActiveSkill = 2,
        /// <summary>
        /// 被动技能
        /// </summary>
        PassiveSkill = 3,
        /// <summary>
        /// 武器技能
        /// </summary>
        WeaponSkill = 4,
        /// <summary>
        /// 坐骑技能
        /// </summary>
        MountSkill = 5,
    }

    /// <summary>
    /// 输入操作类型
    /// </summary>
    public enum EInputType
    {
        Key,
        KeyDown,
        KeyUp,
    }
    
    public enum EOperateType
    {
        Move = 0,
        Jump = 1,
        Attack = 2,//普攻
        Skill1,
        Skill2,
        Skill3,
        Skill4,
    }
    
}
