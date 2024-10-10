using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tipUnlockStore : MonoBehaviour
{

    public static List<int> unlockedTips = new List<int>();

    public static List<string> tipList = new List<string>();

    public static List<int> lockedTips = new List<int>();

    // Start is called before the first frame update
    void Start()
    {

        lockedTips.Add(1);
        lockedTips.Add(2);
        lockedTips.Add(3);
        lockedTips.Add(4);
        lockedTips.Add(5);
        lockedTips.Add(6);
        lockedTips.Add(7);
        lockedTips.Add(8);
        lockedTips.Add(9);

        tipList.Clear();

        // tip 1
        tipList.Add("If a foe doth not possess a health bar, then likely it may not be slain.");

        //tip 2
        tipList.Add("Thou shalt regain all thy health when thou enterest a new chamber, so there is no need to tarry for thy health to be restored.");

        // tip 3
        tipList.Add("Thou canst not attack foes through walls, for I know this to be true, having made the attempt myself.");

        // tip 4
        tipList.Add("Anubis art likely to reflect projectiles launched against them.");

        // tip 5
        tipList.Add("Approach not too near to spores, for they may verily explode.");

        // tip 6
        tipList.Add("Potions do increase thy stats for the remainder of the endeavor, and so thou shouldst employ them plentifully.");

        // tip 7
        tipList.Add("Employ not thy abilities when no foes be present, 'tis but simple counsel.");


        // tip 8
        tipList.Add("Verily, one may press the space bar whilst the game is paused to forthwith resume thine endeavor.");

        // tip 9
        tipList.Add("Prithee, if by chance thou dost encounter a metallic serpent, thy ranged arms shall likely prove ineffective against it.");

        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
