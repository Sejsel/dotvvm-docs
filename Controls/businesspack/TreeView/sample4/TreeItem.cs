using System.Collections.Generic;

namespace DotvvmWeb.Views.Docs.Controls.businesspack.TreeView.sample4
{
    public class TreeItem
    {
        public string Name { get; set; }
        public bool HasItems => Items?.Count > 0;
        public List<TreeItem> Items { get; set; } = new List<TreeItem>();
        public bool IsExpanded { get; set; }
    }
}