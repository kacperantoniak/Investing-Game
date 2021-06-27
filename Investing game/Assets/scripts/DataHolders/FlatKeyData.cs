using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatKeyData
{
    public static int ex_key_helper;
    public int external_key;

    public void update_Data()
    {
        external_key = ex_key_helper;
    }
}
