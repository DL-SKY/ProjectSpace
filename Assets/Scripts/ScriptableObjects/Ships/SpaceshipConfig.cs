using ProjectSpace.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.ScriptableObjects.Ships
{
    [CreateAssetMenu(fileName = "SpaceshipConfig", menuName = "Scriptable/Ships/Config")]
    public class SpaceshipConfig : ScriptableObject
    {
        [Space()]
        public string modelID;
        public EnumSizetype sizetype;

        [Space()]
        [Range(0, 6)] public int maxOfficers;
    }
}
