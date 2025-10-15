using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class door : MonoBehaviour
{
    public void GetBumped()
    {
       Destroy(gameObject);
    }
}
