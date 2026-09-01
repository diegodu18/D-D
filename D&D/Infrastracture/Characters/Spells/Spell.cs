namespace Infrastracture.Characters.Spells
{
    public enum SpellName
    {
        ChillTouch,
        DancingLights,
        Darkness,
        DetectMagic,
        Druidcraft,
        FaerieFire,
        FireBolt,
        HoldPerson,
        Longstrider,
        MistyStep,
        PassWithoutTrace,
        PoisonSprey,
        Prestidigitation,
        RayOfSickness,
        RayOfEnfeeblement,
        FalseLife,
        HellishRebuke,
        MinorIlusion,
        SpeakWithAnimals,
        Mending
    }

    public class Spell
    {
        public short SpellID { get; set; }
        public SpellName SpellName { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public SpellLevel SpellLevel {  get; set; }
        public SchoolOfMagic SchoolOfMagic { get; set; }
        public SpellType SpellType { get; set; }
        public short? Rounds { get; set; }
        public bool RequiresConcentration { get; set; }
    }
}
