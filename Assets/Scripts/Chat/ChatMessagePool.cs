using UnityEngine;

[CreateAssetMenu(menuName = "Chat/MessagePool")]
public class ChatMessagePool : ScriptableObject
{
    public string[] usernames = {
    "xX_ghost_Xx", "viewer123", "spookyfan", "coolcat99", "noobmaster",
    "thunderbird", "lazypanda", "fastturtle", "silentfox", "blobfish42",
    "noodlearms", "crackerbox", "potatoking", "waffletime", "toastmaster",
    "gummybear", "jellybean7", "marshmallow", "candycorn", "sugarrush",
    "pixelwizard", "codemonkey", "techbro420", "keyboardcat", "mouseclicker",
    "cloudnine", "rainydayz", "sunnyside", "moonwalker", "stargazer99",
    "couchsurfer", "napmaster", "sleepyhead", "lazysunday", "mondayblues",
    "coffeehead", "teabagging", "hotchocolat", "milkdrinker", "juicebox",
    "sandwichman", "burgerlord", "pizzatime", "tacotues", "nachodip",
    "frenchfry99", "onionring", "ketchupking", "mustardman", "relishguy",
    "soccerball", "basketcase", "tennisace", "golfswing", "baseballbat",
    "footballfan", "hockeyface", "bowlingpin", "dartmaster", "poolshark",
    "guitarface", "drumstick9", "basslines", "keyboardist", "violinman",
    "paintbrush", "sketchbook", "doodleking", "artmaster", "colorwheel",
    "bookworm42", "pageturner", "librarycard", "novelreader", "plottwist",
    "moviebuff", "filmcritic", "popcornlvr", "reelmaster", "scenestealer",
    "dogperson", "catperson", "fishkeeper", "birdwatcher", "hamsterwheel",
    "runningman", "joggerlife", "cyclingpro", "hikerboy", "campervan",
    "randomdude", "justaguyyy", "normalperson", "regularguy", "basicuser"
    };

    [System.Serializable]
    public class Category
    {
        public string tag;
        public string[] messages;
    }

    public Category[] categories;

    public string GetRandom(string tag)
    {
        foreach (var cat in categories)
            if (cat.tag == tag)
                return cat.messages[Random.Range(0, cat.messages.Length)];

        return "lol";
    }

    public string GetRandomUsername()
    {
        return usernames[Random.Range(0, usernames.Length)];
    }
}