using System;
using String = System.String;

namespace CoreLib.Components
{
    public class ModRangeWeaponCDAuthoring : ModCDAuthoringBase
    {
        public String projectileID;
        public float spawnOffsetDistance;
        public bool Allocate()
        {
            return default(bool);
        }

        public bool Apply(EntityMonoBehaviourData data)
        {
            return default(bool);
        }
    }
}