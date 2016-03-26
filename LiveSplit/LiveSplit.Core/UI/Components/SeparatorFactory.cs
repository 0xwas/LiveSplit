﻿using System;

namespace LiveSplit.UI.Components
{
    public class SeparatorFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Separator"; }
        }

        public string Description
        {
            get { return "部品ごとの区切り線を表示"; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Other; }
        }

        public IComponent Create(Model.LiveSplitState state)
        {
            return new SeparatorComponent();
        }

        public string UpdateName
        {
            get { throw new NotSupportedException(); }
        }

        public string XMLURL
        {
            get { throw new NotSupportedException(); }
        }

        public string UpdateURL
        {
            get { throw new NotSupportedException(); }
        }

        public Version Version
        {
            get { throw new NotSupportedException(); }
        }
    }
}
