using UnityEngine;
using UnityEngine.AI;

public class EnemySkill : MonoBehaviour
{
    public GetItem _getItem;
    public Transform _playerTransform;
    NavMeshAgent _agent;
    private bool IsUsedSkill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsUsedSkill = false;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_getItem != null) return;
        if(_getItem.getItemNum >= 2)
        {

        }
        else if( _getItem.getItemNum == 1)
        {

        }
    }

    void SkillLev1()
    {
        _agent.isStopped = true;
    }
}
