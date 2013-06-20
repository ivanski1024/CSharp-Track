using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    class Folder
    {
        public Folder(string name, File[] files, Folder[] childFolders)
        {
            this.Name = name;
            this.Files = files;
            this.ChildFolders = childFolders;
        }
        public Folder(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public File[] Files { get; set; }
        public Folder[] ChildFolders { get; set; }

        public long Size()
        {
            long size = 0;
            foreach (var file in this.Files)
            {
                size += file.Size;
            }
            foreach (var folder in this.ChildFolders)
            {
                if (folder != null)
                {
                    size += folder.Size();
                }
            }
            return size;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(this.Name);
            foreach (var childFolder in this.ChildFolders)
            {
                if (childFolder != null)
                {
                    output.AppendLine(childFolder.ToString());
                }
            }
            foreach (var file in this.Files)
            {
                output.AppendLine(file.Name);
            }

            return output.ToString();
        }
    }
}
