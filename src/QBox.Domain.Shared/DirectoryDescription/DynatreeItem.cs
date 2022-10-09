
using System.Collections.Generic;

namespace QBox.DirectoryDescription
{
    public class DynatreeItem
    {
        public string Title { get; set; }

        public bool IsFolder { get; set; }

        public string Key { get; set; }

        public List<DynatreeItem> Children { get; set; }

    }
}
