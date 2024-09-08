using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// host alll info we need about dialogue
// serializable so we can edit
[System.Serializable]
public class Dialogue
{
    // name of NPC and thheir dialogue
    public string name;

    //make text box bigger
    [TextArea(3,10)]
    public string[] sentences;
}
