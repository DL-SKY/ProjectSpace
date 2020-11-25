using ProjectSpace.Enums;
using ProjectSpace.Interfaces.Ships;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships.Subsystems
{
    public class WeaponSubsystem : MonoBehaviour, ISpaceshipSubsystem
    {
        public EnumSubsystems SubsystemType => EnumSubsystems.Weapon;


        public void Initialize(ISpaceship _spaceship)
        {

        }
    }
}
