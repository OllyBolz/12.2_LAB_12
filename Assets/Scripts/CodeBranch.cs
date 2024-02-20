#define SOME_SYMBOL
#if SOME_SYMBOL
//Symbol is already defined
#else
//Symbol is undefined
#endif

//#undef SOME_SYMBOL
#if SOME_SYMBOL
//Symbol is already defined
#else
//Symbol is undefined
#endif

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeBranch : MonoBehaviour
{

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
