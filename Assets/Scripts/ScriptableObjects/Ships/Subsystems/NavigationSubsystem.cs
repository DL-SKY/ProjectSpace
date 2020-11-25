using ProjectSpace.Enums;
using ProjectSpace.Interfaces.Ships;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Object.Ships.Subsystems
{
    public class NavigationSubsystem : MonoBehaviour, ISpaceshipSubsystem
    {
        private Transform spaceshipTransform;
        private Transform spaceshipBow;

        public EnumSubsystems SubsystemType => EnumSubsystems.Navigation;


        public void Initialize(ISpaceship _spaceship)
        {
            spaceshipTransform = _spaceship.SpaceshipTransform;
            spaceshipBow = _spaceship.SpaceshipBow;
        }
    }
}
