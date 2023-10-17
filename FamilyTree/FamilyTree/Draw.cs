using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree;

public class Draw
{
    static void Tree(StringBuilder tree, DirectoryInfo dir, string indent, bool lastdir)
    {
        tree.Append(indent);
        if (lastdir)
        {
            tree.Append("└─");
            indent += "  ";
        }
        else
        {
            tree.Append("├─");
            indent += "│ ";
        }

        tree.Append($"{dir.Name}\n");

        FileInfo[] subfiles = dir.GetFiles();
        for (int i = 0; i < subfiles.Length; i++)
        {
            if (i == subfiles.Length - 1)
            {
                tree.Append($"{indent}└─{subfiles[i].Name}\n");
            }
            else
            {
                tree.Append($"{indent}├─{subfiles[i].Name}\n");
            }
        }

        DirectoryInfo[] subDirects = dir.GetDirectories();
        for (int i = 0; i < subDirects.Length; i++)
            Tree(tree, subDirects[i], indent, i == subDirects.Length - 1);
    }

    static void TreeDraw(DirectoryInfo dir, int page)
    {
        StringBuilder tree = new StringBuilder();
        Tree(tree, dir, "", true);
        DrawWindow(0, 0, WINDOW_WIDTH, 18);
        (int currentLeft, int currentTop) = GetCursorPos();
        int pagelines = 16;

        string[] lines = tree.ToString().Split('\n');
        int pageTotal = (lines.Length + pagelines - 1) / pagelines;
        if (page > pageTotal)
            page = pageTotal;

        for (int i = (page - 1) * pagelines, count = 0; i < page * pagelines; i++, count++)
        {
            if (lines.Length - 1 > i)
            {
                Console.SetCursorPosition(currentLeft + 1, currentTop + 1 + count);
                Console.WriteLine(lines[i]);
            }
        }

    }
}
