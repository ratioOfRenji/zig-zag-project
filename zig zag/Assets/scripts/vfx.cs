using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfx : MonoBehaviour
{
    public static vfx singleton;

    [Header("Collectable Variables")]
    public bool enableRotation;
    public bool enableCollectionVFX;
    //public GameObject[] collectionVFX;
    public GameObject collectionParticleEffect;
    public string collectableTag;
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float rotationAmount;
    public GameObject winUI;
    [Header("Death VFX")]
    public GameObject playerDeathParticleEffect;

    private void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
    }
    private void Start()
    {
        setTags();
      
    }
    private void setTags()
    {
        collectableTag = "collectabe";
    }
    private void Update()
    {
        //if(enableCollectionVFX && enableRotation)
        //{
        //    Rotate();
        //}
    }
    private void findOjects(string tag)
    {
        if(tag == collectableTag)
        { 
      /*  collectionVFX = GameObject.FindGameObjectsWithTag(collectableTag);*/}
    }

    public void Rotate()
    {
        //foreach(var item in collectionVFX)
        //{
        //   item.transform.localEulerAngles = new Vector3( Mathf.PingPong(Time.time * rotationSpeed, rotationAmount),
        //  Mathf.PingPong(Time.time * rotationSpeed, rotationAmount), Mathf.PingPong(Time.time * rotationSpeed, rotationAmount));
        //}
     
    }
    public void instantiateParticleEffect( Collider collider,  float time)
    {
       GameObject temp = Instantiate(collectionParticleEffect, collider.transform.position, Quaternion.identity);
        Destroy(temp, time);
    }
    public void instantiatePayerDathParticleEffect(Transform playerTransform, float time)
    {
        if(winUI.activeInHierarchy == false)
        {
 GameObject temp = Instantiate(playerDeathParticleEffect, playerTransform.position, Quaternion.identity);
        Destroy(temp, time);
        }
       
    }
}
