using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsDictionary : MonoBehaviour
{
    [SerializeField] private Skill[] skills;
    [SerializeField] private Transform skillsParent;


    private Dictionary<string, Skill> skillsByName;

    private void Awake()
    {
        skillsByName = new Dictionary<string, Skill>();
        
        foreach(var skill in skills)
        {
            skillsByName.Add(skill.skillName, skill);
        }
    }

    public Skill CreateSkill(string skillName, Transform playerTransform)
    {
        if(skillsByName.TryGetValue(skillName, out Skill skillPrefab)) 
        {
            Skill skillInstance = Instantiate(skillPrefab, playerTransform.position, Quaternion.identity, skillsParent);
            return skillInstance;
        }
        else
        {
            Debug.LogWarning($"La habilidad {skillName} no existe en la base de datos de habilidades.");
            return null;
        }
    }
}
