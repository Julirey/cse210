using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ScriptureGenerator
{
    // Attributes
    
    private List<string> _scriptures = new List<string>();

    // Methods

    public void LoadScriptures()
    {
        _scriptures.Add("Isaiah~55~7~Let the wicked forsake their ways and the unrighteous their thoughts. Let them turn to the Lord, and he will have mercy on them, and to our God, for he will freely pardon.");
        _scriptures.Add("Matthew~27~28~29~They stripped him and put a scarlet robe on him, and then twisted together a crown of thorns and set it on his head. They put a staff in his right hand. Then they knelt in front of him and mocked him. “Hail, king of the Jews!” they said.");
        _scriptures.Add("1 Peter~2~9~But you are a chosen people, a royal priesthood, a holy nation, God's special possession, that you may declare the praises of him who called you out of darkness into his wonderful light.");
        _scriptures.Add("John~3~21~But whoever lives by the truth comes into the light, so that it may be seen plainly that what they have done has been done in the sight of God.");
        _scriptures.Add("Galatians~5~22~23~But the fruit of the Spirit is love, joy, peace, forbearance, kindness, goodness, faithfulness, gentleness and self-control. Against such things there is no law.");
        _scriptures.Add("Luke~6~27~28~But to you who are listening I say: Love your enemies, do good to those who hate you, bless those who curse you, pray for those who mistreat you.");
        _scriptures.Add("Psalm~37~16~17~Better the little that the righteous have than the wealth of many wicked; for the power of the wicked will be broken, but the Lord upholds the righteous.");
    }

    public string GetScripture()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _scriptures.Count);

        string scripture = _scriptures[number];
        return scripture;
    }
}

