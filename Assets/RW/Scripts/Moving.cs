using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving : MonoBehaviour
{

	public float horizontalBoundary = 22;
	public float movementSpeed = 50;

	public GameObject hayBalePrefab; 
	public Transform haySpawnpoint; 
	 public float shootInterval; 
	 private float shootTimer;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement ();
        UpdateShooting();

    }

    private void UpdateMovement()
{
 float horizontalInput = Input.GetAxisRaw("Horizontal"); // 1
if (horizontalInput < 0 && transform.position.x > -horizontalBoundary) // 1
 {
 transform.Translate(transform.right * -movementSpeed * Time.deltaTime);
 }
else if (horizontalInput > 0 && transform.position.x < horizontalBoundary) // 2
 {
 transform.Translate(transform.right * movementSpeed * Time.deltaTime);
 }
}


	 private void ShootHay()
 {
 Instantiate(hayBalePrefab, haySpawnpoint .position, Quaternion.identity);
 }


 private void UpdateShooting() {
 shootTimer -= Time.deltaTime;
 if (shootTimer <= 0 && Input.GetKey(KeyCode.Space)) {
 shootTimer = shootInterval;
 ShootHay();
 }
 }

 
}
