using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalFlatKey : MonoBehaviour
{
    public static int flat_key = 0;
    public int internal_key;
    // Update is called once per frame
    void Update()
    {
        internal_key = flat_key;
        FlatKeyData.ex_key_helper = internal_key;
    }
}
