using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSpace.Interfaces.Ships
{
    public interface ISpaceship
    {
        List<ISpaceshipSubsystem> Subsystems { get; }
        Transform SpaceshipTransform { get; }
        Transform SpaceshipBow { get; }
    }
}
