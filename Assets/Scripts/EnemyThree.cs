using UnityEngine;
using System.Collections;


    public class EnemyThree : MonoBehaviour
    {
        private Rigidbody2D rb2d;

        void Start()
        {

        }

        void Awake()
        {
            rb2d = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
        }

        void FixedUpdate()
        {
            Vector3 temp = new Vector3(0.1f, 0f);
            rb2d.transform.position -= temp;
        }
    }

