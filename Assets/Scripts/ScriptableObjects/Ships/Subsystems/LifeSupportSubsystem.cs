using ProjectSpace.Enums;
using ProjectSpace.Interfaces.Ships;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships.Subsystems
{
    public class LifeSupportSubsystem : MonoBehaviour, ISpaceshipSubsystem
    {
        public EnumSubsystems SubsystemType => EnumSubsystems.LifeSupport;


        public void Initialize(ISpaceship _spaceship)
        {

        }
    }
}
