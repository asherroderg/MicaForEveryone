﻿using System.ComponentModel;
using System.Windows.Input;

using MicaForEveryone.Models;

namespace MicaForEveryone.UI.ViewModels
{
    public interface IRuleSettingsViewModel : INotifyPropertyChanged
    {
        BackdropType BackdropType { get; set; }
        TitlebarColorMode TitlebarColor { get; set; }
        bool ExtendFrameIntoClientArea { get; set; }

        ISettingsViewModel ParentViewModel { get; set; }

        void InitializeData(object data);
        object Rule { get; }
    }
}