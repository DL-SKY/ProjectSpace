using ProjectSpace.Enums;
using ProjectSpace.Interfaces.Ships;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships.Subsystems
{
    public class EnergySubsystem : MonoBehaviour, ISpaceshipSubsystem
    {
        public EnumSubsystems SubsystemType => EnumSubsystems.Energy;


        public void Initialize(ISpaceship _spaceship)
        {

        }
    }
}
