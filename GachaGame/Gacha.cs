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

    private int rollId;
    private string name;
    private string description;
    private int rarity;
    private Element element;
    private WeaponType weapon;
    private bool isEventCharacter;

    public Gacha(int rollId, Element element, WeaponType weapon, string name, string description, int rarity, bool isEventCharacter)
    {
        this.rollId = rollId;
        this.name = name;
        this.description = description;
        this.rarity = rarity;
        this.element = element;
        this.weapon = weapon;
        this.isEventCharacter = isEventCharacter;
    }

    public override string ToString()
    {
        return name;
    }
}

public class Inventory
{
    private List<Gacha> items = new();

    public List<Gacha> returnInventory()
    {
        return this.items;
    }
}

public class CharacterDictionary
{

    public static readonly Dictionary<int, Gacha> Characters = new()
    {
        { 1, new Gacha(1, Gacha.Element.Anemo, Gacha.WeaponType.Sword, "Aether", "Traveler from another world", 5, false) },
        { 2, new Gacha(2, Gacha.Element.Pyro, Gacha.WeaponType.Bow, "Amber", "Outrider of the Knights", 4, false) },
        { 3, new Gacha(3, Gacha.Element.Electro, Gacha.WeaponType.Catalyst, "Lisa", "Knowledgeable librarian", 4, false) },
        { 4, new Gacha(4, Gacha.Element.Pyro, Gacha.WeaponType.Claymore, "Diluc", "Owner of Dawn Winery", 5, false) },
        { 5, new Gacha(5, Gacha.Element.Anemo, Gacha.WeaponType.Bow, "Venti", "Free-spirited bard", 5, true) }
    };

    public Gacha getGacha(int seed)
    {
        return Characters[seed];
    }
}
