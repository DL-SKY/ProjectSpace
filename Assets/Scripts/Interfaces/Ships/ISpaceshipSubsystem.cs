using ProjectSpace.Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Interfaces.Ships
{
    public interface ISpaceshipSubsystem
    {
        EnumSubsystems SubsystemType { get; }

        void Initialize(ISpaceship _spaceship);
    }
}
