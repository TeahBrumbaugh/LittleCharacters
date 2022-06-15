using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collisions : MonoBehaviour
{
    public CharacterGameManager characterGameManagerScript;

    public AudioSource newComboNotif;
    public AudioSource comboNotif;

    public GameObject canvas;
    public GameObject 十;
    public GameObject 亠;
    public GameObject 人;
    public GameObject 山;
    public GameObject 了;
    public GameObject 日;
    public GameObject 巾;
    public GameObject 大;
    public GameObject 天;
    public GameObject 太;
    public GameObject 仙;
    public GameObject 子;
    public GameObject 土;
    public GameObject 白;
    public GameObject 市;
    public GameObject 百;
    public GameObject 王;
    public GameObject 玉;
    public GameObject 匕;
    public GameObject 化;
    public GameObject 二;
    public GameObject 田;
    public GameObject 三;

    private bool destroy;

    private void Awake()
    {
        characterGameManagerScript = GameObject.FindObjectOfType<CharacterGameManager>();

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        destroy = false;

        Identities character1 = collision.GetComponent<Identities>();
        Identities character2 = this.GetComponent<Identities>();

        if (character1.id == Identities.ChineseCharacters.一 && character2.id == Identities.ChineseCharacters.丨)
        {
            RevealCharacter(十);
        }

        if (character1.id == Identities.ChineseCharacters.一 && character2.id == Identities.ChineseCharacters.丶)
        {
            RevealCharacter(亠);
        }

        if (character1.id == Identities.ChineseCharacters.丿 && character2.id == Identities.ChineseCharacters.丨)
        {
            RevealCharacter(人);
        }

        if (character1.id == Identities.ChineseCharacters.凵 && character2.id == Identities.ChineseCharacters.丨)
        {
            RevealCharacter(山);
        }

        if (character1.id == Identities.ChineseCharacters.乙 && character2.id == Identities.ChineseCharacters.亅)
        {
            RevealCharacter(了);
        }

        if (character1.id == Identities.ChineseCharacters.口 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(日);
        }

        if (character1.id == Identities.ChineseCharacters.冂 && character2.id == Identities.ChineseCharacters.丨)
        {
            RevealCharacter(巾);
        }

        if (character1.id == Identities.ChineseCharacters.一 && character2.id == Identities.ChineseCharacters.人)
        {
            RevealCharacter(大);
        }

        if (character1.id == Identities.ChineseCharacters.一 && character2.id == Identities.ChineseCharacters.大)
        {
            RevealCharacter(天);
        }

        if (character1.id == Identities.ChineseCharacters.丶 && character2.id == Identities.ChineseCharacters.大)
        {
            RevealCharacter(太);
        }

        if (character1.id == Identities.ChineseCharacters.山 && character2.id == Identities.ChineseCharacters.人)
        {
            RevealCharacter(仙);
        }

        if (character1.id == Identities.ChineseCharacters.了 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(子);
        }

        if (character1.id == Identities.ChineseCharacters.十 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(土);
        }

        if (character1.id == Identities.ChineseCharacters.日 && character2.id == Identities.ChineseCharacters.丿)
        {
            RevealCharacter(白);
        }

        if (character1.id == Identities.ChineseCharacters.亠 && character2.id == Identities.ChineseCharacters.巾)
        {
            RevealCharacter(市);
        }

        if (character1.id == Identities.ChineseCharacters.白 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(百);
        }

        if (character1.id == Identities.ChineseCharacters.土 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(王);
        }

        if (character1.id == Identities.ChineseCharacters.王 && character2.id == Identities.ChineseCharacters.丶)
        {
            RevealCharacter(玉);
        }

        if (character1.id == Identities.ChineseCharacters.乙 && character2.id == Identities.ChineseCharacters.丿)
        {
            RevealCharacter(匕);
        }

        if (character1.id == Identities.ChineseCharacters.匕 && character2.id == Identities.ChineseCharacters.人)
        {
            RevealCharacter(化);
        }

        if (character1.id == Identities.ChineseCharacters.一 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(二);
        }

        if (character1.id == Identities.ChineseCharacters.冂 && character2.id == Identities.ChineseCharacters.土)
        {
            RevealCharacter(田);
        }

        if (character1.id == Identities.ChineseCharacters.二 && character2.id == Identities.ChineseCharacters.一)
        {
            RevealCharacter(三);
        }

        if (destroy == true)
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }



    private void RevealCharacter(GameObject character)
    {
        if (character.activeSelf == false)
        {
            newComboNotif.Play();

            character.SetActive(true);

            GameObject copy = Instantiate(character, this.transform.position, Quaternion.identity);
            copy.transform.SetParent(canvas.transform, true);
            copy.GetComponent<Identities>().positionStatus = Identities.Position.Canvas;

            characterGameManagerScript.CountScore(1);
        }

        else
        {
            comboNotif.Play();

            GameObject copy = Instantiate(character, this.transform.position, Quaternion.identity);
            copy.transform.SetParent(canvas.transform, true);
            copy.GetComponent<Identities>().positionStatus = Identities.Position.Canvas;
        }

        destroy = true;
        return;
    }
}
