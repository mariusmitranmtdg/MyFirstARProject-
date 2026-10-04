using UnityEngine;

public class Cactus : MonoBehaviour
{
    public Transform targetCharacter; 
    
    public float attackDistance = 0.25f; 

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (targetCharacter != null)
        {
            float distance = Vector3.Distance(transform.position, targetCharacter.position);

            if (distance <= attackDistance)
            {
                animator.SetBool("attacking", true);
            }
            else
            {
                animator.SetBool("attacking", false);
            }
        }
    }
}