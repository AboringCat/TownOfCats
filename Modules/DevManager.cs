using System.Collections.Generic;
using System.Linq;

namespace TOC;

public class DevUser(string code = "", string color = "null", string tag = "null", bool isUp = false, bool isDev = false, bool deBug = false, bool colorCmd = false, string upName = "Unknown")
{
    public string Code { get; set; } = code;
    public string Color { get; set; } = color;
    public string Tag { get; set; } = tag;
    public bool IsUp { get; set; } = isUp;
    public bool IsDev { get; set; } = isDev;
    public bool DeBug { get; set; } = deBug;
    public bool ColorCmd { get; set; } = colorCmd;
    public string UpName { get; set; } = upName;

    public bool HasTag() => Tag != "null";
    public string GetTag() => Color == "null" ? $"<size=1.4>{Tag}</size>\r\n" : $"<color={Color}><size=1.4>{(Tag == "#Dev" ? Translator.GetString("Developer") : Tag)}</size></color>\r\n";
}

public static class DevManager
{
    public static DevUser DefaultDevUser = new();
    public static List<DevUser> DevUserList = [];

    public static void Init()
    {
        DevUserList =
        [
            // Dev
            new(code: "actorour#0029", color: "#ffc0cb", tag: "TOHE/TONX Developer", isUp: true, isDev: true, deBug: true, colorCmd: true, upName: "KARPED1EM"),

            // TOC players
            new(code: "neatnet#5851", color: "#FFFF00", tag: "[Developer] The 200IQ guy", isUp: true, isDev: true, deBug: true, colorCmd: true, upName: "[Developer] The 200IQ guy"),
            new(code: "contenthue#0404", color: "#FFFF00", tag: "[Developer] The 200IQ guy", isUp: true, isDev: true, deBug: true, colorCmd: true, upName: "[Developer] The 200IQ guy"),
            new(code: "ravenknurl#4562", color: "#008000", tag: "Moderador do FH", isUp: false, isDev: false, deBug: false, colorCmd: false, upName: "RicardoFumante"),
            new(code: "crustzonal#9589", color: "#00FFFF", tag: "Translator PT-BR", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "artyleague01"),
            new(code: "tinedpun#6584", color: "#0000ff", tag: "Translator PT-BR", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Dechis"),
            new(code: "swiftlord#8072", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "But What About"),
            new(code: "ovalinstep#2984", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Seleneous"),
            new(code: "seleneous#6930", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Seleneous"),
            new(code: "innerruler#4140", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "thewhiskas27"),
            new(code: "urbanecalf#4975", color: "#420773", tag: "Streamer", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Gugutsik"),
            new(code: "crustzonal#9589", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "aviiiv0102"),
            new(code: "tubedilute#9062", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Xcl4udioX"),
            new(code: "ponyholey#5532", color: "#0000FF", tag: "desenvolvedor", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "DrawingsZz"),
            new(code: "akinlaptop#2206", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "MR Carr"),
            new(code: "fursilty#4676", color: "#0000ff", tag: "arthurzin", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "arthurzin"),
            new(code: "stonefuzzy#8673", color: "#ff0062", tag: "<size=1.6>Ru Translator</size>", isUp: true, isDev: true, deBug: true, colorCmd: true, upName: "HyperAtill"),
            new(code: "frizzytram#2508", color: "#1C87FF", tag: "RafaelBIT50", isUp: false, isDev: false, deBug: false, colorCmd: false, upName: "RafaelBIT50"),
            new(code: "foggyzing#6238", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "LdZinnn"),
            new(code: "onsideblur#3929", color: "#fc3a51", tag: "YouTuber", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Manelzin"),
            new(code: "modestspan#7071", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Shark"),
            new(code: "divotbusy#0624", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "PreCeptorBR"),
            new(code: "pinsrustic#5496", color: "#fc3a51", tag: "YouTuber", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "FHgameplay"),
            new(code: "opaquedot#5610", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Deh_66"),
            new(code: "furpolitic#3380", color: "#a020f0", tag: "EuOncologico o impostor", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "EuOncologico"),
            new(code: "pithfierce#5073", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "OrigeTv"),
            new(code: "cannylink#0564", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "SpicyPoops"),
            new(code: "ghostapt#7243", color: "#a48d6b", tag: "AUME", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "MasterKy"),
            new(code: "planegame#5847", color: "#44fff7", tag: "Kopp56", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Kopp56 PRO"),
            new(code: "clovesorry#6973", color: "#191970", tag: "Master", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "MAT"),
            new(code: "ivorywish#3580", color: "#ff0000", tag: "YouTuber", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "Erik Carr"),
            new(code: "cleardress#6310", color: "#ffffff", tag: "<#00BFFF>一</color><#48D1CC>个</color><#7CFC00>热狗</color><#32CD32>uwu</color>", isUp: true, isDev: true, deBug: true, colorCmd: true, upName: "ABoringCat"),
            new(code: "rainypearl#9545", color: "#A020F0", tag: "YouTuber", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "bielModzs"),
            new(code: "kiltedbill#4145", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "tsaki84"),
            new(code: "onlyfax#3941", color: "#ff0000", tag: "YouTuber", isUp: true, isDev: false, deBug: false, colorCmd: false, upName: "The Nick AG"),

            // Sponsor
            // Other
            new(code: "peakcrown#8292", color: "null", tag: "null", isUp: true, isDev: false, deBug: false, colorCmd: true, upName: null), //Hakaka
        ];
    }

    public static bool IsDevUser(this string code) => DevUserList.Any(x => x.Code == code);
    public static DevUser GetDevUser(this string code) => code.IsDevUser() ? DevUserList.Find(x => x.Code == code) : DefaultDevUser;
}