using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftTwat
{
    public class PathItem
    {
        private string selectedPath;

        public string Path { get; set; }
        public string Alias { get; set; }

        public PathItem(string path, string alias)
        {
            Path = path;
            Alias = alias;
        }

        public PathItem(string selectedPath)
        {
            this.selectedPath = selectedPath;
        }

        public override string ToString()
        {
            return Alias;
        }
    }
}
