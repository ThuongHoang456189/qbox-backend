using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace QBox.DirectoryDescription
{
    // Hien thuc thanh dang singleton, nhung tam thoi dung static class
    public static class DirectoryDescriptor
    {
        public static DynatreeItem GetDynatreeDescriptor(FileSystemInfo fileInfo)
        {
            DynatreeItem dynatreeItem = new DynatreeItem();

            dynatreeItem.Title = fileInfo.Name;
            dynatreeItem.Children = new List<DynatreeItem>();

            if (fileInfo.Attributes == FileAttributes.Directory)
            {
                dynatreeItem.IsFolder = true;
                foreach (FileSystemInfo file in (fileInfo as DirectoryInfo).GetFileSystemInfos())
                {
                    dynatreeItem.Children.Add(DirectoryDescriptor.GetDynatreeDescriptor(file));
                }
            }
            else
            {
                dynatreeItem.IsFolder = false;
            }

            return dynatreeItem;
        }

        public static string ConvertDynatreeToJson(DynatreeItem DirectoryTree)
        {
            return JsonConvert.SerializeObject(DirectoryTree, Formatting.Indented);
        }
    }
}
