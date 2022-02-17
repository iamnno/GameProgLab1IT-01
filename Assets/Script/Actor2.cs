using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor2 : MonoBehaviour
{
    [Header("Player velocity")]
    // Вісь Ox
    public int xVelocity = 5;
    // Вісь Oy
    public int yVelocity = 8;

    // Фізика тіла
    private Rigidbody2D rigidBody;
    //==================
    private void Start()
    { // Отримання доступу до фізики тіла Актора
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
        Debug.Log("Start Test 1 *******");
    }
    //===================
    private void Update()
    {
        updatePlayerPosition();
        Debug.Log("Update Test 1 *******");
    }
    //===================
    // Оновлення розташування гравця
    private void updatePlayerPosition()
    {
        //  Отримуємо значення введення горизонтального переміщення
        float moveInput = Input.GetAxis("Horizontal");
        // Отримуємо значення введення стрибка
        float jumpInput = Input.GetAxis("Jump");
        // 

        if (moveInput < 0)
        { // Рух ліворуч
            rigidBody.velocity = new Vector2(-xVelocity, rigidBody.velocity.y);
        }
        else if (moveInput > 0)
        { // Рух праворуч
            rigidBody.velocity = new Vector2(xVelocity, rigidBody.velocity.y);
        }
        if (jumpInput > 0)
        { // Стрибки
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, yVelocity);
        }
    }

    private void Awake()
    {
        Debug.Log("Awake Test 1 *******");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable Test 1 *******");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Test 1 *******");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate Test 1 *******");
    }

    private void OnGUI()
    {
        Debug.Log("OnGUI");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy");
    }
}
