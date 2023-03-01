using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] nums;
    [SerializeField] private Camera MainCamera;
    private bool cd = false;
    private float cdTime = 0.2f;
    private float cdCount = 0;
    private SpriteRenderer spriteRenderer;
    private int spawnCounter = 1;

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButton(0) || Input.anyKey) && !cd)
        {
            // spawn position
            float mouseX = MainCamera.ScreenToWorldPoint(Input.mousePosition).x;
            if (mouseX > 4)
            {
                mouseX = 4;
            }
            else if (mouseX < -4)
            {
                mouseX = -4;
            }
            Vector3 pos = new Vector3(mouseX, 4, 0);

            // spawn
            GameObject gameObject = Instantiate(nums[Random.Range(0, nums.Length)], pos, Quaternion.identity);
            spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sortingOrder = spawnCounter;
            spawnCounter++;


            // in cold down
            cd = true;
        }

        // cold down for 0.2 sec
        if (cd)
        {
            cdCount += Time.deltaTime;
            if (cdCount >= cdTime)
            {
                cd = false;
                cdCount = 0;
            }
        }
    }
}
