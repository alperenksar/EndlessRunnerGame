using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace RunnerGame.Abstracts.Input
{
    public interface IInputReader 
    {
        float Horizontal { get; }

        bool IsJump { get; }

    }

}



