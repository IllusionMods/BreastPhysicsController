﻿using System.Linq;

namespace BreastPhysicsController.UI.Parts
{
    public class CoordinateSelect : SelectList
    {
        private ChaFileDefine.CoordinateType[] _coordinateType;

        public CoordinateSelect(string[] list, ChaFileDefine.CoordinateType[] coordinateType, string emptyString, float buttonWidth = 0, float buttonHeight = 0, float listWidth = 0, float listHeight = 0)
            : base(list, emptyString, false, buttonWidth, buttonHeight, listWidth, listHeight)
        {
            _coordinateType = coordinateType;
        }

        public void SetList(string[] list, ChaFileDefine.CoordinateType[] coordinateType)
        {
            _list = list;
            _coordinateType = coordinateType;
            changed = true;
            _selectedIndex = 0;
        }

        public ChaFileDefine.CoordinateType GetSelectedCoordinate()
        {
            if (_coordinateType != null && _selectedIndex < _coordinateType.Length)
            {
                return _coordinateType[_selectedIndex];
            }
            return 0;
        }

        public void Select(ChaFileDefine.CoordinateType coordinate)
        {
            for (int i = 0; i < _coordinateType.Count(); i++)
            {
                if (_coordinateType[i] == coordinate)
                {
                    _selectedIndex = i;
                    return;
                }
            }
        }

        public void Select(int index)
        {
            if (index < _coordinateType.Count()) _selectedIndex = index;
        }
    }
}
