using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood : Skill
{
    public override string skillName => "Blood";
    public override void Activate()
    {
        Destroy(gameObject, lifeTime);
    }
}
