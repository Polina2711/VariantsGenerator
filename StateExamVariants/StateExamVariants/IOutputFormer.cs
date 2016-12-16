using System;
using System.Collections.Generic;
using System.Windows;

namespace StateExamVariants
{
    public interface IOutputFormer
    {
        event Func<int, List<string[]>> GetValueFromDict;
        List<UIElement> FormOutputText(int taskid);
    }
}