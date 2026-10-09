using UnityEngine;

public class GetItem: MonoBehaviour
{
    public int getItemNum;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        getItemNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Item")
        {
            getItemNum++;
            Destroy(other.gameObject);
        }
    }

    void GetItems()
    {
        
    }
}
