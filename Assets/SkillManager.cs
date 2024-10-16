using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillManager : MonoBehaviour
{
    public SkillsDictionary skillFactory;
    [SerializeField] private Transform player;
    

    public void ActivateSkill(string skillName)
    {
        Skill skillToActivate = skillFactory.CreateSkill(skillName, player);
        skillToActivate.Activate();
    }
}
