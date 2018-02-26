using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class lotusFlowerController : MonoBehaviour
{
    private int caughtCount = 0;

    void Start()
    {
        DOTween.Init();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("flowerCollisionPoint") && other.transform.childCount == 0)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.parent = other.transform;
            transform.DOLocalMove(Vector3.zero, 3, false);
            transform.DOLocalRotate(Vector3.zero, 3, RotateMode.Fast);

            //Register a "lotus caught" event only once from this object
            caughtCount += 1;

            if (caughtCount <= 1)
            {
                //transform.GetChild(0).gameObject.SetActive(true);
                init.stateManager.SET_LOTUS_CATCH_COUNT(stateManager.lotusCatchCount += caughtCount);
            }
        }
    }
}