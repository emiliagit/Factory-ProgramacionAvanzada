using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Skill
{
    public override string skillName => "Power Up";
    public override void Activate()
    {
        Destroy(gameObject, lifeTime);
    }
}
