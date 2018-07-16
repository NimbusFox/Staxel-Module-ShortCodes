using System.Collections.Generic;

namespace NimbusFox.Module.ShortCodes {
    public class DictionaryData {
        public string SubVariantKey { get; set; }
        public List<DictionaryData> SubVariants { get; set; }
        public Dictionary<string, string> Variants { get; set; }

        public DictionaryData() {
            Variants = new Dictionary<string, string>();
            SubVariants = new List<DictionaryData>();
        }
    }
}
