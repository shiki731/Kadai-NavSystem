using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class EnemySkill : MonoBehaviour
{
    public GetItem _getItem;
    public Transform _playerTransform;
    NavMeshAgent _agent;
    private bool IsUsedSkill;
    private bool _hit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        IsUsedSkill = false;
        _agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 10f, Color.red);

        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit, 10f)){
            if (hit.collider.CompareTag("Player"))
            {
                _hit = true;
            }
            else
            {
                _hit= false;
            }
        }

        // if(_getItem != null) return;
        if(_getItem.getItemNum >= 2 && _hit && !IsUsedSkill)
        {
            Debug.Log("aaa");
            SkillLev1();
        }
        
    }

    void SkillLev1()
    {
        IsUsedSkill = true;
        _agent.isStopped = true;
        StartCoroutine(Attack());
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(1);
        for(int i = 0;i < 10; i++)
        {
            transform.Translate(Vector3.forward * 1.5f);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(0.5f);
        _agent.isStopped = false;
        IsUsedSkill = false;

    }
}
