using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Identities : MonoBehaviour
{
    public enum ChineseCharacters
    {
        None,

        // Starters
        一,
        丨,
        丶,
        丿,
        乙,
        亅,
        凵,
        口,
        冂,

        十,
        亠,
        人,
        山,
        了,
        日,
        巾,
        大,

        天,
        太,
        仙,
        子,
        土,
        白,
        市,
        百,
        王,
        玉,
        匕,
        化,
        二,
        田,
        三

    }

    public ChineseCharacters id = ChineseCharacters.None;

    public enum StrokeCount
    {
        None,
        Starter,
        TwoStrokes
    }

    public StrokeCount strokeId = StrokeCount.None;

    
    public enum Position
    {
        None,
        Column,
        Canvas
    }

    public Position positionStatus = Position.None;
}
