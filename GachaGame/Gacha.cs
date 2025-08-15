namespace exercise;

public class Gacha
{
    public enum Element
    {
        Anemo,
        Hydro,
        Cryo,
        Dendro,
        Pyro,
        Electro,
        Geo
    }

    public enum WeaponType
    {
        Sword,
        Polearm,
        Catalyst,
        Bow,
        Claymore
    }
    
    private string name;
    private string description;
    private int rarity;
    private Element element;
    private WeaponType weapon;
    private bool isEventCharacter;

    public Gacha(Element element, WeaponType weapon, string name, string description, int rarity, bool isEventCharacter)
    {
        this.name = name;
        this.description = description;
        this.rarity = rarity;
        this.element = element;
        this.weapon = weapon;
        this.isEventCharacter = isEventCharacter;
    }
}

public class CharacterDictionary
{
    private Dictionary<string, Gacha> elements;
}