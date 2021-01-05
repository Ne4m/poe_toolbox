using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deti_Poe_ToolBox
{
    class seedsJS
    {
        public class Rootobject
        {
            public Result[] result { get; set; }

        }

        public class Result
        {
            public string id { get; set; }
            public Listing listing { get; set; }
            public Item item { get; set; }
        }

        public class Listing
        {
            public string method { get; set; }
            public DateTime indexed { get; set; }
            public Stash stash { get; set; }
            public string whisper { get; set; }
            public Account account { get; set; }
            public Price price { get; set; }
        }

        public class Stash
        {
            public string name { get; set; }
            public int x { get; set; }
            public int y { get; set; }
        }

        public class Account
        {
            public string name { get; set; }
            public string lastCharacterName { get; set; }
            public Online online { get; set; }
            public string language { get; set; }
        }

        public class Online
        {
            public string league { get; set; }
            public string status { get; set; }
        }

        public class Price
        {
            public string type { get; set; }
            public float amount { get; set; }
            public string currency { get; set; }
        }

        public class Item
        {
            public bool verified { get; set; }
            public int w { get; set; }
            public int h { get; set; }
            public string icon { get; set; }
            public string league { get; set; }
            public Socket[] sockets { get; set; }
            public string name { get; set; }
            public string typeLine { get; set; }
            public bool identified { get; set; }
            public int ilvl { get; set; }
            public string note { get; set; }
            public Property1[] properties { get; set; }
            public Requirement[] requirements { get; set; }
            public int frameType { get; set; }
            public Extended extended { get; set; }
            public string[] explicitMods { get; set; }
            public bool corrupted { get; set; }
            public string[] flavourText { get; set; }
            public Influences influences { get; set; }
            public bool shaper { get; set; }
            public string[] craftedMods { get; set; }
        }

        public class Extended
        {
            public float dps { get; set; }
            public float pdps { get; set; }
            public float edps { get; set; }
            public bool dps_aug { get; set; }
            public bool pdps_aug { get; set; }
            public Mods mods { get; set; }
            public Hashes hashes { get; set; }
            public string text { get; set; }
            public string baseType { get; set; }
            public string category { get; set; }
            public string[] subcategories { get; set; }
            public int prefixes { get; set; }
            public int suffixes { get; set; }
        }

        public class Mods
        {
            public Explicit[] _explicit { get; set; }
            public Crafted[] crafted { get; set; }
        }

        public class Explicit
        {
            public string name { get; set; }
            public string tier { get; set; }
            public Magnitude[] magnitudes { get; set; }
        }

        public class Magnitude
        {
            public string hash { get; set; }
            public int min { get; set; }
            public int max { get; set; }
        }

        public class Crafted
        {
            public string name { get; set; }
            public string tier { get; set; }
            public Magnitude1[] magnitudes { get; set; }
        }

        public class Magnitude1
        {
            public string hash { get; set; }
            public int min { get; set; }
            public int max { get; set; }
        }

        public class Hashes
        {
            public object[][] _explicit { get; set; }
            public object[][] crafted { get; set; }
        }

        public class Influences
        {
            public bool shaper { get; set; }
        }

        public class Socket
        {
            public int group { get; set; }
            public string attr { get; set; }
            public string sColour { get; set; }
        }

        public class Property1
        {
            public string name { get; set; }
            public object[][] values { get; set; }
            public int displayMode { get; set; }
            public int type { get; set; }
        }

        public class Requirement
        {
            public string name { get; set; }
            public object[][] values { get; set; }
            public int displayMode { get; set; }
        }
    }
}
